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

namespace MoleMole.AsyncNetwork
{
	public class SyncContext : SynchronizationContext // TypeDefIndex: 10677
	{
		// Fields
		private int _eventProcessCountMax; // 0x10
		private readonly AtomicPipe<Event> _events; // 0x18
		private readonly AutoResetEvent _wakeEvent; // 0x20
		private SynchronizationContext _oldContext; // 0x28
	
		// Properties
		public static new SyncContext Current { /* [XID] */ /* 0x0000000189A64D40-0x0000000189A64D60 */ get => default; } // 0x0000000186906540-0x0000000186906620 
	
		// Nested types
		private struct Event // TypeDefIndex: 10678
		{
			// Fields
			public SendOrPostCallback callback; // 0x00
			public object state; // 0x08
	
			// Constructors
			public Event(SendOrPostCallback callback, object state) {
				this.callback = default;
				this.state = default;
			} // 0x0000000186902940-0x0000000186902AF0
		}
	
		// Constructors
		public SyncContext() {} // 0x0000000186906480-0x0000000186906540
	
		// Methods
		// [XID] // 0x00000001896AF640-0x00000001896AF660
		public override void Send(SendOrPostCallback d, object state) {} // 0x0000000186906270-0x0000000186906360
		// [IDTag] // 0x00000001896B6D60-0x00000001896B6DA0
		// [XID] // 0x00000001896B6D60-0x00000001896B6DA0
		public override void Post(SendOrPostCallback d, object state) {} // 0x0000000186905F50-0x0000000186906130
		// [XID] // 0x00000001896C1000-0x00000001896C1020
		private static void ActionCallback(object state) {} // 0x0000000186905C10-0x0000000186905CF0
		// [IDTag] // 0x00000001896C8560-0x00000001896C85A0
		// [XID] // 0x00000001896C8560-0x00000001896C85A0
		public void Post(Action action) {} // 0x0000000186906130-0x0000000186906270
		// [XID] // 0x0000000189B24540-0x0000000189B24560
		public void LoopOnce() {} // 0x0000000186905CF0-0x0000000186905E00
		// [XID] // 0x00000001897BE080-0x00000001897BE0A0
		public void Loop() {} // 0x0000000186905E00-0x0000000186905F50
	}
}
