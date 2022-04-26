public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        //1,2,2,3,3,4,5,5,6
        
        PriorityQueue<int,int> pq = new PriorityQueue<int,int>(k, Comparer<int>.Create((x,y) => x.CompareTo(y)));
        
        foreach(int num in nums){
            if(pq.Count < k){
                pq.Enqueue(num,num);
            }
            else{
                int peeked = pq.Peek();
                if(num > peeked){
                    pq.Dequeue();
                    pq.Enqueue(num,num);
                }
            }
        }
        
        return pq.Peek();
        
    }
}