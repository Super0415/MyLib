using MyAlgorithms.Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAlgorithms.Sort
{
    /// <summary>
    /// 冒泡排序
    /// </summary>
    public static class Bubble
    {
        #region 升序

        /// <summary>
        /// 对输入的一维数据(int)进行升序排序
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static List<int> Func_AscendingOrder(List<int> data)
        {
            data.Sort();

            return data;
        }

        /// <summary>
        /// 对输入的一维数据(int)进行升序排序
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static int[] Func_AscendingOrder(int[] data)
        {
            int len = data.Length;

            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len - 1 - i; j++)
                {
                    if (data[j] > data[j + 1])      //当前数 比 下一个数 大 ，则交换位置
                    {
                        int temp = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = temp;
                    }
                }

            }
            return data;
        }

        /// <summary>
        /// 对输入的字符数组进行升序排序
        /// 例如"asdfg"排序后"adfgs"
        /// </summary>
        /// <param name="data">输入数据</param>
        ///  <param name="Mask">屏蔽字</param>
        /// <returns></returns>
        public static char[] Func_AscendingOrder(char[] data, char[] Mask = null)
        {
            char[] MaskChar = CharacterArray.Func_MaskChar(data,Mask);

            int len = MaskChar.Length;
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len-1-i; j++)
                {
                    if (MaskChar[j] > MaskChar[j + 1])      //当前数 比 下一个数 大 ，则交换位置
                    {
                        char temp = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = temp;
                    }
                }
            }
            return MaskChar;
        }

        /// <summary>
        /// 对输入的字符串进行升序排序
        /// 例如"asdfg"排序后"adfgs"
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string Func_AscendingOrder(string data)
        {
            char[] strCharArr = data.ToCharArray();
            return null;
        }


        #endregion

        #region 降序

        /// <summary>
        /// 降序
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static List<int> Func_DescendingOrder(List<int> data)
        {
            data.Sort();
            data.Reverse();
            return data;
        }

        /// <summary>
        /// 降序
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static int[] Func_DescendingOrder(int[] data)
        {
            int len = data.Length;

            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len - 1 - i; j++)
                {
                    if (data[j] < data[j + 1])      //当前数 比 下一个数 大 ，则交换位置
                    {
                        int temp = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = temp;
                    }
                }

            }
            return data;
        }

        #endregion
    }
}
