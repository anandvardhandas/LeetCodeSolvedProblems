public class Solution {
    public IList<string> FizzBuzz(int n) {
        string[] result = new string[n];
        for(int i = 0; i < n; i++){
            int num = i+1;
            if(num % 3 == 0 && num % 5 == 0){
                result[i] = "FizzBuzz";
            }
            else if(num % 3 == 0){
                result[i] = "Fizz";
            }
            else if(num % 5 == 0){
                result[i] = "Buzz";
            }
            else{
                result[i] = num.ToString();
            }
        }
        
        return result.ToList();
    }
}