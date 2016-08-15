using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenPin
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Game();

            for (int i = 0; i < 10; i++)
            {
                game.Roll(3);
                game.Roll(4);
            }

            Console.WriteLine(game.Score());
            Console.ReadLine();
        }
    }
}
