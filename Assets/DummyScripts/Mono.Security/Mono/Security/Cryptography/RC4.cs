/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

// Image 1: Mono.Security.dll - Assembly: Mono.Security, Version=2.0.0.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756 - Types 1030-1183

namespace Mono.Security.Cryptography
{
	public abstract class RC4 : SymmetricAlgorithm // TypeDefIndex: 1058
	{
		// Fields
		private static KeySizes[] s_legalBlockSizes; // 0x00
		private static KeySizes[] s_legalKeySizes; // 0x08
	
		// Properties
		public override byte[] IV { get; set; } // 0x00000001873C3150-0x00000001873C31D0 0x00000001873C31D0-0x00000001873C3220
	
		// Constructors
		public RC4() {} // 0x00000001873C3090-0x00000001873C3150
		static RC4() {} // 0x00000001873C2ED0-0x00000001873C3090
	
		// Methods
		public static RC4 Create() => default; // 0x00000001873C2E40-0x00000001873C2ED0
		public static new RC4 Create(string algName) => default; // 0x00000001873C2D40-0x00000001873C2E40
	}
}
