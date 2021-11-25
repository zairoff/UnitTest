using System;
using System.Collections.Generic;

namespace RecentlyUsedList
{
    public class List
    {
        private readonly LinkedList<string> _items;
        private readonly HashSet<string> _holder;
        private readonly int _capacity;
        private int _count = 0;

        public List(int capacity = 5)
        {
            _items = new LinkedList<string>();
            _holder = new HashSet<string>();
            _capacity = capacity;
        }

        public void Add(string input)
        {
            if (string.IsNullOrEmpty(input))
                throw new ArgumentNullException();

            if (_count == _capacity - 1)
                throw new OverflowException();

            if (_holder.Contains(input))
                throw new InvalidOperationException($"List already has {input} input");

            _holder.Add(input);
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
