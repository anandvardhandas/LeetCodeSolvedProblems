public class Solution {
    public int MinDominoRotations(int[] tops, int[] bottoms) {
        int[] map = new int[7];
        
        foreach(int item in tops){
            map[item]++;
        }
        
        foreach(int item in bottoms){
            map[item]++;
        }
        
        int max = 0;
        int maxnum = -1;
        for(int i = 0; i < map.Length; i++){
            if(map[i] > max){
                max = map[i];
                maxnum = i;
            }
        }
        
        int topscount = 0, botscount = 0;
        for(int i = 0; i < tops.Length; i++){
            if(tops[i] == maxnum)
                topscount++;
            if(bottoms[i] == maxnum)
                botscount++;
            
            if(tops[i] != maxnum && bottoms[i] != maxnum)
                return -1;
        }
        
        return Math.Min(tops.Length-topscount,tops.Length-botscount);
    }
}