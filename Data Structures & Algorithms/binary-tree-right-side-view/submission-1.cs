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

            var node = queue.Dequeue();

            ans.Add(node.val);

            int len = queue.Count;

            if(node.right != null) queue.Enqueue(node.right);
            if(node.left != null) queue.Enqueue(node.left);

            for(int i = 0; i<len; i++){
                var node1 = queue.Dequeue();

                if(node1.right != null) queue.Enqueue(node1.right);
                if(node1.left != null) queue.Enqueue(node1.left);
            }


        }
        return ans;
    }
}
