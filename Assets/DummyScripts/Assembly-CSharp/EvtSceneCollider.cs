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
using UnityEngine;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EvtSceneCollider : BaseLevelEvent, IAutoAllocRecycle // TypeDefIndex: 20157
{
	// Fields
	public uint entityRuntimeID; // 0x30
	public List<Bounds> bounds; // 0x38
	public bool enable; // 0x40
	public bool refreshImmediately; // 0x41
	public bool forceUp; // 0x42

	// Constructors
	public EvtSceneCollider() {} // 0x0000000183145830-0x0000000183145890

	// Methods
	[BlackList] // 0x00000001897CEF40-0x00000001897CEF80
	// [XID] // 0x00000001897CEF40-0x00000001897CEF80
	public override void AutoAllocTypeFields() {} // 0x0000000183145200-0x00000001831452A0
	[BlackList] // 0x00000001897D9DB0-0x00000001897D9DF0
	// [XID] // 0x00000001897D9DB0-0x00000001897D9DF0
	public override void AutoRecycleTypeFields() {} // 0x00000001831452A0-0x0000000183145350
	[BlackList] // 0x00000001897E41D0-0x00000001897E4210
	// [XID] // 0x00000001897E41D0-0x00000001897E4210
	public override void ReturnToObjectPool() {} // 0x00000001831456B0-0x0000000183145750
	// [IDTag] // 0x00000001897EEC80-0x00000001897EECC0
	// [XID] // 0x00000001897EEC80-0x00000001897EECC0
	public new void Init(uint entityRuntimeID) {} // 0x0000000183145530-0x00000001831455F0
	// [IDTag] // 0x00000001897F9670-0x00000001897F96B0
	// [XID] // 0x00000001897F9670-0x00000001897F96B0
	public void Init(uint entityRuntimeID, List<Bounds> bounds, bool enable, bool refreshImmediately, bool forceUp) {} // 0x0000000183145420-0x0000000183145530
	// [XID] // 0x0000000189803C90-0x0000000189803CB0
	public override string ToString() => default; // 0x0000000183145750-0x0000000183145830
}

