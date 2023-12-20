using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArrayLibrary
{
    public class SortArrayClass
    {

      
        public static int[] SortIntArray(int[] array, bool mode)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (mode ? array[j] < array[minIndex] : array[j] > array[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = array[minIndex];
                array[minIndex] = array[i];
                array[i] = temp;
            }
            return array;
        }

        public static float[] SortFloatArray(float[] array, bool mode)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (mode ? array[j] < array[minIndex] : array[j] > array[minIndex])
                    {
                        minIndex = j;
                    }
                }
                float temp = array[minIndex];
                array[minIndex] = array[i];
                array[i] = temp;
            }
            return array;
        }

        public static char[] SortCharArray(char[] array, bool mode)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (mode ? array[j] < array[minIndex] : array[j] > array[minIndex])
                    {
                        minIndex = j;
                    }
                }
                char temp = array[minIndex];
                array[minIndex] = array[i];
                array[i] = temp;
            }
            return array;
        }


        public static string[] SortStringArray(string[] array, bool mode)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (mode ? array[j].CompareTo(array[minIndex]) < 0 : array[j].CompareTo(array[minIndex]) > 0)
                    {
                        minIndex = j;
                    }
                }
                string temp = array[minIndex];
                array[minIndex] = array[i];
                array[i] = temp;
            }
            return array;
        }



    }
}
