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
public class SetGlobalPos : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16420
{
	// Fields
	private string _key; // 0x68
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigBornType _born; // 0x70
	private bool _setTarget; // 0x78

	// Properties
	public string key { /* [XID] */ /* 0x00000001896A7C20-0x00000001896A7C40 */ get => default; /* [XID] */ /* 0x00000001896AF030-0x00000001896AF050 */ private set {} } // 0x0000000181AFAED0-0x0000000181AFAF70 0x0000000181AFC8E0-0x0000000181AFC990
	public ConfigBornType born { /* [XID] */ /* 0x00000001896B6600-0x00000001896B6620 */ get => default; /* [XID] */ /* 0x00000001896BD900-0x00000001896BD920 */ private set {} } // 0x0000000181AFAFE0-0x0000000181AFB080 0x0000000181AFD0F0-0x0000000181AFD1A0
	public bool setTarget { /* [XID] */ /* 0x00000001896C5090-0x00000001896C50B0 */ get => default; /* [XID] */ /* 0x00000001896CC690-0x00000001896CC6B0 */ private set {} } // 0x0000000181AFC4B0-0x0000000181AFC550 0x0000000181AFB6A0-0x0000000181AFB750
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189756EC0-0x0000000189756EE0 */ get => default; } // 0x0000000181AFC990-0x0000000181AFCA30 
	protected override bool MuteRemote { /* [XID] */ /* 0x000000018975E370-0x000000018975E390 */ get => default; } // 0x0000000181AFBE50-0x0000000181AFBEF0 

	// Constructors
	public SetGlobalPos() {} // 0x0000000181AFD2E0-0x0000000181AFD350

	// Methods
	// [XID] // 0x00000001896D3920-0x00000001896D3940
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181AFCFB0-0x0000000181AFD0F0
	// [XID] // 0x00000001896DB400-0x00000001896DB420
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000181AFCA90-0x0000000181AFCB90
	// [XID] // 0x00000001896E2AE0-0x00000001896E2B00
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3AEE */) => default; // 0x0000000181AFC550-0x0000000181AFC630
	// [XID] // 0x00000001896EA0A0-0x00000001896EA0C0
	public override int GetHashNum() => default; // 0x0000000181AFAE00-0x0000000181AFAED0
	// [XID] // 0x00000001896F1120-0x00000001896F1140
	public override void InitEmpty() {} // 0x0000000181AFBEF0-0x0000000181AFBFE0
	[BlackList] // 0x00000001896F8980-0x00000001896F89C0
	// [XID] // 0x00000001896F8980-0x00000001896F89C0
	public override bool FromJson(JSONNode node) => default; // 0x0000000181AFB7D0-0x0000000181AFBB50
	// [XID] // 0x00000001897033B0-0x00000001897033D0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000181AFA410-0x0000000181AFA7C0
	[BlackList] // 0x000000018970AA80-0x000000018970AAC0
	// [XID] // 0x000000018970AA80-0x000000018970AAC0
	public static new SetGlobalPos ParseFromJson(JSONNode node) => default; // 0x0000000181AFC690-0x0000000181AFC8E0
	// [XID] // 0x0000000189714F90-0x0000000189714FB0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3AEF */, bool useObjectPool = false /* Metadata: 0x00AF3AF3 */) => default; // 0x0000000181AFC1B0-0x0000000181AFC4B0
	// [XID] // 0x000000018971CA60-0x000000018971CA80
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3AF4 */, bool useObjectPool = false /* Metadata: 0x00AF3AF8 */) => default; // 0x0000000181AFB160-0x0000000181AFB4C0
	// [XID] // 0x0000000189723E50-0x0000000189723E70
	public static new SetGlobalPos ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3AF9 */, bool useObjectPool = false /* Metadata: 0x00AF3AFD */) => default; // 0x0000000181AFBB50-0x0000000181AFBD70
	[BlackList] // 0x000000018972B690-0x000000018972B6D0
	// [XID] // 0x000000018972B690-0x000000018972B6D0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000181AFA7C0-0x0000000181AFAA90
	// [XID] // 0x0000000189735E80-0x0000000189735EA0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181AFCC70-0x0000000181AFCFB0
	[BlackList] // 0x000000018973D9F0-0x000000018973DA30
	// [XID] // 0x000000018973D9F0-0x000000018973DA30
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000181AFC0C0-0x0000000181AFC1B0
	// [XID] // 0x0000000189748080-0x00000001897480A0
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000181AFD1A0-0x0000000181AFD240
	// [XID] // 0x000000018974F830-0x000000018974F850
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000181AFB4C0-0x0000000181AFB620
	[BlackList] // 0x0000000189765A10-0x0000000189765A50
	// [XID] // 0x0000000189765A10-0x0000000189765A50
	public override void AutoAllocTypeFields() {} // 0x0000000181AFAA90-0x0000000181AFAB30
	[BlackList] // 0x00000001897700B0-0x00000001897700F0
	// [XID] // 0x00000001897700B0-0x00000001897700F0
	public override void AutoRecycleTypeFields() {} // 0x0000000181AFAB30-0x0000000181AFAC70
	[BlackList] // 0x000000018977A720-0x000000018977A760
	// [XID] // 0x000000018977A720-0x000000018977A760
	public override void ReturnToObjectPool() {} // 0x0000000181AFD240-0x0000000181AFD2E0
}

