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
	internal class MD5SHA1 : HashAlgorithm // TypeDefIndex: 1104
	{
		// Fields
		private HashAlgorithm md5; // 0x28
		private HashAlgorithm sha; // 0x30
		private bool hashing; // 0x38
	
		// Constructors
		public MD5SHA1() {} // 0x00000001873BEE70-0x00000001873BEF40
	
		// Methods
		public override void Initialize() {} // 0x00000001873BEC60-0x00000001873BED00
		protected override byte[] HashFinal() => default; // 0x00000001873BEAB0-0x00000001873BEC60
		protected override void HashCore(byte[] array, int ibStart, int cbSize) {} // 0x00000001873BE9D0-0x00000001873BEAB0
		public byte[] CreateSignature(RSA rsa) => default; // 0x00000001873BE8B0-0x00000001873BE9D0
		public bool VerifySignature(RSA rsa, byte[] rgbSignature) => default; // 0x00000001873BED00-0x00000001873BEE70
	}
}
