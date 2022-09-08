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
public class SetAnimatorBool : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16476
{
	// Fields
	private string _boolID; // 0x68
	private bool _value; // 0x70
	private bool _persistent; // 0x71

	// Properties
	public string boolID { /* [XID] */ /* 0x0000000189BB6DD0-0x0000000189BB6DF0 */ get => default; /* [XID] */ /* 0x0000000189BBE3B0-0x0000000189BBE3D0 */ private set {} } // 0x0000000181C6EC80-0x0000000181C6ED20 0x0000000181C6E550-0x0000000181C6E600
	public bool value { /* [XID] */ /* 0x0000000189BC60A0-0x0000000189BC60C0 */ get => default; /* [XID] */ /* 0x0000000189BCDC00-0x0000000189BCDC20 */ private set {} } // 0x0000000181C6DCE0-0x0000000181C6DD80 0x0000000181C6DBB0-0x0000000181C6DC60
	public bool persistent { /* [XID] */ /* 0x0000000189BD5110-0x0000000189BD5130 */ get => default; /* [XID] */ /* 0x0000000189BDCC40-0x0000000189BDCC60 */ private set {} } // 0x0000000181C6ED80-0x0000000181C6EE20 0x0000000181C6D480-0x0000000181C6D530
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189674CF0-0x0000000189674D10 */ get => default; } // 0x0000000181C6F070-0x0000000181C6F110 
	protected override bool MuteRemote { /* [XID] */ /* 0x000000018967C580-0x000000018967C5A0 */ get => default; } // 0x0000000181C6E4B0-0x0000000181C6E550 

	// Constructors
	public SetAnimatorBool() {} // 0x0000000181C6FBB0-0x0000000181C6FC10

	// Methods
	// [XID] // 0x00000001895E93F0-0x00000001895E9410
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181C6F940-0x0000000181C6FA70
	// [XID] // 0x00000001895F0C00-0x00000001895F0C20
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000181C6F170-0x0000000181C6F250
	// [XID] // 0x00000001895F85D0-0x00000001895F85F0
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3CA0 */) => default; // 0x0000000181C6EBA0-0x0000000181C6EC80
	// [XID] // 0x00000001895FFA90-0x00000001895FFAB0
	public override int GetHashNum() => default; // 0x0000000181C6D3B0-0x0000000181C6D480
	// [XID] // 0x0000000189607240-0x0000000189607260
	public override void InitEmpty() {} // 0x0000000181C6E600-0x0000000181C6E6D0
	[BlackList] // 0x000000018960EC60-0x000000018960ECA0
	// [XID] // 0x000000018960EC60-0x000000018960ECA0
	public override bool FromJson(JSONNode node) => default; // 0x0000000181C6DD80-0x0000000181C6E100
	// [XID] // 0x0000000189619580-0x00000001896195A0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000181C6CA50-0x0000000181C6CE00
	[BlackList] // 0x0000000189620AE0-0x0000000189620B20
	// [XID] // 0x0000000189620AE0-0x0000000189620B20
	public static new SetAnimatorBool ParseFromJson(JSONNode node) => default; // 0x0000000181C6EE20-0x0000000181C6F070
	// [XID] // 0x000000018962B1C0-0x000000018962B1E0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3CA1 */, bool useObjectPool = false /* Metadata: 0x00AF3CA5 */) => default; // 0x0000000181C6E8A0-0x0000000181C6EBA0
	// [XID] // 0x0000000189632960-0x0000000189632980
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3CA6 */, bool useObjectPool = false /* Metadata: 0x00AF3CAA */) => default; // 0x0000000181C6D680-0x0000000181C6D9D0
	// [XID] // 0x000000018963A450-0x000000018963A470
	public static new SetAnimatorBool ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3CAB */, bool useObjectPool = false /* Metadata: 0x00AF3CAF */) => default; // 0x0000000181C6E1B0-0x0000000181C6E3D0
	[BlackList] // 0x0000000189641960-0x00000001896419A0
	// [XID] // 0x0000000189641960-0x00000001896419A0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000181C6CE00-0x0000000181C6D0D0
	// [XID] // 0x000000018964C330-0x000000018964C350
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181C6F330-0x0000000181C6F640
	[BlackList] // 0x00000001896539A0-0x00000001896539E0
	// [XID] // 0x00000001896539A0-0x00000001896539E0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000181C6E7B0-0x0000000181C6E8A0
	// [XID] // 0x000000018965E030-0x000000018965E050
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000181C6FA70-0x0000000181C6FB10
	// [XID] // 0x0000000189665770-0x0000000189665790
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000181C6D9D0-0x0000000181C6DB30
	// [XID] // 0x000000018966CEA0-0x000000018966CEC0
	public override bool GetDebugOutput(ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt, ref string output) => default; // 0x0000000181C6F640-0x0000000181C6F940
	[BlackList] // 0x0000000189683C10-0x0000000189683C50
	// [XID] // 0x0000000189683C10-0x0000000189683C50
	public override void AutoAllocTypeFields() {} // 0x0000000181C6D0D0-0x0000000181C6D170
	[BlackList] // 0x000000018968EAB0-0x000000018968EAF0
	// [XID] // 0x000000018968EAB0-0x000000018968EAF0
	public override void AutoRecycleTypeFields() {} // 0x0000000181C6D170-0x0000000181C6D220
	[BlackList] // 0x00000001896991A0-0x00000001896991E0
	// [XID] // 0x00000001896991A0-0x00000001896991E0
	public override void ReturnToObjectPool() {} // 0x0000000181C6FB10-0x0000000181C6FBB0
}

