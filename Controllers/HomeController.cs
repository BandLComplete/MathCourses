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
		
		public IActionResult Course(string name)
		{
			var course = _courses.FirstOrDefault(c => c.Name == name);
			if (course == null) return RedirectToRoute(new {controller = "Home", action = "Login"});
			return View(course);
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
				CurrentUser = new User(dbUser);
				return RedirectToRoute(new { controller="Home", action="Index"});
			}
			return View();
		}
		
		public IActionResult RegistrationForm()
		{
			return View(new RegistrationModel());
		}
		
		public IActionResult Registration(string firstName, string secondName, string email, string password, string[] current, string[] desired)
		{
			var dto = new UserDto
			{
				Email = email, Password = password, FirstName = firstName, SecondName = secondName, 
				CurrentCompetences = current.CompetencesToString(),
				DesiredCompetences = desired.CompetencesToString()
			};
			_dbContext.Users.Add(dto);
			try
			{
				_dbContext.SaveChanges();
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
				return View(false);
			}
			
			CurrentUser = new User(dto);
			return View(true);
		}
	}
}