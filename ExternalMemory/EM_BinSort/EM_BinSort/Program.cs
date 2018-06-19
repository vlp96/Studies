using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EM_BinSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 6;
            int[] nums = new int[] { 156, 215, 318, 50, 400, 27 };

            int minValue = nums[0];
            int maxValue = nums[0];
        
            for(int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > maxValue)
                    maxValue = nums[i];
                if (nums[i] < minValue)
                    minValue = nums[i];
            }

            var bin = new List<int>[maxValue - minValue + 1];

            for (int i = 0; i < bin.Length; i++)
                bin[i] = new List<int>();

            for (int i = 0; i < nums.Length; i++)
                bin[nums[i] - minValue].Add(nums[i]);

            int k = 0;
            for (int i = 0; i < bin.Length; i++)
            {
                if (bin[i].Count > 0)
                {
                    for (int j = 0; j < bin[i].Count; j++)
                    {
                        nums[k] = bin[i][j];
                        k++;
                    }
                }
            }

            for(int i = 0; i < N; i++)
            {
                Console.WriteLine(nums[i]);
            }
            Console.ReadLine();
        }
    }
}
