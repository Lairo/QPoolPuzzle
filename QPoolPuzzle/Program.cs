using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QPoolPuzzle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Q q = new Q(Q.R.Next(3) == 1);
            while (true)
            {
                Console.Write($"{q.N1} {q.Op} {q.N2} = ");
                if(!int.TryParse(Console.ReadLine(), out int i))
                {
                    Console.WriteLine("Thanks for Playing!");
                    return;
                }
                if (q.Check(i))
                {
                    Console.WriteLine("Right!");
                    q = new Q(Q.R.Next(3) == 1);
                }
                else Console.WriteLine("Wrong! Try again.");
            }
        }
    }
}
