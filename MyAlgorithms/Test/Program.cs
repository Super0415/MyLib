using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyAlgorithms.Sort;
namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo key = new ConsoleKeyInfo();
            do
            {



                int TestNum = 1000000;
                long start = DateTime.Now.Ticks;  //1Ticks = 0.0001ms = 0.1um = 100ns
                List<int> temp0 = new List<int>();
                for (int i = 0; i < TestNum; i++)
                {
                    temp0 = Bubble.Func_AscendingOrder(new List<int> { 2, 1, 5, 4, 8, 6, 3, 9, 6, 13, 17, 15, 19, 12, 28, 26, 24, 31, 37, 35, 38, 41, 42, 47, 49 });
                }
                string result = string.Format("{0}(耗时：{1})", string.Join(",", temp0.ToArray()), (DateTime.Now.Ticks - start) / 10);
                Console.WriteLine(result);


                start = DateTime.Now.Ticks;
                int[] temp1 = new int[] { };
                for (int i = 0; i < TestNum; i++)
                {
                    temp1 = Bubble.Func_AscendingOrder(new int[] { 2, 1, 5, 4, 8, 6, 3, 9, 6, 13, 17, 15, 19, 12, 28, 26, 24, 31, 37, 35, 38, 41, 42, 47, 49 });
                }
                result = string.Format("{0}(耗时：{1})", string.Join(",", temp1.ToArray()), (DateTime.Now.Ticks - start) / 10);
                Console.WriteLine(result);


                start = DateTime.Now.Ticks;
                List<int> temp2 = new List<int>();
                for (int i = 0; i < TestNum; i++)
                {
                    temp2 = Bubble.Func_DescendingOrder(new List<int> { 2, 1, 5, 4, 8, 6, 3, 9, 6, 13, 17, 15, 19, 12, 28, 26, 24, 31, 37, 35, 38, 41, 42, 47, 49 });
                }
                result = string.Format("{0}(耗时：{1})", string.Join(",", temp2.ToArray()), (DateTime.Now.Ticks - start) / 10);
                Console.WriteLine(result);

                start = DateTime.Now.Ticks;
                int[] temp3 = new int[] { };
                for (int i = 0; i < TestNum; i++)
                {
                    temp3 = Bubble.Func_DescendingOrder(new int[] { 2, 1, 5, 4, 8, 6, 3, 9, 6, 13, 17, 15, 19, 12, 28, 26, 24, 31, 37, 35, 38, 41, 42, 47, 49 });
                }
                result = string.Format("{0}(耗时：{1})", string.Join(",", temp3.ToArray()), (DateTime.Now.Ticks - start) / 10);
                Console.WriteLine(result);

                start = DateTime.Now.Ticks;
                char[] temp4 = new char[] { };
                for (int i = 0; i < TestNum; i++)
                {
                    temp4 = Bubble.Func_AscendingOrder(new char[] { 'a', 's', 'd', 'f', 'g' });
                }
                result = string.Format("{0}(耗时：{1})", string.Join(",", temp4.ToArray()), (DateTime.Now.Ticks - start) / 10);
                Console.WriteLine(result);

                //start = DateTime.Now.Ticks;
                //List<int> temp5 = new List<int>();
                //for (int i = 0; i < TestNum; i++)
                //{
                //    temp5 = BinaryTree.Func_AscendingOrder(new List<int> { 2, 1, 5, 4, 8, 6, 3, 2, 6, 8, 4, 2, 5, 67, 3, 2, 9, 56, 23, 5, 3 });
                //}
                //result = string.Format("{0}(耗时：{1})", string.Join(",", temp5.ToArray()), (DateTime.Now.Ticks - start) / 10);
                //Console.WriteLine(result);

                start = DateTime.Now.Ticks;
                int[] temp6 = new int[] { };
                BinaryTree.Tree<int> t = new BinaryTree.Tree<int>();
                List<int> lis = new List<int> { 2, 1, 5, 4, 8, 6, 3, 9, 6, 13, 17, 15, 19, 12, 28, 26, 24, 31, 37, 35, 38, 41, 42, 47, 49 };

                BinaryTree.FillTree(lis, t);
                for (int i = 0; i < TestNum; i++)
                {
                    temp6 = BinaryTree.PreOrder(t);
                }
                result = string.Format("{0}(耗时：{1})", string.Join(",", temp6), (DateTime.Now.Ticks - start) / 10);
                Console.WriteLine(result);
                key = Console.ReadKey();

                Console.WriteLine("************************************************");

            }
            while (key.KeyChar == 'y');
        }
    }
}
