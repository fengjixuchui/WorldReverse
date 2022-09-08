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
public class MonsterDefendMixin : EntityDefenceMixin, IAutoAllocRecycle // TypeDefIndex: 16969
{
	// Fields
	private AttackType _attackType; // 0x70
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _onDefendSucceded; // 0x78
	private bool _randomDirection; // 0x80

	// Properties
	public AttackType attackType { /* [XID] */ /* 0x0000000189BD0990-0x0000000189BD09B0 */ get => default; /* [XID] */ /* 0x0000000189BD7E70-0x0000000189BD7E90 */ private set {} } // 0x00000001845C81B0-0x00000001845C8250 0x00000001845C74C0-0x00000001845C7570
	public ConfigAbilityAction[] onDefendSucceded { /* [XID] */ /* 0x0000000189BDFA40-0x0000000189BDFA60 */ get => default; /* [XID] */ /* 0x00000001895EC570-0x00000001895EC590 */ private set {} } // 0x00000001845C7DF0-0x00000001845C7E90 0x00000001845C6FE0-0x00000001845C7090
	public bool randomDirection { /* [XID] */ /* 0x00000001895F3AB0-0x00000001895F3AD0 */ get => default; /* [XID] */ /* 0x00000001895FB370-0x00000001895FB390 */ private set {} } // 0x00000001845C8ED0-0x00000001845C8F80 0x00000001845C8E20-0x00000001845C8ED0
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x000000018967F220-0x000000018967F240 */ get => default; } // 0x00000001845C79D0-0x00000001845C7A70 

	// Constructors
	public MonsterDefendMixin() {} // 0x00000001845C9490-0x00000001845C9500

	// Methods
	// [XID] // 0x0000000189602B10-0x0000000189602B30
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001845C92C0-0x00000001845C93F0
	// [XID] // 0x000000018960A450-0x000000018960A470
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001845C8D40-0x00000001845C8E20
	// [XID] // 0x0000000189611C20-0x0000000189611C40
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF5F0F */) => default; // 0x00000001845C8950-0x00000001845C8A30
	// [XID] // 0x00000001896194E0-0x0000000189619500
	public override int GetHashNum() => default; // 0x00000001845C7310-0x00000001845C73E0
	// [XID] // 0x0000000189620A60-0x0000000189620A80
	public override void InitEmpty() {} // 0x00000001845C82C0-0x00000001845C8390
	[BlackList] // 0x0000000189627FB0-0x0000000189627FF0
	// [XID] // 0x0000000189627FB0-0x0000000189627FF0
	public override bool FromJson(JSONNode node) => default; // 0x00000001845C7A70-0x00000001845C7DF0
	// [XID] // 0x0000000189632840-0x0000000189632860
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001845C6950-0x00000001845C6D10
	[BlackList] // 0x000000018963A350-0x000000018963A390
	// [XID] // 0x000000018963A350-0x000000018963A390
	public static new MonsterDefendMixin ParseFromJson(JSONNode node) => default; // 0x00000001845C8A90-0x00000001845C8CE0
	// [XID] // 0x00000001896449B0-0x00000001896449D0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5F10 */, bool useObjectPool = false /* Metadata: 0x00AF5F14 */) => default; // 0x00000001845C8570-0x00000001845C8870
	// [XID] // 0x000000018964C1D0-0x000000018964C1F0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5F15 */, bool useObjectPool = false /* Metadata: 0x00AF5F19 */) => default; // 0x00000001845C7570-0x00000001845C78D0
	// [XID] // 0x0000000189653940-0x0000000189653960
	public static new MonsterDefendMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5F1A */, bool useObjectPool = false /* Metadata: 0x00AF5F1E */) => default; // 0x00000001845C7F00-0x00000001845C8120
	[BlackList] // 0x000000018965B1F0-0x000000018965B230
	// [XID] // 0x000000018965B1F0-0x000000018965B230
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001845C6D10-0x00000001845C6FE0
	// [XID] // 0x0000000189665690-0x00000001896656B0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001845C8F80-0x00000001845C92C0
	[BlackList] // 0x000000018966CDE0-0x000000018966CE20
	// [XID] // 0x000000018966CDE0-0x000000018966CE20
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001845C8470-0x00000001845C8570
	// [XID] // 0x0000000189677CD0-0x0000000189677CF0
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x00000001845C8870-0x00000001845C8950
	[BlackList] // 0x0000000189686B70-0x0000000189686BB0
	// [XID] // 0x0000000189686B70-0x0000000189686BB0
	public override void AutoAllocTypeFields() {} // 0x00000001845C7090-0x00000001845C7130
	[BlackList] // 0x0000000189691AF0-0x0000000189691B30
	// [XID] // 0x0000000189691AF0-0x0000000189691B30
	public override void AutoRecycleTypeFields() {} // 0x00000001845C7130-0x00000001845C71F0
	[BlackList] // 0x000000018969C080-0x000000018969C0C0
	// [XID] // 0x000000018969C080-0x000000018969C0C0
	public override void ReturnToObjectPool() {} // 0x00000001845C93F0-0x00000001845C9490
}

