namespace LeetCode._104_MaxDepthInBinaryTree;

public class Solution
{
    public int MaxDepth(TreeNode root)
    {
        if (root == null)
            return 0;
        return MaxDepth(root, 1);
    }

    private int MaxDepth(TreeNode node, int step)
    {
        if (node.left == null && node.right == null)
            return step;

        var left = step;
        var right = step;
        if (node.left != null)
            left = MaxDepth(node.left, step + 1);
        if (node.right != null)
            right = MaxDepth(node.right, step + 1);

        return left > right ? left : right;
    }
}

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}
