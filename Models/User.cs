using System.Collections.Generic;
using System.Linq;

namespace InProcess.Models
{
	public class User
	{
		public readonly string Email;
		public readonly string Password;
		public readonly string FirstName;
		public readonly string SecondName;
		public readonly string[] CurrentCompetences;
		public readonly string[] DesiredCompetences;
		public readonly HashSet<string> Courses;
		
		public User(UserDto dto)
		{
			Password = dto.Password;
			Email = dto.Email;
			FirstName = dto.FirstName;
			SecondName = dto.SecondName;
			CurrentCompetences = dto.CurrentCompetences.SplitArray();
			DesiredCompetences = dto.DesiredCompetences.SplitArray();
			Courses = dto.Courses.SplitArray().ToHashSet();
		}

		public UserDto ToDto()
		{
			return new UserDto
			{
				Email = Email, Password = Password, FirstName = FirstName, SecondName = SecondName,
				CurrentCompetences = CurrentCompetences.EnumerableToString(),
				DesiredCompetences = DesiredCompetences.EnumerableToString(),
				Courses = Courses.EnumerableToString()
			};
		}
	}
}