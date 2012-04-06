using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace OxIDE.DCPU
{
	/// <summary>
	/// Represents a program which can be loaded and executed by a <see cref="VirtualMachine" />.
	/// </summary>
	public class Program
	{
		#region Constructors

		/// <summary>
		/// Creates a new instance based on the give buffer.
		/// </summary>
		/// <param name="buffer">The buffer which contains the program.</param>
		/// <param name="symbolData">The symbol data, if available, used when debugging.</param>
		public Program(ushort[] buffer, byte[] symbolData = null)
		{
			this.Buffer = buffer;
			// TODO: implement symbol data.
		}

		#endregion

		#region Properties

		/// <summary>
		/// Gets the buffer which contains the program.
		/// </summary>
		public ushort[] Buffer
		{
			get;
			private set;
		}

		#endregion

		#region Methods

		/// <summary>
		/// Loads the program from either a hexidecimal file: an ASCII file with every word on its own line,
		/// or from a binary file which is directly read into the buffer.
		/// </summary>
		/// <param name="filePath">The path of the file to read.</param>
		/// <returns>The loaded program.</returns>
		/// <exception cref="FileNotFoundException">The given file could not be found.</exception>
		public static Program LoadFrom(string filePath)
		{
			if (File.Exists(filePath) == false)
			{
				throw new FileNotFoundException("File \"" + filePath + "\" could not be found.");
			}

			// Determine how to load the file based on its extension.
			var extension = Path.GetExtension(filePath);
			if (extension == ".hex")
			{
				// Read all the lines, and remove empty lines.
				var lines = File.ReadAllLines(filePath).Where(e => String.IsNullOrWhiteSpace(e) == false).ToArray();

				// Convert to lines to Words.
				ushort[] buffer = new ushort[lines.Length];
				for (int i = 0; i < lines.Length; ++i)
				{
					var code = Convert.ToUInt16(lines[i].Trim(), 16);
					buffer[i] = code;
				}

				return new Program(buffer);
			}
			else if (extension == ".bin")
			{
				ushort[] buffer;

				// Simply read the file word by word in binary format.
				using (var stream = File.OpenRead(filePath))
				using (var reader = new BinaryReader(stream))
				{
					buffer = new ushort[stream.Length / 2];
					for (int i = 0; i < buffer.Length; ++i)
					{
						buffer[i] = reader.ReadUInt16();
					}
				}
			}
			
			throw new NotSupportedException("The given file format is not supported.");
		}

		#endregion
	}
}
