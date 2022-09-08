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

public class TimerPool // TypeDefIndex: 31800
{
	// Fields
	private Stack<NormalTimer> _cache; // 0x10

	// Constructors
	public TimerPool() {} // 0x00000001839D47D0-0x00000001839D4830

	// Methods
	public T Allocate<T>()
		where T : NormalTimer, new() => default;
	public void Deallocate<T>(T instance)
		where T : NormalTimer {}
	// [XID] // 0x0000000189ACC140-0x0000000189ACC160
	public void ReleaseAllCache() {} // 0x00000001839D4720-0x00000001839D47D0
}

