using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using web.Models;

namespace web.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Information(RegisterModel registerModel)
        {
            ViewData["RegisterModel.txt_CardNo"] = registerModel.txt_CardNo;
            ViewData["RegisterModel.txt_CardID"] = registerModel.txt_CardID;
            ViewData["RegisterModel.txt_BirthDate"] = registerModel.txt_BirthDate;
            return View();
        }

        public IActionResult Success()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
