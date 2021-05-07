using System.ComponentModel.DataAnnotations;

namespace InProcess.Models
{
	public class CourseDto
	{
		[Key]
		public  string Name { get; set; }
		public  string Url{ get; set; }
		public  int Format{ get; set; }
		public  int Complexity{ get; set; }
		public  bool Practice{ get; set; }
		public  bool Free{ get; set; }
		public  int Length{ get; set; }
		public  string Feature{ get; set; }
		public  string Content{ get; set; }
		public  string Depth{ get; set; }
		public  string Competences{ get; set; }
	}
}