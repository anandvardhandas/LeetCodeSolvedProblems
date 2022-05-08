public class Solution {
    public int NumPairsDivisibleBy60(int[] time) {
        int len = time.Length;
        Dictionary<int,int> map = new Dictionary<int,int>();
        map.Add(60, 0);
        int total = 0;
        
        for(int i = 0; i < len; i++){
            int num = time[i]%60;
             
            int target = 60-num;
            
            if(target != 60){
                if(map.ContainsKey(target)){
                    total += map[target];
                }

                if(map.ContainsKey(num)){
                    map[num]++;
                }
                else{
                    map.Add(num,1);
                }
            }
            else{
                total += map[60];
                map[60]++;
            }
            
        }
        
        return total;
    }
}