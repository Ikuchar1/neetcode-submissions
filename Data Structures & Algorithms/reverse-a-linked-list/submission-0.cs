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
    public ListNode ReverseList(ListNode head) {
        //two node example
        /*
            1st node this.next = 2nd
            2nd node this.next = null

            take first one. put in temp
        */


        //loop thru all the nodes. loop until listNode == null;
        //get a temp node. 
        ListNode currNode = head;
        ListNode prevNode = null;
        ListNode tempNode = new ListNode();

        while(currNode != null){

            tempNode = currNode.next;
            currNode.next = prevNode;
            prevNode = currNode;
            currNode = tempNode;

        }

        return prevNode;

    }
}
