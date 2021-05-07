using System.ComponentModel.DataAnnotations;

namespace InProcess.Models
{
	public class UserDto
	{
		[Key]
		public string Email { get; set; }
		public string Password { get; set;  }
		public string FirstName { get; set; }
		public string SecondName { get; set; }
		public string CurrentCompetences { get; set; }
		public string DesiredCompetences { get; set; }
	}
}