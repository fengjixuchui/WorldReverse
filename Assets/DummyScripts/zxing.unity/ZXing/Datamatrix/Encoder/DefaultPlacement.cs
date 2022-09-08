/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 43: zxing.unity.dll - Assembly: zxing.unity, Version=0.15.0.0, Culture=neutral, PublicKeyToken=null - Types 4567-4702

namespace ZXing.Datamatrix.Encoder
{
	public class DefaultPlacement // TypeDefIndex: 4625
	{
		// Fields
		private readonly string codewords; // 0x10
		private readonly int numrows; // 0x18
		private readonly int numcols; // 0x1C
		private readonly byte[] bits; // 0x20
	
		// Constructors
		public DefaultPlacement() {} // Dummy constructor
		public DefaultPlacement(string codewords, int numcols, int numrows) {} // 0x0000000186AECF40-0x0000000186AED000
	
		// Methods
		public bool getBit(int col, int row) => default; // 0x0000000186AEE140-0x0000000186AEE1F0
		private void setBit(int col, int row, bool bit) {} // 0x0000000186AEE6E0-0x0000000186AEE7A0
		private bool hasBit(int col, int row) => default; // 0x0000000186AEE1F0-0x0000000186AEE2A0
		public void place() {} // 0x0000000186AEE3B0-0x0000000186AEE6E0
		private void module(int row, int col, int pos, int bit) {} // 0x0000000186AEE2A0-0x0000000186AEE3B0
		private void utah(int row, int col, int pos) {} // 0x0000000186AEE7A0-0x0000000186AEE930
		private void corner1(int pos) {} // 0x0000000186AED000-0x0000000186AED430
		private void corner2(int pos) {} // 0x0000000186AED430-0x0000000186AED860
		private void corner3(int pos) {} // 0x0000000186AED860-0x0000000186AEDC90
		private void corner4(int pos) {} // 0x0000000186AEDC90-0x0000000186AEE140
	}
}
