/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using FlyingWormConsole3.LiteNetLib.Utils;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace FlyingWormConsole3.LiteNetLib
{
	public interface INetEventListener // TypeDefIndex: 6886
	{
		// Methods
		void OnPeerConnected(NetPeer peer);
		void OnPeerDisconnected(NetPeer peer, DisconnectInfo disconnectInfo);
		void OnNetworkError(NetEndPoint endPoint, int socketErrorCode);
		void OnNetworkReceive(NetPeer peer, NetDataReader reader);
		void OnNetworkReceiveUnconnected(NetEndPoint remoteEndPoint, NetDataReader reader, UnconnectedMessageType messageType);
		void OnNetworkLatencyUpdate(NetPeer peer, int latency);
	}
}
