namespace fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var ifif = new ifif();
            var ifelse = new IfReturn();
            var position = new Position();
            var composition = new Composition();
            var allFizzBuzzes = new AllFizzBuzzes();
            var infinityPosition = new InfinityPosition();
            var ranges = new Ranges();
            foreach (var i in Enumerable.Range(1, 16))
            {
                //Console.WriteLine($"{i} => if {ifif.FizzBuzz(i)}");
                //Console.WriteLine($"{i} => else {ifelse.FizzBuzz(i)}");
                //Console.WriteLine($"{i} => ifelse {ifelse.FizzBuzz(i)} = composition {composition.FizzBuzz(i)}");
                //Console.WriteLine($"{i} => ifelse {ifelse.FizzBuzz(i)} = allFizzBuzzes {allFizzBuzzes.FizzBuzz(i)}");
                Console.WriteLine($"{i} => ifelse {ifelse.FizzBuzz(i)} = position {position.FizzBuzz(i)}");
                //Console.WriteLine($"{i} => ifelse {ifelse.FizzBuzz(i)} = ranges {ranges.FizzBuzz(i)}");
                //Console.WriteLine($"{i} => ifelse {ifelse.FizzBuzz(i)} = infinityPosition {infinityPosition.FizzBuzz(i)}");
            }

            Console.ReadKey();
        }
    }
}
