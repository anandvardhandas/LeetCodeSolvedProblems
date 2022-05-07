public class Solution {
    public int NumPairsDivisibleBy60(int[] time) {
        Dictionary<int,int> map = new Dictionary<int,int>();
        map.Add(60,0);
        int total = 0;
        foreach(int t in time){
            int num = t%60;
            if(map.ContainsKey(60-num)){
                total += map[60-num];
            }
            
            if(num != 0){
                if(!map.ContainsKey(num)){
                    map.Add(num, 1);
                }
                else{
                    map[num]++;
                }
            }
            else{
                map[60]++;
            }
            
        }
        
        return total;
    }
}