/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 43: zxing.unity.dll - Assembly: zxing.unity, Version=0.15.0.0, Culture=neutral, PublicKeyToken=null - Types 4567-4702

namespace ZXing.PDF417.Internal
{
	// [DefaultMember] // 0x0000000189A8E950-0x0000000189A8E980
	internal sealed class BarcodeRow // TypeDefIndex: 4614
	{
		// Fields
		private readonly sbyte[] row; // 0x10
		private int currentLocation; // 0x18
	
		// Constructors
		public BarcodeRow() {} // Dummy constructor
		internal BarcodeRow(int width) {} // 0x0000000188DA3FD0-0x0000000188DA4070
	
		// Methods
		internal void set(int x, bool black) {} // 0x0000000188DA42A0-0x0000000188DA4350
		internal void addBar(bool black, int width) {} // 0x0000000188DA4070-0x0000000188DA4180
		internal sbyte[] getScaledRow(int scale) => default; // 0x0000000188DA4180-0x0000000188DA42A0
	}
}
