namespace fizzbuzz;

class Ranges
{
    public string FizzBuzz(int number)
    {
        var allrange = Enumerable.Range(1, 100);
        var fizzBuzzRange = allrange.Where(i => i % 15 == 0);
        var fizzRange = allrange.Where(i => i % 3 == 0);
        var buzzRange = allrange.Where(i => i % 5 == 0);

        string? Test(IEnumerable<int> range, string word)
            => range.Any(i => i == number) ? word : null;

        return Test(fizzBuzzRange, "fizzbuzz") ??
            Test(fizzRange, "fizz") ??
            Test(buzzRange, "buzz") ??
            number.ToString();
    }
}
