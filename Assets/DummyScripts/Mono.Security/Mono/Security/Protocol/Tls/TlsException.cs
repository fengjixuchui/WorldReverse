/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

// Image 1: Mono.Security.dll - Assembly: Mono.Security, Version=2.0.0.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756 - Types 1030-1183

namespace Mono.Security.Protocol.Tls
{
	[Serializable]
	internal sealed class TlsException : Exception // TypeDefIndex: 1141
	{
		// Fields
		private Alert alert; // 0x60
	
		// Properties
		public Alert Alert { get => default; } // 0x0000000186E2B340-0x0000000186E2B3A0 
	
		// Constructors
		public TlsException() {} // Dummy constructor
		internal TlsException(string message) {} // 0x0000000186E2B0E0-0x0000000186E2B160
		internal TlsException(SerializationInfo info, StreamingContext context) {} // 0x0000000186E2AFB0-0x0000000186E2B040
		internal TlsException(AlertLevel level, AlertDescription description) {} // 0x0000000186E2B210-0x0000000186E2B2B0
		internal TlsException(AlertLevel level, AlertDescription description, string message) {} // 0x0000000186E2B160-0x0000000186E2B210
		internal TlsException(AlertDescription description) {} // 0x0000000186E2B2B0-0x0000000186E2B340
		internal TlsException(AlertDescription description, string message) {} // 0x0000000186E2B040-0x0000000186E2B0E0
	}
}
