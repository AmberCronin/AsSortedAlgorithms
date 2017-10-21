using System;
using System.Collections;
using System.Linq;

namespace Sorting
{
	class BubbleSort
	{
		public void DoubleBubbleSort(ref double[] list)
		{
			bool sorted = false;
			while(!sorted)
			{
				BubbleList(list);
				for(int i = 0; i < list.Count; i++)
				{
					if(list[i] > list[i+1])
					{
						BubbleList(list);
						i = 0;
					}
				}
				sorted = true;
			}
		}
		private void BubbleList(ref double[] list)
		{
			for(int i = 0; i < list.Count; i++)
			{
				if(list[i] > list[i+1])
				{
					list.Insert(i, list[i+1]);
					list.RemoveAt(i+2);
				}
			}
		}
	}
}