/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

// Image 54: ICSharpCode.SharpZipLib.dll - Assembly: ICSharpCode.SharpZipLib, Version=0.86.0.518, Culture=neutral, PublicKeyToken=1b03e6acf1164f73 - Types 6620-6667

namespace ICSharpCode.SharpZipLib.Zip.Compression.Streams
{
	public class OutputWindow // TypeDefIndex: 6636
	{
		// Fields
		private byte[] window; // 0x10
		private int windowEnd; // 0x18
		private int windowFilled; // 0x1C
	
		// Constructors
		public OutputWindow() {} // 0x0000000189480280-0x0000000189480310
	
		// Methods
		public void Write(int value) {} // 0x00000001894801A0-0x0000000189480280
		private void SlowRepeat(int repStart, int length, int distance) {} // 0x00000001894800B0-0x00000001894801A0
		public void Repeat(int length, int distance) {} // 0x000000018947FF00-0x00000001894800B0
		public int CopyStored(StreamManipulator input, int length) => default; // 0x000000018947FCD0-0x000000018947FE30
		public int GetFreeSpace() => default; // 0x000000018947FE90-0x000000018947FF00
		public int GetAvailable() => default; // 0x000000018947FE30-0x000000018947FE90
		public int CopyOutput(byte[] output, int offset, int len) => default; // 0x000000018947FB90-0x000000018947FCD0
	}
}
