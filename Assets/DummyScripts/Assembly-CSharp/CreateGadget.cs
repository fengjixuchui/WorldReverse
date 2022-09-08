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
using MoleMole.Config;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class CreateGadget : CreateEntity, IAutoAllocRecycle // TypeDefIndex: 16499
{
	// Fields
	private SimpleSafeUInt32 gadgetIDRawNum; // 0x90
	private SimpleSafeUInt32 campIDRawNum; // 0x94
	private TargetType _campTargetType; // 0x98
	private bool _byServer; // 0x9C

	// Properties
	public uint gadgetID { /* [XID] */ /* 0x0000000189ACFD90-0x0000000189ACFDB0 */ get => default; /* [XID] */ /* 0x0000000189AD7BE0-0x0000000189AD7C00 */ private set {} } // 0x00000001842CD050-0x00000001842CD120 0x00000001842CC680-0x00000001842CC760
	public uint campID { /* [XID] */ /* 0x0000000189ADF670-0x0000000189ADF690 */ get => default; /* [XID] */ /* 0x0000000189AE6E70-0x0000000189AE6E90 */ private set {} } // 0x00000001842CC9B0-0x00000001842CCA80 0x00000001842CAF00-0x00000001842CAFE0
	public TargetType campTargetType { /* [XID] */ /* 0x0000000189AEE980-0x0000000189AEE9A0 */ get => default; /* [XID] */ /* 0x0000000189AF5F90-0x0000000189AF5FB0 */ private set {} } // 0x00000001842CCA80-0x00000001842CCB20 0x00000001842CD710-0x00000001842CD7C0
	public bool byServer { /* [XID] */ /* 0x0000000189AFD490-0x0000000189AFD4B0 */ get => default; /* [XID] */ /* 0x0000000189B04C80-0x0000000189B04CA0 */ private set {} } // 0x00000001842CBB20-0x00000001842CBBD0 0x00000001842CCD40-0x00000001842CCDF0
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189B96620-0x0000000189B96640 */ get => default; } // 0x00000001842CCB20-0x00000001842CCBC0 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189B9DAC0-0x0000000189B9DAE0 */ get => default; } // 0x00000001842CBED0-0x00000001842CBF70 
	protected override bool ForceForwardToServer { /* [XID] */ /* 0x0000000189BA54B0-0x0000000189BA54D0 */ get => default; } // 0x00000001842CAE60-0x00000001842CAF00 

	// Constructors
	public CreateGadget() {} // 0x00000001842CD860-0x00000001842CD8D0

	// Methods
	// [XID] // 0x0000000189B0C470-0x0000000189B0C490
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001842CD520-0x00000001842CD670
	// [XID] // 0x0000000189B13A10-0x0000000189B13A30
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001842CCC90-0x00000001842CCD40
	// [XID] // 0x0000000189B1B0A0-0x0000000189B1B0C0
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3D5A */) => default; // 0x00000001842CC540-0x00000001842CC620
	// [XID] // 0x0000000189B22810-0x0000000189B22830
	public override int GetHashNum() => default; // 0x00000001842CAD90-0x00000001842CAE60
	// [XID] // 0x0000000189B29D60-0x0000000189B29D80
	public override void InitEmpty() {} // 0x00000001842CBF70-0x00000001842CC060
	[BlackList] // 0x0000000189B31310-0x0000000189B31350
	// [XID] // 0x0000000189B31310-0x0000000189B31350
	public override bool FromJson(JSONNode node) => default; // 0x00000001842CB7A0-0x00000001842CBB20
	// [XID] // 0x0000000189B3B990-0x0000000189B3B9B0
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001842CA260-0x00000001842CA790
	[BlackList] // 0x0000000189B433F0-0x0000000189B43430
	// [XID] // 0x0000000189B433F0-0x0000000189B43430
	public static new CreateGadget ParseFromJson(JSONNode node) => default; // 0x00000001842CC760-0x00000001842CC9B0
	// [XID] // 0x0000000189B4DAA0-0x0000000189B4DAC0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3D5B */, bool useObjectPool = false /* Metadata: 0x00AF3D5F */) => default; // 0x00000001842CC240-0x00000001842CC540
	// [XID] // 0x0000000189B55310-0x0000000189B55330
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3D60 */, bool useObjectPool = false /* Metadata: 0x00AF3D64 */) => default; // 0x00000001842CB130-0x00000001842CB540
	// [XID] // 0x0000000189B5CCD0-0x0000000189B5CCF0
	public static new CreateGadget ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3D65 */, bool useObjectPool = false /* Metadata: 0x00AF3D69 */) => default; // 0x00000001842CBBD0-0x00000001842CBDF0
	[BlackList] // 0x0000000189B64310-0x0000000189B64350
	// [XID] // 0x0000000189B64310-0x0000000189B64350
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001842CA790-0x00000001842CAA60
	// [XID] // 0x0000000189B6E7E0-0x0000000189B6E800
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001842CD120-0x00000001842CD520
	[BlackList] // 0x0000000189B76070-0x0000000189B760B0
	// [XID] // 0x0000000189B76070-0x0000000189B760B0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001842CC140-0x00000001842CC240
	// [XID] // 0x0000000189B80450-0x0000000189B80470
	public override bool isAlreadyHandledRecoverCase() => default; // 0x00000001842CD670-0x00000001842CD710
	// [XID] // 0x0000000189B87F40-0x0000000189B87F60
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x00000001842CB540-0x00000001842CB6A0
	// [XID] // 0x0000000189B8F130-0x0000000189B8F150
	public override void CallAuthority(MPActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt, ref RecordInvokeEntryContext context) {} // 0x00000001842CCED0-0x00000001842CD050
	[BlackList] // 0x0000000189BAC650-0x0000000189BAC690
	// [XID] // 0x0000000189BAC650-0x0000000189BAC690
	public override void AutoAllocTypeFields() {} // 0x00000001842CAA60-0x00000001842CAB00
	[BlackList] // 0x0000000189BB6D70-0x0000000189BB6DB0
	// [XID] // 0x0000000189BB6D70-0x0000000189BB6DB0
	public override void AutoRecycleTypeFields() {} // 0x00000001842CAB00-0x00000001842CAC00
	[BlackList] // 0x0000000189BC1C10-0x0000000189BC1C50
	// [XID] // 0x0000000189BC1C10-0x0000000189BC1C50
	public override void ReturnToObjectPool() {} // 0x00000001842CD7C0-0x00000001842CD860
}

