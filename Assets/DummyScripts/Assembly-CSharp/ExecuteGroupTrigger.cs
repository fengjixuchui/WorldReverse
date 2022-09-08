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
public class ExecuteGroupTrigger : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16605
{
	// Fields
	private string _sourceName; // 0x68
	private SimpleSafeInt32 param1RawNum; // 0x70
	private SimpleSafeInt32 param2RawNum; // 0x74
	private SimpleSafeInt32 param3RawNum; // 0x78

	// Properties
	public string sourceName { /* [XID] */ /* 0x00000001897E1740-0x00000001897E1760 */ get => default; /* [XID] */ /* 0x00000001897E8F70-0x00000001897E8F90 */ private set {} } // 0x0000000184B56250-0x0000000184B562F0 0x0000000184B55FC0-0x0000000184B56070
	public int param1 { /* [XID] */ /* 0x00000001897F0B40-0x00000001897F0B60 */ get => default; /* [XID] */ /* 0x00000001897F8360-0x00000001897F8380 */ private set {} } // 0x0000000184B55AA0-0x0000000184B55B70 0x0000000184B56910-0x0000000184B569F0
	public int param2 { /* [XID] */ /* 0x00000001897FFA70-0x00000001897FFA90 */ get => default; /* [XID] */ /* 0x00000001898070F0-0x0000000189807110 */ private set {} } // 0x0000000184B569F0-0x0000000184B56AC0 0x0000000184B57890-0x0000000184B57970
	public int param3 { /* [XID] */ /* 0x000000018980E6F0-0x000000018980E710 */ get => default; /* [XID] */ /* 0x0000000189815E90-0x0000000189815EB0 */ private set {} } // 0x0000000184B55230-0x0000000184B55300 0x0000000184B577B0-0x0000000184B57890
	protected override bool MuteAuthority { /* [XID] */ /* 0x000000018989EF40-0x000000018989EF60 */ get => default; } // 0x0000000184B575D0-0x0000000184B57670 
	protected override bool MuteRemote { /* [XID] */ /* 0x00000001898A6A00-0x00000001898A6A20 */ get => default; } // 0x0000000184B56BA0-0x0000000184B56C40 

	// Constructors
	public ExecuteGroupTrigger() {} // 0x0000000184B58100-0x0000000184B581B0

	// Methods
	// [XID] // 0x000000018981D7D0-0x000000018981D7F0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184B57E70-0x0000000184B57FC0
	// [XID] // 0x0000000189824CA0-0x0000000189824CC0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184B576D0-0x0000000184B577B0
	// [XID] // 0x000000018982C650-0x000000018982C670
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF409A */) => default; // 0x0000000184B57240-0x0000000184B57320
	// [XID] // 0x0000000189833BE0-0x0000000189833C00
	public override int GetHashNum() => default; // 0x0000000184B55900-0x0000000184B559D0
	// [XID] // 0x000000018983B120-0x000000018983B140
	public override void InitEmpty() {} // 0x0000000184B56C40-0x0000000184B56D70
	[BlackList] // 0x00000001898429A0-0x00000001898429E0
	// [XID] // 0x00000001898429A0-0x00000001898429E0
	public override bool FromJson(JSONNode node) => default; // 0x0000000184B56370-0x0000000184B566F0
	// [XID] // 0x000000018984CCE0-0x000000018984CD00
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184B54D20-0x0000000184B55230
	[BlackList] // 0x0000000189853D60-0x0000000189853DA0
	// [XID] // 0x0000000189853D60-0x0000000189853DA0
	public static new ExecuteGroupTrigger ParseFromJson(JSONNode node) => default; // 0x0000000184B57380-0x0000000184B575D0
	// [XID] // 0x000000018985DF90-0x000000018985DFB0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF409B */, bool useObjectPool = false /* Metadata: 0x00AF409F */) => default; // 0x0000000184B56F40-0x0000000184B57240
	// [XID] // 0x0000000189865A10-0x0000000189865A30
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF40A0 */, bool useObjectPool = false /* Metadata: 0x00AF40A4 */) => default; // 0x0000000184B55BF0-0x0000000184B55FC0
	// [XID] // 0x000000018986CF30-0x000000018986CF50
	public static new ExecuteGroupTrigger ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF40A5 */, bool useObjectPool = false /* Metadata: 0x00AF40A9 */) => default; // 0x0000000184B566F0-0x0000000184B56910
	[BlackList] // 0x0000000189874320-0x0000000189874360
	// [XID] // 0x0000000189874320-0x0000000189874360
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184B55300-0x0000000184B555D0
	// [XID] // 0x000000018987EE20-0x000000018987EE40
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184B57A50-0x0000000184B57E70
	[BlackList] // 0x0000000189886400-0x0000000189886440
	// [XID] // 0x0000000189886400-0x0000000189886440
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184B56E50-0x0000000184B56F40
	// [XID] // 0x0000000189890620-0x0000000189890640
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000184B57FC0-0x0000000184B58060
	// [XID] // 0x0000000189897B40-0x0000000189897B60
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000184B56070-0x0000000184B561D0
	[BlackList] // 0x00000001898AE190-0x00000001898AE1D0
	// [XID] // 0x00000001898AE190-0x00000001898AE1D0
	public override void AutoAllocTypeFields() {} // 0x0000000184B555D0-0x0000000184B55670
	[BlackList] // 0x00000001898B8840-0x00000001898B8880
	// [XID] // 0x00000001898B8840-0x00000001898B8880
	public override void AutoRecycleTypeFields() {} // 0x0000000184B55670-0x0000000184B55770
	[BlackList] // 0x00000001898C2E40-0x00000001898C2E80
	// [XID] // 0x00000001898C2E40-0x00000001898C2E80
	public override void ReturnToObjectPool() {} // 0x0000000184B58060-0x0000000184B58100
}

