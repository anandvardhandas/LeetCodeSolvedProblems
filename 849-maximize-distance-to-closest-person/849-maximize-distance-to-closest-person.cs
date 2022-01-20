class Solution {
    public int maxDistToClosest(int[] seats) {
        int max = 0;
        int leftPos = -1, rightPos = -1, currMax = 0;
        
        for(int i = 0; i < seats.length; i++){
            if(seats[i] == 1){
                leftPos = -1;
                rightPos = -1;
            }
            else{
                if(leftPos == -1){
                    leftPos = i;
                    rightPos = i;
                }
                else{
                    rightPos = i;
                }
                
                currMax = rightPos-leftPos+1;
                //updating max based on condition
                if(leftPos == 0 || rightPos == seats.length-1){
                    if(currMax > max)
                        max = currMax;
                }
                else{
                    int mid = leftPos + (rightPos-leftPos)/2;
                    if(mid-leftPos+1 > max)
                        max = mid-leftPos+1;
                }
            }
        }
        
       return max;
    }
}