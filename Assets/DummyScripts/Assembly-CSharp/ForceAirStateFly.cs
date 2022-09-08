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
public class ForceAirStateFly : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16641
{
	// Fields
	private bool _isActive; // 0x68

	// Properties
	public bool isActive { /* [XID] */ /* 0x0000000189A96CC0-0x0000000189A96CE0 */ get => default; /* [XID] */ /* 0x0000000189A9E090-0x0000000189A9E0B0 */ private set {} } // 0x00000001850781C0-0x0000000185078260 0x0000000185076BD0-0x0000000185076C80
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189B29CE0-0x0000000189B29D00 */ get => default; } // 0x0000000185077D30-0x0000000185077DD0 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189B31290-0x0000000189B312B0 */ get => default; } // 0x0000000185077380-0x0000000185077420 

	// Constructors
	public ForceAirStateFly() {} // 0x0000000185078490-0x00000001850784F0

	// Methods
	// [XID] // 0x0000000189AA5AC0-0x0000000189AA5AE0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000185078260-0x0000000185078350
	// [XID] // 0x0000000189AAD120-0x0000000189AAD140
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000185077E30-0x0000000185077EE0
	// [XID] // 0x0000000189AB4B30-0x0000000189AB4B50
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF41BA */) => default; // 0x00000001850779A0-0x0000000185077A80
	// [XID] // 0x0000000189ABC840-0x0000000189ABC860
	public override int GetHashNum() => default; // 0x00000001850765A0-0x0000000185076670
	// [XID] // 0x0000000189AC4100-0x0000000189AC4120
	public override void InitEmpty() {} // 0x0000000185077420-0x00000001850774C0
	[BlackList] // 0x0000000189ACB610-0x0000000189ACB650
	// [XID] // 0x0000000189ACB610-0x0000000189ACB650
	public override bool FromJson(JSONNode node) => default; // 0x0000000185076D00-0x0000000185077080
	// [XID] // 0x0000000189AD6540-0x0000000189AD6560
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000185075DF0-0x0000000185075FF0
	[BlackList] // 0x0000000189ADDD80-0x0000000189ADDDC0
	// [XID] // 0x0000000189ADDD80-0x0000000189ADDDC0
	public static new ForceAirStateFly ParseFromJson(JSONNode node) => default; // 0x0000000185077AE0-0x0000000185077D30
	// [XID] // 0x0000000189AE8370-0x0000000189AE8390
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF41BB */, bool useObjectPool = false /* Metadata: 0x00AF41BF */) => default; // 0x00000001850776A0-0x00000001850779A0
	// [XID] // 0x0000000189AF0310-0x0000000189AF0330
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF41C0 */, bool useObjectPool = false /* Metadata: 0x00AF41C4 */) => default; // 0x00000001850767C0-0x00000001850769F0
	// [XID] // 0x0000000189AF7780-0x0000000189AF77A0
	public static new ForceAirStateFly ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF41C5 */, bool useObjectPool = false /* Metadata: 0x00AF41C9 */) => default; // 0x0000000185077080-0x00000001850772A0
	[BlackList] // 0x0000000189AFEDB0-0x0000000189AFEDF0
	// [XID] // 0x0000000189AFEDB0-0x0000000189AFEDF0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000185075FF0-0x00000001850762C0
	// [XID] // 0x0000000189B093F0-0x0000000189B09410
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000185077FC0-0x00000001850781C0
	[BlackList] // 0x0000000189B10E50-0x0000000189B10E90
	// [XID] // 0x0000000189B10E50-0x0000000189B10E90
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001850775A0-0x00000001850776A0
	// [XID] // 0x0000000189B1B040-0x0000000189B1B060
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000185078350-0x00000001850783F0
	// [XID] // 0x0000000189B22730-0x0000000189B22750
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x00000001850769F0-0x0000000185076B50
	[BlackList] // 0x0000000189B388B0-0x0000000189B388F0
	// [XID] // 0x0000000189B388B0-0x0000000189B388F0
	public override void AutoAllocTypeFields() {} // 0x00000001850762C0-0x0000000185076360
	[BlackList] // 0x0000000189B43330-0x0000000189B43370
	// [XID] // 0x0000000189B43330-0x0000000189B43370
	public override void AutoRecycleTypeFields() {} // 0x0000000185076360-0x0000000185076410
	[BlackList] // 0x0000000189B4DA00-0x0000000189B4DA40
	// [XID] // 0x0000000189B4DA00-0x0000000189B4DA40
	public override void ReturnToObjectPool() {} // 0x00000001850783F0-0x0000000185078490
}

