public class Solution {
    public int AddDigits(int num) {
        //Console.WriteLine(int.MaxValue);
        while(num > 9){
            int sum = 0;
            while(num > 0){
                sum = sum + (num%10);
                num /= 10;
            }
            
            num = sum;
        }
        
        return num;
    }
}