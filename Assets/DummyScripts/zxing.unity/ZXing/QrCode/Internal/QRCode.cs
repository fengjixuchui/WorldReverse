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
	public sealed class QRCode // TypeDefIndex: 4643
	{
		// Fields
		public static int NUM_MASK_PATTERNS; // 0x00
	
		// Properties
		public Mode Mode { get; set; } // 0x0000000188DB66D0-0x0000000188DB6730 0x0000000188DB6950-0x0000000188DB69B0
		public ErrorCorrectionLevel ECLevel { get; set; } // 0x0000000188DB65B0-0x0000000188DB6610 0x0000000188DB6830-0x0000000188DB6890
		public Version Version { get; set; } // 0x0000000188DB6730-0x0000000188DB6790 0x0000000188DB69B0-0x0000000188DB6A10
		public int MaskPattern { get; set; } // 0x0000000188DB6610-0x0000000188DB6670 0x0000000188DB6890-0x0000000188DB68F0
		public ByteMatrix Matrix { get; set; } // 0x0000000188DB6670-0x0000000188DB66D0 0x0000000188DB68F0-0x0000000188DB6950
	
		// Constructors
		public QRCode() {} // 0x0000000188DB6510-0x0000000188DB65B0
		static QRCode() {} // 0x0000000188DB64B0-0x0000000188DB6510
	
		// Methods
		public override string ToString() => default; // 0x0000000188DB6150-0x0000000188DB64B0
		public static bool isValidMaskPattern(int maskPattern) => default; // 0x0000000188DB6790-0x0000000188DB6830
	}
}
