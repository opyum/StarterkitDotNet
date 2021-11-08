using DataAccessLayer.Context;
using DataAccessLayer.UnifOfWork;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using StarterKitAPI.Profile;
using StarterKitAPI.Services;

namespace ServiceTest
{
    public class InitTest
    {
        public InitTest()
        {
            var services = new ServiceCollection();
            services.AddDbContext<SqliteContext>(options =>
             options.UseSqlite("Data Source=.;Initial Catalog=RmConfig;Integrated Security=True"));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IPersonneService, PersonneService>();
            services.AddAutoMapper(typeof(PersonneProfile));
        }
    }
}
