/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace FlyingWormConsole3.LiteNetLib
{
	internal sealed class SimpleChannel // TypeDefIndex: 6969
	{
		// Fields
		private readonly Queue<NetPacket> _outgoingPackets; // 0x10
		private readonly NetPeer _peer; // 0x18
	
		// Constructors
		public SimpleChannel() {} // Dummy constructor
		public SimpleChannel(NetPeer peer) {} // 0x00000001863D5B20-0x00000001863D5BE0
	
		// Methods
		// [XID] // 0x0000000189B2E8A0-0x0000000189B2E8C0
		public void AddToQueue(NetPacket packet) {} // 0x00000001863D57F0-0x00000001863D5930
		// [XID] // 0x00000001898CAFB0-0x00000001898CAFD0
		public bool SendNextPacket() => default; // 0x00000001863D5930-0x00000001863D5B20
	}
}
