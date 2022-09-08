/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
	public class EventDispatcherWithEventQueue : MEventDispatcherNonGeneric // TypeDefIndex: 10542
	{
		// Fields
		private HashSet<object> _eventDuplicationChecker; // 0x18
		private Queue<IDispatchableEvent> _eventQueue; // 0x20
	
		// Properties
		public int eventCount { /* [XID] */ /* 0x00000001899A0C30-0x00000001899A0C50 */ get => default; } // 0x00000001858F66A0-0x00000001858F6760 
	
		// Constructors
		public EventDispatcherWithEventQueue() {} // 0x00000001858F6580-0x00000001858F66A0
	
		// Methods
		// [XID] // 0x0000000189639340-0x0000000189639360
		public void QueueEvent(IDispatchableEvent inEvent) {} // 0x00000001858F63D0-0x00000001858F6520
		// [XID] // 0x00000001895FD150-0x00000001895FD170
		public void ProcessAllQueuedEvents() {} // 0x00000001858F6250-0x00000001858F63D0
		// [XID] // 0x00000001899B7160-0x00000001899B7180
		public override void ClearAll() {} // 0x00000001858F6170-0x00000001858F6250
	}
}
