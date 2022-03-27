public class Solution {
    public int[] KWeakestRows(int[][] mat, int k) {
        int m = mat.Length, n = mat[0].Length;
        int[] solds = new int[m];
        
        for(int i = 0; i < m; i++){
            int total = 0;
            for(int j = 0; j < n; j++){
                if(mat[i][j] == 1)
                    total++;
            }
            
            solds[i] = total;
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