using System;
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

			var list = new List<string>();

			while (true)
            {
                string[] input = ReadInput();
                char character = char.Parse(input[0]);
                string value = input[1];

				switch (character)
				{
					case '+':
                        list.Add(value);
                        Console.WriteLine($"Capacity: {list.Capacity}\nCount: {list.Count}");
                        break;
					case '-':
                        list.Remove(value);
						Console.WriteLine($"Capacity: {list.Capacity}\nCount: {list.Count}");
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

            var queue = new Queue<string>();

			while (true)
            {
                string[] input = ReadInput();
                char character = char.Parse(input[0]);
                string value = input[1];

                switch (character)
				{
					case '+':
                        queue.Enqueue(value);
                        Console.WriteLine($"{value} stands in queue");
                        Console.WriteLine($"Queue count: {queue.Count}");
                        break;
					case '-':
                        if (queue.Count > 0)
                        {
							string name = queue.Dequeue();
							Console.WriteLine($"{name} leaves queue");
							Console.WriteLine($"Queue count: {queue.Count}");
						}
                        else
                        {
                            Console.WriteLine("Queue is empty, nothing to remove");
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
        }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

        }

        static string[] ReadInput()
        {
			char character = ' ';
			string value = string.Empty;

			string? input = Console.ReadLine();
			if (!string.IsNullOrWhiteSpace(input))
			{
				character = input[0];
				value = input.Substring(1);
			}

            return [character.ToString(), value];
		}
    }
}

