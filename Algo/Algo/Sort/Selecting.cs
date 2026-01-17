namespace Algo.Sort;

/// <summary>Сортировка вставкой</summary>
public static class Selecting
{
    public static void Do(int[] source)
    {
        if (source == null || source.Length == 0)
            return;

        for (int i = 0; i < source.Length; i++)
        {
            var min = source[i];
            var index = i;
            for (int j = i + 1; j < source.Length; j++)
            {
                var el = source[j];
                if (el < min)
                {
                    min = el;
                    index = j;
                }
            }

            var cur = source[i];
            source[i] = min;
            source[index] = cur;
        }
    }
}
