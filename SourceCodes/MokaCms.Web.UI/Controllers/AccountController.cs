﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MokaCms.Web.UI.Controllers
{
	public class AccountController : Controller
	{
		//
		// GET: /Account/

		public ActionResult Index()
		{
			return View();
		}

		public ActionResult Login()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Login(FormCollection form)
		{
			var username = form["username"];
			var password = form["password"];
			var rememberMe = form["remember-me"] == "on";

			if (username == ConfigurationManager.AppSettings["username"] &&
			    password == ConfigurationManager.AppSettings["password"])
			{
				// Login Sucssesful!
				ViewBag.Authenticated = true;
				ViewBag.Username = username;
			}
			else
			{
				// Login Failure!
				ViewBag.Authenticated = false;
			}

			return View();
		}

	}
}
