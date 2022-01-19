public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        if(n == 0)
            return true;
        
        int len = flowerbed.Length;
        
        for(int i = 0; i < len; i++){
            //check left and right and center
            if(flowerbed[i] == 1 || (i > 0 && flowerbed[i-1] == 1) || (i < len-1 && flowerbed[i+1] == 1)){
                continue;
            }
            else{
                flowerbed[i] = 1;
                n--;
                if(n == 0)
                    return true;
            }
        }
        
        return n == 0;
    }
}