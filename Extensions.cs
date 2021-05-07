using System;
using System.Collections.Generic;
using System.Linq;

namespace InProcess
{
	public static class Extensions
	{
		private const string Checked = "checked";

		public static string GetCheckedString<T>(this IEnumerable<T> source, T value) =>
			source.Contains(value) ? Checked : string.Empty;
		
		public static string ToCustomString(this bool value) => value ? "Да" : "Нет";

		public static string ToCostString(this bool free) => free ? "Бесплатный" : "Платный";

		public static string ToCustomString(this Complexity value) =>
			value switch
			{
				Complexity.Beginner => "Для начинающих",
				Complexity.Profile => "Профильный",
				_ => throw new ArgumentOutOfRangeException(nameof(value), value, null)
			};

		public static string ToCustomString(this Format value) =>
			value switch
			{
				Format.Course => "Курс",
				Format.Lecture => "Лекции",
				_ => throw new ArgumentOutOfRangeException(nameof(value), value, null)
			};

		public static bool ContainsOrEmpty<T>(this T[] source, T value) => source.Length == 0 || source.Contains(value);

		public static bool ContainsOrEmpty<T>(this T[] source, IEnumerable<T> values) =>
			source.Length == 0 || values.Any(source.Contains);

		public static string[] SplitArray(this string competences) => string.IsNullOrWhiteSpace(competences)
			? Array.Empty<string>()
            : competences.Trim().Split(Separators);

		public static string EnumerableToString(this IEnumerable<string> competences) =>
			competences == null || !competences.Any()
				? ""
				: competences.Aggregate((result, next) => result + $",{next}");
		
		private static readonly char[] Separators = {','};
	}
}