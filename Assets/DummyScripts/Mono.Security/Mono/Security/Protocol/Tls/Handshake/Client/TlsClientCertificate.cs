/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using Mono.Security.Protocol.Tls;
using Mono.Security.Protocol.Tls.Handshake;

// Image 1: Mono.Security.dll - Assembly: Mono.Security, Version=2.0.0.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756 - Types 1030-1183

namespace Mono.Security.Protocol.Tls.Handshake.Client
{
	internal class TlsClientCertificate : HandshakeMessage // TypeDefIndex: 1147
	{
		// Fields
		private bool clientCertSelected; // 0x40
		private X509Certificate clientCert; // 0x48
	
		// Properties
		public X509Certificate ClientCertificate { get => default; } // 0x00000001873C82B0-0x00000001873C8320 
	
		// Constructors
		public TlsClientCertificate() {} // Dummy constructor
		public TlsClientCertificate(Context context) {} // 0x00000001873C7DE0-0x00000001873C7E60
	
		// Methods
		public override void Update() {} // 0x00000001873C7AE0-0x00000001873C7B50
		private void GetClientCertificate() {} // 0x00000001873C7040-0x00000001873C7500
		private void SendCertificates() {} // 0x00000001873C7950-0x00000001873C7AE0
		protected override void ProcessAsSsl3() {} // 0x00000001873C7570-0x00000001873C7640
		protected override void ProcessAsTls1() {} // 0x00000001873C7640-0x00000001873C7710
		private X509Certificate FindParentCertificate(X509Certificate cert) => default; // 0x00000001873C6D50-0x00000001873C7040
	}
}
