public class Solution {
    public int FindTheDistanceValue(int[] arr1, int[] arr2, int d) {
        //4,5,8  1,8,9,10
        int len1 = arr1.Length, len2 = arr2.Length;
        
        int count = 0;
        
        for(int i = 0; i < len1; i++){
            bool less = false;
            for(int j = 0; j < len2; j++){
                if(Math.Abs(arr1[i]-arr2[j]) <= d){
                    less = true;
                    break;
                }
            }
            
            if(!less){
                count++;
            }
        }
        
        return count;
    }
}