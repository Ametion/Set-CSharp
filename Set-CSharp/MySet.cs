namespace Set_CSharp;

public class MySet<T>
{
    private List<T> items = new List<T>();

    public int Count => items.Count;

    public MySet() { }

    public MySet(T item) => items.Add(item);

    public MySet(IEnumerable<T> items)
    {
        this.items = items.ToList();
    }
    
    public void Add(T item)
    {
        if (items.Contains(item)) return;
        
        items.Add(item);
    }

    public void Remove(T item) => items.Remove(item);

    public MySet<T> Union(MySet<T> set)
    {
        MySet<T> resultat = new MySet<T>();
        
        foreach (var item in items)
            resultat.Add(item);
        
        foreach (var item in set.items)
            resultat.Add(item);
        
        
        return resultat;
    }

    public MySet<T> Intersection(MySet<T> set)
    {
        var result = new MySet<T>();
        MySet<T> big;
        MySet<T> small;

        if (Count >= set.Count)
        {
            big = this;
            small = set;
        }
        else
        {
            big = set;
            small = set;
        }
        
        foreach (var item1 in small.items)
        {
            foreach (var item2 in big.items)
            {
                if (item1.Equals(item2)) result.Add(item1);
                break;
            }
        }
        
        return result;
    }

    public MySet<T> Difference(MySet<T> set)
    {
        MySet<T> result = new MySet<T>(items);

        foreach (var item in set.items)
            result.Remove(item);

        return result;
    }

    public bool IsSubset(MySet<T> set)
    {
        foreach (var item1 in set.items)
        {
            var equals = false;

            foreach (var item2 in items)
            {
                if (item1.Equals(item2))
                {
                    equals = true;
                    break;
                }
            }

            if (!equals) return false;
        }

        return true;
    }
}