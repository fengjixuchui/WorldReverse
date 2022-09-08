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
public class GetPos : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16434
{
	// Fields
	private string _key; // 0x68
	private GetPosType _posType; // 0x70

	// Properties
	public string key { /* [XID] */ /* 0x00000001895EC6F0-0x00000001895EC710 */ get => default; /* [XID] */ /* 0x00000001895F3BB0-0x00000001895F3BD0 */ private set {} } // 0x0000000183191570-0x0000000183191610 0x0000000183192D90-0x0000000183192E40
	public GetPosType posType { /* [XID] */ /* 0x00000001895FB470-0x00000001895FB490 */ get => default; /* [XID] */ /* 0x0000000189602BF0-0x0000000189602C10 */ private set {} } // 0x0000000183191C20-0x0000000183191CC0 0x0000000183191260-0x0000000183191310
	protected override bool MuteAuthority { /* [XID] */ /* 0x000000018968EB10-0x000000018968EB30 */ get => default; } // 0x0000000183192E40-0x0000000183192EE0 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189696590-0x00000001896965B0 */ get => default; } // 0x00000001831923C0-0x0000000183192460 

	// Constructors
	public GetPos() {} // 0x00000001831935E0-0x0000000183193640

	// Methods
	// [XID] // 0x000000018960A530-0x000000018960A550
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183193390-0x00000001831934A0
	// [XID] // 0x0000000189611CA0-0x0000000189611CC0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183192F40-0x0000000183193020
	// [XID] // 0x00000001896195A0-0x00000001896195C0
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3B52 */) => default; // 0x0000000183192A00-0x0000000183192AE0
	// [XID] // 0x0000000189620B40-0x0000000189620B60
	public override int GetHashNum() => default; // 0x00000001831914A0-0x0000000183191570
	// [XID] // 0x0000000189628150-0x0000000189628170
	public override void InitEmpty() {} // 0x0000000183192460-0x0000000183192530
	[BlackList] // 0x000000018962F960-0x000000018962F9A0
	// [XID] // 0x000000018962F960-0x000000018962F9A0
	public override bool FromJson(JSONNode node) => default; // 0x0000000183191D40-0x00000001831920C0
	// [XID] // 0x000000018963A490-0x000000018963A4B0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183190B30-0x0000000183190E40
	[BlackList] // 0x0000000189641A00-0x0000000189641A40
	// [XID] // 0x0000000189641A00-0x0000000189641A40
	public static new GetPos ParseFromJson(JSONNode node) => default; // 0x0000000183192B40-0x0000000183192D90
	// [XID] // 0x000000018964C390-0x000000018964C3B0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3B53 */, bool useObjectPool = false /* Metadata: 0x00AF3B57 */) => default; // 0x0000000183192700-0x0000000183192A00
	// [XID] // 0x0000000189653A00-0x0000000189653A20
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3B58 */, bool useObjectPool = false /* Metadata: 0x00AF3B5C */) => default; // 0x0000000183191760-0x0000000183191A40
	// [XID] // 0x000000018965B2B0-0x000000018965B2D0
	public static new GetPos ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3B5D */, bool useObjectPool = false /* Metadata: 0x00AF3B61 */) => default; // 0x00000001831920C0-0x00000001831922E0
	[BlackList] // 0x0000000189662760-0x00000001896627A0
	// [XID] // 0x0000000189662760-0x00000001896627A0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000183190E40-0x0000000183191110
	// [XID] // 0x000000018966CEC0-0x000000018966CEE0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183193100-0x0000000183193390
	[BlackList] // 0x0000000189674D10-0x0000000189674D50
	// [XID] // 0x0000000189674D10-0x0000000189674D50
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183192610-0x0000000183192700
	// [XID] // 0x000000018967F3E0-0x000000018967F400
	public override bool isAlreadyHandledRecoverCase() => default; // 0x00000001831934A0-0x0000000183193540
	// [XID] // 0x0000000189686C50-0x0000000189686C70
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000183191A40-0x0000000183191BA0
	[BlackList] // 0x000000018969DAD0-0x000000018969DB10
	// [XID] // 0x000000018969DAD0-0x000000018969DB10
	public override void AutoAllocTypeFields() {} // 0x0000000183191110-0x00000001831911B0
	[BlackList] // 0x00000001896A7BE0-0x00000001896A7C20
	// [XID] // 0x00000001896A7BE0-0x00000001896A7C20
	public override void AutoRecycleTypeFields() {} // 0x00000001831911B0-0x0000000183191260
	[BlackList] // 0x00000001896B1A70-0x00000001896B1AB0
	// [XID] // 0x00000001896B1A70-0x00000001896B1AB0
	public override void ReturnToObjectPool() {} // 0x0000000183193540-0x00000001831935E0
}

