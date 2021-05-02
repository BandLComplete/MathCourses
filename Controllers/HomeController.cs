using System;
using System.Linq;
using InProcess.Data;
using Microsoft.AspNetCore.Mvc;
using InProcess.Models;

namespace InProcess.Controllers
{
	public class HomeController : Controller
	{
		public static User CurrentUser { get; private set; }
		private readonly ApplicationDbContext _dbContext;
		private readonly Course[] _courses;

		public HomeController(ApplicationDbContext dbContext)
		{
			_dbContext = dbContext;
			_courses = dbContext.Courses.Select(dto => new Course(dto)).ToArray();
		}
		
		public IActionResult Index(bool[] practice, Complexity[] complexities, Format[] formats, bool[] free, int min, int max, string name)
		{
			Course[] courses;
			if (string.IsNullOrEmpty(name))
			{
				courses = _courses.Where(c => practice.ContainsOrEmpty(c.Practice) &&
				                              complexities.ContainsOrEmpty(c.Complexity) &&
				                              formats.ContainsOrEmpty(c.Format) &&
				                              free.ContainsOrEmpty(c.Free) &&
				                              min <= c.Length && (c.Length <= max || max == 0))
					.ToArray();
			}
			else
			{
				courses = _courses.
					Where(c => c.Name.StartsWith(name, StringComparison.OrdinalIgnoreCase)).
					ToArray();
			}
			return View(new IndexViewModel(courses, practice, complexities, formats, free, min, max));
		}

		public IActionResult Profile()
		{
			if (CurrentUser == null) 
				return RedirectToRoute(new {controller = "Home", action = "Login"});
			return View(CurrentUser);
		}
		
		public IActionResult Login(string email, string password)
		{
			var dbUser = _dbContext.Users.Find(email);
			if (dbUser != null && dbUser.Password == password)
			{
				CurrentUser = dbUser;
				return RedirectToRoute(new { controller="Home", action="Index"});
			}
			return View();
		}
		
		public IActionResult RegistrationForm()
		{
			return View(new RegistrationModel());
		}
		
		public IActionResult Registration(string firstName, string secondName, string email, string password, string[] current, string[] desired, string[] themes)
		{
			CurrentUser = new User {Email = email, Password = password, FirstName = firstName, SecondName = secondName};
			_dbContext.Users.Add(CurrentUser);
			_dbContext.SaveChanges();
			return View(true);
		}
	}
}