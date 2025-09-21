using MissingNumberApp.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissingNumberApp
{
    public interface IMissingNumberFinder
    {
        void FindMissingNumbers();
    }

    public class MissingNumberFinder : IMissingNumberFinder
    {
        private readonly IInputProvider _inputProvider;
        private readonly IOutputProvider _outputProvider;

        public MissingNumberFinder(IInputProvider inputProvider, IOutputProvider outputProvider)
        {
            _inputProvider = inputProvider;
            _outputProvider = outputProvider;
        }

        public void FindMissingNumbers()
        {
            var numbers = _inputProvider.GetInput();
            var missingNumber = CalculateMissingNumber(numbers);
            _outputProvider.ShowResult(missingNumber);
        }

        private int CalculateMissingNumber(int[] numbers)
        {
            int n = numbers.Length;
            int expectedSum = n * (n + 1) / 2;
            int actualSum = numbers.Sum();
            return expectedSum - actualSum;
        }
    }
}
