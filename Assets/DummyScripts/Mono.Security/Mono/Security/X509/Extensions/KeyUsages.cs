/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 1: Mono.Security.dll - Assembly: Mono.Security, Version=2.0.0.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756 - Types 1030-1183

namespace Mono.Security.X509.Extensions
{
	[Flags] // 0x000000018990A800-0x000000018990A810
	public enum KeyUsages // TypeDefIndex: 1098
	{
		none = 0,
		encipherOnly = 1,
		cRLSign = 2,
		keyCertSign = 4,
		keyAgreement = 8,
		dataEncipherment = 16,
		keyEncipherment = 32,
		nonRepudiation = 64,
		digitalSignature = 128,
		decipherOnly = 2048
	}
}
