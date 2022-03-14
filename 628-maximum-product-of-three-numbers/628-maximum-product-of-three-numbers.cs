public class Solution {
    public int MaximumProduct(int[] nums) {
        //finding top 3
        int[] nums2 = new int[] { nums[0], nums[1], nums[2] };
        Array.Sort(nums2);
        int max1 = nums2[2], max2 = nums2[1], max3 = nums2[0];
        int min1 = nums2[0], min2 = nums2[1];

        //finding overall max1,2,3
        for (int i = 3; i < nums.Length; i++)
        {
            if (nums[i] >= max1)
            {
                max3 = max2;
                max2 = max1;
                max1 = nums[i];
            }
            else if (nums[i] >= max2)
            {
                max3 = max2;
                max2 = nums[i];
            }
            else if (nums[i] >= max3)
            {
                max3 = nums[i];
            }

            if (nums[i] <= min1)
            {
                min2 = min1;
                min1 = nums[i];
            }
            else if (nums[i] <= min2)
            {
                min2 = nums[i];
            }
        }


        int maxProduct = Math.Max(max1 * max2 * max3, min1 * min2 * max1);
        return maxProduct;
    }
}