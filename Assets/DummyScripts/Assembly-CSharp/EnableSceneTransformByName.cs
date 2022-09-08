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
public class EnableSceneTransformByName : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16565
{
	// Fields
	private string[] _transformNames; // 0x68
	private bool _setEnable; // 0x70

	// Properties
	public string[] transformNames { /* [XID] */ /* 0x0000000189801180-0x00000001898011A0 */ get => default; /* [XID] */ /* 0x0000000189808540-0x0000000189808560 */ private set {} } // 0x0000000184B3C710-0x0000000184B3C7B0 0x0000000184B3C580-0x0000000184B3C630
	public bool setEnable { /* [XID] */ /* 0x00000001898100F0-0x0000000189810110 */ get => default; /* [XID] */ /* 0x0000000189817700-0x0000000189817720 */ private set {} } // 0x0000000184B3BEA0-0x0000000184B3BF40 0x0000000184B3CD20-0x0000000184B3CDD0
	protected override bool MuteAuthority { /* [XID] */ /* 0x00000001898A0710-0x00000001898A0730 */ get => default; } // 0x0000000184B3CA60-0x0000000184B3CB00 
	protected override bool MuteRemote { /* [XID] */ /* 0x00000001898A7E50-0x00000001898A7E70 */ get => default; } // 0x0000000184B3BF40-0x0000000184B3BFE0 

	// Constructors
	public EnableSceneTransformByName() {} // 0x0000000184B3D2E0-0x0000000184B3D340

	// Methods
	// [XID] // 0x000000018981F020-0x000000018981F040
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184B3D090-0x0000000184B3D1A0
	// [XID] // 0x00000001898265B0-0x00000001898265D0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184B3CB60-0x0000000184B3CC40
	// [XID] // 0x000000018982DBE0-0x000000018982DC00
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3F5E */) => default; // 0x0000000184B3C630-0x0000000184B3C710
	// [XID] // 0x00000001898352D0-0x00000001898352F0
	public override int GetHashNum() => default; // 0x0000000184B3B0C0-0x0000000184B3B190
	// [XID] // 0x000000018983CA30-0x000000018983CA50
	public override void InitEmpty() {} // 0x0000000184B3BFE0-0x0000000184B3C0B0
	[BlackList] // 0x0000000189844160-0x00000001898441A0
	// [XID] // 0x0000000189844160-0x00000001898441A0
	public override bool FromJson(JSONNode node) => default; // 0x0000000184B3B820-0x0000000184B3BBA0
	// [XID] // 0x000000018984E580-0x000000018984E5A0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184B3A820-0x0000000184B3AB10
	[BlackList] // 0x0000000189855670-0x00000001898556B0
	// [XID] // 0x0000000189855670-0x00000001898556B0
	public static new EnableSceneTransformByName ParseFromJson(JSONNode node) => default; // 0x0000000184B3C810-0x0000000184B3CA60
	// [XID] // 0x000000018985F9F0-0x000000018985FA10
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3F5F */, bool useObjectPool = false /* Metadata: 0x00AF3F63 */) => default; // 0x0000000184B3C280-0x0000000184B3C580
	// [XID] // 0x00000001898671B0-0x00000001898671D0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3F64 */, bool useObjectPool = false /* Metadata: 0x00AF3F68 */) => default; // 0x0000000184B3B2E0-0x0000000184B3B5C0
	// [XID] // 0x000000018986E9D0-0x000000018986E9F0
	public static new EnableSceneTransformByName ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3F69 */, bool useObjectPool = false /* Metadata: 0x00AF3F6D */) => default; // 0x0000000184B3BBA0-0x0000000184B3BDC0
	[BlackList] // 0x0000000189875EA0-0x0000000189875EE0
	// [XID] // 0x0000000189875EA0-0x0000000189875EE0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184B3AB10-0x0000000184B3ADE0
	// [XID] // 0x0000000189880560-0x0000000189880580
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184B3CDD0-0x0000000184B3D090
	[BlackList] // 0x0000000189887A80-0x0000000189887AC0
	// [XID] // 0x0000000189887A80-0x0000000189887AC0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184B3C190-0x0000000184B3C280
	// [XID] // 0x0000000189891CA0-0x0000000189891CC0
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000184B3D1A0-0x0000000184B3D240
	// [XID] // 0x0000000189899550-0x0000000189899570
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000184B3B5C0-0x0000000184B3B720
	[BlackList] // 0x00000001898AF950-0x00000001898AF990
	// [XID] // 0x00000001898AF950-0x00000001898AF990
	public override void AutoAllocTypeFields() {} // 0x0000000184B3ADE0-0x0000000184B3AE80
	[BlackList] // 0x00000001898BA3C0-0x00000001898BA400
	// [XID] // 0x00000001898BA3C0-0x00000001898BA400
	public override void AutoRecycleTypeFields() {} // 0x0000000184B3AE80-0x0000000184B3AF30
	[BlackList] // 0x00000001898C48A0-0x00000001898C48E0
	// [XID] // 0x00000001898C48A0-0x00000001898C48E0
	public override void ReturnToObjectPool() {} // 0x0000000184B3D240-0x0000000184B3D2E0
}

