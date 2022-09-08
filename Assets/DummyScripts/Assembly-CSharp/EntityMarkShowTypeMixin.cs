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
public class EntityMarkShowTypeMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 17153
{
	// Fields
	private EntityMarkType _markType; // 0x30

	// Properties
	public EntityMarkType markType { /* [XID] */ /* 0x00000001898E4320-0x00000001898E4340 */ get => default; /* [XID] */ /* 0x00000001898EBD30-0x00000001898EBD50 */ private set {} } // 0x0000000183402DD0-0x0000000183402E70 0x00000001834028D0-0x0000000183402980
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x000000018996F700-0x000000018996F720 */ get => default; } // 0x0000000183402D30-0x0000000183402DD0 

	// Constructors
	public EntityMarkShowTypeMixin() {} // 0x0000000183404400-0x0000000183404460

	// Methods
	// [XID] // 0x00000001898F3600-0x00000001898F3620
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183404270-0x0000000183404360
	// [XID] // 0x00000001898FABA0-0x00000001898FABC0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183403FC0-0x0000000183404070
	// [XID] // 0x0000000189902780-0x00000001899027A0
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF64D9 */) => default; // 0x0000000183403BD0-0x0000000183403CB0
	// [XID] // 0x0000000189909D80-0x0000000189909DA0
	public override int GetHashNum() => default; // 0x00000001834027A0-0x0000000183402870
	// [XID] // 0x00000001899115E0-0x0000000189911600
	public override void InitEmpty() {} // 0x0000000183403580-0x0000000183403620
	[BlackList] // 0x0000000189919180-0x00000001899191C0
	// [XID] // 0x0000000189919180-0x00000001899191C0
	public override bool FromJson(JSONNode node) => default; // 0x0000000183402E70-0x00000001834031F0
	// [XID] // 0x0000000189923980-0x00000001899239A0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183402040-0x0000000183402260
	[BlackList] // 0x000000018992AFA0-0x000000018992AFE0
	// [XID] // 0x000000018992AFA0-0x000000018992AFE0
	public static new EntityMarkShowTypeMixin ParseFromJson(JSONNode node) => default; // 0x0000000183403D10-0x0000000183403F60
	// [XID] // 0x0000000189935390-0x00000001899353B0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF64DA */, bool useObjectPool = false /* Metadata: 0x00AF64DE */) => default; // 0x00000001834037F0-0x0000000183403AF0
	// [XID] // 0x000000018993CF50-0x000000018993CF70
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF64DF */, bool useObjectPool = false /* Metadata: 0x00AF64E3 */) => default; // 0x0000000183402A00-0x0000000183402C30
	// [XID] // 0x0000000189944560-0x0000000189944580
	public static new EntityMarkShowTypeMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF64E4 */, bool useObjectPool = false /* Metadata: 0x00AF64E8 */) => default; // 0x0000000183403260-0x0000000183403480
	[BlackList] // 0x000000018994BB20-0x000000018994BB60
	// [XID] // 0x000000018994BB20-0x000000018994BB60
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000183402260-0x0000000183402530
	// [XID] // 0x00000001899560A0-0x00000001899560C0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183404070-0x0000000183404270
	[BlackList] // 0x000000018995DB90-0x000000018995DBD0
	// [XID] // 0x000000018995DB90-0x000000018995DBD0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183403700-0x00000001834037F0
	// [XID] // 0x00000001899682A0-0x00000001899682C0
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x0000000183403AF0-0x0000000183403BD0
	[BlackList] // 0x00000001899773A0-0x00000001899773E0
	// [XID] // 0x00000001899773A0-0x00000001899773E0
	public override void AutoAllocTypeFields() {} // 0x0000000183402530-0x00000001834025D0
	[BlackList] // 0x0000000189981DC0-0x0000000189981E00
	// [XID] // 0x0000000189981DC0-0x0000000189981E00
	public override void AutoRecycleTypeFields() {} // 0x00000001834025D0-0x0000000183402680
	[BlackList] // 0x000000018998C470-0x000000018998C4B0
	// [XID] // 0x000000018998C470-0x000000018998C4B0
	public override void ReturnToObjectPool() {} // 0x0000000183404360-0x0000000183404400
}

