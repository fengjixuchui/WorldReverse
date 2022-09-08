/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using Mono.Security.Protocol.Tls;
using Mono.Security.Protocol.Tls.Handshake;

// Image 1: Mono.Security.dll - Assembly: Mono.Security, Version=2.0.0.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756 - Types 1030-1183

namespace Mono.Security.Protocol.Tls.Handshake.Client
{
	internal class TlsClientCertificateVerify : HandshakeMessage // TypeDefIndex: 1148
	{
		// Constructors
		public TlsClientCertificateVerify() {} // Dummy constructor
		public TlsClientCertificateVerify(Context context) {} // 0x00000001873C6860-0x00000001873C68E0
	
		// Methods
		public override void Update() {} // 0x00000001873C6730-0x00000001873C67A0
		protected override void ProcessAsSsl3() {} // 0x00000001873C5840-0x00000001873C5CE0
		protected override void ProcessAsTls1() {} // 0x00000001873C6000-0x00000001873C6460
		private RSA getClientCertRSA(RSA privKey) => default; // 0x00000001873C68E0-0x00000001873C6C70
		private byte[] getUnsignedBigInteger(byte[] integer) => default; // 0x00000001873C6C70-0x00000001873C6D50
	}
}
