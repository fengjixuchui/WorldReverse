/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class EventHelper // TypeDefIndex: 20548
{
	// Methods
	public static T Allocate<T>()
		where T : BaseEvent, new() => default;
	// [XID] // 0x0000000189726AC0-0x0000000189726AE0
	public static void Deallocate(BaseEvent evt) {} // 0x0000000185070180-0x0000000185070250
	// [XID] // 0x000000018972DFF0-0x000000018972E010
	public static void Clear() {} // 0x0000000185070250-0x00000001850702E0
	public static T ShallowClone<T>(T sourceEvent)
		where T : BaseEvent, new() => default;
}

