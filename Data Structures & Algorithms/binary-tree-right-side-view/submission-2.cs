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
    public List<int> RightSideView(TreeNode root) {
        if(root == null) return new List<int>();
        var queue = new Queue<TreeNode>();

        queue.Enqueue(root);
        List<int> ans = new List<int>();
        while(queue.Count>0){

           int levelSize = queue.Count;

           for(int i = 0; i<levelSize; i++){
                var node = queue.Dequeue();

                if(node.left != null) queue.Enqueue(node.left);
                if(node.right != null) queue.Enqueue(node.right);

                if(i == levelSize-1){
                    ans.Add(node.val);
                }

           }

        }
        return ans;
    }
}
