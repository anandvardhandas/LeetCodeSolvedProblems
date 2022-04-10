public class Solution {
    public int CalPoints(string[] ops) {
        List<int> result = new List<int>();
        foreach(string str in ops){
            if(str == "C"){
                result.RemoveAt(result.Count-1);
            }
            else if(str == "D"){
                int num = result[result.Count-1];
                result.Add(num*2);
            }
            else if(str == "+"){
                int num = result[result.Count-1] + result[result.Count-2];
                result.Add(num);
            }
            else{
                result.Add(int.Parse(str));
            }
        }
        
        int total = 0;
        foreach(int number in result){
            total += number;
        }
        
        return total;
    }
}