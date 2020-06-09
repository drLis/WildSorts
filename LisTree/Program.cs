using System;
using System.ComponentModel;

namespace LisTree
{
	class LisTree
	{
		Int32[] memory;

		UInt32 heigh;

		public LisTree(UInt32 heigh)
		{
			memory = new Int32[Convert.ToInt32(Math.Pow(2, heigh)) - 1];
		}

		public void Add(Int32 value)
		{
			add(value, 0, 0);
		}

		private void add(Int32 value, Int32 level, Int32 position)
		{
			if (memory[Convert.ToInt32(Math.Pow(2, level)) - 1 + position] == 0)
			{
				memory[Convert.ToInt32(Math.Pow(2, level)) - 1 + position] = value;
			}
			else if (memory[Convert.ToInt32(Math.Pow(2, level)) - 1 + position] < value)
			{
				add(value, level + 1, position * 2 + 1);
			}
			else
			{
				add(value, level + 1, position * 2);
			}
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			var tree = new LisTree(3);
			tree.Add(5);
			tree.Add(3);
			tree.Add(2);
			tree.Add(4);
			tree.Add(7);
			tree.Add(6);
			tree.Add(8);
			Console.WriteLine("Hello World!");
		}
	}
}
