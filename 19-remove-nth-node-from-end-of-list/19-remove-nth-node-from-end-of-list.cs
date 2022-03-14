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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        
        ListNode fast = head;
        
        while(n > 0){
            fast = fast.next;
            n--;
        }
        
        ListNode slow = head;
        while(fast != null && fast.next != null){
            slow = slow.next;
            fast = fast.next;
        }
        
        if(fast == null)
            return head.next;
        
        slow.next = slow.next?.next;
        
        return head;
    }
}