using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

namespace kurs_aviis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] registers = new int[2];

            // int a = 50 + 40
            // int b = 30 + 20
            // a > b

            var commands = new ICommand[] {
                new PutConstantToRegisterCommand(0, 50),
                new PutConstantToRegisterCommand(1, 40),
                new AddComand(0),
                new WriteCommand("a", 0),
                new PutConstantToRegisterCommand(0, 30),
                new PutConstantToRegisterCommand(1, 20),
                new AddComand(0),
                new WriteCommand("b", 0),
                new ReadCommand("a", 0),
                new ReadCommand("b", 1),
                new GtComand(0),
            };
        
            for (int i = 0; i < commands.Length;)
            {
                var currentComand = commands[i];
                currentComand.Dump();
                currentComand.Execute(registers, ref i);
                Console.CursorLeft = 20;
                registers.Dump();
                Console.CursorLeft = 30;
                Memory.Dump();
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
