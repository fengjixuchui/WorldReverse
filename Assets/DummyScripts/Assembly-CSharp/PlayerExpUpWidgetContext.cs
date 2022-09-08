/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PlayerExpUpWidgetContext : BaseWidgetContext // TypeDefIndex: 29237
{
	// Fields
	private MonoPlayerExpUpWidget _monoWidget; // 0x168
	private float lastValue; // 0x170
	private float newValue; // 0x174
	private WidgetType type; // 0x178

	// Nested types
	public enum WidgetType // TypeDefIndex: 29238
	{
		Exp = 0,
		Level = 1
	}

	// Constructors
	public PlayerExpUpWidgetContext() {} // Dummy constructor
	public PlayerExpUpWidgetContext(float value, WidgetType t) {} // 0x0000000183D4D190-0x0000000183D4D230
	public PlayerExpUpWidgetContext(float lValue, float value, WidgetType t) {} // 0x0000000183D4D0E0-0x0000000183D4D190

	// Methods
	// [XID] // 0x00000001897B7FB0-0x00000001897B7FD0
	public void InitConfig() {} // 0x0000000183D4CDB0-0x0000000183D4CE80
	// [XID] // 0x00000001897C00D0-0x00000001897C00F0
	public override void SetupView() {} // 0x0000000183D4CE80-0x0000000183D4D0E0
	// [XID] // 0x00000001897C7900-0x00000001897C7920
	public override void ClearView() {} // 0x0000000183D4CC50-0x0000000183D4CCF0
}

