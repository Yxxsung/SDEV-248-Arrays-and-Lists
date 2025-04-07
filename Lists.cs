//Sophia Alexander
//Last edited 04/07/2025

using System;
using System.console;

namespace Exams
{
    class ScoreArray
    {
        static void Main()
        {
            int[] scores = {40, 80, 50, 75, 60, 55}

            Array.Sort(scores);

            foreach(int i in scores)
            {
                Console.WriteLine(i)
            }
        }
    }
}