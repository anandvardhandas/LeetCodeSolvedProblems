public class SparseVector {
    //using list to store non zero index and their values for both the arrays
    List<int[]> map = new List<int[]>();
    public SparseVector(int[] nums) {
        for(int i = 0; i < nums.Length; i++){
            if(nums[i] != 0){
                map.Add(new int[] { i,nums[i] });
            }
        }
    }
    
    // Return the dotProduct of two sparse vectors
    public int DotProduct(SparseVector vec) {
        int result = 0;
        int i = 0, j = 0;
        while(i < this.map.Count && j < vec.map.Count){
            if(this.map[i][0] == vec.map[j][0]){
                result += this.map[i][1] * vec.map[j][1];
                i++;
                j++;
            }
            else if(this.map[i][0] > vec.map[j][0]){
                j++;
            }
            else if(this.map[i][0] < vec.map[j][0]){
                i++;
            }
        }
        
        return result;
    }
}

// Your SparseVector object will be instantiated and called as such:
// SparseVector v1 = new SparseVector(nums1);
// SparseVector v2 = new SparseVector(nums2);
// int ans = v1.DotProduct(v2);