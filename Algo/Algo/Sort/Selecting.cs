namespace Algo.Sort;

/// <summary>
/// Сортировка выбором (Selection Sort)
/// Медленный. O(n^2)
/// </summary>
public static class Selecting
{
    public static void Do(int[] source)
    {
        if (source == null || source.Length == 0)
            return;

        for (int i = 0; i < source.Length; i++)
        {
            var minValue = source[i];
            var minIndex = i;
            for (int j = i + 1; j < source.Length; j++)
            {
                var el = source[j];
                if (el < minValue)
                {
                    minValue = el;
                    minIndex = j;
                }
            }

            if (minIndex == i)
                continue;

            var cur = source[i];
            source[i] = minValue;
            source[minIndex] = cur;
        }
    }
}
