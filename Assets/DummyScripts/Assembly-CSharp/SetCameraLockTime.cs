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
public class SetCameraLockTime : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16381
{
	// Fields
	private SimpleSafeFloat lockTimeRawNum; // 0x68

	// Properties
	public float lockTime { /* [XID] */ /* 0x000000018960ECC0-0x000000018960ECE0 */ get => default; /* [XID] */ /* 0x0000000189616300-0x0000000189616320 */ private set {} } // 0x000000018179ACE0-0x000000018179ADC0 0x000000018179A970-0x000000018179AA50
	protected override bool MuteAuthority { /* [XID] */ /* 0x00000001896A2140-0x00000001896A2160 */ get => default; } // 0x000000018179AA50-0x000000018179AAF0 
	protected override bool MuteRemote { /* [XID] */ /* 0x00000001896A93A0-0x00000001896A93C0 */ get => default; } // 0x0000000181799FA0-0x000000018179A040 

	// Constructors
	public SetCameraLockTime() {} // 0x000000018179B1F0-0x000000018179B250

	// Methods
	// [XID] // 0x000000018961DB70-0x000000018961DB90
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018179AFB0-0x000000018179B0B0
	// [XID] // 0x0000000189624F90-0x0000000189624FB0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018179AB50-0x000000018179AC00
	// [XID] // 0x000000018962C7F0-0x000000018962C810
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF39AC */) => default; // 0x000000018179A5E0-0x000000018179A6C0
	// [XID] // 0x0000000189634530-0x0000000189634550
	public override int GetHashNum() => default; // 0x0000000181799230-0x0000000181799300
	// [XID] // 0x000000018963BC40-0x000000018963BC60
	public override void InitEmpty() {} // 0x000000018179A040-0x000000018179A110
	[BlackList] // 0x0000000189643320-0x0000000189643360
	// [XID] // 0x0000000189643320-0x0000000189643360
	public override bool FromJson(JSONNode node) => default; // 0x0000000181799920-0x0000000181799CA0
	// [XID] // 0x000000018964DA60-0x000000018964DA80
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001817989E0-0x0000000181798C50
	[BlackList] // 0x0000000189655200-0x0000000189655240
	// [XID] // 0x0000000189655200-0x0000000189655240
	public static new SetCameraLockTime ParseFromJson(JSONNode node) => default; // 0x000000018179A720-0x000000018179A970
	// [XID] // 0x000000018965F7E0-0x000000018965F800
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF39AD */, bool useObjectPool = false /* Metadata: 0x00AF39B1 */) => default; // 0x000000018179A2E0-0x000000018179A5E0
	// [XID] // 0x0000000189667270-0x0000000189667290
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF39B2 */, bool useObjectPool = false /* Metadata: 0x00AF39B6 */) => default; // 0x0000000181799450-0x00000001817996C0
	// [XID] // 0x000000018966EA40-0x000000018966EA60
	public static new SetCameraLockTime ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF39B7 */, bool useObjectPool = false /* Metadata: 0x00AF39BB */) => default; // 0x0000000181799CA0-0x0000000181799EC0
	[BlackList] // 0x0000000189676460-0x00000001896764A0
	// [XID] // 0x0000000189676460-0x00000001896764A0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000181798C50-0x0000000181798F20
	// [XID] // 0x0000000189680F80-0x0000000189680FA0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018179ADC0-0x000000018179AFB0
	[BlackList] // 0x0000000189688940-0x0000000189688980
	// [XID] // 0x0000000189688940-0x0000000189688980
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018179A1F0-0x000000018179A2E0
	// [XID] // 0x0000000189693480-0x00000001896934A0
	public override bool isAlreadyHandledRecoverCase() => default; // 0x000000018179B0B0-0x000000018179B150
	// [XID] // 0x000000018969A7B0-0x000000018969A7D0
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x00000001817996C0-0x0000000181799820
	[BlackList] // 0x00000001896B04F0-0x00000001896B0530
	// [XID] // 0x00000001896B04F0-0x00000001896B0530
	public override void AutoAllocTypeFields() {} // 0x0000000181798F20-0x0000000181798FC0
	[BlackList] // 0x00000001896BADB0-0x00000001896BADF0
	// [XID] // 0x00000001896BADB0-0x00000001896BADF0
	public override void AutoRecycleTypeFields() {} // 0x0000000181798FC0-0x00000001817990A0
	[BlackList] // 0x00000001896C50B0-0x00000001896C50F0
	// [XID] // 0x00000001896C50B0-0x00000001896C50F0
	public override void ReturnToObjectPool() {} // 0x000000018179B150-0x000000018179B1F0
}

