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
public class ShowScreenEffect : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16667
{
	// Fields
	private EffectType _effectType; // 0x68
	private bool _show; // 0x6C

	// Properties
	public EffectType effectType { /* [XID] */ /* 0x0000000189882FF0-0x0000000189883010 */ get => default; /* [XID] */ /* 0x000000018988A7D0-0x000000018988A7F0 */ private set {} } // 0x000000018196DD10-0x000000018196DDB0 0x000000018196CD60-0x000000018196CE10
	public bool show { /* [XID] */ /* 0x0000000189891C60-0x0000000189891C80 */ get => default; /* [XID] */ /* 0x00000001898994F0-0x0000000189899510 */ private set {} } // 0x000000018196D030-0x000000018196D0D0 0x000000018196DDB0-0x000000018196DE60
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189925100-0x0000000189925120 */ get => default; } // 0x000000018196DB60-0x000000018196DC00 
	protected override bool MuteRemote { /* [XID] */ /* 0x000000018992C720-0x000000018992C740 */ get => default; } // 0x000000018196D1B0-0x000000018196D250 

	// Constructors
	public ShowScreenEffect() {} // 0x000000018196E420-0x000000018196E480

	// Methods
	// [XID] // 0x00000001898A06F0-0x00000001898A0710
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018196E1D0-0x000000018196E2E0
	// [XID] // 0x00000001898A7E30-0x00000001898A7E50
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018196DC60-0x000000018196DD10
	// [XID] // 0x00000001898AF930-0x00000001898AF950
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF427E */) => default; // 0x000000018196D7D0-0x000000018196D8B0
	// [XID] // 0x00000001898B6ED0-0x00000001898B6EF0
	public override int GetHashNum() => default; // 0x000000018196C2C0-0x000000018196C390
	// [XID] // 0x00000001898BE660-0x00000001898BE680
	public override void InitEmpty() {} // 0x000000018196D250-0x000000018196D2F0
	[BlackList] // 0x00000001898C5E30-0x00000001898C5E70
	// [XID] // 0x00000001898C5E30-0x00000001898C5E70
	public override bool FromJson(JSONNode node) => default; // 0x000000018196C9E0-0x000000018196CD60
	// [XID] // 0x00000001898D0860-0x00000001898D0880
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018196BA30-0x000000018196BD10
	[BlackList] // 0x00000001898D7F20-0x00000001898D7F60
	// [XID] // 0x00000001898D7F20-0x00000001898D7F60
	public static new ShowScreenEffect ParseFromJson(JSONNode node) => default; // 0x000000018196D910-0x000000018196DB60
	// [XID] // 0x00000001898E2BE0-0x00000001898E2C00
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF427F */, bool useObjectPool = false /* Metadata: 0x00AF4283 */) => default; // 0x000000018196D4D0-0x000000018196D7D0
	// [XID] // 0x00000001898EA7F0-0x00000001898EA810
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4284 */, bool useObjectPool = false /* Metadata: 0x00AF4288 */) => default; // 0x000000018196C4E0-0x000000018196C780
	// [XID] // 0x00000001898F1ED0-0x00000001898F1EF0
	public static new ShowScreenEffect ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4289 */, bool useObjectPool = false /* Metadata: 0x00AF428D */) => default; // 0x000000018196CE10-0x000000018196D030
	[BlackList] // 0x00000001898F9770-0x00000001898F97B0
	// [XID] // 0x00000001898F9770-0x00000001898F97B0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018196BD10-0x000000018196BFE0
	// [XID] // 0x0000000189904030-0x0000000189904050
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018196DF40-0x000000018196E1D0
	[BlackList] // 0x000000018990B5F0-0x000000018990B630
	// [XID] // 0x000000018990B5F0-0x000000018990B630
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018196D3D0-0x000000018196D4D0
	// [XID] // 0x0000000189915F40-0x0000000189915F60
	public override bool isAlreadyHandledRecoverCase() => default; // 0x000000018196E2E0-0x000000018196E380
	// [XID] // 0x000000018991D9F0-0x000000018991DA10
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x000000018196C780-0x000000018196C8E0
	[BlackList] // 0x0000000189933E20-0x0000000189933E60
	// [XID] // 0x0000000189933E20-0x0000000189933E60
	public override void AutoAllocTypeFields() {} // 0x000000018196BFE0-0x000000018196C080
	[BlackList] // 0x000000018993E770-0x000000018993E7B0
	// [XID] // 0x000000018993E770-0x000000018993E7B0
	public override void AutoRecycleTypeFields() {} // 0x000000018196C080-0x000000018196C130
	[BlackList] // 0x0000000189948EC0-0x0000000189948F00
	// [XID] // 0x0000000189948EC0-0x0000000189948F00
	public override void ReturnToObjectPool() {} // 0x000000018196E380-0x000000018196E420
}

