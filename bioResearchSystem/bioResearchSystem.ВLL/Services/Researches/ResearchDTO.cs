﻿using bioResearchSystem.Models.Entities;
using bioResearchSystem.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace bioResearchSystem.ВLL.Services.Researches
{
    public class ResearchDTO
    {

        public string Title { get; set; }

        public string Description { get; set; }

        [DefaultValue(StatusResearch.NotStarted)]
        public StatusResearch StatusResearch { get; set; }


        public Privacy Privacy { get; set; }


        public DateTime OpenedDate { get; set; } = DateTime.Now;
        public DateTime? ClosedDate { get; set; }

        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }

        public ICollection<Experimet> Experiments { get; set; }
        public ICollection<TagResearch> TagResearches { get; set; }

        public ICollection<Objective> Objectives { get; set; }
    }
}
