using System;


namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N=");
            int number = Int32.Parse(Console.ReadLine());

            
            for (int i = 1; i < number+1; i++)
            {


                for (int j = 1; j < number+1; j++)
                {
                    if (i == j)
                        continue;

                    Console.WriteLine("{0} {1}", i, j);
                }
            }
        }
    }
}
