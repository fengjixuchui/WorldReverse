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
	internal class ZipAESTransform : ICryptoTransform // TypeDefIndex: 6633
	{
		// Fields
		private int _blockSize; // 0x10
		private ICryptoTransform _encryptor; // 0x18
		private readonly byte[] _counterNonce; // 0x20
		private byte[] _encryptBuffer; // 0x28
		private int _encrPos; // 0x30
		private byte[] _pwdVerifier; // 0x38
		private HMACSHA1 _hmacsha1; // 0x40
		private bool _finalised; // 0x48
		private bool _writeMode; // 0x49
	
		// Properties
		public byte[] PwdVerifier { get => default; } // 0x0000000189483E40-0x0000000189483EA0 
		public int InputBlockSize { get => default; } // 0x0000000189483D80-0x0000000189483DE0 
		public int OutputBlockSize { get => default; } // 0x0000000189483DE0-0x0000000189483E40 
		public bool CanTransformMultipleBlocks { get => default; } // 0x0000000189483D30-0x0000000189483D80 
		public bool CanReuseTransform { get => default; } // 0x0000000189483CE0-0x0000000189483D30 
	
		// Constructors
		public ZipAESTransform() {} // Dummy constructor
		public ZipAESTransform(string key, byte[] saltBytes, int blockSize, bool writeMode) {} // 0x0000000189483840-0x0000000189483CE0
	
		// Methods
		public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) => default; // 0x0000000189483550-0x00000001894837C0
		public byte[] GetAuthCode() => default; // 0x0000000189483470-0x0000000189483550
		public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) => default; // 0x00000001894837C0-0x0000000189483840
		public void Dispose() {} // 0x00000001894833F0-0x0000000189483470
	}
}
