public class Solution {
    public bool IsPowerOfFour(int n) {
        return Math.Log(n)/Math.Log(4) % 1 == 0;
    }
}