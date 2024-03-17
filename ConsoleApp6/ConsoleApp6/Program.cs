using System.Diagnostics.Tracing;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = ("Shirkhan Asgarov");
            Head(str);
        }
        public static void Head(string str)
        {
            string empty = "";
            for (int i = 0; i < str.Length; i++)
            {

                if (str[i]!=' ')
                {
                    empty += str[i];
                }



            }
            Console.WriteLine(empty);
          

        }
        
        
    }
}
