using System.Collections.Generic;

namespace InProcess.Models
{
	public class IndexViewModel
	{
		public readonly Course[] Selected;
		public readonly IEnumerable<string> Competences;
		public readonly bool[] Practice;
		public readonly Complexity[] Complexities;
		public readonly Format[] Formats;
		public readonly bool[] Free;
		public readonly int MinDuration;
		public readonly int MaxDuration;

		public IndexViewModel(Course[] selected,
			IEnumerable<string> competences,
			bool[] practice,
			Complexity[] complexities,
			Format[] formats,
			bool[] free,
			int minDuration,
			int maxDuration)
		{
			Selected = selected;
			Competences = competences;
			Practice = practice;
			Complexities = complexities;
			Formats = formats;
			Free = free;
			MinDuration = minDuration;
			MaxDuration = maxDuration;
		}
	}
}