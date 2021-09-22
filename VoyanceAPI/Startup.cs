using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using VoyanceApi.Profile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VoyanceApi.Injection;
using DataAccessLayer.UnifOfWork;
using VoyanceApi.Services;
using DataAccessLayer.Context;
using Microsoft.EntityFrameworkCore;
using VoyanceApi.Middleware;
using Microsoft.Identity.Web;
using Microsoft.AspNetCore.Http;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using AutoMapper;

namespace VoyanceApi
{
    public class Startup
    {

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            JwtSecurityTokenHandler.DefaultInboundClaimTypeMap.Clear();

            services.AddMicrosoftIdentityWebApiAuthentication(Configuration);
            services.AddHttpContextAccessor();
            services.AddControllers(options =>
            {
                var policy = new AuthorizationPolicyBuilder()
                    .RequireAuthenticatedUser()
                    .Build();
                options.Filters.Add(new AuthorizeFilter(policy));
            });

            services.AddDbContext<VoyanceContext>(options =>
             options.UseSqlServer("Data Source=.;Initial Catalog=Voyance;Integrated Security=True"));

            services.AddAutoMapper(typeof(UserProfile));

            //var serviceProvider = services.BuildServiceProvider();
            //this.applicationService = serviceProvider.GetService<IApplicationService>();
            Injection.Injection.SetInjection(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseRequestResponseLogging();
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();
            //app.Use(async (context, next) =>
            //{
            //    if (!context.User.Identity?.IsAuthenticated ?? false)
            //    {
            //        context.Response.StatusCode = 401;
            //        await context.Response.WriteAsync("Not Authenticated");
            //    }
            //    else await next();

            //});
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
