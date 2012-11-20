using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using prep.utility.filtering;

namespace prep.utility
{
	public static class intExtensions
	{
		public static string hello(this int one, string bob)
		{
			return bob + " " + one.ToString();
		}

		public static FallsInRange<TProperty> AndGreater<TProperty>(this int value) where TProperty:IComparable<TProperty>
		{
			
		}
	}
}
