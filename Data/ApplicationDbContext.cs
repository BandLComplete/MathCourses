using InProcess.Models;
using Microsoft.EntityFrameworkCore;

namespace InProcess.Data
{
	public class ApplicationDbContext : DbContext
	{
		public DbSet<UserDto> Users { get; set; }
		public DbSet<CourseDto> Courses { get; set; }
        
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Server=tcp:mathcoursesserver.database.windows.net,1433;Initial Catalog=MathCoursesDB;Persist Security Info=False;User ID=bandl;Password=DayZstandalone200;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
		}
	}
}