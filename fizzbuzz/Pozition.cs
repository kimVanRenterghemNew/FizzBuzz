using System.Linq;

namespace fizzbuzz
{
    class Pozition
    {
        public string FizzBuzz(int number)
        {
            var firstFisteen = 
                new[] { 0, 0, 1, 0, 2, 1, 0, 0, 1, 2, 0, 1, 0, 0, 3 }
                .Reverse()
                .ToArray();

            return new[] { number.ToString(), "fizz", "buzz", "fizzbuzz" }
                [firstFisteen[number % 15]];
        }
    }
}
