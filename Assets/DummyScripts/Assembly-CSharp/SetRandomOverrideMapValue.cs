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
public class SetRandomOverrideMapValue : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16404
{
	// Fields
	private SimpleSafeFloat valueRangeMaxRawNum; // 0x68
	private SimpleSafeFloat valueRangeMinRawNum; // 0x6C
	private string _overrideMapKey; // 0x70

	// Properties
	public float valueRangeMax { /* [XID] */ /* 0x00000001896A2120-0x00000001896A2140 */ get => default; /* [XID] */ /* 0x00000001896A9380-0x00000001896A93A0 */ private set {} } // 0x0000000185413260-0x0000000185413340 0x0000000185414090-0x0000000185414170
	public float valueRangeMin { /* [XID] */ /* 0x00000001896B04D0-0x00000001896B04F0 */ get => default; /* [XID] */ /* 0x00000001896B7F30-0x00000001896B7F50 */ private set {} } // 0x0000000185414790-0x0000000185414870 0x0000000185412480-0x0000000185412560
	public string overrideMapKey { /* [XID] */ /* 0x00000001898BACD0-0x00000001898BACF0 */ get => default; /* [XID] */ /* 0x00000001896C68F0-0x00000001896C6910 */ private set {} } // 0x00000001854146F0-0x0000000185414790 0x0000000185414870-0x0000000185414920
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189758270-0x0000000189758290 */ get => default; } // 0x0000000185413E40-0x0000000185413EE0 
	protected override bool MuteRemote { /* [XID] */ /* 0x000000018975FD30-0x000000018975FD50 */ get => default; } // 0x0000000185413420-0x00000001854134C0 
	protected override bool ForceForwardToServer { /* [XID] */ /* 0x00000001897673A0-0x00000001897673C0 */ get => default; } // 0x00000001854123E0-0x0000000185412480 

	// Constructors
	public SetRandomOverrideMapValue() {} // 0x0000000185414B90-0x0000000185414BF0

	// Methods
	// [XID] // 0x00000001896CDF50-0x00000001896CDF70
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000185414920-0x0000000185414A50
	// [XID] // 0x00000001896D54C0-0x00000001896D54E0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000185413FB0-0x0000000185414090
	// [XID] // 0x00000001896DCA20-0x00000001896DCA40
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3A6A */) => default; // 0x0000000185413AB0-0x0000000185413B90
	// [XID] // 0x00000001896E4390-0x00000001896E43B0
	public override int GetHashNum() => default; // 0x0000000185412310-0x00000001854123E0
	// [XID] // 0x00000001896EB7A0-0x00000001896EB7C0
	public override void InitEmpty() {} // 0x00000001854134C0-0x00000001854135E0
	[BlackList] // 0x00000001896F2B90-0x00000001896F2BD0
	// [XID] // 0x00000001896F2B90-0x00000001896F2BD0
	public override bool FromJson(JSONNode node) => default; // 0x0000000185412CC0-0x0000000185413040
	// [XID] // 0x00000001896FD670-0x00000001896FD690
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001854118B0-0x0000000185411D20
	[BlackList] // 0x0000000189704AF0-0x0000000189704B30
	// [XID] // 0x0000000189704AF0-0x0000000189704B30
	public static new SetRandomOverrideMapValue ParseFromJson(JSONNode node) => default; // 0x0000000185413BF0-0x0000000185413E40
	// [XID] // 0x000000018970F4C0-0x000000018970F4E0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3A6B */, bool useObjectPool = false /* Metadata: 0x00AF3A6F */) => default; // 0x00000001854137B0-0x0000000185413AB0
	// [XID] // 0x0000000189716840-0x0000000189716860
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3A70 */, bool useObjectPool = false /* Metadata: 0x00AF3A74 */) => default; // 0x00000001854126B0-0x0000000185412A60
	// [XID] // 0x000000018971E2A0-0x000000018971E2C0
	public static new SetRandomOverrideMapValue ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3A75 */, bool useObjectPool = false /* Metadata: 0x00AF3A79 */) => default; // 0x0000000185413040-0x0000000185413260
	[BlackList] // 0x0000000189725800-0x0000000189725840
	// [XID] // 0x0000000189725800-0x0000000189725840
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000185411D20-0x0000000185411FF0
	// [XID] // 0x000000018972FFC0-0x000000018972FFE0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001854143D0-0x00000001854146F0
	[BlackList] // 0x0000000189737880-0x00000001897378C0
	// [XID] // 0x0000000189737880-0x00000001897378C0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001854136C0-0x00000001854137B0
	// [XID] // 0x0000000189741E60-0x0000000189741E80
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000185414A50-0x0000000185414AF0
	// [XID] // 0x0000000189749860-0x0000000189749880
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000185412A60-0x0000000185412BC0
	// [XID] // 0x0000000189750DC0-0x0000000189750DE0
	public override void CallAuthority(MPActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt, ref RecordInvokeEntryContext context) {} // 0x0000000185414250-0x00000001854143D0
	[BlackList] // 0x000000018976E940-0x000000018976E980
	// [XID] // 0x000000018976E940-0x000000018976E980
	public override void AutoAllocTypeFields() {} // 0x0000000185411FF0-0x0000000185412090
	[BlackList] // 0x0000000189779220-0x0000000189779260
	// [XID] // 0x0000000189779220-0x0000000189779260
	public override void AutoRecycleTypeFields() {} // 0x0000000185412090-0x0000000185412180
	[BlackList] // 0x0000000189783A30-0x0000000189783A70
	// [XID] // 0x0000000189783A30-0x0000000189783A70
	public override void ReturnToObjectPool() {} // 0x0000000185414AF0-0x0000000185414B90
}

