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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        
        l1 = Reverse(l1);
        l2 = Reverse(l2);
        
        ListNode dummy = new ListNode();
        
        ListNode curr = dummy;
        
        int carry = 0;
        while(l1 != null || l2 != null){
            int sum = carry;
            if(l1 != null){
                sum += l1.val;
                l1 = l1.next;
            }
            
            if(l2 != null){
                sum += l2.val;
                l2 = l2.next;
            }
            
            carry = sum/10;
            sum = sum%10;
            
            curr.next = new ListNode(sum);
            curr = curr.next;
        }
        
        if(carry > 0){
            curr.next = new ListNode(carry);
            curr = curr.next;
        }
        
        ListNode result = Reverse(dummy.next);
        return result;
    }
    
    private ListNode Reverse(ListNode head){
        
        ListNode prev = null;
        ListNode curr = head;
        
        while(curr != null){
            ListNode temp = curr.next;
            
            curr.next = prev;
            prev = curr;
            
            curr = temp;
        }
        
        return prev;
    }
}