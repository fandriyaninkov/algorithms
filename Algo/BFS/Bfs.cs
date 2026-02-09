namespace Algo.BFS;

public class Bfs
{
    private readonly Dictionary<string, Item[]> Items = new Dictionary<string, Item[]>();

    private void Init()
    {
        Items.Clear();
        var spencer = new Item("Spencer", false);
        var oliver = new Item("Oliver", false);
        var jack = new Item("Jack", false);
        var harry = new Item("Harry", false);

        var jacob = new Item("Jacob", false);
        var charlie = new Item("Charlie", false);
        var thomas = new Item("Thomas", false);
        var george = new Item("George", false);
        var oscar = new Item("Oscar", false);

        var james = new Item("James", false);
        var william = new Item("William", false);
        var amelia = new Item("Amelia", true);

        Items["Spencer"] = [oliver, jack, harry];

        Items["Oliver"] = [charlie, george];
        Items["Jack"] = [jacob];
        Items["Harry"] = [charlie, thomas, oscar];

        Items["George"] = [james, william];
        Items["Oscar"] = [james, amelia];
        Items["Thomas"] = [amelia];
    }

    public string? Do()
    {
        Init();

        var check = new HashSet<string>();
        var queue = new Queue<Item>();
        var first = Items["Spencer"];
        foreach (var item in first)
            queue.Enqueue(item);

        while (queue.Count > 0)
        {
            var item = queue.Dequeue();
            if (!check.Add(item.Name))
                continue;
            if (item.IsSeller)
                return item.Name;

            if (!Items.TryGetValue(item.Name, out var friends))
                continue;

            foreach (var friend in friends)
                queue.Enqueue(friend);
        }

        return null;
    }
}

public readonly record struct Item(string Name, bool IsSeller);