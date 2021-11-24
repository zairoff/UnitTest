using System;
using System.Collections.Generic;

namespace RecentlyUsedList
{
    public class List
    {
        private readonly LinkedList<string> _items;
        private readonly int _count;

        public List(int capacity)
        {
            _items = new LinkedList<string>();
            _count = capacity;
        }

        public void Add(string input)
        {
            _items.AddFirst(input);
        }
    }
}
