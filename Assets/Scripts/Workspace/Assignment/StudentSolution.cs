using UnityEngine;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace Assignment
{
    public class StudentSolution : IAssignment
    {
        #region Lecture
        public int[] LCT01_SelectionSortAscending(int[] numbers)
        {
            for (int i = 0; i < numbers.Length-1; i++)
            {
                int minIndex = i;
                for (int j = i+1; j < numbers.Length; j++)
                {
                    if (numbers[j] < numbers[minIndex])
                    {
                        minIndex = j;
                    }
                }

                (numbers[i], numbers[minIndex]) = (numbers[minIndex], numbers[i]);
            }
            return numbers;
        }

        public int[] LCT02_BubbleSortAscending(int[] numbers)
        {
            for (int i =0; i < numbers.Length-1; i++)
            {
                for (int j = 0; j < numbers.Length - i - 1; j++)
                {
                    if (numbers[j] > numbers[j +1 ])
                    {
                        (numbers[j], numbers[j + 1]) = (numbers[j+1], numbers[j]);
                    }
                }
            }

            return numbers;
        }

         public int[] LCT03_InsertionSortAscending(int[] numbers)
         {int n = numbers.Length;

       for (int i = 0; i < n; i++){int key = numbers[i];

           int j = i - 1;

           while (j >= 0 && numbers[j] > key){numbers[j+1] = numbers[j];

               j--;

           }numbers[j+1] = key;

       }foreach (var n_ in numbers){Debug.Log(n_); 

       }return numbers;

   }

        #endregion

        #region Assignment

        public int[] AS01_SelectionSortDescending(int[] numbers)
        {
              for (int i = 0; i < numbers.Length-1; i++)
            {
                int minIndex = i;
                for (int j = i+1; j < numbers.Length; j++)
                {
                    if (numbers[j] > numbers[minIndex])
                    {
                        minIndex = j;
                    }
                }

                (numbers[i], numbers[minIndex]) = (numbers[minIndex], numbers[i]);
            }
            return numbers;
        }

        public int[] AS02_BubbleSortDescending(int[] numbers)
        {
            for (int i =0; i < numbers.Length-1; i++)
            {
                for (int j = 0; j < numbers.Length - i - 1; j++)
                {
                    if (numbers[j] < numbers[j +1 ])
                    {
                        (numbers[j], numbers[j + 1]) = (numbers[j+1], numbers[j]);
                    }
                }
            }

            return numbers;
        }

        public int[] AS03_InsertionSortDescending(int[] numbers)
        {
            {
            for (int i = 1; i < numbers.Length; i++)
            {
        int key = numbers[i];
        int j = i - 1;

        // เลื่อนตัวที่น้อยกว่า key ไปทางขวา เพื่อให้ key อยู่ในตำแหน่งที่ถูกต้อง (มาก -> น้อย)
        while (j >= 0 && numbers[j] < key)
        {
            numbers[j + 1] = numbers[j];
            j--;
        }

        numbers[j + 1] = key;
        }

    return numbers;
}
        }

        public int AS04_FindTheSecondLargestNumber(int[] numbers)
        {
                int largest = int.MinValue;
    int second = int.MinValue;

    foreach (int n in numbers)
    {
        if (n > largest)
        {
            second = largest;
            largest = n;
        }
        else if (n > second && n != largest)
        {
            second = n;
        }
    }

    return second;
        }

        #endregion

        #region Extra

        public int EX01_FindLongestConsecutiveSequence(int[] numbers)
{
    if (numbers == null || numbers.Length == 0)
        return 0;

    HashSet<int> set = new HashSet<int>(numbers);
    int longest = 0;

    foreach (int n in set)
    {
        // เริ่มนับเฉพาะตัวที่เป็นจุดเริ่มต้นของชุด (ไม่มี n-1 อยู่ใน set)
        if (!set.Contains(n - 1))
        {
            int current = n;
            int length = 1;

            while (set.Contains(current + 1))
            {
                current++;
                length++;
            }

            if (length > longest)
                longest = length;
        }
    }

    return longest;
}

        #endregion
    }
}
