public class Solution {
    public int MaximumUnits(int[][] boxTypes, int truckSize) {
        Array.Sort(boxTypes, (x,y) => y[1].CompareTo(x[1]));
        
        int totalunits = 0;
        
        for(int i = 0; i < boxTypes.Length; i++){
            int boxes = boxTypes[i][0];
            if(truckSize >= boxes){
                totalunits += boxTypes[i][1]*boxes;
                truckSize -= boxes;
            }
            else{
                totalunits += boxTypes[i][1]*truckSize;
                break;
            }
        }
        
        return totalunits;
    }
}