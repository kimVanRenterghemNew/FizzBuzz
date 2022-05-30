namespace fizzbuzz;
class Composition
{
    public string FizzBuzz(int number)
    {
        Func<string, string> Test(int d, string s, Func<string, string> x)
            => number % d == 0 ? _
                => s + "" + x("") : x;
        Func<string, string> Fizz(Func<string, string> x)
            => Test(3, "fizz", x);
        Func<string, string> Buzz(Func<string, string> x)
            => Test(5, "buzz", x);
        return Fizz(Buzz(x => x))(number.ToString());
    }
}
