using System.Collections;
using System.Collections.Generic;

namespace Resol.Picker.Models;

public class Items : IEnumerable<Item>
{
    private readonly List<Item> _items = new();
    public void Add()
    {
        _items.Add(new Item());
    }

    public void Remove()
    {
        if (_items.Count == 0)
        {
            return;
        }
        _items.RemoveAt(0);
    }

    IEnumerator<Item> IEnumerable<Item>.GetEnumerator()
    {
        return _items.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return ((IEnumerable)_items).GetEnumerator();
    }
}
