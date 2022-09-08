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
using MoleMole.Config;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ModifySkillCDByModifierCountMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 16990
{
	// Fields
	private TargetType _targetType; // 0x30
	private string _modifierName; // 0x38
	private SimpleSafeUInt32 skillIDRawNum; // 0x40
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _cdDelta; // 0x48

	// Properties
	public TargetType targetType { /* [XID] */ /* 0x00000001899941D0-0x00000001899941F0 */ get => default; /* [XID] */ /* 0x000000018999BA40-0x000000018999BA60 */ private set {} } // 0x0000000182CB8460-0x0000000182CB8500 0x0000000182CB69F0-0x0000000182CB6AA0
	public string modifierName { /* [XID] */ /* 0x00000001899A31D0-0x00000001899A31F0 */ get => default; /* [XID] */ /* 0x00000001899AAC40-0x00000001899AAC60 */ private set {} } // 0x0000000182CB99B0-0x0000000182CB9A50 0x0000000182CB8870-0x0000000182CB8920
	public uint skillID { /* [XID] */ /* 0x00000001899B2730-0x00000001899B2750 */ get => default; /* [XID] */ /* 0x00000001899B99B0-0x00000001899B99D0 */ private set {} } // 0x0000000182CB8500-0x0000000182CB85D0 0x0000000182CB9770-0x0000000182CB9850
	public DynamicFloat cdDelta { /* [XID] */ /* 0x00000001899C14F0-0x00000001899C1510 */ get => default; /* [XID] */ /* 0x00000001899C8A60-0x00000001899C8A80 */ private set {} } // 0x0000000182CB85D0-0x0000000182CB8670 0x0000000182CB9180-0x0000000182CB9230
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x0000000189A4B800-0x0000000189A4B820 */ get => default; } // 0x0000000182CB7CB0-0x0000000182CB7D50 

	// Constructors
	public ModifySkillCDByModifierCountMixin() {} // 0x0000000182CB9AF0-0x0000000182CB9B50

	// Methods
	// [XID] // 0x00000001899D0430-0x00000001899D0450
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182CB9850-0x0000000182CB99B0
	// [XID] // 0x00000001899D78D0-0x00000001899D78F0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182CB9290-0x0000000182CB9390
	// [XID] // 0x00000001899DED30-0x00000001899DED50
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF5FB5 */) => default; // 0x0000000182CB8DF0-0x0000000182CB8ED0
	// [XID] // 0x00000001899E6950-0x00000001899E6970
	public override int GetHashNum() => default; // 0x0000000182CB75B0-0x0000000182CB7680
	// [XID] // 0x00000001899EDF60-0x00000001899EDF80
	public override void InitEmpty() {} // 0x0000000182CB8670-0x0000000182CB8790
	[BlackList] // 0x00000001899F5770-0x00000001899F57B0
	// [XID] // 0x00000001899F5770-0x00000001899F57B0
	public override bool FromJson(JSONNode node) => default; // 0x0000000182CB7D50-0x0000000182CB80D0
	// [XID] // 0x00000001899FFCA0-0x00000001899FFCC0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182CB6AA0-0x0000000182CB6FB0
	[BlackList] // 0x0000000189A075B0-0x0000000189A075F0
	// [XID] // 0x0000000189A075B0-0x0000000189A075F0
	public static new ModifySkillCDByModifierCountMixin ParseFromJson(JSONNode node) => default; // 0x0000000182CB8F30-0x0000000182CB9180
	// [XID] // 0x0000000189A11CA0-0x0000000189A11CC0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5FB6 */, bool useObjectPool = false /* Metadata: 0x00AF5FBA */) => default; // 0x0000000182CB8A10-0x0000000182CB8D10
	// [XID] // 0x0000000189A18F70-0x0000000189A18F90
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5FBB */, bool useObjectPool = false /* Metadata: 0x00AF5FBF */) => default; // 0x0000000182CB7760-0x0000000182CB7BB0
	// [XID] // 0x0000000189A20690-0x0000000189A206B0
	public static new ModifySkillCDByModifierCountMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5FC0 */, bool useObjectPool = false /* Metadata: 0x00AF5FC4 */) => default; // 0x0000000182CB8140-0x0000000182CB8360
	[BlackList] // 0x0000000189A27B00-0x0000000189A27B40
	// [XID] // 0x0000000189A27B00-0x0000000189A27B40
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182CB6FB0-0x0000000182CB7280
	// [XID] // 0x0000000189A32060-0x0000000189A32080
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182CB9390-0x0000000182CB9770
	[BlackList] // 0x0000000189A399B0-0x0000000189A399F0
	// [XID] // 0x0000000189A399B0-0x0000000189A399F0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182CB8920-0x0000000182CB8A10
	// [XID] // 0x0000000189A44290-0x0000000189A442B0
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x0000000182CB8D10-0x0000000182CB8DF0
	[BlackList] // 0x0000000189A52F00-0x0000000189A52F40
	// [XID] // 0x0000000189A52F00-0x0000000189A52F40
	public override void AutoAllocTypeFields() {} // 0x0000000182CB7280-0x0000000182CB7320
	[BlackList] // 0x0000000189A5DB40-0x0000000189A5DB80
	// [XID] // 0x0000000189A5DB40-0x0000000189A5DB80
	public override void AutoRecycleTypeFields() {} // 0x0000000182CB7320-0x0000000182CB7490
	[BlackList] // 0x0000000189A68710-0x0000000189A68750
	// [XID] // 0x0000000189A68710-0x0000000189A68750
	public override void ReturnToObjectPool() {} // 0x0000000182CB9A50-0x0000000182CB9AF0
}

