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
public class ByHitImpulse : ConfigAbilityPredicate, IAutoAllocRecycle // TypeDefIndex: 17238
{
	// Fields
	private SimpleSafeFloat hitImpulseRawNum; // 0x18

	// Properties
	public float hitImpulse { /* [XID] */ /* 0x0000000189A2F130-0x0000000189A2F150 */ get => default; /* [XID] */ /* 0x0000000189A36AF0-0x0000000189A36B10 */ private set {} } // 0x00000001831874E0-0x00000001831875C0 0x0000000183188340-0x0000000183188420

	// Constructors
	public ByHitImpulse() {} // 0x0000000183188BD0-0x0000000183188C70

	// Methods
	// [XID] // 0x0000000189A3E1B0-0x0000000189A3E1D0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183188A30-0x0000000183188B30
	// [XID] // 0x0000000189A458E0-0x0000000189A45900
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001831886D0-0x0000000183188780
	// [XID] // 0x0000000189A4CF20-0x0000000189A4CF40
	public override ConfigAbilityPredicate Clone(bool useObjectPool = false /* Metadata: 0x00AF67A7 */) => default; // 0x0000000183188200-0x00000001831882E0
	// [XID] // 0x0000000189A54670-0x0000000189A54690
	public override int GetHashNum() => default; // 0x0000000183186F50-0x0000000183187020
	// [XID] // 0x0000000189A5C180-0x0000000189A5C1A0
	public override void InitEmpty() {} // 0x0000000183187C50-0x0000000183187D30
	[BlackList] // 0x0000000189A63AB0-0x0000000189A63AF0
	// [XID] // 0x0000000189A63AB0-0x0000000189A63AF0
	public override bool FromJson(JSONNode node) => default; // 0x0000000183187640-0x00000001831879C0
	// [XID] // 0x0000000189A6E220-0x0000000189A6E240
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183186790-0x00000001831869E0
	[BlackList] // 0x0000000189A75790-0x0000000189A757D0
	// [XID] // 0x0000000189A75790-0x0000000189A757D0
	public static new ByHitImpulse ParseFromJson(JSONNode node) => default; // 0x0000000183188420-0x0000000183188670
	// [XID] // 0x0000000189A800C0-0x0000000189A800E0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF67A8 */, bool useObjectPool = false /* Metadata: 0x00AF67AC */) => default; // 0x0000000183187F00-0x0000000183188200
	// [XID] // 0x0000000189A87D80-0x0000000189A87DA0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF67AD */, bool useObjectPool = false /* Metadata: 0x00AF67B1 */) => default; // 0x0000000183187100-0x0000000183187330
	// [XID] // 0x0000000189A8F5D0-0x0000000189A8F5F0
	public static new ByHitImpulse ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF67B2 */, bool useObjectPool = false /* Metadata: 0x00AF67B6 */) => default; // 0x00000001831879C0-0x0000000183187BE0
	[BlackList] // 0x0000000189A96B60-0x0000000189A96BA0
	// [XID] // 0x0000000189A96B60-0x0000000189A96BA0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001831869E0-0x0000000183186CB0
	// [XID] // 0x0000000189AA0E40-0x0000000189AA0E60
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183188830-0x0000000183188A30
	[BlackList] // 0x0000000189AA84E0-0x0000000189AA8520
	// [XID] // 0x0000000189AA84E0-0x0000000189AA8520
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183187E10-0x0000000183187F00
	// [XID] // 0x0000000189AB3140-0x0000000189AB3160
	public override bool Call(ActorAbilityPlugin abilityPlugin, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000183187330-0x0000000183187460
	[BlackList] // 0x0000000189ABADB0-0x0000000189ABADF0
	// [XID] // 0x0000000189ABADB0-0x0000000189ABADF0
	public override void AutoAllocTypeFields() {} // 0x0000000183186CB0-0x0000000183186D50
	[BlackList] // 0x0000000189AC5750-0x0000000189AC5790
	// [XID] // 0x0000000189AC5750-0x0000000189AC5790
	public override void AutoRecycleTypeFields() {} // 0x0000000183186D50-0x0000000183186E30
	[BlackList] // 0x0000000189ACFCD0-0x0000000189ACFD10
	// [XID] // 0x0000000189ACFCD0-0x0000000189ACFD10
	public override void ReturnToObjectPool() {} // 0x0000000183188B30-0x0000000183188BD0
}

