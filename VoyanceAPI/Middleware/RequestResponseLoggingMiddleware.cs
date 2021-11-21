using Commun.Enums;
using DataAccessLayer.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using StarterKitAPI.Services;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace DotnetApplication.Api
{
    public class HttpRequestBodyMiddleware
    {
        private readonly ILogger logger;
        private readonly RequestDelegate next;

        public HttpRequestBodyMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task Invoke(HttpContext context, ILogService logService)
        {
            context.Request.EnableBuffering();

            var reader = new StreamReader(context.Request.Body);

            string body = await reader.ReadToEndAsync();

            logService.CreateLog(SeverityEnum.INFORMATION, body, $"Request {context.Request?.Method}: {context.Request?.Path.Value}\n{body}");

            context.Request.Body.Position = 0L;

            await next(context);
        }
    }
}