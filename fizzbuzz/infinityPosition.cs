namespace fizzbuzz;

class InfinityPosition
{
    public string FizzBuzz(int number)
    {
        IEnumerable<int> List(int skip, int p)
            => Enumerable.Repeat(0, skip).Concat(new[] { p });

        IEnumerable<int> Repeat(IEnumerable<int> list, int repete)
            => Enumerable.Repeat(list, 5).SelectMany(f => f);
        
        var fizz = Repeat(List(2, 1), 5);
        var buzz = Repeat(List(4, 2), 3);

        var firstFisteen = fizz
            .Zip(buzz,(f,b) => f + b)
            .Reverse()
            .ToArray();

        var infinity = Enumerable.Repeat(firstFisteen,7)
            .SelectMany(f => f)
            .Take(100)
            .ToArray();

        return new[] { number.ToString(), "fizz", "buzz", "fizzbuzz" }
            [infinity[number]];
    }
}
