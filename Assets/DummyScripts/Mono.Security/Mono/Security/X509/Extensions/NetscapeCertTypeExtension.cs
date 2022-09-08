/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Mono.Security.X509;

// Image 1: Mono.Security.dll - Assembly: Mono.Security, Version=2.0.0.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756 - Types 1030-1183

namespace Mono.Security.X509.Extensions
{
	public class NetscapeCertTypeExtension : X509Extension // TypeDefIndex: 1100
	{
		// Fields
		private int ctbits; // 0x28
	
		// Nested types
		[Flags] // 0x000000018990A800-0x000000018990A810
		public enum CertTypes // TypeDefIndex: 1101
		{
			ObjectSigningCA = 1,
			SmimeCA = 2,
			SslCA = 4,
			ObjectSigning = 16,
			Smime = 32,
			SslServer = 64,
			SslClient = 128
		}
	
		// Constructors
		public NetscapeCertTypeExtension() {} // Dummy constructor
		public NetscapeCertTypeExtension(X509Extension extension) {} // 0x0000000186E11550-0x0000000186E115D0
	
		// Methods
		protected override void Decode() {} // 0x0000000186E10FE0-0x0000000186E11130
		public bool Support(CertTypes usage) => default; // 0x0000000186E11130-0x0000000186E11210
		public override string ToString() => default; // 0x0000000186E11210-0x0000000186E11550
	}
}
