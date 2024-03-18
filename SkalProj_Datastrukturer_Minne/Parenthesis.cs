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
            string result = string.Empty;

            switch (Type)
            {
                case ParenthesisType.Bracket:
                    if (Opening)
                    {
                        result = "(";
                    }
                    else
                    {
                        result = ")";
                    }
                    break;
                case ParenthesisType.Square:
                    if (Opening)
                    {
                        result = "[";
                    }
                    else
                    {
                        result = "]";
                    }
                    break;
                case ParenthesisType.Curly:
                    if (Opening)
                    {
                        result = "{";
                    }
                    else
                    {
                        result = "}";
                    }
                    break;
                case ParenthesisType.Angle:
                    if (Opening)
                    {
                        result = "<";
                    }
                    else
                    {
                        result = ">";
                    }
                    break;
            }

            return result;
		}
	}
}
