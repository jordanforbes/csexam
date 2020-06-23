using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using exam.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace exam.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context { get; set; }
        private PasswordHasher<User> regHasher = new PasswordHasher<User>();
        private PasswordHasher<LoginUser> logHasher = new PasswordHasher<LoginUser>();

        public User GetUser()
        {
            return _context.Users.FirstOrDefault(u => u.UserId == HttpContext.Session.GetInt32("userId"));
        }

        public HomeController(MyContext context)
        {
            _context = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            User current = GetUser();
            ViewBag.User = current;
            return View();
        }

        [HttpPost("register")]
        public IActionResult Register(User u)
        {
            if (ModelState.IsValid)
            {
                if (_context.Users.FirstOrDefault(usr => usr.Email == u.Email) != null)
                {
                    ModelState.AddModelError("Email", "Email is already in use, try logging in!");
                    return View("Index");
                }
                string hash = regHasher.HashPassword(u, u.Password);
                u.Password = hash;
                _context.Users.Add(u);
                _context.SaveChanges();
                HttpContext.Session.SetInt32("userId", u.UserId);
                return Redirect("/home");
            }
            return View("Index");
        }

        [HttpPost("login")]
        public IActionResult Login(LoginUser lu)
        {
            if (ModelState.IsValid)
            {
                User userInDB = _context.Users.FirstOrDefault(u => u.Email == lu.LoginEmail);
                if (userInDB == null)
                {
                    ModelState.AddModelError("LoginEmail", "Invalid Email or Password!");
                    return View("Index");
                }
                var result = logHasher.VerifyHashedPassword(lu, userInDB.Password, lu.LoginPassword);
                if (result == 0)
                {
                    ModelState.AddModelError("LoginPassword", "Invalid Email or Password!");
                    return View("Index");
                }
                HttpContext.Session.SetInt32("userId", userInDB.UserId);
                return Redirect("/home");
            }
            return View("Index");
        }
        
        [HttpGet("home")]
        public IActionResult Home()
        {
            User current = GetUser();
            if(current == null)
            {
                return Redirect("/");
            }
            ViewBag.User = current;
            List<Jawn> AllJawns = _context.Jawns.Include(j => j.Organizer)
                                                .Include(j => j.Attendees)
                                                .ThenInclude(gt => gt.JawnGoer)
                                                .Where( j => j.StartTime >= DateTime.Now)
                                                .OrderBy( j => j.StartTime)
                                                .ToList();
                                                
            return View(AllJawns);
        }

        [HttpGet("jawn/new")]
        public IActionResult NewJawn()
        {
            User current = GetUser();
            if(current == null)
            {
                return Redirect("/");
            }
            return View();
        }

        [HttpPost("jawn/create")]
        public IActionResult CreateJawn(Jawn newJawn)
        {
            User current = GetUser();
            if(current == null)
            {
                return Redirect ("/");
            };
            if(ModelState.IsValid)
            {
                newJawn.UserId = current.UserId;
                _context.Jawns.Add(newJawn);
                _context.SaveChanges();
                return RedirectToAction("Home");
            };
            return View("NewJawn");
        }

        [HttpGet("jawn/{jawnId}")]

        public IActionResult DisplayJawn(int jawnId)
        {
            User current = GetUser();
            if (current == null)
            {
                return Redirect ("/");
            }else{
                Console.WriteLine("%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%");
            }
            ViewBag.User = current;
            Console.WriteLine("!!!!!!!!!!!!!!!!!! User: " + ViewBag.User);
            Jawn activity = _context.Jawns
            .Include( j => j.Attendees)
            .ThenInclude( u => u.JawnGoer)
            .Include( j => j.Organizer)
            .FirstOrDefault( j => j.JawnId == jawnId );
            return View(activity);
        }

        [HttpGet("jawn/{jawnId}/{status}")]
        public IActionResult ToggleJawn(int jawnId, string status)
        {
            User current = GetUser();
            if (current == null)
            {
                return Redirect("/");
            }

            
            if(status == "join")
            {
                GetTogether newParty = new GetTogether();
                newParty.UserId = current.UserId;
                newParty.JawnId =jawnId;
                _context.GetTogethers.Add(newParty);
            }
            else if(status == "leave")
            {
                GetTogether flake = _context.GetTogethers
                .FirstOrDefault( g => g.UserId == current.UserId && g.JawnId == jawnId);
                _context.GetTogethers.Remove(flake);
            }
            _context.SaveChanges();
            return RedirectToAction("Home");
        }

        [HttpGet("jawn/{jawnId}/delete")]
        public IActionResult DeleteJawn(int jawnId)
        {
            User current = GetUser();
            if(current == null)
            {
                return Redirect ("/");
            }
            Jawn remove = _context.Jawns.FirstOrDefault( j => j.JawnId == jawnId);
            _context.Jawns.Remove(remove);
            _context.SaveChanges();
            return RedirectToAction("Home");
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

        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return Redirect("/");
        }

    }
}
