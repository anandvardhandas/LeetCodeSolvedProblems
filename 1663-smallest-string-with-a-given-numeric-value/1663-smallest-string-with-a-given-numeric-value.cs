public class Solution {
    public string GetSmallestString(int n, int k) {
        char[] freqs = new char[n];
        for(int i = 0; i < freqs.Length; i++){
            freqs[i] = 'a';
        }
        
        k = k-n;// as each value of 'a' is 1, and 'a' was added in before
        
        int index = n-1;
        while(k > 0){
            if(freqs[index] < 'z'){
                freqs[index]++;
                k--;
            }
            else{
                index--;
            }
        }
        
        return new string(freqs);
    }
}