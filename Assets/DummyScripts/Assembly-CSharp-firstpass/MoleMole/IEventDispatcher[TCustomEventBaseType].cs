/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
	public interface IEventDispatcher<TCustomEventBaseType> // TypeDefIndex: 10538
		where TCustomEventBaseType : class, IDispatchableEvent
	{
		// Methods
		void AddEventListener<T>(Action<T> action)
			where T : class, IDispatchableEvent;
		void RemoveEventListener<T>(Action<T> action)
			where T : class, IDispatchableEvent;
		void FireEventToDispatch(TCustomEventBaseType args);
	}
}
