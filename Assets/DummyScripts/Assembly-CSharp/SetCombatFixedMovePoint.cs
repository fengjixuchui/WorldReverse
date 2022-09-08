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
public class SetCombatFixedMovePoint : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16709
{
	// Fields
	private bool _setPoint; // 0x68
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigBornType _toPos; // 0x70

	// Properties
	public bool setPoint { /* [XID] */ /* 0x0000000189844120-0x0000000189844140 */ get => default; /* [XID] */ /* 0x000000018984B570-0x000000018984B590 */ private set {} } // 0x000000018486FD10-0x000000018486FDB0 0x0000000184870BF0-0x0000000184870CA0
	public ConfigBornType toPos { /* [XID] */ /* 0x0000000189852680-0x00000001898526A0 */ get => default; /* [XID] */ /* 0x000000018985A0F0-0x000000018985A110 */ private set {} } // 0x00000001848717C0-0x0000000184871860 0x00000001848703A0-0x0000000184870450
	protected override bool MuteAuthority { /* [XID] */ /* 0x00000001898E43E0-0x00000001898E4400 */ get => default; } // 0x00000001848715E0-0x0000000184871680 
	protected override bool MuteRemote { /* [XID] */ /* 0x00000001898EBE10-0x00000001898EBE30 */ get => default; } // 0x0000000184870B50-0x0000000184870BF0 

	// Constructors
	public SetCombatFixedMovePoint() {} // 0x0000000184871E60-0x0000000184871ED0

	// Methods
	// [XID] // 0x0000000189861290-0x00000001898612B0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184871BF0-0x0000000184871D20
	// [XID] // 0x00000001898689F0-0x0000000189868A10
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001848716E0-0x00000001848717C0
	// [XID] // 0x000000018986FEA0-0x000000018986FEC0
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF43CE */) => default; // 0x0000000184871250-0x0000000184871330
	// [XID] // 0x0000000189877590-0x00000001898775B0
	public override int GetHashNum() => default; // 0x000000018486FC40-0x000000018486FD10
	// [XID] // 0x000000018987EDE0-0x000000018987EE00
	public override void InitEmpty() {} // 0x0000000184870CA0-0x0000000184870D70
	[BlackList] // 0x0000000189886340-0x0000000189886380
	// [XID] // 0x0000000189886340-0x0000000189886380
	public override bool FromJson(JSONNode node) => default; // 0x00000001848704D0-0x0000000184870850
	// [XID] // 0x00000001898905E0-0x0000000189890600
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018486F330-0x000000018486F610
	[BlackList] // 0x0000000189897AA0-0x0000000189897AE0
	// [XID] // 0x0000000189897AA0-0x0000000189897AE0
	public static new SetCombatFixedMovePoint ParseFromJson(JSONNode node) => default; // 0x0000000184871390-0x00000001848715E0
	// [XID] // 0x00000001898A2020-0x00000001898A2040
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF43CF */, bool useObjectPool = false /* Metadata: 0x00AF43D3 */) => default; // 0x0000000184870F50-0x0000000184871250
	// [XID] // 0x00000001898A97D0-0x00000001898A97F0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF43D4 */, bool useObjectPool = false /* Metadata: 0x00AF43D8 */) => default; // 0x000000018486FF00-0x00000001848701C0
	// [XID] // 0x00000001898B1060-0x00000001898B1080
	public static new SetCombatFixedMovePoint ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF43D9 */, bool useObjectPool = false /* Metadata: 0x00AF43DD */) => default; // 0x0000000184870850-0x0000000184870A70
	[BlackList] // 0x00000001898B87E0-0x00000001898B8820
	// [XID] // 0x00000001898B87E0-0x00000001898B8820
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018486F610-0x000000018486F8E0
	// [XID] // 0x00000001898C2E20-0x00000001898C2E40
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184871940-0x0000000184871BF0
	[BlackList] // 0x00000001898CA760-0x00000001898CA7A0
	// [XID] // 0x00000001898CA760-0x00000001898CA7A0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184870E50-0x0000000184870F50
	// [XID] // 0x00000001898D4FD0-0x00000001898D4FF0
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000184871D20-0x0000000184871DC0
	// [XID] // 0x00000001898DC930-0x00000001898DC950
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x00000001848701C0-0x0000000184870320
	[BlackList] // 0x00000001898F36C0-0x00000001898F3700
	// [XID] // 0x00000001898F36C0-0x00000001898F3700
	public override void AutoAllocTypeFields() {} // 0x000000018486F8E0-0x000000018486F980
	[BlackList] // 0x00000001898FDF60-0x00000001898FDFA0
	// [XID] // 0x00000001898FDF60-0x00000001898FDFA0
	public override void AutoRecycleTypeFields() {} // 0x000000018486F980-0x000000018486FAB0
	[BlackList] // 0x0000000189908950-0x0000000189908990
	// [XID] // 0x0000000189908950-0x0000000189908990
	public override void ReturnToObjectPool() {} // 0x0000000184871DC0-0x0000000184871E60
}

