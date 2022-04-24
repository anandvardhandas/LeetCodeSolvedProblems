public class Solution {
    public bool CanBeEqual(int[] target, int[] arr) {
        //[1,2,3,4]  [4,1,2,3  1,4,2,3  1,2,4,3  1,2,3,4]
        
        int[] map1 = new int[1001];
        int[] map2 = new int[1001];
        
        for(int i = 0; i < target.Length; i++){
            map1[target[i]]++;
            map2[arr[i]]++;
        }
        
        for(int i = 1; i <= 1000; i++){
            if(map1[i] != map2[i])
                return false;
        }
        
        return true;
    }
}