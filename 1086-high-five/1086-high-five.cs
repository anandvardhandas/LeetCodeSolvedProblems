public class Solution {
    public int[][] HighFive(int[][] items) {
        SortedDictionary<int,(int,PriorityQueue<int,int>)> map = new SortedDictionary<int,(int,PriorityQueue<int,int>)>();
        
        for(int i = 0; i < items.Length; i++){
            int key = items[i][0];
            if(!map.ContainsKey(key)){
                PriorityQueue<int,int> pq = new PriorityQueue<int,int>(5, Comparer<int>.Create((x,y) => x.CompareTo(y)));
                
                int val = items[i][1];
                pq.Enqueue(val,val);
                
                map.Add(items[i][0], (val,pq));
            }
            else{
                int sum = map[key].Item1;
                var pq = map[key].Item2;
                
                int val = items[i][1];
                
                if(pq.Count == 5){
                    if(val > pq.Peek()){
                        sum = sum - pq.Dequeue();
                        sum += val;
                        pq.Enqueue(val,val);
                        map[key] = (sum, pq);
                    }
                }
                else{
                    sum += val;
                    pq.Enqueue(val, val);
                    map[key] = (sum, pq);
                }
            }
        }
        
        int[][] result = new int[map.Count][];
        int index = 0;
        foreach(var item in map){
            result[index++] = new int[] { item.Key, item.Value.Item1/5 };
        }
        
        return result;
    }
}