namespace fizzbuzz;

class Position
{
    class Options
    {
        private int number;

        public Options(int number)
        {
            this.number = number;
        }
       // 
        public string this[int index] 
            => new[] { number.ToString(), "fizz", "buzz", "fizzbuzz" }[index];

        public const int Number = 0;
        public const int Fizz = 1;
        public const int Buzz = 2;
    }
    public string FizzBuzz(int number)
    {
        var options = new Options(number);

        var firstFisteen = 
            new[] {
                Options.Number,
                Options.Number,
                Options.Fizz,
                Options.Number, 
                Options.Buzz,
                Options.Fizz,
                Options.Number,
                Options.Number, 
                Options.Fizz,
                Options.Buzz,
                Options.Number,
                Options.Fizz,
                Options.Number,
                Options.Number,
                Options.Fizz + Options.Buzz 
            }
            .Reverse()
            .ToArray();

        return options
            [firstFisteen[number % 15]];
    }
}
