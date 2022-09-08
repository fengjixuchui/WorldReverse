/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.HID
{
	[CustomClassObfuscation] // 0x0000000189699A10-0x0000000189699A60
	[CustomObfuscation] // 0x0000000189699A10-0x0000000189699A60
	internal static class SpecialDevices // TypeDefIndex: 4053
	{
		// Fields
		private static YihhqmRUvNaaOMUsLbSJPzNOTya[] xMWfUfpqOFuHOFbzPEWMoXUvInx; // 0x00
	
		// Nested types
		private class YihhqmRUvNaaOMUsLbSJPzNOTya // TypeDefIndex: 4054
		{
			// Fields
			public readonly ushort NdbvKbBBJrSYqhcLkswavvMBjSd; // 0x10
			public readonly ushort dUFmmEnRQtqCUuTnapnLPxMpqTR; // 0x12
			public readonly string ElqFHgfeUUYnOxTfelQmyaxwbDRH; // 0x18
			public readonly bool WZLuWjtcITrbfbfffMpyrOMjGqYE; // 0x20
			public readonly int hAMpIKTsnADLjYzyTRfnHpNUfuv; // 0x24
			public readonly int aFfAoLGdYiGQyrSnDncKGWToFMEE; // 0x28
			public readonly int kejQupRfjceGIPNEdnJfeHCGwsv; // 0x2C
			public readonly float uDuhXPHeMvuOLpolrfQodKuKBJqI; // 0x30
	
			// Constructors
			public YihhqmRUvNaaOMUsLbSJPzNOTya() {} // Dummy constructor
			public YihhqmRUvNaaOMUsLbSJPzNOTya(ushort vendorId, ushort productId, string productName, bool hasRelativeAxes, int axisMin, int axisMax, int axisZero, float relToAbsAxisConversionTimeout) {} // 0x0000000185842E10-0x0000000185842F30
	
			// Methods
			public bool DmlNEhzmzUCVUnDgXReTiclcUGs(ushort param_000086d7, ushort param_000086d8) => default; // 0x0000000185842D90-0x0000000185842E10
			public bool DmlNEhzmzUCVUnDgXReTiclcUGs(ushort param_000086d9, ushort param_000086da, string param_000086db) => default; // 0x0000000185842C70-0x0000000185842D90
		}
	
		// Constructors
		static SpecialDevices() {} // 0x0000000185841490-0x00000001858417A0
	
		// Methods
		public static bool RequiresRelativeToAbsoluteAxisConversion(ushort vendorId, ushort productId, string productName = null) => default; // 0x00000001858413D0-0x0000000185841490
		public static float GetRelativeToAbsoluteAxisEventTimeout(ushort vendorId, ushort productId, string productName = null) => default; // 0x0000000185841300-0x00000001858413D0
		public static bool GetRelativeAxisRanges(ushort vendorId, ushort productId, string productName, out int min, out int max, out int zero) {
			min = default;
			max = default;
			zero = default;
			return default;
		} // 0x0000000185840F30-0x0000000185841300
		private static YihhqmRUvNaaOMUsLbSJPzNOTya BfyeHowHhyBGbCryYEFcdGRNbKSI(ushort param_000086cc, ushort param_000086cd, string param_000086ce = null) => default; // 0x0000000185840D40-0x0000000185840F30
	}
}
