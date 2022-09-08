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
public class MoveStateMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 17131
{
	// Fields
	private MoveStateMixinType _type; // 0x30

	// Properties
	public MoveStateMixinType type { /* [XID] */ /* 0x0000000189607180-0x00000001896071A0 */ get => default; /* [XID] */ /* 0x000000018960EBC0-0x000000018960EBE0 */ private set {} } // 0x000000018331C210-0x000000018331C2B0 0x000000018331BE70-0x000000018331BF20
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x00000001896933A0-0x00000001896933C0 */ get => default; } // 0x000000018331ABD0-0x000000018331AC70 

	// Constructors
	public MoveStateMixin() {} // 0x000000018331C350-0x000000018331C3B0

	// Methods
	// [XID] // 0x00000001896161A0-0x00000001896161C0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018331C120-0x000000018331C210
	// [XID] // 0x000000018961D9F0-0x000000018961DA10
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018331BDC0-0x000000018331BE70
	// [XID] // 0x0000000189624E70-0x0000000189624E90
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF6431 */) => default; // 0x000000018331B9D0-0x000000018331BAB0
	// [XID] // 0x000000018962C610-0x000000018962C630
	public override int GetHashNum() => default; // 0x000000018331A6F0-0x000000018331A7C0
	// [XID] // 0x00000001896342B0-0x00000001896342D0
	public override void InitEmpty() {} // 0x000000018331B380-0x000000018331B420
	[BlackList] // 0x000000018963BA60-0x000000018963BAA0
	// [XID] // 0x000000018963BA60-0x000000018963BAA0
	public override bool FromJson(JSONNode node) => default; // 0x000000018331AC70-0x000000018331AFF0
	// [XID] // 0x0000000189646080-0x00000001896460A0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183319F90-0x000000018331A1B0
	[BlackList] // 0x000000018964D8C0-0x000000018964D900
	// [XID] // 0x000000018964D8C0-0x000000018964D900
	public static new MoveStateMixin ParseFromJson(JSONNode node) => default; // 0x000000018331BB10-0x000000018331BD60
	// [XID] // 0x0000000189658130-0x0000000189658150
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6432 */, bool useObjectPool = false /* Metadata: 0x00AF6436 */) => default; // 0x000000018331B5F0-0x000000018331B8F0
	// [XID] // 0x000000018965F6C0-0x000000018965F6E0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6437 */, bool useObjectPool = false /* Metadata: 0x00AF643B */) => default; // 0x000000018331A8A0-0x000000018331AAD0
	// [XID] // 0x0000000189667070-0x0000000189667090
	public static new MoveStateMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF643C */, bool useObjectPool = false /* Metadata: 0x00AF6440 */) => default; // 0x000000018331B060-0x000000018331B280
	[BlackList] // 0x000000018966E740-0x000000018966E780
	// [XID] // 0x000000018966E740-0x000000018966E780
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018331A1B0-0x000000018331A480
	// [XID] // 0x00000001896795D0-0x00000001896795F0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018331BF20-0x000000018331C120
	[BlackList] // 0x0000000189680CA0-0x0000000189680CE0
	// [XID] // 0x0000000189680CA0-0x0000000189680CE0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018331B500-0x000000018331B5F0
	// [XID] // 0x000000018968B850-0x000000018968B870
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x000000018331B8F0-0x000000018331B9D0
	[BlackList] // 0x000000018969A610-0x000000018969A650
	// [XID] // 0x000000018969A610-0x000000018969A650
	public override void AutoAllocTypeFields() {} // 0x000000018331A480-0x000000018331A520
	[BlackList] // 0x00000001896A4A20-0x00000001896A4A60
	// [XID] // 0x00000001896A4A20-0x00000001896A4A60
	public override void AutoRecycleTypeFields() {} // 0x000000018331A520-0x000000018331A5D0
	[BlackList] // 0x00000001896AEF10-0x00000001896AEF50
	// [XID] // 0x00000001896AEF10-0x00000001896AEF50
	public override void ReturnToObjectPool() {} // 0x000000018331C2B0-0x000000018331C350
}

