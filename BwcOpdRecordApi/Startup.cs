﻿using BwcOpdRecordApi.Data;
using BwcOpdRecordApi.Data.Interfaces.Repositories;
using BwcOpdRecordApi.Data.Interfaces.Services;
using BwcOpdRecordApi.Data.Repositories;
using BwcOpdRecordApi.Data.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BwcOpdRecordApi
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
            // set value connection string
            var config = new ConnectionStrings();
            Configuration.Bind("ConnectionStrings", config);
            services.AddSingleton(config);

            // repositories
            services.AddTransient<IObservationRepository, ObservationRepository>();
            services.AddTransient<IQuestionnaireRepository, QuestionnaireRepository>();
            services.AddTransient<IPatientAdmissionRepository, PatientAdmissionRepository>();

            // services
            services.AddTransient<IVitalSignsService, VitalSignsService>();
            services.AddTransient<IPhysicalExamService, PhysicalExamService>();
            services.AddTransient<IDietService, DietService>();
            services.AddTransient<IExerciseService, ExerciseService>();
            services.AddTransient<ITreatmentService, TreatmentService>();
            services.AddTransient<IEprService, EprService>();
            services.AddTransient<IPatientInfoService, PatientInfoService>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddCors();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            // use cors
            app.UseCors(builder => builder
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader()
                .AllowCredentials());

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
