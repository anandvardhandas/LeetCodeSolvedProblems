public class Solution {
    public int MinimumDeviation(int[] nums) {
        int len = nums.Length;
        PriorityQueue<int, int> pq = new PriorityQueue<int, int>(len, new MaxHeapComparer());
        
        int min = int.MaxValue;
        for(int i = 0; i < len; i++){
            int num = nums[i];
            if(num%2 == 1){
                num = num * 2;
            }
            
            min = Math.Min(min, num);
            
            pq.Enqueue(num,num);
        }
        
        int diff = int.MaxValue;
        while(pq.Count > 0){
            int max = pq.Dequeue();
            diff = Math.Min(diff, Math.Abs(max-min));
            
            if(max % 2 == 1){
                break;
            }
            else{
                
                max = max/2;
                min = Math.Min(min,max);
                pq.Enqueue(max,max);
            }
        }
        
        return diff;
    }
}

public class MaxHeapComparer : IComparer<int>
{
    public int Compare(int x, int y)
    {
        if (x < y)
            return 1;
        else if (x > y)
            return -1;
        else
            return 0;
    }
}