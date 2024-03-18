namespace SkalProj_Datastrukturer_Minne
{
	public static class StringExtensions
	{
		public static List<char> ToCharList(this string value)
		{
			return value.ToCharArray().ToList();
		}
	}
}
