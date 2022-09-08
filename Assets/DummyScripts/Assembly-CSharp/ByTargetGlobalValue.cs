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
public class ByTargetGlobalValue : ConfigAbilityPredicate, IAutoAllocRecycle // TypeDefIndex: 17230
{
	// Fields
	private string _key; // 0x18
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _value; // 0x20
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _maxValue; // 0x28
	private bool _forceByCaster; // 0x30
	private RelationType _compareType; // 0x34

	// Properties
	public string key { /* [XID] */ /* 0x00000001896E12D0-0x00000001896E12F0 */ get => default; /* [XID] */ /* 0x00000001896E8500-0x00000001896E8520 */ private set {} } // 0x0000000182742CE0-0x0000000182742D80 0x00000001827448F0-0x00000001827449A0
	public DynamicFloat value { /* [XID] */ /* 0x00000001896EFA80-0x00000001896EFAA0 */ get => default; /* [XID] */ /* 0x00000001896F7490-0x00000001896F74B0 */ private set {} } // 0x00000001827436F0-0x0000000182743790 0x00000001827435C0-0x0000000182743670
	public DynamicFloat maxValue { /* [XID] */ /* 0x00000001896FEE50-0x00000001896FEE70 */ get => default; /* [XID] */ /* 0x0000000189706080-0x00000001897060A0 */ private set {} } // 0x0000000182743DA0-0x0000000182743E40 0x0000000182742C30-0x0000000182742CE0
	public bool forceByCaster { /* [XID] */ /* 0x000000018970D910-0x000000018970D930 */ get => default; /* [XID] */ /* 0x0000000189714DB0-0x0000000189714DD0 */ private set {} } // 0x00000001827451A0-0x0000000182745240 0x0000000182743E40-0x0000000182743EF0
	public RelationType compareType { /* [XID] */ /* 0x000000018971C880-0x000000018971C8A0 */ get => default; /* [XID] */ /* 0x0000000189723D10-0x0000000189723D30 */ private set {} } // 0x00000001827444C0-0x0000000182744560 0x0000000182742D80-0x0000000182742E30

	// Constructors
	public ByTargetGlobalValue() {} // 0x00000001827452E0-0x0000000182745340

	// Methods
	// [XID] // 0x000000018972B470-0x000000018972B490
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182745010-0x00000001827451A0
	// [XID] // 0x0000000189732D20-0x0000000189732D40
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182744A00-0x0000000182744B10
	// [XID] // 0x000000018973A3F0-0x000000018973A410
	public override ConfigAbilityPredicate Clone(bool useObjectPool = false /* Metadata: 0x00AF6767 */) => default; // 0x0000000182744560-0x0000000182744640
	// [XID] // 0x0000000189741DE0-0x0000000189741E00
	public override int GetHashNum() => default; // 0x0000000182742B60-0x0000000182742C30
	// [XID] // 0x00000001897497A0-0x00000001897497C0
	public override void InitEmpty() {} // 0x0000000182743EF0-0x0000000182743FF0
	[BlackList] // 0x0000000189750C80-0x0000000189750CC0
	// [XID] // 0x0000000189750C80-0x0000000189750CC0
	public override bool FromJson(JSONNode node) => default; // 0x0000000182743790-0x0000000182743B10
	// [XID] // 0x000000018975B140-0x000000018975B160
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182741F80-0x0000000182742520
	[BlackList] // 0x0000000189762B30-0x0000000189762B70
	// [XID] // 0x0000000189762B30-0x0000000189762B70
	public static new ByTargetGlobalValue ParseFromJson(JSONNode node) => default; // 0x00000001827446A0-0x00000001827448F0
	// [XID] // 0x000000018976D100-0x000000018976D120
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6768 */, bool useObjectPool = false /* Metadata: 0x00AF676C */) => default; // 0x00000001827441C0-0x00000001827444C0
	// [XID] // 0x0000000189774550-0x0000000189774570
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF676D */, bool useObjectPool = false /* Metadata: 0x00AF6771 */) => default; // 0x0000000182742F10-0x0000000182743410
	// [XID] // 0x000000018977BF60-0x000000018977BF80
	public static new ByTargetGlobalValue ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6772 */, bool useObjectPool = false /* Metadata: 0x00AF6776 */) => default; // 0x0000000182743B10-0x0000000182743D30
	[BlackList] // 0x0000000189783810-0x0000000189783850
	// [XID] // 0x0000000189783810-0x0000000189783850
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182742520-0x00000001827427F0
	// [XID] // 0x000000018978DDD0-0x000000018978DDF0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182744BC0-0x0000000182745010
	[BlackList] // 0x00000001897954A0-0x00000001897954E0
	// [XID] // 0x00000001897954A0-0x00000001897954E0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001827440D0-0x00000001827441C0
	// [XID] // 0x00000001897A0370-0x00000001897A0390
	public override bool Call(ActorAbilityPlugin abilityPlugin, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000182743410-0x0000000182743540
	[BlackList] // 0x00000001897A79E0-0x00000001897A7A20
	// [XID] // 0x00000001897A79E0-0x00000001897A7A20
	public override void AutoAllocTypeFields() {} // 0x00000001827427F0-0x0000000182742890
	[BlackList] // 0x00000001897B2290-0x00000001897B22D0
	// [XID] // 0x00000001897B2290-0x00000001897B22D0
	public override void AutoRecycleTypeFields() {} // 0x0000000182742890-0x0000000182742A40
	[BlackList] // 0x00000001897BD760-0x00000001897BD7A0
	// [XID] // 0x00000001897BD760-0x00000001897BD7A0
	public override void ReturnToObjectPool() {} // 0x0000000182745240-0x00000001827452E0
}

