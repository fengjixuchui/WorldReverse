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
public class DoActionByCreateGadgetMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 17024
{
	// Fields
	private CreateGadgetMixinType _type; // 0x30
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _actionQueue; // 0x38

	// Properties
	public CreateGadgetMixinType type { /* [XID] */ /* 0x0000000189ACB570-0x0000000189ACB590 */ get => default; /* [XID] */ /* 0x0000000189AD2FA0-0x0000000189AD2FC0 */ private set {} } // 0x00000001840154D0-0x0000000184015570 0x0000000184015050-0x0000000184015100
	public ConfigAbilityAction[] actionQueue { /* [XID] */ /* 0x0000000189ADA9E0-0x0000000189ADAA00 */ get => default; /* [XID] */ /* 0x0000000189AE2200-0x0000000189AE2220 */ private set {} } // 0x00000001840142B0-0x0000000184014350 0x0000000184014E60-0x0000000184014F10
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x0000000189B65A60-0x0000000189B65A80 */ get => default; } // 0x0000000184013C00-0x0000000184013CA0 

	// Constructors
	public DoActionByCreateGadgetMixin() {} // 0x0000000184015610-0x0000000184015670

	// Methods
	// [XID] // 0x0000000189AE9B30-0x0000000189AE9B50
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001840153C0-0x00000001840154D0
	// [XID] // 0x0000000189AF18B0-0x0000000189AF18D0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184014F70-0x0000000184015050
	// [XID] // 0x0000000189AF8FF0-0x0000000189AF9010
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF60B9 */) => default; // 0x0000000184014AD0-0x0000000184014BB0
	// [XID] // 0x0000000189B00590-0x0000000189B005B0
	public override int GetHashNum() => default; // 0x0000000184013670-0x0000000184013740
	// [XID] // 0x0000000189B07A50-0x0000000189B07A70
	public override void InitEmpty() {} // 0x0000000184014450-0x0000000184014520
	[BlackList] // 0x0000000189B0F2D0-0x0000000189B0F310
	// [XID] // 0x0000000189B0F2D0-0x0000000189B0F310
	public override bool FromJson(JSONNode node) => default; // 0x0000000184013CA0-0x0000000184014020
	// [XID] // 0x0000000189B196B0-0x0000000189B196D0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184012E10-0x0000000184013120
	[BlackList] // 0x0000000189B20D50-0x0000000189B20D90
	// [XID] // 0x0000000189B20D50-0x0000000189B20D90
	public static new DoActionByCreateGadgetMixin ParseFromJson(JSONNode node) => default; // 0x0000000184014C10-0x0000000184014E60
	// [XID] // 0x0000000189B2B3D0-0x0000000189B2B3F0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF60BA */, bool useObjectPool = false /* Metadata: 0x00AF60BE */) => default; // 0x00000001840146F0-0x00000001840149F0
	// [XID] // 0x0000000189B32960-0x0000000189B32980
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF60BF */, bool useObjectPool = false /* Metadata: 0x00AF60C3 */) => default; // 0x0000000184013820-0x0000000184013B00
	// [XID] // 0x0000000189B3A250-0x0000000189B3A270
	public static new DoActionByCreateGadgetMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF60C4 */, bool useObjectPool = false /* Metadata: 0x00AF60C8 */) => default; // 0x0000000184014090-0x00000001840142B0
	[BlackList] // 0x0000000189B41BB0-0x0000000189B41BF0
	// [XID] // 0x0000000189B41BB0-0x0000000189B41BF0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184013120-0x00000001840133F0
	// [XID] // 0x0000000189B4C3E0-0x0000000189B4C400
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184015100-0x00000001840153C0
	[BlackList] // 0x0000000189B53A00-0x0000000189B53A40
	// [XID] // 0x0000000189B53A00-0x0000000189B53A40
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184014600-0x00000001840146F0
	// [XID] // 0x0000000189B5E540-0x0000000189B5E560
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x00000001840149F0-0x0000000184014AD0
	[BlackList] // 0x0000000189B6CFA0-0x0000000189B6CFE0
	// [XID] // 0x0000000189B6CFA0-0x0000000189B6CFE0
	public override void AutoAllocTypeFields() {} // 0x00000001840133F0-0x0000000184013490
	[BlackList] // 0x0000000189B77490-0x0000000189B774D0
	// [XID] // 0x0000000189B77490-0x0000000189B774D0
	public override void AutoRecycleTypeFields() {} // 0x0000000184013490-0x0000000184013550
	[BlackList] // 0x0000000189B81DB0-0x0000000189B81DF0
	// [XID] // 0x0000000189B81DB0-0x0000000189B81DF0
	public override void ReturnToObjectPool() {} // 0x0000000184015570-0x0000000184015610
}

