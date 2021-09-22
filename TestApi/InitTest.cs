using AutoMapper;
using DataAccessLayer;
using DataAccessLayer.Context;
using DataAccessLayer.UnifOfWork;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using VoyanceApi.Profile;
using VoyanceApi.Services;
using System;
using System.Collections.Generic;
using System.Text;
using UserManagement.Services;

namespace UserManagement.Services.Tests
{
    public class InitTest
    {
        protected ILoginService applicationService;

        public InitTest()
        {

            var services = new ServiceCollection();   
            services.AddDbContext<VoyanceContext>(options =>
             options.UseSqlServer("Data Source=.;Initial Catalog=Voyance;Integrated Security=True"));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddTransient<ILoginService, LoginService>();
            services.AddAutoMapper(typeof(UserProfile));


        }
    }
}
