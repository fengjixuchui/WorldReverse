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
	internal class ServerContext : Context // TypeDefIndex: 1130
	{
		// Fields
		private SslServerStream sslStream; // 0xE0
		private bool request_client_certificate; // 0xE8
		private bool clientCertificateRequired; // 0xE9
	
		// Properties
		public SslServerStream SslStream { get => default; } // 0x0000000186E1DAF0-0x0000000186E1DB50 
		public bool ClientCertificateRequired { get => default; } // 0x0000000186E1DA30-0x0000000186E1DA90 
		public bool RequestClientCertificate { get => default; } // 0x0000000186E1DA90-0x0000000186E1DAF0 
	
		// Constructors
		public ServerContext() {} // Dummy constructor
		public ServerContext(SslServerStream stream, SecurityProtocolType securityProtocolType, X509Certificate serverCertificate, bool clientCertificateRequired, bool requestClientCertificate) {} // 0x0000000186E1D4E0-0x0000000186E1DA30
	}
}
