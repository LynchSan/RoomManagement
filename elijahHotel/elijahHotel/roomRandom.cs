using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elijahHotel
{
    internal class roomRandom
    {
        private Random random;
        private HashSet<int> generatedNumbers;

        public roomRandom()
        {
            random = new Random();
            generatedNumbers = new HashSet<int>();
        }

        // Generate a unique random number between 1-200
        public int GenerateUniqueNumber()
        {
            // If already generated all possible numbers, will reset
            if (generatedNumbers.Count >= 200)
            {
                generatedNumbers.Clear();
            }

            int number;
            do
            {
                number = random.Next(1, 201); // Generates a number between 1 and 200 inclusive
            } while (generatedNumbers.Contains(number));

            generatedNumbers.Add(number);
            return number;
        }

        // Generate multiple unique random numbers
        public List<int> GenerateMultipleUniqueNumbers(int count)
        {
            List<int> numbers = new List<int>();

            count = Math.Min(count, 200);

            for (int i = 0; i < count; i++)
            {
                numbers.Add(GenerateUniqueNumber());
            }

            return numbers;
        }
    }
}