using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAlgorithms.Character
{
    /// <summary>
    /// 字符数组处理
    /// </summary>
    public static class CharacterArray
    {

        /// <summary>
        /// 根据屏蔽字对字符数组中的元素进行删除
        /// </summary>
        /// <param name="data"></param>
        /// <param name="Mask"></param>
        /// <returns></returns>
        public static char[] Func_MaskChar(char[] data, char[] Mask)
        {
            if (Mask != null)
            {
                int count = 0;
                int len = data.Length;
                char[] result = new char[len];
                for (int i = 0; i < len; i++)
                {
                    if (!Mask.Contains(data[i]))
                    {
                        result[count++] = data[i];
                    }
                }
                return result;
            }
            return data;
        }
    }
}
