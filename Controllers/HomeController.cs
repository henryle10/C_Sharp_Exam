using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using C_Sharp_Exam.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

namespace C_Sharp_Exam.Controllers
{
    public class HomeController : Controller
    {
        private MyContext db;
        public HomeController(MyContext context)
        {
            db = context;
        }
        private int? uid
        {
            get
            {
                return HttpContext.Session.GetInt32("UserId");
            }
        }

        //========Login/Register Page========
        [HttpGet("")]
        public IActionResult Index()
        {
            return RedirectToAction("Signin");
        }

        [HttpGet("/signin")]
        public IActionResult Signin()
        {
            return View();
        }

        //=========Dashboard===========

        [HttpGet("/home")]
        public IActionResult Dashboard()
        {
            if (uid == null)
            {
                return RedirectToAction("Index");
            }
            List<Event> allEvents = db.Events.Include(eve => eve.Creator).Include(eve => eve.EventList).OrderBy(eve => eve.Date).ToList();

            ViewBag.User = db.Users.FirstOrDefault(user => user.UserId == uid);
            ViewBag.uid = (int)uid;
            return View(allEvents);
        }

        //=========Add Activity Page==========
        [HttpGet("/new")]
        public IActionResult NewActivityPage()
        {
            return View();
        }

        [HttpPost("/Add_Activity")]
        public IActionResult CreateActivity(Event newEvent)
        {
            if (uid == null)
            {
                return View("Signin");
            }
            var PresentYear = DateTime.Now;
            if (newEvent.Date < PresentYear)
            {
                ModelState.AddModelError("Date", "Date cannot be in the past");
                return View("NewActivityPage");
            }
            if (ModelState.IsValid)
            {
                newEvent.UserId = (int)uid;
                db.Add(newEvent);
                db.SaveChanges();
                return RedirectToAction("ActivityInfo", new { id = newEvent.EventId });
            }
            return View("NewActivityPage");
        }

        //=========Activity Info page============
        [HttpGet("/activity/{id}")]
        public IActionResult ActivityInfo(int id)
        {
            if (uid == null)
            {
                return View("Signin");
            }
            Event SpecificEvent = db.Events.Include(e => e.EventList).ThenInclude(Joinz => Joinz.Attendee).OrderBy(Joinz => Joinz.Date).FirstOrDefault(e => e.EventId == id);

            var now = DateTime.Now;
            if (SpecificEvent.Date < now)
            {
                db.Events.Remove(SpecificEvent);
                db.SaveChanges();
                return View("Dashboard");
            }
            else
            {
                ViewBag.User = db.Users.FirstOrDefault(u => u.UserId == SpecificEvent.UserId);
                ViewBag.uid = (int)uid;
                return View("ActivityInfo", SpecificEvent);
            }
        }

        //========Login/Register Actions========

        [HttpPost("/register")]
        public IActionResult Register(User newUser)
        {
            if (ModelState.IsValid)
            {
                if (db.Users.Any(u => u.Email == newUser.Email))
                {
                    ModelState.AddModelError("Email", "is taken");
                }
            }
            if (ModelState.IsValid == false)
            {
                return View("Signin");
            }

            PasswordHasher<User> hasher = new PasswordHasher<User>();
            newUser.Password = hasher.HashPassword(newUser, newUser.Password);

            newUser.CreatedAt = DateTime.Now;
            newUser.UpdatedAt = DateTime.Now;
            db.Users.Add(newUser);
            db.SaveChanges();

            HttpContext.Session.SetInt32("UserId", newUser.UserId);
            HttpContext.Session.SetString("Name", newUser.Name);
            return RedirectToAction("Dashboard");
        }

        [HttpPost("Login")]
        public IActionResult LoginUser(LoginUser loginUser)
        {
            string errorMsg = "Invalid Email or Password";

            if (ModelState.IsValid == false)
            {
                return View("Signin");
            }

            User dbUser = db.Users.FirstOrDefault(user => user.Email == loginUser.LoginEmail);

            if (dbUser == null)
            {
                ModelState.AddModelError("LoginEmail", errorMsg);
            }
            // user found in db
            else
            {
                PasswordHasher<LoginUser> hasher = new PasswordHasher<LoginUser>();
                PasswordVerificationResult result = hasher.VerifyHashedPassword(loginUser, dbUser.Password, loginUser.LoginPassword);

                if (result == 0)
                {
                    ModelState.AddModelError("LoginEmail", errorMsg);
                }
            }

            if (ModelState.IsValid == false)
            {
                return View("Signin");
            }

            HttpContext.Session.SetInt32("UserId", dbUser.UserId);
            HttpContext.Session.SetString("Name", dbUser.Name);
            return RedirectToAction("Dashboard");
        }

        //=======Actions========

        [HttpGet("Leave/{id}")]
        public IActionResult Leave(int id)
        {
            if (uid == null)
            {
                return View("Signin");
            }
            else
            {
                var joinz = db.Joinzs.FirstOrDefault(e => e.EventId == id && e.UserId == uid);
                db.Joinzs.Remove(joinz);
                db.SaveChanges();
                return RedirectToAction("Dashboard");
            }
        }

        [HttpGet("Join/{id}")]
        public IActionResult Join(int id)
        {
            if (uid == null)
            {
                return View("Signin");
            }
            else
            {
                var joinz = new Joinz((int)uid, id);
                // var SpecificEvent = db.Events.Include(e => e.EventList).ThenInclude(Joinz => Joinz.Attendee).FirstOrDefault(e => e.EventId == id);
                // if (SpecificEvent.Date == joinz.CreatedAt)
                // {
                //     ModelState.AddModelError("Datetime", "Cannot join activites that overlap");
                //     return View("Dashboard");
                // }
                db.Joinzs.Add(joinz);
                db.SaveChanges();
                return RedirectToAction("Dashboard");
            }
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");

        }

        [HttpGet("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            if (uid == null)
            {
                return View("Index");
            }
            else
            {
                Event SpecificEvent = db.Events.FirstOrDefault(eve => eve.EventId == id);
                db.Remove(SpecificEvent);
                db.SaveChanges();
                return RedirectToAction("Dashboard");
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
