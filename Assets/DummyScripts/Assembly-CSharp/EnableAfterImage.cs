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
public class EnableAfterImage : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16459
{
	// Fields
	private bool _enable; // 0x68
	private SimpleSafeUInt32 indexRawNum; // 0x6C

	// Properties
	public bool enable { /* [XID] */ /* 0x0000000189A96D20-0x0000000189A96D40 */ get => default; /* [XID] */ /* 0x0000000189A9E190-0x0000000189A9E1B0 */ private set {} } // 0x0000000184176FF0-0x0000000184177090 0x0000000184177FC0-0x0000000184178070
	public uint index { /* [XID] */ /* 0x0000000189AA5B20-0x0000000189AA5B40 */ get => default; /* [XID] */ /* 0x0000000189AAD140-0x0000000189AAD160 */ private set {} } // 0x0000000184177780-0x0000000184177850 0x0000000184177B50-0x0000000184177C30
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189B402A0-0x0000000189B402C0 */ get => default; } // 0x0000000184178070-0x0000000184178110 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189B47B60-0x0000000189B47B80 */ get => default; } // 0x0000000184177440-0x00000001841774E0 

	// Constructors
	public EnableAfterImage() {} // 0x0000000184178990-0x0000000184178A00

	// Methods
	// [XID] // 0x0000000189AB4B50-0x0000000189AB4B70
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184178740-0x0000000184178850
	// [XID] // 0x0000000189ABC8A0-0x0000000189ABC8C0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184178170-0x0000000184178220
	// [XID] // 0x0000000189AC4160-0x0000000189AC4180
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3C14 */) => default; // 0x0000000184177C30-0x0000000184177D10
	// [XID] // 0x0000000189ACB6D0-0x0000000189ACB6F0
	public override int GetHashNum() => default; // 0x0000000184176510-0x00000001841765E0
	// [XID] // 0x0000000189AD3100-0x0000000189AD3120
	public override void InitEmpty() {} // 0x00000001841774E0-0x00000001841775B0
	[BlackList] // 0x0000000189ADAAC0-0x0000000189ADAB00
	// [XID] // 0x0000000189ADAAC0-0x0000000189ADAB00
	public override bool FromJson(JSONNode node) => default; // 0x0000000184176C70-0x0000000184176FF0
	// [XID] // 0x0000000189AE5880-0x0000000189AE58A0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184175C00-0x0000000184175F30
	[BlackList] // 0x0000000189AECC60-0x0000000189AECCA0
	// [XID] // 0x0000000189AECC60-0x0000000189AECCA0
	public static new EnableAfterImage ParseFromJson(JSONNode node) => default; // 0x0000000184177D70-0x0000000184177FC0
	// [XID] // 0x0000000189AF7820-0x0000000189AF7840
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3C15 */, bool useObjectPool = false /* Metadata: 0x00AF3C19 */) => default; // 0x0000000184177850-0x0000000184177B50
	// [XID] // 0x0000000189AFEE50-0x0000000189AFEE70
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3C1A */, bool useObjectPool = false /* Metadata: 0x00AF3C1E */) => default; // 0x0000000184176730-0x0000000184176A10
	// [XID] // 0x0000000189B06640-0x0000000189B06660
	public static new EnableAfterImage ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3C1F */, bool useObjectPool = false /* Metadata: 0x00AF3C23 */) => default; // 0x0000000184177140-0x0000000184177360
	[BlackList] // 0x0000000189B0DC90-0x0000000189B0DCD0
	// [XID] // 0x0000000189B0DC90-0x0000000189B0DCD0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184175F30-0x0000000184176200
	// [XID] // 0x0000000189B18140-0x0000000189B18160
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184178300-0x00000001841785C0
	[BlackList] // 0x0000000189B1F7A0-0x0000000189B1F7E0
	// [XID] // 0x0000000189B1F7A0-0x0000000189B1F7E0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184177690-0x0000000184177780
	// [XID] // 0x0000000189B29D80-0x0000000189B29DA0
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000184178850-0x00000001841788F0
	// [XID] // 0x0000000189B31350-0x0000000189B31370
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000184176A10-0x0000000184176B70
	// [XID] // 0x0000000189B38910-0x0000000189B38930
	public override bool GetDebugOutput(ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt, ref string output) => default; // 0x00000001841785C0-0x0000000184178740
	[BlackList] // 0x0000000189B4F3F0-0x0000000189B4F430
	// [XID] // 0x0000000189B4F3F0-0x0000000189B4F430
	public override void AutoAllocTypeFields() {} // 0x0000000184176200-0x00000001841762A0
	[BlackList] // 0x0000000189B59B80-0x0000000189B59BC0
	// [XID] // 0x0000000189B59B80-0x0000000189B59BC0
	public override void AutoRecycleTypeFields() {} // 0x00000001841762A0-0x0000000184176380
	[BlackList] // 0x0000000189B64350-0x0000000189B64390
	// [XID] // 0x0000000189B64350-0x0000000189B64390
	public override void ReturnToObjectPool() {} // 0x00000001841788F0-0x0000000184178990
}

