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
public class ShowProgressBarAction : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16749
{
	// Fields
	private bool _show; // 0x68

	// Properties
	public bool show { /* [XID] */ /* 0x00000001896E8660-0x00000001896E8680 */ get => default; /* [XID] */ /* 0x00000001896EFB20-0x00000001896EFB40 */ private set {} } // 0x000000018457E8A0-0x000000018457E940 0x000000018457F510-0x000000018457F5C0
	protected override bool MuteAuthority { /* [XID] */ /* 0x00000001897730A0-0x00000001897730C0 */ get => default; } // 0x000000018457F360-0x000000018457F400 
	protected override bool MuteRemote { /* [XID] */ /* 0x000000018977A680-0x000000018977A6A0 */ get => default; } // 0x000000018457E9B0-0x000000018457EA50 

	// Constructors
	public ShowProgressBarAction() {} // 0x000000018457FA30-0x000000018457FAA0

	// Methods
	// [XID] // 0x00000001896F7570-0x00000001896F7590
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018457F8A0-0x000000018457F990
	// [XID] // 0x00000001896FEF30-0x00000001896FEF50
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018457F460-0x000000018457F510
	// [XID] // 0x0000000189706180-0x00000001897061A0
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF450E */) => default; // 0x000000018457EFD0-0x000000018457F0B0
	// [XID] // 0x000000018970DAB0-0x000000018970DAD0
	public override int GetHashNum() => default; // 0x000000018457DC50-0x000000018457DD20
	// [XID] // 0x0000000189714ED0-0x0000000189714EF0
	public override void InitEmpty() {} // 0x000000018457EA50-0x000000018457EAF0
	[BlackList] // 0x000000018971C9A0-0x000000018971C9E0
	// [XID] // 0x000000018971C9A0-0x000000018971C9E0
	public override bool FromJson(JSONNode node) => default; // 0x000000018457E300-0x000000018457E680
	// [XID] // 0x0000000189727040-0x0000000189727060
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018457D4A0-0x000000018457D6A0
	[BlackList] // 0x000000018972E590-0x000000018972E5D0
	// [XID] // 0x000000018972E590-0x000000018972E5D0
	public static new ShowProgressBarAction ParseFromJson(JSONNode node) => default; // 0x000000018457F110-0x000000018457F360
	// [XID] // 0x0000000189738D70-0x0000000189738D90
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF450F */, bool useObjectPool = false /* Metadata: 0x00AF4513 */) => default; // 0x000000018457ECD0-0x000000018457EFD0
	// [XID] // 0x0000000189740B80-0x0000000189740BA0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4514 */, bool useObjectPool = false /* Metadata: 0x00AF4518 */) => default; // 0x000000018457DE70-0x000000018457E0A0
	// [XID] // 0x0000000189747FC0-0x0000000189747FE0
	public static new ShowProgressBarAction ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4519 */, bool useObjectPool = false /* Metadata: 0x00AF451D */) => default; // 0x000000018457E680-0x000000018457E8A0
	[BlackList] // 0x000000018974F710-0x000000018974F750
	// [XID] // 0x000000018974F710-0x000000018974F750
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018457D6A0-0x000000018457D970
	// [XID] // 0x00000001897599A0-0x00000001897599C0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018457F6A0-0x000000018457F8A0
	[BlackList] // 0x00000001897615D0-0x0000000189761610
	// [XID] // 0x00000001897615D0-0x0000000189761610
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018457EBD0-0x000000018457ECD0
	// [XID] // 0x000000018976BB40-0x000000018976BB60
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x000000018457E0A0-0x000000018457E200
	[BlackList] // 0x0000000189782260-0x00000001897822A0
	// [XID] // 0x0000000189782260-0x00000001897822A0
	public override void AutoAllocTypeFields() {} // 0x000000018457D970-0x000000018457DA10
	[BlackList] // 0x000000018978C650-0x000000018978C690
	// [XID] // 0x000000018978C650-0x000000018978C690
	public override void AutoRecycleTypeFields() {} // 0x000000018457DA10-0x000000018457DAC0
	[BlackList] // 0x0000000189796D90-0x0000000189796DD0
	// [XID] // 0x0000000189796D90-0x0000000189796DD0
	public override void ReturnToObjectPool() {} // 0x000000018457F990-0x000000018457FA30
}

