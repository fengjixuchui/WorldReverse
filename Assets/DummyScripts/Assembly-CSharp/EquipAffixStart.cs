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
public class EquipAffixStart : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16777
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _CD; // 0x68
	private SimpleSafeUInt32 equipAffixDataIDRawNum; // 0x70

	// Properties
	public DynamicFloat CD { /* [XID] */ /* 0x0000000189703310-0x0000000189703330 */ get => default; /* [XID] */ /* 0x000000018970AA20-0x000000018970AA40 */ private set {} } // 0x0000000181E7D0B0-0x0000000181E7D150 0x0000000181E7B5E0-0x0000000181E7B690
	public uint equipAffixDataID { /* [XID] */ /* 0x0000000189712470-0x0000000189712490 */ get => default; /* [XID] */ /* 0x0000000189719B70-0x0000000189719B90 */ private set {} } // 0x0000000181E7BE90-0x0000000181E7BF60 0x0000000181E7BC30-0x0000000181E7BD10
	protected override bool MuteAuthority { /* [XID] */ /* 0x00000001897A4C70-0x00000001897A4C90 */ get => default; } // 0x0000000181E7C8E0-0x0000000181E7C980 
	protected override bool MuteRemote { /* [XID] */ /* 0x00000001897AC220-0x00000001897AC240 */ get => default; } // 0x0000000181E7BDF0-0x0000000181E7BE90 
	protected override bool ForceForwardToServer { /* [XID] */ /* 0x00000001897B41B0-0x00000001897B41D0 */ get => default; } // 0x0000000181E7AEA0-0x0000000181E7AF40 

	// Constructors
	public EquipAffixStart() {} // 0x0000000181E7D1F0-0x0000000181E7D250

	// Methods
	// [XID] // 0x0000000189721170-0x0000000189721190
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181E7CEF0-0x0000000181E7D010
	// [XID] // 0x0000000189728770-0x0000000189728790
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000181E7CA50-0x0000000181E7CB30
	// [XID] // 0x000000018972FEE0-0x000000018972FF00
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF45EE */) => default; // 0x0000000181E7C550-0x0000000181E7C630
	// [XID] // 0x00000001897377C0-0x00000001897377E0
	public override int GetHashNum() => default; // 0x0000000181E7ADD0-0x0000000181E7AEA0
	// [XID] // 0x000000018973F300-0x000000018973F320
	public override void InitEmpty() {} // 0x0000000181E7BF60-0x0000000181E7C070
	[BlackList] // 0x00000001897465C0-0x0000000189746600
	// [XID] // 0x00000001897465C0-0x0000000189746600
	public override bool FromJson(JSONNode node) => default; // 0x0000000181E7B690-0x0000000181E7BA10
	// [XID] // 0x0000000189750D20-0x0000000189750D40
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000181E7A3F0-0x0000000181E7A760
	[BlackList] // 0x0000000189758130-0x0000000189758170
	// [XID] // 0x0000000189758130-0x0000000189758170
	public static new EquipAffixStart ParseFromJson(JSONNode node) => default; // 0x0000000181E7C690-0x0000000181E7C8E0
	// [XID] // 0x0000000189762BB0-0x0000000189762BD0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF45EF */, bool useObjectPool = false /* Metadata: 0x00AF45F3 */) => default; // 0x0000000181E7C250-0x0000000181E7C550
	// [XID] // 0x000000018976A1F0-0x000000018976A210
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF45F4 */, bool useObjectPool = false /* Metadata: 0x00AF45F8 */) => default; // 0x0000000181E7B090-0x0000000181E7B3C0
	// [XID] // 0x0000000189771A30-0x0000000189771A50
	public static new EquipAffixStart ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF45F9 */, bool useObjectPool = false /* Metadata: 0x00AF45FD */) => default; // 0x0000000181E7BA10-0x0000000181E7BC30
	[BlackList] // 0x0000000189779100-0x0000000189779140
	// [XID] // 0x0000000189779100-0x0000000189779140
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000181E7A760-0x0000000181E7AA30
	// [XID] // 0x0000000189783950-0x0000000189783970
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181E7CC10-0x0000000181E7CEF0
	[BlackList] // 0x000000018978B120-0x000000018978B160
	// [XID] // 0x000000018978B120-0x000000018978B160
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000181E7C150-0x0000000181E7C250
	// [XID] // 0x0000000189795540-0x0000000189795560
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000181E7D010-0x0000000181E7D0B0
	// [XID] // 0x000000018979D990-0x000000018979D9B0
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000181E7B3C0-0x0000000181E7B4E0
	[BlackList] // 0x00000001897BBE70-0x00000001897BBEB0
	// [XID] // 0x00000001897BBE70-0x00000001897BBEB0
	public override void AutoAllocTypeFields() {} // 0x0000000181E7AA30-0x0000000181E7AAD0
	[BlackList] // 0x00000001897C67E0-0x00000001897C6820
	// [XID] // 0x00000001897C67E0-0x00000001897C6820
	public override void AutoRecycleTypeFields() {} // 0x0000000181E7AAD0-0x0000000181E7AC40
	[BlackList] // 0x00000001897D0D10-0x00000001897D0D50
	// [XID] // 0x00000001897D0D10-0x00000001897D0D50
	public override void ReturnToObjectPool() {} // 0x0000000181E7D150-0x0000000181E7D1F0
}

