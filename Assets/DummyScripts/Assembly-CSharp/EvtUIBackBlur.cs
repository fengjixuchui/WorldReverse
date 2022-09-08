/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EvtUIBackBlur : BaseEvent, IAutoAllocRecycle // TypeDefIndex: 20177
{
	// Fields
	private OP _op; // 0x30

	// Properties
	public OP op { /* [XID] */ /* 0x0000000189A7DCE0-0x0000000189A7DD00 */ get => default; } // 0x0000000181DA7530-0x0000000181DA75D0 

	// Nested types
	public enum OP // TypeDefIndex: 20178
	{
		INVALID = -1,
		START = 0,
		FINISH = 8
	}

	// Constructors
	public EvtUIBackBlur() {} // 0x0000000181DA76D0-0x0000000181DA7740

	// Methods
	[BlackList] // 0x0000000189B08DF0-0x0000000189B08E30
	// [XID] // 0x0000000189B08DF0-0x0000000189B08E30
	public override void AutoAllocTypeFields() {} // 0x0000000181DA7240-0x0000000181DA72E0
	[BlackList] // 0x0000000189B13400-0x0000000189B13440
	// [XID] // 0x0000000189B13400-0x0000000189B13440
	public override void AutoRecycleTypeFields() {} // 0x0000000181DA72E0-0x0000000181DA7390
	[BlackList] // 0x0000000189B1D7D0-0x0000000189B1D810
	// [XID] // 0x0000000189B1D7D0-0x0000000189B1D810
	public override void ReturnToObjectPool() {} // 0x0000000181DA7630-0x0000000181DA76D0
	// [XID] // 0x0000000189B2F230-0x0000000189B2F250
	public void Init(uint targetID, OP op) {} // 0x0000000181DA73F0-0x0000000181DA74D0
}

