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
    public bool HasCycle(ListNode head) {
        //HashSet<ListNode> set = new HashSet<ListNode>();
        Dictionary<ListNode, int> set = new Dictionary<ListNode, int>();

        ListNode currNode = head;

        int index = 0;

        while(currNode != null){
            
            //check to see if its in the set
            
            //if in set return the index?
            if (set.ContainsKey(currNode)){
                
                return true;

            } else {
                
                set.Add(currNode, index);
                index++;
            }
            //if not in set, add it to set and move on.


            currNode = currNode.next;
        }

        return false;
    }
}
