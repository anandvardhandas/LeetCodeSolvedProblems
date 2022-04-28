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
    public ListNode RemoveElements(ListNode head, int val) {
        if(head == null)
            return null;
        
        ListNode dummy = new ListNode(0);
        ListNode curr = dummy;
        
        while(head != null){
            while(head != null && head.val == val){
                head = head.next;
            }
            
            curr.next = head;
            if(head != null)
                head = head.next;
            curr = curr.next;
        }
        
        return dummy.next;
    }
}