namespace SkalProj_Datastrukturer_Minne
{
	internal class Parenthesis
	{
        public char Symbol { get; set; }
        public bool IsClosing { get; private set; }
        public ParenthesisType Type { get; set; }

        public Parenthesis(ParenthesisType type, char symbol, bool isClosing)
        {
            Type = type;
            Symbol = symbol;
            IsClosing = isClosing;
        }
	}
}
