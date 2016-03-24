using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandInterpreter
{
    class CommandInterpreter
    {
        static void Main()
        {
            List<string> collection = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                try
                {
                    ExecuteCommand(command.Split(), collection);
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Invalid input parameters.");
                }

                command = Console.ReadLine();
            }

            Console.WriteLine("[{0}]", string.Join(", ", collection));
        }

        private static void ExecuteCommand(string[] commandArguments, List<string> collection)
        {
            string operation = commandArguments[0];

            switch (operation)
            {
                case "reverse":
                    ExecuteReverse(commandArguments, collection);
                    break;
                case "sort":
                    ExecuteSort(commandArguments, collection);
                    break;
                case "rollLeft":
                    ExecuteRollLeft(commandArguments, collection);
                    break;
                case "rollRight":
                    ExecuteRollRight(commandArguments, collection);
                    break;
            }
        }

        private static void ExecuteRollRight(string[] commandArguments, List<string> collection)
        {
            throw new NotImplementedException();
        }

        private static void ExecuteRollLeft(string[] commandArguments, List<string> collection)
        {
            int rolls
        }

        private static void ExecuteSort(string[] commandArguments, List<string> collection)
        {
            int start = int.Parse(commandArguments[2]);

            if (start == collection.Count)
            {
                throw new ArgumentException();
            }

            int count = int.Parse(commandArguments[4]);

            collection.Sort(start, count, StringComparer.InvariantCulture);
        }

        private static void ExecuteReverse(string[] commandArguments, List<string> collection)
        {
            int start = int.Parse(commandArguments[2]);

            if (start == collection.Count)
            {
                throw new ArgumentException();
            }

            int count = int.Parse(commandArguments[4]);

            collection.Reverse(start, count);
        }
    }
}
