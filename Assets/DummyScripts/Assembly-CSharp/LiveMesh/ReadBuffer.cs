/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace LiveMesh
{
	public class ReadBuffer // TypeDefIndex: 28385
	{
		// Fields
		private int availableSize; // 0x10
		private int offset; // 0x14
		private byte[] mBuffer; // 0x18
	
		// Constructors
		public ReadBuffer() {} // Dummy constructor
		public ReadBuffer(byte[] buffer, int size) {} // 0x000000018169D5D0-0x000000018169D6B0
	
		// Methods
		~ReadBuffer() {} // 0x000000018169D050-0x000000018169D0C0
		public uint ReadUInt() => default; // 0x000000018169D4E0-0x000000018169D5D0
		public int ReadInt() => default; // 0x000000018169D290-0x000000018169D380
		public int ReadInt16() => default; // 0x000000018169D1A0-0x000000018169D290
		public int ReadByte() => default; // 0x000000018169D0C0-0x000000018169D1A0
		public string ReadString() => default; // 0x000000018169D380-0x000000018169D4E0
		public T ReadStructure<T>()
			where T : struct => default;
		public T[] ReadArray<T>()
			where T : struct => default;
	}
}
