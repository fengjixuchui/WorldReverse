/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace FlyingWormConsole3.LiteNetLib
{
	internal sealed class NetPacket // TypeDefIndex: 6915
	{
		// Fields
		private const int LastProperty = 19; // Metadata: 0x00ADE05D
		public readonly byte[] RawData; // 0x10
		public int Size; // 0x18
	
		// Properties
		public PacketProperty Property { /* [XID] */ /* 0x0000000189B6D8B0-0x0000000189B6D8D0 */ get => default; /* [XID] */ /* 0x0000000189A6BBE0-0x0000000189A6BC00 */ set {} } // 0x00000001863C92C0-0x00000001863C9390 0x00000001863C97A0-0x00000001863C98A0
		public ushort Sequence { /* [XID] */ /* 0x00000001896A1050-0x00000001896A1070 */ get => default; /* [XID] */ /* 0x00000001896A8490-0x00000001896A84B0 */ set {} } // 0x00000001863C9390-0x00000001863C9460 0x00000001863C98A0-0x00000001863C9960
		public bool IsFragmented { /* [XID] */ /* 0x00000001898880A0-0x00000001898880C0 */ get => default; /* [XID] */ /* 0x00000001896B7030-0x00000001896B7050 */ set {} } // 0x00000001863C91F0-0x00000001863C92C0 0x00000001863C96A0-0x00000001863C97A0
		public ushort FragmentId { /* [XID] */ /* 0x00000001896BE120-0x00000001896BE140 */ get => default; /* [XID] */ /* 0x0000000189B48370-0x0000000189B48390 */ set {} } // 0x00000001863C8F80-0x00000001863C9050 0x00000001863C9460-0x00000001863C9520
		public ushort FragmentPart { /* [XID] */ /* 0x00000001896CD080-0x00000001896CD0A0 */ get => default; /* [XID] */ /* 0x0000000189B57280-0x0000000189B572A0 */ set {} } // 0x00000001863C9050-0x00000001863C9120 0x00000001863C9520-0x00000001863C95E0
		public ushort FragmentsTotal { /* [XID] */ /* 0x00000001896DBD20-0x00000001896DBD40 */ get => default; /* [XID] */ /* 0x0000000189B5ECC0-0x0000000189B5ECE0 */ set {} } // 0x00000001863C9120-0x00000001863C91F0 0x00000001863C95E0-0x00000001863C96A0
	
		// Constructors
		public NetPacket() {} // Dummy constructor
		public NetPacket(int size) {} // 0x00000001863C8EE0-0x00000001863C8F80
	
		// Methods
		// [XID] // 0x00000001896EA920-0x00000001896EA940
		public static bool GetPacketProperty(byte[] data, out PacketProperty property) {
			property = default;
			return default;
		} // 0x00000001863C8C70-0x00000001863C8D60
		// [IDTag] // 0x00000001896F19D0-0x00000001896F1A10
		// [XID] // 0x00000001896F19D0-0x00000001896F1A10
		public static int GetHeaderSize(PacketProperty property) => default; // 0x00000001863C8AB0-0x00000001863C8B60
		// [IDTag] // 0x00000001896FC790-0x00000001896FC7D0
		// [XID] // 0x00000001896FC790-0x00000001896FC7D0
		public int GetHeaderSize() => default; // 0x00000001863C8A00-0x00000001863C8AB0
		// [XID] // 0x0000000189706BE0-0x0000000189706C00
		public byte[] GetPacketData() => default; // 0x00000001863C8B60-0x00000001863C8C70
		// [XID] // 0x000000018970E580-0x000000018970E5A0
		public bool IsClientData() => default; // 0x00000001863C8D60-0x00000001863C8E20
		// [XID] // 0x0000000189B5BCA0-0x0000000189B5BCC0
		public static bool IsSequenced(PacketProperty property) => default; // 0x00000001863C8E20-0x00000001863C8EE0
		// [XID] // 0x000000018971D410-0x000000018971D430
		public bool FromBytes(byte[] data, int start, int packetSize) => default; // 0x00000001863C8880-0x00000001863C8A00
	}
}
