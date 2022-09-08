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
	public sealed class Mode // TypeDefIndex: 4649
	{
		// Fields
		public static readonly Mode TERMINATOR; // 0x00
		public static readonly Mode NUMERIC; // 0x08
		public static readonly Mode ALPHANUMERIC; // 0x10
		public static readonly Mode STRUCTURED_APPEND; // 0x18
		public static readonly Mode BYTE; // 0x20
		public static readonly Mode ECI; // 0x28
		public static readonly Mode KANJI; // 0x30
		public static readonly Mode FNC1_FIRST_POSITION; // 0x38
		public static readonly Mode FNC1_SECOND_POSITION; // 0x40
		public static readonly Mode HANZI; // 0x48
		private readonly int[] characterCountBitsForVersions; // 0x10
		private readonly int bits; // 0x18
		private readonly string name; // 0x20
	
		// Properties
		public int Bits { get => default; } // 0x0000000188DAE840-0x0000000188DAE8A0 
	
		// Constructors
		public Mode() {} // Dummy constructor
		private Mode(int[] characterCountBitsForVersions, int bits, string name) {} // 0x0000000188DAE690-0x0000000188DAE720
		static Mode() {} // 0x0000000188DAE010-0x0000000188DAE690
	
		// Methods
		public int getCharacterCountBits(Version version) => default; // 0x0000000188DAE720-0x0000000188DAE840
		public override string ToString() => default; // 0x0000000188DADFB0-0x0000000188DAE010
	}
}
