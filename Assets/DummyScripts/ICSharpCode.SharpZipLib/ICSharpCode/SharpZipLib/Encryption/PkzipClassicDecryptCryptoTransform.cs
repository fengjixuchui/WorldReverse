/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;

// Image 54: ICSharpCode.SharpZipLib.dll - Assembly: ICSharpCode.SharpZipLib, Version=0.86.0.518, Culture=neutral, PublicKeyToken=1b03e6acf1164f73 - Types 6620-6667

namespace ICSharpCode.SharpZipLib.Encryption
{
	internal class PkzipClassicDecryptCryptoTransform : PkzipClassicCryptoBase, ICryptoTransform // TypeDefIndex: 6630
	{
		// Properties
		public bool CanReuseTransform { get => default; } // 0x00000001894816A0-0x00000001894816F0 
		public int InputBlockSize { get => default; } // 0x0000000189481740-0x0000000189481790 
		public int OutputBlockSize { get => default; } // 0x0000000189481790-0x00000001894817E0 
		public bool CanTransformMultipleBlocks { get => default; } // 0x00000001894816F0-0x0000000189481740 
	
		// Constructors
		public PkzipClassicDecryptCryptoTransform() {} // Dummy constructor
		internal PkzipClassicDecryptCryptoTransform(byte[] keyBlock) {} // 0x00000001894815E0-0x00000001894816A0
	
		// Methods
		public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) => default; // 0x0000000189481520-0x00000001894815E0
		public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) => default; // 0x0000000189481360-0x0000000189481520
		public void Dispose() {} // 0x0000000189481300-0x0000000189481360
	}
}
