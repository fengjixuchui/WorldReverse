/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class MechanicusCardEffectExcelConfig : IAutoAllocRecycle // TypeDefIndex: 16223
{
	// Fields
	protected SimpleSafeUInt32 IDRawNum; // 0x10
	protected MechanicusCardTargetType _targetType; // 0x14
	protected SimpleSafeUInt32[] _targetParamList; // 0x18
	protected MechanicusCardEffectType _effectType; // 0x20
	protected string _effectStrParam; // 0x28
	protected SimpleSafeInt32 effectParam1RawNum; // 0x30
	protected SimpleSafeInt32 effectParam2RawNum; // 0x34
	protected SimpleSafeInt32 effectParam3RawNum; // 0x38

	// Properties
	public uint ID { /* [XID] */ /* 0x00000001897927C0-0x00000001897927E0 */ get => default; /* [XID] */ /* 0x0000000189799D10-0x0000000189799D30 */ protected set {} } // 0x000000018474AA60-0x000000018474AB30 0x00000001847494F0-0x00000001847495D0
	public MechanicusCardTargetType targetType { /* [XID] */ /* 0x00000001897A1BC0-0x00000001897A1BE0 */ get => default; /* [XID] */ /* 0x00000001897A9460-0x00000001897A9480 */ protected set {} } // 0x000000018474AB30-0x000000018474ABD0 0x00000001847495D0-0x0000000184749680
	public SimpleSafeUInt32[] targetParamList { /* [XID] */ /* 0x00000001897B0BA0-0x00000001897B0BC0 */ get => default; /* [XID] */ /* 0x00000001897B8920-0x00000001897B8940 */ protected set {} } // 0x0000000184749450-0x00000001847494F0 0x000000018474A780-0x000000018474A830
	public MechanicusCardEffectType effectType { /* [XID] */ /* 0x00000001897C0960-0x00000001897C0980 */ get => default; /* [XID] */ /* 0x00000001897C8310-0x00000001897C8330 */ protected set {} } // 0x000000018474B4D0-0x000000018474B570 0x000000018474A8D0-0x000000018474A980
	public string effectStrParam { /* [XID] */ /* 0x00000001897CF710-0x00000001897CF730 */ get => default; /* [XID] */ /* 0x00000001897D6F80-0x00000001897D6FA0 */ protected set {} } // 0x000000018474A830-0x000000018474A8D0 0x000000018474B850-0x000000018474B900
	public int effectParam1 { /* [XID] */ /* 0x00000001897DE610-0x00000001897DE630 */ get => default; /* [XID] */ /* 0x00000001897E60F0-0x00000001897E6110 */ protected set {} } // 0x000000018474B570-0x000000018474B640 0x000000018474ABD0-0x000000018474ACB0
	public int effectParam2 { /* [XID] */ /* 0x00000001897EDAB0-0x00000001897EDAD0 */ get => default; /* [XID] */ /* 0x00000001897F51F0-0x00000001897F5210 */ protected set {} } // 0x000000018474B640-0x000000018474B710 0x000000018474A980-0x000000018474AA60
	public int effectParam3 { /* [XID] */ /* 0x00000001897FCC00-0x00000001897FCC20 */ get => default; /* [XID] */ /* 0x0000000189804210-0x0000000189804230 */ protected set {} } // 0x0000000184749860-0x0000000184749930 0x000000018474B3F0-0x000000018474B4D0

	// Constructors
	public MechanicusCardEffectExcelConfig() {} // 0x000000018474B9A0-0x000000018474BA00

	// Methods
	// [IDTag] // 0x000000018980B620-0x000000018980B660
	// [XID] // 0x000000018980B620-0x000000018980B660
	public virtual bool ParseFromLine(string line) => default; // 0x0000000184749930-0x000000018474A060
	// [IDTag] // 0x0000000189815F50-0x0000000189815F90
	// [XID] // 0x0000000189815F50-0x0000000189815F90
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x000000018474A060-0x000000018474A780
	// [XID] // 0x0000000189820B10-0x0000000189820B30
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF34C3 */, bool useObjectPool = false /* Metadata: 0x00AF34C7 */) => default; // 0x000000018474ACB0-0x000000018474B3F0
	[BlackList] // 0x0000000189828020-0x0000000189828060
	// [XID] // 0x0000000189828020-0x0000000189828060
	public virtual void AutoAllocTypeFields() {} // 0x0000000184749680-0x0000000184749720
	[BlackList] // 0x00000001898323B0-0x00000001898323F0
	// [XID] // 0x00000001898323B0-0x00000001898323F0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184749720-0x0000000184749860
	[BlackList] // 0x000000018983CA90-0x000000018983CAD0
	// [XID] // 0x000000018983CA90-0x000000018983CAD0
	public virtual void ReturnToObjectPool() {} // 0x000000018474B900-0x000000018474B9A0
	[BlackList] // 0x0000000189847010-0x0000000189847050
	// [XID] // 0x0000000189847010-0x0000000189847050
	public virtual void OnPoolAllocated() {} // 0x000000018474B7B0-0x000000018474B850
	[BlackList] // 0x0000000189851470-0x00000001898514B0
	// [XID] // 0x0000000189851470-0x00000001898514B0
	public virtual void OnBeforePoolRecycled() {} // 0x000000018474B710-0x000000018474B7B0
}

