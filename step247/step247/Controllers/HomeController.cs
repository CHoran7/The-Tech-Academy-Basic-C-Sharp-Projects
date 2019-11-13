using step247.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace step247.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Quote(string firstName, string lastName, string emailAddress, DateTime dateOfBirth, int carYear, string carMake, string carModel, string hadDUI, int numberOfTickets, string coverage)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress) || string.IsNullOrEmpty(carMake) || string.IsNullOrEmpty(carModel) || string.IsNullOrEmpty(hadDUI) || string.IsNullOrEmpty(coverage))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                var today = DateTime.Today;
                var age = today.Year - dateOfBirth.Year;
                decimal total = 50;
                if (age < 25 && age >= 18)
                {
                    total += 25;
                }
                if (age < 18)
                {
                    total += 25;
                }
                if (age > 100)
                {
                    total += 25;
                }
                if (carYear < 2000)
                {
                    total += 25;
                }
                if (carYear > 2015)
                {
                    total += 25;
                }
                if (carMake == "Porsche")
                {
                    total += 25;
                }
                if (carMake == "Porsche" && carModel == "911 Carrera")
                {
                    total += 25;
                }
                total = total + (10 * numberOfTickets);
                if (hadDUI == "Yes")
                {
                    total = (total * 1.25m);
                }
                if (coverage == "Full Coverage")
                {
                    total = (total * 1.5m);
                }
                using (QuoteDbEntities db = new QuoteDbEntities())
                {
                    var quote = new QuoteTable();
                    quote.FirstName = firstName;
                    quote.LastName = lastName;
                    quote.EmailAddress = emailAddress;
                    quote.DateOfBirth = dateOfBirth;
                    quote.CarYear = carYear;
                    quote.CarMake = carMake;
                    quote.CarModel = carModel;
                    quote.HadDUI = hadDUI;
                    quote.NumberOfTickets = numberOfTickets;
                    quote.Coverage = coverage;
                    quote.Quote1 = total;

                    db.QuoteTables.Add(quote);
                    db.SaveChanges();
                }
                return View("Success");
            }
        }

        public ActionResult Admin()
        {
            using (QuoteDbEntities db = new QuoteDbEntities())
            {
                var quotes = db.QuoteTables;
                var quoteVms = new List<QuoteVm>();
                foreach (var quote in quotes)
                {
                    var quoteVm = new QuoteVm();
                    quoteVm.FirstName = quote.FirstName;
                    quoteVm.LastName = quote.LastName;
                    quoteVm.EmailAddress = quote.EmailAddress;
                    quoteVm.Quote1 = Convert.ToDecimal(quote.Quote1);
                    quoteVms.Add(quoteVm);
                    
                }
                return View(quoteVms);
            }
        }
    }
}