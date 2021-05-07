using System;
using System.Collections.Generic;
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
		public static readonly HashSet<string> Competences = new HashSet<string>();

		public HomeController(ApplicationDbContext dbContext)
		{
			_dbContext = dbContext;
			_courses = dbContext.Courses.Select(dto => new Course(dto)).ToArray();
			foreach (var course in _courses)
			{
				foreach (var competence in course.Competences)
				{
					Competences.Add(competence);
				}
			}
		}
		
		public IActionResult Index(string[] competences, bool[] practice, Complexity[] complexities, Format[] formats, bool[] free, int min, int max, string name)
		{
			Course[] courses;
			if (string.IsNullOrEmpty(name))
			{
				courses = _courses.Where(c => competences.ContainsOrEmpty(c.Competences) &&
				                              practice.ContainsOrEmpty(c.Practice) &&
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
			return View(new IndexViewModel(courses, competences, practice, complexities, formats, free, min, max));
		}
		
		public IActionResult Course(string name, CourseAction courseAction)
		{
			var course = _courses.FirstOrDefault(c => c.Name == name);
			if (course == null) return RedirectToRoute(new {controller = "Home", action = "Index"});
			if (CurrentUser == null) return View(course);
			switch (courseAction)
			{
				case CourseAction.Add:
					CurrentUser.Courses.Add(name);
					break;
				case CourseAction.Remove:
					if (CurrentUser.Courses.Contains(name))
						CurrentUser.Courses.Remove(name);
					break;
				case CourseAction.None:
					return View(course);
			}

			_dbContext.Users.Update(CurrentUser.ToDto());
			_dbContext.SaveChanges();
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
			var userDto = _dbContext.Users.Find(email);
			if (userDto != null && userDto.Password == password)
			{
				CurrentUser = new User(userDto);
				return RedirectToRoute(new { controller="Home", action="Index"});
			}
			return View();
		}
		
		public IActionResult RegistrationForm()
		{
			return View(Competences);
		}
		
		public IActionResult Registration(string firstName, string secondName, string email, string password, string[] current, string[] desired)
		{
			var userDto = new UserDto
			{
				Email = email, Password = password, FirstName = firstName, SecondName = secondName, 
				CurrentCompetences = current.EnumerableToString(),
				DesiredCompetences = desired.EnumerableToString()
			};
			_dbContext.Users.Add(userDto);
			try
			{
				_dbContext.SaveChanges();
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
				return View(false);
			}
			
			CurrentUser = new User(userDto);
			return View(true);
		}
		
		public IActionResult ProfileEdit(string firstName, string secondName, string password, string[] current, string[] desired)
		{
			if (CurrentUser == null) return RedirectToRoute(new {controller = "Home", action = "Index"});
			if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(secondName) || string.IsNullOrEmpty(password))
			{
				return View(CurrentUser);
			}

			var dto = new UserDto
			{
				Email = CurrentUser.Email, Password = password, FirstName = firstName, SecondName = secondName, 
				CurrentCompetences = current.EnumerableToString(),
				DesiredCompetences = desired.EnumerableToString()
			};
			_dbContext.Users.Update(dto);
			try
			{
				_dbContext.SaveChanges();
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
				return View(CurrentUser);
			}
			
			CurrentUser = new User(dto);
			return View(CurrentUser);
		}
	}
}