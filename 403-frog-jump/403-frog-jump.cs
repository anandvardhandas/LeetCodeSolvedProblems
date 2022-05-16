public class Solution {
    public bool CanCross(int[] stones) {
        int len = stones.Length;
        
        Dictionary<int,HashSet<int>> map = new Dictionary<int,HashSet<int>>();
        for(int i = 0; i < len; i++){
            map.Add(stones[i], new HashSet<int>());
        }
        
        map[stones[0]].Add(1);
        
        for(int i = 0; i < len; i++){
            HashSet<int> jumps = map[stones[i]];
            foreach(int jump in jumps){
                if(map.ContainsKey(stones[i]+jump)){
                    if(stones[i]+jump == stones[len-1]){
                        return true;
                    }
                    
                    map[stones[i]+jump].Add(jump);
                    
                    if(jump-1 > 0)
                        map[stones[i]+jump].Add(jump-1);
                    
                    map[stones[i]+jump].Add(jump+1);
                }
            }
        }
        
        return false;
    }
    
    
}