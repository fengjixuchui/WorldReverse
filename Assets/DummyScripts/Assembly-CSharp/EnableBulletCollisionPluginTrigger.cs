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
public class EnableBulletCollisionPluginTrigger : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16627
{
	// Fields
	private bool _setEnable; // 0x68

	// Properties
	public bool setEnable { /* [XID] */ /* 0x0000000189A9FB10-0x0000000189A9FB30 */ get => default; /* [XID] */ /* 0x0000000189AA7300-0x0000000189AA7320 */ private set {} } // 0x0000000181080A40-0x0000000181080AE0 0x0000000181081720-0x00000001810817D0
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189B329E0-0x0000000189B32A00 */ get => default; } // 0x0000000181081490-0x0000000181081530 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189B3A2D0-0x0000000189B3A2F0 */ get => default; } // 0x0000000181080AE0-0x0000000181080B80 

	// Constructors
	public EnableBulletCollisionPluginTrigger() {} // 0x0000000181081C00-0x0000000181081C60

	// Methods
	// [XID] // 0x0000000189AAEA00-0x0000000189AAEA20
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001810819D0-0x0000000181081AC0
	// [XID] // 0x0000000189AB6300-0x0000000189AB6320
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000181081590-0x0000000181081640
	// [XID] // 0x0000000189ABDDB0-0x0000000189ABDDD0
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF414A */) => default; // 0x0000000181081100-0x00000001810811E0
	// [XID] // 0x0000000189AC5910-0x0000000189AC5930
	public override int GetHashNum() => default; // 0x000000018107FD10-0x000000018107FDE0
	// [XID] // 0x0000000189ACCE80-0x0000000189ACCEA0
	public override void InitEmpty() {} // 0x0000000181080B80-0x0000000181080C20
	[BlackList] // 0x0000000189AD4B00-0x0000000189AD4B40
	// [XID] // 0x0000000189AD4B00-0x0000000189AD4B40
	public override bool FromJson(JSONNode node) => default; // 0x00000001810803C0-0x0000000181080740
	// [XID] // 0x0000000189ADF610-0x0000000189ADF630
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018107F560-0x000000018107F760
	[BlackList] // 0x0000000189AE6E10-0x0000000189AE6E50
	// [XID] // 0x0000000189AE6E10-0x0000000189AE6E50
	public static new EnableBulletCollisionPluginTrigger ParseFromJson(JSONNode node) => default; // 0x0000000181081240-0x0000000181081490
	// [XID] // 0x0000000189AF1950-0x0000000189AF1970
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF414B */, bool useObjectPool = false /* Metadata: 0x00AF414F */) => default; // 0x0000000181080E00-0x0000000181081100
	// [XID] // 0x0000000189AF90B0-0x0000000189AF90D0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4150 */, bool useObjectPool = false /* Metadata: 0x00AF4154 */) => default; // 0x000000018107FF30-0x0000000181080160
	// [XID] // 0x0000000189B00670-0x0000000189B00690
	public static new EnableBulletCollisionPluginTrigger ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4155 */, bool useObjectPool = false /* Metadata: 0x00AF4159 */) => default; // 0x0000000181080740-0x0000000181080960
	[BlackList] // 0x0000000189B07B50-0x0000000189B07B90
	// [XID] // 0x0000000189B07B50-0x0000000189B07B90
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018107F760-0x000000018107FA30
	// [XID] // 0x0000000189B123E0-0x0000000189B12400
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001810817D0-0x00000001810819D0
	[BlackList] // 0x0000000189B196D0-0x0000000189B19710
	// [XID] // 0x0000000189B196D0-0x0000000189B19710
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000181080D00-0x0000000181080E00
	// [XID] // 0x0000000189B24020-0x0000000189B24040
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000181081AC0-0x0000000181081B60
	// [XID] // 0x0000000189B2B4B0-0x0000000189B2B4D0
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000181080160-0x00000001810802C0
	[BlackList] // 0x0000000189B41C50-0x0000000189B41C90
	// [XID] // 0x0000000189B41C50-0x0000000189B41C90
	public override void AutoAllocTypeFields() {} // 0x000000018107FA30-0x000000018107FAD0
	[BlackList] // 0x0000000189B4C460-0x0000000189B4C4A0
	// [XID] // 0x0000000189B4C460-0x0000000189B4C4A0
	public override void AutoRecycleTypeFields() {} // 0x000000018107FAD0-0x000000018107FB80
	[BlackList] // 0x0000000189B56CB0-0x0000000189B56CF0
	// [XID] // 0x0000000189B56CB0-0x0000000189B56CF0
	public override void ReturnToObjectPool() {} // 0x0000000181081B60-0x0000000181081C00
}

