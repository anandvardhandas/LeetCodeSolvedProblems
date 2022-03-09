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
    public ListNode DeleteDuplicates(ListNode head) {
        if(head == null || head.next == null)
            return head;
        
        ListNode dummy = new ListNode(0);
        ListNode prev = dummy;
        ListNode curr = head;
        prev.next = curr;
        
        while(curr != null && curr.next != null){
            if(curr.val != curr.next.val){
                prev = curr;
                curr = curr.next;
            }
            else{
                while(curr.next != null && curr.val == curr.next.val){
                    curr = curr.next;
                }
                
                prev.next = curr.next;
                curr = curr.next;
            }
        }
        
        return dummy.next;
    }
}