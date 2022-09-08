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

// Image 1: Mono.Security.dll - Assembly: Mono.Security, Version=2.0.0.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756 - Types 1030-1183

namespace Mono.Security.Protocol.Tls.Handshake.Client
{
	internal class TlsServerCertificateRequest : HandshakeMessage // TypeDefIndex: 1153
	{
		// Fields
		private ClientCertificateType[] certificateTypes; // 0x40
		private string[] distinguisedNames; // 0x48
	
		// Constructors
		public TlsServerCertificateRequest() {} // Dummy constructor
		public TlsServerCertificateRequest(Context context, byte[] buffer) {} // 0x00000001873CA9C0-0x00000001873CAA80
	
		// Methods
		public override void Update() {} // 0x00000001873CA770-0x00000001873CA9C0
		protected override void ProcessAsSsl3() {} // 0x00000001873CA3C0-0x00000001873CA430
		protected override void ProcessAsTls1() {} // 0x00000001873CA430-0x00000001873CA770
	}
}
