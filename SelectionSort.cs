using System;
using System.Linq;
using System.Collections;

namespace Sorting
{
	class SelectionSort
	{
		public void DoubleSelectionSort(ref double[] list, bool smallToBig)
		{
			List<double> sorted = new List<double>;
			while(list.Count() != 0)
			{
				sorted.Add(list.Max());
				list.Remove(list.Max());
			}
			if(smallToBig)
			{
				sorted.Reverse();
			}
			return sorted;
		}
		public void FloatSelectionSort(ref float[] list, bool smallToBig)
		{
			List<float> sorted = new List<float>;
			while(list.Count() != 0)
			{
				sorted.Add(list.Max());
				list.Remove(list.Max());
			}
			if(smallToBig)
			{
				sorted.Reverse();
			}
			return sorted;
		}
	}
}