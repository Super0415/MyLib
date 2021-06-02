using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAlgorithms.Array
{
    /// <summary>
    /// 数据相关
    /// </summary>
    public static class ArrayCorrelation
    {

        /// <summary>
        /// 追加数组
        /// </summary>
        /// <param name="tag">目标数组</param>
        /// <param name="src">资源数组</param>
        /// <returns></returns>
        public static int[] ArrayAppend(int[] tag,int[] src)
        {
            if (tag == null || src == null)
                return null;
            int[] temp = new int[tag.Length + src.Length];
            for (int i = 0; i < tag.Length; i++)
            {
                temp[i] = tag[i];
            }
            for (int i = 0; i < src.Length; i++)
            {
                temp[i + tag.Length] = src[i];
            }

            return temp;
        }

        /// <summary>
        /// 覆盖数组
        /// 将资源数组，从偏移序号开始覆盖到目标数组中
        /// </summary>
        /// <param name="tag">目标数组</param>
        /// <param name="index">偏移序号</param>
        /// <param name="src">资源数组</param>
        /// <returns></returns>
        public static int[] ArrayCover(int[] tag, int index ,int[] src)
        {
            if (tag == null || src == null)
                return null;
            if (tag.Length - index < src.Length)
                return tag;
            for (int i = 0; i < src.Length; i++)
            {
                tag[i + index] = src[i];
            }
            return tag;
        }

    }
}
