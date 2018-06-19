using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EM_LAB3
{
class Program
    {
        static void Main(string[] args)
        {

            int N = 6;
            int[] nums = new int[] { 156, 215, 318, 50, 400, 27 };
            int[] res = new int[N];

            int i, j;
            int hold, position;

            for (i = 2; i < N; i++)
            {
                hold = nums[i];
                position = 0;
                while (hold < nums[position])
                {
                    position = position + 1;
                }
                if (position < i)
                {
                    for (j = i; j > position; j--)
                    {
                        nums[j] = nums[j - 1];
                    }
                    nums[position] = hold;
                }
            }

            for (i = 0; i < N; i++)
            {
                Console.WriteLine(nums[i]);
            }
            Console.ReadLine();

            for (i = 2; i < N; i++)
            {
                hold = nums[i];
                position = 0;
                while (hold > nums[position])
                {
                    position = position + 1;
                }
                if (position < i)
                {
                    for (j = i; j > position; j--)
                    {
                        nums[j] = nums[j - 1];
                    }
                    nums[position] = hold;
                }
            }

            for (i = 0; i < N; i++)
            {
                Console.WriteLine(nums[i]);
            }
            Console.ReadLine();

        }
    }
}