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
	internal class TlsClientHello : HandshakeMessage // TypeDefIndex: 1150
	{
		// Fields
		private byte[] random; // 0x40
	
		// Constructors
		public TlsClientHello() {} // Dummy constructor
		public TlsClientHello(Context context) {} // 0x00000001873C9CC0-0x00000001873C9D40
	
		// Methods
		public override void Update() {} // 0x00000001873C9AD0-0x00000001873C9CC0
		protected override void ProcessAsSsl3() {} // 0x00000001873C9200-0x00000001873C9270
		protected override void ProcessAsTls1() {} // 0x00000001873C9270-0x00000001873C9AD0
	}
}
