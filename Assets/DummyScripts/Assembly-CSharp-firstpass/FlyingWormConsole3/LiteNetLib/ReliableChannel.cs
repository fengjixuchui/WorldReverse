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
	internal sealed class ReliableChannel // TypeDefIndex: 6966
	{
		// Fields
		private readonly Queue<NetPacket> _outgoingPackets; // 0x10
		private readonly bool[] _outgoingAcks; // 0x18
		private readonly PendingPacket[] _pendingPackets; // 0x20
		private readonly NetPacket[] _receivedPackets; // 0x28
		private readonly bool[] _earlyReceived; // 0x30
		private int _localSeqence; // 0x38
		private int _remoteSequence; // 0x3C
		private int _localWindowStart; // 0x40
		private int _remoteWindowStart; // 0x44
		private readonly NetPeer _peer; // 0x48
		private bool _mustSendAcks; // 0x50
		private readonly bool _ordered; // 0x51
		private readonly int _windowSize; // 0x54
		private const int BitsInByte = 8; // Metadata: 0x00ADE091
		private int _queueIndex; // 0x58
	
		// Properties
		public int PacketsInQueue { /* [XID] */ /* 0x0000000189B03DF0-0x0000000189B03E10 */ get => default; } // 0x00000001863D51F0-0x00000001863D52D0 
	
		// Nested types
		private class PendingPacket // TypeDefIndex: 6967
		{
			// Fields
			public NetPacket Packet; // 0x10
			public DateTime? TimeStamp; // 0x18
	
			// Constructors
			public PendingPacket() {} // 0x00000001863D3EC0-0x00000001863D3F20
	
			// Methods
			// [XID] // 0x0000000189B37A80-0x0000000189B37AA0
			public NetPacket GetAndClear() => default; // 0x00000001863D3DE0-0x00000001863D3EC0
		}
	
		// Constructors
		public ReliableChannel() {} // Dummy constructor
		public ReliableChannel(NetPeer peer, bool ordered, int windowSize) {} // 0x00000001863D4FC0-0x00000001863D51F0
	
		// Methods
		// [XID] // 0x0000000189B0B580-0x0000000189B0B5A0
		public void ProcessAck(NetPacket packet) {} // 0x00000001863D40C0-0x00000001863D4370
		// [XID] // 0x0000000189994920-0x0000000189994940
		public void AddToQueue(NetPacket packet) {} // 0x00000001863D3F80-0x00000001863D40C0
		// [XID] // 0x00000001898B4450-0x00000001898B4470
		private void ProcessQueuedPackets() {} // 0x00000001863D4870-0x00000001863D4AD0
		// [XID] // 0x0000000189B21680-0x0000000189B216A0
		public bool SendNextPacket() => default; // 0x00000001863D4CE0-0x00000001863D4FC0
		// [XID] // 0x0000000189B28E50-0x0000000189B28E70
		public void SendAcks() {} // 0x00000001863D4AD0-0x00000001863D4CE0
		// [XID] // 0x0000000189A4A7B0-0x0000000189A4A7D0
		public void ProcessPacket(NetPacket packet) {} // 0x00000001863D4370-0x00000001863D4870
	}
}
