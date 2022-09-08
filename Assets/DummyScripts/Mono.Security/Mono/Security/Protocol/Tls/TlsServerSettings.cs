/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using Mono.Security.Protocol.Tls.Handshake;
using Mono.Security.X509;

// Image 1: Mono.Security.dll - Assembly: Mono.Security, Version=2.0.0.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756 - Types 1030-1183

namespace Mono.Security.Protocol.Tls
{
	internal class TlsServerSettings // TypeDefIndex: 1142
	{
		// Fields
		private X509CertificateCollection certificates; // 0x10
		private RSA certificateRSA; // 0x18
		private RSAParameters rsaParameters; // 0x20
		private byte[] signedParams; // 0x60
		private string[] distinguisedNames; // 0x68
		private bool serverKeyExchange; // 0x70
		private bool certificateRequest; // 0x71
		private ClientCertificateType[] certificateTypes; // 0x78
	
		// Properties
		public bool ServerKeyExchange { get => default; set {} } // 0x0000000186E2D580-0x0000000186E2D5E0 0x0000000186E2D7E0-0x0000000186E2D840
		public X509CertificateCollection Certificates { get => default; set {} } // 0x0000000186E2D440-0x0000000186E2D4A0 0x0000000186E2D6A0-0x0000000186E2D700
		public RSA CertificateRSA { get => default; } // 0x0000000186E2D320-0x0000000186E2D380 
		public RSAParameters RsaParameters { get => default; set {} } // 0x0000000186E2D500-0x0000000186E2D580 0x0000000186E2D760-0x0000000186E2D7E0
		public byte[] SignedParams { set {} } // 0x0000000186E2D840-0x0000000186E2D8A0
		public bool CertificateRequest { get => default; set {} } // 0x0000000186E2D380-0x0000000186E2D3E0 0x0000000186E2D5E0-0x0000000186E2D640
		public ClientCertificateType[] CertificateTypes { get => default; set {} } // 0x0000000186E2D3E0-0x0000000186E2D440 0x0000000186E2D640-0x0000000186E2D6A0
		public string[] DistinguisedNames { get => default; set {} } // 0x0000000186E2D4A0-0x0000000186E2D500 0x0000000186E2D700-0x0000000186E2D760
	
		// Constructors
		public TlsServerSettings() {} // 0x0000000186E2D2C0-0x0000000186E2D320
	
		// Methods
		public void UpdateCertificateRSA() {} // 0x0000000186E2D0E0-0x0000000186E2D2C0
	}
}
