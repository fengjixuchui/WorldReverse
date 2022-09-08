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
public class ByTargetHPValue : RelationalOperationPredicate, IAutoAllocRecycle // TypeDefIndex: 17186
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _HP; // 0x20

	// Properties
	public DynamicFloat HP { /* [XID] */ /* 0x0000000189A7BAE0-0x0000000189A7BB00 */ get => default; /* [XID] */ /* 0x0000000189A83400-0x0000000189A83420 */ private set {} } // 0x00000001844818A0-0x0000000184481940 0x000000018447F610-0x000000018447F6C0

	// Constructors
	public ByTargetHPValue() {} // 0x0000000184481AC0-0x0000000184481B20

	// Methods
	// [XID] // 0x0000000189A8AD60-0x0000000189A8AD80
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184481940-0x0000000184481A20
	// [XID] // 0x0000000189A924B0-0x0000000189A924D0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001844814E0-0x00000001844815C0
	// [XID] // 0x0000000189A99EA0-0x0000000189A99EC0
	public override ConfigAbilityPredicate Clone(bool useObjectPool = false /* Metadata: 0x00AF65F7 */) => default; // 0x00000001844810F0-0x00000001844811D0
	// [XID] // 0x0000000189AA0E80-0x0000000189AA0EA0
	public override int GetHashNum() => default; // 0x000000018447FEC0-0x000000018447FF90
	// [XID] // 0x0000000189AA8560-0x0000000189AA8580
	public override void InitEmpty() {} // 0x0000000184480B50-0x0000000184480C20
	[BlackList] // 0x0000000189AB01C0-0x0000000189AB0200
	// [XID] // 0x0000000189AB01C0-0x0000000189AB0200
	public override bool FromJson(JSONNode node) => default; // 0x0000000184480540-0x00000001844808C0
	// [XID] // 0x0000000189ABAE30-0x0000000189ABAE50
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018447F6C0-0x000000018447F900
	[BlackList] // 0x0000000189AC26A0-0x0000000189AC26E0
	// [XID] // 0x0000000189AC26A0-0x0000000189AC26E0
	public static new ByTargetHPValue ParseFromJson(JSONNode node) => default; // 0x0000000184481230-0x0000000184481480
	// [XID] // 0x0000000189ACCC60-0x0000000189ACCC80
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF65F8 */, bool useObjectPool = false /* Metadata: 0x00AF65FC */) => default; // 0x0000000184480DF0-0x00000001844810F0
	// [XID] // 0x0000000189AD49C0-0x0000000189AD49E0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF65FD */, bool useObjectPool = false /* Metadata: 0x00AF6601 */) => default; // 0x0000000184480070-0x0000000184480310
	// [XID] // 0x0000000189ADC300-0x0000000189ADC320
	public static new ByTargetHPValue ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6602 */, bool useObjectPool = false /* Metadata: 0x00AF6606 */) => default; // 0x00000001844808C0-0x0000000184480AE0
	[BlackList] // 0x0000000189AE3D10-0x0000000189AE3D50
	// [XID] // 0x0000000189AE3D10-0x0000000189AE3D50
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018447F900-0x000000018447FBD0
	// [XID] // 0x0000000189AEE8A0-0x0000000189AEE8C0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184481670-0x00000001844818A0
	[BlackList] // 0x0000000189AF5E70-0x0000000189AF5EB0
	// [XID] // 0x0000000189AF5E70-0x0000000189AF5EB0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184480D00-0x0000000184480DF0
	// [XID] // 0x0000000189B00550-0x0000000189B00570
	public override bool Call(ActorAbilityPlugin abilityPlugin, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000184480310-0x0000000184480440
	[BlackList] // 0x0000000189B079F0-0x0000000189B07A30
	// [XID] // 0x0000000189B079F0-0x0000000189B07A30
	public override void AutoAllocTypeFields() {} // 0x000000018447FBD0-0x000000018447FC70
	[BlackList] // 0x0000000189B12320-0x0000000189B12360
	// [XID] // 0x0000000189B12320-0x0000000189B12360
	public override void AutoRecycleTypeFields() {} // 0x000000018447FC70-0x000000018447FDA0
	[BlackList] // 0x0000000189B1C9D0-0x0000000189B1CA10
	// [XID] // 0x0000000189B1C9D0-0x0000000189B1CA10
	public override void ReturnToObjectPool() {} // 0x0000000184481A20-0x0000000184481AC0
}

