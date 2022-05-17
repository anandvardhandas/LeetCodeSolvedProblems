public class Solution {
    public int PeakIndexInMountainArray(int[] arr) {
        int len = arr.Length;
        
        int i = 1;
        while(i < len-1 && arr[i] > arr[i-1]){
            i++;
        }
        
        int j = len-2;
        while(j > 0 && arr[j] > arr[j+1]){
            j--;
        }
        
        i--;
        j++;
        if(i == j){
            return i;
        }
        else{
            return -1;
        }
    }
}