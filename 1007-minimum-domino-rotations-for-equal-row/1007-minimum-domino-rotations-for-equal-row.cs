public class Solution {
    public int MinDominoRotations(int[] tops, int[] bottoms) {
        int[] map = new int[7];
        
        foreach(int item in tops){
            map[item]++;
        }
        
        foreach(int item in bottoms){
            map[item]++;
        }
        
        foreach(var item in map){
            //Console.WriteLine(item);
        }
        
        int max = 0;
        int maxnum = -1;
        for(int i = 0; i < map.Length; i++){
            //Console.WriteLine(map[i]);
            if(map[i] > max){
                max = map[i];
                maxnum = i;
            }
        }
        //Console.WriteLine(maxnum);
        int topscount = 0;
        for(int i = 0; i < tops.Length; i++){
            if(tops[i] == maxnum)
                topscount++;
        }
        
        int botscount = 0;
        for(int i = 0; i < bottoms.Length; i++){
            if(bottoms[i] == maxnum)
                botscount++;
        }
        
        for(int i = 0; i < tops.Length; i++){
            if(tops[i] != maxnum && bottoms[i] != maxnum)
                return -1;
        }
        
        int greater = Math.Max(topscount,botscount);
        return tops.Length-greater;
    }
}