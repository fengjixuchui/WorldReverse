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
public class ClearGlobalPos : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16424
{
	// Fields
	private string _key; // 0x68
	private bool _setTarget; // 0x70

	// Properties
	public string key { /* [XID] */ /* 0x000000018987AA30-0x000000018987AA50 */ get => default; /* [XID] */ /* 0x0000000189881B00-0x0000000189881B20 */ private set {} } // 0x00000001821BBC20-0x00000001821BBCC0 0x00000001821BD4F0-0x00000001821BD5A0
	public bool setTarget { /* [XID] */ /* 0x00000001898891E0-0x0000000189889200 */ get => default; /* [XID] */ /* 0x0000000189890660-0x0000000189890680 */ private set {} } // 0x00000001821BD0C0-0x00000001821BD160 0x00000001821BC2D0-0x00000001821BC380
	protected override bool MuteAuthority { /* [XID] */ /* 0x000000018991C460-0x000000018991C480 */ get => default; } // 0x00000001821BD5A0-0x00000001821BD640 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189923B80-0x0000000189923BA0 */ get => default; } // 0x00000001821BCA80-0x00000001821BCB20 

	// Constructors
	public ClearGlobalPos() {} // 0x00000001821BDD40-0x00000001821BDDB0

	// Methods
	// [XID] // 0x0000000189897BC0-0x0000000189897BE0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001821BDAF0-0x00000001821BDC00
	// [XID] // 0x000000018989EFC0-0x000000018989EFE0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001821BD6A0-0x00000001821BD780
	// [XID] // 0x00000001898A6AC0-0x00000001898A6AE0
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3B0E */) => default; // 0x00000001821BD160-0x00000001821BD240
	// [XID] // 0x00000001898AE230-0x00000001898AE250
	public override int GetHashNum() => default; // 0x00000001821BBB50-0x00000001821BBC20
	// [XID] // 0x00000001898B5710-0x00000001898B5730
	public override void InitEmpty() {} // 0x00000001821BCB20-0x00000001821BCBF0
	[BlackList] // 0x00000001898BD1C0-0x00000001898BD200
	// [XID] // 0x00000001898BD1C0-0x00000001898BD200
	public override bool FromJson(JSONNode node) => default; // 0x00000001821BC400-0x00000001821BC780
	// [XID] // 0x00000001898C78C0-0x00000001898C78E0
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001821BB2B0-0x00000001821BB5A0
	[BlackList] // 0x00000001898CEFD0-0x00000001898CF010
	// [XID] // 0x00000001898CEFD0-0x00000001898CF010
	public static new ClearGlobalPos ParseFromJson(JSONNode node) => default; // 0x00000001821BD2A0-0x00000001821BD4F0
	// [XID] // 0x00000001898D97F0-0x00000001898D9810
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3B0F */, bool useObjectPool = false /* Metadata: 0x00AF3B13 */) => default; // 0x00000001821BCDC0-0x00000001821BD0C0
	// [XID] // 0x00000001898E15B0-0x00000001898E15D0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3B14 */, bool useObjectPool = false /* Metadata: 0x00AF3B18 */) => default; // 0x00000001821BBE10-0x00000001821BC0F0
	// [XID] // 0x00000001898E9000-0x00000001898E9020
	public static new ClearGlobalPos ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3B19 */, bool useObjectPool = false /* Metadata: 0x00AF3B1D */) => default; // 0x00000001821BC780-0x00000001821BC9A0
	[BlackList] // 0x00000001898F07C0-0x00000001898F0800
	// [XID] // 0x00000001898F07C0-0x00000001898F0800
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001821BB5A0-0x00000001821BB870
	// [XID] // 0x00000001898FADC0-0x00000001898FADE0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001821BD860-0x00000001821BDAF0
	[BlackList] // 0x0000000189902980-0x00000001899029C0
	// [XID] // 0x0000000189902980-0x00000001899029C0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001821BCCD0-0x00000001821BCDC0
	// [XID] // 0x000000018990D0F0-0x000000018990D110
	public override bool isAlreadyHandledRecoverCase() => default; // 0x00000001821BDC00-0x00000001821BDCA0
	// [XID] // 0x0000000189914840-0x0000000189914860
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x00000001821BC0F0-0x00000001821BC250
	[BlackList] // 0x000000018992B1E0-0x000000018992B220
	// [XID] // 0x000000018992B1E0-0x000000018992B220
	public override void AutoAllocTypeFields() {} // 0x00000001821BB870-0x00000001821BB910
	[BlackList] // 0x0000000189935590-0x00000001899355D0
	// [XID] // 0x0000000189935590-0x00000001899355D0
	public override void AutoRecycleTypeFields() {} // 0x00000001821BB910-0x00000001821BB9C0
	[BlackList] // 0x000000018993FEE0-0x000000018993FF20
	// [XID] // 0x000000018993FEE0-0x000000018993FF20
	public override void ReturnToObjectPool() {} // 0x00000001821BDCA0-0x00000001821BDD40
}

