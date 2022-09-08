/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace xxHashSharp
{
	public class xxHash // TypeDefIndex: 10656
	{
		// Fields
		private const uint PRIME32_1 = 2654435761; // Metadata: 0x00AE8044
		private const uint PRIME32_2 = 2246822519; // Metadata: 0x00AE8048
		private const uint PRIME32_3 = 3266489917; // Metadata: 0x00AE804C
		private const uint PRIME32_4 = 668265263; // Metadata: 0x00AE8050
		private const uint PRIME32_5 = 374761393; // Metadata: 0x00AE8054
		protected XXH_State _state; // 0x10
	
		// Nested types
		public struct XXH_State // TypeDefIndex: 10657
		{
			// Fields
			public ulong total_len; // 0x00
			public uint seed; // 0x08
			public uint v1; // 0x0C
			public uint v2; // 0x10
			public uint v3; // 0x14
			public uint v4; // 0x18
			public int memsize; // 0x1C
			public byte[] memory; // 0x20
		}
	
		// Constructors
		public xxHash() {} // 0x00000001894977C0-0x0000000189497930
	
		// Methods
		// [XID] // 0x00000001897C0F30-0x00000001897C0F50
		public static uint CalculateHash(byte[] buf, int len = -1 /* Metadata: 0x00AE8038 */, uint seed = 0 /* Metadata: 0x00AE803C */) => default; // 0x0000000189496E90-0x0000000189497160
		// [XID] // 0x00000001897C88D0-0x00000001897C88F0
		public void Init(uint seed = 0 /* Metadata: 0x00AE8040 */) {} // 0x0000000189497370-0x0000000189497460
		// [XID] // 0x000000018985EB50-0x000000018985EB70
		public bool Update(byte[] input, int len) => default; // 0x0000000189497530-0x00000001894977C0
		// [XID] // 0x00000001897D76B0-0x00000001897D76D0
		public uint Digest() => default; // 0x0000000189497160-0x0000000189497370
		// [XID] // 0x00000001897DEC00-0x00000001897DEC20
		private static uint CalcSubHash(uint value, byte[] buf, int index) => default; // 0x0000000189496D80-0x0000000189496E90
		// [XID] // 0x00000001897E66B0-0x00000001897E66D0
		private static uint RotateLeft(uint value, int count) => default; // 0x0000000189497460-0x0000000189497530
	}
}
