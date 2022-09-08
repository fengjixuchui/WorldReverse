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
public class RejectAttackMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 16996
{
	// Fields
	private string _attackTag; // 0x30
	private SimpleSafeFloat limitTimeRawNum; // 0x38
	private RejectEventType _type; // 0x3C

	// Properties
	public string attackTag { /* [XID] */ /* 0x0000000189B86760-0x0000000189B86780 */ get => default; /* [XID] */ /* 0x0000000189B8D890-0x0000000189B8D8B0 */ private set {} } // 0x000000018450B230-0x000000018450B2D0 0x000000018450B350-0x000000018450B400
	public float limitTime { /* [XID] */ /* 0x0000000189B94E70-0x0000000189B94E90 */ get => default; /* [XID] */ /* 0x0000000189B9C600-0x0000000189B9C620 */ private set {} } // 0x000000018450CB70-0x000000018450CC50 0x000000018450BEE0-0x000000018450BFC0
	public RejectEventType type { /* [XID] */ /* 0x0000000189BA3C10-0x0000000189BA3C30 */ get => default; /* [XID] */ /* 0x0000000189BAB080-0x0000000189BAB0A0 */ private set {} } // 0x000000018450DDE0-0x000000018450DE80 0x000000018450D8E0-0x000000018450D990
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x00000001896343B0-0x00000001896343D0 */ get => default; } // 0x000000018450C4C0-0x000000018450C560 

	// Constructors
	public RejectAttackMixin() {} // 0x000000018450DF20-0x000000018450DF90

	// Methods
	// [XID] // 0x0000000189BB2670-0x0000000189BB2690
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018450DCB0-0x000000018450DDE0
	// [XID] // 0x0000000189BB9A60-0x0000000189BB9A80
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018450D800-0x000000018450D8E0
	// [XID] // 0x0000000189BC1A40-0x0000000189BC1A60
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF5FE1 */) => default; // 0x000000018450D410-0x000000018450D4F0
	// [XID] // 0x0000000189BC9060-0x0000000189BC9080
	public override int GetHashNum() => default; // 0x000000018450BDB0-0x000000018450BE80
	// [XID] // 0x0000000189BD0970-0x0000000189BD0990
	public override void InitEmpty() {} // 0x000000018450CD50-0x000000018450CE60
	[BlackList] // 0x0000000189BD7E30-0x0000000189BD7E70
	// [XID] // 0x0000000189BD7E30-0x0000000189BD7E70
	public override bool FromJson(JSONNode node) => default; // 0x000000018450C560-0x000000018450C8E0
	// [XID] // 0x00000001895E7AD0-0x00000001895E7AF0
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018450B400-0x000000018450B830
	[BlackList] // 0x00000001895EF400-0x00000001895EF440
	// [XID] // 0x00000001895EF400-0x00000001895EF440
	public static new RejectAttackMixin ParseFromJson(JSONNode node) => default; // 0x000000018450D550-0x000000018450D7A0
	// [XID] // 0x00000001895F9BE0-0x00000001895F9C00
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5FE2 */, bool useObjectPool = false /* Metadata: 0x00AF5FE6 */) => default; // 0x000000018450D030-0x000000018450D330
	// [XID] // 0x0000000189601340-0x0000000189601360
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5FE7 */, bool useObjectPool = false /* Metadata: 0x00AF5FEB */) => default; // 0x000000018450C040-0x000000018450C3C0
	// [XID] // 0x0000000189608D70-0x0000000189608D90
	public static new RejectAttackMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5FEC */, bool useObjectPool = false /* Metadata: 0x00AF5FF0 */) => default; // 0x000000018450C950-0x000000018450CB70
	[BlackList] // 0x0000000189610490-0x00000001896104D0
	// [XID] // 0x0000000189610490-0x00000001896104D0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018450B830-0x000000018450BB00
	// [XID] // 0x000000018961AAC0-0x000000018961AAE0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018450D990-0x000000018450DCB0
	[BlackList] // 0x00000001896220A0-0x00000001896220E0
	// [XID] // 0x00000001896220A0-0x00000001896220E0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018450CF40-0x000000018450D030
	// [XID] // 0x000000018962C6B0-0x000000018962C6D0
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x000000018450D330-0x000000018450D410
	[BlackList] // 0x000000018963BAC0-0x000000018963BB00
	// [XID] // 0x000000018963BAC0-0x000000018963BB00
	public override void AutoAllocTypeFields() {} // 0x000000018450BB00-0x000000018450BBA0
	[BlackList] // 0x00000001896460C0-0x0000000189646100
	// [XID] // 0x00000001896460C0-0x0000000189646100
	public override void AutoRecycleTypeFields() {} // 0x000000018450BBA0-0x000000018450BC90
	[BlackList] // 0x00000001896508B0-0x00000001896508F0
	// [XID] // 0x00000001896508B0-0x00000001896508F0
	public override void ReturnToObjectPool() {} // 0x000000018450DE80-0x000000018450DF20
}

