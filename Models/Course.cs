namespace InProcess.Models
{
	public class Course
	{
		public readonly string Name;
		public readonly string Url;
		public readonly Format Format;
		public readonly Complexity Complexity;
		public readonly bool Practice;
		public readonly bool Free;
		public readonly int Length;
		public readonly string Feature;
		public readonly string Content;
		public readonly string Depth;
		public readonly string[] Competences;

		public Course(string name,
			string url,
			Format format,
			Complexity complexity,
			bool practice,
			bool free,
			int length,
			string content,string feature,  string depth)
		{
			Name = name;
			Url = url;
			Format = format;
			Complexity = complexity;
			Practice = practice;
			Free = free;
			Length = length;
			Feature = feature;
			Content = content;
			Depth = depth;
		}

		public Course(CourseDto dto)
		{
			Name = dto.Name.Trim(Trimmers);
			Url = dto.Url;
			Format = (Format) dto.Format;
			Complexity = (Complexity) dto.Complexity;
			Practice = dto.Practice;
			Free = dto.Free;
			Length = dto.Length;
			Feature = dto.Feature.Trim(Trimmers);
			Content = dto.Content.Trim(Trimmers);
			Depth = dto.Depth;
			Competences = dto.Competences.Trim(Trimmers).ToLower().SplitArray();
		}

		private static readonly char[] Trimmers = {'\"', '\n', '\r'};
	}
}