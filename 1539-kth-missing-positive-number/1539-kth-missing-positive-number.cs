public class Solution {
    public int FindKthPositive(int[] arr, int k) {
        int count = 1, numth = 0;
        
        int i = 0;
        while(k > 0){
            if(i < arr.Length && count == arr[i]){
                count++;
                i++;
            }
            else{
                count++;
                k--;
            }
        }
        
        return count-1;
    }
}