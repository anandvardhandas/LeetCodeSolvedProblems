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
    public ListNode SortList(ListNode head) {
        //doing merge sort
        /*
        merge sort algorithm 
        
        find the mid
        left = sort(start);
        right = sort(mid);
        merge(left, right)
        
        */
        
        //base condition
        if(head == null || head.next == null)
            return head;
        
        //cutting the list into two halves
        ListNode prev = null;
        ListNode slow = head;
        ListNode fast = head;
        while(fast != null && fast.next != null){
            prev = slow;
            slow = slow.next;
            fast = fast.next.next;
        }
        
        prev.next = null; // making sure that cut happens
        
        ListNode left = SortList(head);
        ListNode right = SortList(slow);
        ListNode merged = Merge(left,right);
        return merged;
    }
    
    private ListNode Merge(ListNode l1, ListNode l2){
        ListNode dummy = new ListNode(0);
        ListNode curr = dummy;
        
        while(l1 != null && l2 != null){
            if(l1.val < l2.val){
                curr.next = l1;
                l1 = l1.next;
            }
            else{
                curr.next = l2;
                l2 = l2.next;
            }
            
            curr = curr.next;
        }
        
        if(l1 != null){
            curr.next = l1;
        }
        else if(l2 != null){
            curr.next = l2;
        }
        
        
        return dummy.next;
    }
}