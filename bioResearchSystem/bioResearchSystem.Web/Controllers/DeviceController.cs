﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace bioResearchSystem.Web.Controllers
{
    public class DeviceController : Controller
    {
        public IActionResult Settings() {
            return View();
        }
    }
}