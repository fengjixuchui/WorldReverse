/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class RuntimeDebugMonitor // TypeDefIndex: 27775
{
	// Fields
	private static TimeData _gameTime; // 0x00
	private static TimeData _renderTime; // 0x18
	private static TimeData _waitPresent; // 0x30
	private static IEnumerator _coroutimeFrameStats; // 0x48
	private static float _updateTime; // 0x50
	private static float _timer; // 0x54
	private static bool _enable; // 0x58

	// Properties
	public static double gameTime { /* [XID] */ /* 0x0000000189B104E0-0x0000000189B10500 */ get => default; } // 0x00000001807876B0-0x0000000180787780 
	public static double renderTime { /* [XID] */ /* 0x0000000189B176A0-0x0000000189B176C0 */ get => default; } // 0x0000000180787DD0-0x0000000180787EA0 
	public static double waitPresent { /* [XID] */ /* 0x0000000189B1EF30-0x0000000189B1EF50 */ get => default; } // 0x0000000180788180-0x0000000180788250 
	public static float updateTime { /* [XID] */ /* 0x0000000189B268B0-0x0000000189B268D0 */ get => default; /* [XID] */ /* 0x0000000189B2DA80-0x0000000189B2DAA0 */ set {} } // 0x0000000180788250-0x0000000180788320 0x0000000180787D00-0x0000000180787DD0

	// Nested types
	private struct TimeData // TypeDefIndex: 27776
	{
		// Fields
		public double time; // 0x00
		public double max; // 0x08
		public double current; // 0x10
	}

	// Constructors
	public RuntimeDebugMonitor() {} // 0x00000001807883A0-0x0000000180788400
	static RuntimeDebugMonitor() {} // 0x0000000180788320-0x00000001807883A0

	// Methods
	// [XID] // 0x0000000189B34E80-0x0000000189B34EA0
	public static void GetTime() {} // 0x0000000180787780-0x0000000180787940
	// [XID] // 0x0000000189B3C750-0x0000000189B3C770
	public static void Enable(bool value) {} // 0x0000000180787940-0x0000000180787A80
	// [XID] // 0x0000000189B444B0-0x0000000189B444D0
	public static void Tick() {} // 0x0000000180787B70-0x0000000180787D00
	[DebuggerHidden] // 0x0000000189B4BB70-0x0000000189B4BBB0
	// [XID] // 0x0000000189B4BB70-0x0000000189B4BBB0
	private static IEnumerator CoroutineFrameStats() => default; // 0x0000000180787A80-0x0000000180787B70
	// [XID] // 0x0000000189B56400-0x0000000189B56420
	private static void UpdateTime(bool force) {} // 0x0000000180787EA0-0x0000000180788180
}

