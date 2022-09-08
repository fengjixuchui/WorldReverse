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

public sealed class EvtFieldExit : BaseEvent, IAutoAllocRecycle // TypeDefIndex: 20113
{
	// Fields
	public uint runtimeId; // 0x30
	public TriggerFlag flag; // 0x34
	public ConfigLocalTrigger config; // 0x38

	// Constructors
	public EvtFieldExit() {} // 0x0000000183934C50-0x0000000183934CB0

	// Methods
	[BlackList] // 0x0000000189A07020-0x0000000189A07060
	// [XID] // 0x0000000189A07020-0x0000000189A07060
	public override void AutoAllocTypeFields() {} // 0x00000001839346C0-0x0000000183934760
	[BlackList] // 0x0000000189A11820-0x0000000189A11860
	// [XID] // 0x0000000189A11820-0x0000000189A11860
	public override void AutoRecycleTypeFields() {} // 0x0000000183934760-0x0000000183934810
	[BlackList] // 0x0000000189A1B950-0x0000000189A1B990
	// [XID] // 0x0000000189A1B950-0x0000000189A1B990
	public override void ReturnToObjectPool() {} // 0x0000000183934AB0-0x0000000183934B50
	// [XID] // 0x0000000189A25F90-0x0000000189A25FB0
	public void Init(uint targetID, uint runtimeId, TriggerFlag flag = TriggerFlag.None /* Metadata: 0x00AFD262 */, ConfigLocalTrigger config = null) {} // 0x00000001839348E0-0x00000001839349F0
	// [XID] // 0x0000000189A2D330-0x0000000189A2D350
	public override string ToString() => default; // 0x0000000183934B50-0x0000000183934C50
}

