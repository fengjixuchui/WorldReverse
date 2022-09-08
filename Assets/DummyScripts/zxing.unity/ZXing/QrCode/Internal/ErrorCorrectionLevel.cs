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
	public sealed class ErrorCorrectionLevel // TypeDefIndex: 4636
	{
		// Fields
		public static readonly ErrorCorrectionLevel L; // 0x00
		public static readonly ErrorCorrectionLevel M; // 0x08
		public static readonly ErrorCorrectionLevel Q; // 0x10
		public static readonly ErrorCorrectionLevel H; // 0x18
		private static readonly ErrorCorrectionLevel[] FOR_BITS; // 0x20
		private readonly int bits; // 0x10
		private readonly int ordinal_Renamed_Field; // 0x14
		private readonly string name; // 0x18
	
		// Properties
		public int Bits { get => default; } // 0x0000000188DA88B0-0x0000000188DA8910 
	
		// Constructors
		public ErrorCorrectionLevel() {} // Dummy constructor
		private ErrorCorrectionLevel(int ordinal, int bits, string name) {} // 0x0000000188DA8830-0x0000000188DA88B0
		static ErrorCorrectionLevel() {} // 0x0000000188DA8440-0x0000000188DA8830
	
		// Methods
		public int ordinal() => default; // 0x0000000188DA8910-0x0000000188DA8970
		public override string ToString() => default; // 0x0000000188DA83E0-0x0000000188DA8440
	}
}
