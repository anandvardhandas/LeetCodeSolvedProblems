public class Solution {
    public int[][] HighFive(int[][] items) {
        SortedDictionary<int,PriorityQueue<int,int>> map = new SortedDictionary<int,PriorityQueue<int,int>>();
        
        for(int i = 0; i < items.Length; i++){
            int key = items[i][0];
            if(!map.ContainsKey(key)){
                PriorityQueue<int,int> pq = new PriorityQueue<int,int>(Comparer<int>.Create((x,y) => x.CompareTo(y)));
                
                int val = items[i][1];
                pq.Enqueue(val,val);
                
                map.Add(items[i][0], pq);
            }
            else{
                var pq = map[key];
                int val = items[i][1];
                
                pq.Enqueue(val, val);
                if(pq.Count > 5){
                    pq.Dequeue();
                }
                
                map[key] = pq;
            }
        }
        
        int[][] result = new int[map.Count][];
        int index = 0;
        foreach(var item in map){
            int sum = 0;
            var pq = item.Value;
            while(pq.Count > 0){
                sum += pq.Dequeue();
            }
            
            result[index++] = new int[] { item.Key, sum/5 };
        }
        
        return result;
    }
}