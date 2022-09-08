/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 43: zxing.unity.dll - Assembly: zxing.unity, Version=0.15.0.0, Culture=neutral, PublicKeyToken=null - Types 4567-4702

namespace ZXing.Common
{
	public sealed class BitMatrix // TypeDefIndex: 4630
	{
		// Fields
		private readonly int width; // 0x10
		private readonly int height; // 0x14
		private readonly int rowSize; // 0x18
		private readonly int[] bits; // 0x20
	
		// Properties
		public int Width { get => default; } // 0x0000000186AE2B40-0x0000000186AE2BA0 
		public int Height { get => default; } // 0x0000000186AE2A20-0x0000000186AE2A80 
		public bool this[int x, int y] { get => default; set {} } // 0x0000000186AE2A80-0x0000000186AE2B40 0x0000000186AE2D70-0x0000000186AE2E80
	
		// Constructors
		public BitMatrix() {} // Dummy constructor
		public BitMatrix(int dimension) {} // 0x0000000186AE22F0-0x0000000186AE2370
		public BitMatrix(int width, int height) {} // 0x0000000186AE2200-0x0000000186AE22F0
	
		// Methods
		public void flip(int x, int y) {} // 0x0000000186AE2560-0x0000000186AE2620
		public void clear() {} // 0x0000000186AE24B0-0x0000000186AE2560
		public void setRegion(int left, int top, int width, int height) {} // 0x0000000186AE2BA0-0x0000000186AE2D70
		public BitArray getRow(int y, BitArray row) => default; // 0x0000000186AE2860-0x0000000186AE2A20
		public int[] getEnclosingRectangle() => default; // 0x0000000186AE2620-0x0000000186AE2860
		public override bool Equals(object obj) => default; // 0x0000000186AE1E80-0x0000000186AE2010
		public override int GetHashCode() => default; // 0x0000000186AE2010-0x0000000186AE20E0
		public override string ToString() => default; // 0x0000000186AE20E0-0x0000000186AE2170
		public string ToString(string setString, string unsetString, string lineSeparator) => default; // 0x0000000186AE2170-0x0000000186AE2200
		private string buildToString(string setString, string unsetString, string lineSeparator) => default; // 0x0000000186AE2370-0x0000000186AE24B0
	}
}
