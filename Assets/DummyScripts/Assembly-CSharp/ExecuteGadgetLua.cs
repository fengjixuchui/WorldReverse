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
public class ExecuteGadgetLua : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16683
{
	// Fields
	private SimpleSafeInt32 param1RawNum; // 0x68
	private SimpleSafeInt32 param2RawNum; // 0x6C
	private SimpleSafeInt32 param3RawNum; // 0x70

	// Properties
	public int param1 { /* [XID] */ /* 0x000000018996F840-0x000000018996F860 */ get => default; /* [XID] */ /* 0x00000001899774E0-0x0000000189977500 */ private set {} } // 0x0000000181AF7CC0-0x0000000181AF7D90 0x0000000181AF89C0-0x0000000181AF8AA0
	public int param2 { /* [XID] */ /* 0x000000018997E840-0x000000018997E860 */ get => default; /* [XID] */ /* 0x0000000189986270-0x0000000189986290 */ private set {} } // 0x0000000181AF8AA0-0x0000000181AF8B70 0x0000000181AF98E0-0x0000000181AF99C0
	public int param3 { /* [XID] */ /* 0x000000018998DE80-0x000000018998DEA0 */ get => default; /* [XID] */ /* 0x0000000189995950-0x0000000189995970 */ private set {} } // 0x0000000181AF7450-0x0000000181AF7520 0x0000000181AF9800-0x0000000181AF98E0
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189A27BC0-0x0000000189A27BE0 */ get => default; } // 0x0000000181AF9650-0x0000000181AF96F0 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189A2F230-0x0000000189A2F250 */ get => default; } // 0x0000000181AF8C50-0x0000000181AF8CF0 

	// Constructors
	public ExecuteGadgetLua() {} // 0x0000000181AFA230-0x0000000181AFA290

	// Methods
	// [XID] // 0x000000018999D270-0x000000018999D290
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181AF9FC0-0x0000000181AFA0F0
	// [XID] // 0x00000001899A4C30-0x00000001899A4C50
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000181AF9750-0x0000000181AF9800
	// [XID] // 0x00000001899AC7B0-0x00000001899AC7D0
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF42FE */) => default; // 0x0000000181AF92C0-0x0000000181AF93A0
	// [XID] // 0x00000001899B3F00-0x00000001899B3F20
	public override int GetHashNum() => default; // 0x0000000181AF7B20-0x0000000181AF7BF0
	// [XID] // 0x00000001899BB350-0x00000001899BB370
	public override void InitEmpty() {} // 0x0000000181AF8CF0-0x0000000181AF8DE0
	[BlackList] // 0x00000001899C2EA0-0x00000001899C2EE0
	// [XID] // 0x00000001899C2EA0-0x00000001899C2EE0
	public override bool FromJson(JSONNode node) => default; // 0x0000000181AF8420-0x0000000181AF87A0
	// [XID] // 0x00000001899CD4F0-0x00000001899CD510
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000181AF6FD0-0x0000000181AF7450
	[BlackList] // 0x00000001899D49D0-0x00000001899D4A10
	// [XID] // 0x00000001899D49D0-0x00000001899D4A10
	public static new ExecuteGadgetLua ParseFromJson(JSONNode node) => default; // 0x0000000181AF9400-0x0000000181AF9650
	// [XID] // 0x00000001899DEE50-0x00000001899DEE70
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF42FF */, bool useObjectPool = false /* Metadata: 0x00AF4303 */) => default; // 0x0000000181AF8FC0-0x0000000181AF92C0
	// [XID] // 0x00000001899E6A30-0x00000001899E6A50
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4304 */, bool useObjectPool = false /* Metadata: 0x00AF4308 */) => default; // 0x0000000181AF7E10-0x0000000181AF81C0
	// [XID] // 0x00000001899EDFE0-0x00000001899EE000
	public static new ExecuteGadgetLua ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4309 */, bool useObjectPool = false /* Metadata: 0x00AF430D */) => default; // 0x0000000181AF87A0-0x0000000181AF89C0
	[BlackList] // 0x00000001899F5810-0x00000001899F5850
	// [XID] // 0x00000001899F5810-0x00000001899F5850
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000181AF7520-0x0000000181AF77F0
	// [XID] // 0x00000001899FFD80-0x00000001899FFDA0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181AF9C20-0x0000000181AF9FC0
	[BlackList] // 0x0000000189A075F0-0x0000000189A07630
	// [XID] // 0x0000000189A075F0-0x0000000189A07630
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000181AF8EC0-0x0000000181AF8FC0
	// [XID] // 0x0000000189A11DC0-0x0000000189A11DE0
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000181AFA0F0-0x0000000181AFA190
	// [XID] // 0x0000000189A19050-0x0000000189A19070
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000181AF81C0-0x0000000181AF8320
	// [XID] // 0x0000000189A207F0-0x0000000189A20810
	public override void CallAuthority(MPActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt, ref RecordInvokeEntryContext context) {} // 0x0000000181AF9AA0-0x0000000181AF9C20
	[BlackList] // 0x0000000189A36C70-0x0000000189A36CB0
	// [XID] // 0x0000000189A36C70-0x0000000189A36CB0
	public override void AutoAllocTypeFields() {} // 0x0000000181AF77F0-0x0000000181AF7890
	[BlackList] // 0x0000000189A412B0-0x0000000189A412F0
	// [XID] // 0x0000000189A412B0-0x0000000189A412F0
	public override void AutoRecycleTypeFields() {} // 0x0000000181AF7890-0x0000000181AF7990
	[BlackList] // 0x0000000189A4B8E0-0x0000000189A4B920
	// [XID] // 0x0000000189A4B8E0-0x0000000189A4B920
	public override void ReturnToObjectPool() {} // 0x0000000181AFA190-0x0000000181AFA230
}

