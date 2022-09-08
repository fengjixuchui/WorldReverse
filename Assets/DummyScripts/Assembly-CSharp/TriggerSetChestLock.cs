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
public class TriggerSetChestLock : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16535
{
	// Fields
	private bool _locked; // 0x68

	// Properties
	public bool locked { /* [XID] */ /* 0x0000000189804170-0x0000000189804190 */ get => default; /* [XID] */ /* 0x000000018980B5A0-0x000000018980B5C0 */ private set {} } // 0x00000001825FE350-0x00000001825FE3F0 0x00000001825FE900-0x00000001825FE9B0
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189894CF0-0x0000000189894D10 */ get => default; } // 0x00000001825FF9D0-0x00000001825FFA70 
	protected override bool MuteRemote { /* [XID] */ /* 0x000000018989C2C0-0x000000018989C2E0 */ get => default; } // 0x00000001825FF030-0x00000001825FF0D0 

	// Constructors
	public TriggerSetChestLock() {} // 0x0000000182600090-0x0000000182600100

	// Methods
	// [XID] // 0x0000000189812C60-0x0000000189812C80
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001825FFE60-0x00000001825FFF50
	// [XID] // 0x000000018981A840-0x000000018981A860
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001825FFAD0-0x00000001825FFB80
	// [XID] // 0x0000000189822090-0x00000001898220B0
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3E76 */) => default; // 0x00000001825FF640-0x00000001825FF720
	// [XID] // 0x00000001898295D0-0x00000001898295F0
	public override int GetHashNum() => default; // 0x00000001825FE1B0-0x00000001825FE280
	// [XID] // 0x0000000189830BC0-0x0000000189830BE0
	public override void InitEmpty() {} // 0x00000001825FF0D0-0x00000001825FF170
	[BlackList] // 0x0000000189838260-0x00000001898382A0
	// [XID] // 0x0000000189838260-0x00000001898382A0
	public override bool FromJson(JSONNode node) => default; // 0x00000001825FE9B0-0x00000001825FED30
	// [XID] // 0x0000000189842A40-0x0000000189842A60
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001825FDA00-0x00000001825FDC00
	[BlackList] // 0x0000000189849D50-0x0000000189849D90
	// [XID] // 0x0000000189849D50-0x0000000189849D90
	public static new TriggerSetChestLock ParseFromJson(JSONNode node) => default; // 0x00000001825FF780-0x00000001825FF9D0
	// [XID] // 0x0000000189853DE0-0x0000000189853E00
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3E77 */, bool useObjectPool = false /* Metadata: 0x00AF3E7B */) => default; // 0x00000001825FF340-0x00000001825FF640
	// [XID] // 0x000000018985B8F0-0x000000018985B910
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3E7C */, bool useObjectPool = false /* Metadata: 0x00AF3E80 */) => default; // 0x00000001825FE470-0x00000001825FE6A0
	// [XID] // 0x0000000189862E30-0x0000000189862E50
	public static new TriggerSetChestLock ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3E81 */, bool useObjectPool = false /* Metadata: 0x00AF3E85 */) => default; // 0x00000001825FED30-0x00000001825FEF50
	[BlackList] // 0x000000018986A260-0x000000018986A2A0
	// [XID] // 0x000000018986A260-0x000000018986A2A0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001825FDC00-0x00000001825FDED0
	// [XID] // 0x00000001898743E0-0x0000000189874400
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001825FFC60-0x00000001825FFE60
	[BlackList] // 0x000000018987BF40-0x000000018987BF80
	// [XID] // 0x000000018987BF40-0x000000018987BF80
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001825FF250-0x00000001825FF340
	// [XID] // 0x0000000189886460-0x0000000189886480
	public override bool isAlreadyHandledRecoverCase() => default; // 0x00000001825FFF50-0x00000001825FFFF0
	// [XID] // 0x000000018988D580-0x000000018988D5A0
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x00000001825FE6A0-0x00000001825FE800
	[BlackList] // 0x00000001898A3960-0x00000001898A39A0
	// [XID] // 0x00000001898A3960-0x00000001898A39A0
	public override void AutoAllocTypeFields() {} // 0x00000001825FDED0-0x00000001825FDF70
	[BlackList] // 0x00000001898AE1D0-0x00000001898AE210
	// [XID] // 0x00000001898AE1D0-0x00000001898AE210
	public override void AutoRecycleTypeFields() {} // 0x00000001825FDF70-0x00000001825FE020
	[BlackList] // 0x00000001898B88C0-0x00000001898B8900
	// [XID] // 0x00000001898B88C0-0x00000001898B8900
	public override void ReturnToObjectPool() {} // 0x00000001825FFFF0-0x0000000182600090
}

