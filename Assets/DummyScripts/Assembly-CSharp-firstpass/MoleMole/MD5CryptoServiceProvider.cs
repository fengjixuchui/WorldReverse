/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
	// [ComVisible] // 0x00000001898DB8F0-0x00000001898DB910
	public sealed class MD5CryptoServiceProvider : MD5 // TypeDefIndex: 10598
	{
		// Fields
		private const int BLOCK_SIZE_BYTES = 64; // Metadata: 0x00AE7B9A
		private uint[] _H; // 0x28
		private uint[] buff; // 0x30
		private ulong count; // 0x38
		private byte[] _ProcessingBuffer; // 0x40
		private int _ProcessingBufferCount; // 0x48
		private byte[] hash; // 0x50
		private byte[] fooBuffer; // 0x58
		private static readonly uint[] K; // 0x00
	
		// Constructors
		public MD5CryptoServiceProvider() {} // 0x0000000186C21420-0x0000000186C21540
		static MD5CryptoServiceProvider() {} // 0x0000000186C21380-0x0000000186C21420
	
		// Methods
		~MD5CryptoServiceProvider() {} // 0x0000000186C1EAB0-0x0000000186C1EB60
		// [XID] // 0x000000018996E6C0-0x000000018996E6E0
		protected override void Dispose(bool disposing) {} // 0x0000000186C1E990-0x0000000186C1EAB0
		// [XID] // 0x00000001899948E0-0x0000000189994900
		protected override void HashCore(byte[] rgb, int ibStart, int cbSize) {} // 0x0000000186C1EB60-0x0000000186C1ED20
		// [XID] // 0x0000000189BAA240-0x0000000189BAA260
		protected override byte[] HashFinal() => default; // 0x0000000186C1ED20-0x0000000186C1EE90
		// [XID] // 0x0000000189BB19C0-0x0000000189BB19E0
		public override void Initialize() {} // 0x0000000186C1EE90-0x0000000186C1EFF0
		// [XID] // 0x00000001899A3A20-0x00000001899A3A40
		private void ProcessBlock(byte[] inputBuffer, int inputOffset) {} // 0x0000000186C1EFF0-0x0000000186C210B0
		// [XID] // 0x0000000189BC03C0-0x0000000189BC03E0
		private void ProcessFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) {} // 0x0000000186C210B0-0x0000000186C21300
		// [XID] // 0x0000000189BC7D80-0x0000000189BC7DA0
		internal void AddLength(ulong length, byte[] buffer, int position) {} // 0x0000000186C1E790-0x0000000186C1E990
	}
}
