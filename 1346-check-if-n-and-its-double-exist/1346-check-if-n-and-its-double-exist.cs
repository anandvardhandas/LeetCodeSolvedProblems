public class Solution {
    public bool CheckIfExist(int[] arr) {
        Dictionary<int,int> map = new Dictionary<int,int>();
        int len = arr.Length;
        for(int i = 0; i < len; i++){
            if(!map.ContainsKey(arr[i]))
                map.Add(arr[i],i);
        }
        
        for(int i = 0; i < len; i++){
            if(map.ContainsKey(2 * arr[i]) && i != map[2*arr[i]]){
                //Console.WriteLine(i);
                return true;
            }
        }
        
        return false;
    }
}