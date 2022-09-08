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
public class ByHitBoxType : ConfigAbilityPredicate, IAutoAllocRecycle // TypeDefIndex: 17200
{
	// Fields
	private HitBoxType _hitBoxType; // 0x18

	// Properties
	public HitBoxType hitBoxType { /* [XID] */ /* 0x000000018996C9F0-0x000000018996CA10 */ get => default; /* [XID] */ /* 0x0000000189974430-0x0000000189974450 */ private set {} } // 0x0000000182F845B0-0x0000000182F84650 0x0000000182F84650-0x0000000182F84700

	// Constructors
	public ByHitBoxType() {} // 0x0000000182F84B40-0x0000000182F84BA0

	// Methods
	// [XID] // 0x000000018997BAA0-0x000000018997BAC0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182F849B0-0x0000000182F84AA0
	// [XID] // 0x00000001899835D0-0x00000001899835F0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182F84500-0x0000000182F845B0
	// [XID] // 0x000000018998ADC0-0x000000018998ADE0
	public override ConfigAbilityPredicate Clone(bool useObjectPool = false /* Metadata: 0x00AF6667 */) => default; // 0x0000000182F84110-0x0000000182F841F0
	// [XID] // 0x00000001899926F0-0x0000000189992710
	public override int GetHashNum() => default; // 0x0000000182F82F80-0x0000000182F83050
	// [XID] // 0x000000018999A490-0x000000018999A4B0
	public override void InitEmpty() {} // 0x0000000182F83BA0-0x0000000182F83C40
	[BlackList] // 0x00000001899A1AF0-0x00000001899A1B30
	// [XID] // 0x00000001899A1AF0-0x00000001899A1B30
	public override bool FromJson(JSONNode node) => default; // 0x0000000182F83590-0x0000000182F83910
	// [XID] // 0x00000001899AC6B0-0x00000001899AC6D0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182F82820-0x0000000182F82A40
	[BlackList] // 0x00000001899B3E00-0x00000001899B3E40
	// [XID] // 0x00000001899B3E00-0x00000001899B3E40
	public static new ByHitBoxType ParseFromJson(JSONNode node) => default; // 0x0000000182F84250-0x0000000182F844A0
	// [XID] // 0x00000001899BE4D0-0x00000001899BE4F0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6668 */, bool useObjectPool = false /* Metadata: 0x00AF666C */) => default; // 0x0000000182F83E10-0x0000000182F84110
	// [XID] // 0x00000001899C5C90-0x00000001899C5CB0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF666D */, bool useObjectPool = false /* Metadata: 0x00AF6671 */) => default; // 0x0000000182F83130-0x0000000182F83360
	// [XID] // 0x00000001899CD450-0x00000001899CD470
	public static new ByHitBoxType ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6672 */, bool useObjectPool = false /* Metadata: 0x00AF6676 */) => default; // 0x0000000182F83910-0x0000000182F83B30
	[BlackList] // 0x00000001899D4890-0x00000001899D48D0
	// [XID] // 0x00000001899D4890-0x00000001899D48D0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182F82A40-0x0000000182F82D10
	// [XID] // 0x00000001899DEC90-0x00000001899DECB0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182F847B0-0x0000000182F849B0
	[BlackList] // 0x00000001899E68D0-0x00000001899E6910
	// [XID] // 0x00000001899E68D0-0x00000001899E6910
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182F83D20-0x0000000182F83E10
	// [XID] // 0x00000001899F0DB0-0x00000001899F0DD0
	public override bool Call(ActorAbilityPlugin abilityPlugin, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000182F83360-0x0000000182F83490
	[BlackList] // 0x00000001899F8690-0x00000001899F86D0
	// [XID] // 0x00000001899F8690-0x00000001899F86D0
	public override void AutoAllocTypeFields() {} // 0x0000000182F82D10-0x0000000182F82DB0
	[BlackList] // 0x0000000189A02C90-0x0000000189A02CD0
	// [XID] // 0x0000000189A02C90-0x0000000189A02CD0
	public override void AutoRecycleTypeFields() {} // 0x0000000182F82DB0-0x0000000182F82E60
	[BlackList] // 0x0000000189A0D360-0x0000000189A0D3A0
	// [XID] // 0x0000000189A0D360-0x0000000189A0D3A0
	public override void ReturnToObjectPool() {} // 0x0000000182F84AA0-0x0000000182F84B40
}

