public class Solution {
    public IList<int> SequentialDigits(int low, int high) {
        IList<int> result = new List<int>();
        
        string num = "1";
        string prev = num;
        int index = 2;
        int times = 8;
        string addNum = "1";
        while(times > 0){
            num = prev + index.ToString();
            prev = num;
            int count = 0;
            addNum += "1";
            while(count < times){
                if(int.Parse(num) > high)
                    return result;
                if(int.Parse(num) >= low)
                    result.Add(int.Parse(num));
                
                num = (int.Parse(num) + int.Parse(addNum)).ToString();
                count++;
            }
            
            times--;
            index++;
        }
        
        return result;
    }
}