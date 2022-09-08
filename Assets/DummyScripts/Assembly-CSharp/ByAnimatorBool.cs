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
public class ByAnimatorBool : RelationalOperationPredicate, IAutoAllocRecycle // TypeDefIndex: 17224
{
	// Fields
	private bool _value; // 0x20
	private string _parameter; // 0x28

	// Properties
	public bool value { /* [XID] */ /* 0x00000001895F3A30-0x00000001895F3A50 */ get => default; /* [XID] */ /* 0x00000001895FB330-0x00000001895FB350 */ private set {} } // 0x0000000182487D50-0x0000000182487DF0 0x0000000182487C20-0x0000000182487CD0
	public string parameter { /* [XID] */ /* 0x0000000189602A70-0x0000000189602A90 */ get => default; /* [XID] */ /* 0x000000018960A3F0-0x000000018960A410 */ private set {} } // 0x0000000182488390-0x0000000182488430 0x0000000182487660-0x0000000182487710

	// Constructors
	public ByAnimatorBool() {} // 0x0000000182489400-0x0000000182489460

	// Methods
	// [XID] // 0x0000000189611BA0-0x0000000189611BC0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182489250-0x0000000182489360
	// [XID] // 0x0000000189619480-0x00000001896194A0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182488E30-0x0000000182488F10
	// [XID] // 0x00000001896209E0-0x0000000189620A00
	public override ConfigAbilityPredicate Clone(bool useObjectPool = false /* Metadata: 0x00AF6727 */) => default; // 0x0000000182488A40-0x0000000182488B20
	// [XID] // 0x0000000189627F50-0x0000000189627F70
	public override int GetHashNum() => default; // 0x0000000182487530-0x0000000182487600
	// [XID] // 0x000000018962F840-0x000000018962F860
	public override void InitEmpty() {} // 0x00000001824884A0-0x0000000182488570
	[BlackList] // 0x00000001896373A0-0x00000001896373E0
	// [XID] // 0x00000001896373A0-0x00000001896373E0
	public override bool FromJson(JSONNode node) => default; // 0x0000000182487DF0-0x0000000182488170
	// [XID] // 0x0000000189641840-0x0000000189641860
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182486D00-0x0000000182486FF0
	[BlackList] // 0x0000000189649260-0x00000001896492A0
	// [XID] // 0x0000000189649260-0x00000001896492A0
	public static new ByAnimatorBool ParseFromJson(JSONNode node) => default; // 0x0000000182488B80-0x0000000182488DD0
	// [XID] // 0x00000001896538E0-0x0000000189653900
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6728 */, bool useObjectPool = false /* Metadata: 0x00AF672C */) => default; // 0x0000000182488740-0x0000000182488A40
	// [XID] // 0x000000018965B150-0x000000018965B170
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF672D */, bool useObjectPool = false /* Metadata: 0x00AF6731 */) => default; // 0x0000000182487790-0x0000000182487A70
	// [XID] // 0x0000000189662600-0x0000000189662620
	public static new ByAnimatorBool ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6732 */, bool useObjectPool = false /* Metadata: 0x00AF6736 */) => default; // 0x0000000182488170-0x0000000182488390
	[BlackList] // 0x000000018966A180-0x000000018966A1C0
	// [XID] // 0x000000018966A180-0x000000018966A1C0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182486FF0-0x00000001824872C0
	// [XID] // 0x0000000189674C30-0x0000000189674C50
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182488FC0-0x0000000182489250
	[BlackList] // 0x000000018967C4A0-0x000000018967C4E0
	// [XID] // 0x000000018967C4A0-0x000000018967C4E0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182488650-0x0000000182488740
	// [XID] // 0x0000000189686B10-0x0000000189686B30
	public override bool Call(ActorAbilityPlugin abilityPlugin, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000182487A70-0x0000000182487BA0
	[BlackList] // 0x000000018968E970-0x000000018968E9B0
	// [XID] // 0x000000018968E970-0x000000018968E9B0
	public override void AutoAllocTypeFields() {} // 0x00000001824872C0-0x0000000182487360
	[BlackList] // 0x0000000189699060-0x00000001896990A0
	// [XID] // 0x0000000189699060-0x00000001896990A0
	public override void AutoRecycleTypeFields() {} // 0x0000000182487360-0x0000000182487410
	[BlackList] // 0x00000001896A34A0-0x00000001896A34E0
	// [XID] // 0x00000001896A34A0-0x00000001896A34E0
	public override void ReturnToObjectPool() {} // 0x0000000182489360-0x0000000182489400
}

