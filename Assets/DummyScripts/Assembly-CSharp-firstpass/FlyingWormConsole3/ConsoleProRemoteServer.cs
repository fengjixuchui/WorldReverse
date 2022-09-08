/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using FlyingWormConsole3.LiteNetLib;
using FlyingWormConsole3.LiteNetLib.Utils;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace FlyingWormConsole3
{
	public class ConsoleProRemoteServer : MonoBehaviour, INetEventListener // TypeDefIndex: 6878
	{
		// Fields
		public bool useNATPunch; // 0x18
		public int port; // 0x1C
		private NetManager _netServer; // 0x20
		private NetPeer _ourPeer; // 0x28
		private NetDataWriter _dataWriter; // 0x30
		[NonSerialized]
		public List<QueuedLog> logs; // 0x38
		private static ConsoleProRemoteServer instance; // 0x00
	
		// Nested types
		[Serializable]
		public class QueuedLog // TypeDefIndex: 6879
		{
			// Fields
			public string message; // 0x10
			public string stackTrace; // 0x18
			public LogType type; // 0x20
	
			// Constructors
			public QueuedLog() {} // 0x00000001863D3F20-0x00000001863D3F80
		}
	
		// Constructors
		public ConsoleProRemoteServer() {} // 0x00000001863B4430-0x00000001863B4520
		static ConsoleProRemoteServer() {} // 0x00000001863B43D0-0x00000001863B4430
	
		// Methods
		// [XID] // 0x0000000189AD8460-0x0000000189AD8480
		private void Awake() {} // 0x00000001863B2F90-0x00000001863B3280
		// [XID] // 0x0000000189A7DCA0-0x0000000189A7DCC0
		private void OnDestroy() {} // 0x00000001863B3710-0x00000001863B37C0
		// [XID] // 0x0000000189A0ABD0-0x0000000189A0ABF0
		public void OnPeerConnected(NetPeer peer) {} // 0x00000001863B3D00-0x00000001863B3E30
		// [IDTag] // 0x0000000189AEF3F0-0x0000000189AEF430
		// [XID] // 0x0000000189AEF3F0-0x0000000189AEF430
		public void OnPeerDisconnected(NetPeer peer, DisconnectInfo disconnectInfo) {} // 0x00000001863B3F00-0x00000001863B41E0
		// [XID] // 0x0000000189A123E0-0x0000000189A12400
		public void OnNetworkReceive(NetPeer peer, NetDataReader reader) {} // 0x00000001863B3C40-0x00000001863B3D00
		// [IDTag] // 0x0000000189B00E80-0x0000000189B00EC0
		// [XID] // 0x0000000189B00E80-0x0000000189B00EC0
		public void OnPeerDisconnected(NetPeer peer, DisconnectReason reason, int socketErrorCode) {} // 0x00000001863B3E30-0x00000001863B3F00
		// [XID] // 0x0000000189B0B5A0-0x0000000189B0B5C0
		public void OnNetworkError(NetEndPoint endPoint, int socketErrorCode) {} // 0x00000001863B3980-0x00000001863B3A40
		// [XID] // 0x0000000189B88640-0x0000000189B88660
		public void OnNetworkReceiveUnconnected(NetEndPoint remoteEndPoint, NetDataReader reader, UnconnectedMessageType messageType) {} // 0x00000001863B3B00-0x00000001863B3C40
		// [XID] // 0x0000000189B1A210-0x0000000189B1A230
		public void OnNetworkLatencyUpdate(NetPeer peer, int latency) {} // 0x00000001863B3A40-0x00000001863B3B00
		// [XID] // 0x0000000189B216A0-0x0000000189B216C0
		private void OnEnable() {} // 0x00000001863B38A0-0x00000001863B3980
		// [XID] // 0x0000000189B28E70-0x0000000189B28E90
		private void OnDisable() {} // 0x00000001863B37C0-0x00000001863B38A0
		// [XID] // 0x0000000189B302F0-0x0000000189B30310
		public void LogCallback(string logString, string stackTrace, LogType type) {} // 0x00000001863B3600-0x00000001863B3710
		// [XID] // 0x0000000189B37AA0-0x0000000189B37AC0
		private void QueueLog(string logString, string stackTrace, LogType type) {} // 0x00000001863B41E0-0x00000001863B43D0
		// [XID] // 0x0000000189B3F420-0x0000000189B3F440
		private void LateUpdate() {} // 0x00000001863B3280-0x00000001863B3600
	}
}
