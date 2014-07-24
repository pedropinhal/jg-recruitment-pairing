namespace Exercises
{
    public class FizzBuzz
    {
        public string[] Run()
        {
            var result = new string[100];
            for (var i = 0; i < result.Length; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    result[i] = "FizzBuzz";
                else if (i % 3 == 0)
                    result[i] = "Fizz";
                else if (i % 5 == 0)
                    result[i] = "Buzz";
                else
                    result[i] = i.ToString();
            }
            return result;
        }
    }
}