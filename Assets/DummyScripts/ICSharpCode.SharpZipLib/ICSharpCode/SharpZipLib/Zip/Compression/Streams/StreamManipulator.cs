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
	public class StreamManipulator // TypeDefIndex: 6637
	{
		// Fields
		private byte[] window_; // 0x10
		private int windowStart_; // 0x18
		private int windowEnd_; // 0x1C
		private uint buffer_; // 0x20
		private int bitsInBuffer_; // 0x24
	
		// Properties
		public int AvailableBits { get => default; } // 0x0000000189482BB0-0x0000000189482C10 
		public int AvailableBytes { get => default; } // 0x0000000189482C10-0x0000000189482C70 
		public bool IsNeedingInput { get => default; } // 0x0000000189482C70-0x0000000189482CD0 
	
		// Constructors
		public StreamManipulator() {} // 0x0000000189482B50-0x0000000189482BB0
	
		// Methods
		public int PeekBits(int bitCount) => default; // 0x00000001894827C0-0x00000001894828E0
		public void DropBits(int bitCount) {} // 0x0000000189482750-0x00000001894827C0
		public void SkipToByteBoundary() {} // 0x0000000189482AE0-0x0000000189482B50
		public int CopyBytes(byte[] output, int offset, int length) => default; // 0x0000000189482560-0x0000000189482750
		public void SetInput(byte[] buffer, int offset, int count) {} // 0x00000001894828E0-0x0000000189482AE0
	}
}
