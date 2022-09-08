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
public class FireGainCrystalSeedEvent : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16769
{
	// Fields
	private ElementType _elementType; // 0x68

	// Properties
	public ElementType elementType { /* [XID] */ /* 0x00000001899CEB40-0x00000001899CEB60 */ get => default; /* [XID] */ /* 0x00000001899D6290-0x00000001899D62B0 */ private set {} } // 0x000000018240B3E0-0x000000018240B480 0x000000018240C2F0-0x000000018240C3A0
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189A59040-0x0000000189A59060 */ get => default; } // 0x000000018240C5F0-0x000000018240C690 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189A60980-0x0000000189A609A0 */ get => default; } // 0x000000018240BB90-0x000000018240BC30 

	// Constructors
	public FireGainCrystalSeedEvent() {} // 0x000000018240CC10-0x000000018240CC70

	// Methods
	// [XID] // 0x00000001899DD700-0x00000001899DD720
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018240CA80-0x000000018240CB70
	// [XID] // 0x00000001899E5420-0x00000001899E5440
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018240C6F0-0x000000018240C7A0
	// [XID] // 0x00000001899EC750-0x00000001899EC770
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF45AE */) => default; // 0x000000018240C1B0-0x000000018240C290
	// [XID] // 0x00000001899F4470-0x00000001899F4490
	public override int GetHashNum() => default; // 0x000000018240AE30-0x000000018240AF00
	// [XID] // 0x00000001899FBA30-0x00000001899FBA50
	public override void InitEmpty() {} // 0x000000018240BC30-0x000000018240BCD0
	[BlackList] // 0x0000000189A02DF0-0x0000000189A02E30
	// [XID] // 0x0000000189A02DF0-0x0000000189A02E30
	public override bool FromJson(JSONNode node) => default; // 0x000000018240B580-0x000000018240B900
	// [XID] // 0x0000000189A0D460-0x0000000189A0D480
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018240A660-0x000000018240A880
	[BlackList] // 0x0000000189A14C20-0x0000000189A14C60
	// [XID] // 0x0000000189A14C20-0x0000000189A14C60
	public static new FireGainCrystalSeedEvent ParseFromJson(JSONNode node) => default; // 0x000000018240C3A0-0x000000018240C5F0
	// [XID] // 0x0000000189A1EE50-0x0000000189A1EE70
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF45AF */, bool useObjectPool = false /* Metadata: 0x00AF45B3 */) => default; // 0x000000018240BEB0-0x000000018240C1B0
	// [XID] // 0x0000000189A264A0-0x0000000189A264C0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF45B4 */, bool useObjectPool = false /* Metadata: 0x00AF45B8 */) => default; // 0x000000018240B050-0x000000018240B280
	// [XID] // 0x0000000189A2D770-0x0000000189A2D790
	public static new FireGainCrystalSeedEvent ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF45B9 */, bool useObjectPool = false /* Metadata: 0x00AF45BD */) => default; // 0x000000018240B900-0x000000018240BB20
	[BlackList] // 0x0000000189A352B0-0x0000000189A352F0
	// [XID] // 0x0000000189A352B0-0x0000000189A352F0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018240A880-0x000000018240AB50
	// [XID] // 0x0000000189A3F9A0-0x0000000189A3F9C0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018240C880-0x000000018240CA80
	[BlackList] // 0x0000000189A470F0-0x0000000189A47130
	// [XID] // 0x0000000189A470F0-0x0000000189A47130
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018240BDB0-0x000000018240BEB0
	// [XID] // 0x0000000189A51830-0x0000000189A51850
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x000000018240B280-0x000000018240B3E0
	[BlackList] // 0x0000000189A68790-0x0000000189A687D0
	// [XID] // 0x0000000189A68790-0x0000000189A687D0
	public override void AutoAllocTypeFields() {} // 0x000000018240AB50-0x000000018240ABF0
	[BlackList] // 0x0000000189A72C00-0x0000000189A72C40
	// [XID] // 0x0000000189A72C00-0x0000000189A72C40
	public override void AutoRecycleTypeFields() {} // 0x000000018240ABF0-0x000000018240ACA0
	[BlackList] // 0x0000000189A7D510-0x0000000189A7D550
	// [XID] // 0x0000000189A7D510-0x0000000189A7D550
	public override void ReturnToObjectPool() {} // 0x000000018240CB70-0x000000018240CC10
}

