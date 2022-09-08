/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using MoleMole;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole.AsyncNetwork
{
	public class Connection : IConnection // TypeDefIndex: 10667
	{
		// Fields
		private bool _enableLog; // 0x10
		private const int _maxSendSize = 1048576; // Metadata: 0x00AE8068
		private const int _defalutReceiveBufferSize = 65536; // Metadata: 0x00AE806C
		private Socket _socket; // 0x18
		private EndPoint _remoteAddress; // 0x20
		private bool _socketError; // 0x28
		private EndPoint _address; // 0x30
		private ConnectState _connectState; // 0x38
		private byte[] _receiveBuffer; // 0x40
		private int _receiveBufferOffset; // 0x48
		private int _receiveBufferSize; // 0x4C
		private readonly ByteBuffer _sendingBuffer; // 0x50
		private readonly ByteBuffer _sendingCache; // 0x58
		private bool _receiveAsyncInprogress; // 0x60
		private bool _sendAsyncInprogress; // 0x61
		private Action _sendActoin; // 0x68
	
		// Properties
		public Func<IConnection, ArraySegment<byte>, bool> receiveCallback { /* [XID] */ /* 0x0000000189959A50-0x0000000189959A90 */ get; set; } // 0x0000000186901CD0-0x0000000186901D30 0x0000000186901E70-0x0000000186901FC0
		internal Action<IConnection> connectedCallback { /* [XID] */ /* 0x000000018996BA30-0x000000018996BA70 */ get; /* [XID] */ /* 0x0000000189976350-0x0000000189976390 */ set; } // 0x0000000186901BB0-0x0000000186901C10 0x0000000186901D30-0x0000000186901D90
		internal Action<IConnection> disconnectedCallback { /* [XID] */ /* 0x00000001899809E0-0x0000000189980A20 */ get; /* [XID] */ /* 0x000000018998B6A0-0x000000018998B6E0 */ set; } // 0x0000000186901C70-0x0000000186901CD0 0x0000000186901E00-0x0000000186901E70
		internal SyncContext context { /* [XID] */ /* 0x0000000189996120-0x0000000189996160 */ get; private set; } // 0x0000000186901C10-0x0000000186901C70 0x0000000186901D90-0x0000000186901E00
	
		// Nested types
		private enum ConnectState // TypeDefIndex: 10668
		{
			Idle = 0,
			Connecting = 1,
			Connected = 2,
			Disconnect = 3
		}
	
		// Constructors
		public Connection() {} // Dummy constructor
		public Connection(SyncContext syncContext) {} // 0x0000000186901A50-0x0000000186901BB0
		public Connection(SyncContext syncContext, EndPoint addr) {} // 0x00000001869019C0-0x0000000186901A50
	
		// Methods
		// [IDTag] // 0x00000001899A8560-0x00000001899A85A0
		// [XID] // 0x00000001899A8560-0x00000001899A85A0
		public void Connect(EndPoint addr) {} // 0x00000001868FEE80-0x00000001868FEF40
		// [XID] // 0x00000001897B7FF0-0x00000001897B8010
		public void Flush() {} // 0x00000001868FF1F0-0x00000001868FF310
		// [IDTag] // 0x00000001899BA1D0-0x00000001899BA210
		// [XID] // 0x00000001899BA1D0-0x00000001899BA210
		public void Send(byte[] msg, bool flush = true /* Metadata: 0x00AE8065 */) {} // 0x00000001869018B0-0x00000001869019C0
		// [IDTag] // 0x00000001899C4D50-0x00000001899C4D90
		// [XID] // 0x00000001899C4D50-0x00000001899C4D90
		public void Send(string msg, bool flush = true /* Metadata: 0x00AE8066 */) {} // 0x00000001869017D0-0x00000001869018B0
		// [IDTag] // 0x00000001899CF470-0x00000001899CF4B0
		// [XID] // 0x00000001899CF470-0x00000001899CF4B0
		public void Send(ArraySegment<byte> msg, bool flush = true /* Metadata: 0x00AE8067 */) {} // 0x0000000186901630-0x00000001869017D0
		// [XID] // 0x000000018996D9F0-0x000000018996DA10
		public void Close() {} // 0x00000001868FEBC0-0x00000001868FED40
		// [XID] // 0x000000018972F6F0-0x000000018972F710
		public bool IsSending() => default; // 0x00000001868FF9B0-0x00000001868FFA90
		// [XID] // 0x00000001899E8AE0-0x00000001899E8B00
		public bool IsConnecting() => default; // 0x00000001868FF850-0x00000001868FF900
		// [XID] // 0x0000000189668380-0x00000001896683A0
		public bool IsConnected() => default; // 0x00000001868FF7A0-0x00000001868FF850
		// [XID] // 0x00000001899F7850-0x00000001899F7870
		public bool IsDisconnect() => default; // 0x00000001868FF900-0x00000001868FF9B0
		// [XID] // 0x0000000189AB7510-0x0000000189AB7530
		public string GetName() => default; // 0x00000001868FF310-0x00000001868FF400
		// [IDTag] // 0x0000000189A067E0-0x0000000189A06820
		// [XID] // 0x0000000189A067E0-0x0000000189A06820
		internal bool Connect(Socket s) => default; // 0x00000001868FED40-0x00000001868FEE80
		// [XID] // 0x0000000189686510-0x0000000189686530
		private void Initialize() {} // 0x00000001868FF4D0-0x00000001868FF7A0
		// [XID] // 0x0000000189966610-0x0000000189966630
		private void Disconnect() {} // 0x00000001868FEF40-0x00000001868FF0D0
		// [XID] // 0x000000018967EC20-0x000000018967EC40
		private void InitSocket(Socket s) {} // 0x00000001868FF400-0x00000001868FF4D0
		// [XID] // 0x00000001895F9650-0x00000001895F9670
		private void CheckReceiveBuffer() {} // 0x00000001868FE920-0x00000001868FEA00
		// [XID] // 0x0000000189ADD8D0-0x0000000189ADD8F0
		private bool CheckError() => default; // 0x00000001868FE6A0-0x00000001868FE920
		// [XID] // 0x000000018997C730-0x000000018997C750
		private void CheckReceive() {} // 0x00000001868FEA00-0x00000001868FEAD0
		// [XID] // 0x0000000189624950-0x0000000189624970
		private void CheckSend() {} // 0x00000001868FEAD0-0x00000001868FEBC0
		// [XID] // 0x0000000189A448F0-0x0000000189A44910
		private void CheckConnection() {} // 0x00000001868FE110-0x00000001868FE6A0
		// [XID] // 0x0000000189600DA0-0x0000000189600DC0
		private void ProcessReceiveData(int size) {} // 0x00000001869000E0-0x0000000186900390
		// [XID] // 0x0000000189AA6B60-0x0000000189AA6B80
		private void PrepareSendBuffer() {} // 0x00000001868FFEF0-0x00000001869000E0
		// [XID] // 0x00000001897B3920-0x00000001897B3940
		private void SendData() {} // 0x0000000186901200-0x0000000186901630
		// [XID] // 0x0000000189A626E0-0x0000000189A62700
		private void ReceiveData() {} // 0x0000000186900840-0x0000000186900E80
		// [XID] // 0x0000000189A6A4E0-0x0000000189A6A500
		private void ReceiveAsyncCallback(IAsyncResult ar) {} // 0x0000000186900390-0x0000000186900840
		// [XID] // 0x0000000189A718D0-0x0000000189A718F0
		private void SendAsyncCallback(IAsyncResult ar) {} // 0x0000000186900E80-0x0000000186901200
		// [XID] // 0x000000018960E580-0x000000018960E5A0
		private void FlushInternal() {} // 0x00000001868FF0D0-0x00000001868FF1F0
		// [XID] // 0x0000000189A80B20-0x0000000189A80B40
		private void OnConnected() {} // 0x00000001868FFA90-0x00000001868FFCE0
		// [XID] // 0x000000018966FE50-0x000000018966FE70
		private void OnDisconnected() {} // 0x00000001868FFCE0-0x00000001868FFEF0
	}
}
