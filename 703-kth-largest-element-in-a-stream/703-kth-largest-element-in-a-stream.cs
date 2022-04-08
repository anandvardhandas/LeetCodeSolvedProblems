public class KthLargest {

    PriorityQueue<int,int> pq;
    private int size;
    public KthLargest(int k, int[] nums) {
        size = k;
        pq = new PriorityQueue<int,int>(k, Comparer<int>.Create((x,y) => x.CompareTo(y)));
        int len = nums.Length;
        for(int i = 0; i < len; i++){
            if(pq.Count < k){
                pq.Enqueue(nums[i], nums[i]);
            }
            else{
                int topnum = pq.Peek();
                if(nums[i] > topnum){
                    pq.Dequeue();
                    pq.Enqueue(nums[i],nums[i]);
                }
            }
        }
        
        
    }
    
    public int Add(int val) {
        if(pq.Count < size){
            pq.Enqueue(val,val);
        }
        else{
            int topnum = pq.Peek();
            if(val > topnum){
                pq.Dequeue();
                pq.Enqueue(val,val);
            }
        }
        
        return pq.Peek();
    }
}

/**
 * Your KthLargest object will be instantiated and called as such:
 * KthLargest obj = new KthLargest(k, nums);
 * int param_1 = obj.Add(val);
 */