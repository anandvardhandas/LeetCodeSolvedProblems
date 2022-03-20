public class Solution {
    public IList<string> FullJustify(string[] words, int maxWidth) {
        List<string> result = new List<string>();
        int len = words.Length;
        int i = 0;
        while(i < len){
            int j = i+1;
            int wordcount = words[i].Length;
            int spacecount = 0;
            
            while(j < len && wordcount + spacecount + words[j].Length + 1 <= maxWidth){
                wordcount += words[j].Length;
                spacecount++;
                j++;
            }
            
            int spaceleft = maxWidth-wordcount;
            
            int atleast = spacecount == 0 ? 0 : spaceleft/spacecount;
            int extra = spacecount == 0 ? 0 : spaceleft % spacecount;
            
            //for last line
            if(j == len){
                atleast = 1;
                extra = 0;
            }
            
            StringBuilder sb = new StringBuilder();
            
            for(int k = i; k < j; k++){
                sb.Append(words[k]);
                if(k == j-1)
                    break;
                
                for(int e = 0; e < atleast; e++){
                    sb.Append(" ");
                    if(extra > 0){
                        sb.Append(" ");
                        extra--;
                    }
                }
            }
            
            while(sb.Length < maxWidth){
                sb.Append(" ");
            }
            
            result.Add(sb.ToString());
            
            i = j;
            
        }
        
        
        return result;
    }
}