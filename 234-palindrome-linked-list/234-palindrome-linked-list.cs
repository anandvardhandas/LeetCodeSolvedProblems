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
    public bool IsPalindrome(ListNode head) {
        
        ListNode slow = head;
        ListNode fast = head;
        
        while(fast != null && fast.next != null){
            slow = slow.next;
            fast = fast.next.next;
        }
        
        ListNode end = Reverse(slow);
        ListNode start = head;
        
        while(start != null && end != null && start != end){
            if(start.val == end.val){
                start = start.next;
                end = end.next;
            }
            else{
                return false;
            }
        }
        
        return true;
    }
    
    private ListNode Reverse(ListNode head){
        ListNode curr = head;
        ListNode prev = null;
        
        while(curr != null){
            ListNode temp = curr.next;
            
            curr.next = prev;
            
            prev = curr;
            curr = temp;
        }
        
        return prev;
    }
}