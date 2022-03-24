public class Solution {
    public int NumRescueBoats(int[] people, int limit) {
        Array.Sort(people);
        int len = people.Length;
        int boats = 0;
        int l = 0, r = len-1;
        
        while(l <= r){
            if(people[l]+people[r] <= limit){
                l++;
                r--;
            }
            else{
                r--;
            }
            
            boats++;
        }
        
        return boats;
    }
}