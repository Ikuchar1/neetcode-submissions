/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {    
    public bool IsSubtree(TreeNode root, TreeNode subRoot) {
        
        if(subRoot == null){
            return true;
        }

        if(root == null){
            return false;
        }

        return IsSameTree(root, subRoot) || IsSubtree(root.left, subRoot) || IsSubtree(root.right, subRoot);

        // //check left
        //     if (root.left != null && root.left.val == subRoot.val){
        //         //check is same tree
        //         return IsSameTree(root.left, subRoot);

        //     } else if(root.right != null && root.right.val == subRoot.val){
        //         return IsSameTree(root.right, subRoot);
        //     } else{

        //         return IsSubtree(root.left, subRoot) || IsSubtree(root.right, subRoot);

        //     }
    }


    public bool IsSameTree(TreeNode p, TreeNode q) {
        
        

        //check if either are null
        if(p == null || q == null){
            if(p == q){
                return true;
            } else {
                return false;
            }
        }

        if(p.val != q.val){
            return false;
        }

        return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);

    }
}
