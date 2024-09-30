using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Runtime.InteropServices;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Threading;

namespace stacks_30._09._24
{
    internal class Program
    {
        static void Main(string[] args)
          {
            bool quit = false;
            while (quit == false)
            {
                int count = 0;
                List<int> stack1 = new List<int>();
                Console.WriteLine($"Items in stack: {count}\n");
                Console.WriteLine("OPTIONS:\n");
                Console.WriteLine("1) Push");
                Console.WriteLine("2) Peek");
                Console.WriteLine("3) Pop");
                Console.WriteLine("4) Quit\n");
                
                
                    Console.WriteLine($"Stack Contents: {stack1.ToString()}");
                
                
                Console.Write("\n\n\n\n\n\n\n\nEnter choice: ");
                int input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    Push(stack1);
                    count += 1;
                }
                if (input == 2)
                {
                    Peek();
                }
                if (input == 3)
                {
                    Pop();
                }
                if (input == 4)
                {
                    quit = true;
                    return;
                }
               
            }
            
        }
        static void Peek()
        {
            
        }
        static void Pop()
        {

        }
        static void Push(List<int>stack1)
        {
            Console.Clear();
            Console.Write("Enter number to add: ");
            int number = int.Parse(Console.ReadLine());
            stack1.Add(number);
            
            Console.Clear();
            

        }
        
    }
}
