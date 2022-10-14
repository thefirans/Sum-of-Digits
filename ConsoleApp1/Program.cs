using System;
using System.Data;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Number
    {
        public int DigitalRoot(long n)
        {
            long result = n;
            do
            {
                var list = result.ToString().Select(c => int.Parse(c.ToString())).ToList(); // split n into digits
                result = list.Sum(c => Convert.ToInt32(c)); // sum of digits
            } while (result > 9);
            return (int)result;
        }
    }
}
