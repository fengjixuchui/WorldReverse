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

public sealed class EvtPickupGadget : BaseEvent, IAutoAllocRecycle // TypeDefIndex: 20139
{
	// Fields
	public uint pickupItemRuntimeID; // 0x30
	public uint pickupItemConfigID; // 0x34

	// Constructors
	public EvtPickupGadget() {} // 0x00000001858A06D0-0x00000001858A0730

	// Methods
	[BlackList] // 0x00000001899B4FE0-0x00000001899B5020
	// [XID] // 0x00000001899B4FE0-0x00000001899B5020
	public override void AutoAllocTypeFields() {} // 0x00000001858A0160-0x00000001858A0200
	[BlackList] // 0x00000001899BF830-0x00000001899BF870
	// [XID] // 0x00000001899BF830-0x00000001899BF870
	public override void AutoRecycleTypeFields() {} // 0x00000001858A0200-0x00000001858A02B0
	[BlackList] // 0x00000001899C9DE0-0x00000001899C9E20
	// [XID] // 0x00000001899C9DE0-0x00000001899C9E20
	public override void ReturnToObjectPool() {} // 0x00000001858A0530-0x00000001858A05D0
	// [XID] // 0x00000001899D4380-0x00000001899D43A0
	public void Init(uint targetID, uint gadgetID, uint configID) {} // 0x00000001858A0380-0x00000001858A0470
	// [XID] // 0x00000001899DBA70-0x00000001899DBA90
	public override string ToString() => default; // 0x00000001858A05D0-0x00000001858A06D0
}

