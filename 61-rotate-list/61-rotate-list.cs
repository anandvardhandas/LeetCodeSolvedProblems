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
    public ListNode RotateRight(ListNode head, int k) {
        if(head == null || head.next == null)
            return head;
            
        int len = 0;
        
        ListNode curr = head;
        while(curr != null){
            curr = curr.next;
            len++;
        }
        
        k = k % len;
        
        if(k == 0)
            return head;
        
        ListNode fast = head;
        int count = 0;
        while(count < k){
            fast = fast.next;
            count++;
        }
        
        ListNode slow = head;
        
        while(fast.next != null){
            slow = slow.next;
            fast = fast.next;
        }
        
        ListNode result = slow.next;
        slow.next = null;
        
        fast.next = head;
        return result;
    }
}