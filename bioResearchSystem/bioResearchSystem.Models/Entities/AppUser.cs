﻿using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace bioResearchSystem.Models.Entities
{
    public class AppUser : IdentityUser
    {

        public string Name { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public int Age { get; set; }
        public string Bio { get; set; }

        public Wallet Wallet { get; set; }
        public Gender Gender { get; set; }
        public Roles Role { get; set; }

        public byte[] Photo { get; set; }
        public ICollection<Device> Devices { get; set; }
        public ICollection<Research> Researches { get; set; }
        public ICollection<Contract> Contracts { get; set; }
    }
}
