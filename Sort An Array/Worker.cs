using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_An_Array
{
    class Worker
    {
        public Worker()
        {
            Work();
        }

        public void Work()
        {
            var numbers = SortArray(new int[] { 1, 5, 7, 4 });
            foreach (var number in numbers)
            {
                Console.Write($"{number}, ");
            }
        }

        public int[] SortArray(int[] nums)
        {
            int[] temp = new int[nums.Length];
            MergeSort(nums, 0, nums.Length - 1);
            return nums;
        }

        public void MergeSort(int[] nums, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;
                MergeSort(nums, left, mid);
                MergeSort(nums, mid + 1, right);
                Merge(nums, left, mid, right);
            }
        }

        public void Merge(int[] nums, int left, int mid, int right)
        {
            int i = left;
            int j = mid + 1;

            int k = 0;
            int[] temp = new int[nums.Length];

            while (i <= mid && j <= right)
            {
                if (nums[i] <= nums[j])
                {
                    temp[k++] = nums[i++];
                }
                else
                    temp[k++] = nums[j++];
            }

            while (i <= mid) temp[k++] = nums[i++];
            while (j <= right) temp[k++] = nums[j++];

            for (int m = left; m <= right; m++)
            {
                nums[m] = temp[m - left];
            }
        }
    }
}
