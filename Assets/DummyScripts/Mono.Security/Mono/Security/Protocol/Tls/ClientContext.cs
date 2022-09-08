/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

// Image 1: Mono.Security.dll - Assembly: Mono.Security, Version=2.0.0.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756 - Types 1030-1183

namespace Mono.Security.Protocol.Tls
{
	internal class ClientContext : Context // TypeDefIndex: 1112
	{
		// Fields
		private SslClientStream sslStream; // 0xE0
		private short clientHelloProtocol; // 0xE8
	
		// Properties
		public SslClientStream SslStream { get => default; } // 0x00000001873B16E0-0x00000001873B1740 
		public short ClientHelloProtocol { get => default; set {} } // 0x00000001873B1680-0x00000001873B16E0 0x00000001873B1740-0x00000001873B17B0
	
		// Constructors
		public ClientContext() {} // Dummy constructor
		public ClientContext(SslClientStream stream, SecurityProtocolType securityProtocolType, string targetHost, X509CertificateCollection clientCertificates) {} // 0x00000001873B1550-0x00000001873B1680
	
		// Methods
		public override void Clear() {} // 0x00000001873B14E0-0x00000001873B1550
	}
}
