public class Solution {
    public int KthFactor(int n, int k) {
        int sqrt = (int)Math.Sqrt(n);
        
        PriorityQueue<int,int> pq = new PriorityQueue<int,int>(k+1, Comparer<int>.Create((x,y) => {
            return y.CompareTo(x);
        }));
        
        int count = 0;
        for(int i = 1; i <= sqrt; i++){
            if(n%i == 0){
                count += 1;
                pq.Enqueue(i,i);
                if(pq.Count > k){
                    pq.Dequeue();
                }
                
                if(i != n/i){
                    count++;
                    pq.Enqueue(n/i,n/i);
                    if(pq.Count > k){
                        pq.Dequeue();
                    }
                }
            }
        }
        
        if(count < k)
            return -1;
        
        return pq.Dequeue();
    }
}