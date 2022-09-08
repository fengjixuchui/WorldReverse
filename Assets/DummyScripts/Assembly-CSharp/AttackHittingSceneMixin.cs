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
public class AttackHittingSceneMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 16975
{
	// Fields
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _onHittingScene; // 0x30
	private string[] _animEventIDs; // 0x38

	// Properties
	public ConfigAbilityAction[] onHittingScene { /* [XID] */ /* 0x000000018985B750-0x000000018985B770 */ get => default; /* [XID] */ /* 0x0000000189862D30-0x0000000189862D50 */ private set {} } // 0x00000001835722D0-0x0000000183572370 0x0000000183570E30-0x0000000183570EE0
	public string[] animEventIDs { /* [XID] */ /* 0x000000018986A140-0x000000018986A160 */ get => default; /* [XID] */ /* 0x00000001898714D0-0x00000001898714F0 */ private set {} } // 0x0000000183572130-0x00000001835721D0 0x0000000183571D70-0x0000000183571E20
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x00000001898F4E20-0x00000001898F4E40 */ get => default; } // 0x0000000183570D90-0x0000000183570E30 

	// Constructors
	public AttackHittingSceneMixin() {} // 0x0000000183572810-0x0000000183572870

	// Methods
	// [XID] // 0x0000000189878E70-0x0000000189878E90
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183572660-0x0000000183572770
	// [XID] // 0x00000001898804A0-0x00000001898804C0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001835721D0-0x00000001835722D0
	// [XID] // 0x0000000189887A00-0x0000000189887A20
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF5F3F */) => default; // 0x0000000183571C90-0x0000000183571D70
	// [XID] // 0x000000018988ED00-0x000000018988ED20
	public override int GetHashNum() => default; // 0x00000001835707D0-0x00000001835708A0
	// [XID] // 0x0000000189896240-0x0000000189896260
	public override void InitEmpty() {} // 0x00000001835715F0-0x00000001835716E0
	[BlackList] // 0x000000018989D8E0-0x000000018989D920
	// [XID] // 0x000000018989D8E0-0x000000018989D920
	public override bool FromJson(JSONNode node) => default; // 0x0000000183570EE0-0x0000000183571260
	// [XID] // 0x00000001898A7DF0-0x00000001898A7E10
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018356FF60-0x0000000183570280
	[BlackList] // 0x00000001898AF8D0-0x00000001898AF910
	// [XID] // 0x00000001898AF8D0-0x00000001898AF910
	public static new AttackHittingSceneMixin ParseFromJson(JSONNode node) => default; // 0x0000000183571E80-0x00000001835720D0
	// [XID] // 0x00000001898BA340-0x00000001898BA360
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5F40 */, bool useObjectPool = false /* Metadata: 0x00AF5F44 */) => default; // 0x00000001835718B0-0x0000000183571BB0
	// [XID] // 0x00000001898C16A0-0x00000001898C16C0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5F45 */, bool useObjectPool = false /* Metadata: 0x00AF5F49 */) => default; // 0x0000000183570980-0x0000000183570C90
	// [XID] // 0x00000001898C8FA0-0x00000001898C8FC0
	public static new AttackHittingSceneMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5F4A */, bool useObjectPool = false /* Metadata: 0x00AF5F4E */) => default; // 0x00000001835712D0-0x00000001835714F0
	[BlackList] // 0x00000001898D07A0-0x00000001898D07E0
	// [XID] // 0x00000001898D07A0-0x00000001898D07E0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000183570280-0x0000000183570550
	// [XID] // 0x00000001898DADC0-0x00000001898DADE0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183572370-0x0000000183572660
	[BlackList] // 0x00000001898E2BA0-0x00000001898E2BE0
	// [XID] // 0x00000001898E2BA0-0x00000001898E2BE0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001835717C0-0x00000001835718B0
	// [XID] // 0x00000001898ED600-0x00000001898ED620
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x0000000183571BB0-0x0000000183571C90
	[BlackList] // 0x00000001898FC510-0x00000001898FC550
	// [XID] // 0x00000001898FC510-0x00000001898FC550
	public override void AutoAllocTypeFields() {} // 0x0000000183570550-0x00000001835705F0
	[BlackList] // 0x0000000189906E30-0x0000000189906E70
	// [XID] // 0x0000000189906E30-0x0000000189906E70
	public override void AutoRecycleTypeFields() {} // 0x00000001835705F0-0x00000001835706B0
	[BlackList] // 0x0000000189911640-0x0000000189911680
	// [XID] // 0x0000000189911640-0x0000000189911680
	public override void ReturnToObjectPool() {} // 0x0000000183572770-0x0000000183572810
}

