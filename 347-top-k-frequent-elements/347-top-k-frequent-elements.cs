public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        int len = nums.Length;
        Dictionary<int,int> map = new Dictionary<int,int>();
        for(int i = 0; i < len; i++){
            if(map.ContainsKey(nums[i]))
                map[nums[i]]++;
            else
                map.Add(nums[i],1);
        }
        
        PriorityQueue<int,int> pq = new PriorityQueue<int,int>(k);
        foreach(var item in map){
            if(pq.Count < k){
                pq.Enqueue(item.Key, item.Value);
            }
            else{
                if(map[pq.Peek()] < item.Value){
                    pq.Dequeue();
                    pq.Enqueue(item.Key, item.Value);
                }
            }
        }
        
        List<int> result = new List<int>();
        while(pq.Count > 0){
            result.Add(pq.Dequeue());
        }
        
        return result.ToArray();
    }
}