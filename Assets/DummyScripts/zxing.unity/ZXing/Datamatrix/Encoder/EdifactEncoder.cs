/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

// Image 43: zxing.unity.dll - Assembly: zxing.unity, Version=0.15.0.0, Culture=neutral, PublicKeyToken=null - Types 4567-4702

namespace ZXing.Datamatrix.Encoder
{
	internal sealed class EdifactEncoder : Encoder // TypeDefIndex: 4624
	{
		// Properties
		public int EncodingMode { get => default; } // 0x0000000186AF06A0-0x0000000186AF06F0 
	
		// Constructors
		public EdifactEncoder() {} // 0x0000000186AF0110-0x0000000186AF0170
	
		// Methods
		public void encode(EncoderContext context) {} // 0x0000000186AF0420-0x0000000186AF06A0
		private static void handleEOD(EncoderContext context, StringBuilder buffer) {} // 0x0000000186AF06F0-0x0000000186AF0A00
		private static void encodeChar(char c, StringBuilder sb) {} // 0x0000000186AF0170-0x0000000186AF0230
		private static string encodeToCodewords(StringBuilder sb, int startPos) => default; // 0x0000000186AF0230-0x0000000186AF0420
	}
}
