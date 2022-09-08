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
public class ByAnimatorFloat : RelationalOperationPredicate, IAutoAllocRecycle // TypeDefIndex: 17220
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _value; // 0x20
	private string _parameter; // 0x28

	// Properties
	public DynamicFloat value { /* [XID] */ /* 0x0000000189A65220-0x0000000189A65240 */ get => default; /* [XID] */ /* 0x0000000189A6C9C0-0x0000000189A6C9E0 */ private set {} } // 0x0000000183FC5680-0x0000000183FC5720 0x0000000183FC5550-0x0000000183FC5600
	public string parameter { /* [XID] */ /* 0x0000000189A74130-0x0000000189A74150 */ get => default; /* [XID] */ /* 0x0000000189A7BAC0-0x0000000189A7BAE0 */ private set {} } // 0x0000000183FC5CC0-0x0000000183FC5D60 0x0000000183FC4F40-0x0000000183FC4FF0

	// Constructors
	public ByAnimatorFloat() {} // 0x0000000183FC6DA0-0x0000000183FC6E00

	// Methods
	// [XID] // 0x0000000189A833E0-0x0000000189A83400
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183FC6BE0-0x0000000183FC6D00
	// [XID] // 0x0000000189A8AD40-0x0000000189A8AD60
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183FC6780-0x0000000183FC6880
	// [XID] // 0x0000000189A92490-0x0000000189A924B0
	public override ConfigAbilityPredicate Clone(bool useObjectPool = false /* Metadata: 0x00AF6707 */) => default; // 0x0000000183FC6390-0x0000000183FC6470
	// [XID] // 0x0000000189A99E80-0x0000000189A99EA0
	public override int GetHashNum() => default; // 0x0000000183FC4E10-0x0000000183FC4EE0
	// [XID] // 0x0000000189AA0E60-0x0000000189AA0E80
	public override void InitEmpty() {} // 0x0000000183FC5DD0-0x0000000183FC5EC0
	[BlackList] // 0x0000000189AA8520-0x0000000189AA8560
	// [XID] // 0x0000000189AA8520-0x0000000189AA8560
	public override bool FromJson(JSONNode node) => default; // 0x0000000183FC5720-0x0000000183FC5AA0
	// [XID] // 0x0000000189AB3160-0x0000000189AB3180
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183FC4520-0x0000000183FC4850
	[BlackList] // 0x0000000189ABADF0-0x0000000189ABAE30
	// [XID] // 0x0000000189ABADF0-0x0000000189ABAE30
	public static new ByAnimatorFloat ParseFromJson(JSONNode node) => default; // 0x0000000183FC64D0-0x0000000183FC6720
	// [XID] // 0x0000000189AC5790-0x0000000189AC57B0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6708 */, bool useObjectPool = false /* Metadata: 0x00AF670C */) => default; // 0x0000000183FC6090-0x0000000183FC6390
	// [XID] // 0x0000000189ACCC40-0x0000000189ACCC60
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF670D */, bool useObjectPool = false /* Metadata: 0x00AF6711 */) => default; // 0x0000000183FC5070-0x0000000183FC53A0
	// [XID] // 0x0000000189AD49A0-0x0000000189AD49C0
	public static new ByAnimatorFloat ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6712 */, bool useObjectPool = false /* Metadata: 0x00AF6716 */) => default; // 0x0000000183FC5AA0-0x0000000183FC5CC0
	[BlackList] // 0x0000000189ADC2C0-0x0000000189ADC300
	// [XID] // 0x0000000189ADC2C0-0x0000000189ADC300
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000183FC4850-0x0000000183FC4B20
	// [XID] // 0x0000000189AE6D10-0x0000000189AE6D30
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183FC6930-0x0000000183FC6BE0
	[BlackList] // 0x0000000189AEE860-0x0000000189AEE8A0
	// [XID] // 0x0000000189AEE860-0x0000000189AEE8A0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183FC5FA0-0x0000000183FC6090
	// [XID] // 0x0000000189AF8F70-0x0000000189AF8F90
	public override bool Call(ActorAbilityPlugin abilityPlugin, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000183FC53A0-0x0000000183FC54D0
	[BlackList] // 0x0000000189B00510-0x0000000189B00550
	// [XID] // 0x0000000189B00510-0x0000000189B00550
	public override void AutoAllocTypeFields() {} // 0x0000000183FC4B20-0x0000000183FC4BC0
	[BlackList] // 0x0000000189B0AC00-0x0000000189B0AC40
	// [XID] // 0x0000000189B0AC00-0x0000000189B0AC40
	public override void AutoRecycleTypeFields() {} // 0x0000000183FC4BC0-0x0000000183FC4CF0
	[BlackList] // 0x0000000189B14FD0-0x0000000189B15010
	// [XID] // 0x0000000189B14FD0-0x0000000189B15010
	public override void ReturnToObjectPool() {} // 0x0000000183FC6D00-0x0000000183FC6DA0
}

