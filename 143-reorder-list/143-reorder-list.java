/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode() {}
 *     ListNode(int val) { this.val = val; }
 *     ListNode(int val, ListNode next) { this.val = val; this.next = next; }
 * }
 */
class Solution {
    public void reorderList(ListNode head) {
      if(head == null || head.next == null || head.next.next == null)
          return;
        
        ListNode slow = head;
        ListNode fast = head.next;
        //finding the middle element
        while(fast != null && fast.next != null){
            slow = slow.next;
            fast = fast.next.next;
        }
        
        //reversing the next half
        ListNode head2 = Reverse(slow.next);
        
        //breaking the chain
        slow.next = null;
        
        //Merging the two heads head and head2
        Merge(head, head2);
    }
    
    private ListNode Reverse(ListNode head){
        ListNode prev = null;
        while(head != null){
            ListNode temp = head.next;
            head.next = prev;
            prev = head;
            head = temp;
        }
        
        return prev;
    }
    
    private void Merge(ListNode h1, ListNode h2){
        while(h1 != null){
            ListNode next = h1.next;
            h1.next = h2;
            h1 = h2;
            h2 = next;
        }
    }
}