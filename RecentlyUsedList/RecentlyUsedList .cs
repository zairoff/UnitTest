using System;
using System.Collections.Generic;

namespace RecentlyUsedList
{
    public class List
    {
        private readonly LinkedList<string> _items;
        private readonly int _capacity;
        private int _count = 0;

        public List(int capacity)
        {
            _items = new LinkedList<string>();
            _capacity = capacity;
        }

        public void Add(string input)
        {
            if (string.IsNullOrEmpty(input))
                throw new ArgumentNullException();

            if (_count == _capacity)
                throw new OverflowException();

            _items.AddFirst(input);
            _count++;
        }

        public void Print()
        {
            foreach(var item in _items)
                Console.WriteLine(item);
        }
    }
}
