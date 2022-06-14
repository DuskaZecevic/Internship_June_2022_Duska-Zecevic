using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Socks
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            int[] arr = { 1, 2, 1, 2, 1, 3, 2 };
            List<int> list = new List<int>();
            foreach (int item in arr)
            { int count = 0;
                foreach (int i in arr)
                {
                    if (item == i)
                    {
                        count++;
                        if (count > 1)
                        {
                            if (!list.Contains(i))
                            {
                                list.Add(i);
                            }
                        }
                    }
                }
            }
            foreach(var item in list)
            {
                Console.WriteLine("We have a pair of colored socks under number " + item);
            }
             
            Console.ReadLine();



        }
    }
}
