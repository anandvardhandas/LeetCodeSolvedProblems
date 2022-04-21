public class NumArray {

    private int[] arr;
    private int[] seg;
    public NumArray(int[] nums) {
        arr = nums;
        seg = new int[4*nums.Length];
        BuildTree(0, 0, nums.Length-1);
    }
    
    public void Update(int index, int val) {
        arr[index] = val;
        UpdateTree(index, 0, 0, arr.Length-1);
    }
    
    public int SumRange(int left, int right) {
        return GetSum(0, 0, arr.Length-1, left, right);
    }
    
    private int GetSum(int index, int left, int right, int l, int r){
        //completely inside the search range, hence return the node
        if(left >= l && right <= r){
            return seg[index];
        }
        
        if(right < l || left > r)
            return 0;
        
        int mid = (left+right)/2;
        int lsum = GetSum(2*index+1, left, mid, l, r);
        int rsum = GetSum(2*index+2, mid+1, right, l, r);
        
        return lsum+rsum;
    }
    
    private void UpdateTree(int i, int index, int left, int right){
        if(left == right){
            seg[index] = arr[left];
            return;
        }
        
       int mid = (left+right)/2;
        if(i <= mid){
            UpdateTree(i, 2*index+1, left, mid);
        }
        else{
            UpdateTree(i, 2*index+2, mid+1, right);
        }
        
        seg[index] = seg[2*index+1] + seg[2*index+2];
    }
    
    private void BuildTree(int index, int left, int right){
        if(left == right){
            seg[index] = arr[left];
            return;
        }
        
        int mid = (left+right)/2;
        BuildTree(2*index+1, left, mid);
        BuildTree(2*index+2, mid+1, right);
        
        //assign the value coming from left and right positions
        seg[index] = seg[2*index+1] + seg[2*index+2];
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * obj.Update(index,val);
 * int param_2 = obj.SumRange(left,right);
 */