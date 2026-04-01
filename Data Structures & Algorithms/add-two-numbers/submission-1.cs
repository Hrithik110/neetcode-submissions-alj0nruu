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
        
        ListNode result = new ListNode(0, null);
        ListNode dummy = result;
        var curr1 = l1;
        var curr2 = l2; 

        int rem = 0;

        while(curr1 !=null && curr2!=null){
            int val1 = curr1.val;
            int val2 = curr2.val;

            int sum = val1 + val2 + rem;

            rem = sum/10;

            int val3 = sum%10;

            result.next = new ListNode(val3);

            result = result.next;
            curr1 = curr1.next;
            curr2 = curr2.next;
        }

        while(curr1 != null){
            int sum = curr1.val + rem;
            rem = sum/10;
            int v = sum%10;
            result.next = new ListNode(v);
            result = result.next;
            curr1 = curr1.next;
        }

        while(curr2 != null){
            int sum = curr2.val + rem;
            rem = sum/10;
            int v = sum%10;
            result.next = new ListNode(v);
            result = result.next;

            curr2 = curr2.next;
        }
        if(rem != 0){
            result.next = new ListNode(rem);
        }
        return dummy.next;
    }
}
