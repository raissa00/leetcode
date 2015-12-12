using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MoveZeroes_283
{
    public static void MoveZeroes(int[] nums)
    {
        int numLen = nums.Length;
        int j = 0;
        for (int i = 0; i < numLen; i++)
        {
            int numi = nums[i];
            if (numi != 0)
            {
                nums[j++] = numi;
            }
        }
        for (; j < numLen; j++)
            nums[j] = 0;
    }
}
