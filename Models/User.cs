using System.ComponentModel.DataAnnotations;

namespace InProcess.Models
{
	public class User
	{
		[Key]
		public string Email { get; set; }
		public string Password { get; set;  }
		public string FirstName { get; set; }
		public string SecondName { get; set; }
		
	}
}