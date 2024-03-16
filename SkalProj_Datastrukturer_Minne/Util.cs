namespace SkalProj_Datastrukturer_Minne
{
	internal static class Util
	{
		public static void WriteMenu(string title, string[] options)
		{
			Console.Clear();
			Console.WriteLine(title);

			foreach (var option in options)
			{
                Console.WriteLine(option);
            }
		}

		public static string[] GetInput()
		{
			char operation = ' ';
			string value = string.Empty;

			string? input = Console.ReadLine();
			if (!string.IsNullOrWhiteSpace(input))
			{
				operation = input[0];
				value = input.Substring(1);
			}

			return [operation.ToString(), value];
		}
	}
}
