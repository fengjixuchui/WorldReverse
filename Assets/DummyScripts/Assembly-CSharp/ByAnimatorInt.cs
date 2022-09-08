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
public class ByAnimatorInt : RelationalOperationPredicate, IAutoAllocRecycle // TypeDefIndex: 17222
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicInt _value; // 0x20
	private string _parameter; // 0x28

	// Properties
	public DynamicInt value { /* [XID] */ /* 0x0000000189B2E150-0x0000000189B2E170 */ get => default; /* [XID] */ /* 0x0000000189B35540-0x0000000189B35560 */ private set {} } // 0x0000000181A8D840-0x0000000181A8D8E0 0x0000000181A8D710-0x0000000181A8D7C0
	public string parameter { /* [XID] */ /* 0x0000000189B3CE00-0x0000000189B3CE20 */ get => default; /* [XID] */ /* 0x0000000189B44B50-0x0000000189B44B70 */ private set {} } // 0x0000000181A8DE80-0x0000000181A8DF20 0x0000000181A8D100-0x0000000181A8D1B0

	// Constructors
	public ByAnimatorInt() {} // 0x0000000181A8EF60-0x0000000181A8EFC0

	// Methods
	// [XID] // 0x0000000189B4C3A0-0x0000000189B4C3C0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181A8EDA0-0x0000000181A8EEC0
	// [XID] // 0x0000000189B539C0-0x0000000189B539E0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000181A8E940-0x0000000181A8EA40
	// [XID] // 0x0000000189B5B270-0x0000000189B5B290
	public override ConfigAbilityPredicate Clone(bool useObjectPool = false /* Metadata: 0x00AF6717 */) => default; // 0x0000000181A8E550-0x0000000181A8E630
	// [XID] // 0x0000000189B626A0-0x0000000189B626C0
	public override int GetHashNum() => default; // 0x0000000181A8CFD0-0x0000000181A8D0A0
	// [XID] // 0x0000000189B6A270-0x0000000189B6A290
	public override void InitEmpty() {} // 0x0000000181A8DF90-0x0000000181A8E080
	[BlackList] // 0x0000000189B71950-0x0000000189B71990
	// [XID] // 0x0000000189B71950-0x0000000189B71990
	public override bool FromJson(JSONNode node) => default; // 0x0000000181A8D8E0-0x0000000181A8DC60
	// [XID] // 0x0000000189B7BCB0-0x0000000189B7BCD0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000181A8C6E0-0x0000000181A8CA10
	[BlackList] // 0x0000000189B835A0-0x0000000189B835E0
	// [XID] // 0x0000000189B835A0-0x0000000189B835E0
	public static new ByAnimatorInt ParseFromJson(JSONNode node) => default; // 0x0000000181A8E690-0x0000000181A8E8E0
	// [XID] // 0x0000000189B8D810-0x0000000189B8D830
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6718 */, bool useObjectPool = false /* Metadata: 0x00AF671C */) => default; // 0x0000000181A8E250-0x0000000181A8E550
	// [XID] // 0x0000000189B94DF0-0x0000000189B94E10
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF671D */, bool useObjectPool = false /* Metadata: 0x00AF6721 */) => default; // 0x0000000181A8D230-0x0000000181A8D560
	// [XID] // 0x0000000189B9C520-0x0000000189B9C540
	public static new ByAnimatorInt ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6722 */, bool useObjectPool = false /* Metadata: 0x00AF6726 */) => default; // 0x0000000181A8DC60-0x0000000181A8DE80
	[BlackList] // 0x0000000189BA3B50-0x0000000189BA3B90
	// [XID] // 0x0000000189BA3B50-0x0000000189BA3B90
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000181A8CA10-0x0000000181A8CCE0
	// [XID] // 0x0000000189BADC80-0x0000000189BADCA0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181A8EAF0-0x0000000181A8EDA0
	[BlackList] // 0x0000000189BB5450-0x0000000189BB5490
	// [XID] // 0x0000000189BB5450-0x0000000189BB5490
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000181A8E160-0x0000000181A8E250
	// [XID] // 0x0000000189BBFAB0-0x0000000189BBFAD0
	public override bool Call(ActorAbilityPlugin abilityPlugin, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000181A8D560-0x0000000181A8D690
	[BlackList] // 0x0000000189BC76A0-0x0000000189BC76E0
	// [XID] // 0x0000000189BC76A0-0x0000000189BC76E0
	public override void AutoAllocTypeFields() {} // 0x0000000181A8CCE0-0x0000000181A8CD80
	[BlackList] // 0x0000000189BD2140-0x0000000189BD2180
	// [XID] // 0x0000000189BD2140-0x0000000189BD2180
	public override void AutoRecycleTypeFields() {} // 0x0000000181A8CD80-0x0000000181A8CEB0
	[BlackList] // 0x0000000189BDCA80-0x0000000189BDCAC0
	// [XID] // 0x0000000189BDCA80-0x0000000189BDCAC0
	public override void ReturnToObjectPool() {} // 0x0000000181A8EEC0-0x0000000181A8EF60
}

