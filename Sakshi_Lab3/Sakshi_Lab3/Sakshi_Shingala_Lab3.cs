using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakshi_Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] weekDays = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday"};
            string[] weekEnds = { "Saturday", "Sunday" };

            for (int i = 0; i < weekDays.Length; i++)
            {
                Console.WriteLine($"\n{ weekDays[i]}\n");
                for (int j = 1; j <= 12; j++)
                {
                    if(j >= 11 && j < 12)
                    {
                        Console.WriteLine($"{j} AM : On-Peak");
                    }
                    else if (j >= 7 && j <= 11) 
                    {
                        Console.WriteLine($"{j} AM : Mid-Peak");
                    }
                    else
                    {
                        Console.WriteLine($"{j} AM : Off-Peak");
                    }
                }
                for (int k = 1; k <= 12; k++)
                {
                    if (k >= 7 && k < 12)
                    {
                        Console.WriteLine($"{k} PM : Off-Peak");
                    }
                    else if (k >= 5 && k < 7)
                    {
                        Console.WriteLine($"{k} PM : Mid-Peak");
                    }
                    else
                    {
                        Console.WriteLine($"{k} PM : On-Peak");
                    }
                }
            }

            for (int a = 0; a < weekEnds.Length; a++)
            {
                Console.WriteLine($"\n{weekEnds[a]}\n");
                for (int b = 1; b <= 12; b++)
                {
                    Console.WriteLine($"{b} AM : Off-Peak");
                }
                for (int c = 1; c <= 12; c++)
                {
                    Console.WriteLine($"{c} PM : Off-Peak");
                }
            }
        }
    }
}
