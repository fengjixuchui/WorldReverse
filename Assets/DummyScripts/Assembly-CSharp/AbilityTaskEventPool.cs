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

public static class AbilityTaskEventPool // TypeDefIndex: 20595
{
	// Fields
	private static Queue<AbilityTaskEvent>[] _pool; // 0x00

	// Constructors
	static AbilityTaskEventPool() {} // 0x00000001835BE270-0x00000001835BE2F0

	// Methods
	public static T Alloc<T>(AbilityEventID evtID)
		where T : AbilityTaskEvent, new() => default;
	// [XID] // 0x0000000189666A10-0x0000000189666A30
	public static void Dealloc(ref AbilityTaskEvent evt) {} // 0x00000001835BE050-0x00000001835BE270
}

