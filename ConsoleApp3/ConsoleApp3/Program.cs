using System.ComponentModel.DataAnnotations;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Pold(1234));
        }









        public static int Pold(int nums)
        {

            
            int b = 0;
            while (nums > 0)
            {
                int qaliq = nums % 10;
                b = (b * 10) + qaliq;
                nums = nums / 10;
              
            }
            return b;



        }

    }
}