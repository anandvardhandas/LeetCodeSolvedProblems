public class Solution {
    public int[] KWeakestRows(int[][] mat, int k) {
        int m = mat.Length, n = mat[0].Length;
        int[] solds = new int[m];
        
        for(int i = 0; i < m; i++){
            int low = 0, hi = n-1;
            while(low < hi){
                int mid = low + (hi-low)/2;
                if(mat[i][mid] == 1)
                    low = mid+1;
                else{
                    hi = mid;
                }
            }
            
            if(mat[i][low] == 1)
                low++;
            solds[i] = low;
        }
        
        
        PriorityQueue<int,int> pq = new PriorityQueue<int,int>(k, Comparer<int>.Create((x,y) => {
            if(solds[x] == solds[y])
                return y.CompareTo(x);
            
            return solds[y].CompareTo(solds[x]);
        }));
        
        for(int i = 0; i < m; i++){
            if(pq.Count < k)
                pq.Enqueue(i,i);
            else{
                if(solds[i] < solds[pq.Peek()]){
                    pq.Dequeue();
                    pq.Enqueue(i,i);
                }
            }
        }
        
        List<int> result = new List<int>();
        while(pq.Count > 0){
            result.Add(pq.Dequeue());
        }
        
       int[] res = result.ToArray();
        Array.Reverse(res);
        return res;
    }
}