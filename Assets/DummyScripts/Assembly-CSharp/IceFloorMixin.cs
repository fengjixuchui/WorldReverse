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
public class IceFloorMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 17012
{
	// Fields
	private SimpleSafeFloat widthRawNum; // 0x30
	private SimpleSafeFloat heightRawNum; // 0x34
	private SimpleSafeFloat moveDistanceRawNum; // 0x38
	private SimpleSafeFloat minIntervalRawNum; // 0x3C
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAbilityAction _doAction; // 0x40

	// Properties
	public float width { /* [XID] */ /* 0x0000000189662660-0x0000000189662680 */ get => default; /* [XID] */ /* 0x000000018966A220-0x000000018966A240 */ private set {} } // 0x00000001835D88C0-0x00000001835D89A0 0x00000001835D75D0-0x00000001835D76B0
	public float height { /* [XID] */ /* 0x0000000189671E40-0x0000000189671E60 */ get => default; /* [XID] */ /* 0x0000000189679630-0x0000000189679650 */ private set {} } // 0x00000001835D99C0-0x00000001835D9AA0 0x00000001835D9340-0x00000001835D9420
	public float moveDistance { /* [XID] */ /* 0x0000000189680D80-0x0000000189680DA0 */ get => default; /* [XID] */ /* 0x00000001896887A0-0x00000001896887C0 */ private set {} } // 0x00000001835D7BB0-0x00000001835D7C90 0x00000001835D8560-0x00000001835D8640
	public float minInterval { /* [XID] */ /* 0x0000000189690160-0x0000000189690180 */ get => default; /* [XID] */ /* 0x0000000189697B20-0x0000000189697B40 */ private set {} } // 0x00000001835D66A0-0x00000001835D6780 0x00000001835D8FB0-0x00000001835D9090
	public ConfigAbilityAction doAction { /* [XID] */ /* 0x000000018969EE90-0x000000018969EEB0 */ get => default; /* [XID] */ /* 0x00000001896A6330-0x00000001896A6350 */ private set {} } // 0x00000001835D84C0-0x00000001835D8560 0x00000001835D8640-0x00000001835D86F0
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x0000000189728710-0x0000000189728730 */ get => default; } // 0x00000001835D7D10-0x00000001835D7DB0 

	// Constructors
	public IceFloorMixin() {} // 0x00000001835D9CC0-0x00000001835D9D70

	// Methods
	// [XID] // 0x00000001896AD890-0x00000001896AD8B0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001835D9AA0-0x00000001835D9C20
	// [XID] // 0x00000001896B4F70-0x00000001896B4F90
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001835D9480-0x00000001835D9560
	// [XID] // 0x00000001896BC260-0x00000001896BC280
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF605D */) => default; // 0x00000001835D8ED0-0x00000001835D8FB0
	// [XID] // 0x00000001896C3660-0x00000001896C3680
	public override int GetHashNum() => default; // 0x00000001835D7420-0x00000001835D74F0
	// [XID] // 0x00000001896CAC10-0x00000001896CAC30
	public override void InitEmpty() {} // 0x00000001835D86F0-0x00000001835D8840
	[BlackList] // 0x00000001896D22A0-0x00000001896D22E0
	// [XID] // 0x00000001896D22A0-0x00000001896D22E0
	public override bool FromJson(JSONNode node) => default; // 0x00000001835D7DB0-0x00000001835D8130
	// [XID] // 0x00000001896DC8E0-0x00000001896DC900
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001835D6780-0x00000001835D6DF0
	[BlackList] // 0x00000001896E42B0-0x00000001896E42F0
	// [XID] // 0x00000001896E42B0-0x00000001896E42F0
	public static new IceFloorMixin ParseFromJson(JSONNode node) => default; // 0x00000001835D90F0-0x00000001835D9340
	// [XID] // 0x00000001896EE490-0x00000001896EE4B0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF605E */, bool useObjectPool = false /* Metadata: 0x00AF6062 */) => default; // 0x00000001835D8AF0-0x00000001835D8DF0
	// [XID] // 0x00000001896F5D80-0x00000001896F5DA0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6063 */, bool useObjectPool = false /* Metadata: 0x00AF6067 */) => default; // 0x00000001835D76B0-0x00000001835D7B30
	// [XID] // 0x00000001896FD590-0x00000001896FD5B0
	public static new IceFloorMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6068 */, bool useObjectPool = false /* Metadata: 0x00AF606C */) => default; // 0x00000001835D81A0-0x00000001835D83C0
	[BlackList] // 0x00000001897049B0-0x00000001897049F0
	// [XID] // 0x00000001897049B0-0x00000001897049F0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001835D6DF0-0x00000001835D70C0
	// [XID] // 0x000000018970F400-0x000000018970F420
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001835D9560-0x00000001835D99C0
	[BlackList] // 0x0000000189716720-0x0000000189716760
	// [XID] // 0x0000000189716720-0x0000000189716760
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001835D8A00-0x00000001835D8AF0
	// [XID] // 0x00000001897210B0-0x00000001897210D0
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x00000001835D8DF0-0x00000001835D8ED0
	[BlackList] // 0x000000018972FE60-0x000000018972FEA0
	// [XID] // 0x000000018972FE60-0x000000018972FEA0
	public override void AutoAllocTypeFields() {} // 0x00000001835D70C0-0x00000001835D7160
	[BlackList] // 0x000000018973A410-0x000000018973A450
	// [XID] // 0x000000018973A410-0x000000018973A450
	public override void AutoRecycleTypeFields() {} // 0x00000001835D7160-0x00000001835D7300
	[BlackList] // 0x0000000189744CD0-0x0000000189744D10
	// [XID] // 0x0000000189744CD0-0x0000000189744D10
	public override void ReturnToObjectPool() {} // 0x00000001835D9C20-0x00000001835D9CC0
}

