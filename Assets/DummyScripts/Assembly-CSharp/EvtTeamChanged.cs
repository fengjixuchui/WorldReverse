/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EvtTeamChanged : BaseLevelEvent, IAutoAllocRecycle // TypeDefIndex: 20171
{
	// Fields
	public List<ulong> lastTeamList; // 0x30
	public List<ulong> curTeamList; // 0x38

	// Constructors
	public EvtTeamChanged() {} // 0x0000000183227690-0x00000001832276F0

	// Methods
	[BlackList] // 0x0000000189A201F0-0x0000000189A20230
	// [XID] // 0x0000000189A201F0-0x0000000189A20230
	public override void AutoAllocTypeFields() {} // 0x0000000183227150-0x00000001832271F0
	[BlackList] // 0x0000000189A2A500-0x0000000189A2A540
	// [XID] // 0x0000000189A2A500-0x0000000189A2A540
	public override void AutoRecycleTypeFields() {} // 0x00000001832271F0-0x00000001832272A0
	[BlackList] // 0x0000000189A34DB0-0x0000000189A34DF0
	// [XID] // 0x0000000189A34DB0-0x0000000189A34DF0
	public override void ReturnToObjectPool() {} // 0x0000000183227510-0x00000001832275B0
	// [XID] // 0x0000000189A3F500-0x0000000189A3F520
	public void Init(List<ulong> lastTeamList, List<ulong> curTeamList) {} // 0x0000000183227370-0x0000000183227450
	// [XID] // 0x0000000189A46B30-0x0000000189A46B50
	public override string ToString() => default; // 0x00000001832275B0-0x0000000183227690
}

