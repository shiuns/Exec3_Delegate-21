using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _作業03_Exec3_Delegate_21謝孟勳
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<int> items = new List<int> { 2,4,11,88,7,9,5 };
			//Func<int, bool> isEven = n => n % 2 == 0;

			List<int> EvenItems = GetEvenItems(items, IsEven);
			
		}
		static List<int> GetEvenItems(List<int> sourse ,Func<int, bool> func)
		{
			var result = new List<int>();

			foreach (int item in sourse)
			{
				if (func(item) == true)
				{
					result.Add(item);
				}
			}
			return result;
		}
		static bool IsEven (int n) 
		{
			return n % 2 == 0;
		}
	}
}
