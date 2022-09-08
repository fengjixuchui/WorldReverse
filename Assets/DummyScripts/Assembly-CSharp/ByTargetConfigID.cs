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
public class ByTargetConfigID : ConfigAbilityPredicate, IAutoAllocRecycle // TypeDefIndex: 17332
{
	// Fields
	private SimpleSafeUInt32[] _configIdArray; // 0x18

	// Properties
	public SimpleSafeUInt32[] configIdArray { /* [XID] */ /* 0x00000001896F4460-0x00000001896F4480 */ get => default; /* [XID] */ /* 0x00000001896FBCD0-0x00000001896FBCF0 */ private set {} } // 0x0000000183567160-0x0000000183567200 0x0000000183566D60-0x0000000183566E10

	// Constructors
	public ByTargetConfigID() {} // 0x0000000183568930-0x0000000183568990

	// Methods
	// [XID] // 0x0000000189703210-0x0000000189703230
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001835687A0-0x0000000183568890
	// [XID] // 0x000000018970A920-0x000000018970A940
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001835683D0-0x00000001835684B0
	// [XID] // 0x00000001897123D0-0x00000001897123F0
	public override ConfigAbilityPredicate Clone(bool useObjectPool = false /* Metadata: 0x00AF6ABF */) => default; // 0x0000000183567FE0-0x00000001835680C0
	// [XID] // 0x0000000189719A70-0x0000000189719A90
	public override int GetHashNum() => default; // 0x0000000183566C90-0x0000000183566D60
	// [XID] // 0x0000000189720F90-0x0000000189720FB0
	public override void InitEmpty() {} // 0x0000000183567A40-0x0000000183567B10
	[BlackList] // 0x0000000189728670-0x00000001897286B0
	// [XID] // 0x0000000189728670-0x00000001897286B0
	public override bool FromJson(JSONNode node) => default; // 0x0000000183567430-0x00000001835677B0
	// [XID] // 0x0000000189732C80-0x0000000189732CA0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183566520-0x0000000183566750
	[BlackList] // 0x000000018973A350-0x000000018973A390
	// [XID] // 0x000000018973A350-0x000000018973A390
	public static new ByTargetConfigID ParseFromJson(JSONNode node) => default; // 0x0000000183568120-0x0000000183568370
	// [XID] // 0x0000000189744C30-0x0000000189744C50
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6AC0 */, bool useObjectPool = false /* Metadata: 0x00AF6AC4 */) => default; // 0x0000000183567CE0-0x0000000183567FE0
	// [XID] // 0x000000018974C880-0x000000018974C8A0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6AC5 */, bool useObjectPool = false /* Metadata: 0x00AF6AC9 */) => default; // 0x0000000183566EF0-0x0000000183567160
	// [XID] // 0x0000000189753BC0-0x0000000189753BE0
	public static new ByTargetConfigID ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6ACA */, bool useObjectPool = false /* Metadata: 0x00AF6ACE */) => default; // 0x00000001835677B0-0x00000001835679D0
	[BlackList] // 0x000000018975B100-0x000000018975B140
	// [XID] // 0x000000018975B100-0x000000018975B140
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000183566750-0x0000000183566A20
	// [XID] // 0x0000000189765830-0x0000000189765850
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183568560-0x00000001835687A0
	[BlackList] // 0x000000018976D080-0x000000018976D0C0
	// [XID] // 0x000000018976D080-0x000000018976D0C0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183567BF0-0x0000000183567CE0
	// [XID] // 0x0000000189777690-0x00000001897776B0
	public override bool Call(ActorAbilityPlugin abilityPlugin, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000183567200-0x0000000183567330
	[BlackList] // 0x000000018977ED80-0x000000018977EDC0
	// [XID] // 0x000000018977ED80-0x000000018977EDC0
	public override void AutoAllocTypeFields() {} // 0x0000000183566A20-0x0000000183566AC0
	[BlackList] // 0x00000001897894C0-0x0000000189789500
	// [XID] // 0x00000001897894C0-0x0000000189789500
	public override void AutoRecycleTypeFields() {} // 0x0000000183566AC0-0x0000000183566B70
	[BlackList] // 0x0000000189793AC0-0x0000000189793B00
	// [XID] // 0x0000000189793AC0-0x0000000189793B00
	public override void ReturnToObjectPool() {} // 0x0000000183568890-0x0000000183568930
}

