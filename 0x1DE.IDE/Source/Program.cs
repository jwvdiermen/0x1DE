using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OxIDE.IDE
{
	/// <summary>
	/// The main entry class.
	/// </summary>
	static class Program
	{
		#region Methods

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainWindow());
		}

		#endregion
	}
}
