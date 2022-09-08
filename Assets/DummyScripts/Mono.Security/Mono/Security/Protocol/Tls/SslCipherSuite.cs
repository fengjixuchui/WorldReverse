/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 1: Mono.Security.dll - Assembly: Mono.Security, Version=2.0.0.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756 - Types 1030-1183

namespace Mono.Security.Protocol.Tls
{
	internal class SslCipherSuite : CipherSuite // TypeDefIndex: 1134
	{
		// Fields
		private byte[] pad1; // 0x80
		private byte[] pad2; // 0x88
		private byte[] header; // 0x90
	
		// Constructors
		public SslCipherSuite() {} // Dummy constructor
		public SslCipherSuite(short code, string name, CipherAlgorithmType cipherAlgorithmType, HashAlgorithmType hashAlgorithmType, ExchangeAlgorithmType exchangeAlgorithmType, bool exportable, bool blockMode, byte keyMaterialSize, byte expandedKeyMaterialSize, short effectiveKeyBytes, byte ivSize, byte blockSize) {} // 0x0000000186E1FB60-0x0000000186E1FD50
	
		// Methods
		public override byte[] ComputeServerRecordMAC(ContentType contentType, byte[] fragment) => default; // 0x0000000186E1F710-0x0000000186E1FB60
		public override byte[] ComputeClientRecordMAC(ContentType contentType, byte[] fragment) => default; // 0x0000000186E1E510-0x0000000186E1E960
		public override void ComputeMasterSecret(byte[] preMasterSecret) {} // 0x0000000186E1F560-0x0000000186E1F710
		public override void ComputeKeys() {} // 0x0000000186E1E960-0x0000000186E1F560
		private byte[] prf(byte[] secret, string label, byte[] random) => default; // 0x0000000186E1FD50-0x0000000186E1FF50
	}
}
