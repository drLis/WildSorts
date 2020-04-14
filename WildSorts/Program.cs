using System;
using System.Collections;
using System.Collections.Generic;

namespace WildSorts
{
	class Program
	{
		static Int32 Sort(Int32[] array, Int32 currentIndex)
		{
			try
			{
				if (array[currentIndex + 1] < array[currentIndex])
				{
					if (indexes.Peek() > 0)
					{
						indexes.Push(1);
						return Sort(array, currentIndex + 1);
					}
					else
					{
						Console.WriteLine($"{currentIndex} {array[currentIndex]} {array[currentIndex + 1]}");
						indexes.Push(currentIndex + 1);
						Console.WriteLine(currentIndex + 1);
						return Sort(array, currentIndex + 1);
					}
				}
				else
				{
					if (indexes.Peek() < 0)
					{
						indexes.Push(-1);
						return Sort(array, currentIndex + 1);
					}
					else
					{
						Console.WriteLine($"{currentIndex} {array[currentIndex]} {array[currentIndex + 1]}");
						indexes.Push(-(currentIndex + 1));
						return Sort(array, currentIndex + 1);
					}
				}
			}
			catch
			{
				return currentIndex;
			}
		}

		static Stack<Int32> indexes = new Stack<Int32>();

		static Int32 steped = 0;
	
		static void Main(string[] args)
		{
			Int32[] array = new Int32[] { 5, 4, 3, 6, 7, 1, 9, 8};
			indexes.Push(1);
			indexes.Push(Sort(array, 1));
			foreach (var i in indexes)
			{
				Console.WriteLine(i);
			}
		}
	}
}
