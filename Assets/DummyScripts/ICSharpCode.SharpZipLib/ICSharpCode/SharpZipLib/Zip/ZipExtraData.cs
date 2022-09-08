/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

// Image 54: ICSharpCode.SharpZipLib.dll - Assembly: ICSharpCode.SharpZipLib, Version=0.86.0.518, Culture=neutral, PublicKeyToken=1b03e6acf1164f73 - Types 6620-6667

namespace ICSharpCode.SharpZipLib.Zip
{
	public sealed class ZipExtraData : IDisposable // TypeDefIndex: 6650
	{
		// Fields
		private int _index; // 0x10
		private int _readValueStart; // 0x14
		private int _readValueLength; // 0x18
		private MemoryStream _newEntry; // 0x20
		private byte[] _data; // 0x28
	
		// Properties
		public int ValueLength { get => default; } // 0x0000000189487110-0x0000000189487170 
		public int UnreadCount { get => default; } // 0x0000000189487060-0x0000000189487110 
	
		// Constructors
		public ZipExtraData() {} // Dummy constructor
		public ZipExtraData(byte[] data) {} // 0x0000000189486FC0-0x0000000189487060
	
		// Methods
		public bool Find(int headerID) => default; // 0x0000000189486840-0x0000000189486950
		public long ReadLong() => default; // 0x0000000189486CA0-0x0000000189486D40
		public int ReadInt() => default; // 0x0000000189486B50-0x0000000189486CA0
		public int ReadShort() => default; // 0x0000000189486E60-0x0000000189486F40
		public int ReadByte() => default; // 0x0000000189486950-0x0000000189486A10
		public void Skip(int amount) {} // 0x0000000189486F40-0x0000000189486FC0
		private void ReadCheck(int length) {} // 0x0000000189486A10-0x0000000189486B50
		private int ReadShortInternal() => default; // 0x0000000189486D40-0x0000000189486E60
		public void Dispose() {} // 0x00000001894867D0-0x0000000189486840
	}
}
