using System;
using Xunit;
using FizzBuzz;

namespace Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(5, "1.2.Fizz.4.Buzz.")]
        [InlineData(16, "1.2.Fizz.4.Buzz.Fizz.7.8.Fizz.Buzz.11.Fizz.13.14.FizzBuzz.16.")]
        public void TestFizzBuzz(int input, string expected)
        {
            var app = new FizzBuzz.FizzBuzz();

            InMemReadWriter inmemReadWriter = new InMemReadWriter();
            app.PrintFizzBuzz(input, inmemReadWriter);

            Assert.Equal(expected, inmemReadWriter.Read());
        }
    }

    public class InMemReadWriter : Writer
    {
        private string mem { get; set; } = "";
        public void WriteLine(string value)
        {
            this.mem +=  $"{value}.";
        }

        public string Read() {
            return this.mem;
        }
    }
}
