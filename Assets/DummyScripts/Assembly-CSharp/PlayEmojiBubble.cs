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
public class PlayEmojiBubble : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16623
{
	// Fields
	private string _name; // 0x68

	// Properties
	public string name { /* [XID] */ /* 0x000000018990E930-0x000000018990E950 */ get => default; /* [XID] */ /* 0x0000000189915F60-0x0000000189915F80 */ private set {} } // 0x0000000185B32380-0x0000000185B32420 0x0000000185B31340-0x0000000185B313F0
	protected override bool MuteAuthority { /* [XID] */ /* 0x00000001899A1C50-0x00000001899A1C70 */ get => default; } // 0x0000000185B31D30-0x0000000185B31DD0 
	protected override bool MuteRemote { /* [XID] */ /* 0x00000001899A9460-0x00000001899A9480 */ get => default; } // 0x0000000185B312A0-0x0000000185B31340 

	// Constructors
	public PlayEmojiBubble() {} // 0x0000000185B324C0-0x0000000185B32520

	// Methods
	// [XID] // 0x000000018991DA10-0x000000018991DA30
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000185B321F0-0x0000000185B322E0
	// [XID] // 0x0000000189925120-0x0000000189925140
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000185B31E30-0x0000000185B31F10
	// [XID] // 0x000000018992C740-0x000000018992C760
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF412A */) => default; // 0x0000000185B319A0-0x0000000185B31A80
	// [XID] // 0x0000000189933E60-0x0000000189933E80
	public override int GetHashNum() => default; // 0x0000000185B30530-0x0000000185B30600
	// [XID] // 0x000000018993B990-0x000000018993B9B0
	public override void InitEmpty() {} // 0x0000000185B313F0-0x0000000185B314C0
	[BlackList] // 0x0000000189942AF0-0x0000000189942B30
	// [XID] // 0x0000000189942AF0-0x0000000189942B30
	public override bool FromJson(JSONNode node) => default; // 0x0000000185B30C20-0x0000000185B30FA0
	// [XID] // 0x000000018994D210-0x000000018994D230
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000185B2FD50-0x0000000185B2FF80
	[BlackList] // 0x0000000189954A20-0x0000000189954A60
	// [XID] // 0x0000000189954A20-0x0000000189954A60
	public static new PlayEmojiBubble ParseFromJson(JSONNode node) => default; // 0x0000000185B31AE0-0x0000000185B31D30
	// [XID] // 0x000000018995F430-0x000000018995F450
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF412B */, bool useObjectPool = false /* Metadata: 0x00AF412F */) => default; // 0x0000000185B316A0-0x0000000185B319A0
	// [XID] // 0x0000000189966D50-0x0000000189966D70
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4130 */, bool useObjectPool = false /* Metadata: 0x00AF4134 */) => default; // 0x0000000185B30750-0x0000000185B309C0
	// [XID] // 0x000000018996E040-0x000000018996E060
	public static new PlayEmojiBubble ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4135 */, bool useObjectPool = false /* Metadata: 0x00AF4139 */) => default; // 0x0000000185B30FA0-0x0000000185B311C0
	[BlackList] // 0x0000000189975C50-0x0000000189975C90
	// [XID] // 0x0000000189975C50-0x0000000189975C90
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000185B2FF80-0x0000000185B30250
	// [XID] // 0x00000001899801E0-0x0000000189980200
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000185B31FF0-0x0000000185B321F0
	[BlackList] // 0x0000000189987A30-0x0000000189987A70
	// [XID] // 0x0000000189987A30-0x0000000189987A70
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000185B315A0-0x0000000185B316A0
	// [XID] // 0x0000000189992770-0x0000000189992790
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000185B322E0-0x0000000185B32380
	// [XID] // 0x000000018999A570-0x000000018999A590
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000185B309C0-0x0000000185B30B20
	[BlackList] // 0x00000001899B0F70-0x00000001899B0FB0
	// [XID] // 0x00000001899B0F70-0x00000001899B0FB0
	public override void AutoAllocTypeFields() {} // 0x0000000185B30250-0x0000000185B302F0
	[BlackList] // 0x00000001899BB390-0x00000001899BB3D0
	// [XID] // 0x00000001899BB390-0x00000001899BB3D0
	public override void AutoRecycleTypeFields() {} // 0x0000000185B302F0-0x0000000185B303A0
	[BlackList] // 0x00000001899C5D90-0x00000001899C5DD0
	// [XID] // 0x00000001899C5D90-0x00000001899C5DD0
	public override void ReturnToObjectPool() {} // 0x0000000185B32420-0x0000000185B324C0
}

