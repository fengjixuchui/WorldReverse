/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using Newtonsoft.Json.Shims;

// Image 47: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5228-5529

namespace Newtonsoft.Json.Utilities
{
	[Preserve] // 0x00000001897D5F50-0x00000001897D5F60
	internal class PropertyNameTable // TypeDefIndex: 5296
	{
		// Fields
		private static readonly int HashCodeRandomizer; // 0x00
		private int _count; // 0x10
		private Entry[] _entries; // 0x18
		private int _mask; // 0x20
	
		// Nested types
		private class Entry // TypeDefIndex: 5297
		{
			// Fields
			internal readonly string Value; // 0x10
			internal readonly int HashCode; // 0x18
			internal Entry Next; // 0x20
	
			// Constructors
			public Entry() {} // Dummy constructor
			internal Entry(string value, int hashCode, Entry next) {} // 0x0000000185E53E20-0x0000000185E53EB0
		}
	
		// Constructors
		static PropertyNameTable() {} // 0x0000000185E60740-0x0000000185E607B0
		public PropertyNameTable() {} // 0x0000000185E607B0-0x0000000185E60850
	
		// Methods
		public string Get(char[] key, int start, int length) => default; // 0x0000000185E602B0-0x0000000185E604D0
		public string Add(string key) => default; // 0x0000000185E600B0-0x0000000185E602B0
		private string AddEntry(string str, int hashCode) => default; // 0x0000000185E5FF50-0x0000000185E600B0
		private void Grow() {} // 0x0000000185E604D0-0x0000000185E60650
		private static bool TextEquals(string str1, char[] str2, int str2Start, int str2Length) => default; // 0x0000000185E60650-0x0000000185E60740
	}
}
