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

namespace Mono.Security.Protocol.Tls.Handshake.Server
{
	internal class TlsServerKeyExchange : HandshakeMessage // TypeDefIndex: 1168
	{
		// Constructors
		public TlsServerKeyExchange() {} // Dummy constructor
		public TlsServerKeyExchange(Context context) {} // 0x0000000186E2CEF0-0x0000000186E2CF70
	
		// Methods
		public override void Update() {} // 0x0000000186E2CE80-0x0000000186E2CEF0
		protected override void ProcessAsSsl3() {} // 0x0000000186E2CA50-0x0000000186E2CAC0
		protected override void ProcessAsTls1() {} // 0x0000000186E2CAC0-0x0000000186E2CE80
		private byte[] createSignature(RSA rsa, byte[] buffer) => default; // 0x0000000186E2CF70-0x0000000186E2D0E0
	}
}
