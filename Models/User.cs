namespace InProcess.Models
{
	public class User
	{
		public readonly string Email;
		public readonly string FirstName;
		public readonly string SecondName;
		public readonly string[] CurrentCompetences;
		public readonly string[] DesiredCompetences;
		
		public User(UserDto dto)
		{
			Email = dto.Email;
			FirstName = dto.FirstName;
			SecondName = dto.SecondName;
			CurrentCompetences = dto.CurrentCompetences.SplitCompetences();
			DesiredCompetences = dto.DesiredCompetences.SplitCompetences();
		}
	}
}