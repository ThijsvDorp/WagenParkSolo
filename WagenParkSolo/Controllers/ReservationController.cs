﻿using System;
using System.Web.Mvc;
using WagenParkSolo.Models;

namespace WagenParkSolo.Controllers
{
    [Authorize(Roles ="User,Admin,Employee")]
    public class ReservationController : Controller
    {
        WagenparkEntities db = new WagenparkEntities();
        // GET: Reservation
        public ActionResult Index()
        {
            return View(db.spSelectReservations(this.User.Identity.Name));
        }
        public ActionResult Reserve(int id, Reservations model)
        {
           Auto reservation = db.Autoes.Find(id);
            model.Autonummer = id;
            model.Merk = reservation.Merk;
            model.Kenteken = reservation.Kenteken;
            model.Model = reservation.Model;
            model.Kostperdag = reservation.Kostperdag;
            return View(model);
        }
        [HttpPost]
        public ActionResult Reserve(Reservations model, FormCollection collection, int id)
        {

                //Maak een nieuwe factuurregel aan, met de gegevens die je van de frondend hebt gekregen!
                Factuurregel reservations = new Factuurregel();
                reservations.Van = Convert.ToDateTime(Request.Form["Van"]);
                reservations.Tot = Convert.ToDateTime(Request.Form["Tot"]);
                reservations.Autonummer = id;

                //Maak een nieuwe factuur, en vul deze met gegevens!
                Factuur factuur = new Factuur();
                factuur.Klantnummer = this.User.Identity.Name;
                factuur.Factuurdatum = DateTime.Now;
                factuur.Factuurregels.Add(reservations);
                db.Factuurs.Add(factuur);
                db.SaveChanges();
                return RedirectToAction("Index");
        }
    }
}