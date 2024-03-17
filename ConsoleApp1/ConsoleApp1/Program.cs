namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] word = { "Yusif", "Resul", "Enver" };

            string a = "2";
            string b = word[2];
            for (int i = 0; i <word.Length ; i++)
            {
                for (int i= word.Length - 1; i >= 0; i--)
                {

                    if (a==b)
                    {
                        Console.WriteLine();
                    }
                    

                }



            } 
            
        }
    }
}