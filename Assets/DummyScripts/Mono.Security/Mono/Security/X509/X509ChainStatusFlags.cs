/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 1: Mono.Security.dll - Assembly: Mono.Security, Version=2.0.0.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756 - Types 1030-1183

namespace Mono.Security.X509
{
	[Serializable]
	[Flags] // 0x000000018990A800-0x000000018990A810
	public enum X509ChainStatusFlags // TypeDefIndex: 1069
	{
		NoError = 0,
		NotTimeValid = 1,
		NotTimeNested = 2,
		NotSignatureValid = 8,
		UntrustedRoot = 32,
		InvalidBasicConstraints = 1024,
		PartialChain = 65536
	}
}
