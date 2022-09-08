/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace FlyingWormConsole3.LiteNetLib.Utils
{
	public static class FastBitConverter // TypeDefIndex: 6880
	{
		// Nested types
		private struct ConverterHelperDouble // TypeDefIndex: 6881
		{
			// Fields
			public ulong Along; // 0x00
			public double Adouble; // 0x00
		}
	
		private struct ConverterHelperFloat // TypeDefIndex: 6882
		{
			// Fields
			public int Aint; // 0x00
			public float Afloat; // 0x00
		}
	
		// Methods
		// [IDTag] // 0x0000000189B46DC0-0x0000000189B46E00
		// [XID] // 0x0000000189B46DC0-0x0000000189B46E00
		private static void WriteLittleEndian(byte[] buffer, int offset, ulong data) {} // 0x00000001863BCB50-0x00000001863BCD40
		// [IDTag] // 0x0000000189B51700-0x0000000189B51740
		// [XID] // 0x0000000189B51700-0x0000000189B51740
		private static void WriteLittleEndian(byte[] buffer, int offset, int data) {} // 0x00000001863BCD40-0x00000001863BCEA0
		// [IDTag] // 0x0000000189B5BFB0-0x0000000189B5BFF0
		// [XID] // 0x0000000189B5BFB0-0x0000000189B5BFF0
		public static void WriteLittleEndian(byte[] buffer, int offset, short data) {} // 0x00000001863BCA40-0x00000001863BCB50
		// [IDTag] // 0x0000000189B66470-0x0000000189B664B0
		// [XID] // 0x0000000189B66470-0x0000000189B664B0
		public static void GetBytes(byte[] bytes, int startIndex, double value) {} // 0x00000001863BC890-0x00000001863BC970
		// [IDTag] // 0x0000000189B70B00-0x0000000189B70B40
		// [XID] // 0x0000000189B70B00-0x0000000189B70B40
		public static void GetBytes(byte[] bytes, int startIndex, float value) {} // 0x00000001863BC600-0x00000001863BC6E0
		// [IDTag] // 0x0000000189B7AEE0-0x0000000189B7AF20
		// [XID] // 0x0000000189B7AEE0-0x0000000189B7AF20
		public static void GetBytes(byte[] bytes, int startIndex, short value) {} // 0x00000001863BC520-0x00000001863BC600
		// [IDTag] // 0x0000000189B85A80-0x0000000189B85AC0
		// [XID] // 0x0000000189B85A80-0x0000000189B85AC0
		public static void GetBytes(byte[] bytes, int startIndex, ushort value) {} // 0x00000001863BC7B0-0x00000001863BC890
		// [IDTag] // 0x0000000189B8FB70-0x0000000189B8FBB0
		// [XID] // 0x0000000189B8FB70-0x0000000189B8FBB0
		public static void GetBytes(byte[] bytes, int startIndex, int value) {} // 0x00000001863BC450-0x00000001863BC520
		// [IDTag] // 0x0000000189B99DB0-0x0000000189B99DF0
		// [XID] // 0x0000000189B99DB0-0x0000000189B99DF0
		public static void GetBytes(byte[] bytes, int startIndex, uint value) {} // 0x00000001863BC970-0x00000001863BCA40
		// [IDTag] // 0x0000000189BA45B0-0x0000000189BA45F0
		// [XID] // 0x0000000189BA45B0-0x0000000189BA45F0
		public static void GetBytes(byte[] bytes, int startIndex, long value) {} // 0x00000001863BC380-0x00000001863BC450
		// [IDTag] // 0x0000000189BAE840-0x0000000189BAE880
		// [XID] // 0x0000000189BAE840-0x0000000189BAE880
		public static void GetBytes(byte[] bytes, int startIndex, ulong value) {} // 0x00000001863BC6E0-0x00000001863BC7B0
	}
}
