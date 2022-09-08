/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class EventPool // TypeDefIndex: 20547
{
	// Fields
	private Stack<BaseEvent> _cache; // 0x10

	// Constructors
	public EventPool() {} // 0x00000001830E6190-0x00000001830E61F0

	// Methods
	public T Allocate<T>()
		where T : BaseEvent, new() => default;
	public void Deallocate<T>(T instance)
		where T : BaseEvent {}
	// [XID] // 0x000000018971F490-0x000000018971F4B0
	public void ReleaseAllCache() {} // 0x00000001830E60E0-0x00000001830E6190
}

