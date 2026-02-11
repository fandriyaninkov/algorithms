namespace LeetCode._733_FloodFill;

public class Solution
{
    public int[][] FloodFill(int[][] image, int sr, int sc, int color)
    {
        var original = image[sr][sc];
        if (color == original)
            return image;

        var queue = new Queue<(int, int)>();
        queue.Enqueue((sr, sc));
        int count = 0;
        while (queue.Count > 0)
        {
            count++;
            var (x, y) = queue.Dequeue();
            var colorXY = image[x][y];
            if (colorXY != original || colorXY == color)
                continue;
            image[x][y] = color;
            if (CheckInArray(image, x + 1, y, original))
                queue.Enqueue((x + 1, y));
            if (CheckInArray(image, x - 1, y, original))
                queue.Enqueue((x - 1, y));
            if (CheckInArray(image, x, y + 1, original))
                queue.Enqueue((x, y + 1));
            if (CheckInArray(image, x, y - 1, original))
                queue.Enqueue((x, y - 1));
        }
        
        return image;
    }

    private bool CheckInArray(int[][] image, int x, int y, int original)
    {
        return x >= 0
            && y >= 0
            && image.Length - 1 >= x
            && image[x].Length - 1 >= y 
            && image[x][y] == original;
    }
}
