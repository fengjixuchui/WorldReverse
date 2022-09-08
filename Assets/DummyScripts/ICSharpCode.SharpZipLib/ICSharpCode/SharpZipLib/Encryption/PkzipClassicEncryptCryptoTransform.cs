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
	internal class PkzipClassicEncryptCryptoTransform : PkzipClassicCryptoBase, ICryptoTransform // TypeDefIndex: 6629
	{
		// Properties
		public bool CanReuseTransform { get => default; } // 0x0000000189481B90-0x0000000189481BE0 
		public int InputBlockSize { get => default; } // 0x0000000189481C30-0x0000000189481C80 
		public int OutputBlockSize { get => default; } // 0x0000000189481C80-0x0000000189481CD0 
		public bool CanTransformMultipleBlocks { get => default; } // 0x0000000189481BE0-0x0000000189481C30 
	
		// Constructors
		public PkzipClassicEncryptCryptoTransform() {} // Dummy constructor
		internal PkzipClassicEncryptCryptoTransform(byte[] keyBlock) {} // 0x0000000189481AD0-0x0000000189481B90
	
		// Methods
		public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) => default; // 0x0000000189481A10-0x0000000189481AD0
		public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) => default; // 0x0000000189481840-0x0000000189481A10
		public void Dispose() {} // 0x00000001894817E0-0x0000000189481840
	}
}
