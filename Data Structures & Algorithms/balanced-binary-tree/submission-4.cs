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
    public bool IsBalanced(TreeNode root) {
        return CheckDepth(root) != -1;
    }

    public int CheckDepth(TreeNode root){
        if(root == null) return 0;

        int left = CheckDepth(root.left);

        if(left == -1) return -1;

        int right = CheckDepth(root.right);
        
        if(right == -1) return -1;
        if(Math.Abs(left-right)>1) return -1;

        return 1 + Math.Max(right, left);


    }
}
