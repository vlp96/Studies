using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine(IntPtr.Size);
            Console.WriteLine(Environment.Is64BitOperatingSystem);*/
            int N = 1000 * 300;
            int[] nums = new int[N];
            Random rand1 = new Random();
            for (int i = 0; i < N; i++)
            {
                nums[i] = i+1;
            //Console.WriteLine(nums[i]);
            }

            int rand = rand1.Next(0, N);
            Console.WriteLine(rand);
            int j = 0;
            while (rand != nums[j])
            {
                //if (rand == nums[j])
                //{
                    
                //    break;
                //}
                        j++;
            }
            Console.WriteLine("Найдено на " + (j += 1) + " этапе");

            Console.WriteLine("Бинарный поиск");
            int low = 0;
            int check = 0;
            int high = nums.Length - 1;

            int point = 0;

            while (low < high)
            {
                point = (low + high) / 2;
                if (rand > nums[point])
                    low = point + 1;
                else if (rand < nums[point])
                    high = point - 1;
                else
                    break;
                check++;
                //Console.WriteLine(low);
                //Console.WriteLine(high);
            }

            Console.WriteLine("Найдено на " + (check += 1) + " этапе(" + (nums[point]) + ")");
                        
            Console.ReadLine();
        }
    }

}
