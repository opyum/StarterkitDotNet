using Commun.Enums;
using Microsoft.Extensions.Configuration;
using Microsoft.Identity.Web;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Voyance.Business
{
    public interface IApiService
    {
        Task<string> CallApi(HttpVerbsEnums verb, string controller, string method, object parameters = null);
    }
    public class ApiService : IApiService
    {
        private readonly IHttpClientFactory _clientFactory;
        private readonly ITokenAcquisition _tokenAcquisition;
        private readonly IConfiguration _configuration;

        public ApiService(IHttpClientFactory clientFactory,
            ITokenAcquisition tokenAcquisition,
            IConfiguration configuration)
        {
            _clientFactory = clientFactory;
            _tokenAcquisition = tokenAcquisition;
            _configuration = configuration;
        }

        private HttpClient setHttpClient()
        {
            HttpClient client = _clientFactory.CreateClient();

            var scope = _configuration["CallApi:ScopeForAccessToken"];
            var accessToken = _tokenAcquisition.GetAccessTokenForUserAsync(new[] { scope }).Result;

            client.BaseAddress = new Uri(_configuration["CallApi:ApiBaseAddress"]);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            return client;
        }

        private string setParam(UrlParameter[] parameters)
        {
            string paramInString = string.Empty;
            if (parameters != null)
            {
                paramInString = "?";
                foreach (var param in parameters)
                {
                    if (paramInString.Length > 1) paramInString += "&";
                    paramInString += param.PropertyName + "=" + param.PropertyValue;
                }
            }
            return paramInString;
        }

        public async Task<string> CallApi(HttpVerbsEnums verb, string controller, string method, object parameters = null)
        {
            try
            {
                HttpClient client = setHttpClient();
                var url = new Uri(Startup.StaticConfig.GetSection("Config")["ApiUrl"] + "/" + controller + "/" + method);
                HttpResponseMessage response = new HttpResponseMessage();
                switch (verb)
                {
                    case HttpVerbsEnums.POST:
                        response = await client.PostAsync(url, parameters, new JsonMediaTypeFormatter());
                        break;
                    case HttpVerbsEnums.GET:
                        response = await client.GetAsync(url + setParam((UrlParameter[])parameters));
                        break;
                    case HttpVerbsEnums.PUT:
                        response = await client.PutAsync(url, parameters, new JsonMediaTypeFormatter());
                        break;
                    case HttpVerbsEnums.DELETE:
                        response = await client.DeleteAsync(url + setParam((UrlParameter[])parameters));
                        break;
                    default:
                        break;
                }

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStringAsync();
                }

                throw new ApplicationException($"Status code: {response.StatusCode}, Error: {response.ReasonPhrase}");
            }
            catch (Exception e)
            {
                throw new ApplicationException($"Exception {e}");
            }
        }
    }
}
