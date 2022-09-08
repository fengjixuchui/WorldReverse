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
	public class MD2Managed : MD2 // TypeDefIndex: 1051
	{
		// Fields
		private byte[] state; // 0x28
		private byte[] checksum; // 0x30
		private byte[] buffer; // 0x38
		private int count; // 0x40
		private byte[] x; // 0x48
		private static readonly byte[] PI_SUBST; // 0x00
	
		// Constructors
		public MD2Managed() {} // 0x00000001873BC2B0-0x00000001873BC400
		static MD2Managed() {} // 0x00000001873BC210-0x00000001873BC2B0
	
		// Methods
		private byte[] Padding(int nLength) => default; // 0x00000001873BC140-0x00000001873BC210
		public override void Initialize() {} // 0x00000001873BBCF0-0x00000001873BBDC0
		protected override void HashCore(byte[] array, int ibStart, int cbSize) {} // 0x00000001873BBA80-0x00000001873BBBC0
		protected override byte[] HashFinal() => default; // 0x00000001873BBBC0-0x00000001873BBCF0
		private void MD2Transform(byte[] state, byte[] checksum, byte[] block, int index) {} // 0x00000001873BBDC0-0x00000001873BC140
	}
}
