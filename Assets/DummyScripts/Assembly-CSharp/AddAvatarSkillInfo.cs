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
public class AddAvatarSkillInfo : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16617
{
	// Fields
	private SimpleSafeUInt32 skillIDRawNum; // 0x68

	// Properties
	public uint skillID { /* [XID] */ /* 0x00000001896B65A0-0x00000001896B65C0 */ get => default; /* [XID] */ /* 0x00000001896BD880-0x00000001896BD8A0 */ private set {} } // 0x0000000183AD1DC0-0x0000000183AD1E90 0x0000000183AD2C80-0x0000000183AD2D60
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189748020-0x0000000189748040 */ get => default; } // 0x0000000183AD27C0-0x0000000183AD2860 
	protected override bool MuteRemote { /* [XID] */ /* 0x000000018974F7B0-0x000000018974F7D0 */ get => default; } // 0x0000000183AD1D20-0x0000000183AD1DC0 

	// Constructors
	public AddAvatarSkillInfo() {} // 0x0000000183AD2F90-0x0000000183AD2FF0

	// Methods
	// [XID] // 0x00000001896C5030-0x00000001896C5050
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183AD2D60-0x0000000183AD2E50
	// [XID] // 0x00000001896CC610-0x00000001896CC630
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183AD28C0-0x0000000183AD2970
	// [XID] // 0x00000001896D38A0-0x00000001896D38C0
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF40FA */) => default; // 0x0000000183AD2430-0x0000000183AD2510
	// [XID] // 0x00000001896DB3C0-0x00000001896DB3E0
	public override int GetHashNum() => default; // 0x0000000183AD0FB0-0x0000000183AD1080
	// [XID] // 0x00000001896E2AA0-0x00000001896E2AC0
	public override void InitEmpty() {} // 0x0000000183AD1E90-0x0000000183AD1F60
	[BlackList] // 0x00000001896EA040-0x00000001896EA080
	// [XID] // 0x00000001896EA040-0x00000001896EA080
	public override bool FromJson(JSONNode node) => default; // 0x0000000183AD16A0-0x0000000183AD1A20
	// [XID] // 0x00000001896F45E0-0x00000001896F4600
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183AD0770-0x0000000183AD09D0
	[BlackList] // 0x00000001896FBDF0-0x00000001896FBE30
	// [XID] // 0x00000001896FBDF0-0x00000001896FBE30
	public static new AddAvatarSkillInfo ParseFromJson(JSONNode node) => default; // 0x0000000183AD2570-0x0000000183AD27C0
	// [XID] // 0x00000001897061E0-0x0000000189706200
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF40FB */, bool useObjectPool = false /* Metadata: 0x00AF40FF */) => default; // 0x0000000183AD2130-0x0000000183AD2430
	// [XID] // 0x000000018970DB30-0x000000018970DB50
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4100 */, bool useObjectPool = false /* Metadata: 0x00AF4104 */) => default; // 0x0000000183AD11D0-0x0000000183AD1440
	// [XID] // 0x0000000189714F10-0x0000000189714F30
	public static new AddAvatarSkillInfo ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4105 */, bool useObjectPool = false /* Metadata: 0x00AF4109 */) => default; // 0x0000000183AD1A20-0x0000000183AD1C40
	[BlackList] // 0x000000018971CA00-0x000000018971CA40
	// [XID] // 0x000000018971CA00-0x000000018971CA40
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000183AD09D0-0x0000000183AD0CA0
	// [XID] // 0x00000001897270A0-0x00000001897270C0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183AD2A50-0x0000000183AD2C80
	[BlackList] // 0x000000018972E650-0x000000018972E690
	// [XID] // 0x000000018972E650-0x000000018972E690
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183AD2040-0x0000000183AD2130
	// [XID] // 0x0000000189738DF0-0x0000000189738E10
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000183AD2E50-0x0000000183AD2EF0
	// [XID] // 0x0000000189740BE0-0x0000000189740C00
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000183AD1440-0x0000000183AD15A0
	[BlackList] // 0x0000000189756E40-0x0000000189756E80
	// [XID] // 0x0000000189756E40-0x0000000189756E80
	public override void AutoAllocTypeFields() {} // 0x0000000183AD0CA0-0x0000000183AD0D40
	[BlackList] // 0x0000000189761650-0x0000000189761690
	// [XID] // 0x0000000189761650-0x0000000189761690
	public override void AutoRecycleTypeFields() {} // 0x0000000183AD0D40-0x0000000183AD0E20
	[BlackList] // 0x000000018976BB80-0x000000018976BBC0
	// [XID] // 0x000000018976BB80-0x000000018976BBC0
	public override void ReturnToObjectPool() {} // 0x0000000183AD2EF0-0x0000000183AD2F90
}

