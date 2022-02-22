public class Solution {
    public string LargestNumber(int[] nums) {
        Array.Sort(nums, new MyComparer());
        
        if(nums[0] == 0)
            return "0";
        
        StringBuilder sb = new StringBuilder();
        foreach(int item in nums){
            sb.Append(item.ToString());
        }
        
        return sb.ToString();
    }
}

public class MyComparer : IComparer<int>{
    public int Compare(int x, int y) {
        string num1 = x.ToString();
        string num2 = y.ToString();
        
        long n1 = long.Parse(num1+num2);
        long n2 = long.Parse(num2+num1);
        
        if(num1 == num2)
            return 0;
        
        if(n1 > n2)
            return -1;
        else
            return 1;
    }
}