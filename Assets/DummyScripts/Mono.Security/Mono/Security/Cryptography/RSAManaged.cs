/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using Mono.Math;

// Image 1: Mono.Security.dll - Assembly: Mono.Security, Version=2.0.0.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756 - Types 1030-1183

namespace Mono.Security.Cryptography
{
	public class RSAManaged : RSA // TypeDefIndex: 1059
	{
		// Fields
		private bool isCRTpossible; // 0x20
		private bool keyBlinding; // 0x21
		private bool keypairGenerated; // 0x22
		private bool m_disposed; // 0x23
		private BigInteger d; // 0x28
		private BigInteger p; // 0x30
		private BigInteger q; // 0x38
		private BigInteger dp; // 0x40
		private BigInteger dq; // 0x48
		private BigInteger qInv; // 0x50
		private BigInteger n; // 0x58
		private BigInteger e; // 0x60
		private KeyGeneratedEventHandler KeyGenerated; // 0x68
	
		// Properties
		public override int KeySize { get => default; } // 0x00000001873C5150-0x00000001873C51F0 
		public bool PublicOnly { get => default; } // 0x00000001873C51F0-0x00000001873C52E0 
	
		// Nested types
		public delegate void KeyGeneratedEventHandler(object sender, EventArgs e); // TypeDefIndex: 1060; 0x00000001873BB6F0-0x00000001873BB9A0
	
		// Constructors
		public RSAManaged() {} // 0x00000001873C4FB0-0x00000001873C5020
		public RSAManaged(int keySize) {} // 0x00000001873C5020-0x00000001873C5150
	
		// Methods
		~RSAManaged() {} // 0x00000001873C3EF0-0x00000001873C3FA0
		private void GenerateKeyPair() {} // 0x00000001873C3FA0-0x00000001873C4330
		public override byte[] DecryptValue(byte[] rgb) => default; // 0x00000001873C3220-0x00000001873C3640
		public override byte[] EncryptValue(byte[] rgb) => default; // 0x00000001873C3950-0x00000001873C3AA0
		public override RSAParameters ExportParameters(bool includePrivateParameters) => default; // 0x00000001873C3AA0-0x00000001873C3EF0
		public override void ImportParameters(RSAParameters parameters) {} // 0x00000001873C4430-0x00000001873C4AC0
		protected override void Dispose(bool disposing) {} // 0x00000001873C3640-0x00000001873C3950
		public override string ToXmlString(bool includePrivateParameters) => default; // 0x00000001873C4AC0-0x00000001873C4FB0
		private byte[] GetPaddedValue(BigInteger value, int length) => default; // 0x00000001873C4330-0x00000001873C4430
	}
}
