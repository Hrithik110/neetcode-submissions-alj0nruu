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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode i = list1;

        ListNode j = list2;

        ListNode ans = new ListNode();
        ListNode curr = ans;
        while(i!=null && j!=null){
            int val1 = i.val;
            int val2 = j.val;

            if(val1<=val2){
                curr.next = i;
                curr = curr.next;
                i = i.next;
            }
            else{
                curr.next = j;
                curr = curr.next;
                j = j.next;
            }
        }

        while(i!=null){
            curr.next = i;
            curr = curr.next;
            i = i.next;
        }
         while(j!=null){
            curr.next = j;
            curr = curr.next;
            j = j.next;
        }

        return ans.next;
    }
}