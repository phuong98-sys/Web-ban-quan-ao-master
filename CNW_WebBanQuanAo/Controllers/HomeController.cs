﻿using CNW_WebBanQuanAo.Models;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;

namespace CNW_WebBanQuanAo.Controllers
{
    public class HomeController : Controller
    {
        MyContext context = new MyContext();
        public ActionResult Index()
        {
            //var model = context.MATHANG.Where(x => x.TenMH != null).ToList();
            //return View(model);
            //HttpCookie testCookie = new HttpCookie("testCookie");
            //testCookie.Value = "day la dong thu nhat";
            //Response.Cookies.Add(testCookie);
            //HttpCookie loginCookie = new HttpCookie("LoginCookie");
            //loginCookie["username"] = "day la username";
            //loginCookie["password"] = "ehehehe";

            //Response.Cookies["usernameCookie"].Value = "Day la username";
            //Response.Cookies["passwordCookie"].Value = "Day la username";


            //Response.Write(Request.Cookies["testCookie"].Value + "egggggggggggg" + Request.Cookies["usernameCookie"].Value);
            //Response.Write(Request.Cookies["LoginCookie"]["username"]);
            //Response.Write(Request.Cookies["LoginCookie"]["password"]);
            //Response.Write("Ehehihioaweithoaewthai");


            var model = context.MATHANG.Where(x => x.MaMH != null).ToList();


            return View(model);
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [ChildActionOnly]
        public ActionResult LeftMenu()
        {
            var model = context.NHASANXUAT.ToList();
            return PartialView("~/Views/Shared/_LeftMenu.cshtml", model);
        }
        public ActionResult Detail()
        {
            ViewBag.Message = "Details of a specified product";

            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult TestWebService()
        {
            return View();
        }
    }
}