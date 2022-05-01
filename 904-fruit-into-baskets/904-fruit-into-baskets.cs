public class Solution {
    public int TotalFruit(int[] fruits) {
        Dictionary<int,int> map = new Dictionary<int,int>();
        int max = 0;
        int k = 2;
        int len = fruits.Length;
        int low = 0, hi = 0;
        while(hi < len){
            if(!map.ContainsKey(fruits[hi])){
                k--;
                map.Add(fruits[hi], 1);
            }
            else{
                map[fruits[hi]]++;
            }
            
            while(k < 0){
                map[fruits[low]]--;
                if(map[fruits[low]] == 0){
                    k++;
                    
                    map.Remove(fruits[low]);
                }
                
                low++;
            }
            
            max = Math.Max(max, hi-low+1);
            hi++;
        }
        
        return max;
    }
}