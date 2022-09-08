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
	internal class TlsServerFinished : HandshakeMessage // TypeDefIndex: 1165
	{
		// Fields
		private static byte[] Ssl3Marker; // 0x00
	
		// Constructors
		public TlsServerFinished() {} // Dummy constructor
		public TlsServerFinished(Context context) {} // 0x0000000186E2C300-0x0000000186E2C380
		static TlsServerFinished() {} // 0x0000000186E2C260-0x0000000186E2C300
	
		// Methods
		protected override void ProcessAsSsl3() {} // 0x0000000186E2BEA0-0x0000000186E2C090
		protected override void ProcessAsTls1() {} // 0x0000000186E2C090-0x0000000186E2C260
	}
}
