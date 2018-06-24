using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionWithRef
{
	class MyList
	{
		private int[] _items = { 3, 4, 7, 1, 4, 6 };

		public ref int GetRefToSmallestItem()
		{
			var smallest = _items[0];
			int index = 0;
			for (int i = 1; i < _items.Length; i++)
			{
				if (_items[i] < smallest)
				{
					smallest = _items[i];
					index = i;
				}
			}
			return ref _items[index];
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			MyList l = new MyList();
			ref int i = ref l.GetRefToSmallestItem();
			i = 42;
		}
	}
}
