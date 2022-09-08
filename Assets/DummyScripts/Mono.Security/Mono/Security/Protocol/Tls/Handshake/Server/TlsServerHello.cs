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

namespace Mono.Security.Protocol.Tls.Handshake.Server
{
	internal class TlsServerHello : HandshakeMessage // TypeDefIndex: 1166
	{
		// Fields
		private int unixTime; // 0x40
		private byte[] random; // 0x48
	
		// Constructors
		public TlsServerHello() {} // Dummy constructor
		public TlsServerHello(Context context) {} // 0x0000000186E2C9D0-0x0000000186E2CA50
	
		// Methods
		public override void Update() {} // 0x0000000186E2C790-0x0000000186E2C9D0
		protected override void ProcessAsSsl3() {} // 0x0000000186E2C4A0-0x0000000186E2C510
		protected override void ProcessAsTls1() {} // 0x0000000186E2C510-0x0000000186E2C790
	}
}
