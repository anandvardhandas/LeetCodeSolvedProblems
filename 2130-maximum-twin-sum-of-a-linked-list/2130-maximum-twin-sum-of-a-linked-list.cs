/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public int PairSum(ListNode head) {
        //reach the half of the list
        ListNode slow = head, fast = head;
        while(fast != null && fast.next != null){
            slow = slow.next;
            fast = fast.next.next;
        }
        
        ListNode end = Reverse(slow);
        
        int max = 0;
        
        ListNode start = head;
        
        while(start != null && end != null){
            max = Math.Max(max, start.val+end.val);
            start = start.next;
            end = end.next;
        }
        
        return max;
    }
    
    private ListNode Reverse(ListNode root){
        if(root == null){
            return null;
        }
        
        ListNode prev = null;
        ListNode curr = root;
        
        while(curr != null){
            ListNode temp = curr.next;
            
            curr.next = prev;
            prev = curr;
            
            curr = temp;
        }
        
        
        return prev;
    }
}