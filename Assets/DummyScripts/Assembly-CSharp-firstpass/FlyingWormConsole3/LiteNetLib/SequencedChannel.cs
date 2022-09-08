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
	internal sealed class SequencedChannel // TypeDefIndex: 6968
	{
		// Fields
		private ushort _localSequence; // 0x10
		private ushort _remoteSequence; // 0x12
		private readonly Queue<NetPacket> _outgoingPackets; // 0x18
		private readonly NetPeer _peer; // 0x20
	
		// Constructors
		public SequencedChannel() {} // Dummy constructor
		public SequencedChannel(NetPeer peer) {} // 0x00000001863D5750-0x00000001863D57F0
	
		// Methods
		// [XID] // 0x0000000189B3F400-0x0000000189B3F420
		public void AddToQueue(NetPacket packet) {} // 0x00000001863D52D0-0x00000001863D5410
		// [XID] // 0x0000000189B46DA0-0x0000000189B46DC0
		public bool SendNextPacket() => default; // 0x00000001863D5540-0x00000001863D5750
		// [XID] // 0x0000000189B4E650-0x0000000189B4E670
		public void ProcessPacket(NetPacket packet) {} // 0x00000001863D5410-0x00000001863D5540
	}
}
