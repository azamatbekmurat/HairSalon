using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using HairSalon.Models;

namespace HairSalon.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
          List<Stylist> allStylists = Stylist.GetAll();
          return View(allStylists);
        }

        [HttpGet("/stylist/new")]
        public ActionResult StylistForm()
        {
          return View("Stylist");
        }

        [HttpPost("/stylist/add")]
        public ActionResult AddStylist()
        {
          string name = Request.Form["name"];
          Stylist newStylist = new Stylist(name, 0);
          newStylist.Save();
          return RedirectToAction("Index");
        }

        [HttpGet("/stylist/{id}")]
        public ActionResult StylistDetails(int id)
        {
            return View(Stylist.Find(id));
        }

    }
}
