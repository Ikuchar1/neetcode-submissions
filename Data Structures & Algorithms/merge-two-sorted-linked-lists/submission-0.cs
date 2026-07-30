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
        //start with the 2 heads. 
        //see if which one is lower, set that to head, then loop until one is empty. keep picking next lower one

        

        ListNode newList = new ListNode();
        ListNode currNode = newList;

        //get head
        //check if both have values
        if (list1 == null){
            return list2;
        } else if (list2 == null){
            return list1;
        }

        if(list1.val <= list2.val){
            newList.val = list1.val;
            list1 = list1.next;
        } else{
            newList.val = list2.val;
            list2 = list2.next;
        }
        
        while(list1 != null && list2 != null){

            ListNode tempNode = new ListNode();
            currNode.next = tempNode;
            currNode = tempNode;

            //get next smallest one
            if (list1.val <= list2.val){
                currNode.val = list1.val;
                list1 = list1.next;
            } else {
                currNode.val = list2.val;
                list2 = list2.next;
            }
        }

        //check which one is null
        if(list1 == null){
            currNode.next = list2;
        } else {
            currNode.next = list1;
        }

        return newList;

    }
}