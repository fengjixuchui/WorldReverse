/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 43: zxing.unity.dll - Assembly: zxing.unity, Version=0.15.0.0, Culture=neutral, PublicKeyToken=null - Types 4567-4702

namespace ZXing.OneD
{
	public abstract class UPCEANReader : OneDReader // TypeDefIndex: 4596
	{
		// Fields
		private static readonly int MAX_AVG_VARIANCE; // 0x00
		private static readonly int MAX_INDIVIDUAL_VARIANCE; // 0x04
		internal static int[] START_END_PATTERN; // 0x08
		internal static int[] MIDDLE_PATTERN; // 0x10
		internal static int[] END_PATTERN; // 0x18
		internal static int[][] L_PATTERNS; // 0x20
		internal static int[][] L_AND_G_PATTERNS; // 0x28
	
		// Constructors
		protected UPCEANReader() {} // Dummy constructor
		static UPCEANReader() {} // 0x0000000188DB6F20-0x0000000188DB7750
	
		// Methods
		internal static bool checkStandardUPCEANChecksum(string s) => default; // 0x0000000188DB7750-0x0000000188DB7870
		internal static int? getStandardUPCEANChecksum(string s) => default; // 0x0000000188DB7870-0x0000000188DB7AD0
	}
}
