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
        while (queue.Count > 0)
        {
            var (x, y) = queue.Dequeue();
            var colorXY = image[x][y];
            if (colorXY != original)
                continue;
            image[x][y] = color;
            if (CheckInArray(image, x + 1, y, color))
                queue.Enqueue((x + 1, y));
            if (CheckInArray(image, x - 1, y, color))
                queue.Enqueue((x - 1, y));
            if (CheckInArray(image, x, y + 1, color))
                queue.Enqueue((x, y + 1));
            if (CheckInArray(image, x, y - 1, color))
                queue.Enqueue((x, y - 1));
        }
        
        return image;
    }

    private bool CheckInArray(int[][] image, int x, int y, int color)
    {
        return x >= 0
            && y >= 0
            && image.Length - 1 >= x
            && image[x].Length - 1 >= y 
            && image[x][y] != color;
    }
}
