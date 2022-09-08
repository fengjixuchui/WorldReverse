/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

// Image 1: Mono.Security.dll - Assembly: Mono.Security, Version=2.0.0.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756 - Types 1030-1183

namespace Mono.Security.Protocol.Tls
{
	internal class RSASslSignatureDeformatter : AsymmetricSignatureDeformatter // TypeDefIndex: 1125
	{
		// Fields
		private RSA key; // 0x10
		private HashAlgorithm hash; // 0x18
	
		// Constructors
		public RSASslSignatureDeformatter() {} // Dummy constructor
		public RSASslSignatureDeformatter(AsymmetricAlgorithm key) {} // 0x0000000186E18AF0-0x0000000186E18B80
	
		// Methods
		public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature) => default; // 0x0000000186E18970-0x0000000186E18AF0
		public override void SetHashAlgorithm(string strName) {} // 0x0000000186E186F0-0x0000000186E18850
		public override void SetKey(AsymmetricAlgorithm key) {} // 0x0000000186E18850-0x0000000186E18970
	}
}
