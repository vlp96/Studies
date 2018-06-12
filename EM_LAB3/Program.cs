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

            //LinkedList number1 = new LinkedList(156, null);
            //LinkedList number2 = new LinkedList(215, number1);
            //LinkedList number3 = new LinkedList(318, number2);
            //LinkedList number4 = new LinkedList(50, number3);
            //LinkedList number5 = new LinkedList(400, number4);
            //LinkedList number6 = new LinkedList(27, number5);

            //LinkedList currentnumber = number1;
            //LinkedList compnumber = number1;

            //while(currentnumber.value > )

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

    public class LinkedList
    {
        public int value;
        LinkedList next;
        public LinkedList(int value, LinkedList next)
        {
            this.value = value;
            this.next = next;
        }
    }
}

//ДЗ: Сделать сортировку вставкой для LinkedList (+ посчитать асимптотическую сложность (для массива - О(n^2)))! 
//Корзиночная сортировка (BinSort, сортировка подсчетом, карманная, поразрядная, цифровая). 