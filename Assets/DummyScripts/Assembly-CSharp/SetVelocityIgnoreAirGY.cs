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
public class SetVelocityIgnoreAirGY : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16733
{
	// Fields
	private bool _ignoreAirGY; // 0x68

	// Properties
	public bool ignoreAirGY { /* [XID] */ /* 0x00000001895FCA10-0x00000001895FCA30 */ get => default; /* [XID] */ /* 0x0000000189604430-0x0000000189604450 */ private set {} } // 0x0000000184789660-0x0000000184789700 0x0000000184788350-0x0000000184788400
	protected override bool MuteAuthority { /* [XID] */ /* 0x00000001896902C0-0x00000001896902E0 */ get => default; } // 0x00000001847894B0-0x0000000184789550 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189697BE0-0x0000000189697C00 */ get => default; } // 0x0000000184788B00-0x0000000184788BA0 

	// Constructors
	public SetVelocityIgnoreAirGY() {} // 0x0000000184789C10-0x0000000184789C70

	// Methods
	// [XID] // 0x000000018960BC80-0x000000018960BCA0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001847899E0-0x0000000184789AD0
	// [XID] // 0x0000000189613260-0x0000000189613280
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001847895B0-0x0000000184789660
	// [XID] // 0x000000018961AB40-0x000000018961AB60
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF448E */) => default; // 0x0000000184789120-0x0000000184789200
	// [XID] // 0x0000000189622120-0x0000000189622140
	public override int GetHashNum() => default; // 0x0000000184787D20-0x0000000184787DF0
	// [XID] // 0x0000000189629A70-0x0000000189629A90
	public override void InitEmpty() {} // 0x0000000184788BA0-0x0000000184788C40
	[BlackList] // 0x00000001896312E0-0x0000000189631320
	// [XID] // 0x00000001896312E0-0x0000000189631320
	public override bool FromJson(JSONNode node) => default; // 0x0000000184788480-0x0000000184788800
	// [XID] // 0x000000018963BBC0-0x000000018963BBE0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184787570-0x0000000184787770
	[BlackList] // 0x0000000189643260-0x00000001896432A0
	// [XID] // 0x0000000189643260-0x00000001896432A0
	public static new SetVelocityIgnoreAirGY ParseFromJson(JSONNode node) => default; // 0x0000000184789260-0x00000001847894B0
	// [XID] // 0x000000018964D9C0-0x000000018964D9E0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF448F */, bool useObjectPool = false /* Metadata: 0x00AF4493 */) => default; // 0x0000000184788E20-0x0000000184789120
	// [XID] // 0x0000000189655140-0x0000000189655160
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4494 */, bool useObjectPool = false /* Metadata: 0x00AF4498 */) => default; // 0x0000000184787F40-0x0000000184788170
	// [XID] // 0x000000018965CA00-0x000000018965CA20
	public static new SetVelocityIgnoreAirGY ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4499 */, bool useObjectPool = false /* Metadata: 0x00AF449D */) => default; // 0x0000000184788800-0x0000000184788A20
	[BlackList] // 0x0000000189663EA0-0x0000000189663EE0
	// [XID] // 0x0000000189663EA0-0x0000000189663EE0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184787770-0x0000000184787A40
	// [XID] // 0x000000018966E8E0-0x000000018966E900
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001847897E0-0x00000001847899E0
	[BlackList] // 0x00000001896763E0-0x0000000189676420
	// [XID] // 0x00000001896763E0-0x0000000189676420
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184788D20-0x0000000184788E20
	// [XID] // 0x0000000189680E80-0x0000000189680EA0
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000184789AD0-0x0000000184789B70
	// [XID] // 0x00000001896888A0-0x00000001896888C0
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000184788170-0x00000001847882D0
	[BlackList] // 0x000000018969EF50-0x000000018969EF90
	// [XID] // 0x000000018969EF50-0x000000018969EF90
	public override void AutoAllocTypeFields() {} // 0x0000000184787A40-0x0000000184787AE0
	[BlackList] // 0x00000001896A9300-0x00000001896A9340
	// [XID] // 0x00000001896A9300-0x00000001896A9340
	public override void AutoRecycleTypeFields() {} // 0x0000000184787AE0-0x0000000184787B90
	[BlackList] // 0x00000001896B3570-0x00000001896B35B0
	// [XID] // 0x00000001896B3570-0x00000001896B35B0
	public override void ReturnToObjectPool() {} // 0x0000000184789B70-0x0000000184789C10
}

