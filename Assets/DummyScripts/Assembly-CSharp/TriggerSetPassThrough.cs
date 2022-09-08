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
public class TriggerSetPassThrough : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16527
{
	// Fields
	private bool _passThrough; // 0x68

	// Properties
	public bool passThrough { /* [XID] */ /* 0x0000000189AB0360-0x0000000189AB0380 */ get => default; /* [XID] */ /* 0x0000000189AB7A20-0x0000000189AB7A40 */ private set {} } // 0x00000001830AA5E0-0x00000001830AA680 0x00000001830AAFE0-0x00000001830AB090
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189B43390-0x0000000189B433B0 */ get => default; } // 0x00000001830ABD30-0x00000001830ABDD0 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189B4AB70-0x0000000189B4AB90 */ get => default; } // 0x00000001830AB390-0x00000001830AB430 

	// Constructors
	public TriggerSetPassThrough() {} // 0x00000001830AC3F0-0x00000001830AC450

	// Methods
	// [XID] // 0x0000000189ABF470-0x0000000189ABF490
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001830AC1C0-0x00000001830AC2B0
	// [XID] // 0x0000000189AC6F20-0x0000000189AC6F40
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001830ABE30-0x00000001830ABEE0
	// [XID] // 0x0000000189ACE6B0-0x0000000189ACE6D0
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3E36 */) => default; // 0x00000001830AB9A0-0x00000001830ABA80
	// [XID] // 0x0000000189AD6560-0x0000000189AD6580
	public override int GetHashNum() => default; // 0x00000001830AA510-0x00000001830AA5E0
	// [XID] // 0x0000000189ADDDE0-0x0000000189ADDE00
	public override void InitEmpty() {} // 0x00000001830AB430-0x00000001830AB4D0
	[BlackList] // 0x0000000189AE5840-0x0000000189AE5880
	// [XID] // 0x0000000189AE5840-0x0000000189AE5880
	public override bool FromJson(JSONNode node) => default; // 0x00000001830AAC60-0x00000001830AAFE0
	// [XID] // 0x0000000189AF0390-0x0000000189AF03B0
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001830A9D60-0x00000001830A9F60
	[BlackList] // 0x0000000189AF77C0-0x0000000189AF7800
	// [XID] // 0x0000000189AF77C0-0x0000000189AF7800
	public static new TriggerSetPassThrough ParseFromJson(JSONNode node) => default; // 0x00000001830ABAE0-0x00000001830ABD30
	// [XID] // 0x0000000189B01ED0-0x0000000189B01EF0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3E37 */, bool useObjectPool = false /* Metadata: 0x00AF3E3B */) => default; // 0x00000001830AB6A0-0x00000001830AB9A0
	// [XID] // 0x0000000189B09410-0x0000000189B09430
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3E3C */, bool useObjectPool = false /* Metadata: 0x00AF3E40 */) => default; // 0x00000001830AA7D0-0x00000001830AAA00
	// [XID] // 0x0000000189B10E90-0x0000000189B10EB0
	public static new TriggerSetPassThrough ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3E41 */, bool useObjectPool = false /* Metadata: 0x00AF3E45 */) => default; // 0x00000001830AB090-0x00000001830AB2B0
	[BlackList] // 0x0000000189B18100-0x0000000189B18140
	// [XID] // 0x0000000189B18100-0x0000000189B18140
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001830A9F60-0x00000001830AA230
	// [XID] // 0x0000000189B227D0-0x0000000189B227F0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001830ABFC0-0x00000001830AC1C0
	[BlackList] // 0x0000000189B29D00-0x0000000189B29D40
	// [XID] // 0x0000000189B29D00-0x0000000189B29D40
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001830AB5B0-0x00000001830AB6A0
	// [XID] // 0x0000000189B34080-0x0000000189B340A0
	public override bool isAlreadyHandledRecoverCase() => default; // 0x00000001830AC2B0-0x00000001830AC350
	// [XID] // 0x0000000189B3B950-0x0000000189B3B970
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x00000001830AAA00-0x00000001830AAB60
	[BlackList] // 0x0000000189B521E0-0x0000000189B52220
	// [XID] // 0x0000000189B521E0-0x0000000189B52220
	public override void AutoAllocTypeFields() {} // 0x00000001830AA230-0x00000001830AA2D0
	[BlackList] // 0x0000000189B5CC70-0x0000000189B5CCB0
	// [XID] // 0x0000000189B5CC70-0x0000000189B5CCB0
	public override void AutoRecycleTypeFields() {} // 0x00000001830AA2D0-0x00000001830AA380
	[BlackList] // 0x0000000189B675A0-0x0000000189B675E0
	// [XID] // 0x0000000189B675A0-0x0000000189B675E0
	public override void ReturnToObjectPool() {} // 0x00000001830AC350-0x00000001830AC3F0
}

