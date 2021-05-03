using InProcess.Models;
using Microsoft.EntityFrameworkCore;

namespace InProcess.Data
{
	public class ApplicationDbContext : DbContext
	{
		public DbSet<User> Users { get; set; }
		public DbSet<CourseDto> Courses { get; set; }
        
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Data Source=mathcoursesserver.database.windows.net;Initial Catalog=MathCoursesDB;User ID=bandl;Password=DayZstandalone200;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
			//optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
			//optionsBuilder.UseSqlServer(@"Data Source=MathCourses.mssql.somee.com;Initial Catalog=MathCourses;User ID=BandLComplete_SQLLogin_1;Password=********;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
		}
	}
}