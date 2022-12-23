using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i<10)
            {
                if(i==3)
                {
                    continue;
                }
                Console.WriteLine(i++);
            }
        }
    }
}
