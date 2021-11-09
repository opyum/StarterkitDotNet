using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using StarterKitAPI.Profile;
using Microsoft.Identity.Web;
using DataAccessLayer.Context;
using Microsoft.EntityFrameworkCore;

namespace StarterKitAPI
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
            services.AddMvc();

            //services.AddDbContext<SqliteContext>(options =>
            // options.UseSqlite(Configuration.GetConnectionString("CnxString")));
            services.AddEntityFrameworkSqlite().AddDbContext<SqliteContext>(options =>
                options.UseSqlite(Configuration.GetConnectionString("bdd")));
            services.AddAutoMapper(typeof(PersonneProfile));

            //var serviceProvider = services.BuildServiceProvider();
            //this.applicationService = serviceProvider.GetService<IApplicationService>();
            Injection.Injection.SetInjection(services);
            services.AddSwaggerGen();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            //app.UseRequestResponseLogging();

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.)
            app.UseSwaggerUI();
            app.UseHttpsRedirection();

            app.UseRouting();
            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetRequiredService<SqliteContext>();
                context.Database.EnsureCreated();
            }
            //app.UseAuthentication();
            //app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
