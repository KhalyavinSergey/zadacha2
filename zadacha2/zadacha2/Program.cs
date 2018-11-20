using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1; 
            
            double s = 0; 
            for (int i = 1; i <= n; i++)
            { 
                s += 5 / (25 * (Math.Pow(n, 2)) - 5 * n - 6);
                

                }
                Console.WriteLine("Sum = {0}", s);
                Console.ReadLine();

            }
        }
    }

   
