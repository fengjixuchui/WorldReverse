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
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigWidgetAction_AddDynamicValue : ConfigWidgetAction, IAutoAllocRecycle // TypeDefIndex: 19171
{
	// Fields
	private string _key; // 0x10
	private SimpleSafeFloat valueRawNum; // 0x18

	// Properties
	public string key { /* [XID] */ /* 0x0000000189A37EF0-0x0000000189A37F10 */ get => default; /* [XID] */ /* 0x0000000189A3F640-0x0000000189A3F660 */ private set {} } // 0x0000000184C214B0-0x0000000184C21550 0x0000000184C22CD0-0x0000000184C22D80
	public float value { /* [XID] */ /* 0x0000000189A46CD0-0x0000000189A46CF0 */ get => default; /* [XID] */ /* 0x0000000189A4E520-0x0000000189A4E540 */ private set {} } // 0x0000000184C21AF0-0x0000000184C21BD0 0x0000000184C21990-0x0000000184C21A70

	// Constructors
	public ConfigWidgetAction_AddDynamicValue() {} // 0x0000000184C23300-0x0000000184C23390

	// Methods
	// [XID] // 0x0000000189A55CE0-0x0000000189A55D00
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184C23150-0x0000000184C23260
	// [XID] // 0x0000000189A5D500-0x0000000189A5D520
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184C22DE0-0x0000000184C22EC0
	// [XID] // 0x0000000189A64E40-0x0000000189A64E60
	public override ConfigWidgetAction Clone(bool useObjectPool = false /* Metadata: 0x00AFC427 */) => default; // 0x0000000184C22940-0x0000000184C22A20
	// [XID] // 0x0000000189A6C5A0-0x0000000189A6C5C0
	public override int GetHashNum() => default; // 0x0000000184C213E0-0x0000000184C214B0
	// [XID] // 0x0000000189A73DD0-0x0000000189A73DF0
	public override void InitEmpty() {} // 0x0000000184C22270-0x0000000184C22380
	[BlackList] // 0x0000000189A7B880-0x0000000189A7B8C0
	// [XID] // 0x0000000189A7B880-0x0000000189A7B8C0
	public override bool FromJson(JSONNode node) => default; // 0x0000000184C21BD0-0x0000000184C21F50
	// [XID] // 0x0000000189A86030-0x0000000189A86050
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184C20B30-0x0000000184C20E70
	[BlackList] // 0x0000000189A8D950-0x0000000189A8D990
	// [XID] // 0x0000000189A8D950-0x0000000189A8D990
	public static new ConfigWidgetAction_AddDynamicValue ParseFromJson(JSONNode node) => default; // 0x0000000184C22A80-0x0000000184C22CD0
	// [XID] // 0x0000000189A98280-0x0000000189A982A0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC428 */, bool useObjectPool = false /* Metadata: 0x00AFC42C */) => default; // 0x0000000184C22550-0x0000000184C22850
	// [XID] // 0x0000000189A9F5F0-0x0000000189A9F610
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC42D */, bool useObjectPool = false /* Metadata: 0x00AFC431 */) => default; // 0x0000000184C21630-0x0000000184C21910
	// [XID] // 0x0000000189AA6F00-0x0000000189AA6F20
	public static new ConfigWidgetAction_AddDynamicValue ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC432 */, bool useObjectPool = false /* Metadata: 0x00AFC436 */) => default; // 0x0000000184C21F50-0x0000000184C22170
	[BlackList] // 0x0000000189AAE620-0x0000000189AAE660
	// [XID] // 0x0000000189AAE620-0x0000000189AAE660
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184C20E70-0x0000000184C21140
	// [XID] // 0x0000000189AB8CA0-0x0000000189AB8CC0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184C22EC0-0x0000000184C23150
	[BlackList] // 0x0000000189AC0750-0x0000000189AC0790
	// [XID] // 0x0000000189AC0750-0x0000000189AC0790
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184C22460-0x0000000184C22550
	[BlackList] // 0x0000000189ACB160-0x0000000189ACB1A0
	// [XID] // 0x0000000189ACB160-0x0000000189ACB1A0
	public override void AutoAllocTypeFields() {} // 0x0000000184C21140-0x0000000184C211E0
	[BlackList] // 0x0000000189AD60A0-0x0000000189AD60E0
	// [XID] // 0x0000000189AD60A0-0x0000000189AD60E0
	public override void AutoRecycleTypeFields() {} // 0x0000000184C211E0-0x0000000184C212C0
	[BlackList] // 0x0000000189AE0AE0-0x0000000189AE0B20
	// [XID] // 0x0000000189AE0AE0-0x0000000189AE0B20
	public override void ReturnToObjectPool() {} // 0x0000000184C23260-0x0000000184C23300
	// [XID] // 0x0000000189AEB190-0x0000000189AEB1B0
	public override void DoAction(LCWidget lcWidget, QuickWidgetGeneral widget) {} // 0x0000000184C22850-0x0000000184C22940
}

