using System.Text;

namespace SkalProj_Datastrukturer_Minne
{
    public class Program
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

            List<string> strings = new List<string>();
            bool examine = true;
            const char exitCondition = '!';
            string menu = $"Type '{exitCondition}' to exit\n'+' To add strings to the list\n'-'To remove matching strings from the list\n";

            Console.Write("Hello! ");
            while (examine)
            {
                Console.WriteLine(menu);
                string? input = Console.ReadLine();
                input ??= "BAD INPUT";
                switch (input[0])
                {
                    case '+':
                        //Insert input.substring(1)
                        strings.Add(input.Substring(1));
                        Console.WriteLine($"Count: {strings.Count}, Capacity: {strings.Capacity}");
                        break;
                    case '-':
                        //Remove input.substring(1)
                        strings.Remove(input.Substring(1));
                        Console.WriteLine($"Count: {strings.Count}, Capacity: {strings.Capacity}");
                        break;
                    case exitCondition:
                        examine = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid input...");
                        break;
                }
            }
            /*
            1.Skriv klart implementationen av ExamineList-metoden så att undersökningen blir genomförbar. ✔
            2.När ökar listans kapacitet ? (Alltså den underliggande arrayens storlek)
                När man försöker lägga in ett till element och Capacity == Count
            3.Med hur mycket ökar kapaciteten?
                Dubblar (capacity *= 2)
            4.Varför ökar inte listans kapacitet i samma takt som element läggs till ?
                Mer tidseffektivt, ivartfall om den funkar som C++ std::vector, vilket den verkar göra
            5.Minskar kapaciteten när element tas bort ur listan?
                Nej
            6.När är det då fördelaktigt att använda en egendefinierad array istället för en lista ?
                När man själv vill bestämma allt i arrayen
            */
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

            //Que: FIFO -> deque remove first element, enque add to the back
            Queue<string> strings = new Queue<string>();
            bool examine = true;
            const char exitCondition = '!';
            string menu = $"Type '{exitCondition}' to exit\n'+' To add strings to the list\n'-'To remove matching strings from the list\n";

            Console.Write("Hello! ");
            while (examine)
            {
                Console.WriteLine(menu);
                string? input = Console.ReadLine();
                input ??= "BAD INPUT";
                switch (input[0])
                {
                    case '+':
                        //Insert input.substring(1)
                        strings.Enqueue(input.Substring(1));
                        foreach (var item in strings)
                        {
                            Console.Write($"{item} ");
                        }
                        Console.WriteLine();
                        break;
                    case '-':
                        //Remove input.substring(1)
                        if(strings.Count > 0)
                            strings.Dequeue();
                        foreach (var item in strings)
                        {
                            Console.Write($"{item} ");
                        }
                        Console.WriteLine();
                        break;
                    case exitCondition:
                        examine = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid input...");
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

            //Stack: LIFO -> push add to first element, pop remove first element
            Stack<string> strings = new Stack<string>();
            bool examine = true;
            const char exitCondition = '!';
            string menu = $"Hello! Type '{exitCondition}' to exit\n'+' To add strings to the list\n'-'To remove matching strings from the list\n";

            while (examine)
            {
                Console.WriteLine(menu);
                string? input = Console.ReadLine();
                input ??= "BAD INPUT";
                switch (input[0])
                {
                    case '+':
                        //Insert input.substring(1)
                        strings.Push(input.Substring(1));
                        foreach (var item in strings)
                        {
                            Console.Write($"{item} ");
                        }
                        Console.WriteLine();
                        break;
                    case '-':
                        //Remove input.substring(1)
                        if (strings.Count > 0)
                            strings.Pop();
                        foreach (var item in strings)
                        {
                            Console.Write($"{item} ");
                        }
                        Console.WriteLine();
                        break;
                    case exitCondition:
                        examine = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid input...");
                        break;
                }
            }
            /*
            1. Simulera ännu en gång ICA-kön på papper. Denna gång med en stack . Varför är det inte så smart att använda en stack i det här fallet?
                Det är orättvist, ingen skulle vilja vara först i en stack att betala på ica såvida man inte är ensam kund i butiken. Annars är det detsamma som att låta alla andra gå före i kön tills man är sist ungefär (ivartfall om man är först i kön).
            2. Implementera en ReverseText-metod som läser in en sträng från användaren och med hjälp av en stack vänder ordning på teckenföljden för att sedan skriva ut den omvända strängen till användaren.
                ✔
             */
        }

        public static string ReverseText(string input)
        {
            Stack<char> stack = new Stack<char>();
            input ??= " ";
            for (int i = 0; i < input.Length; i++)
            {
                stack.Push(input[i]);
            }
            StringBuilder sb = new StringBuilder();
            while(stack.Count > 0)
            {
                sb.Append(stack.Pop());
            }
            string output = sb.ToString();
            return output;
        }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

            string? input = Console.ReadLine();
            input ??= " ";
            Stack<char> chars = new Stack<char>();
            bool correctness = true;

            for (int i = 0; i < input.Length && correctness; i++)
            {
                switch (input[i])
                {
                    case '(':
                        chars.Push('(');
                        break;
                    case '{':
                        chars.Push('{');
                        break;
                    case '[':
                        chars.Push('[');
                        break;
                    case ')':
                    case '}':
                    case ']':
                        if(chars.Count <= 0)
                        {
                            correctness = false;
                            break;
                        }
                        char output = chars.Pop();
                        switch (output)
                        {
                            case '(':
                                if (input[i] != ')')
                                    correctness = false;
                                break;
                            case '{':
                                if (input[i] != '}')
                                    correctness = false;
                                break;
                            case '[':
                                if (input[i] != ']')
                                    correctness = false;
                                break;
                        }

                        break;
                    default:
                        //Do nothing
                        break;
                }
            }

            if(correctness && chars.Count == 0)
                Console.WriteLine("Correct formatting!");
            else
                Console.WriteLine("Incorrect formatting...");

            /*
            1. Skapa med hjälp av er nya kunskap funktionalitet för att kontrollera en välformad sträng på papper. Du ska använda dig av någon eller några av de datastrukturer vi precis gått igenom. Vilken datastruktur använder du?
                Stack. Pusha (, { och [, och poppa när man stöter på ), } eller ]. Jämför sedan det som gav utfall för poppningen ifall den är dess 'partner'. Kolla också att stacken är tom i slutet. 
            2. Implementera funktionaliteten i metoden CheckParantheses . Låt programmet läsa in en sträng från användaren och returnera ett svar som reflekterar huruvida strängen är välformad eller ej.
                ✔
             */
        }

        /*Övning 5*/
        public static int RecursiveEven(int n)
        {
            if(n == 0)
                return 0;
            return (RecursiveEven(n - 1) + 2);
        }

        public static int Fibonacci(int n)
        {
            if (n <= 0)
                return 0;
            if (n == 1)
                return n;
            return (Fibonacci(n - 1) + Fibonacci(n - 2));
        }
        /*Övning 6*/
        public static int IterativeEven(int n)
        {
            int result = 0;
            for (int i = 0; i < n; i++)
            {
                result += 2;
            }
            return result;
        }

        public static int IterativeFibonacci(int n)
        {
            if (n <= 0)
                return 0;
            List<int> fibo = new List<int>();
            fibo.Add(0);
            fibo.Add(1);
            for (int i = fibo.Count; i <= n; i++)
            {
                fibo.Add(fibo[i - 1] + fibo[i - 2]);
            }
            return fibo.Last();
        }
        /*
        Utgå ifrån era nyvunna kunskaper om iteration, rekursion och minneshantering. Vilken av ovanstående funktioner är mest minnesvänlig och varför?
            Enligt Unit testerna så är rekursionerna snabbare än iterationerna i just dessa implementationer. 
            Even ger 4ms på Recursion, 29ms på Iteration
            Fibonacci ger 2ms på Recursion, 18ms på Iteration
            Minns jag rätt är det för att Recursion sker stackvis och det inte är lika mycket overhead, 
            medans Iteration sker på heapen vilket är djupare och svår åtkommligare, samt att det finns mer overhead
         */
    }
}

