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
	public class MEventDispatcherNonGeneric : IEventDispatcherNonGeneric, IReusable // TypeDefIndex: 10540
	{
		// Fields
		private Dictionary<System.Type, IBaseEventCallbackHandler> _dicRegisterFuncCallback; // 0x10
	
		// Nested types
		public class EventHandler<T> : HashList<object>, IBaseEventCallbackHandler // TypeDefIndex: 10541
			where T : class, IDispatchableEvent
		{
			// Constructors
			public EventHandler() {}
	
			// Methods
			public void Invoke(IDispatchableEvent e) {}
			bool IBaseEventCallbackHandler.Empty() => default;
		}
	
		// Constructors
		public MEventDispatcherNonGeneric() {} // 0x0000000186C21980-0x0000000186C21B80
	
		// Methods
		public void AddEventListener<T>(Action<T> eventHandler)
			where T : class, IDispatchableEvent {}
		public void RemoveEventListener<T>(Action<T> callbackAction)
			where T : class, IDispatchableEvent {}
		// [XID] // 0x0000000189604B30-0x0000000189604B50
		public virtual void FireEventToDispatch(IDispatchableEvent args) {} // 0x0000000186C217F0-0x0000000186C21980
		public void ClearEventListener<T>()
			where T : class, IDispatchableEvent {}
		// [XID] // 0x00000001899917F0-0x0000000189991810
		public virtual void ClearAll() {} // 0x0000000186C215F0-0x0000000186C217F0
		// [XID] // 0x00000001899992A0-0x00000001899992C0
		public void BeforeRecycle() {} // 0x0000000186C21540-0x0000000186C215F0
	}
}
