using MyAlgorithms.Array;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAlgorithms.Sort
{
    /// <summary>
    /// 二叉树排序-树的左节点小
    /// </summary>
    public static class BinaryTree
    {
        /// <summary>
        /// 定义一个树结构
        /// </summary>
        public class Tree<T>
        {
            /// <summary>
            /// 节点内容
            /// </summary>
            public T Value = default(T);
            /// <summary>
            /// 节点个数(包含本身)
            /// </summary>
            public int NodeCount = 0;
            /// <summary>
            /// 树的左分支-小
            /// </summary>
            public Tree<T> Left = null;
            /// <summary>
            /// 树的右分支-大
            /// </summary>
            public Tree<T> Right = null;
        }

        /// <summary>
        /// 填充树
        /// </summary>
        /// <param name="datain"></param>
        /// <param name="t">int类型的树结构</param>
        public static Tree<int> FillTree(int datain, Tree<int> t)
        {
            if (t.NodeCount == 0)
            {
                t.NodeCount++;  //节点自增1
                t.Value = datain;
                return t;
            }
            t.NodeCount++;  //节点自增1

            if (datain <= t.Value)  //输入数据小于等于节点数据，归到左节点
            {
                if (t.Left == null) //没有子节点，可接续
                {
                    Tree<int> node = new Tree<int>();
                    node.NodeCount++;
                    node.Value = datain;
                    t.Left = node;
                }
                else                //有左节点，传入左节点查询
                {
                    FillTree(datain, t.Left);
                }
            }
            else //归到右节点
            {
                if (t.Right == null) //没有子节点，可接续
                {
                    Tree<int> node = new Tree<int>();
                    node.NodeCount++;
                    node.Value = datain;
                    t.Right = node;
                }
                else                //有左节点，传入左节点查询
                {
                    FillTree(datain, t.Right);
                }
            }

            return t;
        }

        /// <summary>
        /// 填充树
        /// </summary>
        /// <param name="data"></param>
        /// <param name="t">int类型的树结构</param>
        public static Tree<int> FillTree(List<int> data, Tree<int> t)
        {
            foreach (int item in data)
            {
                FillTree(item,t);
            }

            return t;
        }



        /// <summary>
        /// 先序遍历，从左到右
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public static int[] PreOrder(Tree<int> t)
        {
            int[] temp = new int[t.NodeCount];
            if (t.NodeCount == 0)
            {
                return temp;
            }
            else if (t.NodeCount == 1)
            {
                temp[0] = t.Value;
            }
            else if (t.NodeCount == 2)
            {
                if (t.Left == null)
                {               
                    temp[0] = t.Value;
                    ArrayCorrelation.ArrayCover(temp, 1, PreOrder(t.Right));
                }
                else
                {
                    ArrayCorrelation.ArrayCover(temp, 0, PreOrder(t.Left));
                    temp[t.NodeCount - 1] = t.Value;
                }
            }
            else
            {
                if (t.Left != null && t.Left != null)
                {
                    ArrayCorrelation.ArrayCover(temp, 0, PreOrder(t.Left));
                    temp[t.Left.NodeCount] = t.Value;
                    ArrayCorrelation.ArrayCover(temp, t.Left.NodeCount + 1, PreOrder(t.Right));
                }
                else if (t.Left == null)
                {
                    temp[0] = t.Value;
                    ArrayCorrelation.ArrayCover(temp, 1, PreOrder(t.Right));
                }
                else
                {
                    ArrayCorrelation.ArrayCover(temp, 0, PreOrder(t.Left));
                    temp[t.NodeCount - 1] = t.Value;
                }

            }

            return temp;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static List<int> Func_AscendingOrder(List<int> data)
        {
            //建立一个树
            Tree<int> t = new Tree<int>();
            foreach (int item in data)
            {
                //往树中存值
                FillTree(item, t);    
            }

            int[] temp = PreOrder(t);
            return temp.ToList();
        }

    }
}
