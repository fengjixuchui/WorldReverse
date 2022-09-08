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

namespace Mono.Security.Protocol.Tls
{
	internal class SslHandshakeHash : HashAlgorithm // TypeDefIndex: 1135
	{
		// Fields
		private HashAlgorithm md5; // 0x28
		private HashAlgorithm sha; // 0x30
		private bool hashing; // 0x38
		private byte[] secret; // 0x40
		private byte[] innerPadMD5; // 0x48
		private byte[] outerPadMD5; // 0x50
		private byte[] innerPadSHA; // 0x58
		private byte[] outerPadSHA; // 0x60
	
		// Constructors
		public SslHandshakeHash() {} // Dummy constructor
		public SslHandshakeHash(byte[] secret) {} // 0x0000000186E22460-0x0000000186E22570
	
		// Methods
		public override void Initialize() {} // 0x0000000186E22240-0x0000000186E222F0
		protected override byte[] HashFinal() => default; // 0x0000000186E21E10-0x0000000186E22240
		protected override void HashCore(byte[] array, int ibStart, int cbSize) {} // 0x0000000186E21D30-0x0000000186E21E10
		public byte[] CreateSignature(RSA rsa) => default; // 0x0000000186E21C10-0x0000000186E21D30
		public bool VerifySignature(RSA rsa, byte[] rgbSignature) => default; // 0x0000000186E222F0-0x0000000186E22460
		private void initializePad() {} // 0x0000000186E22570-0x0000000186E22730
	}
}
