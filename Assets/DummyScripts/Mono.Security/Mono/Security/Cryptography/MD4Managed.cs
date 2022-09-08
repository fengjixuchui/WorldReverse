/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 1: Mono.Security.dll - Assembly: Mono.Security, Version=2.0.0.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756 - Types 1030-1183

namespace Mono.Security.Cryptography
{
	public class MD4Managed : MD4 // TypeDefIndex: 1053
	{
		// Fields
		private uint[] state; // 0x28
		private byte[] buffer; // 0x30
		private uint[] count; // 0x38
		private uint[] x; // 0x40
		private byte[] digest; // 0x48
	
		// Constructors
		public MD4Managed() {} // 0x00000001873BE560-0x00000001873BE6D0
	
		// Methods
		public override void Initialize() {} // 0x00000001873BD120-0x00000001873BD2D0
		protected override void HashCore(byte[] array, int ibStart, int cbSize) {} // 0x00000001873BCDA0-0x00000001873BCFC0
		protected override byte[] HashFinal() => default; // 0x00000001873BCFC0-0x00000001873BD120
		private byte[] Padding(int nLength) => default; // 0x00000001873BE430-0x00000001873BE4E0
		private uint F(uint x, uint y, uint z) => default; // 0x00000001873BCA00-0x00000001873BCA80
		private uint G(uint x, uint y, uint z) => default; // 0x00000001873BCB90-0x00000001873BCC10
		private uint H(uint x, uint y, uint z) => default; // 0x00000001873BCD30-0x00000001873BCDA0
		private uint ROL(uint x, byte n) => default; // 0x00000001873BE4E0-0x00000001873BE560
		private void FF(ref uint a, uint b, uint c, uint d, uint x, byte s) {} // 0x00000001873BC900-0x00000001873BCA00
		private void GG(ref uint a, uint b, uint c, uint d, uint x, byte s) {} // 0x00000001873BCA80-0x00000001873BCB90
		private void HH(ref uint a, uint b, uint c, uint d, uint x, byte s) {} // 0x00000001873BCC10-0x00000001873BCD30
		private void Encode(byte[] output, uint[] input) {} // 0x00000001873BC750-0x00000001873BC900
		private void Decode(uint[] output, byte[] input, int index) {} // 0x00000001873BC5E0-0x00000001873BC750
		private void MD4Transform(uint[] state, byte[] block, int index) {} // 0x00000001873BD2D0-0x00000001873BE430
	}
}
