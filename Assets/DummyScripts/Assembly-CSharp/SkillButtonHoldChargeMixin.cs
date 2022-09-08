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
public class SkillButtonHoldChargeMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 16904
{
	// Fields
	private bool _allowHoldLockDirection; // 0x30
	private SimpleSafeUInt32 skillIDRawNum; // 0x34
	private string _nextLoopTriggerID; // 0x38
	private string _endHoldTrigger; // 0x40
	private string[] _beforeStateIDs; // 0x48
	private SimpleSafeFloat beforeHoldDurationRawNum; // 0x50
	private string[] _chargeLoopStateIDs; // 0x58
	private string[] _afterStateIDs; // 0x60
	private SimpleSafeFloat[] _chargeLoopDurations; // 0x68
	private string[] _transientStateIDs; // 0x70

	// Properties
	public bool allowHoldLockDirection { /* [XID] */ /* 0x0000000189AC4080-0x0000000189AC40A0 */ get => default; /* [XID] */ /* 0x0000000189ACB5D0-0x0000000189ACB5F0 */ private set {} } // 0x0000000181113890-0x0000000181113930 0x0000000181113B10-0x0000000181113BC0
	public uint skillID { /* [XID] */ /* 0x0000000189AD3040-0x0000000189AD3060 */ get => default; /* [XID] */ /* 0x0000000189ADAA80-0x0000000189ADAAA0 */ private set {} } // 0x0000000181115170-0x0000000181115240 0x0000000181116910-0x00000001811169F0
	public string nextLoopTriggerID { /* [XID] */ /* 0x0000000189AE2220-0x0000000189AE2240 */ get => default; /* [XID] */ /* 0x0000000189AE9B70-0x0000000189AE9B90 */ private set {} } // 0x0000000181114730-0x00000001811147D0 0x0000000181113780-0x0000000181113830
	public string endHoldTrigger { /* [XID] */ /* 0x0000000189AF1910-0x0000000189AF1930 */ get => default; /* [XID] */ /* 0x0000000189AF9050-0x0000000189AF9070 */ private set {} } // 0x0000000181116870-0x0000000181116910 0x00000001811139E0-0x0000000181113A90
	public string[] beforeStateIDs { /* [XID] */ /* 0x0000000189B00610-0x0000000189B00630 */ get => default; /* [XID] */ /* 0x0000000189B07A90-0x0000000189B07AB0 */ private set {} } // 0x0000000181116BE0-0x0000000181116C80 0x0000000181115240-0x00000001811152F0
	public float beforeHoldDuration { /* [XID] */ /* 0x0000000189B0F370-0x0000000189B0F390 */ get => default; /* [XID] */ /* 0x0000000189B16690-0x0000000189B166B0 */ private set {} } // 0x0000000181114450-0x0000000181114530 0x0000000181114650-0x0000000181114730
	public string[] chargeLoopStateIDs { /* [XID] */ /* 0x0000000189B1DD50-0x0000000189B1DD70 */ get => default; /* [XID] */ /* 0x0000000189B25580-0x0000000189B255A0 */ private set {} } // 0x0000000181114B50-0x0000000181114BF0 0x00000001811136D0-0x0000000181113780
	public string[] afterStateIDs { /* [XID] */ /* 0x0000000189B2CAD0-0x0000000189B2CAF0 */ get => default; /* [XID] */ /* 0x0000000189B33F60-0x0000000189B33F80 */ private set {} } // 0x00000001811134E0-0x0000000181113580 0x0000000181115B30-0x0000000181115BE0
	public SimpleSafeFloat[] chargeLoopDurations { /* [XID] */ /* 0x0000000189B3B850-0x0000000189B3B870 */ get => default; /* [XID] */ /* 0x0000000189B43290-0x0000000189B432B0 */ private set {} } // 0x0000000181114D00-0x0000000181114DA0 0x0000000181113930-0x00000001811139E0
	public string[] transientStateIDs { /* [XID] */ /* 0x0000000189B4AB10-0x0000000189B4AB30 */ get => default; /* [XID] */ /* 0x0000000189B52160-0x0000000189B52180 */ private set {} } // 0x0000000181114BF0-0x0000000181114C90 0x0000000181115050-0x0000000181115100
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x0000000189BD4FD0-0x0000000189BD4FF0 */ get => default; } // 0x00000001811145B0-0x0000000181114650 

	// Constructors
	public SkillButtonHoldChargeMixin() {} // 0x0000000181116D20-0x0000000181116DC0

	// Methods
	// [XID] // 0x0000000189B59B00-0x0000000189B59B20
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001811169F0-0x0000000181116BE0
	// [XID] // 0x0000000189B61270-0x0000000189B61290
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000181115EF0-0x0000000181116080
	// [XID] // 0x0000000189B68B40-0x0000000189B68B60
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF5D19 */) => default; // 0x0000000181115A50-0x0000000181115B30
	// [XID] // 0x0000000189B70160-0x0000000189B70180
	public override int GetHashNum() => default; // 0x0000000181113600-0x00000001811136D0
	// [XID] // 0x0000000189B77570-0x0000000189B77590
	public override void InitEmpty() {} // 0x00000001811152F0-0x00000001811154A0
	[BlackList] // 0x0000000189B7EB20-0x0000000189B7EB60
	// [XID] // 0x0000000189B7EB20-0x0000000189B7EB60
	public override bool FromJson(JSONNode node) => default; // 0x00000001811147D0-0x0000000181114B50
	// [XID] // 0x0000000189B894D0-0x0000000189B894F0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000181112580-0x0000000181112FA0
	[BlackList] // 0x0000000189B90A90-0x0000000189B90AD0
	// [XID] // 0x0000000189B90A90-0x0000000189B90AD0
	public static new SkillButtonHoldChargeMixin ParseFromJson(JSONNode node) => default; // 0x0000000181115C40-0x0000000181115E90
	// [XID] // 0x0000000189B9AD20-0x0000000189B9AD40
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5D1A */, bool useObjectPool = false /* Metadata: 0x00AF5D1E */) => default; // 0x0000000181115670-0x0000000181115970
	// [XID] // 0x0000000189BA25D0-0x0000000189BA25F0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5D1F */, bool useObjectPool = false /* Metadata: 0x00AF5D23 */) => default; // 0x0000000181113BC0-0x00000001811143D0
	// [XID] // 0x0000000189BA9A80-0x0000000189BA9AA0
	public static new SkillButtonHoldChargeMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5D24 */, bool useObjectPool = false /* Metadata: 0x00AF5D28 */) => default; // 0x0000000181114DA0-0x0000000181114FC0
	[BlackList] // 0x0000000189BB1290-0x0000000189BB12D0
	// [XID] // 0x0000000189BB1290-0x0000000189BB12D0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000181112FA0-0x0000000181113270
	// [XID] // 0x0000000189BBB470-0x0000000189BBB490
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181116080-0x0000000181116870
	[BlackList] // 0x0000000189BC3310-0x0000000189BC3350
	// [XID] // 0x0000000189BC3310-0x0000000189BC3350
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000181115580-0x0000000181115670
	// [XID] // 0x0000000189BCDAC0-0x0000000189BCDAE0
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x0000000181115970-0x0000000181115A50
	[BlackList] // 0x0000000189BDCB20-0x0000000189BDCB60
	// [XID] // 0x0000000189BDCB20-0x0000000189BDCB60
	public override void AutoAllocTypeFields() {} // 0x0000000181113270-0x0000000181113310
	[BlackList] // 0x00000001895EC5B0-0x00000001895EC5F0
	// [XID] // 0x00000001895EC5B0-0x00000001895EC5F0
	public override void AutoRecycleTypeFields() {} // 0x0000000181113310-0x0000000181113440
	[BlackList] // 0x00000001895F6E40-0x00000001895F6E80
	// [XID] // 0x00000001895F6E40-0x00000001895F6E80
	public override void ReturnToObjectPool() {} // 0x0000000181116C80-0x0000000181116D20
}

