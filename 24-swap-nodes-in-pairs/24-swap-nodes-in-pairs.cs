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
    public ListNode SwapPairs(ListNode head) {
        if(head == null || head.next == null)
            return head;
        
        ListNode dummy = new ListNode(0);
        dummy.next = head;
        
        ListNode prev = dummy;
        ListNode curr = head;
        
        while(curr != null && curr.next != null){
            ListNode first = curr;
            ListNode second = curr.next;
            
            first.next = second.next;
            second.next = first;
            prev.next = second;
            
            prev = first;
            curr = first.next;
        }
        
        return dummy.next;
    }
}