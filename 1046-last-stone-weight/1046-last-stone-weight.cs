public class Solution {
    public int LastStoneWeight(int[] stones) {
        /*
             2,7,4,1,8,1
             1,1,2,4,7,8
             1,1,1,2,4
             1,1,1,2
             1,1,1
             1,1
             1
        
        */
        
        int len = stones.Length;
        PriorityQueue<int,int> pq = new PriorityQueue<int,int>(len, Comparer<int>.Create((x,y) => y.CompareTo(x)));
        for(int i = 0; i < len; i++){
            pq.Enqueue(stones[i], stones[i]);
        }
        
        while(pq.Count > 1){
            int stone1 = pq.Dequeue();
            int stone2 = pq.Dequeue();
            
            int diff = Math.Abs(stone1-stone2);
            if(diff > 0){
                pq.Enqueue(diff, diff);
            }
        }
        
        int result = 0;
        
        if(pq.Count > 0)
            result = pq.Dequeue();
        
        return result;
    }
}