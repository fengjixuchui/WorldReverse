/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace WebSocketSharp.Net
{
	internal class HttpStreamAsyncResult : IAsyncResult // TypeDefIndex: 10270
	{
		// Fields
		private byte[] _buffer; // 0x10
		private AsyncCallback _callback; // 0x18
		private bool _completed; // 0x20
		private int _count; // 0x24
		private Exception _exception; // 0x28
		private int _offset; // 0x30
		private object _state; // 0x38
		private object _sync; // 0x40
		private int _syncRead; // 0x48
		private ManualResetEvent _waitHandle; // 0x50
	
		// Properties
		internal byte[] Buffer { /* [XID] */ /* 0x0000000189747040-0x0000000189747060 */ get => default; /* [XID] */ /* 0x00000001897D2C60-0x00000001897D2C80 */ set {} } // 0x0000000187179760-0x0000000187179800 0x0000000187179CD0-0x0000000187179D80
		internal int Count { /* [XID] */ /* 0x000000018978E560-0x000000018978E580 */ get => default; /* [XID] */ /* 0x000000018975D1A0-0x000000018975D1C0 */ set {} } // 0x00000001871798B0-0x0000000187179950 0x0000000187179D80-0x0000000187179E30
		internal Exception Exception { /* [XID] */ /* 0x0000000189764920-0x0000000189764940 */ get => default; } // 0x0000000187179950-0x00000001871799F0 
		internal bool HasException { /* [XID] */ /* 0x000000018976C3C0-0x000000018976C3E0 */ get => default; } // 0x00000001871799F0-0x0000000187179AA0 
		internal int Offset { /* [XID] */ /* 0x0000000189773860-0x0000000189773880 */ get => default; /* [XID] */ /* 0x000000018977F4C0-0x000000018977F4E0 */ set {} } // 0x0000000187179B90-0x0000000187179C30 0x0000000187179E30-0x0000000187179EE0
		internal int SyncRead { /* [XID] */ /* 0x0000000189782BA0-0x0000000189782BC0 */ get => default; /* [XID] */ /* 0x00000001897DA9C0-0x00000001897DA9E0 */ set {} } // 0x0000000187179C30-0x0000000187179CD0 0x0000000187179EE0-0x0000000187179F90
		public object AsyncState { /* [XID] */ /* 0x0000000189791610-0x0000000189791630 */ get => default; } // 0x0000000187179550-0x00000001871795F0 
		public WaitHandle AsyncWaitHandle { /* [XID] */ /* 0x00000001895F6C20-0x00000001895F6C40 */ get => default; } // 0x00000001871795F0-0x0000000187179760 
		public bool CompletedSynchronously { /* [XID] */ /* 0x000000018968D3F0-0x000000018968D410 */ get => default; } // 0x0000000187179800-0x00000001871798B0 
		public bool IsCompleted { /* [XID] */ /* 0x00000001897A8230-0x00000001897A8250 */ get => default; } // 0x0000000187179AA0-0x0000000187179B90 
	
		// Constructors
		public HttpStreamAsyncResult() {} // Dummy constructor
		internal HttpStreamAsyncResult(AsyncCallback callback, object state) {} // 0x00000001871794B0-0x0000000187179550
	
		// Methods
		// [IDTag] // 0x00000001897AFCF0-0x00000001897AFD30
		// [XID] // 0x00000001897AFCF0-0x00000001897AFD30
		internal void Complete() {} // 0x00000001871791D0-0x0000000187179370
		// [IDTag] // 0x00000001897BA800-0x00000001897BA840
		// [XID] // 0x00000001897BA800-0x00000001897BA840
		internal void Complete(Exception exception) {} // 0x0000000187179370-0x0000000187179430
	}
}
