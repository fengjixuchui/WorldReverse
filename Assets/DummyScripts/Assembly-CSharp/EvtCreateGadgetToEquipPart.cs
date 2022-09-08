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

public sealed class EvtCreateGadgetToEquipPart : BaseEvent, IAutoAllocRecycle // TypeDefIndex: 20085
{
	// Fields
	public string equipPart; // 0x30
	public uint gadgetConfigID; // 0x38
	public uint entityID; // 0x3C

	// Constructors
	public EvtCreateGadgetToEquipPart() {} // 0x00000001817A4110-0x00000001817A4170

	// Methods
	[BlackList] // 0x0000000189B42DD0-0x0000000189B42E10
	// [XID] // 0x0000000189B42DD0-0x0000000189B42E10
	public override void AutoAllocTypeFields() {} // 0x00000001817A3B80-0x00000001817A3C20
	[BlackList] // 0x0000000189B4D4F0-0x0000000189B4D530
	// [XID] // 0x0000000189B4D4F0-0x0000000189B4D530
	public override void AutoRecycleTypeFields() {} // 0x00000001817A3C20-0x00000001817A3CD0
	[BlackList] // 0x0000000189B57E70-0x0000000189B57EB0
	// [XID] // 0x0000000189B57E70-0x0000000189B57EB0
	public override void ReturnToObjectPool() {} // 0x00000001817A3F60-0x00000001817A4000
	// [XID] // 0x0000000189B62210-0x0000000189B62230
	public void Init(uint targetID, uint gadgetConfigID, string equipPart, uint entityID) {} // 0x00000001817A3DA0-0x00000001817A3EA0
	// [XID] // 0x0000000189B69E70-0x0000000189B69E90
	public override string ToString() => default; // 0x00000001817A4000-0x00000001817A4110
}

