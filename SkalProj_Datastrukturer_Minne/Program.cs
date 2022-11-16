using System;
using System.Diagnostics;

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {

        /*
         * 
         * 

        Frågor:

        1. Hur fungerarstackenochheapen? Förklaragärna med exempel eller skiss på dess grundläggande funktion.

        Svar: 

        Stacken är som en hög med lådor ovanpå varandra. Använder principen "först in sist ut". För att komma åt lådor längre ner måste man flytta på lådorna över dessa. När en låda (anrop, metoder) använts (körts) kastas den.

        Heapen är mer av en mappstruktur/trädstruktur men där man har tillgång till allt innehåll direkt. Som tvättade kläder utlagda i en trädstruktur på en säng, där det är enkelt att ta det man vill ha.


        2.Vad är Value Types respektive Reference Types och vad skiljer dem åt?

        Reference Types kan bara existera på Heapen medan Value Types kan skapas på Stacken men också inuti en Reference Type på Heapen.

        Value Types är ifrån System.ValueTypes. 

        Reference Types är typer som ärver ifrån System.Object (.object). Reference Types har en pekare som anger var i minnet (Heapen) det är allokerat. 
        

        3. Följande metoder (se bild nedan) genererar olikasvar. Den första returnerar 3, denandra returnerar 4, varför?

        Det första exemplet lagras på stacken och det skapas 2 olika minnes platser för de olika variablerna.

        Det andra exemplet lagras i ett objekt på Heapen. Pekaren ändrar på den minnesplats som pekas ut. 



        */


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
                    + "\n4. CheckParanthesis"
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
             Loop this method until the user inputs something to exit to main menue.
             Create a switch statement with cases '+' and '-'
             '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             In both cases, look at the count and capacity of the list
             As a default case, tell them to use only + or -
             Below you can see some inspirational code to begin working.


            Svar:

            1. Klart
            2. Ökar när jag matar in 5:e
            3. 4
            4. Antar att det är en array med 4 platser som läggt på
            5. Nej
            6. Om man vill spara minne


            */

            Console.WriteLine("Mata in + eller -. Tillbaka, skriv Q");
            bool ExitExamineList = false;
            List<string> theList = new List<string>();

            do
            {
                            
                string input = Console.ReadLine()!;
                char nav = input[0];
                string value = input.Substring(1);


                

                switch (nav) {
                    case '+':
                            theList.Add(value);
                        break;
                    case '-':
                            theList.Remove(value);
                        break;
                    case 'Q':
                            ExitExamineList = true;
                        break;
                    case 'q':
                            ExitExamineList = true;
                        break;
                }
                Console.WriteLine($"Listan innehåller:");

                theList.ForEach(item => { Console.WriteLine($"{item}"); });

            } while (!ExitExamineList);
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

            Console.WriteLine("Mata in + eller -. Tillbaka, skriv Q");
            bool ExitExamineQueue = false;
            
            

            Queue<string> theQueue = new Queue<string>();
            

            do
            {

                string input = Console.ReadLine()!;
                char nav = input[0];
                string value = input.Substring(1);




                switch (nav)
                {
                    case '+':
                        theQueue.Enqueue(value);
                        break;
                    case '-':
                        theQueue.Dequeue();
                        break;
                    case 'Q':
                        ExitExamineQueue = true;
                        break;
                    case 'q':
                        ExitExamineQueue = true;
                        break;
                }
                Console.WriteLine($"Listan innehåller:");

                //theQueue.theQueue.ForEach(item => { Console.WriteLine($"{item}"); });

                for(int i=0; i< theQueue.Count; i++)
                {
                    Console.WriteLine(theQueue.ElementAt(i));
                }

                

            } while (!ExitExamineQueue);
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

    }
}

