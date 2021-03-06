<<<<<<< HEAD
﻿using Microsoft.AspNetCore.Builder;
=======
using Microsoft.AspNetCore.Builder;
>>>>>>> 079066216a5086b0181f007ae290835d96b6fff9
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
<<<<<<< HEAD
using Microsoft.EntityFrameworkCore;
using FullStackDeveloperAssessment.Data;
=======
>>>>>>> 079066216a5086b0181f007ae290835d96b6fff9

namespace FullStackDeveloperAssessment
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
            services.AddControllers();
<<<<<<< HEAD

            services.AddDbContext<FullStackDeveloperAssessmentContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("FullStackDeveloperAssessmentContext")));
=======
>>>>>>> 079066216a5086b0181f007ae290835d96b6fff9
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
