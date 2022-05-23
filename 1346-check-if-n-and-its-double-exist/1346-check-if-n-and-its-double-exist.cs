public class Solution {
    public bool CheckIfExist(int[] arr) {
        HashSet<double> map = new HashSet<double>();
        int len = arr.Length;
        for(int i = 0; i < len; i++){
            if(map.Contains((double)2 * arr[i]) || map.Contains((double)arr[i]/2)){
                return true;
            }
            else{
                map.Add((double)arr[i]);
            }
        }
        
        return false;
    }
}