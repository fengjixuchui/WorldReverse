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
public class EnableMonsterMoveOnWater : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16771
{
	// Fields
	private bool _enable; // 0x68

	// Properties
	public bool enable { /* [XID] */ /* 0x0000000189A8F6F0-0x0000000189A8F710 */ get => default; /* [XID] */ /* 0x0000000189A96CA0-0x0000000189A96CC0 */ private set {} } // 0x0000000185B3C450-0x0000000185B3C4F0 0x0000000185B3D130-0x0000000185B3D1E0
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189B1AF80-0x0000000189B1AFA0 */ get => default; } // 0x0000000185B3D1E0-0x0000000185B3D280 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189B226F0-0x0000000189B22710 */ get => default; } // 0x0000000185B3C780-0x0000000185B3C820 

	// Constructors
	public EnableMonsterMoveOnWater() {} // 0x0000000185B3D800-0x0000000185B3D860

	// Methods
	// [XID] // 0x0000000189A9E070-0x0000000189A9E090
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000185B3D670-0x0000000185B3D760
	// [XID] // 0x0000000189AA5AA0-0x0000000189AA5AC0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000185B3D2E0-0x0000000185B3D390
	// [XID] // 0x0000000189AAD0E0-0x0000000189AAD100
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF45BE */) => default; // 0x0000000185B3CDA0-0x0000000185B3CE80
	// [XID] // 0x0000000189AB4AB0-0x0000000189AB4AD0
	public override int GetHashNum() => default; // 0x0000000185B3BA20-0x0000000185B3BAF0
	// [XID] // 0x0000000189ABC7E0-0x0000000189ABC800
	public override void InitEmpty() {} // 0x0000000185B3C820-0x0000000185B3C8C0
	[BlackList] // 0x0000000189AC40C0-0x0000000189AC4100
	// [XID] // 0x0000000189AC40C0-0x0000000189AC4100
	public override bool FromJson(JSONNode node) => default; // 0x0000000185B3C0D0-0x0000000185B3C450
	// [XID] // 0x0000000189ACE650-0x0000000189ACE670
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000185B3B270-0x0000000185B3B470
	[BlackList] // 0x0000000189AD64A0-0x0000000189AD64E0
	// [XID] // 0x0000000189AD64A0-0x0000000189AD64E0
	public static new EnableMonsterMoveOnWater ParseFromJson(JSONNode node) => default; // 0x0000000185B3CEE0-0x0000000185B3D130
	// [XID] // 0x0000000189AE0F80-0x0000000189AE0FA0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF45BF */, bool useObjectPool = false /* Metadata: 0x00AF45C3 */) => default; // 0x0000000185B3CAA0-0x0000000185B3CDA0
	// [XID] // 0x0000000189AE8310-0x0000000189AE8330
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF45C4 */, bool useObjectPool = false /* Metadata: 0x00AF45C8 */) => default; // 0x0000000185B3BC40-0x0000000185B3BE70
	// [XID] // 0x0000000189AF02B0-0x0000000189AF02D0
	public static new EnableMonsterMoveOnWater ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF45C9 */, bool useObjectPool = false /* Metadata: 0x00AF45CD */) => default; // 0x0000000185B3C4F0-0x0000000185B3C710
	[BlackList] // 0x0000000189AF7740-0x0000000189AF7780
	// [XID] // 0x0000000189AF7740-0x0000000189AF7780
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000185B3B470-0x0000000185B3B740
	// [XID] // 0x0000000189B01E30-0x0000000189B01E50
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000185B3D470-0x0000000185B3D670
	[BlackList] // 0x0000000189B09350-0x0000000189B09390
	// [XID] // 0x0000000189B09350-0x0000000189B09390
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000185B3C9A0-0x0000000185B3CAA0
	// [XID] // 0x0000000189B13970-0x0000000189B13990
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000185B3BE70-0x0000000185B3BFD0
	[BlackList] // 0x0000000189B29C80-0x0000000189B29CC0
	// [XID] // 0x0000000189B29C80-0x0000000189B29CC0
	public override void AutoAllocTypeFields() {} // 0x0000000185B3B740-0x0000000185B3B7E0
	[BlackList] // 0x0000000189B33FC0-0x0000000189B34000
	// [XID] // 0x0000000189B33FC0-0x0000000189B34000
	public override void AutoRecycleTypeFields() {} // 0x0000000185B3B7E0-0x0000000185B3B890
	[BlackList] // 0x0000000189B3E980-0x0000000189B3E9C0
	// [XID] // 0x0000000189B3E980-0x0000000189B3E9C0
	public override void ReturnToObjectPool() {} // 0x0000000185B3D760-0x0000000185B3D800
}

