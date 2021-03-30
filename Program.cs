using System;

namespace repitition_nested
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name? ");
            string name = Console.ReadLine();
            int counter = 0;

            while(counter < 10){
                counter = counter + 1;
                int counter2 = 0;
                while(counter2 < 5){
                    Console.WriteLine(name);
                    counter2 = counter2 + 1;
                }
                Console.WriteLine();

            }
            Console.WriteLine("Goodbye " + name);
        }
    }
}
