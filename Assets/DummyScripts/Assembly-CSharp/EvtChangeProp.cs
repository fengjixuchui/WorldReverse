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

public sealed class EvtChangeProp : BaseEvent, IAutoAllocRecycle // TypeDefIndex: 20082
{
	// Fields
	public uint entityId; // 0x30
	public DataPropOp propOp; // 0x34
	public PropChangeReason reason; // 0x38
	public FightPropType fightPropType; // 0x3C
	public PropType propType; // 0x40
	public List<uint> paramList; // 0x48
	public float value; // 0x50
	public EvtType type; // 0x54

	// Nested types
	public enum EvtType // TypeDefIndex: 20083
	{
		Fight = 0,
		Normal = 1
	}

	// Constructors
	public EvtChangeProp() {} // 0x0000000182D3B0F0-0x0000000182D3B160

	// Methods
	[BlackList] // 0x0000000189AC9820-0x0000000189AC9860
	// [XID] // 0x0000000189AC9820-0x0000000189AC9860
	public override void AutoAllocTypeFields() {} // 0x0000000182D3A800-0x0000000182D3A8A0
	[BlackList] // 0x0000000189AD4530-0x0000000189AD4570
	// [XID] // 0x0000000189AD4530-0x0000000189AD4570
	public override void AutoRecycleTypeFields() {} // 0x0000000182D3A8A0-0x0000000182D3A960
	[BlackList] // 0x0000000189ADF010-0x0000000189ADF050
	// [XID] // 0x0000000189ADF010-0x0000000189ADF050
	public override void ReturnToObjectPool() {} // 0x0000000182D3AF70-0x0000000182D3B010
	// [IDTag] // 0x0000000189AE96B0-0x0000000189AE96F0
	// [XID] // 0x0000000189AE96B0-0x0000000189AE96F0
	public void Init(uint entityId, FightPropType ftype, PropChangeReason reason, float value, DataPropOp propOp) {} // 0x0000000182D3AA30-0x0000000182D3AB60
	// [IDTag] // 0x0000000189AF41B0-0x0000000189AF41F0
	// [XID] // 0x0000000189AF41B0-0x0000000189AF41F0
	public void Init(uint entityId, PropType type, PropChangeReason reason, float value, DataPropOp propOp) {} // 0x0000000182D3AB60-0x0000000182D3AC90
	// [XID] // 0x0000000189AFE7F0-0x0000000189AFE810
	public void AddParam(uint param) {} // 0x0000000182D3ADB0-0x0000000182D3AEB0
	// [XID] // 0x0000000189B06060-0x0000000189B06080
	public override void Clear() {} // 0x0000000182D3AC90-0x0000000182D3AD50
	// [XID] // 0x0000000189B0D7B0-0x0000000189B0D7D0
	public override string ToString() => default; // 0x0000000182D3B010-0x0000000182D3B0F0
}

