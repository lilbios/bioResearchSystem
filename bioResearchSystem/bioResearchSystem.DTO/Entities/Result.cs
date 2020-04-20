﻿using System.ComponentModel.DataAnnotations;

namespace bioResearchSystem.DTO.Entities
{
    public class Result : Entity
    {
        [Required]
        public string OrignalResult { get; set; }
        public int ExpetimentId { get; set; }
        public Experiment Experiment  { get; set; }
    }
}
