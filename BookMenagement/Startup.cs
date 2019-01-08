using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookMenagement.DAL.DBContext;
using BookMenagement.DAL.Interfaces;
using BookMenagement.DAL.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using BookMenagement.BLL;
using BookMenagement.Bll.Interfaces;

namespace BookMenagement
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
            //repositories
            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
            //services
            services.AddTransient<IBookCategoryService, BookCategoryService>();
            

            services.AddMvc();
            var connection = @"Server=.\\;Initial Catalog=BookMenagement;Integrated Security=True;Trusted_Connection=True";
            services.AddDbContext<BookMenagementContext>();
            //(options => options.UseSqlServer(connection));
            services.AddCors();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(builder => builder
                                     .AllowAnyOrigin()
                                     .AllowAnyMethod()
                                     .AllowAnyHeader()
                                     .AllowCredentials());
            app.UseMvc();

        }
    }
}
