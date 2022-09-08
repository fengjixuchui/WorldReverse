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
public class SetSkillAnchor : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16811
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigBornType _born; // 0x68

	// Properties
	public ConfigBornType born { /* [XID] */ /* 0x0000000189B627C0-0x0000000189B627E0 */ get => default; /* [XID] */ /* 0x0000000189B6A330-0x0000000189B6A350 */ private set {} } // 0x00000001819A5380-0x00000001819A5420 0x00000001819A6F70-0x00000001819A7020
	protected override bool MuteAuthority { /* [XID] */ /* 0x00000001895F2270-0x00000001895F2290 */ get => default; } // 0x00000001819A69A0-0x00000001819A6A40 
	protected override bool MuteRemote { /* [XID] */ /* 0x00000001895F9C40-0x00000001895F9C60 */ get => default; } // 0x00000001819A5FC0-0x00000001819A6060 

	// Constructors
	public SetSkillAnchor() {} // 0x00000001819A70C0-0x00000001819A7120

	// Methods
	// [XID] // 0x0000000189B71A50-0x0000000189B71A70
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001819A6E90-0x00000001819A6F70
	// [XID] // 0x0000000189B78DE0-0x0000000189B78E00
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001819A6AA0-0x00000001819A6B80
	// [XID] // 0x0000000189B80370-0x0000000189B80390
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF4706 */) => default; // 0x00000001819A6610-0x00000001819A66F0
	// [XID] // 0x0000000189B87E00-0x0000000189B87E20
	public override int GetHashNum() => default; // 0x00000001819A5240-0x00000001819A5310
	// [XID] // 0x0000000189B8F010-0x0000000189B8F030
	public override void InitEmpty() {} // 0x00000001819A6060-0x00000001819A6130
	[BlackList] // 0x0000000189B964E0-0x0000000189B96520
	// [XID] // 0x0000000189B964E0-0x0000000189B96520
	public override bool FromJson(JSONNode node) => default; // 0x00000001819A59B0-0x00000001819A5D30
	// [XID] // 0x0000000189BA0A90-0x0000000189BA0AB0
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001819A49F0-0x00000001819A4C10
	[BlackList] // 0x0000000189BA8170-0x0000000189BA81B0
	// [XID] // 0x0000000189BA8170-0x0000000189BA81B0
	public static new SetSkillAnchor ParseFromJson(JSONNode node) => default; // 0x00000001819A6750-0x00000001819A69A0
	// [XID] // 0x0000000189BB26D0-0x0000000189BB26F0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4707 */, bool useObjectPool = false /* Metadata: 0x00AF470B */) => default; // 0x00000001819A6310-0x00000001819A6610
	// [XID] // 0x0000000189BB9B20-0x0000000189BB9B40
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF470C */, bool useObjectPool = false /* Metadata: 0x00AF4710 */) => default; // 0x00000001819A5500-0x00000001819A5750
	// [XID] // 0x0000000189BC1AF0-0x0000000189BC1B10
	public static new SetSkillAnchor ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4711 */, bool useObjectPool = false /* Metadata: 0x00AF4715 */) => default; // 0x00000001819A5D30-0x00000001819A5F50
	[BlackList] // 0x0000000189BC90E0-0x0000000189BC9120
	// [XID] // 0x0000000189BC90E0-0x0000000189BC9120
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001819A4C10-0x00000001819A4EE0
	// [XID] // 0x0000000189BD37F0-0x0000000189BD3810
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001819A6C60-0x00000001819A6E90
	[BlackList] // 0x0000000189BDB1E0-0x0000000189BDB220
	// [XID] // 0x0000000189BDB1E0-0x0000000189BDB220
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001819A6210-0x00000001819A6310
	// [XID] // 0x00000001895EAD90-0x00000001895EADB0
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x00000001819A5750-0x00000001819A58B0
	[BlackList] // 0x0000000189601400-0x0000000189601440
	// [XID] // 0x0000000189601400-0x0000000189601440
	public override void AutoAllocTypeFields() {} // 0x00000001819A4EE0-0x00000001819A4F80
	[BlackList] // 0x000000018960BC40-0x000000018960BC80
	// [XID] // 0x000000018960BC40-0x000000018960BC80
	public override void AutoRecycleTypeFields() {} // 0x00000001819A4F80-0x00000001819A50B0
	[BlackList] // 0x0000000189616200-0x0000000189616240
	// [XID] // 0x0000000189616200-0x0000000189616240
	public override void ReturnToObjectPool() {} // 0x00000001819A7020-0x00000001819A70C0
}

