﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GEZAP_V2.Areas.Principal.Controllers
{
    [Area("Principal")]
    public class PrincipalController : Controller
    {
        public IActionResult Principal()
        {
            return View();
        }
    }
}
