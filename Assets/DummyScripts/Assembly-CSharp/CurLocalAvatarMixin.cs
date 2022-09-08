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
public class CurLocalAvatarMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 17018
{
	// Fields
	private string _modifierName; // 0x30

	// Properties
	public string modifierName { /* [XID] */ /* 0x0000000189932660-0x0000000189932680 */ get => default; /* [XID] */ /* 0x000000018993A050-0x000000018993A070 */ private set {} } // 0x0000000182E9AD10-0x0000000182E9ADB0 0x0000000182E99FD0-0x0000000182E9A080
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x00000001899BE510-0x00000001899BE530 */ get => default; } // 0x0000000182E99670-0x0000000182E99710 

	// Constructors
	public CurLocalAvatarMixin() {} // 0x0000000182E9AE50-0x0000000182E9AEB0

	// Methods
	// [XID] // 0x0000000189941260-0x0000000189941280
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182E9AC20-0x0000000182E9AD10
	// [XID] // 0x0000000189948D80-0x0000000189948DA0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182E9A940-0x0000000182E9AA20
	// [XID] // 0x0000000189950590-0x00000001899505B0
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF608D */) => default; // 0x0000000182E9A550-0x0000000182E9A630
	// [XID] // 0x0000000189957AE0-0x0000000189957B00
	public override int GetHashNum() => default; // 0x0000000182E99150-0x0000000182E99220
	// [XID] // 0x000000018995F370-0x000000018995F390
	public override void InitEmpty() {} // 0x0000000182E99E20-0x0000000182E99EF0
	[BlackList] // 0x0000000189966C70-0x0000000189966CB0
	// [XID] // 0x0000000189966C70-0x0000000189966CB0
	public override bool FromJson(JSONNode node) => default; // 0x0000000182E99710-0x0000000182E99A90
	// [XID] // 0x0000000189971840-0x0000000189971860
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182E989E0-0x0000000182E98C10
	[BlackList] // 0x0000000189979110-0x0000000189979150
	// [XID] // 0x0000000189979110-0x0000000189979150
	public static new CurLocalAvatarMixin ParseFromJson(JSONNode node) => default; // 0x0000000182E9A690-0x0000000182E9A8E0
	// [XID] // 0x0000000189983630-0x0000000189983650
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF608E */, bool useObjectPool = false /* Metadata: 0x00AF6092 */) => default; // 0x0000000182E9A170-0x0000000182E9A470
	// [XID] // 0x000000018998ADE0-0x000000018998AE00
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6093 */, bool useObjectPool = false /* Metadata: 0x00AF6097 */) => default; // 0x0000000182E99300-0x0000000182E99570
	// [XID] // 0x0000000189992710-0x0000000189992730
	public static new CurLocalAvatarMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6098 */, bool useObjectPool = false /* Metadata: 0x00AF609C */) => default; // 0x0000000182E99B00-0x0000000182E99D20
	[BlackList] // 0x000000018999A4D0-0x000000018999A510
	// [XID] // 0x000000018999A4D0-0x000000018999A510
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182E98C10-0x0000000182E98EE0
	// [XID] // 0x00000001899A4BD0-0x00000001899A4BF0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182E9AA20-0x0000000182E9AC20
	[BlackList] // 0x00000001899AC6F0-0x00000001899AC730
	// [XID] // 0x00000001899AC6F0-0x00000001899AC730
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182E9A080-0x0000000182E9A170
	// [XID] // 0x00000001899B6A70-0x00000001899B6A90
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x0000000182E9A470-0x0000000182E9A550
	[BlackList] // 0x00000001899C5CF0-0x00000001899C5D30
	// [XID] // 0x00000001899C5CF0-0x00000001899C5D30
	public override void AutoAllocTypeFields() {} // 0x0000000182E98EE0-0x0000000182E98F80
	[BlackList] // 0x00000001899D03F0-0x00000001899D0430
	// [XID] // 0x00000001899D03F0-0x00000001899D0430
	public override void AutoRecycleTypeFields() {} // 0x0000000182E98F80-0x0000000182E99030
	[BlackList] // 0x00000001899DA840-0x00000001899DA880
	// [XID] // 0x00000001899DA840-0x00000001899DA880
	public override void ReturnToObjectPool() {} // 0x0000000182E9ADB0-0x0000000182E9AE50
}

