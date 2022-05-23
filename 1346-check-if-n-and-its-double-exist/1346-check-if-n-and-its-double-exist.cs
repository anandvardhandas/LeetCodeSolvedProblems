public class Solution {
    public bool CheckIfExist(int[] arr) {
        Array.Sort(arr);
        int len = arr.Length;
        int i = 0;
        while(i < len && arr[i] < 0){
            i++;
        }
        
        //search forward
        int j = i;
        if(i < len && arr[i] == 0){
            j = i+1;
        }
        
        while(j < len){
            bool found = BinarySearch(arr, j, len-1, 2 * arr[j]);
            if(found)
                return true;
            
            j++;
        }
        
        //search backward
        
        j = i-1;
        while(j >= 0){
            bool found = BinarySearch(arr, 0, j, 2 * arr[j]);
            if(found)
                return true;
            
            j--;
        }
        
        return false;
    }
    
    private bool BinarySearch(int[] arr, int low, int hi, int target){
        while(low <= hi){
            int mid = low + (hi-low)/2;
            if(arr[mid] == target){
                return true;
            }
            else if(arr[mid] < target){
                low = mid+1;
            }
            else{
                hi = mid-1;
            }
        }
        
        return false;
    }
}