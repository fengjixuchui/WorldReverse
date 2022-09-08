/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 43: zxing.unity.dll - Assembly: zxing.unity, Version=0.15.0.0, Culture=neutral, PublicKeyToken=null - Types 4567-4702

namespace ZXing.QrCode.Internal
{
	public sealed class ByteMatrix // TypeDefIndex: 4613
	{
		// Fields
		private readonly byte[][] bytes; // 0x10
		private readonly int width; // 0x18
		private readonly int height; // 0x1C
	
		// Properties
		public int Height { get => default; } // 0x0000000188DA4900-0x0000000188DA4960 
		public int Width { get => default; } // 0x0000000188DA4A30-0x0000000188DA4A90 
		public int this[int x, int y] { get => default; set {} } // 0x0000000188DA4960-0x0000000188DA4A30 0x0000000188DA4A90-0x0000000188DA4B60
		public byte[][] Array { get => default; } // 0x0000000188DA48A0-0x0000000188DA4900 
	
		// Constructors
		public ByteMatrix() {} // Dummy constructor
		public ByteMatrix(int width, int height) {} // 0x0000000188DA4660-0x0000000188DA47B0
	
		// Methods
		public void set(int x, int y, bool value) {} // 0x0000000188DA4B60-0x0000000188DA4C40
		public void clear(byte value) {} // 0x0000000188DA47B0-0x0000000188DA48A0
		public override string ToString() => default; // 0x0000000188DA44A0-0x0000000188DA4660
	}
}
