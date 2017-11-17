using System.Linq;

namespace fizzbuzz
{
    class infinety
    {
        public string FizzBuzz(int number)
        {
            var fizzsequenst = Enumerable.Repeat("", 2).Concat(new[] { "fizz" });
            var fizz = Enumerable.Repeat(fizzsequenst, 34)
                .SelectMany(f => f)
                .Take(100);

            var buzzsequense = Enumerable.Repeat("", 4).Concat( new[] { "buzz" });
            var buzz = Enumerable.Repeat(buzzsequense, 20)
                .SelectMany(f => f);

            var words = fizz.Zip(buzz, (f, b) => f + b);

            return Enumerable.Range(1, 100)
                 .Select(x => x.ToString())
                 .Zip(words, (n, w) => w == "" ? n : w)
                 .ToArray()[number - 1];
        }
    }
}
