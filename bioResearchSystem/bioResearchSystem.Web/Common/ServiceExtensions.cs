﻿using bioResearchSystem.DAL.Implementations;
using bioResearchSystem.DAL.Infrastructure;
using bioResearchSystem.DAL.Repositories;
using bioResearchSystem.Models.Interfaces.DataAccess;
using bioResearchSystem.Models.Repositories;
using bioResearchSystem.ВLL.DomainModels.DeviceModule;
using bioResearchSystem.ВLL.Services;
using bioResearchSystem.ВLL.Services.Accounts;
using bioResearchSystem.ВLL.Services.DatabaseManager;
using bioResearchSystem.ВLL.Services.Devices;
using bioResearchSystem.ВLL.Services.Experiments;
using bioResearchSystem.ВLL.Services.Objectives;
using bioResearchSystem.ВLL.Services.Researches;
using bioResearchSystem.ВLL.Services.Tags;
using bioResearchSystem.ВLL.Services.Topics;
using bioResearchSystem.ВLL.Services.Wallets;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace bioResearchSystem.Web.Common
{
    public static  class ServiceExtensions
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services, IConfiguration configuration)
        {
            if (configuration == null)
            {
                throw new ArgumentNullException(nameof(configuration));
            }
            services.AddTransient<IDbMaster, DbMaster>();
            services.AddTransient<IRepositoryUser,UserRepository>();
            services.AddTransient<IRepositoryResearch,ResearchRepository>();
            services.AddTransient<IRepositoryObjective,ObjectiveRepository>();
            services.AddTransient<IRepositoryTag, TagRepository>();
            services.AddTransient<IRepositoryDevice, DeviceRepository>();
            services.AddTransient<IRepositoryTagResearch,TagResearchRepository>();
            services.AddTransient<IWalletRepository, WalletRepository>();
            services.AddTransient<IRepositoryTopic, TopicRepository>();
            services.AddTransient<IRepositoryContract, ContractRepository>();
            services.AddTransient<IRepositoryExperiment, ExperimentRepository>();



            services.AddScoped<IAccountService, AccountService>();
            services.AddTransient<IDatabaseManagerService, DatabaseManagerService>();
            services.AddTransient<IResearchService, ResearchService>();
            services.AddTransient<IDeviceService, DeviceService>();
            services.AddTransient<IExperimentService, ExperimentService>();
            services.AddTransient<IObjectiveService, ObjectiveService>();
            services.AddTransient<ITagService, TagService>();
            services.AddTransient<IWalletService, WalletService>();
            services.AddTransient<ITopicService, TopicService>();
            services.AddTransient<IBaseDevice,DnaSequencer>();
          

            return services;
        }
    }
}
