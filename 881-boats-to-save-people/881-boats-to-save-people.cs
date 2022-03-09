public class Solution {
    public int NumRescueBoats(int[] people, int limit) {
        //3,3,4,5
        Array.Sort(people);
        int l = 0, r = people.Length-1;
        
        int total = 0;
        while(l<=r){
            if(people[l]+people[r] > limit){
                total++;
                r--;
            }
            else{
                total++;
                l++;
                r--;
            }
        }
        
        return total;
    }
}