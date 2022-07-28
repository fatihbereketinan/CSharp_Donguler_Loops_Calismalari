using System;

namespace SayiYazdirma
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1
              12
              123
              .
              .
              123456789 şeklinde ekrana yazdırınız*/
           
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine("");
            }
        }
    }
}
