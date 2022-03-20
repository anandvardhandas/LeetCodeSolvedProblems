public class Solution {
    public long MaximumSubsequenceCount(string text, string pattern) {
        
        string input1 = pattern[0].ToString() + text;
        string input2 = pattern[1].ToString() + text;
        string input3 =  text + pattern[1].ToString();
        string input4 =  text + pattern[0].ToString();
        
        List<long> result = new List<long>();
        result.Add(Calc(input1, pattern));
        result.Add(Calc(input2, pattern));
        result.Add(Calc(input3, pattern));
        result.Add(Calc(input4, pattern));
        
        long[] resultArray = result.ToArray();
        Array.Sort(resultArray);
        return resultArray[resultArray.Length-1];
    }
    
    private long Calc(string text, string pattern){
        
        long count = 0;
        long total = 0;
        for(int i = text.Length-1; i >= 0; i--){
            if(text[i] == pattern[1]){
                count++;
            }
            else if(text[i] == pattern[0]){
                total += count;
            }
        }
        
        if(pattern[0] == pattern[1]){
            return ((count-1)*count)/2;
        }
        
        //Console.WriteLine($"{text} {pattern} {total}");
        return total;
    }
}