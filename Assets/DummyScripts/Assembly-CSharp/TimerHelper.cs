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

public static class TimerHelper // TypeDefIndex: 31801
{
	// Fields
	public static Dictionary<System.Type, TimerPool> _timerMap; // 0x00

	// Constructors
	static TimerHelper() {} // 0x000000018125DBA0-0x000000018125DC30

	// Methods
	public static T Allocate<T>()
		where T : NormalTimer, new() => default;
	public static void Deallocate<T>(ref T timer)
		where T : NormalTimer {}
	// [XID] // 0x0000000189AD3C20-0x0000000189AD3C40
	public static void Clear() {} // 0x000000018125DAC0-0x000000018125DBA0
}

