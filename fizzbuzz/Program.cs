using System;
using System.Linq;

namespace fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var ifif = new ifif();
            var ifelse = new ifelse();
            var pozition = new Pozition();
            var composition = new Composition();
            var infinety = new infinety();
            var infinityPosition = new infinityPosition();
            var ranges = new ranges();
            foreach (var i in Enumerable.Range(1, 16))
            {
                Console.WriteLine($"{i} => if {ifif.FizzBuzz(i)}");
                Console.WriteLine($"{i} => else {ifelse.FizzBuzz(i)}");
                Console.WriteLine($"{i} => {ifelse.FizzBuzz(i)} = co {composition.FizzBuzz(i)}");
                Console.WriteLine($"{i} => {ifelse.FizzBuzz(i)} = in {infinety.FizzBuzz(i)}");
                Console.WriteLine($"{i} => {ifelse.FizzBuzz(i)} = po {pozition.FizzBuzz(i)}");
                Console.WriteLine($"{i} => {ifelse.FizzBuzz(i)} = ra {ranges.FizzBuzz(i)}");
                Console.WriteLine($"{i} => {ifelse.FizzBuzz(i)} = in {infinityPosition.FizzBuzz(i)}");
            }

            Console.ReadKey();
        }
    }
}
