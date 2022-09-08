/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using Newtonsoft.Json.Shims;

// Image 47: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5228-5529

namespace Newtonsoft.Json.Utilities
{
	[Preserve] // 0x00000001897D5F50-0x00000001897D5F60
	internal class Base64Encoder // TypeDefIndex: 5291
	{
		// Fields
		private readonly char[] _charsLine; // 0x10
		private readonly TextWriter _writer; // 0x18
		private byte[] _leftOverBytes; // 0x20
		private int _leftOverBytesCount; // 0x28
	
		// Constructors
		public Base64Encoder() {} // Dummy constructor
		public Base64Encoder(TextWriter writer) {} // 0x0000000185E48D80-0x0000000185E48E30
	
		// Methods
		public void Encode(byte[] buffer, int index, int count) {} // 0x0000000185E48860-0x0000000185E48BF0
		public void Flush() {} // 0x0000000185E48BF0-0x0000000185E48CE0
		private void WriteChars(char[] chars, int index, int count) {} // 0x0000000185E48CE0-0x0000000185E48D80
	}
}
