public class Solution {
    public double MyPow(double x, int n) {
        long N = n;
        if(x == 0)
            return 0;
        
        if(n == 0)
            return 1.0;
        
        if(N<0){
            x=1/x;
            N=-N;
        }
        double result = Helper(x,N);
        
        return result;
    }
    
    private double Helper(double x, long n){
        if(x == 0)
            return 0;
        
        if(n == 0)
            return 1;
        
        double result = Helper(x,n/2);
        
        if(n%2==1){
            return x * result * result;
        }
        
        return result * result;
    }
}