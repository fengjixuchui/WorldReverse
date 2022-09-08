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
	internal class TlsServerHello : HandshakeMessage // TypeDefIndex: 1155
	{
		// Fields
		private SecurityCompressionType compressionMethod; // 0x40
		private byte[] random; // 0x48
		private byte[] sessionId; // 0x50
		private CipherSuite cipherSuite; // 0x58
	
		// Constructors
		public TlsServerHello() {} // Dummy constructor
		public TlsServerHello(Context context, byte[] buffer) {} // 0x00000001873CD9E0-0x00000001873CDAA0
	
		// Methods
		public override void Update() {} // 0x00000001873CD1D0-0x00000001873CD9E0
		protected override void ProcessAsSsl3() {} // 0x00000001873CCCB0-0x00000001873CCD20
		protected override void ProcessAsTls1() {} // 0x00000001873CCD20-0x00000001873CD1D0
		private void processProtocol(short protocol) {} // 0x00000001873CDAA0-0x00000001873CDEE0
	}
}
