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
public class SetWeaponBindState : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16685
{
	// Fields
	private bool _place; // 0x68
	private string _equipPartName; // 0x70
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigBornType _born; // 0x78

	// Properties
	public bool place { /* [XID] */ /* 0x0000000189A65380-0x0000000189A653A0 */ get => default; /* [XID] */ /* 0x0000000189A6CAE0-0x0000000189A6CB00 */ private set {} } // 0x0000000184354EB0-0x0000000184354F50 0x0000000184354F50-0x0000000184355000
	public string equipPartName { /* [XID] */ /* 0x0000000189A74230-0x0000000189A74250 */ get => default; /* [XID] */ /* 0x0000000189A7BBE0-0x0000000189A7BC00 */ private set {} } // 0x0000000184355820-0x00000001843558C0 0x0000000184354D90-0x0000000184354E40
	public ConfigBornType born { /* [XID] */ /* 0x0000000189A834C0-0x0000000189A834E0 */ get => default; /* [XID] */ /* 0x0000000189A8AE20-0x0000000189A8AE40 */ private set {} } // 0x00000001843540B0-0x0000000184354150 0x0000000184356270-0x0000000184356320
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189B16750-0x0000000189B16770 */ get => default; } // 0x0000000184355B10-0x0000000184355BB0 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189B1DE10-0x0000000189B1DE30 */ get => default; } // 0x0000000184355070-0x0000000184355110 

	// Constructors
	public SetWeaponBindState() {} // 0x0000000184356460-0x00000001843564C0

	// Methods
	// [XID] // 0x0000000189A925B0-0x0000000189A925D0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184356130-0x0000000184356270
	// [XID] // 0x0000000189A9A000-0x0000000189A9A020
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184355C10-0x0000000184355D10
	// [XID] // 0x0000000189AA0FC0-0x0000000189AA0FE0
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF430E */) => default; // 0x00000001843556E0-0x00000001843557C0
	// [XID] // 0x0000000189AA86A0-0x0000000189AA86C0
	public override int GetHashNum() => default; // 0x0000000184353F70-0x0000000184354040
	// [XID] // 0x0000000189AB02E0-0x0000000189AB0300
	public override void InitEmpty() {} // 0x0000000184355110-0x0000000184355200
	[BlackList] // 0x0000000189AB79C0-0x0000000189AB7A00
	// [XID] // 0x0000000189AB79C0-0x0000000189AB7A00
	public override bool FromJson(JSONNode node) => default; // 0x00000001843547F0-0x0000000184354B70
	// [XID] // 0x0000000189AC27C0-0x0000000189AC27E0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184353580-0x0000000184353930
	[BlackList] // 0x0000000189AC9DA0-0x0000000189AC9DE0
	// [XID] // 0x0000000189AC9DA0-0x0000000189AC9DE0
	public static new SetWeaponBindState ParseFromJson(JSONNode node) => default; // 0x00000001843558C0-0x0000000184355B10
	// [XID] // 0x0000000189AD4AC0-0x0000000189AD4AE0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF430F */, bool useObjectPool = false /* Metadata: 0x00AF4313 */) => default; // 0x00000001843553E0-0x00000001843556E0
	// [XID] // 0x0000000189ADC440-0x0000000189ADC460
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4314 */, bool useObjectPool = false /* Metadata: 0x00AF4318 */) => default; // 0x0000000184354230-0x0000000184354590
	// [XID] // 0x0000000189AE3E10-0x0000000189AE3E30
	public static new SetWeaponBindState ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4319 */, bool useObjectPool = false /* Metadata: 0x00AF431D */) => default; // 0x0000000184354B70-0x0000000184354D90
	[BlackList] // 0x0000000189AEB690-0x0000000189AEB6D0
	// [XID] // 0x0000000189AEB690-0x0000000189AEB6D0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184353930-0x0000000184353C00
	// [XID] // 0x0000000189AF5F30-0x0000000189AF5F50
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184355DF0-0x0000000184356130
	[BlackList] // 0x0000000189AFD3B0-0x0000000189AFD3F0
	// [XID] // 0x0000000189AFD3B0-0x0000000189AFD3F0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001843552E0-0x00000001843553E0
	// [XID] // 0x0000000189B07AF0-0x0000000189B07B10
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000184356320-0x00000001843563C0
	// [XID] // 0x0000000189B0F3D0-0x0000000189B0F3F0
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000184354590-0x00000001843546F0
	[BlackList] // 0x0000000189B25660-0x0000000189B256A0
	// [XID] // 0x0000000189B25660-0x0000000189B256A0
	public override void AutoAllocTypeFields() {} // 0x0000000184353C00-0x0000000184353CA0
	[BlackList] // 0x0000000189B2F790-0x0000000189B2F7D0
	// [XID] // 0x0000000189B2F790-0x0000000189B2F7D0
	public override void AutoRecycleTypeFields() {} // 0x0000000184353CA0-0x0000000184353DE0
	[BlackList] // 0x0000000189B3A290-0x0000000189B3A2D0
	// [XID] // 0x0000000189B3A290-0x0000000189B3A2D0
	public override void ReturnToObjectPool() {} // 0x00000001843563C0-0x0000000184356460
}

