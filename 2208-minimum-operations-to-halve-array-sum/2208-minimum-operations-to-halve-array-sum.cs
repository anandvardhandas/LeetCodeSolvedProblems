public class Solution {
    public int HalveArray(int[] nums) {
        PriorityQueue<double,double> pq = new PriorityQueue<double,double>(Comparer<double>.Create((x,y) => y.CompareTo(x)));
        double sum = 0;
        for(int i = 0; i < nums.Length; i++){
            pq.Enqueue(nums[i],nums[i]);
            sum += nums[i];
        }
        
        double initialsum = sum;
        int operations = 0;
        while(sum > (initialsum/2)){
            double pop = pq.Dequeue();
            sum -= pop;
            pop = pop/2;
            sum += pop;
            pq.Enqueue(pop,pop);
            operations++;
        }
        
        return operations;
    }
}