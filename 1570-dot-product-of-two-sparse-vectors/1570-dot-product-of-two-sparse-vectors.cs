public class SparseVector {
    Dictionary<int,int> map = new Dictionary<int,int>();
    public int[] _nums;
    public SparseVector(int[] nums) {
        //Console.WriteLine(map.Count);
        for(int i = 0; i < nums.Length; i++){
            if(nums[i] != 0){
                map.Add(i,nums[i]);
            }
        }
    }
    
    // Return the dotProduct of two sparse vectors
    public int DotProduct(SparseVector vec) {
        int result = 0;
        foreach(var item in this.map){
            if(vec.map.ContainsKey(item.Key)){
                result += item.Value * vec.map[item.Key];
            }
        }
        
        return result;
    }
}

// Your SparseVector object will be instantiated and called as such:
// SparseVector v1 = new SparseVector(nums1);
// SparseVector v2 = new SparseVector(nums2);
// int ans = v1.DotProduct(v2);