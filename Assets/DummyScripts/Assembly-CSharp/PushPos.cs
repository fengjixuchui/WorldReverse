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
public class PushPos : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16428
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigBornType _posType; // 0x68
	private AbilityTargetting _saveTo; // 0x70

	// Properties
	public ConfigBornType posType { /* [XID] */ /* 0x0000000189A471D0-0x0000000189A471F0 */ get => default; /* [XID] */ /* 0x0000000189A4EAF0-0x0000000189A4EB10 */ private set {} } // 0x00000001811EF630-0x00000001811EF6D0 0x00000001811EED30-0x00000001811EEDE0
	public AbilityTargetting saveTo { /* [XID] */ /* 0x0000000189A56160-0x0000000189A56180 */ get => default; /* [XID] */ /* 0x0000000189A5DC80-0x0000000189A5DCA0 */ private set {} } // 0x00000001811F0DD0-0x00000001811F0E70 0x00000001811F0410-0x00000001811F04C0
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189AE9C10-0x0000000189AE9C30 */ get => default; } // 0x00000001811F0850-0x00000001811F08F0 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189AF1990-0x0000000189AF19B0 */ get => default; } // 0x00000001811EFDD0-0x00000001811EFE70 

	// Constructors
	public PushPos() {} // 0x00000001811F10D0-0x00000001811F1140

	// Methods
	// [XID] // 0x0000000189A65400-0x0000000189A65420
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001811F0E70-0x00000001811F0F90
	// [XID] // 0x0000000189A6CB20-0x0000000189A6CB40
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001811F0950-0x00000001811F0A30
	// [XID] // 0x0000000189A742B0-0x0000000189A742D0
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3B2E */) => default; // 0x00000001811F04C0-0x00000001811F05A0
	// [XID] // 0x0000000189A7BC40-0x0000000189A7BC60
	public override int GetHashNum() => default; // 0x00000001811EEF70-0x00000001811EF040
	// [XID] // 0x0000000189A835C0-0x0000000189A835E0
	public override void InitEmpty() {} // 0x00000001811EFE70-0x00000001811EFF40
	[BlackList] // 0x0000000189A8AE60-0x0000000189A8AEA0
	// [XID] // 0x0000000189A8AE60-0x0000000189A8AEA0
	public override bool FromJson(JSONNode node) => default; // 0x00000001811EF750-0x00000001811EFAD0
	// [XID] // 0x0000000189A954D0-0x0000000189A954F0
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001811EE590-0x00000001811EE880
	[BlackList] // 0x0000000189A9CCD0-0x0000000189A9CD10
	// [XID] // 0x0000000189A9CCD0-0x0000000189A9CD10
	public static new PushPos ParseFromJson(JSONNode node) => default; // 0x00000001811F0600-0x00000001811F0850
	// [XID] // 0x0000000189AA7320-0x0000000189AA7340
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3B2F */, bool useObjectPool = false /* Metadata: 0x00AF3B33 */) => default; // 0x00000001811F0110-0x00000001811F0410
	// [XID] // 0x0000000189AAEA40-0x0000000189AAEA60
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3B34 */, bool useObjectPool = false /* Metadata: 0x00AF3B38 */) => default; // 0x00000001811EF190-0x00000001811EF450
	// [XID] // 0x0000000189AB6380-0x0000000189AB63A0
	public static new PushPos ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3B39 */, bool useObjectPool = false /* Metadata: 0x00AF3B3D */) => default; // 0x00000001811EFAD0-0x00000001811EFCF0
	[BlackList] // 0x0000000189ABDE30-0x0000000189ABDE70
	// [XID] // 0x0000000189ABDE30-0x0000000189ABDE70
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001811EE880-0x00000001811EEB50
	// [XID] // 0x0000000189AC86B0-0x0000000189AC86D0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001811F0B10-0x00000001811F0DD0
	[BlackList] // 0x0000000189ACFDB0-0x0000000189ACFDF0
	// [XID] // 0x0000000189ACFDB0-0x0000000189ACFDF0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001811F0020-0x00000001811F0110
	// [XID] // 0x0000000189ADAB00-0x0000000189ADAB20
	public override bool isAlreadyHandledRecoverCase() => default; // 0x00000001811F0F90-0x00000001811F1030
	// [XID] // 0x0000000189AE2320-0x0000000189AE2340
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x00000001811EF450-0x00000001811EF5B0
	[BlackList] // 0x0000000189AF90F0-0x0000000189AF9130
	// [XID] // 0x0000000189AF90F0-0x0000000189AF9130
	public override void AutoAllocTypeFields() {} // 0x00000001811EEB50-0x00000001811EEBF0
	[BlackList] // 0x0000000189B03410-0x0000000189B03450
	// [XID] // 0x0000000189B03410-0x0000000189B03450
	public override void AutoRecycleTypeFields() {} // 0x00000001811EEBF0-0x00000001811EED30
	[BlackList] // 0x0000000189B0DCD0-0x0000000189B0DD10
	// [XID] // 0x0000000189B0DCD0-0x0000000189B0DD10
	public override void ReturnToObjectPool() {} // 0x00000001811F1030-0x00000001811F10D0
}

