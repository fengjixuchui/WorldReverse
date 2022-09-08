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
	internal class HMAC : KeyedHashAlgorithm // TypeDefIndex: 1103
	{
		// Fields
		private HashAlgorithm hash; // 0x30
		private bool hashing; // 0x38
		private byte[] innerPad; // 0x40
		private byte[] outerPad; // 0x48
	
		// Properties
		public override byte[] Key { get => default; set {} } // 0x00000001873B7E40-0x00000001873B7F00 0x00000001873B8110-0x00000001873B8230
	
		// Constructors
		public HMAC() {} // Dummy constructor
		public HMAC(string hashName, byte[] rgbKey) {} // 0x00000001873B7CF0-0x00000001873B7E40
	
		// Methods
		public override void Initialize() {} // 0x00000001873B7C60-0x00000001873B7CF0
		protected override byte[] HashFinal() => default; // 0x00000001873B7A80-0x00000001873B7C60
		protected override void HashCore(byte[] array, int ibStart, int cbSize) {} // 0x00000001873B7980-0x00000001873B7A80
		private void initializePad() {} // 0x00000001873B7F00-0x00000001873B8110
	}
}
