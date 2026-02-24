using LeetCode.Common;

namespace LeetCode._101_SymmetricTree;

public class Solution
{
    public bool IsSymmetric(TreeNode root)
    {
        if (root == null) 
            return false;

        return IsSymmetricChild(root.left, root.right);
    }

    private bool IsSymmetricChild(TreeNode left, TreeNode rigth)
    {
        if (left == null && rigth == null)
            return true;
        if ((left != null && rigth == null) || (left == null && rigth != null))
            return false;
        if (left != null && rigth != null && left.val != rigth.val)
            return false;
        if (left.left == null && left.right == null && rigth.left == null && rigth.right == null)
            return true;

        var leftSymmetric = (left.left == null && rigth.right == null) || IsSymmetricChild(left.left, rigth.right);
        var rightSymmetric = (left.right == null && rigth.left == null) || IsSymmetricChild(left.right, rigth.left);

        return leftSymmetric && rightSymmetric;
    }
}
