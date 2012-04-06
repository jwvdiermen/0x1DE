using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OxIDE.Support
{
	/// <summary>
	/// Represents the method that will handle an event that has no event data.
	/// </summary>
	/// <typeparam name="T">The type of the sender.</typeparam>
	/// <param name="sender">The source of the event.</param>
	public delegate void GenericEvent<T>(T sender);
}
