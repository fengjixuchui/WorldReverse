/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Mono.Security.Protocol.Tls.Handshake;

// Image 1: Mono.Security.dll - Assembly: Mono.Security, Version=2.0.0.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756 - Types 1030-1183

namespace Mono.Security.Protocol.Tls
{
	internal class ClientRecordProtocol : RecordProtocol // TypeDefIndex: 1113
	{
		// Constructors
		public ClientRecordProtocol() {} // Dummy constructor
		public ClientRecordProtocol(Stream innerStream, ClientContext context) {} // 0x00000001873B1B50-0x00000001873B1BF0
	
		// Methods
		public override HandshakeMessage GetMessage(HandshakeType type) => default; // 0x00000001873B17B0-0x00000001873B1830
		protected override void ProcessHandshakeMessage(TlsStream handMsg) {} // 0x00000001873B1830-0x00000001873B1B50
		private HandshakeMessage createClientHandshakeMessage(HandshakeType type) => default; // 0x00000001873B1BF0-0x00000001873B1E10
		private HandshakeMessage createServerHandshakeMessage(HandshakeType type, byte[] buffer) => default; // 0x00000001873B1E10-0x00000001873B2210
	}
}
