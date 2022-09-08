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
public class EntityDoSkill : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16353
{
	// Fields
	private SimpleSafeUInt32 skillIDRawNum; // 0x68
	private bool _isHold; // 0x6C

	// Properties
	public uint skillID { /* [XID] */ /* 0x0000000189BC91E0-0x0000000189BC9200 */ get => default; /* [XID] */ /* 0x0000000189BD0A70-0x0000000189BD0A90 */ private set {} } // 0x00000001822B4AC0-0x00000001822B4B90 0x00000001822B5A10-0x00000001822B5AF0
	public bool isHold { /* [XID] */ /* 0x0000000189BD7F90-0x0000000189BD7FB0 */ get => default; /* [XID] */ /* 0x0000000189BDFB00-0x0000000189BDFB20 */ private set {} } // 0x00000001822B3CE0-0x00000001822B3D80 0x00000001822B3BC0-0x00000001822B3C70
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189670630-0x0000000189670650 */ get => default; } // 0x00000001822B54C0-0x00000001822B5560 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189677E70-0x0000000189677E90 */ get => default; } // 0x00000001822B4A20-0x00000001822B4AC0 

	// Constructors
	public EntityDoSkill() {} // 0x00000001822B5D40-0x00000001822B5DA0

	// Methods
	// [XID] // 0x00000001895EC710-0x00000001895EC730
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001822B5AF0-0x00000001822B5C00
	// [XID] // 0x00000001895F3BD0-0x00000001895F3BF0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001822B55C0-0x00000001822B5670
	// [XID] // 0x00000001895FB4D0-0x00000001895FB4F0
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF38C4 */) => default; // 0x00000001822B5130-0x00000001822B5210
	// [XID] // 0x0000000189602C10-0x0000000189602C30
	public override int GetHashNum() => default; // 0x00000001822B3AF0-0x00000001822B3BC0
	// [XID] // 0x000000018960A550-0x000000018960A570
	public override void InitEmpty() {} // 0x00000001822B4B90-0x00000001822B4C60
	[BlackList] // 0x0000000189611CC0-0x0000000189611D00
	// [XID] // 0x0000000189611CC0-0x0000000189611D00
	public override bool FromJson(JSONNode node) => default; // 0x00000001822B43A0-0x00000001822B4720
	// [XID] // 0x000000018961C500-0x000000018961C520
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001822B31F0-0x00000001822B3510
	[BlackList] // 0x00000001896238E0-0x0000000189623920
	// [XID] // 0x00000001896238E0-0x0000000189623920
	public static new EntityDoSkill ParseFromJson(JSONNode node) => default; // 0x00000001822B5270-0x00000001822B54C0
	// [XID] // 0x000000018962E170-0x000000018962E190
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF38C5 */, bool useObjectPool = false /* Metadata: 0x00AF38C9 */) => default; // 0x00000001822B4E30-0x00000001822B5130
	// [XID] // 0x0000000189635E30-0x0000000189635E50
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF38CA */, bool useObjectPool = false /* Metadata: 0x00AF38CE */) => default; // 0x00000001822B3E60-0x00000001822B4140
	// [XID] // 0x000000018963D530-0x000000018963D550
	public static new EntityDoSkill ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF38CF */, bool useObjectPool = false /* Metadata: 0x00AF38D3 */) => default; // 0x00000001822B4720-0x00000001822B4940
	[BlackList] // 0x0000000189644B10-0x0000000189644B50
	// [XID] // 0x0000000189644B10-0x0000000189644B50
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001822B3510-0x00000001822B37E0
	// [XID] // 0x000000018964F060-0x000000018964F080
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001822B5750-0x00000001822B5A10
	[BlackList] // 0x0000000189656990-0x00000001896569D0
	// [XID] // 0x0000000189656990-0x00000001896569D0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001822B4D40-0x00000001822B4E30
	// [XID] // 0x0000000189661050-0x0000000189661070
	public override bool isAlreadyHandledRecoverCase() => default; // 0x00000001822B5C00-0x00000001822B5CA0
	// [XID] // 0x0000000189668A80-0x0000000189668AA0
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x00000001822B4140-0x00000001822B42A0
	[BlackList] // 0x000000018967F420-0x000000018967F460
	// [XID] // 0x000000018967F420-0x000000018967F460
	public override void AutoAllocTypeFields() {} // 0x00000001822B37E0-0x00000001822B3880
	[BlackList] // 0x0000000189689EF0-0x0000000189689F30
	// [XID] // 0x0000000189689EF0-0x0000000189689F30
	public override void AutoRecycleTypeFields() {} // 0x00000001822B3880-0x00000001822B3960
	[BlackList] // 0x00000001896949C0-0x0000000189694A00
	// [XID] // 0x00000001896949C0-0x0000000189694A00
	public override void ReturnToObjectPool() {} // 0x00000001822B5CA0-0x00000001822B5D40
}

