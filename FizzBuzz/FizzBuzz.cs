namespace FizzBuzz
{
    public class FizzBuzz
    {
        public void PrintFizzBuzz(int n, Writer writer)
        {
            for (int i = 1; i <= n; i++)
            {
                string strg = "";

                if (i % 3 == 0)
                {
                    strg += "Fizz";
                }
                if (i % 5 == 0)
                {
                    strg += "Buzz";
                }
                if (strg.Length == 0)
                {
                    strg = i.ToString();
                }
                writer.WriteLine(strg);

            }
        }
    }
    public interface Writer
    {
        void WriteLine(string value);
    }
}
