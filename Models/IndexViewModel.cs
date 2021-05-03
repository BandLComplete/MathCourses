namespace InProcess.Models
{
	public class IndexViewModel
	{
		public readonly Course[] Selected;
		public readonly bool[] Practice;
		public readonly Complexity[] Complexities;
		public readonly Format[] Formats;
		public readonly bool[] Free;
		public readonly int MinDuration;
		public readonly int MaxDuration;

		public IndexViewModel(Course[] selected,
			bool[] practice,
			Complexity[] complexities,
			Format[] formats,
			bool[] free,
			int minDuration,
			int maxDuration)
		{
			Selected = selected;
			Practice = practice;
			Complexities = complexities;
			Formats = formats;
			Free = free;
			MinDuration = minDuration;
			MaxDuration = maxDuration;
		}
	}
}