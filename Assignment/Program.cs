using System;
using System.Collections.Generic;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Draw draw = new Draw();
                draw.Print();        
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("It is not in the given ranges", e);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("It is not an odd number", e);
            }
            catch (Exception e)
            {
                Console.WriteLine("Something goes wrong", e);
            }
        }
    }
}