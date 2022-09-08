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
	internal class RSASslSignatureFormatter : AsymmetricSignatureFormatter // TypeDefIndex: 1126
	{
		// Fields
		private RSA key; // 0x10
		private HashAlgorithm hash; // 0x18
	
		// Constructors
		public RSASslSignatureFormatter() {} // Dummy constructor
		public RSASslSignatureFormatter(AsymmetricAlgorithm key) {} // 0x0000000186E18F60-0x0000000186E18FF0
	
		// Methods
		public override byte[] CreateSignature(byte[] rgbHash) => default; // 0x0000000186E18B80-0x0000000186E18CE0
		public override void SetHashAlgorithm(string strName) {} // 0x0000000186E18CE0-0x0000000186E18E40
		public override void SetKey(AsymmetricAlgorithm key) {} // 0x0000000186E18E40-0x0000000186E18F60
	}
}
