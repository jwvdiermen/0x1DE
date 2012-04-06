using System;

namespace OxIDE.DCPU
{
	/// <summary>
	/// The non-basic opcodes.
	/// </summary>
	public enum ExtendedOpcodes : ushort
	{
		Reserved = 0x00,
		JSR = 0x01
	}
}
