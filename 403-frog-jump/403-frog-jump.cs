public class Solution {
    public bool CanCross(int[] stones) {
        int len = stones.Length;
        
        if(stones[1] != 1)
            return false;
        
        if(len == 2 && stones[1] == 1){
            return true;
        }
        
        Dictionary<string,bool> dp = new Dictionary<string,bool>();
        return Helper(stones, 1, 1, dp);
    }
    
    private bool Helper(int[] stones, int index, int k, Dictionary<string,bool> dp){
        if(index == stones.Length-1){
            return true;
        }
        
        bool res = false;
        int nextPos = -1;
        
        string key = $"{index}.{k}";
        if(dp.ContainsKey(key)){
            return dp[key];
        }
        
        // k jump
        nextPos = FindNextPos(stones, index+1, stones.Length-1, stones[index]+k);
        if(nextPos != -1){
            res = Helper(stones, nextPos, k, dp);
            if(res){
                return true;
            }
        }
        
        //k-1 jump
        nextPos = FindNextPos(stones, index+1, stones.Length-1, stones[index]+k-1);
        if(nextPos != -1){
            res = Helper(stones, nextPos, k-1, dp);
            if(res){
                return true;
            }
        }
        
        //k+1 jump
        nextPos = FindNextPos(stones, index+1, stones.Length-1, stones[index]+k+1);
        if(nextPos != -1){
            res = Helper(stones, nextPos, k+1, dp);
            if(res){
                return true;
            }
        }
        
        dp.Add(key,false);
        return false;
    }
    
    private int FindNextPos(int[] stones, int low, int hi, int pos){
        while(low <= hi){
            int mid = low + (hi-low)/2;
            if(stones[mid] == pos){
                return mid;
            }
            else if(stones[mid] > pos){
                hi = mid-1;
            }
            else{
                low = mid+1;
            }
        }
        
        return -1;
    }
}