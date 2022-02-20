public class Solution {
    public IList<long> MaximumEvenSplit(long finalSum) {
        long currsum = finalSum;
        IList<long> result = new List<long>();
        
        if(finalSum % 2 == 1)
            return result;
        
        long num = 2;
        while(currsum - num >= 0){
            result.Add(num);
            currsum -= num;
            num += 2;
        }
        
        if(currsum == 0)
            return result;
        
        long lastval = result[result.Count-1];
        result.RemoveAt(result.Count-1);
        currsum += lastval;
        result.Add(currsum);
        return result;
    }
}