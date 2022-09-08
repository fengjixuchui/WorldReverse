/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using Mono.Security.Cryptography;

// Image 1: Mono.Security.dll - Assembly: Mono.Security, Version=2.0.0.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756 - Types 1030-1183

namespace Mono.Security.Protocol.Tls
{
	internal sealed class TlsClientSettings // TypeDefIndex: 1140
	{
		// Fields
		private string targetHost; // 0x10
		private X509CertificateCollection certificates; // 0x18
		private X509Certificate clientCertificate; // 0x20
		private RSAManaged certificateRSA; // 0x28
	
		// Properties
		public string TargetHost { get => default; set {} } // 0x0000000186E2AE10-0x0000000186E2AE70 0x0000000186E2AF50-0x0000000186E2AFB0
		public X509CertificateCollection Certificates { get => default; set {} } // 0x0000000186E2AD50-0x0000000186E2ADB0 0x0000000186E2AE70-0x0000000186E2AED0
		public X509Certificate ClientCertificate { get => default; set {} } // 0x0000000186E2ADB0-0x0000000186E2AE10 0x0000000186E2AED0-0x0000000186E2AF50
		public RSAManaged CertificateRSA { get => default; } // 0x0000000186E2ACF0-0x0000000186E2AD50 
	
		// Constructors
		public TlsClientSettings() {} // 0x0000000186E2AC30-0x0000000186E2ACF0
	
		// Methods
		public void UpdateCertificateRSA() {} // 0x0000000186E2AA80-0x0000000186E2AC30
	}
}
