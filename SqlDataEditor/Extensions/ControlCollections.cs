using SqlDataEditor.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.TabControl;

namespace SqlDataEditor.Extensions
{
	internal static class ControlCollections
	{
		public static IEnumerable<T2> SelectOfType<T1, T2>(this IEnumerable enumerable, Func<T1, T2> propertySelector)
		{
			return Enumerable.Select(enumerable.OfType<T1>(), propertySelector);
		}

		public static IEnumerable<T> Select<T>(this TabPageCollection pageCollection, Func<TabPage, T> propertySelector)
		{
			return pageCollection.Cast<TabPage>().Select(propertySelector);
		}

		public static IEnumerable<T> SelectMany<TChildType, T>(this TabPageExCollection pageCollection, Func<TChildType, T> propertySelector)
		{
			return pageCollection.Cast<TabPage>().SelectMany(c => c.Controls.OfType<TChildType>().Select(propertySelector));
		}

		public static IEnumerable<TTarget> Select<TTarget>(this ControlCollection controlCollection, Func<Control, TTarget> propertySelector)
		{
			return controlCollection.Cast<Control>().Select(propertySelector);
		}

		public static int FindIndex<T>(this ICollection<T> collection, Predicate<T> predicate)
		{
			for (int i = 0; i < collection.Count; i++)
			{
				if (predicate(collection.ElementAt(i)))
				{
					return i;
				}
			}

			return -1;
		}
	}
}
