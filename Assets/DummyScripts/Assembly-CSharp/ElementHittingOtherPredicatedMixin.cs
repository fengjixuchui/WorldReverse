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
public class ElementHittingOtherPredicatedMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 17113
{
	// Fields
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityPredicate[] _prePredicates; // 0x30
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ElementBatchPredicated[] _elementBatchPredicateds; // 0x38

	// Properties
	public ConfigAbilityPredicate[] prePredicates { /* [XID] */ /* 0x0000000189624E90-0x0000000189624EB0 */ get => default; /* [XID] */ /* 0x000000018962C630-0x000000018962C650 */ private set {} } // 0x0000000182A99880-0x0000000182A99920 0x0000000182A98140-0x0000000182A981F0
	public ElementBatchPredicated[] elementBatchPredicateds { /* [XID] */ /* 0x00000001896342D0-0x00000001896342F0 */ get => default; /* [XID] */ /* 0x000000018963BAA0-0x000000018963BAC0 */ private set {} } // 0x0000000182A97EF0-0x0000000182A97F90 0x0000000182A98FF0-0x0000000182A990A0
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x00000001896C67D0-0x00000001896C67F0 */ get => default; } // 0x0000000182A98840-0x0000000182A988E0 

	// Constructors
	public ElementHittingOtherPredicatedMixin() {} // 0x0000000182A9A1F0-0x0000000182A9A250

	// Methods
	// [XID] // 0x00000001896431A0-0x00000001896431C0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182A99FC0-0x0000000182A9A0D0
	// [XID] // 0x000000018964A820-0x000000018964A840
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182A99BD0-0x0000000182A99CD0
	// [XID] // 0x0000000189652100-0x0000000189652120
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF63AD */) => default; // 0x0000000182A99740-0x0000000182A99820
	// [XID] // 0x00000001896597B0-0x00000001896597D0
	public override int GetHashNum() => default; // 0x0000000182A98010-0x0000000182A980E0
	// [XID] // 0x0000000189660F50-0x0000000189660F70
	public override void InitEmpty() {} // 0x0000000182A990A0-0x0000000182A99190
	[BlackList] // 0x00000001896688C0-0x0000000189668900
	// [XID] // 0x00000001896688C0-0x0000000189668900
	public override bool FromJson(JSONNode node) => default; // 0x0000000182A988E0-0x0000000182A98C60
	// [XID] // 0x00000001896732E0-0x0000000189673300
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182A97700-0x0000000182A97A20
	[BlackList] // 0x000000018967AAC0-0x000000018967AB00
	// [XID] // 0x000000018967AAC0-0x000000018967AB00
	public static new ElementHittingOtherPredicatedMixin ParseFromJson(JSONNode node) => default; // 0x0000000182A99920-0x0000000182A99B70
	// [XID] // 0x00000001896852E0-0x0000000189685300
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF63AE */, bool useObjectPool = false /* Metadata: 0x00AF63B2 */) => default; // 0x0000000182A99360-0x0000000182A99660
	// [XID] // 0x000000018968CD80-0x000000018968CDA0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF63B3 */, bool useObjectPool = false /* Metadata: 0x00AF63B7 */) => default; // 0x0000000182A98430-0x0000000182A98740
	// [XID] // 0x0000000189694920-0x0000000189694940
	public static new ElementHittingOtherPredicatedMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF63B8 */, bool useObjectPool = false /* Metadata: 0x00AF63BC */) => default; // 0x0000000182A98CD0-0x0000000182A98EF0
	[BlackList] // 0x000000018969C000-0x000000018969C040
	// [XID] // 0x000000018969C000-0x000000018969C040
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182A97A20-0x0000000182A97CF0
	// [XID] // 0x00000001896A62D0-0x00000001896A62F0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182A99CD0-0x0000000182A99FC0
	[BlackList] // 0x00000001896AD7F0-0x00000001896AD830
	// [XID] // 0x00000001896AD7F0-0x00000001896AD830
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182A99270-0x0000000182A99360
	// [XID] // 0x00000001896B7E10-0x00000001896B7E30
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x0000000182A99660-0x0000000182A99740
	// [XID] // 0x00000001896BEE50-0x00000001896BEE70
	protected override void GetSubActions(object member) {} // 0x0000000182A98270-0x0000000182A98430
	[BlackList] // 0x00000001896CDD30-0x00000001896CDD70
	// [XID] // 0x00000001896CDD30-0x00000001896CDD70
	public override void AutoAllocTypeFields() {} // 0x0000000182A97CF0-0x0000000182A97D90
	[BlackList] // 0x00000001896D81B0-0x00000001896D81F0
	// [XID] // 0x00000001896D81B0-0x00000001896D81F0
	public override void AutoRecycleTypeFields() {} // 0x0000000182A97D90-0x0000000182A97E50
	[BlackList] // 0x00000001896E29E0-0x00000001896E2A20
	// [XID] // 0x00000001896E29E0-0x00000001896E2A20
	public override void ReturnToObjectPool() {} // 0x0000000182A9A150-0x0000000182A9A1F0
}

