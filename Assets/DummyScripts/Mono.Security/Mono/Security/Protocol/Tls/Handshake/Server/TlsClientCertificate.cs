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

namespace Mono.Security.Protocol.Tls.Handshake.Server
{
	internal class TlsClientCertificate : HandshakeMessage // TypeDefIndex: 1158
	{
		// Fields
		private X509CertificateCollection clientCertificates; // 0x40
	
		// Constructors
		public TlsClientCertificate() {} // Dummy constructor
		public TlsClientCertificate(Context context, byte[] buffer) {} // 0x00000001873C7E60-0x00000001873C7F20
	
		// Methods
		public override void Update() {} // 0x00000001873C7B50-0x00000001873C7DE0
		protected override void ProcessAsSsl3() {} // 0x00000001873C7500-0x00000001873C7570
		protected override void ProcessAsTls1() {} // 0x00000001873C7710-0x00000001873C7950
		private bool checkCertificateUsage(X509Certificate cert) => default; // 0x00000001873C7F20-0x00000001873C82B0
		private void validateCertificates(X509CertificateCollection certificates) {} // 0x00000001873C8320-0x00000001873C8AE0
	}
}
