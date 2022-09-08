/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ZXing.Common;

// Image 43: zxing.unity.dll - Assembly: zxing.unity, Version=0.15.0.0, Culture=neutral, PublicKeyToken=null - Types 4567-4702

namespace ZXing.Aztec.Internal
{
	public abstract class Token // TypeDefIndex: 4626
	{
		// Fields
		public static Token EMPTY; // 0x00
		private readonly Token previous; // 0x10
	
		// Properties
		public Token Previous { get; } // 0x0000000186B03470-0x0000000186B034D0 
	
		// Constructors
		protected Token() {} // Dummy constructor
		protected Token(Token previous) {} // 0x0000000186B032A0-0x0000000186B03310
		static Token() {} // 0x0000000186B03210-0x0000000186B032A0
	
		// Methods
		public Token add(int value, int bitCount) => default; // 0x0000000186B033C0-0x0000000186B03470
		public Token addBinaryShift(int start, int byteCount) => default; // 0x0000000186B03310-0x0000000186B033C0
		public abstract void appendTo(BitArray bitArray, byte[] text);
	}
}
