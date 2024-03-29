﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
		/// <summary>
		/// The main method, vill handle the menues for the program
		/// </summary>
		/// <param name="args"></param>
		static void Main()
        {

            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParenthesis"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */

            //List<string> theList = new List<string>();
            //string input = Console.ReadLine();
            //char nav = input[0];
            //string value = input.substring(1);

            //switch(nav){...}

            Util.Clear();
            Util.WriteMenu("Examine a List", ["Use (+) to add", "Use (-) to remove", "Enter (0) to exit program"]);
			var list = new List<string>();

			while (true)
            {
                string[] input = Util.GetInput();
                char operation = char.Parse(input[0]);
                string value = input[1];

				switch (operation)
				{
					case '+':
                        list.Add(value);
                        Console.WriteLine($"Capacity: {list.Capacity}\nCount: {list.Count}");
                        break;
					case '-':
                        bool succeeded = list.Remove(value);
                        if (succeeded) Console.WriteLine($"Capacity: {list.Capacity}\nCount: {list.Count}");
                        else Console.WriteLine("List empty.");
                        break;
					case '0':
						Environment.Exit(0);
						break;
					default:
						Console.WriteLine("Please enter som valid input (+, -)");
						break;
				}
			}
        }

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */

            Util.Clear();
            Util.WriteMenu("Examine a Queue", ["Use (+) to add", "Use (-) to remove", "Enter (0) to exit program"]);
			var queue = new Queue<string>();

			while (true)
            {
                string[] input = Util.GetInput();
                char operation = char.Parse(input[0]);
                string value = input[1];

                switch (operation)
				{
					case '+':
                        queue.Enqueue(value);
                        Console.WriteLine($"{value} stands in queue");
                        Console.WriteLine($"Queue count: {queue.Count}");
                        break;
					case '-':
                        try
                        {
							string name = queue.Dequeue();
							Console.WriteLine($"{name} leaves queue");
							Console.WriteLine($"Queue count: {queue.Count}");
						}
                        catch (InvalidOperationException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
						break;
					case '0':
						Environment.Exit(0);
						break;
					default:
						Console.WriteLine("Please enter som valid input (+, -)");
						break;
				}
			}
        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */

            Util.Clear();
			Util.WriteMenu("Examine a Stack", ["Use (+) to add", "Use (-) to remove", "Enter (1) to reverse a text","Enter (0) to exit program"]);
			var stack = new Stack<string>();

			while (true)
			{
				string[] input = Util.GetInput();
				char operation = char.Parse(input[0]);
				string value = input[1];

				switch (operation)
				{
					case '+':
						stack.Push(value);
						Console.WriteLine($"{value} stands in queue");
						Console.WriteLine($"Stack count: {stack.Count}");
						break;
					case '-':
                        try
                        {
							string name = stack.Pop();
							Console.WriteLine($"{name} leaves queue");
							Console.WriteLine($"Stack count: {stack.Count}");
						}
                        catch (InvalidOperationException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
						break;
                    case '1':
                        Console.Write("Enter text: ");
                        string? text = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(text))
                        {
                            string reversed = Util.ReverseText(text);
                            Console.WriteLine(reversed);
                        }
                        break;
					case '0':
						Environment.Exit(0);
						break;
					default:
						Console.WriteLine("Please enter som valid input (+, -)");
						break;
				}
			}
		}

        static void CheckParanthesis()
        {
			/*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

		    var parenthesis = new List<Parenthesis>
		    {
			    new Parenthesis(ParenthesisType.Bracket, '(', isClosing: false),
			    new Parenthesis(ParenthesisType.Bracket, ')', isClosing: true),
			    new Parenthesis(ParenthesisType.Square, '[', isClosing: false),
			    new Parenthesis(ParenthesisType.Square, ']', isClosing: true),
			    new Parenthesis(ParenthesisType.Curly, '{', isClosing: false),
			    new Parenthesis(ParenthesisType.Curly, '}', isClosing: true),
			    new Parenthesis(ParenthesisType.Angle, '<', isClosing: false),
			    new Parenthesis(ParenthesisType.Angle, '>', isClosing: true),
		    };

		    Util.Clear();
            Console.WriteLine("Check parenthesis");

			while (true)
            {
                Console.Write("Enter text: ");
                string? text = Console.ReadLine();

				if (!string.IsNullOrWhiteSpace(text))
                {
					var stack = new Stack<Parenthesis>();

					foreach (var character in text.ToCharArray())
					{
						var p = parenthesis.FirstOrDefault(p => character.Equals(p.Symbol));
						if (p is not null)
						{
							if (p.IsClosing)
							{
								var top = stack.Peek();
								if (p.Type.Equals(top.Type))
								{
									stack.Pop();
								}
							}
							else
							{
								stack.Push(p);
							}
						}
					}

					if (stack.Count > 0)
                    {
                        Console.WriteLine("Incorrect formatting");
                    }
                    else
                    {
                        Console.WriteLine("Correct formatting");
                    }
                }
			}
        }
    }
}

