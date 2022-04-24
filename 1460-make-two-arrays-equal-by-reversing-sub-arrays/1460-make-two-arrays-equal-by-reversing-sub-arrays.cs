public class Solution {
    public bool CanBeEqual(int[] target, int[] arr) {
        //[1,2,3,4]  [4,1,2,3  1,4,2,3  1,2,4,3  1,2,3,4]
        
        Array.Sort(target);
        Array.Sort(arr);
        int i = 0;
        while(i < target.Length){
            if(target[i] != arr[i])
                return false;
            
            i++;
        }
        
        return true;
    }
}