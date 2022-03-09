public class Solution {
    public int FindLeastNumOfUniqueInts(int[] arr, int k) {
        Dictionary<int,int> map = new Dictionary<int,int>();
        foreach(int item in arr){
            if(!map.ContainsKey(item)){
                map.Add(item,1);
            }
            else{
                map[item]++;
            }
        }
        
        if(k == 0)
            return map.Count;
        
        PriorityQueue<int,int> pq = new PriorityQueue<int,int>(k, Comparer<int>.Create((x,y) => y.CompareTo(x)));
        
        foreach(var item in map){
            if(pq.Count < k){
                pq.Enqueue(item.Key, item.Value);
            }
            else{
                if(item.Value < map[pq.Peek()]){
                    pq.Dequeue();
                    pq.Enqueue(item.Key, item.Value);
                }
            }
        }
        
        List<int> removed = new List<int>();
        while(pq.Count > 0){
            removed.Add(pq.Dequeue());
        }
        
        removed.Reverse();
        
        foreach(int item in removed){
            int freq = map[item];
            if(k >= freq){
                map.Remove(item);
                k = k - freq;
            }
            else
                break;
        }
        
        return map.Count;
    }
}