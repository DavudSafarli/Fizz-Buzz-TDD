using System;
using Xunit;
using FizzBuzz;

namespace Test
{
    public class UnitTest1
    {
        [Fact]
        public void TestFizzBuzz()
        {
            var app = new FizzBuzz.FizzBuzz();

            int input = 5;
            string expected = "1\n2\nFizz\n4\nBuzz\n";

            InMemWriter inmemReadWriter = new InMemWriter();
            app.PrintFizzBuzz(input, inmemReadWriter);

            Assert.Equal(expected, inmemReadWriter.Read());
        }
    }

    public class InMemWriter : Writer
    {
        private string mem { get; set; } = "";
        public void WriteLine(string value)
        {
            this.mem +=  $"{value}\n";
        }

        public string Read() {
            return this.mem;
        }
    }
}
