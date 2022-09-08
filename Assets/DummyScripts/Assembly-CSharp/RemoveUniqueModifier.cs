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
public class RemoveUniqueModifier : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16339
{
	// Fields
	private string _modifierName; // 0x68

	// Properties
	public string modifierName { /* [XID] */ /* 0x0000000189AEB730-0x0000000189AEB750 */ get => default; /* [XID] */ /* 0x0000000189AF3070-0x0000000189AF3090 */ private set {} } // 0x0000000184E6A730-0x0000000184E6A7D0 0x0000000184E694F0-0x0000000184E695A0
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189B7D5A0-0x0000000189B7D5C0 */ get => default; } // 0x0000000184E69E80-0x0000000184E69F20 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189B852D0-0x0000000189B852F0 */ get => default; } // 0x0000000184E692A0-0x0000000184E69340 

	// Constructors
	public RemoveUniqueModifier() {} // 0x0000000184E6A870-0x0000000184E6A8D0

	// Methods
	// [XID] // 0x0000000189AFA980-0x0000000189AFA9A0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184E6A5A0-0x0000000184E6A690
	// [XID] // 0x0000000189B01F10-0x0000000189B01F30
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184E69F80-0x0000000184E6A060
	// [XID] // 0x0000000189B09450-0x0000000189B09470
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3854 */) => default; // 0x0000000184E69990-0x0000000184E69A70
	// [XID] // 0x0000000189B10ED0-0x0000000189B10EF0
	public override int GetHashNum() => default; // 0x0000000184E68530-0x0000000184E68600
	// [XID] // 0x0000000189B18180-0x0000000189B181A0
	public override void InitEmpty() {} // 0x0000000184E69340-0x0000000184E69410
	[BlackList] // 0x0000000189B1F820-0x0000000189B1F860
	// [XID] // 0x0000000189B1F820-0x0000000189B1F860
	public override bool FromJson(JSONNode node) => default; // 0x0000000184E68C20-0x0000000184E68FA0
	// [XID] // 0x0000000189B29DA0-0x0000000189B29DC0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184E67D50-0x0000000184E67F80
	[BlackList] // 0x0000000189B313B0-0x0000000189B313F0
	// [XID] // 0x0000000189B313B0-0x0000000189B313F0
	public static new RemoveUniqueModifier ParseFromJson(JSONNode node) => default; // 0x0000000184E69C30-0x0000000184E69E80
	// [XID] // 0x0000000189B3B9B0-0x0000000189B3B9D0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3855 */, bool useObjectPool = false /* Metadata: 0x00AF3859 */) => default; // 0x0000000184E69690-0x0000000184E69990
	// [XID] // 0x0000000189B43430-0x0000000189B43450
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF385A */, bool useObjectPool = false /* Metadata: 0x00AF385E */) => default; // 0x0000000184E68750-0x0000000184E689C0
	// [XID] // 0x0000000189B4ABB0-0x0000000189B4ABD0
	public static new RemoveUniqueModifier ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF385F */, bool useObjectPool = false /* Metadata: 0x00AF3863 */) => default; // 0x0000000184E68FA0-0x0000000184E691C0
	[BlackList] // 0x0000000189B52260-0x0000000189B522A0
	// [XID] // 0x0000000189B52260-0x0000000189B522A0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184E67F80-0x0000000184E68250
	// [XID] // 0x0000000189B5CCF0-0x0000000189B5CD10
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184E6A3A0-0x0000000184E6A5A0
	[BlackList] // 0x0000000189B64390-0x0000000189B643D0
	// [XID] // 0x0000000189B64390-0x0000000189B643D0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184E695A0-0x0000000184E69690
	// [XID] // 0x0000000189B6E820-0x0000000189B6E840
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000184E6A690-0x0000000184E6A730
	// [XID] // 0x0000000189B760D0-0x0000000189B760F0
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000184E689C0-0x0000000184E68B20
	// [XID] // 0x0000000189B8C0E0-0x0000000189B8C100
	public override void CallAuthority(MPActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt, ref RecordInvokeEntryContext context) {} // 0x0000000184E6A220-0x0000000184E6A3A0
	// [XID] // 0x0000000189B93910-0x0000000189B93930
	public override void CallRemote(MPActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, UnionAbilityInvokeEntry invokeEntry) {} // 0x0000000184E69AD0-0x0000000184E69C30
	[BlackList] // 0x0000000189B9AEC0-0x0000000189B9AF00
	// [XID] // 0x0000000189B9AEC0-0x0000000189B9AF00
	public override void AutoAllocTypeFields() {} // 0x0000000184E68250-0x0000000184E682F0
	[BlackList] // 0x0000000189BA5530-0x0000000189BA5570
	// [XID] // 0x0000000189BA5530-0x0000000189BA5570
	public override void AutoRecycleTypeFields() {} // 0x0000000184E682F0-0x0000000184E683A0
	[BlackList] // 0x0000000189BAF7A0-0x0000000189BAF7E0
	// [XID] // 0x0000000189BAF7A0-0x0000000189BAF7E0
	public override void ReturnToObjectPool() {} // 0x0000000184E6A7D0-0x0000000184E6A870
}

