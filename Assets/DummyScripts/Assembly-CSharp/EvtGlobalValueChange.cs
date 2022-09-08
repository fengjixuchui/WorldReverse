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

public sealed class EvtGlobalValueChange : BaseEvent, IAutoAllocRecycle // TypeDefIndex: 20121
{
	// Fields
	public uint key; // 0x30
	public float delta; // 0x34

	// Constructors
	public EvtGlobalValueChange() {} // 0x0000000181FEC910-0x0000000181FEC970

	// Methods
	[BlackList] // 0x0000000189B78A00-0x0000000189B78A40
	// [XID] // 0x0000000189B78A00-0x0000000189B78A40
	public override void AutoAllocTypeFields() {} // 0x0000000181FEC3C0-0x0000000181FEC460
	[BlackList] // 0x0000000189B83180-0x0000000189B831C0
	// [XID] // 0x0000000189B83180-0x0000000189B831C0
	public override void AutoRecycleTypeFields() {} // 0x0000000181FEC460-0x0000000181FEC510
	[BlackList] // 0x0000000189B8D310-0x0000000189B8D350
	// [XID] // 0x0000000189B8D310-0x0000000189B8D350
	public override void ReturnToObjectPool() {} // 0x0000000181FEC790-0x0000000181FEC830
	// [XID] // 0x0000000189B97910-0x0000000189B97930
	public void Init(uint targetID, uint key, float delta) {} // 0x0000000181FEC5E0-0x0000000181FEC6D0
	// [XID] // 0x0000000189B9ECF0-0x0000000189B9ED10
	public override string ToString() => default; // 0x0000000181FEC830-0x0000000181FEC910
}

