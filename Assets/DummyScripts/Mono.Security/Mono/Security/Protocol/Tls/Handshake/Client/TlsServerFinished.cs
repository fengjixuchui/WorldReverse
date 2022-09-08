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
	internal class TlsServerFinished : HandshakeMessage // TypeDefIndex: 1154
	{
		// Fields
		private static byte[] Ssl3Marker; // 0x00
	
		// Constructors
		public TlsServerFinished() {} // Dummy constructor
		public TlsServerFinished(Context context, byte[] buffer) {} // 0x00000001873CCA90-0x00000001873CCB50
		static TlsServerFinished() {} // 0x00000001873CC9F0-0x00000001873CCA90
	
		// Methods
		public override void Update() {} // 0x00000001873CC900-0x00000001873CC9F0
		protected override void ProcessAsSsl3() {} // 0x00000001873CC2F0-0x00000001873CC610
		protected override void ProcessAsTls1() {} // 0x00000001873CC610-0x00000001873CC900
	}
}
