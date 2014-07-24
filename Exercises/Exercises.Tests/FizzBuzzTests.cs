using NUnit.Framework;

namespace Exercises.Tests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        public void FizzBuzz_Returns_Fizz_For_Multiples_Of_Three()
        {
            var fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.Run();

            /*
            foreach (var number in result)
            {
                
                if(number.s)
                Assert.That();
            } 
            */

            Assert.That(result[3], Is.EqualTo("Fizz"));
            Assert.That(result[6], Is.EqualTo("Fizz"));
            Assert.That(result[27], Is.EqualTo("Fizz"));
        }


        [Test]
        public void FizzBuzz_Returns_Buzz_For_Multiples_Of_Five()
        {
            var fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.Run();

            Assert.That(result[5], Is.EqualTo("Buzz"));
            Assert.That(result[10], Is.EqualTo("Buzz"));
            Assert.That(result[35], Is.EqualTo("Buzz"));
        }

        [Test]
        public void FizzBuzz_Returns_FizzBuzz_For_Multiples_Of_Three_And_Five()
        {
            var fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.Run();

            Assert.That(result[15], Is.EqualTo("FizzBuzz"));
            Assert.That(result[30], Is.EqualTo("FizzBuzz"));
            Assert.That(result[45], Is.EqualTo("FizzBuzz"));

        }

        [Test]
        public void FizzBuzz_Can_Run()
        {
            var fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.Run();

            Assert.That(result.Length, Is.EqualTo(100));
        }
    }
}
