/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using MoleMole;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole.AsyncNetwork
{
	public class ConnectionManager : NetListener // TypeDefIndex: 10670
	{
		// Fields
		private bool _enableLog; // 0x38
		private readonly LinkedList<IConnection> _connections; // 0x40
		private Dictionary<IConnection, ByteBuffer> _connectionBufferSet; // 0x48
	
		// Properties
		public Action<IConnection> clientConnectedCallback { /* [XID] */ /* 0x0000000189AED430-0x0000000189AED470 */ get; /* [XID] */ /* 0x0000000189AF7F30-0x0000000189AF7F70 */ set; } // 0x00000001868FDC90-0x00000001868FDCF0 0x00000001868FDED0-0x00000001868FDF30
		public Action<IConnection> clientDisconnectedCallback { /* [XID] */ /* 0x0000000189B026A0-0x0000000189B026E0 */ get; set; } // 0x00000001868FDCF0-0x00000001868FDD50 0x00000001868FDF30-0x00000001868FDF90
		public Func<IConnection, ByteBuffer, int> processDataCallback { /* [XID] */ /* 0x0000000189B140C0-0x0000000189B14100 */ get; set; } // 0x00000001868FDE70-0x00000001868FDED0 0x00000001868FE0B0-0x00000001868FE110
		public Func<Connection> connectionFactory { /* [XID] */ /* 0x0000000189B25F60-0x0000000189B25FA0 */ get; set; } // 0x00000001868FDD50-0x00000001868FDDB0 0x00000001868FDF90-0x00000001868FDFF0
		public Action maxConnectionReachedCallback { /* [XID] */ /* 0x0000000189B37940-0x0000000189B37980 */ get; set; } // 0x00000001868FDE10-0x00000001868FDE70 0x00000001868FE050-0x00000001868FE0B0
		public int maxClients { /* [XID] */ /* 0x0000000189B49C90-0x0000000189B49CD0 */ get; set; } // 0x00000001868FDDB0-0x00000001868FDE10 0x00000001868FDFF0-0x00000001868FE050
	
		// Constructors
		public ConnectionManager() {} // Dummy constructor
		public ConnectionManager(SyncContext ctx) {} // 0x00000001868FDB30-0x00000001868FDC90
	
		// Methods
		// [XID] // 0x0000000189B5BDE0-0x0000000189B5BE00
		public override void Close() {} // 0x00000001868FC340-0x00000001868FC560
		// [XID] // 0x0000000189B631E0-0x0000000189B63200
		protected virtual void OnConnnect(IConnection conn) {} // 0x00000001868FCB00-0x00000001868FCC60
		// [XID] // 0x0000000189B6AAF0-0x0000000189B6AB10
		protected virtual void OnDisconnect(IConnection conn) {} // 0x00000001868FCC60-0x00000001868FCDF0
		// [XID] // 0x00000001897039C0-0x00000001897039E0
		protected virtual int ProcessData(IConnection connection, ByteBuffer buffer) => default; // 0x00000001868FD580-0x00000001868FD700
		// [XID] // 0x0000000189B79710-0x0000000189B79730
		private string GetRemoteEndPoint(Socket socket) => default; // 0x00000001868FC560-0x00000001868FC740
		// [XID] // 0x0000000189B80A70-0x0000000189B80A90
		private void OnSocketConnected(Socket socket) {} // 0x00000001868FCDF0-0x00000001868FD580
		// [XID] // 0x0000000189B88660-0x0000000189B88680
		private void SocketClose(Socket socket) {} // 0x00000001868FDA00-0x00000001868FDAD0
		// [XID] // 0x0000000189B21350-0x0000000189B21370
		private void ReceiveBuffer(IConnection connection, ByteBuffer buffer) {} // 0x00000001868FD700-0x00000001868FD820
		// [XID] // 0x0000000189B96E20-0x0000000189B96E40
		private bool ReceiveData(IConnection connection, ArraySegment<byte> data) => default; // 0x00000001868FD820-0x00000001868FDA00
		// [XID] // 0x0000000189AFB840-0x0000000189AFB860
		private void OnClientConnected(IConnection connection) {} // 0x00000001868FC740-0x00000001868FC970
		// [XID] // 0x0000000189BA5BF0-0x0000000189BA5C10
		private void OnClientDisconnected(IConnection connection) {} // 0x00000001868FC970-0x00000001868FCB00
	}
}
