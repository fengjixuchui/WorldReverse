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
	internal class ServerRecordProtocol : RecordProtocol // TypeDefIndex: 1131
	{
		// Constructors
		public ServerRecordProtocol() {} // Dummy constructor
		public ServerRecordProtocol(Stream innerStream, ServerContext context) {} // 0x0000000186E1DEE0-0x0000000186E1DF80
	
		// Methods
		public override HandshakeMessage GetMessage(HandshakeType type) => default; // 0x0000000186E1DB50-0x0000000186E1DBD0
		protected override void ProcessHandshakeMessage(TlsStream handMsg) {} // 0x0000000186E1DBD0-0x0000000186E1DEE0
		private HandshakeMessage createClientHandshakeMessage(HandshakeType type, byte[] buffer) => default; // 0x0000000186E1DF80-0x0000000186E1E270
		private HandshakeMessage createServerHandshakeMessage(HandshakeType type) => default; // 0x0000000186E1E270-0x0000000186E1E510
	}
}
