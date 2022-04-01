using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Snake And Ladder Game");
            SnakeAndLadder snakeAndLadder = new SnakeAndLadder();
            snakeAndLadder.StartGame(); // Call the Method.
            Console.ReadLine();
        }
    }
}
