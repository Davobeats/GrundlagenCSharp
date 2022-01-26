using System;
using System.Threading;
namespace SchleifenÜbungenA1
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 50; i>=0;i--)
            {
                Thread.Sleep(1000);
                Console.WriteLine(i);
            }

        }
    }
}
