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
	public sealed class NetManager // TypeDefIndex: 6908
	{
		// Fields
		private readonly List<IncomingData> _pingSimulationList; // 0x10
		private readonly Random _randomGenerator; // 0x18
		private const int MinLatencyTreshold = 5; // Metadata: 0x00ADE021
		private readonly NetSocket _socket; // 0x20
		private readonly List<FlowMode> _flowModes; // 0x28
		private readonly NetThread _logicThread; // 0x30
		private readonly Queue<NetEvent> _netEventsQueue; // 0x38
		private readonly Stack<NetEvent> _netEventsPool; // 0x40
		private readonly INetEventListener _netEventListener; // 0x48
		private readonly NetPeerCollection _peers; // 0x50
		private readonly int _maxConnections; // 0x58
		private readonly string _connectKey; // 0x60
		private readonly NetPacketPool _netPacketPool; // 0x68
		public bool UnconnectedMessagesEnabled; // 0x70
		public bool NatPunchEnabled; // 0x71
		public int PingInterval; // 0x74
		public long DisconnectTimeout; // 0x78
		public bool SimulatePacketLoss; // 0x80
		public bool SimulateLatency; // 0x81
		public int SimulationPacketLossChance; // 0x84
		public int SimulationMinLatency; // 0x88
		public int SimulationMaxLatency; // 0x8C
		public bool UnsyncedEvents; // 0x90
		public bool DiscoveryEnabled; // 0x91
		public bool MergeEnabled; // 0x92
		public int ReconnectDelay; // 0x94
		public int MaxConnectAttempts; // 0x98
		public bool ReuseAddress; // 0x9C
		private const int DefaultUpdateTime = 15; // Metadata: 0x00ADE025
		public readonly NatPunchModule NatPunchModule; // 0xC0
	
		// Properties
		public int UpdateTime { /* [XID] */ /* 0x0000000189A5CC00-0x0000000189A5CC20 */ get => default; /* [XID] */ /* 0x0000000189A76370-0x0000000189A76390 */ set {} } // 0x00000001863C7BD0-0x00000001863C7C80 0x00000001863C7E40-0x00000001863C7F00
		public ulong PacketsSent { /* [XID] */ /* 0x0000000189A6BDA0-0x0000000189A6BDE0 */ get; /* [XID] */ /* 0x0000000189A764E0-0x0000000189A76520 */ private set; } // 0x00000001863C7AC0-0x00000001863C7B20 0x00000001863C7DD0-0x00000001863C7E40
		public ulong PacketsReceived { /* [XID] */ /* 0x0000000189A80E50-0x0000000189A80E90 */ get; /* [XID] */ /* 0x0000000189A8B970-0x0000000189A8B9B0 */ private set; } // 0x00000001863C7A60-0x00000001863C7AC0 0x00000001863C7D60-0x00000001863C7DD0
		public ulong BytesSent { /* [XID] */ /* 0x0000000189A95DE0-0x0000000189A95E20 */ get; /* [XID] */ /* 0x0000000189AA03D0-0x0000000189AA0410 */ private set; } // 0x00000001863C7760-0x00000001863C77C0 0x00000001863C7CF0-0x00000001863C7D60
		public ulong BytesReceived { /* [XID] */ /* 0x0000000189AAA910-0x0000000189AAA950 */ get; /* [XID] */ /* 0x0000000189AB5420-0x0000000189AB5460 */ private set; } // 0x00000001863C7700-0x00000001863C7760 0x00000001863C7C80-0x00000001863C7CF0
		public bool IsRunning { /* [XID] */ /* 0x0000000189A49090-0x0000000189A490B0 */ get => default; } // 0x00000001863C7860-0x00000001863C7910 
		public NetEndPoint LocalEndPoint { /* [XID] */ /* 0x0000000189616970-0x0000000189616990 */ get => default; } // 0x00000001863C7910-0x00000001863C79C0 
		public int PeersCount { /* [XID] */ /* 0x0000000189ACEFD0-0x0000000189ACEFF0 */ get => default; } // 0x00000001863C7B20-0x00000001863C7BD0 
		public string ConnectKey { /* [XID] */ /* 0x00000001897A9A20-0x00000001897A9A40 */ get => default; } // 0x00000001863C77C0-0x00000001863C7860 
		internal NetPacketPool PacketPool { /* [XID] */ /* 0x0000000189AFC5F0-0x0000000189AFC610 */ get => default; } // 0x00000001863C79C0-0x00000001863C7A60 
	
		// Nested types
		internal delegate void OnMessageReceived(byte[] data, int length, int errorCode, NetEndPoint remoteEndPoint); // TypeDefIndex: 6909; 0x00000001863D1700-0x00000001863D1A50
	
		private struct FlowMode // TypeDefIndex: 6910
		{
			// Fields
			public int PacketsPerSecond; // 0x00
			public int StartRtt; // 0x04
		}
	
		private enum NetEventType // TypeDefIndex: 6911
		{
			Connect = 0,
			Disconnect = 1,
			Receive = 2,
			ReceiveUnconnected = 3,
			Error = 4,
			ConnectionLatencyUpdated = 5,
			DiscoveryRequest = 6,
			DiscoveryResponse = 7
		}
	
		private sealed class NetEvent // TypeDefIndex: 6912
		{
			// Fields
			public NetPeer Peer; // 0x10
			public readonly NetDataReader DataReader; // 0x18
			public NetEventType Type; // 0x20
			public NetEndPoint RemoteEndPoint; // 0x28
			public int AdditionalData; // 0x30
			public DisconnectReason DisconnectReason; // 0x34
	
			// Constructors
			public NetEvent() {} // 0x00000001863C2960-0x00000001863C2A30
		}
	
		private struct IncomingData // TypeDefIndex: 6913
		{
			// Fields
			public byte[] Data; // 0x00
			public NetEndPoint EndPoint; // 0x08
			public DateTime TimeWhenGet; // 0x10
		}
	
		// Constructors
		public NetManager() {} // Dummy constructor
		public NetManager(INetEventListener listener, string connectKey) {} // 0x00000001863C7320-0x00000001863C73B0
		public NetManager(INetEventListener listener, int maxConnections, string connectKey) {} // 0x00000001863C73B0-0x00000001863C7700
	
		// Methods
		// [XID] // 0x00000001897B1260-0x00000001897B1280
		public void AddFlowMode(int startRtt, int packetsPerSecond) {} // 0x00000001863C2A30-0x00000001863C2B90
		// [XID] // 0x0000000189AE60E0-0x0000000189AE6100
		internal int GetPacketsPerSecond(int flowMode) => default; // 0x00000001863C45E0-0x00000001863C46D0
		// [XID] // 0x00000001897C0F10-0x00000001897C0F30
		internal int GetMaxFlowMode() => default; // 0x00000001863C4520-0x00000001863C45E0
		// [XID] // 0x0000000189AF5080-0x0000000189AF50A0
		internal int GetStartRtt(int flowMode) => default; // 0x00000001863C49B0-0x00000001863C4AB0
		// [XID] // 0x000000018982CCD0-0x000000018982CCF0
		internal void ConnectionLatencyUpdated(NetPeer fromPeer, int latency) {} // 0x00000001863C2FB0-0x00000001863C30A0
		// [XID] // 0x0000000189AB24B0-0x0000000189AB24D0
		internal bool SendRawAndRecycle(NetPacket packet, NetEndPoint remoteEndPoint) => default; // 0x00000001863C5CB0-0x00000001863C5DC0
		// [XID] // 0x00000001899C1D00-0x00000001899C1D20
		internal bool SendRaw(byte[] message, int start, int length, NetEndPoint remoteEndPoint) => default; // 0x00000001863C5DC0-0x00000001863C6000
		// [IDTag] // 0x0000000189B1A1D0-0x0000000189B1A210
		// [XID] // 0x0000000189B1A1D0-0x0000000189B1A210
		private void DisconnectPeer(NetPeer peer, DisconnectReason reason, int socketErrorCode, bool sendDisconnectPacket, byte[] data, int start, int count) {} // 0x00000001863C3B90-0x00000001863C3E30
		// [XID] // 0x0000000189A19810-0x0000000189A19830
		private void ClearPeers() {} // 0x00000001863C2B90-0x00000001863C2CB0
		// [XID] // 0x0000000189A5C9C0-0x0000000189A5C9E0
		private void RemovePeer(NetEndPoint endPoint) {} // 0x00000001863C5540-0x00000001863C5600
		// [XID] // 0x0000000189834420-0x0000000189834440
		private void RemovePeerAt(int idx) {} // 0x00000001863C5480-0x00000001863C5540
		// [XID] // 0x0000000189B3AD30-0x0000000189B3AD50
		private NetEvent CreateEvent(NetEventType type) => default; // 0x00000001863C30A0-0x00000001863C3250
		// [XID] // 0x0000000189B424D0-0x0000000189B424F0
		private void EnqueueEvent(NetEvent evt) {} // 0x00000001863C40F0-0x00000001863C4240
		// [XID] // 0x0000000189B49F00-0x0000000189B49F20
		private void ProcessEvent(NetEvent evt) {} // 0x00000001863C4C80-0x00000001863C4FC0
		// [XID] // 0x0000000189B516E0-0x0000000189B51700
		private void UpdateLogic() {} // 0x00000001863C6F10-0x00000001863C7320
		// [XID] // 0x0000000189A59830-0x0000000189A59850
		private void ReceiveLogic(byte[] data, int length, int errorCode, NetEndPoint remoteEndPoint) {} // 0x00000001863C5140-0x00000001863C5480
		// [XID] // 0x0000000189B606D0-0x0000000189B606F0
		private void DataReceived(byte[] reusableBuffer, int count, NetEndPoint remoteEndPoint) {} // 0x00000001863C3250-0x00000001863C3A40
		// [XID] // 0x00000001898ACF00-0x00000001898ACF20
		internal void ReceiveFromPeer(NetPacket packet, NetEndPoint remoteEndPoint) {} // 0x00000001863C4FC0-0x00000001863C5140
		// [IDTag] // 0x0000000189B6F160-0x0000000189B6F1A0
		// [XID] // 0x0000000189B6F160-0x0000000189B6F1A0
		public void SendToAll(NetDataWriter writer, SendOptions options) {} // 0x00000001863C65A0-0x00000001863C66B0
		// [IDTag] // 0x0000000189B799A0-0x0000000189B799E0
		// [XID] // 0x0000000189B799A0-0x0000000189B799E0
		public void SendToAll(byte[] data, SendOptions options) {} // 0x00000001863C6000-0x00000001863C60F0
		// [IDTag] // 0x0000000189B842A0-0x0000000189B842E0
		// [XID] // 0x0000000189B842A0-0x0000000189B842E0
		public void SendToAll(byte[] data, int start, int length, SendOptions options) {} // 0x00000001863C62D0-0x00000001863C6480
		// [IDTag] // 0x0000000189B8E360-0x0000000189B8E3A0
		// [XID] // 0x0000000189B8E360-0x0000000189B8E3A0
		public void SendToAll(NetDataWriter writer, SendOptions options, NetPeer excludePeer) {} // 0x00000001863C6480-0x00000001863C65A0
		// [IDTag] // 0x0000000189B98930-0x0000000189B98970
		// [XID] // 0x0000000189B98930-0x0000000189B98970
		public void SendToAll(byte[] data, SendOptions options, NetPeer excludePeer) {} // 0x00000001863C66B0-0x00000001863C67B0
		// [IDTag] // 0x0000000189BA3130-0x0000000189BA3170
		// [XID] // 0x0000000189BA3130-0x0000000189BA3170
		public void SendToAll(byte[] data, int start, int length, SendOptions options, NetPeer excludePeer) {} // 0x00000001863C60F0-0x00000001863C62D0
		// [IDTag] // 0x0000000189BAD260-0x0000000189BAD2A0
		// [XID] // 0x0000000189BAD260-0x0000000189BAD2A0
		public bool Start() => default; // 0x00000001863C6C00-0x00000001863C6CB0
		// [IDTag] // 0x0000000189BB7570-0x0000000189BB75B0
		// [XID] // 0x0000000189BB7570-0x0000000189BB75B0
		public bool Start(int port) => default; // 0x00000001863C6AE0-0x00000001863C6C00
		// [IDTag] // 0x0000000189BC25E0-0x0000000189BC2620
		// [XID] // 0x0000000189BC25E0-0x0000000189BC2620
		public bool SendUnconnectedMessage(byte[] message, NetEndPoint remoteEndPoint) => default; // 0x00000001863C68E0-0x00000001863C69D0
		// [IDTag] // 0x0000000189BCCDC0-0x0000000189BCCE00
		// [XID] // 0x0000000189BCCDC0-0x0000000189BCCE00
		public bool SendUnconnectedMessage(NetDataWriter writer, NetEndPoint remoteEndPoint) => default; // 0x00000001863C69D0-0x00000001863C6AE0
		// [IDTag] // 0x0000000189BD6FD0-0x0000000189BD7010
		// [XID] // 0x0000000189BD6FD0-0x0000000189BD7010
		public bool SendUnconnectedMessage(byte[] message, int start, int length, NetEndPoint remoteEndPoint) => default; // 0x00000001863C67B0-0x00000001863C68E0
		// [IDTag] // 0x00000001895E6CB0-0x00000001895E6CF0
		// [XID] // 0x00000001895E6CB0-0x00000001895E6CF0
		public bool SendDiscoveryRequest(NetDataWriter writer, int port) => default; // 0x00000001863C5600-0x00000001863C5710
		// [IDTag] // 0x00000001895F14E0-0x00000001895F1520
		// [XID] // 0x00000001895F14E0-0x00000001895F1520
		public bool SendDiscoveryRequest(byte[] data, int port) => default; // 0x00000001863C5710-0x00000001863C5800
		// [IDTag] // 0x00000001895FBE10-0x00000001895FBE50
		// [XID] // 0x00000001895FBE10-0x00000001895FBE50
		public bool SendDiscoveryRequest(byte[] data, int start, int length, int port) => default; // 0x00000001863C5800-0x00000001863C5980
		// [IDTag] // 0x00000001896065F0-0x0000000189606630
		// [XID] // 0x00000001896065F0-0x0000000189606630
		public bool SendDiscoveryResponse(NetDataWriter writer, NetEndPoint remoteEndPoint) => default; // 0x00000001863C5A70-0x00000001863C5B80
		// [IDTag] // 0x0000000189610E80-0x0000000189610EC0
		// [XID] // 0x0000000189610E80-0x0000000189610EC0
		public bool SendDiscoveryResponse(byte[] data, NetEndPoint remoteEndPoint) => default; // 0x00000001863C5980-0x00000001863C5A70
		// [IDTag] // 0x000000018961B4C0-0x000000018961B500
		// [XID] // 0x000000018961B4C0-0x000000018961B500
		public bool SendDiscoveryResponse(byte[] data, int start, int length, NetEndPoint remoteEndPoint) => default; // 0x00000001863C5B80-0x00000001863C5CB0
		// [XID] // 0x0000000189625A40-0x0000000189625A60
		public void Flush() {} // 0x00000001863C4240-0x00000001863C43A0
		// [XID] // 0x0000000189B053B0-0x0000000189B053D0
		public void PollEvents() {} // 0x00000001863C4AB0-0x00000001863C4C80
		// [IDTag] // 0x0000000189634D80-0x0000000189634DC0
		// [XID] // 0x0000000189634D80-0x0000000189634DC0
		public void Connect(string address, int port) {} // 0x00000001863C2CB0-0x00000001863C2DB0
		// [IDTag] // 0x000000018963F2B0-0x000000018963F2F0
		// [XID] // 0x000000018963F2B0-0x000000018963F2F0
		public void Connect(NetEndPoint target) {} // 0x00000001863C2DB0-0x00000001863C2FB0
		// [XID] // 0x0000000189649C20-0x0000000189649C40
		public void Stop() {} // 0x00000001863C6CB0-0x00000001863C6F10
		// [XID] // 0x0000000189AB3A50-0x0000000189AB3A70
		public NetPeer GetFirstPeer() => default; // 0x00000001863C43A0-0x00000001863C4520
		// [XID] // 0x00000001897E1E20-0x00000001897E1E40
		public NetPeer[] GetPeers() => default; // 0x00000001863C4860-0x00000001863C49B0
		// [XID] // 0x00000001896600E0-0x0000000189660100
		public void GetPeersNonAlloc(List<NetPeer> peers) {} // 0x00000001863C46D0-0x00000001863C4860
		// [IDTag] // 0x0000000189667B50-0x0000000189667B90
		// [XID] // 0x0000000189667B50-0x0000000189667B90
		public void DisconnectPeer(NetPeer peer) {} // 0x00000001863C3F20-0x00000001863C3FE0
		// [IDTag] // 0x00000001896727C0-0x0000000189672800
		// [XID] // 0x00000001896727C0-0x0000000189672800
		public void DisconnectPeer(NetPeer peer, byte[] data) {} // 0x00000001863C3E30-0x00000001863C3F20
		// [IDTag] // 0x000000018967CEF0-0x000000018967CF30
		// [XID] // 0x000000018967CEF0-0x000000018967CF30
		public void DisconnectPeer(NetPeer peer, NetDataWriter writer) {} // 0x00000001863C3FE0-0x00000001863C40F0
		// [IDTag] // 0x00000001896875A0-0x00000001896875E0
		// [XID] // 0x00000001896875A0-0x00000001896875E0
		public void DisconnectPeer(NetPeer peer, byte[] data, int start, int count) {} // 0x00000001863C3A40-0x00000001863C3B90
	}
}
