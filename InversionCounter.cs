using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProgram
{
    public class InversionCounter
    {
        int[] array;

        public InversionCounter(IEnumerable<int> list)
        {
            array = list.ToArray();
        }

        private int Merge(int firstStartIndex, int firstEndIndex,
                          int secondStartIndex, int secondEndIndex)
        {
            int counter = 0;
            for (int i = firstStartIndex; i <= firstEndIndex; i++)
            {
                for (int j = secondStartIndex; j <= secondEndIndex; j++)
                {
                    if (array[i] > array[j])
                    {
                        counter++;
                    }
                }
            }
            return counter;
        }

        private int CountInversion(int start, int end)
        {
            if (start >= end)
            {
                return 0;
            }

            int mid = start + (end - start) / 2;

            return CountInversion(start, mid) + CountInversion(mid + 1, end)
                + Merge(start, mid, mid + 1, end);
        }

        public int GetInversion()
        {
            return CountInversion(0, array.Length - 1);
        }
    }
}
