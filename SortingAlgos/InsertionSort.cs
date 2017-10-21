using System;
using System.Collections;
using System.Linq;

namespace Sorting
{
	class InsertionSort
	{
		private void InsertDouble(double num, ref double[] list)
		{
			for(int i = 0; i < list.Count; i++)
			{
				if(list[i] > num)
				{
						list.Insert(i-1, num);
						return;
				}
			}
		}
		private bool ListHasDuplicates(double[] list)
		{
			int firstIndex;
			for(int i = 0; i < list.Count; i++)
			{
				firstIndex = list.IndexOf(list[i]);
				if(list.IndexOf(list[i], firstIndex) != -1)
				{
						return true;
				}
			}
			return false;
		}
		public double[] DoubleInsertionSort(double[] list, bool smallToBig)
		{
			List<double> sortedList = new List<double>;
			foreach(double d in list)
			{
				InsertDouble(d, sortedList);
			}
			if(!smallToBig)
			{
				sortedList.Reverse();
			}
			return sortedList;
		}
		public double[] DoubleInsertionOneList(ref double[] list, bool smallToBig)
		{
			double min = list.Min();
			list.Remove(list.Min());
			list.Insert(0, min);
			if(ListHasDuplicates(list))
			{

			}
		}
	}
}