/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Mono.Security.Protocol.Tls;
using Mono.Security.Protocol.Tls.Handshake;
using Mono.Security.X509;

// Image 1: Mono.Security.dll - Assembly: Mono.Security, Version=2.0.0.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756 - Types 1030-1183

namespace Mono.Security.Protocol.Tls.Handshake.Client
{
	internal class TlsServerCertificate : HandshakeMessage // TypeDefIndex: 1152
	{
		// Fields
		private X509CertificateCollection certificates; // 0x40
	
		// Constructors
		public TlsServerCertificate() {} // Dummy constructor
		public TlsServerCertificate(Context context, byte[] buffer) {} // 0x00000001873CB0F0-0x00000001873CB1B0
	
		// Methods
		public override void Update() {} // 0x00000001873CAF40-0x00000001873CB0F0
		protected override void ProcessAsSsl3() {} // 0x00000001873CADC0-0x00000001873CAE30
		protected override void ProcessAsTls1() {} // 0x00000001873CAE30-0x00000001873CAF40
		private bool checkCertificateUsage(X509Certificate cert) => default; // 0x00000001873CB1B0-0x00000001873CB5A0
		private void validateCertificates(X509CertificateCollection certificates) {} // 0x00000001873CBB30-0x00000001873CC2F0
		private bool checkServerIdentity(X509Certificate cert) => default; // 0x00000001873CB850-0x00000001873CBB30
		private bool checkDomainName(string subjectName) => default; // 0x00000001873CB5A0-0x00000001873CB850
		private static bool Match(string hostname, string pattern) => default; // 0x00000001873CAA80-0x00000001873CADC0
	}
}
