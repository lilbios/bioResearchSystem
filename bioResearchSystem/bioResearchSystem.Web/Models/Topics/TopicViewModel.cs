﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bioResearchSystem.Web.Models.Topics
{
    public class TopicViewModel
    {

        public Guid Id { get; set; }
        [Required(ErrorMessage = "title is reqired field")]
        [MinLength(3,ErrorMessage = "title cannot be less than 3 characters")]
        [MaxLength(15, ErrorMessage = "title cannot be long than 15 characters")]
        public string TopicName { get; set; }

        public byte[] TopicPicture { get; set; }

        public string ConvertedImage { get; set; }
        public IFormFile Image { get; set; }

    }
}
