using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace WildSorts
{
	class Program
	{
		class BinaryTree
		{
			public class Node
			{
				public Int32 value;
				public Int32 counter;
				public Node left;
				public Node right;
			}

			public Node Root { get; private set; }

			public BinaryTree()
			{

			}

			public void Insert(Int32 value, Node node)
			{
				if (node == null)
				{
					Root = new Node();
					Root.value = value;
					Root.counter = 1;
				}
				else if (node.value == value)
				{
					node.counter++;
				}
				else if (value > node.value)
				{
					if (node.right == null)
					{
						node.right = new Node();
						node.right.value = value;
						node.right.counter = 1;
					}
					else
					{
						Insert(value, node.right);
					}
				}
				else
				{
					if (node.left == null)
					{
						node.left = new Node();
						node.left.value = value;
						node.left.counter = 1;
					}
					else
					{
						Insert(value, node.left);
					}
				}
			}

			public List<Int32> ToArray(Node node)
			{
				if (node!= null)
				{
					var array = ToArray(node.left);
					var m = new List<Int32>();
					for (Int32 i = 0; i < node.counter; i++)
					{
						m.Add(node.value);
					}
					array.AddRange(m);
					array.AddRange(ToArray(node.right));
					return array;
				}
				else
				{
					return new List<Int32>(){ };
				}
			}
		}

		static Int32[] sort(Int32[] array)
		{
			BinaryTree tree = new BinaryTree();
			for (Int32 i = 0; i < array.Length; i++)
			{
				tree.Insert(array[i], tree.Root);
			}
			return tree.ToArray(tree.Root).ToArray();
		}

		static void Main(string[] args)
		{
			Int32[] array = new Int32[] { 1, 3, 5, 7, 9, 0, 8, 6, 4, 2, 1, 1, 2, 3, 5, 8, 13 };
			var sortedArray = sort(array);
			foreach (var i in sortedArray)
			{
				Console.WriteLine(i);
			}
		}
	}
}
