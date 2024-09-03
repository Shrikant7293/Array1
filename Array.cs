using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array1
{
	internal class ArrayProgram
	{

		public void FindMaxNumber()
		{
			int[] num = new int[] { 10, 54, 64, 454, 3, 45, 345, 456, 345, 234 };

			int Max = num[0];

			for (int i = 1; i < 10; i++)
			{
				if (Max < num[i])
				{
					Max = num[i];
				}
			}
			Console.WriteLine(Max);

		}

		public void BubbleSort()
		{
			int[] num = new int[] { 10, 564, 355, 35, 34, 634, 62, 5, 64, 744 };

			int Temp;
			for (int i = 0; i < 10; i++)
			{
				for (int j = i + 1; j < 10; j++)
				{
					if (num[i] > num[j])
					{
						Temp = num[i];
						num[i] = num[j];
						num[j] = Temp;
					}
				}
			}
			for (int i = 0; i < 10; i++)
			{
				Console.WriteLine(num[i]);
			}
		}

		public void SwapingTwoNumberWithoutThirdVariable()
		{
			int A = 2, B = 3;

			Console.WriteLine($"Before Value A = {A} & B = {B}");

			A = A + B;
			B = A - B;
			A = A - B;
			Console.WriteLine($"After Value A = {A} & B = {B}");

		}

	}
}
