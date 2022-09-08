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
	internal class TlsClientHello : HandshakeMessage // TypeDefIndex: 1161
	{
		// Fields
		private byte[] random; // 0x40
		private byte[] sessionId; // 0x48
		private short[] cipherSuites; // 0x50
		private byte[] compressionMethods; // 0x58
	
		// Constructors
		public TlsClientHello() {} // Dummy constructor
		public TlsClientHello(Context context, byte[] buffer) {} // 0x0000000186E29C70-0x0000000186E29D00
	
		// Methods
		public override void Update() {} // 0x0000000186E29B90-0x0000000186E29C70
		protected override void ProcessAsSsl3() {} // 0x0000000186E29880-0x0000000186E298F0
		protected override void ProcessAsTls1() {} // 0x0000000186E298F0-0x0000000186E29B90
		private void processProtocol(short protocol) {} // 0x0000000186E29D00-0x0000000186E29ED0
		private void selectCipherSuite() {} // 0x0000000186E29ED0-0x0000000186E2A100
		private void selectCompressionMethod() {} // 0x0000000186E2A100-0x0000000186E2A180
	}
}
