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
	internal sealed class BarcodeMatrix // TypeDefIndex: 4631
	{
		// Fields
		private readonly BarcodeRow[] matrix; // 0x10
		private int currentRow; // 0x18
		private readonly int height; // 0x1C
		private readonly int width; // 0x20
	
		// Constructors
		public BarcodeMatrix() {} // Dummy constructor
		internal BarcodeMatrix(int height, int width) {} // 0x0000000188DA3B20-0x0000000188DA3C90
	
		// Methods
		internal void startRow() {} // 0x0000000188DA3F70-0x0000000188DA3FD0
		internal BarcodeRow getCurrentRow() => default; // 0x0000000188DA3C90-0x0000000188DA3D30
		internal sbyte[][] getScaledMatrix(int xScale, int yScale) => default; // 0x0000000188DA3D30-0x0000000188DA3F70
	}
}
