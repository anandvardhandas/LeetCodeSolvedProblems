public class Solution {
    public string ToGoatLatin(string sentence) {
        StringBuilder result = new StringBuilder();
        
        string[] words = sentence.Split(' ');
        int count = 1;
        foreach(string word in words){
            char c = word[0];
            string wordcopy = word;
            if(c == 'a' || c == 'i' || c == 'e' || c == 'o' || c == 'u'
               || c == 'A' || c == 'I' || c == 'E' || c == 'O' || c == 'U'){
                wordcopy = AppendA(wordcopy + "ma", count);
                result.Append(wordcopy);
                result.Append(" ");
            }
            else{
                wordcopy = wordcopy.Substring(1, wordcopy.Length-1);
                wordcopy = wordcopy+c.ToString()+"ma";
                wordcopy = AppendA(wordcopy, count);
                
                result.Append(wordcopy);
                result.Append(" ");
            }
            
            count++;
        }
        
        string res = result.ToString();
        
        return res.Substring(0, res.Length-1);
    }
    
    private string AppendA(string str, int times){
        StringBuilder sb = new StringBuilder();
        while(times > 0){
            sb.Append("a");
            times--;
        }
        
        return str+sb.ToString();
    }
}