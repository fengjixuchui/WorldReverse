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
public class OverrideAttackEventMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 16924
{
	// Fields
	private string _overrideAttackEvent; // 0x30

	// Properties
	public string overrideAttackEvent { /* [XID] */ /* 0x00000001897E45D0-0x00000001897E45F0 */ get => default; /* [XID] */ /* 0x00000001897EC100-0x00000001897EC120 */ private set {} } // 0x0000000183D54E30-0x0000000183D54ED0 0x0000000183D55360-0x0000000183D55410
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x000000018986E930-0x000000018986E950 */ get => default; } // 0x0000000183D552C0-0x0000000183D55360 

	// Constructors
	public OverrideAttackEventMixin() {} // 0x0000000183D56A00-0x0000000183D56A60

	// Methods
	// [XID] // 0x00000001897F3AB0-0x00000001897F3AD0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183D56870-0x0000000183D56960
	// [XID] // 0x00000001897FB4B0-0x00000001897FB4D0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183D56590-0x0000000183D56670
	// [XID] // 0x00000001898028E0-0x0000000189802900
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF5DB5 */) => default; // 0x0000000183D561A0-0x0000000183D56280
	// [XID] // 0x0000000189809F30-0x0000000189809F50
	public override int GetHashNum() => default; // 0x0000000183D54D00-0x0000000183D54DD0
	// [XID] // 0x0000000189811620-0x0000000189811640
	public override void InitEmpty() {} // 0x0000000183D55B20-0x0000000183D55BF0
	[BlackList] // 0x0000000189819150-0x0000000189819190
	// [XID] // 0x0000000189819150-0x0000000189819190
	public override bool FromJson(JSONNode node) => default; // 0x0000000183D55410-0x0000000183D55790
	// [XID] // 0x00000001898233F0-0x0000000189823410
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183D54590-0x0000000183D547C0
	[BlackList] // 0x000000018982AD90-0x000000018982ADD0
	// [XID] // 0x000000018982AD90-0x000000018982ADD0
	public static new OverrideAttackEventMixin ParseFromJson(JSONNode node) => default; // 0x0000000183D562E0-0x0000000183D56530
	// [XID] // 0x0000000189835250-0x0000000189835270
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5DB6 */, bool useObjectPool = false /* Metadata: 0x00AF5DBA */) => default; // 0x0000000183D55DC0-0x0000000183D560C0
	// [XID] // 0x000000018983C970-0x000000018983C990
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5DBB */, bool useObjectPool = false /* Metadata: 0x00AF5DBF */) => default; // 0x0000000183D54F50-0x0000000183D551C0
	// [XID] // 0x00000001898440A0-0x00000001898440C0
	public static new OverrideAttackEventMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5DC0 */, bool useObjectPool = false /* Metadata: 0x00AF5DC4 */) => default; // 0x0000000183D55800-0x0000000183D55A20
	[BlackList] // 0x000000018984B4B0-0x000000018984B4F0
	// [XID] // 0x000000018984B4B0-0x000000018984B4F0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000183D547C0-0x0000000183D54A90
	// [XID] // 0x0000000189855630-0x0000000189855650
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183D56670-0x0000000183D56870
	[BlackList] // 0x000000018985CB30-0x000000018985CB70
	// [XID] // 0x000000018985CB30-0x000000018985CB70
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183D55CD0-0x0000000183D55DC0
	// [XID] // 0x0000000189867110-0x0000000189867130
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x0000000183D560C0-0x0000000183D561A0
	[BlackList] // 0x0000000189875E20-0x0000000189875E60
	// [XID] // 0x0000000189875E20-0x0000000189875E60
	public override void AutoAllocTypeFields() {} // 0x0000000183D54A90-0x0000000183D54B30
	[BlackList] // 0x00000001898804C0-0x0000000189880500
	// [XID] // 0x00000001898804C0-0x0000000189880500
	public override void AutoRecycleTypeFields() {} // 0x0000000183D54B30-0x0000000183D54BE0
	[BlackList] // 0x000000018988A6F0-0x000000018988A730
	// [XID] // 0x000000018988A6F0-0x000000018988A730
	public override void ReturnToObjectPool() {} // 0x0000000183D56960-0x0000000183D56A00
}

