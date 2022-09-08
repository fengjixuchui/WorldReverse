/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

// Image 1: Mono.Security.dll - Assembly: Mono.Security, Version=2.0.0.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756 - Types 1030-1183

namespace Mono.Security.Cryptography
{
	public class ARC4Managed : RC4, ICryptoTransform // TypeDefIndex: 1047
	{
		// Fields
		private byte[] key; // 0x50
		private byte[] state; // 0x58
		private byte x; // 0x60
		private byte y; // 0x61
		private bool m_disposed; // 0x62
	
		// Properties
		public override byte[] Key { get => default; set {} } // 0x00000001873A69E0-0x00000001873A6AA0 0x00000001873A6AF0-0x00000001873A6BC0
		public bool CanReuseTransform { get => default; } // 0x00000001873A68F0-0x00000001873A6940 
		public bool CanTransformMultipleBlocks { get => default; } // 0x00000001873A6940-0x00000001873A6990 
		public int InputBlockSize { get => default; } // 0x00000001873A6990-0x00000001873A69E0 
		public int OutputBlockSize { get => default; } // 0x00000001873A6AA0-0x00000001873A6AF0 
	
		// Constructors
		public ARC4Managed() {} // 0x00000001873A6840-0x00000001873A68F0
	
		// Methods
		~ARC4Managed() {} // 0x00000001873A5F10-0x00000001873A5FC0
		protected override void Dispose(bool disposing) {} // 0x00000001873A5E40-0x00000001873A5F10
		public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgvIV) => default; // 0x00000001873A5DC0-0x00000001873A5E40
		public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgvIV) => default; // 0x00000001873A5D20-0x00000001873A5DC0
		public override void GenerateIV() {} // 0x00000001873A5FC0-0x00000001873A6050
		public override void GenerateKey() {} // 0x00000001873A6050-0x00000001873A60D0
		private void KeySetup(byte[] key) {} // 0x00000001873A6390-0x00000001873A6590
		private void CheckInput(byte[] inputBuffer, int inputOffset, int inputCount) {} // 0x00000001873A5BA0-0x00000001873A5D20
		public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) => default; // 0x00000001873A6590-0x00000001873A6760
		private int InternalTransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) => default; // 0x00000001873A60D0-0x00000001873A6390
		public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) => default; // 0x00000001873A6760-0x00000001873A6840
	}
}
