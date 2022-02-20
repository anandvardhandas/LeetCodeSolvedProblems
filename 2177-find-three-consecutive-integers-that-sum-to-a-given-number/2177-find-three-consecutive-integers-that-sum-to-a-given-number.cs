public class Solution {
    public long[] SumOfThree(long num) {
        if(num % 3 != 0){
            return new long[0];
        }
        else{
            long n = num/3;
            return new long[] { n-1, n, n+1 };
        }
    }
}
