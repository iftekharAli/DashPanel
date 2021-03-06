﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DashPanel.Models;

namespace DashPanel.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Login lg)
        {
            if (lg.UserName.ToUpper() == "ADMIN" && lg.Password == "1234!@#$")
            {
                Session["Uid"] = lg.UserName;

                return RedirectToAction("DashPanel", "ServiceRanking");
            }
            else
            {
                ModelState.AddModelError("", @"Invalid user Name/Password");
                return View(lg);

            }
          

        }
        public ActionResult Logout()
        {
            Session["Uid"] = null;
            return RedirectToAction("Index", "Login");
        }


    }
}