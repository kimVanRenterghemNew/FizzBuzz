namespace fizzbuzz
{
    class ifif
    {
        public string FizzBuzz (int number ){
            var result = "";

            if (number % 3 == 0)
                result += "fizz";
            if (number % 5 == 0)
                result += "buzz";
            if (result == "")
                result += number;

            return result;
        }
    }
}
