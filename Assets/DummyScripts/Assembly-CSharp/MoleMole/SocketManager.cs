/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole.AsyncNetwork;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[LuaCallCSharp] // 0x0000000189BA67A0-0x0000000189BA67C0
	public sealed class SocketManager : GlobalManager // TypeDefIndex: 21319
	{
		// Fields
		private const int SOCKET_PORT = 6666; // Metadata: 0x00AFF44C
		private ConnectionManager _server; // 0x10
		private IConnection _defaultConnection; // 0x18
		private IConnection _currentConnection; // 0x20
		private HashSet<IConnection> _connectionSet; // 0x28
		private static SyncContext _serverContext; // 0x00
		private AtomicPipe<Message> _messageQueue; // 0x30
		private static int _messageProcessCountMax; // 0x08
		private SocketMgrTask _socketMgrTask; // 0x38
		private bool _clientFlag; // 0x40
	
		// Properties
		public IConnection CurrentConnection { /* [XID] */ /* 0x000000018978C130-0x000000018978C150 */ get => default; } // 0x0000000182B169E0-0x0000000182B16A80 
	
		// Nested types
		private enum Token // TypeDefIndex: 21320
		{
			End2 = 10,
			End1 = 13
		}
	
		private class Message // TypeDefIndex: 21321
		{
			// Fields
			public IConnection connection; // 0x10
			public string command; // 0x18
	
			// Constructors
			public Message() {} // 0x0000000182B120F0-0x0000000182B12150
		}
	
		// Constructors
		public SocketManager() {} // 0x0000000182B16920-0x0000000182B169E0
		static SocketManager() {} // 0x0000000182B168C0-0x0000000182B16920
	
		// Methods
		// [XID] // 0x0000000189793660-0x0000000189793680
		public override void Init() {} // 0x0000000182B15540-0x0000000182B157F0
		// [XID] // 0x000000018979B890-0x000000018979B8B0
		public override void ClearOnLevelDestroy() {} // 0x0000000182B15270-0x0000000182B15310
		// [XID] // 0x00000001897A2C80-0x00000001897A2CA0
		public override void Tick() {} // 0x0000000182B16450-0x0000000182B16860
		// [XID] // 0x00000001897AA2E0-0x00000001897AA300
		public override void ReloadRes() {} // 0x0000000182B16170-0x0000000182B16210
		// [XID] // 0x00000001897B1CF0-0x00000001897B1D10
		public override void Destroy() {} // 0x0000000182B153E0-0x0000000182B15540
		// [XID] // 0x00000001897B9770-0x00000001897B9790
		public void QueueAutoTestJob(IAsyncExecutor ae) {} // 0x0000000182B160B0-0x0000000182B16170
		// [IDTag] // 0x00000001897C17A0-0x00000001897C17F0
		[LuaCallCSharp] // 0x00000001897C17A0-0x00000001897C17F0
		// [XID] // 0x00000001897C17A0-0x00000001897C17F0
		public void SendString(string str) {} // 0x0000000182B16330-0x0000000182B16450
		// [IDTag] // 0x00000001897CEE50-0x00000001897CEEA0
		[LuaCallCSharp] // 0x00000001897CEE50-0x00000001897CEEA0
		// [XID] // 0x00000001897CEE50-0x00000001897CEEA0
		public void SendString(IConnection connection, string str) {} // 0x0000000182B16210-0x0000000182B16330
		// [XID] // 0x00000001897DC650-0x00000001897DC670
		public void CheckConnect() {} // 0x0000000182B151A0-0x0000000182B15270
		// [XID] // 0x00000001897E4050-0x00000001897E4070
		public bool Contains(IConnection conn) => default; // 0x0000000182B15310-0x0000000182B153E0
		// [XID] // 0x00000001897EBBC0-0x00000001897EBBE0
		private void Bind() {} // 0x0000000182B14FA0-0x0000000182B151A0
		// [XID] // 0x00000001897F3490-0x00000001897F34B0
		private int OnProcessData(IConnection conn, ByteBuffer buffer) => default; // 0x0000000182B15AE0-0x0000000182B15DE0
		// [XID] // 0x00000001897FAE90-0x00000001897FAEB0
		private void ProcessBuffer(IConnection connection, ByteBuffer buffer, int size) {} // 0x0000000182B15DE0-0x0000000182B160B0
		// [XID] // 0x0000000189802390-0x00000001898023B0
		private void OnClientConnnect(IConnection conn) {} // 0x0000000182B157F0-0x0000000182B15A00
		// [XID] // 0x00000001898097C0-0x00000001898097E0
		private void OnClientDisconnnect(IConnection conn) {} // 0x0000000182B15A00-0x0000000182B15AE0
	}
}
