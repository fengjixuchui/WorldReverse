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
	internal class C40Encoder : Encoder // TypeDefIndex: 4628
	{
		// Properties
		public virtual int EncodingMode { get => default; } // 0x0000000186AE38D0-0x0000000186AE3920 
	
		// Constructors
		public C40Encoder() {} // 0x0000000186AE2E80-0x0000000186AE2EE0
	
		// Methods
		public virtual void encode(EncoderContext context) {} // 0x0000000186AE3500-0x0000000186AE38D0
		private int backtrackOneCharacter(EncoderContext context, StringBuilder buffer, StringBuilder removed, int lastCharSize) => default; // 0x0000000186AE2EE0-0x0000000186AE3080
		internal static void writeNextTriplet(EncoderContext context, StringBuilder buffer) {} // 0x0000000186AE3D80-0x0000000186AE3E30
		protected virtual void handleEOD(EncoderContext context, StringBuilder buffer) {} // 0x0000000186AE3920-0x0000000186AE3D80
		protected virtual int encodeChar(char c, StringBuilder sb) => default; // 0x0000000186AE3080-0x0000000186AE33B0
		private static string encodeToCodewords(StringBuilder sb, int startPos) => default; // 0x0000000186AE33B0-0x0000000186AE3500
	}
}
