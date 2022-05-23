public class Solution {
    public bool CheckIfExist(int[] arr) {
        HashSet<int> map = new HashSet<int>();
        int len = arr.Length;
        for(int i = 0; i < len; i++){
            if(map.Contains(2 * arr[i]) || (arr[i]%2 == 0 && map.Contains(arr[i]/2))){
                return true;
            }
            else{
                map.Add(arr[i]);
            }
        }
        
        return false;
    }
}