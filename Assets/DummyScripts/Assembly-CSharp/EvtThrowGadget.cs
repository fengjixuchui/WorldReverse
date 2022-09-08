/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EvtThrowGadget : BaseEvent, IAutoAllocRecycle // TypeDefIndex: 20172
{
	// Fields
	public string equipPart; // 0x30
	public uint targetRuntimeID; // 0x38
	public uint lockPointIndex; // 0x3C
	public Quaternion rotation; // 0x40

	// Constructors
	public EvtThrowGadget() {} // 0x000000018451F600-0x000000018451F660

	// Methods
	[BlackList] // 0x0000000189A4E330-0x0000000189A4E370
	// [XID] // 0x0000000189A4E330-0x0000000189A4E370
	public override void AutoAllocTypeFields() {} // 0x000000018451F040-0x000000018451F0E0
	[BlackList] // 0x0000000189A589A0-0x0000000189A589E0
	// [XID] // 0x0000000189A589A0-0x0000000189A589E0
	public override void AutoRecycleTypeFields() {} // 0x000000018451F0E0-0x000000018451F1A0
	[BlackList] // 0x0000000189A634B0-0x0000000189A634F0
	// [XID] // 0x0000000189A634B0-0x0000000189A634F0
	public override void ReturnToObjectPool() {} // 0x000000018451F460-0x000000018451F500
	// [XID] // 0x0000000189A6DC20-0x0000000189A6DC40
	public void Init(uint targetID, uint targetRuntimeID, uint lockPointIndex, string equipPart, Quaternion rotation) {} // 0x000000018451F270-0x000000018451F3A0
	// [XID] // 0x0000000189A752F0-0x0000000189A75310
	public override string ToString() => default; // 0x000000018451F500-0x000000018451F600
}

