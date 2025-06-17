namespace OOP.Generics;

class Any<T>
{
    private T[] _items;

    public void Add(T item)
    {
        if (_items is null)
        {
            _items = new T[1];
            _items[0] = item;
            return;
        }
        var length = _items.Length;
        var temp = new T[length + 1];
        Array.Copy(_items, temp, length);
        temp[length] = item;
        _items = temp;
    }

    public void Remove(int position)
    {
        if (_items is null || _items.Length == 0|| position < 0 || position >= _items.Length)
                return;
        
        var length = _items.Length;
        var temp = new T[length-1];
        var index = 0;
        for (int i = 0; i < _items.Length; i++)
        {
            if (i==position)
                continue;
            temp[index++] = _items[i];
        }
        _items = temp;
    }

    public void print()
    {
        Console.Write("{");
        for (int i = 0; i < _items.Length; i++)
        {
            Console.Write(_items[i]);
            if(i<_items.Length-1)
                Console.Write(",");
            
            
        }

        Console.WriteLine("}");
    }
    
}