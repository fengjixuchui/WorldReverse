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

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole.AsyncNetwork
{
	public class NetListener // TypeDefIndex: 10674
	{
		// Fields
		private const bool _enableLog = true; // Metadata: 0x00AE8087
		private Socket _socket; // 0x10
		private const int _failedRetryCountDefault = 5; // Metadata: 0x00AE8088
		private int _failedRetryCount; // 0x18
		public Action<Socket> onConnected; // 0x20
	
		// Properties
		public SyncContext context { /* [XID] */ /* 0x0000000189603400-0x0000000189603440 */ get; private set; } // 0x0000000186903B60-0x0000000186903BC0 0x0000000186903C20-0x0000000186903C80
		public EndPoint bindAddress { /* [XID] */ /* 0x00000001896153F0-0x0000000189615430 */ get; /* [XID] */ /* 0x000000018961FBB0-0x000000018961FBF0 */ private set; } // 0x0000000186903B00-0x0000000186903B60 0x0000000186903BC0-0x0000000186903C20
		public bool IsClosed { /* [XID] */ /* 0x000000018999FB90-0x000000018999FBB0 */ get => default; } // 0x0000000186903A50-0x0000000186903B00 
	
		// Constructors
		public NetListener() {} // Dummy constructor
		public NetListener(SyncContext ctx) {} // 0x00000001869039A0-0x0000000186903A50
	
		// Methods
		// [XID] // 0x0000000189631920-0x0000000189631940
		public void Listen(EndPoint address) {} // 0x00000001869034F0-0x00000001869038C0
		// [XID] // 0x00000001897975B0-0x00000001897975D0
		public virtual void Close() {} // 0x0000000186903420-0x00000001869034F0
		// [XID] // 0x00000001897AE200-0x00000001897AE220
		private void Accept() {} // 0x0000000186902F60-0x0000000186903110
		// [XID] // 0x00000001896480E0-0x0000000189648100
		private void AsyncAcceptCallback(IAsyncResult ar) {} // 0x0000000186903110-0x0000000186903420
	}
}
