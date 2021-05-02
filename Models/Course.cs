using System;

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

		public Course(string name,
			string url,
			Format format,
			Complexity complexity,
			bool practice,
			bool free,
			int length,
			string content,string feature,  string depth = "Материал представлен понятно и подробно")
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
			Name = dto.Name;
			Url = dto.Url;
			Format = (Format) dto.Format;
			Complexity = (Complexity) dto.Complexity;
			Practice = dto.Practice;
			Free = dto.Free;
			Length = dto.Length;
			Feature = dto.Feature;
			Content = dto.Content;
			Depth = dto.Depth;
		}
	}
}