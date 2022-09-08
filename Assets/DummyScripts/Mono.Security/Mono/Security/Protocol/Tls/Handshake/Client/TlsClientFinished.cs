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
	internal class TlsClientFinished : HandshakeMessage // TypeDefIndex: 1149
	{
		// Fields
		private static byte[] Ssl3Marker; // 0x00
	
		// Constructors
		public TlsClientFinished() {} // Dummy constructor
		public TlsClientFinished(Context context) {} // 0x00000001873C9180-0x00000001873C9200
		static TlsClientFinished() {} // 0x00000001873C90E0-0x00000001873C9180
	
		// Methods
		public override void Update() {} // 0x00000001873C9070-0x00000001873C90E0
		protected override void ProcessAsSsl3() {} // 0x00000001873C8AE0-0x00000001873C8DA0
		protected override void ProcessAsTls1() {} // 0x00000001873C8DA0-0x00000001873C9070
	}
}
