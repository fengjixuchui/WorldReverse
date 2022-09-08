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
	internal class TlsCipherSuite : CipherSuite // TypeDefIndex: 1139
	{
		// Fields
		private byte[] header; // 0x80
		private object headerLock; // 0x88
	
		// Constructors
		public TlsCipherSuite() {} // Dummy constructor
		public TlsCipherSuite(short code, string name, CipherAlgorithmType cipherAlgorithmType, HashAlgorithmType hashAlgorithmType, ExchangeAlgorithmType exchangeAlgorithmType, bool exportable, bool blockMode, byte keyMaterialSize, byte expandedKeyMaterialSize, short effectiveKeyBytes, byte ivSize, byte blockSize) {} // 0x0000000186E29270-0x0000000186E293C0
	
		// Methods
		public override byte[] ComputeServerRecordMAC(ContentType contentType, byte[] fragment) => default; // 0x0000000186E28F20-0x0000000186E29270
		public override byte[] ComputeClientRecordMAC(ContentType contentType, byte[] fragment) => default; // 0x0000000186E28270-0x0000000186E285C0
		public override void ComputeMasterSecret(byte[] preMasterSecret) {} // 0x0000000186E28DE0-0x0000000186E28F20
		public override void ComputeKeys() {} // 0x0000000186E285C0-0x0000000186E28DE0
	}
}
