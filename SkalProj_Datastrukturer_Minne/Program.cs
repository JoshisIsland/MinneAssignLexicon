using System;
using System.Linq.Expressions;

namespace MinneAssignLexicon
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
                        //CheckParanthesis();
                        break;
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

            /*  F:
             *  Listans kapacitet ökar med 4 efter de första 4 är fyllda (dubblerar)
             *  Anledningen till att listan inte ökar i storlek efter varje tillägg är för att vid varje ökning av listan görs en ny lista som existrande lista kopieras till.
             *  Detta tar upp prestande och minne och skulle vara oeffektivt att göra vid varje tillägg.
             *  Listan minskar inte i kapacitet vid minskning av listelement. En array är fördelaktig när man vet storleken i förväg och innehållet ej ändras.
             */

            List<string> theList = new List<string>();
            bool exit = false;
            while (exit == false)
            {
                Console.WriteLine("To add to list please put a + before item, \n" +
                    "to remove from list please put a - before item. To exit please input e");
                string input = Console.ReadLine();
                char nav = input[0];
                string value = input.Substring(1);
                switch (nav)
                {
                    case '+':
                        theList.Add(value);
                        foreach (var item in theList)
                        {
                            Console.WriteLine(item);   
                        }
                        Console.WriteLine("Count: " + theList.Count + " Capacity: " + theList.Capacity);
                        break;
                    case '-':
                        theList.Remove(value);
                        foreach (var item in theList)
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("Count: " + theList.Count + " Capacity: " + theList.Capacity);
                        break;
                    case 'e':
                        exit = true;
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
            Queue<string> customers = new Queue<string>();
            customers.Enqueue("Kalle");
            customers.Enqueue("Greta");
            bool exit = false;
            while (exit == false)
            {
                Console.WriteLine("Kalle and Greta are already queueing, \n" +
                    "to add customers to the queue please put a + before the customers name, \n" +
                    "to remove the first person from queue please press -. To exit please input e");
                string input = Console.ReadLine();
                char nav = input[0];
                string value = input.Substring(1);
            
                switch (nav)
                {
                    case '+':
                        customers.Enqueue(value);
                        foreach (string customer in customers)
                        {
                            Console.WriteLine(customer);
                        }
                        break;
                    case '-':
                        customers.Dequeue();
                        foreach (string customer in customers)
                        {
                            Console.WriteLine(customer);
                        }
                        break;
                    case 'e':
                        exit = true;
                        break;
                }
            }

        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            Stack<string> customers = new Stack<string>();
            customers.Push("Kalle");
            customers.Push("Greta");
            bool exit = false;
            while (exit == false)
            {
                Console.WriteLine("Kalle and Greta are already in the stack, \n" +
                    "to add customers to the stack please put a + before the customers name, \n" +
                    "to remove the last person from the stack please press -. To exit please input e");
                string input = Console.ReadLine();
                char nav = input[0];
                string value = input.Substring(1);
                switch (nav)
                {
                    case '+':
                        customers.Push(value);
                        foreach (string customer in customers)
                        {
                            Console.WriteLine(customer);
                        }
                        break;
                    case '-':
                        customers.Pop();
                        foreach (string customer in customers)
                        {
                            Console.WriteLine(customer);
                        }
                        break;
                    case 'e':
                        exit = true;
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

        }

    }
}

