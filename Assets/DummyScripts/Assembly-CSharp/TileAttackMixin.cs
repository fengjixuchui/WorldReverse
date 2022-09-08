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
public class TileAttackMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 17067
{
	// Fields
	private string _attackID; // 0x30

	// Properties
	public string attackID { /* [XID] */ /* 0x00000001896933C0-0x00000001896933E0 */ get => default; /* [XID] */ /* 0x000000018969A650-0x000000018969A670 */ private set {} } // 0x00000001845780D0-0x0000000184578170 0x0000000184578170-0x0000000184578220
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x000000018971C920-0x000000018971C940 */ get => default; } // 0x0000000184578670-0x0000000184578710 

	// Constructors
	public TileAttackMixin() {} // 0x0000000184579D00-0x0000000184579D60

	// Methods
	// [XID] // 0x00000001896A1F80-0x00000001896A1FA0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184579B70-0x0000000184579C60
	// [XID] // 0x00000001896A92E0-0x00000001896A9300
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184579890-0x0000000184579970
	// [XID] // 0x00000001896B0470-0x00000001896B0490
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF6213 */) => default; // 0x00000001845794A0-0x0000000184579580
	// [XID] // 0x00000001896B7E30-0x00000001896B7E50
	public override int GetHashNum() => default; // 0x0000000184578000-0x00000001845780D0
	// [XID] // 0x00000001896BEE70-0x00000001896BEE90
	public override void InitEmpty() {} // 0x0000000184578E20-0x0000000184578EF0
	[BlackList] // 0x00000001896C67F0-0x00000001896C6830
	// [XID] // 0x00000001896C67F0-0x00000001896C6830
	public override bool FromJson(JSONNode node) => default; // 0x0000000184578710-0x0000000184578A90
	// [XID] // 0x00000001896D0C40-0x00000001896D0C60
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184577890-0x0000000184577AC0
	[BlackList] // 0x00000001896D81F0-0x00000001896D8230
	// [XID] // 0x00000001896D81F0-0x00000001896D8230
	public static new TileAttackMixin ParseFromJson(JSONNode node) => default; // 0x00000001845795E0-0x0000000184579830
	// [XID] // 0x00000001896E2A20-0x00000001896E2A40
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6214 */, bool useObjectPool = false /* Metadata: 0x00AF6218 */) => default; // 0x00000001845790C0-0x00000001845793C0
	// [XID] // 0x00000001896E9FA0-0x00000001896E9FC0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6219 */, bool useObjectPool = false /* Metadata: 0x00AF621D */) => default; // 0x0000000184578300-0x0000000184578570
	// [XID] // 0x00000001896F1040-0x00000001896F1060
	public static new TileAttackMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF621E */, bool useObjectPool = false /* Metadata: 0x00AF6222 */) => default; // 0x0000000184578B00-0x0000000184578D20
	[BlackList] // 0x00000001896F88E0-0x00000001896F8920
	// [XID] // 0x00000001896F88E0-0x00000001896F8920
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184577AC0-0x0000000184577D90
	// [XID] // 0x00000001897032B0-0x00000001897032D0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184579970-0x0000000184579B70
	[BlackList] // 0x000000018970A9E0-0x000000018970AA20
	// [XID] // 0x000000018970A9E0-0x000000018970AA20
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184578FD0-0x00000001845790C0
	// [XID] // 0x0000000189714E10-0x0000000189714E30
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x00000001845793C0-0x00000001845794A0
	[BlackList] // 0x0000000189723D30-0x0000000189723D70
	// [XID] // 0x0000000189723D30-0x0000000189723D70
	public override void AutoAllocTypeFields() {} // 0x0000000184577D90-0x0000000184577E30
	[BlackList] // 0x000000018972E4F0-0x000000018972E530
	// [XID] // 0x000000018972E4F0-0x000000018972E530
	public override void AutoRecycleTypeFields() {} // 0x0000000184577E30-0x0000000184577EE0
	[BlackList] // 0x0000000189738C90-0x0000000189738CD0
	// [XID] // 0x0000000189738C90-0x0000000189738CD0
	public override void ReturnToObjectPool() {} // 0x0000000184579C60-0x0000000184579D00
}

