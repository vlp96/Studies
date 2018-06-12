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
            //long InitialWorkingSet = GC.GetTotalMemory(true);

            //int N = 1000000*100;
            //int[] nums = new int[N];

            //long ResultWorkingSet = GC.GetTotalMemory(true);

            //long IntResult = (ResultWorkingSet - InitialWorkingSet) / (1024 * 1024);

            //InitialWorkingSet = GC.GetTotalMemory(true);

            //decimal[] numsdec = new decimal[N];

            //ResultWorkingSet = GC.GetTotalMemory(true);

            //long DecResult = (ResultWorkingSet - InitialWorkingSet) / (1024 * 1024);

            //Console.WriteLine(IntResult);
            //Console.WriteLine(DecResult);

            //Console.ReadLine();

            int N = 4;
            int[] nums = new int[] {156, 215, 318,  50};
            int[] res = new int[N];

            int i = 0;

            while (i < 4)
            {
                int maxnumber = nums.Max();
                int j = 0;
                while (maxnumber != nums[j])
                {
                    //if (rand == nums[j])
                    //{

                    //    break;
                    //}
                    j++;
                }

                res[i] = nums[j];
                nums[j] = -1;

                i++;

            }

            for (i = 0; i < N; i++)
            {
                Console.WriteLine(res[i]);
            }

            //Console.WriteLine(fact(3));

            Console.ReadLine();

        }

        //static int fact(int x)
        //{
        //    if (x != 1)
        //        return x * fact(x - 1);
        //    else
        //    {
        //        return 1;
        //    }

                    
        //}
    }

}

//ДЗ: сортировка вставкой (Insertion Sort) + понять, почему сортировка выбором (Selection Sort) работает быстрее