public class Solution {
    public int[] FindPermutation(string s) {
        int[] result = new int[s.Length+1];
        
        int index = 0;
        int num = 0;
        int dcount = 0;
        for(int i = 0; i < s.Length; i++){
            if(s[i] == 'D'){
                dcount++;
            }
            else{
                if(dcount > 0){
                    num = num + dcount + 1;
                    int temp = num;
                    result[index++] = temp;
                    temp--;
                    while(dcount > 0){
                        result[index++] = temp;
                        temp--;
                        dcount--;
                    }
                }
                else{
                    num++;
                    result[index++] = num;
                }
            }
        }
        
        if(dcount > 0){
             num = num + dcount + 1;
            result[index++] = num;
            num--;
             while(dcount > 0){
                result[index++] = num;
                 num--;
                 dcount--;
            }
        }
        else{
            num++;
            result[index] = num;
        }
        
        
       
        return result;
    }
}