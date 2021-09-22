using Microsoft.Extensions.DependencyInjection;
using Voyance.Business;
using Voyance.Models;

namespace Voyance.Injection
{
    public static class Injection
    {
        public static void SetInjection(IServiceCollection services)
        {
            services.AddTransient<IApiService, ApiService>();

            services.AddTransient<IUserBusiness, UserBusiness>();

        }
    }
}
