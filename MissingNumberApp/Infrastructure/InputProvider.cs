using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissingNumberApp.Infrastructure
{
    public interface IInputProvider
    {
        int[]? GetInput();
    }

    internal class ConsoleInputProvider : IInputProvider
    {
        public int[]? GetInput()
        {
            Console.WriteLine("Enter numbers seperated by space");
            string? input = Console.ReadLine();
            return input?.Split(' ').Select(int.Parse).ToArray();
        }
    }
}
