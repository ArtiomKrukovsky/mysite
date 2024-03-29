﻿using AllExpirience.Models;
using mysite.Domain.Interface;
using System.Web.Mvc;

namespace AllExpirience.Controllers
{
    [Authorize]
    public class MainController : Controller
    {

        public ActionResult Home()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult OtherInformation()
        {
            return View();
        }

        public ActionResult AboutMeProgramming()
        {
            return View();
        }

        public ActionResult AboutMeMusic()
        {
            return View();
        }

        public ActionResult AboutMeLiterature()
        {
            return View();
        }

        public ActionResult AboutMeSkills()
        {
            return View();
        }

        private IUnitOfWork context;

        public MainController(IUnitOfWork unitOfWork)
        {
            context = unitOfWork;
        }

        [HttpGet]
        public ActionResult Help()
        {
            SelectList list = new SelectList(context.Countries.GetAll(), "CountryId", "Name");
            ViewBag.countrylist = list;
            return View();
        }

        [HttpPost, ActionName("Help")]
        public ActionResult Help(Help help)
        {
            if (ModelState.IsValid)
            {
                context.Helps.Add(help);
                context.SaveChanges();
                TempData["msg"] = "<script>alert('Your request has been successfully added.'); window.location = '/Main/Home';</script>";
            }
            SelectList list = new SelectList(context.Countries.GetAll(), "CountryId", "Name");
            ViewBag.countrylist = list;
            return View(help);
        }
    }
}