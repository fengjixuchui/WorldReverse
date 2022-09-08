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
using MoleMole.Config;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class DungeonFogEffects : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16743
{
	// Fields
	private bool _enable; // 0x68
	private string _cameraFogEffectName; // 0x70
	private string _playerFogEffectName; // 0x78
	private MoleMole.Config.Vector _localOffset; // 0x80

	// Properties
	public bool enable { /* [XID] */ /* 0x0000000189A47130-0x0000000189A47150 */ get => default; /* [XID] */ /* 0x0000000189A4EA70-0x0000000189A4EA90 */ private set {} } // 0x00000001841EFFE0-0x00000001841F0080 0x00000001841F0E70-0x00000001841F0F20
	public string cameraFogEffectName { /* [XID] */ /* 0x0000000189A56100-0x0000000189A56120 */ get => default; /* [XID] */ /* 0x0000000189A5DBE0-0x0000000189A5DC00 */ private set {} } // 0x00000001841EFA90-0x00000001841EFB30 0x00000001841EFF30-0x00000001841EFFE0
	public string playerFogEffectName { /* [XID] */ /* 0x0000000189A65360-0x0000000189A65380 */ get => default; /* [XID] */ /* 0x0000000189A6CAC0-0x0000000189A6CAE0 */ private set {} } // 0x00000001841EF370-0x00000001841EF410 0x00000001841EF1F0-0x00000001841EF2A0
	public MoleMole.Config.Vector localOffset { /* [XID] */ /* 0x0000000189A74210-0x0000000189A74230 */ get => default; /* [XID] */ /* 0x0000000189A7BBC0-0x0000000189A7BBE0 */ private set {} } // 0x00000001841F0310-0x00000001841F03F0 0x00000001841F1120-0x00000001841F11F0
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189B07AB0-0x0000000189B07AD0 */ get => default; } // 0x00000001841F0F20-0x00000001841F0FC0 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189B0F390-0x0000000189B0F3B0 */ get => default; } // 0x00000001841F0460-0x00000001841F0500 

	// Constructors
	public DungeonFogEffects() {} // 0x00000001841F1970-0x00000001841F19D0

	// Methods
	// [XID] // 0x0000000189A83480-0x0000000189A834A0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001841F16C0-0x00000001841F1830
	// [XID] // 0x0000000189A8ADC0-0x0000000189A8ADE0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001841F1020-0x00000001841F1120
	// [XID] // 0x0000000189A92550-0x0000000189A92570
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF44DE */) => default; // 0x00000001841F0AE0-0x00000001841F0BC0
	// [XID] // 0x0000000189A99FE0-0x0000000189A9A000
	public override int GetHashNum() => default; // 0x00000001841EF120-0x00000001841EF1F0
	// [XID] // 0x0000000189AA0FA0-0x0000000189AA0FC0
	public override void InitEmpty() {} // 0x00000001841F0500-0x00000001841F0600
	[BlackList] // 0x0000000189AA8660-0x0000000189AA86A0
	// [XID] // 0x0000000189AA8660-0x0000000189AA86A0
	public override bool FromJson(JSONNode node) => default; // 0x00000001841EFBB0-0x00000001841EFF30
	// [XID] // 0x0000000189AB3260-0x0000000189AB3280
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001841EE6B0-0x00000001841EEB50
	[BlackList] // 0x0000000189ABAF90-0x0000000189ABAFD0
	// [XID] // 0x0000000189ABAF90-0x0000000189ABAFD0
	public static new DungeonFogEffects ParseFromJson(JSONNode node) => default; // 0x00000001841F0C20-0x00000001841F0E70
	// [XID] // 0x0000000189AC58F0-0x0000000189AC5910
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF44DF */, bool useObjectPool = false /* Metadata: 0x00AF44E3 */) => default; // 0x00000001841F07E0-0x00000001841F0AE0
	// [XID] // 0x0000000189ACCE40-0x0000000189ACCE60
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF44E4 */, bool useObjectPool = false /* Metadata: 0x00AF44E8 */) => default; // 0x00000001841EF490-0x00000001841EF8B0
	// [XID] // 0x0000000189AD4AA0-0x0000000189AD4AC0
	public static new DungeonFogEffects ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF44E9 */, bool useObjectPool = false /* Metadata: 0x00AF44ED */) => default; // 0x00000001841F0080-0x00000001841F02A0
	[BlackList] // 0x0000000189ADC400-0x0000000189ADC440
	// [XID] // 0x0000000189ADC400-0x0000000189ADC440
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001841EEB50-0x00000001841EEE20
	// [XID] // 0x0000000189AE6DF0-0x0000000189AE6E10
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001841F12D0-0x00000001841F16C0
	[BlackList] // 0x0000000189AEE900-0x0000000189AEE940
	// [XID] // 0x0000000189AEE900-0x0000000189AEE940
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001841F06E0-0x00000001841F07E0
	// [XID] // 0x0000000189AF9070-0x0000000189AF9090
	public override bool isAlreadyHandledRecoverCase() => default; // 0x00000001841F1830-0x00000001841F18D0
	// [XID] // 0x0000000189B00630-0x0000000189B00650
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x00000001841EF8B0-0x00000001841EFA10
	[BlackList] // 0x0000000189B166D0-0x0000000189B16710
	// [XID] // 0x0000000189B166D0-0x0000000189B16710
	public override void AutoAllocTypeFields() {} // 0x00000001841EEE20-0x00000001841EEEC0
	[BlackList] // 0x0000000189B20D90-0x0000000189B20DD0
	// [XID] // 0x0000000189B20D90-0x0000000189B20DD0
	public override void AutoRecycleTypeFields() {} // 0x00000001841EEEC0-0x00000001841EEF90
	[BlackList] // 0x0000000189B2B470-0x0000000189B2B4B0
	// [XID] // 0x0000000189B2B470-0x0000000189B2B4B0
	public override void ReturnToObjectPool() {} // 0x00000001841F18D0-0x00000001841F1970
}

