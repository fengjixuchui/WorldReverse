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
public class PaimonAction : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16633
{
	// Fields
	private PaimonRequestFrom _from; // 0x68
	private PaimonSkill _actionName; // 0x6C

	// Properties
	public PaimonRequestFrom from { /* [XID] */ /* 0x000000018971B480-0x000000018971B4A0 */ get => default; /* [XID] */ /* 0x00000001897226A0-0x00000001897226C0 */ private set {} } // 0x000000018188CB70-0x000000018188CC10 0x000000018188CE90-0x000000018188CF40
	public PaimonSkill actionName { /* [XID] */ /* 0x0000000189729E00-0x0000000189729E20 */ get => default; /* [XID] */ /* 0x0000000189731520-0x0000000189731540 */ private set {} } // 0x000000018188BC10-0x000000018188BCB0 0x000000018188D320-0x000000018188D3D0
	protected override bool MuteAuthority { /* [XID] */ /* 0x00000001897BD960-0x00000001897BD980 */ get => default; } // 0x000000018188D680-0x000000018188D720 
	protected override bool MuteRemote { /* [XID] */ /* 0x00000001897C4CC0-0x00000001897C4CE0 */ get => default; } // 0x000000018188CAD0-0x000000018188CB70 

	// Constructors
	public PaimonAction() {} // 0x000000018188DDF0-0x000000018188DE50

	// Methods
	// [XID] // 0x0000000189738DD0-0x0000000189738DF0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018188DBA0-0x000000018188DCB0
	// [XID] // 0x0000000189740BC0-0x0000000189740BE0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018188D780-0x000000018188D830
	// [XID] // 0x0000000189748000-0x0000000189748020
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF417A */) => default; // 0x000000018188D240-0x000000018188D320
	// [XID] // 0x000000018974F790-0x000000018974F7B0
	public override int GetHashNum() => default; // 0x000000018188BD30-0x000000018188BE00
	// [XID] // 0x0000000189756E20-0x0000000189756E40
	public override void InitEmpty() {} // 0x000000018188CC10-0x000000018188CCB0
	[BlackList] // 0x000000018975E2B0-0x000000018975E2F0
	// [XID] // 0x000000018975E2B0-0x000000018975E2F0
	public override bool FromJson(JSONNode node) => default; // 0x000000018188C450-0x000000018188C7D0
	// [XID] // 0x0000000189768980-0x00000001897689A0
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018188B3E0-0x000000018188B6E0
	[BlackList] // 0x000000018976FFF0-0x0000000189770030
	// [XID] // 0x000000018976FFF0-0x0000000189770030
	public static new PaimonAction ParseFromJson(JSONNode node) => default; // 0x000000018188D430-0x000000018188D680
	// [XID] // 0x000000018977A6E0-0x000000018977A700
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF417B */, bool useObjectPool = false /* Metadata: 0x00AF417F */) => default; // 0x000000018188CF40-0x000000018188D240
	// [XID] // 0x0000000189782300-0x0000000189782320
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4180 */, bool useObjectPool = false /* Metadata: 0x00AF4184 */) => default; // 0x000000018188BF50-0x000000018188C1F0
	// [XID] // 0x0000000189789680-0x00000001897896A0
	public static new PaimonAction ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4185 */, bool useObjectPool = false /* Metadata: 0x00AF4189 */) => default; // 0x000000018188C7D0-0x000000018188C9F0
	[BlackList] // 0x0000000189790DB0-0x0000000189790DF0
	// [XID] // 0x0000000189790DB0-0x0000000189790DF0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018188B6E0-0x000000018188B9B0
	// [XID] // 0x000000018979BEB0-0x000000018979BED0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018188D910-0x000000018188DBA0
	[BlackList] // 0x00000001897A3300-0x00000001897A3340
	// [XID] // 0x00000001897A3300-0x00000001897A3340
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018188CD90-0x000000018188CE90
	// [XID] // 0x00000001897ADA30-0x00000001897ADA50
	public override bool isAlreadyHandledRecoverCase() => default; // 0x000000018188DCB0-0x000000018188DD50
	// [XID] // 0x00000001897B5B70-0x00000001897B5B90
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x000000018188C1F0-0x000000018188C350
	[BlackList] // 0x00000001897CC4D0-0x00000001897CC510
	// [XID] // 0x00000001897CC4D0-0x00000001897CC510
	public override void AutoAllocTypeFields() {} // 0x000000018188B9B0-0x000000018188BA50
	[BlackList] // 0x00000001897D6EA0-0x00000001897D6EE0
	// [XID] // 0x00000001897D6EA0-0x00000001897D6EE0
	public override void AutoRecycleTypeFields() {} // 0x000000018188BA50-0x000000018188BB00
	[BlackList] // 0x00000001897E1700-0x00000001897E1740
	// [XID] // 0x00000001897E1700-0x00000001897E1740
	public override void ReturnToObjectPool() {} // 0x000000018188DD50-0x000000018188DDF0
}

