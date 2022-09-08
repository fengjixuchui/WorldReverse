/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 1: Mono.Security.dll - Assembly: Mono.Security, Version=2.0.0.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756 - Types 1030-1183

namespace Mono.Security.Protocol.Tls.Handshake
{
	[Serializable]
	internal enum HandshakeType : byte // TypeDefIndex: 1146
	{
		HelloRequest = 0,
		ClientHello = 1,
		ServerHello = 2,
		Certificate = 11,
		ServerKeyExchange = 12,
		CertificateRequest = 13,
		ServerHelloDone = 14,
		CertificateVerify = 15,
		ClientKeyExchange = 16,
		Finished = 20,
		None = 255
	}
}
