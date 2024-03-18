namespace SkalProj_Datastrukturer_Minne
{
	internal class Parenthesis
	{
        public char Symbol { get; set; }
        public bool IsOpening { get; private set; }
        public bool IsClosing { get; private set; }
        public ParenthesisType Type { get; set; }

        public Parenthesis(ParenthesisType type, char symbol, bool isOpening, bool isClosing)
        {
            Type = type;
            Symbol = symbol;
            IsOpening = isOpening;
            IsClosing = isClosing;
        }

		public override string ToString()
		{
            return $"Type: {Type}, Symbol: {Symbol}, Opening: {IsOpening}, Closing: {IsClosing}";
		}
	}
}
