/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 1: Mono.Security.dll - Assembly: Mono.Security, Version=2.0.0.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756 - Types 1030-1183

namespace Mono.Security.Protocol.Tls
{
	internal class SecurityParameters // TypeDefIndex: 1128
	{
		// Fields
		private CipherSuite cipher; // 0x10
		private byte[] clientWriteMAC; // 0x18
		private byte[] serverWriteMAC; // 0x20
	
		// Properties
		public CipherSuite Cipher { get => default; set {} } // 0x0000000186E1CD10-0x0000000186E1CD70 0x0000000186E1CE30-0x0000000186E1CE90
		public byte[] ClientWriteMAC { get => default; set {} } // 0x0000000186E1CD70-0x0000000186E1CDD0 0x0000000186E1CE90-0x0000000186E1CEF0
		public byte[] ServerWriteMAC { get => default; set {} } // 0x0000000186E1CDD0-0x0000000186E1CE30 0x0000000186E1CEF0-0x0000000186E1CF50
	
		// Constructors
		public SecurityParameters() {} // 0x0000000186E1CCB0-0x0000000186E1CD10
	
		// Methods
		public void Clear() {} // 0x0000000186E1CC50-0x0000000186E1CCB0
	}
}
