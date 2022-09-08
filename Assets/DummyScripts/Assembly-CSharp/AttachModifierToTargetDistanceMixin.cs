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
public class AttachModifierToTargetDistanceMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 17127
{
	// Fields
	private SimpleSafeUInt32[] _targetIDs; // 0x30
	private bool _byserver; // 0x38
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private DynamicFloat[] _valueSteps; // 0x40
	private string[] _modifierNameSteps; // 0x48
	private bool _removeAppliedModifier; // 0x50
	private string _BlendParam; // 0x58
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private DynamicFloat[] _BlendDistance; // 0x60
	private string _effectPattern; // 0x68

	// Properties
	public SimpleSafeUInt32[] targetIDs { /* [XID] */ /* 0x0000000189AD1690-0x0000000189AD16B0 */ get => default; /* [XID] */ /* 0x0000000189AD93B0-0x0000000189AD93D0 */ private set {} } // 0x00000001816670F0-0x0000000181667190 0x0000000181667190-0x0000000181667240
	public bool byserver { /* [XID] */ /* 0x0000000189AE0EC0-0x0000000189AE0EE0 */ get => default; /* [XID] */ /* 0x0000000189AE82D0-0x0000000189AE82F0 */ private set {} } // 0x0000000181664550-0x00000001816645F0 0x0000000181667240-0x00000001816672F0
	public DynamicFloat[] valueSteps { /* [XID] */ /* 0x0000000189AF01F0-0x0000000189AF0210 */ get => default; /* [XID] */ /* 0x0000000189AF7640-0x0000000189AF7660 */ private set {} } // 0x0000000181665850-0x00000001816658F0 0x0000000181665480-0x0000000181665530
	public string[] modifierNameSteps { /* [XID] */ /* 0x0000000189AFED10-0x0000000189AFED30 */ get => default; /* [XID] */ /* 0x0000000189B064E0-0x0000000189B06500 */ private set {} } // 0x0000000181664F40-0x0000000181664FE0 0x0000000181664E10-0x0000000181664EC0
	public bool removeAppliedModifier { /* [XID] */ /* 0x0000000189B0DB70-0x0000000189B0DB90 */ get => default; /* [XID] */ /* 0x0000000189B15010-0x0000000189B15030 */ private set {} } // 0x0000000181664360-0x0000000181664400 0x0000000181666830-0x00000001816668E0
	public string BlendParam { /* [XID] */ /* 0x0000000189B1CA10-0x0000000189B1CA30 */ get => default; /* [XID] */ /* 0x0000000189B23FA0-0x0000000189B23FC0 */ private set {} } // 0x0000000181665DB0-0x0000000181665E50 0x0000000181664650-0x0000000181664700
	public DynamicFloat[] BlendDistance { /* [XID] */ /* 0x0000000189B2B3B0-0x0000000189B2B3D0 */ get => default; /* [XID] */ /* 0x0000000189B32940-0x0000000189B32960 */ private set {} } // 0x0000000181666790-0x0000000181666830 0x0000000181665960-0x0000000181665A10
	public string effectPattern { /* [XID] */ /* 0x0000000189B3A230-0x0000000189B3A250 */ get => default; /* [XID] */ /* 0x0000000189B41B90-0x0000000189B41BB0 */ private set {} } // 0x0000000181665BC0-0x0000000181665C60 0x00000001816672F0-0x00000001816673A0
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x0000000189BC47E0-0x0000000189BC4800 */ get => default; } // 0x0000000181665060-0x0000000181665100 

	// Constructors
	public AttachModifierToTargetDistanceMixin() {} // 0x0000000181667440-0x00000001816674B0

	// Methods
	// [XID] // 0x0000000189B49540-0x0000000189B49560
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181666F40-0x00000001816670F0
	// [XID] // 0x0000000189B50B60-0x0000000189B50B80
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000181666620-0x0000000181666790
	// [XID] // 0x0000000189B583F0-0x0000000189B58410
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF641D */) => default; // 0x0000000181666230-0x0000000181666310
	// [XID] // 0x0000000189B5FD40-0x0000000189B5FD60
	public override int GetHashNum() => default; // 0x0000000181664480-0x0000000181664550
	// [XID] // 0x0000000189B673E0-0x0000000189B67400
	public override void InitEmpty() {} // 0x0000000181665A10-0x0000000181665B40
	[BlackList] // 0x0000000189B6E5E0-0x0000000189B6E620
	// [XID] // 0x0000000189B6E5E0-0x0000000189B6E620
	public override bool FromJson(JSONNode node) => default; // 0x0000000181665100-0x0000000181665480
	// [XID] // 0x0000000189B78DC0-0x0000000189B78DE0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000181663690-0x0000000181663E70
	[BlackList] // 0x0000000189B802D0-0x0000000189B80310
	// [XID] // 0x0000000189B802D0-0x0000000189B80310
	public static new AttachModifierToTargetDistanceMixin ParseFromJson(JSONNode node) => default; // 0x0000000181666370-0x00000001816665C0
	// [XID] // 0x0000000189B8AA30-0x0000000189B8AA50
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF641E */, bool useObjectPool = false /* Metadata: 0x00AF6422 */) => default; // 0x0000000181665E50-0x0000000181666150
	// [XID] // 0x0000000189B92020-0x0000000189B92040
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6423 */, bool useObjectPool = false /* Metadata: 0x00AF6427 */) => default; // 0x0000000181664780-0x0000000181664E10
	// [XID] // 0x0000000189B99520-0x0000000189B99540
	public static new AttachModifierToTargetDistanceMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6428 */, bool useObjectPool = false /* Metadata: 0x00AF642C */) => default; // 0x00000001816655A0-0x00000001816657C0
	[BlackList] // 0x0000000189BA0A10-0x0000000189BA0A50
	// [XID] // 0x0000000189BA0A10-0x0000000189BA0A50
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000181663E70-0x0000000181664140
	// [XID] // 0x0000000189BAB020-0x0000000189BAB040
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001816668E0-0x0000000181666F40
	[BlackList] // 0x0000000189BB25F0-0x0000000189BB2630
	// [XID] // 0x0000000189BB25F0-0x0000000189BB2630
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000181665CC0-0x0000000181665DB0
	// [XID] // 0x0000000189BBCB80-0x0000000189BBCBA0
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x0000000181666150-0x0000000181666230
	[BlackList] // 0x0000000189BCC160-0x0000000189BCC1A0
	// [XID] // 0x0000000189BCC160-0x0000000189BCC1A0
	public override void AutoAllocTypeFields() {} // 0x0000000181664140-0x00000001816641E0
	[BlackList] // 0x0000000189BD6580-0x0000000189BD65C0
	// [XID] // 0x0000000189BD6580-0x0000000189BD65C0
	public override void AutoRecycleTypeFields() {} // 0x00000001816641E0-0x00000001816642C0
	[BlackList] // 0x00000001895E6250-0x00000001895E6290
	// [XID] // 0x00000001895E6250-0x00000001895E6290
	public override void ReturnToObjectPool() {} // 0x00000001816673A0-0x0000000181667440
}

