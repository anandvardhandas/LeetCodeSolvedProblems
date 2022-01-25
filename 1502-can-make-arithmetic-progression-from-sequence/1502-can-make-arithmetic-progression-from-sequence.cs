public class Solution {
    public bool CanMakeArithmeticProgression(int[] arr) {
        // Airthmetic Progression: a, a+d, a+2d, a+3d, .... a+(n-1)d
        // min = a, max = a+(n-1)d, hence d = (max-min)/(n-1)
        int len = arr.Length;
        int max = int.MinValue, min = int.MaxValue;
        Dictionary<int,int> map = new Dictionary<int,int>();
        for(int i = 0; i < len; i++){
            max = Math.Max(max, arr[i]);
            min = Math.Min(min, arr[i]);
            if(!map.ContainsKey(arr[i]))
                map.Add(arr[i],arr[i]);
        }
        
        int d = (max-min)/(len-1);
        int start = min;
        for(int i = 0; i < len; i++){
            if(!map.ContainsKey(start))
                return false;
            
            start += d;
        }
        
        return true;
    }
}