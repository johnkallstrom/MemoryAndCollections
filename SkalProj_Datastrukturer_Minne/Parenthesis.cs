namespace SkalProj_Datastrukturer_Minne
{
	internal class Parenthesis
	{
        public char Symbol { get; set; }
        public bool Opening { get; set; }
        public ParenthesisType Type { get; set; }

        public Parenthesis(ParenthesisType type, bool opening, char symbol)
        {
            Type = type;
            Opening = opening;
            Symbol = symbol;
        }

		public override string ToString()
		{
            return $"Type: {Type}, Opening: {Opening}, Symbol: {Symbol}";
		}
	}
}
