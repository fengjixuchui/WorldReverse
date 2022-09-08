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
	internal class TlsServerKeyExchange : HandshakeMessage // TypeDefIndex: 1157
	{
		// Fields
		private RSAParameters rsaParams; // 0x40
		private byte[] signedParams; // 0x80
	
		// Constructors
		public TlsServerKeyExchange() {} // Dummy constructor
		public TlsServerKeyExchange(Context context, byte[] buffer) {} // 0x00000001873CE310-0x00000001873CE3D0
	
		// Methods
		public override void Update() {} // 0x00000001873CE060-0x00000001873CE310
		protected override void ProcessAsSsl3() {} // 0x00000001873CDEE0-0x00000001873CDF50
		protected override void ProcessAsTls1() {} // 0x00000001873CDF50-0x00000001873CE060
		private void verifySignature() {} // 0x00000001873CE3D0-0x00000001873CE900
	}
}
