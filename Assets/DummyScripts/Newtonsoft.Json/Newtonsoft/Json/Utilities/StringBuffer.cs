/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using Newtonsoft.Json;
using Newtonsoft.Json.Shims;

// Image 47: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5228-5529

namespace Newtonsoft.Json.Utilities
{
	[Preserve] // 0x00000001897D5F50-0x00000001897D5F60
	internal struct StringBuffer // TypeDefIndex: 5337
	{
		// Fields
		private char[] _buffer; // 0x00
		private int _position; // 0x08
	
		// Properties
		public int Position { get => default; set {} } // 0x0000000185E67230-0x0000000185E672F0 0x0000000185E672F0-0x0000000185E67490
		public bool IsEmpty { get => default; } // 0x0000000185E67170-0x0000000185E67230 
		public char[] InternalBuffer { get => default; } // 0x0000000185E670B0-0x0000000185E67170 
	
		// Constructors
		public StringBuffer(IArrayPool<char> bufferPool, int initalSize) : this() {
			_buffer = default;
			_position = default;
		} // 0x0000000185E67040-0x0000000185E670B0
		private StringBuffer(char[] buffer) : this() {
			_buffer = default;
			_position = default;
		} // 0x0000000185E66F00-0x0000000185E67040
	
		// Methods
		public void Append(IArrayPool<char> bufferPool, char value) {} // 0x0000000185E66C70-0x0000000185E66D10
		public void Append(IArrayPool<char> bufferPool, char[] buffer, int startIndex, int count) {} // 0x0000000185E66B90-0x0000000185E66C70
		public void Clear(IArrayPool<char> bufferPool) {} // 0x0000000185E66D10-0x0000000185E66DE0
		private void EnsureSize(IArrayPool<char> bufferPool, int appendLength) {} // 0x0000000185E66DE0-0x0000000185E66DF0
		public override string ToString() => default; // 0x0000000185E66DF0-0x0000000185E66EF0
		public string ToString(int start, int length) => default; // 0x0000000185E66EF0-0x0000000185E66F00
	}
}
