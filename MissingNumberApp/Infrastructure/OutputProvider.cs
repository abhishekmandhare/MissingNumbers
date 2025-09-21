using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissingNumberApp.Infrastructure
{
    public interface IOutputProvider
    {
        void ShowResult(int output);
    }

    internal class ConsoleOutputProvider : IOutputProvider
    {
        public void ShowResult(int output)
        {
            Console.WriteLine(output);
        }
    }
}
