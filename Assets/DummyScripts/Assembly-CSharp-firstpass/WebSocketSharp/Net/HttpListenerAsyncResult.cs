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
	internal class HttpListenerAsyncResult : IAsyncResult // TypeDefIndex: 10257
	{
		// Fields
		private AsyncCallback _callback; // 0x10
		private bool _completed; // 0x18
		private HttpListenerContext _context; // 0x20
		private bool _endCalled; // 0x28
		private Exception _exception; // 0x30
		private bool _inGet; // 0x38
		private object _state; // 0x40
		private object _sync; // 0x48
		private bool _syncCompleted; // 0x50
		private ManualResetEvent _waitHandle; // 0x58
	
		// Properties
		internal bool EndCalled { /* [XID] */ /* 0x0000000189782AE0-0x0000000189782B00 */ get => default; /* [XID] */ /* 0x000000018989B470-0x000000018989B490 */ set {} } // 0x000000018716E200-0x000000018716E2A0 0x000000018716E430-0x000000018716E4E0
		internal bool InGet { /* [XID] */ /* 0x00000001898A2910-0x00000001898A2930 */ get => default; /* [XID] */ /* 0x00000001898A9EE0-0x00000001898A9F00 */ set {} } // 0x000000018716E2A0-0x000000018716E340 0x000000018716E4E0-0x000000018716E590
		public object AsyncState { /* [XID] */ /* 0x00000001898B1850-0x00000001898B1870 */ get => default; } // 0x000000018716DF50-0x000000018716DFF0 
		public WaitHandle AsyncWaitHandle { /* [XID] */ /* 0x00000001898B9300-0x00000001898B9320 */ get => default; } // 0x000000018716DFF0-0x000000018716E160 
		public bool CompletedSynchronously { /* [XID] */ /* 0x00000001898C0820-0x00000001898C0840 */ get => default; } // 0x000000018716E160-0x000000018716E200 
		public bool IsCompleted { /* [XID] */ /* 0x00000001897A0A90-0x00000001897A0AB0 */ get => default; } // 0x000000018716E340-0x000000018716E430 
	
		// Constructors
		public HttpListenerAsyncResult() {} // Dummy constructor
		internal HttpListenerAsyncResult(AsyncCallback callback, object state) {} // 0x000000018716DC80-0x000000018716DD20
	
		// Methods
		// [XID] // 0x00000001897E4D30-0x00000001897E4D50
		private static void complete(HttpListenerAsyncResult asyncResult) {} // 0x000000018716DD20-0x000000018716DF50
		// [IDTag] // 0x00000001898D7090-0x00000001898D70D0
		// [XID] // 0x00000001898D7090-0x00000001898D70D0
		internal void Complete(Exception exception) {} // 0x000000018716DA90-0x000000018716DBC0
		// [IDTag] // 0x00000001898E1C80-0x00000001898E1CC0
		// [XID] // 0x00000001898E1C80-0x00000001898E1CC0
		internal void Complete(HttpListenerContext context) {} // 0x000000018716D9D0-0x000000018716DA90
		// [IDTag] // 0x00000001898EC4B0-0x00000001898EC4F0
		// [XID] // 0x00000001898EC4B0-0x00000001898EC4F0
		internal void Complete(HttpListenerContext context, bool syncCompleted) {} // 0x000000018716D900-0x000000018716D9D0
		// [XID] // 0x00000001897AFBB0-0x00000001897AFBD0
		internal HttpListenerContext GetContext() => default; // 0x000000018716DBC0-0x000000018716DC80
	}
}
