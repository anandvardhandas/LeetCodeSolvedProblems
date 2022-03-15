public class Solution {
    public int ShortestDistance(string[] wordsDict, string word1, string word2) {
        int len = wordsDict.Length;
        int i1 = -1, i2 = -1;
        int mindist = int.MaxValue;
        for(int i = 0; i < len; i++){
            if(wordsDict[i] == word1){
                i1 = i;
            }
            else if(wordsDict[i] == word2){
                i2 = i;
            }
            
            if(i1 != -1 && i2 != -1){
                mindist = Math.Min(mindist, Math.Abs(i1-i2));
                if(mindist == 1)
                    return 1;
            }
        }
            
        return mindist;
    }
}