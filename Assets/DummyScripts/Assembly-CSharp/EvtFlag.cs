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

public sealed class EvtFlag : BaseLevelEvent, IAutoAllocRecycle // TypeDefIndex: 20114
{
	// Fields
	public FlagType flag; // 0x30

	// Nested types
	public enum FlagType // TypeDefIndex: 20115
	{
		RageUp = 0,
		RageDown = 1,
		StaminaEmpty = 2
	}

	// Constructors
	public EvtFlag() {} // 0x00000001850677C0-0x0000000185067820

	// Methods
	[BlackList] // 0x0000000189A34DF0-0x0000000189A34E30
	// [XID] // 0x0000000189A34DF0-0x0000000189A34E30
	public override void AutoAllocTypeFields() {} // 0x0000000185067290-0x0000000185067330
	[BlackList] // 0x0000000189A3F540-0x0000000189A3F580
	// [XID] // 0x0000000189A3F540-0x0000000189A3F580
	public override void AutoRecycleTypeFields() {} // 0x0000000185067330-0x00000001850673E0
	[BlackList] // 0x0000000189A49A80-0x0000000189A49AC0
	// [XID] // 0x0000000189A49A80-0x0000000189A49AC0
	public override void ReturnToObjectPool() {} // 0x0000000185067630-0x00000001850676D0
	// [XID] // 0x0000000189A542D0-0x0000000189A542F0
	public void Init(FlagType flag) {} // 0x00000001850674B0-0x0000000185067570
	// [XID] // 0x0000000189A5BDA0-0x0000000189A5BDC0
	public override string ToString() => default; // 0x00000001850676D0-0x00000001850677C0
}

