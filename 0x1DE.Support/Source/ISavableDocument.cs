using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OxIDE.Support
{
	/// <summary>
	/// Implemented by documents who can save.
	/// </summary>
	public interface ISavableDocument
	{
		#region Properties

		/// <summary>
		/// Gets if the document has changed since the last save.
		/// </summary>
		bool IsDirty
		{
			get;
		}

		#endregion

		#region Methods

		/// <summary>
		/// Saves the document.
		/// </summary>
		void Save();

		#endregion
	}
}
