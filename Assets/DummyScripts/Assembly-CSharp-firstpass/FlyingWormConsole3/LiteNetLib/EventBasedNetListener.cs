/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using FlyingWormConsole3.LiteNetLib.Utils;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace FlyingWormConsole3.LiteNetLib
{
	public class EventBasedNetListener : INetEventListener // TypeDefIndex: 6887
	{
		// Events
		public event OnPeerConnected PeerConnectedEvent;
		public event OnPeerDisconnected PeerDisconnectedEvent;
		public event OnNetworkError NetworkErrorEvent;
		public event OnNetworkReceive NetworkReceiveEvent;
		public event OnNetworkReceiveUnconnected NetworkReceiveUnconnectedEvent;
		public event OnNetworkLatencyUpdate NetworkLatencyUpdateEvent;
	
		// Nested types
		public delegate void OnPeerConnected(NetPeer peer); // TypeDefIndex: 6888; 0x00000001863D35F0-0x00000001863D3850
	
		public delegate void OnPeerDisconnected(NetPeer peer, DisconnectInfo disconnectInfo); // TypeDefIndex: 6889; 0x00000001863D39F0-0x00000001863D3D60
	
		public delegate void OnNetworkError(NetEndPoint endPoint, int socketErrorCode); // TypeDefIndex: 6890; 0x00000001863D24A0-0x00000001863D2750
	
		public delegate void OnNetworkReceive(NetPeer peer, NetDataReader reader); // TypeDefIndex: 6891; 0x00000001863D31B0-0x00000001863D3460
	
		public delegate void OnNetworkReceiveUnconnected(NetEndPoint remoteEndPoint, NetDataReader reader, UnconnectedMessageType messageType); // TypeDefIndex: 6892; 0x00000001863D2D40-0x00000001863D3030
	
		public delegate void OnNetworkLatencyUpdate(NetPeer peer, int latency); // TypeDefIndex: 6893; 0x00000001863D28F0-0x00000001863D2BA0
	
		// Constructors
		public EventBasedNetListener() {} // 0x00000001863B5280-0x00000001863B52E0
	
		// Methods
		// [XID] // 0x0000000189BCE370-0x0000000189BCE390
		void INetEventListener.OnPeerConnected(NetPeer peer) {} // 0x00000001863B50D0-0x00000001863B5190
		// [XID] // 0x0000000189BD5610-0x0000000189BD5630
		void INetEventListener.OnPeerDisconnected(NetPeer peer, DisconnectInfo disconnectInfo) {} // 0x00000001863B5190-0x00000001863B5280
		// [XID] // 0x0000000189666120-0x0000000189666140
		void INetEventListener.OnNetworkError(NetEndPoint endPoint, int socketErrorCode) {} // 0x00000001863B4D40-0x00000001863B4E20
		// [XID] // 0x00000001895E9C40-0x00000001895E9C60
		void INetEventListener.OnNetworkReceive(NetPeer peer, NetDataReader reader) {} // 0x00000001863B4FF0-0x00000001863B50D0
		// [XID] // 0x0000000189675750-0x0000000189675770
		void INetEventListener.OnNetworkReceiveUnconnected(NetEndPoint remoteEndPoint, NetDataReader reader, UnconnectedMessageType messageType) {} // 0x00000001863B4F00-0x00000001863B4FF0
		// [XID] // 0x00000001895F8E80-0x00000001895F8EA0
		void INetEventListener.OnNetworkLatencyUpdate(NetPeer peer, int latency) {} // 0x00000001863B4E20-0x00000001863B4F00
	}
}
