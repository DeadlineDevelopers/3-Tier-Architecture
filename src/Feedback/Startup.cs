﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Feedback.Core.Helpers;
using Feedback.Data.Helpers;
using Feedback.Core.Repositories;
using Feedback.Data.Repositories;
using Feedback.Core.Services;
using Feedback.Infrastructure.Services;

namespace Feedback
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddMvc();

            services.AddSingleton<IDatabaseHelper, DapperHelper>();
            //Users
            services.AddTransient<IUsersRepository, UsersRepository>();
            services.AddTransient<IUsersService, UsersService>();
            //Companies
            services.AddTransient<ICompaniesRepository, CompaniesRepository>();
            services.AddTransient<ICompaniesService, CompaniesService>();
            //Entites
            services.AddTransient<IEntitiesRepository, EntitiesRepository>();
            services.AddTransient<IEntitiesService, EntitiesService>();
            //Branches
            services.AddTransient<IBranchesRepository, BranchesRepository>();
            services.AddTransient<IBranchesService, BranchesService>();
            //Surveys
            services.AddTransient<ISurveysRepository, SurveysRepository>();
            services.AddTransient<ISurveysService, SurveysService>();
            //NFCTags
            services.AddTransient<INFCTagsRepository, NFCTagsRepository>();
            services.AddTransient<INFCTagsService, NFCTagsService>();
            //SurveyQuestions
            services.AddTransient<ISurveyQuestionsRepository, SurveyQuestionsRepository>();
            services.AddTransient<ISurveyQuestionsService, SurveyQuestionsService>();
            //SurveyChoices
            services.AddTransient<ISurveyChoicesRepository, SurveyChoicesRepository>();
            services.AddTransient<ISurveyChoicesService, SurveyChoicesService>();
            //SurveyAnswers
            services.AddTransient<ISurveyAnswersRepository, SurveyAnswersRepository>();
            services.AddTransient<ISurveyAnswersService, SurveyAnswersService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            app.UseMvc();
        }
    }
}
