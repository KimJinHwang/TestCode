using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _220113_Test_for_foreach
{
    class Program
    {
        static int size = 200000000;    // size = int.maxValue;

        static void Main(string[] args)
        {
            int[] array = new int[size];    
            List<int> list = new List<int>();
            list.Capacity = size;
            for (int i = 0; i < size; i++)
            {
                array[i] = i;
                list.Add(i);
            }
            Console.WriteLine("Array Test");
            Console.WriteLine(ArrayForWithoutOptimization(array));
            Console.WriteLine(ArrayForWithOptimization(array));
            Console.WriteLine(Arrayforeach(array));
            Console.WriteLine(ArrayForEach(array));
            Console.WriteLine("\nList Test");
            Console.WriteLine(ListForWithoutOptimization(list));
            Console.WriteLine(ListForWithOptimization(list));
            Console.WriteLine(Listforeach(list));
            Console.WriteLine(ListForEach(list));
            Console.ReadKey();
        }
        static double ArrayForWithoutOptimization(int[] array)
        {
            int sum = 0;
            DateTime timeStart = DateTime.Now;
            for (int i = 0; i < array.Length; i++)
                sum += array[i];
            DateTime timeEnd = DateTime.Now;

            return (timeEnd - timeStart).TotalSeconds;
        }
        static double ArrayForWithOptimization(int[] array)
        {
            int length = array.Length;
            int sum = 0;
            DateTime timeStart = DateTime.Now;
            for (int i = 0; i < length; i++)
                sum += array[i];
            DateTime timeEnd = DateTime.Now;

            return (timeEnd - timeStart).TotalSeconds;
        }
        static double Arrayforeach(int[] array)
        {
            int sum = 0;
            DateTime timeStart = DateTime.Now;
            foreach (var item in array)
                sum += item;
            DateTime timeEnd = DateTime.Now;

            return (timeEnd - timeStart).TotalSeconds;
        }
        static double ArrayForEach(int[] array)
        {
            int sum = 0;
            DateTime timeStart = DateTime.Now;
            Array.ForEach(array, (i) => { sum += i; /*Console.WriteLine(i);*/ });
            DateTime timeEnd = DateTime.Now;

            return (timeEnd - timeStart).TotalSeconds;
        }
        static double ListForWithoutOptimization(List<int> list)
        {
            int sum = 0;
            DateTime timeStart = DateTime.Now;
            for (int i = 0; i < list.Count; i++)
                sum += list[i];
            DateTime timeEnd = DateTime.Now;

            return (timeEnd - timeStart).TotalSeconds;
        }
        static double ListForWithOptimization(List<int> list)
        {
            int length = list.Count;
            int sum = 0;
            DateTime timeStart = DateTime.Now;
            for (int i = 0; i < length; i++)
                sum += list[i];
            DateTime timeEnd = DateTime.Now;

            return (timeEnd - timeStart).TotalSeconds;
        }
        static double Listforeach(List<int> list)
        {
            int sum = 0;
            DateTime timeStart = DateTime.Now;
            foreach (var item in list)
                sum += item;
            DateTime timeEnd = DateTime.Now;

            return (timeEnd - timeStart).TotalSeconds;
        }
        static double ListForEach(List<int> list)
        {
            int sum = 0;
            DateTime timeStart = DateTime.Now;
            list.ForEach((i) => { sum += i; /*Console.WriteLine(i);*/ });
            DateTime timeEnd = DateTime.Now;

            return (timeEnd - timeStart).TotalSeconds;
        }
    }
}
