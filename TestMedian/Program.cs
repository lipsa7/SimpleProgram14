using System;
using System.Collections.Generic;
using System.Linq;

namespace TestMedian
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 0;
            int sum = 0;
            //List<int> list1 = new List<int>();
            Console.Write("Enter the size of first array");
            int m = Convert.ToInt32(Console.ReadLine());

            if (m > 0)
            {
                Console.WriteLine("Enter elements of first array");
                for (int i = 0; i < m; i++)
                {
                    try
                    {
                        //list1.Add(Convert.ToInt32(Console.ReadLine()));
                        sum += Convert.ToInt32(Console.ReadLine());

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        Console.WriteLine("Please enter the number again");
                    }


                }
            }

            

            //List<int> list2 = new List<int>();
            Console.Write("Enter the size of second array");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n > 0)
            {
                Console.WriteLine("Enter elements of second array");
                for (int i = 0; i < n; i++)
                {
                    try
                    {
                        sum += Convert.ToInt32(Console.ReadLine());

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        Console.WriteLine("Please enter the number again");
                    }


                }
            }
            
            if(m>0 || n > 0)
            {
                

                double median = (double)sum / (double)(m + n);
                Console.WriteLine(median);
            }
            else
            {
                Console.WriteLine("0");
            }
            

            


        }
    }
}
