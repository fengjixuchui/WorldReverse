/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using ZXing.Common;
using ZXing.Rendering;

// Image 43: zxing.unity.dll - Assembly: zxing.unity, Version=0.15.0.0, Culture=neutral, PublicKeyToken=null - Types 4567-4702

namespace ZXing
{
	public class Color32Renderer : IBarcodeRenderer<Color32[]> // TypeDefIndex: 4619
	{
		// Properties
		// [CLSCompliant] // 0x0000000189B18AF0-0x0000000189B18B10
		public Color32 Foreground { get; set; } // 0x0000000186AEBFF0-0x0000000186AEC050 0x0000000186AEC0B0-0x0000000186AEC110
		// [CLSCompliant] // 0x0000000189B18AF0-0x0000000189B18B10
		public Color32 Background { get; set; } // 0x0000000186AEBF90-0x0000000186AEBFF0 0x0000000186AEC050-0x0000000186AEC0B0
	
		// Constructors
		public Color32Renderer() {} // 0x0000000186AEBE60-0x0000000186AEBF90
	
		// Methods
		// [CLSCompliant] // 0x0000000189B18AF0-0x0000000189B18B10
		public Color32[] Render(BitMatrix matrix, BarcodeFormat format, string content, EncodingOptions options) => default; // 0x0000000186AEBA70-0x0000000186AEBE60
	}
}
