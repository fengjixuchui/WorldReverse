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
	public sealed class NetPeer // TypeDefIndex: 6918
	{
		// Fields
		private int _currentFlowMode; // 0x10
		private int _sendedPacketsCount; // 0x14
		private int _flowTimer; // 0x18
		private int _ping; // 0x1C
		private int _rtt; // 0x20
		private int _avgRtt; // 0x24
		private int _rttCount; // 0x28
		private int _goodRttCount; // 0x2C
		private ushort _pingSequence; // 0x30
		private ushort _remotePingSequence; // 0x32
		private double _resendDelay; // 0x38
		private int _pingSendTimer; // 0x40
		private const int RttResetDelay = 1000; // Metadata: 0x00ADE06D
		private int _rttResetTimer; // 0x44
		private DateTime _pingTimeStart; // 0x48
		private int _timeSinceLastPacket; // 0x58
		private readonly NetEndPoint _remoteEndPoint; // 0x60
		private readonly NetManager _peerListener; // 0x68
		private readonly NetPacketPool _packetPool; // 0x70
		private readonly object _flushLock; // 0x78
		private readonly ReliableChannel _reliableOrderedChannel; // 0x80
		private readonly ReliableChannel _reliableUnorderedChannel; // 0x88
		private readonly SequencedChannel _sequencedChannel; // 0x90
		private readonly SimpleChannel _simpleChannel; // 0x98
		private int _windowSize; // 0xA0
		private int _mtu; // 0xA4
		private int _mtuIdx; // 0xA8
		private bool _finishMtu; // 0xAC
		private int _mtuCheckTimer; // 0xB0
		private int _mtuCheckAttempts; // 0xB4
		private const int MtuCheckDelay = 1000; // Metadata: 0x00ADE071
		private const int MaxMtuCheckAttempts = 4; // Metadata: 0x00ADE075
		private readonly object _mtuMutex; // 0xB8
		private ushort _fragmentId; // 0xC0
		private readonly Dictionary<ushort, IncomingFragments> _holdedFragments; // 0xC8
		private readonly NetPacket _mergeData; // 0xD0
		private int _mergePos; // 0xD8
		private int _mergeCount; // 0xDC
		private int _connectAttempts; // 0xE0
		private int _connectTimer; // 0xE4
		private long _connectId; // 0xE8
		private ConnectionState _connectionState; // 0xF0
		public object Tag; // 0xF8
	
		// Properties
		public ConnectionState ConnectionState { /* [XID] */ /* 0x0000000189750040-0x0000000189750060 */ get => default; } // 0x00000001863CD460-0x00000001863CD500 
		public long ConnectId { /* [XID] */ /* 0x0000000189A94230-0x0000000189A94250 */ get => default; } // 0x00000001863CD3B0-0x00000001863CD460 
		public NetEndPoint EndPoint { /* [XID] */ /* 0x0000000189AAA630-0x0000000189AAA650 */ get => default; } // 0x00000001863CD5A0-0x00000001863CD640 
		public int Ping { /* [XID] */ /* 0x00000001897663B0-0x00000001897663D0 */ get => default; } // 0x00000001863CD900-0x00000001863CD9A0 
		public int CurrentFlowMode { /* [XID] */ /* 0x000000018994AC20-0x000000018994AC40 */ get => default; } // 0x00000001863CD500-0x00000001863CD5A0 
		public int Mtu { /* [XID] */ /* 0x0000000189775190-0x00000001897751B0 */ get => default; } // 0x00000001863CD640-0x00000001863CD6E0 
		public int TimeSinceLastPacket { /* [XID] */ /* 0x000000018977CAA0-0x000000018977CAC0 */ get => default; } // 0x00000001863CDA50-0x00000001863CDAF0 
		public NetManager NetManager { /* [XID] */ /* 0x00000001897843F0-0x0000000189784410 */ get => default; } // 0x00000001863CD6E0-0x00000001863CD780 
		public int PacketsCountInReliableQueue { /* [XID] */ /* 0x000000018999F1B0-0x000000018999F1D0 */ get => default; } // 0x00000001863CD840-0x00000001863CD900 
		public int PacketsCountInReliableOrderedQueue { /* [XID] */ /* 0x0000000189792F30-0x0000000189792F50 */ get => default; } // 0x00000001863CD780-0x00000001863CD840 
		internal double ResendDelay { /* [XID] */ /* 0x00000001898BC230-0x00000001898BC250 */ get => default; } // 0x00000001863CD9A0-0x00000001863CDA50 
	
		// Nested types
		private class IncomingFragments // TypeDefIndex: 6919
		{
			// Fields
			public NetPacket[] Fragments; // 0x10
			public int ReceivedCount; // 0x18
			public int TotalSize; // 0x1C
	
			// Constructors
			public IncomingFragments() {} // 0x00000001863BD610-0x00000001863BD670
		}
	
		// Constructors
		public NetPeer() {} // Dummy constructor
		internal NetPeer(NetManager peerListener, NetEndPoint remoteEndPoint, long connectId) {} // 0x00000001863CD0B0-0x00000001863CD3B0
	
		// Methods
		// [XID] // 0x00000001897A25C0-0x00000001897A25E0
		private void SendConnectRequest() {} // 0x00000001863CBA40-0x00000001863CBC30
		// [XID] // 0x00000001897A9C10-0x00000001897A9C30
		private void SendConnectAccept() {} // 0x00000001863CB930-0x00000001863CBA40
		// [XID] // 0x00000001897B1430-0x00000001897B1450
		internal bool ProcessConnectAccept(NetPacket packet) => default; // 0x00000001863CADD0-0x00000001863CAEF0
		// [XID] // 0x0000000189B40B30-0x0000000189B40B50
		private static PacketProperty SendOptionsToProperty(SendOptions options) => default; // 0x00000001863CBC30-0x00000001863CBCF0
		// [XID] // 0x00000001897C1150-0x00000001897C1170
		public int GetMaxSinglePacketSize(SendOptions options) => default; // 0x00000001863CAC20-0x00000001863CACF0
		// [IDTag] // 0x00000001897C8B00-0x00000001897C8B40
		// [XID] // 0x00000001897C8B00-0x00000001897C8B40
		public void Send(byte[] data, SendOptions options) {} // 0x00000001863CC960-0x00000001863CCA50
		// [IDTag] // 0x00000001897D2F80-0x00000001897D2FC0
		// [XID] // 0x00000001897D2F80-0x00000001897D2FC0
		public void Send(NetDataWriter dataWriter, SendOptions options) {} // 0x00000001863CC850-0x00000001863CC960
		// [IDTag] // 0x00000001897DD6A0-0x00000001897DD6E0
		// [XID] // 0x00000001897DD6A0-0x00000001897DD6E0
		public void Send(byte[] data, int start, int length, SendOptions options) {} // 0x00000001863CC320-0x00000001863CC850
		// [XID] // 0x00000001897E7EF0-0x00000001897E7F10
		private void CreateAndSend(PacketProperty property, ushort sequence) {} // 0x00000001863CA9F0-0x00000001863CAB00
		// [XID] // 0x0000000189B66340-0x0000000189B66360
		private void SendPacket(NetPacket packet) {} // 0x00000001863CBCF0-0x00000001863CBF70
		// [XID] // 0x00000001897F72A0-0x00000001897F72C0
		private void UpdateRoundTripTime(int roundTripTime) {} // 0x00000001863CCA50-0x00000001863CCBD0
		// [XID] // 0x0000000189880D30-0x0000000189880D50
		internal void AddIncomingPacket(NetPacket p) {} // 0x00000001863CA3A0-0x00000001863CA900
		// [XID] // 0x0000000189AAC0D0-0x0000000189AAC0F0
		private void ProcessMtuPacket(NetPacket packet) {} // 0x00000001863CAEF0-0x00000001863CB310
		// [XID] // 0x000000018980D790-0x000000018980D7B0
		internal void ProcessPacket(NetPacket packet) {} // 0x00000001863CB310-0x00000001863CB870
		// [XID] // 0x0000000189B74E90-0x0000000189B74EB0
		private static bool CanMerge(PacketProperty property) => default; // 0x00000001863CA900-0x00000001863CA9F0
		// [XID] // 0x0000000189A3EA30-0x0000000189A3EA50
		internal void SendRawData(NetPacket packet) {} // 0x00000001863CC140-0x00000001863CC320
		// [XID] // 0x0000000189A04CA0-0x0000000189A04CC0
		private void SendQueuedPackets(int currentMaxSend) {} // 0x00000001863CBF70-0x00000001863CC140
		// [XID] // 0x000000018990F050-0x000000018990F070
		public void Flush() {} // 0x00000001863CAB00-0x00000001863CAC20
		// [XID] // 0x0000000189832D20-0x0000000189832D40
		internal void Update(int deltaTime) {} // 0x00000001863CCBD0-0x00000001863CD0B0
		// [XID] // 0x000000018983A240-0x000000018983A260
		internal void Recycle(NetPacket packet) {} // 0x00000001863CB870-0x00000001863CB930
		// [XID] // 0x00000001898417C0-0x00000001898417E0
		internal NetPacket GetPacketFromPool(PacketProperty property, int bytesCount) => default; // 0x00000001863CACF0-0x00000001863CADD0
	}
}
