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
public class TileComplexManagerMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 17076
{
	// Fields
	private string _attackID; // 0x30
	private SimpleSafeFloat intervalRawNum; // 0x38
	private SimpleSafeUInt32 srcCampRawNum; // 0x3C
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAttackInfo _attackInfo; // 0x40

	// Properties
	public string attackID { /* [XID] */ /* 0x0000000189A1BE10-0x0000000189A1BE30 */ get => default; /* [XID] */ /* 0x0000000189A23680-0x0000000189A236A0 */ private set {} } // 0x0000000182788DD0-0x0000000182788E70 0x0000000182788E70-0x0000000182788F20
	public float interval { /* [XID] */ /* 0x0000000189A2AA80-0x0000000189A2AAA0 */ get => default; /* [XID] */ /* 0x0000000189A32040-0x0000000189A32060 */ private set {} } // 0x000000018278A7A0-0x000000018278A880 0x0000000182789450-0x0000000182789530
	public uint srcCamp { /* [XID] */ /* 0x0000000189A39970-0x0000000189A39990 */ get => default; /* [XID] */ /* 0x0000000189A411B0-0x0000000189A411D0 */ private set {} } // 0x0000000182788000-0x00000001827880D0 0x0000000182789A50-0x0000000182789B30
	public ConfigAttackInfo attackInfo { /* [XID] */ /* 0x0000000189A48870-0x0000000189A48890 */ get => default; /* [XID] */ /* 0x0000000189A4FFC0-0x0000000189A4FFE0 */ private set {} } // 0x000000018278A5C0-0x000000018278A660 0x00000001827880D0-0x0000000182788180
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x0000000189AD49E0-0x0000000189AD4A00 */ get => default; } // 0x0000000182789630-0x00000001827896D0 

	// Constructors
	public TileComplexManagerMixin() {} // 0x000000018278B220-0x000000018278B2B0

	// Methods
	// [XID] // 0x0000000189A575F0-0x0000000189A57610
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018278B020-0x000000018278B180
	// [XID] // 0x0000000189A5F0B0-0x0000000189A5F0D0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018278AB30-0x000000018278AC30
	// [XID] // 0x0000000189A669A0-0x0000000189A669C0
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF6253 */) => default; // 0x000000018278A660-0x000000018278A740
	// [XID] // 0x0000000189A6E240-0x0000000189A6E260
	public override int GetHashNum() => default; // 0x0000000182788D00-0x0000000182788DD0
	// [XID] // 0x0000000189A757D0-0x0000000189A757F0
	public override void InitEmpty() {} // 0x0000000182789EC0-0x000000018278A010
	[BlackList] // 0x0000000189A7D430-0x0000000189A7D470
	// [XID] // 0x0000000189A7D430-0x0000000189A7D470
	public override bool FromJson(JSONNode node) => default; // 0x00000001827896D0-0x0000000182789A50
	// [XID] // 0x0000000189A87DC0-0x0000000189A87DE0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182788180-0x00000001827886D0
	[BlackList] // 0x0000000189A8F610-0x0000000189A8F650
	// [XID] // 0x0000000189A8F610-0x0000000189A8F650
	public static new TileComplexManagerMixin ParseFromJson(JSONNode node) => default; // 0x000000018278A880-0x000000018278AAD0
	// [XID] // 0x0000000189A99EC0-0x0000000189A99EE0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6254 */, bool useObjectPool = false /* Metadata: 0x00AF6258 */) => default; // 0x000000018278A1E0-0x000000018278A4E0
	// [XID] // 0x0000000189AA0EA0-0x0000000189AA0EC0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6259 */, bool useObjectPool = false /* Metadata: 0x00AF625D */) => default; // 0x0000000182789000-0x0000000182789450
	// [XID] // 0x0000000189AA8580-0x0000000189AA85A0
	public static new TileComplexManagerMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF625E */, bool useObjectPool = false /* Metadata: 0x00AF6262 */) => default; // 0x0000000182789BA0-0x0000000182789DC0
	[BlackList] // 0x0000000189AB0240-0x0000000189AB0280
	// [XID] // 0x0000000189AB0240-0x0000000189AB0280
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001827886D0-0x00000001827889A0
	// [XID] // 0x0000000189ABAE70-0x0000000189ABAE90
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018278AC30-0x000000018278B020
	[BlackList] // 0x0000000189AC2700-0x0000000189AC2740
	// [XID] // 0x0000000189AC2700-0x0000000189AC2740
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018278A0F0-0x000000018278A1E0
	// [XID] // 0x0000000189ACCC80-0x0000000189ACCCA0
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x000000018278A4E0-0x000000018278A5C0
	[BlackList] // 0x0000000189ADC320-0x0000000189ADC360
	// [XID] // 0x0000000189ADC320-0x0000000189ADC360
	public override void AutoAllocTypeFields() {} // 0x00000001827889A0-0x0000000182788A40
	[BlackList] // 0x0000000189AE6D70-0x0000000189AE6DB0
	// [XID] // 0x0000000189AE6D70-0x0000000189AE6DB0
	public override void AutoRecycleTypeFields() {} // 0x0000000182788A40-0x0000000182788BE0
	[BlackList] // 0x0000000189AF1870-0x0000000189AF18B0
	// [XID] // 0x0000000189AF1870-0x0000000189AF18B0
	public override void ReturnToObjectPool() {} // 0x000000018278B180-0x000000018278B220
}

