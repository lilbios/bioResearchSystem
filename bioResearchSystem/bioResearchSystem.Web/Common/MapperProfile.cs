﻿using AutoMapper;
using bioResearchSystem.Models.Entities;
using bioResearchSystem.Web.Models.Accounts;
using bioResearchSystem.Web.Models.Experiments;
using bioResearchSystem.Web.Models.Researсhes;
using bioResearchSystem.Web.Models.Topics;
using bioResearchSystem.Web.Models.Users;
using bioResearchSystem.ВLL.Services.Accounts;
using bioResearchSystem.ВLL.Services.Researches;
using bioResearchSystem.ВLL.Services.Topics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bioResearchSystem.Web.Common
{
    public class MapperProfile:Profile
    {
        public MapperProfile()
        {
            CreateMap<LoginViewModel, UserDTO>().ReverseMap();
            CreateMap<RegisterViewModel, UserDTO>().ReverseMap();
            CreateMap<UserDTO, AppUser>().ReverseMap();
            CreateMap<TopicViewModel, TopicDTO>().ReverseMap();
            CreateMap<TopicDTO, Topic>().ReverseMap();
            CreateMap<LoginedUserViewModel, UserDTO>().ReverseMap();
            CreateMap<UserDTO,AppUser>().ReverseMap();
            CreateMap<AppUser, ProfileViewModel>().ReverseMap();
            CreateMap<UserDTO, ProfileViewModel>().ReverseMap();
            CreateMap<ResearchDTO, ResearchViewModel>().ReverseMap();
            CreateMap<ResearchDTO, Research>().ReverseMap();
            CreateMap<ResearchModel, Research>().ReverseMap();
            CreateMap<ExperimentModel, Experimet>().ReverseMap();
            CreateMap<ExperimentProcess, Experimet>().ReverseMap();
            CreateMap<ExperimentModel, Experimet>().ReverseMap();
           



        }
    }
}
