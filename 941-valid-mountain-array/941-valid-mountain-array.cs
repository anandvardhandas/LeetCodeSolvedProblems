public class Solution {
    public bool ValidMountainArray(int[] arr) {
        if(arr.Length < 3)
            return false;
        
        int len = arr.Length;
        bool increase = false, decrease = false;
        for(int i = 0; i < len-1; i++){
            if(arr[i] == arr[i+1])
                return false;
            else if(arr[i] < arr[i+1]){
                if(decrease)
                    return false;
                
                increase = true;
            }
            else if(arr[i] > arr[i+1]){
                if(!increase)
                    return false;
                
                decrease = true;
            }
        }
        
        return increase && decrease;
    }
}