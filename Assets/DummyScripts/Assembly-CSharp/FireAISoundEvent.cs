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
public class FireAISoundEvent : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16593
{
	// Fields
	private SimpleSafeFloat volumeRawNum; // 0x68

	// Properties
	public float volume { /* [XID] */ /* 0x00000001898A9810-0x00000001898A9830 */ get => default; /* [XID] */ /* 0x00000001898B10A0-0x00000001898B10C0 */ private set {} } // 0x0000000183D43220-0x0000000183D43300 0x0000000183D41870-0x0000000183D41950
	protected override bool MuteAuthority { /* [XID] */ /* 0x000000018993D0B0-0x000000018993D0D0 */ get => default; } // 0x0000000183D42F90-0x0000000183D43030 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189944660-0x0000000189944680 */ get => default; } // 0x0000000183D425B0-0x0000000183D42650 

	// Constructors
	public FireAISoundEvent() {} // 0x0000000183D43740-0x0000000183D437E0

	// Methods
	// [XID] // 0x00000001898B8880-0x00000001898B88A0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183D43500-0x0000000183D43600
	// [XID] // 0x00000001898BFF80-0x00000001898BFFA0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183D43090-0x0000000183D43140
	// [XID] // 0x00000001898C7860-0x00000001898C7880
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF403A */) => default; // 0x0000000183D42C00-0x0000000183D42CE0
	// [XID] // 0x00000001898CEF10-0x00000001898CEF30
	public override int GetHashNum() => default; // 0x0000000183D417A0-0x0000000183D41870
	// [XID] // 0x00000001898D6940-0x00000001898D6960
	public override void InitEmpty() {} // 0x0000000183D42650-0x0000000183D42730
	[BlackList] // 0x00000001898DE540-0x00000001898DE580
	// [XID] // 0x00000001898DE540-0x00000001898DE580
	public override bool FromJson(JSONNode node) => default; // 0x0000000183D41F30-0x0000000183D422B0
	// [XID] // 0x00000001898E8F80-0x00000001898E8FA0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183D40F70-0x0000000183D411C0
	[BlackList] // 0x00000001898F06E0-0x00000001898F0720
	// [XID] // 0x00000001898F06E0-0x00000001898F0720
	public static new FireAISoundEvent ParseFromJson(JSONNode node) => default; // 0x0000000183D42D40-0x0000000183D42F90
	// [XID] // 0x00000001898FAD40-0x00000001898FAD60
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF403B */, bool useObjectPool = false /* Metadata: 0x00AF403F */) => default; // 0x0000000183D42900-0x0000000183D42C00
	// [XID] // 0x0000000189902880-0x00000001899028A0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4040 */, bool useObjectPool = false /* Metadata: 0x00AF4044 */) => default; // 0x0000000183D41AA0-0x0000000183D41CD0
	// [XID] // 0x0000000189909E80-0x0000000189909EA0
	public static new FireAISoundEvent ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4045 */, bool useObjectPool = false /* Metadata: 0x00AF4049 */) => default; // 0x0000000183D422B0-0x0000000183D424D0
	[BlackList] // 0x0000000189911700-0x0000000189911740
	// [XID] // 0x0000000189911700-0x0000000189911740
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000183D411C0-0x0000000183D41490
	// [XID] // 0x000000018991C400-0x000000018991C420
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183D43300-0x0000000183D43500
	[BlackList] // 0x0000000189923AE0-0x0000000189923B20
	// [XID] // 0x0000000189923AE0-0x0000000189923B20
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183D42810-0x0000000183D42900
	// [XID] // 0x000000018992E150-0x000000018992E170
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000183D43600-0x0000000183D436A0
	// [XID] // 0x0000000189935510-0x0000000189935530
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000183D41CD0-0x0000000183D41E30
	[BlackList] // 0x000000018994BC80-0x000000018994BCC0
	// [XID] // 0x000000018994BC80-0x000000018994BCC0
	public override void AutoAllocTypeFields() {} // 0x0000000183D41490-0x0000000183D41530
	[BlackList] // 0x00000001899561E0-0x0000000189956220
	// [XID] // 0x00000001899561E0-0x0000000189956220
	public override void AutoRecycleTypeFields() {} // 0x0000000183D41530-0x0000000183D41610
	[BlackList] // 0x0000000189960C00-0x0000000189960C40
	// [XID] // 0x0000000189960C00-0x0000000189960C40
	public override void ReturnToObjectPool() {} // 0x0000000183D436A0-0x0000000183D43740
}

