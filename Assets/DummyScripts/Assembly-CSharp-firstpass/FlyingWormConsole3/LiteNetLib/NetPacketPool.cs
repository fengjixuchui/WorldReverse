/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using FlyingWormConsole3.LiteNetLib.Utils;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace FlyingWormConsole3.LiteNetLib
{
	internal class NetPacketPool // TypeDefIndex: 6916
	{
		// Fields
		private readonly Stack<NetPacket> _pool; // 0x10
	
		// Constructors
		public NetPacketPool() {} // 0x00000001863C87F0-0x00000001863C8880
	
		// Methods
		// [IDTag] // 0x0000000189724860-0x00000001897248A0
		// [XID] // 0x0000000189724860-0x00000001897248A0
		public NetPacket GetWithData(PacketProperty property, NetDataWriter writer) => default; // 0x00000001863C8270-0x00000001863C83D0
		// [IDTag] // 0x000000018972EFD0-0x000000018972F010
		// [XID] // 0x000000018972EFD0-0x000000018972F010
		public NetPacket GetWithData(PacketProperty property, byte[] data, int start, int length) => default; // 0x00000001863C8130-0x00000001863C8270
		// [XID] // 0x00000001897396E0-0x0000000189739700
		public NetPacket GetAndRead(byte[] data, int start, int count) => default; // 0x00000001863C7F00-0x00000001863C8130
		// [XID] // 0x0000000189741290-0x00000001897412B0
		public NetPacket Get(PacketProperty property, int size) => default; // 0x00000001863C83D0-0x00000001863C8660
		// [XID] // 0x0000000189A0ABB0-0x0000000189A0ABD0
		public void Recycle(NetPacket packet) {} // 0x00000001863C8660-0x00000001863C87F0
	}
}
