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
	internal static class BufferUtils // TypeDefIndex: 5335
	{
		// Methods
		public static char[] RentBuffer(IArrayPool<char> bufferPool, int minSize) => default; // 0x0000000185E48F00-0x0000000185E48FA0
		public static void ReturnBuffer(IArrayPool<char> bufferPool, char[] buffer) {} // 0x0000000185E48FA0-0x0000000185E49020
		public static char[] EnsureBufferSize(IArrayPool<char> bufferPool, int size, char[] buffer) => default; // 0x0000000185E48E30-0x0000000185E48F00
	}
}
