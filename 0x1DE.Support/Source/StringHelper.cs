using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OxIDE.Support
{
	/// <summary>
	/// Contains helper methods for use with the <see cref="System.String" /> class.
	/// </summary>
	public static class StringHelper
	{
		#region Methods

		/// <summary>
		/// 
		/// </summary>
		/// <param name="input"></param>
		/// <param name="count"></param>
		/// <returns></returns>
		public static string Repeat(this string input, int count)
		{
			var sb = new StringBuilder();
			for (int i = 0; i < count; ++i)
			{
				sb.Append(input);
			}

			return sb.ToString();
		}

		#endregion
	}
}
