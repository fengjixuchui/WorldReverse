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
public class ByItemNumber : ConfigAbilityPredicate, IAutoAllocRecycle // TypeDefIndex: 17278
{
	// Fields
	private SimpleSafeUInt32 itemIdRawNum; // 0x18
	private SimpleSafeUInt32 itemNumRawNum; // 0x1C

	// Properties
	public uint itemId { /* [XID] */ /* 0x0000000189B4AA50-0x0000000189B4AA70 */ get => default; /* [XID] */ /* 0x0000000189B52100-0x0000000189B52120 */ private set {} } // 0x00000001816513A0-0x0000000181651470 0x00000001816519A0-0x0000000181651A80
	public uint itemNum { /* [XID] */ /* 0x0000000189B59A60-0x0000000189B59A80 */ get => default; /* [XID] */ /* 0x0000000189B61210-0x0000000189B61230 */ private set {} } // 0x00000001816527A0-0x0000000181652870 0x00000001816522D0-0x00000001816523B0

	// Constructors
	public ByItemNumber() {} // 0x0000000181653260-0x00000001816532C0

	// Methods
	// [XID] // 0x0000000189B68AE0-0x0000000189B68B00
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001816530B0-0x00000001816531C0
	// [XID] // 0x0000000189B700C0-0x0000000189B700E0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000181652C60-0x0000000181652D10
	// [XID] // 0x0000000189B773F0-0x0000000189B77410
	public override ConfigAbilityPredicate Clone(bool useObjectPool = false /* Metadata: 0x00AF691B */) => default; // 0x0000000181652870-0x0000000181652950
	// [XID] // 0x0000000189B7EAA0-0x0000000189B7EAC0
	public override int GetHashNum() => default; // 0x0000000181651270-0x0000000181651340
	// [XID] // 0x0000000189B866C0-0x0000000189B866E0
	public override void InitEmpty() {} // 0x0000000181652110-0x00000001816521F0
	[BlackList] // 0x0000000189B8D7D0-0x0000000189B8D810
	// [XID] // 0x0000000189B8D7D0-0x0000000189B8D810
	public override bool FromJson(JSONNode node) => default; // 0x0000000181651B00-0x0000000181651E80
	// [XID] // 0x0000000189B97E20-0x0000000189B97E40
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000181650970-0x0000000181650CF0
	[BlackList] // 0x0000000189B9F210-0x0000000189B9F250
	// [XID] // 0x0000000189B9F210-0x0000000189B9F250
	public static new ByItemNumber ParseFromJson(JSONNode node) => default; // 0x00000001816529B0-0x0000000181652C00
	// [XID] // 0x0000000189BA99A0-0x0000000189BA99C0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF691C */, bool useObjectPool = false /* Metadata: 0x00AF6920 */) => default; // 0x00000001816524A0-0x00000001816527A0
	// [XID] // 0x0000000189BB1190-0x0000000189BB11B0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6921 */, bool useObjectPool = false /* Metadata: 0x00AF6925 */) => default; // 0x00000001816514F0-0x00000001816517F0
	// [XID] // 0x0000000189BB82C0-0x0000000189BB82E0
	public static new ByItemNumber ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6926 */, bool useObjectPool = false /* Metadata: 0x00AF692A */) => default; // 0x0000000181651E80-0x00000001816520A0
	[BlackList] // 0x0000000189BBFA30-0x0000000189BBFA70
	// [XID] // 0x0000000189BBFA30-0x0000000189BBFA70
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000181650CF0-0x0000000181650FC0
	// [XID] // 0x0000000189BCAA90-0x0000000189BCAAB0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181652DC0-0x00000001816530B0
	[BlackList] // 0x0000000189BD20C0-0x0000000189BD2100
	// [XID] // 0x0000000189BD20C0-0x0000000189BD2100
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001816523B0-0x00000001816524A0
	// [XID] // 0x0000000189BDCA60-0x0000000189BDCA80
	public override bool Call(ActorAbilityPlugin abilityPlugin, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x00000001816517F0-0x0000000181651920
	[BlackList] // 0x00000001895E92D0-0x00000001895E9310
	// [XID] // 0x00000001895E92D0-0x00000001895E9310
	public override void AutoAllocTypeFields() {} // 0x0000000181650FC0-0x0000000181651060
	[BlackList] // 0x00000001895F39F0-0x00000001895F3A30
	// [XID] // 0x00000001895F39F0-0x00000001895F3A30
	public override void AutoRecycleTypeFields() {} // 0x0000000181651060-0x0000000181651150
	[BlackList] // 0x00000001895FE180-0x00000001895FE1C0
	// [XID] // 0x00000001895FE180-0x00000001895FE1C0
	public override void ReturnToObjectPool() {} // 0x00000001816531C0-0x0000000181653260
}

