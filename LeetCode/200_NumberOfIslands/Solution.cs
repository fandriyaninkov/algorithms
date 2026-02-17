namespace LeetCode._200_NumberOfIslands;

public class Solution
{
    public int NumIslands(char[][] grid)
    {
        var count = 0;
        var queue = new Queue<(int, int)>();
        for (var m = 0; m < grid.Length; m++)
            for (var n = 0; n < grid[m].Length; n++)
            {
                var cur = grid[m][n];
                if (cur == '0')
                    continue;
                
                count++;
                grid[m][n] = '0';
                AddInQueue(queue, grid, m, n);
                while (queue.Count > 0)
                {
                    var (x, y) = queue.Dequeue();
                    if (grid[x][y] == '0')
                        continue;

                    grid[x][y] = '0';
                    AddInQueue(queue, grid, x, y);
                }
            }
        return count;
    }

    private bool CheckInArray(char[][] grid, int x, int y)
    {
        return x >= 0
            && y >= 0
            && grid.Length - 1 >= x
            && grid[x].Length - 1 >= y
            && grid[x][y] == '1';
    }

    private void AddInQueue(Queue<(int, int)> queue, char[][] grid, int x, int y)
    {
        if (CheckInArray(grid, x, y + 1))
            queue.Enqueue((x, y + 1));
        if (CheckInArray(grid, x, y - 1))
            queue.Enqueue((x, y - 1));
        if (CheckInArray(grid, x + 1, y))
            queue.Enqueue((x + 1, y));
        if (CheckInArray(grid, x - 1, y))
            queue.Enqueue((x - 1, y));
    }
}
