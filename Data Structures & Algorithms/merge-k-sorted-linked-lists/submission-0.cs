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
    public ListNode MergeKLists(ListNode[] lists) {
        if (lists.Length == 0 ) return new ListNode().next;

        List<int> array = new List<int>();
        for(int i = 0; i<lists.Length; i++){
            ListNode curr = lists[i];

            while(curr!=null){
                array.Add(curr.val);
                curr = curr.next;
            }

        }

        array.Sort();

        ListNode newListNode = new ListNode();

        ListNode c = newListNode;

        for(int i = 0; i<array.Count; i++){
            c.val = array[i];
            if(i!= array.Count-1){
            c.next = new ListNode();}
            c = c.next;
        }

        return newListNode;

    }
}
