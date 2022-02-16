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
        ListNode curr = dummy;
        dummy.next = head;
        
        
        while(curr.next != null && curr.next.next != null){
            ListNode first = curr.next;
            ListNode second = curr.next.next;
            
            first.next = second.next;
            
            curr.next = second;
            curr.next.next = first;
            
            curr = curr.next.next;
            
        }
        
        return dummy.next;
    }
}