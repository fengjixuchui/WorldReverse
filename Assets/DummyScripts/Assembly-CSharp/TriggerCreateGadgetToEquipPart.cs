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
public class TriggerCreateGadgetToEquipPart : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16517
{
	// Fields
	private SimpleSafeUInt32 gadgetIDRawNum; // 0x68
	private string _equipPart; // 0x70

	// Properties
	public uint gadgetID { /* [XID] */ /* 0x00000001896B7F10-0x00000001896B7F30 */ get => default; /* [XID] */ /* 0x00000001896BEF70-0x00000001896BEF90 */ private set {} } // 0x0000000182AC85D0-0x0000000182AC86A0 0x0000000182AC7F70-0x0000000182AC8050
	public string equipPart { /* [XID] */ /* 0x00000001896C68D0-0x00000001896C68F0 */ get => default; /* [XID] */ /* 0x00000001896CDF30-0x00000001896CDF50 */ private set {} } // 0x0000000182AC7410-0x0000000182AC74B0 0x0000000182AC6A80-0x0000000182AC6B30
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189758250-0x0000000189758270 */ get => default; } // 0x0000000182AC82A0-0x0000000182AC8340 
	protected override bool MuteRemote { /* [XID] */ /* 0x000000018975FCF0-0x000000018975FD10 */ get => default; } // 0x0000000182AC77B0-0x0000000182AC7850 
	protected override bool ForceForwardToServer { /* [XID] */ /* 0x0000000189767360-0x0000000189767380 */ get => default; } // 0x0000000182AC6890-0x0000000182AC6930 

	// Constructors
	public TriggerCreateGadgetToEquipPart() {} // 0x0000000182AC8BB0-0x0000000182AC8C10

	// Methods
	// [XID] // 0x00000001896D54A0-0x00000001896D54C0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182AC8960-0x0000000182AC8A70
	// [XID] // 0x00000001896DCA00-0x00000001896DCA20
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182AC8410-0x0000000182AC84F0
	// [XID] // 0x00000001896E4370-0x00000001896E4390
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3DE6 */) => default; // 0x0000000182AC7E30-0x0000000182AC7F10
	// [XID] // 0x00000001896EB780-0x00000001896EB7A0
	public override int GetHashNum() => default; // 0x0000000182AC67C0-0x0000000182AC6890
	// [XID] // 0x00000001896F2B50-0x00000001896F2B70
	public override void InitEmpty() {} // 0x0000000182AC7850-0x0000000182AC7960
	[BlackList] // 0x00000001896FA470-0x00000001896FA4B0
	// [XID] // 0x00000001896FA470-0x00000001896FA4B0
	public override bool FromJson(JSONNode node) => default; // 0x0000000182AC7090-0x0000000182AC7410
	// [XID] // 0x0000000189704AD0-0x0000000189704AF0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182AC5EA0-0x0000000182AC61E0
	[BlackList] // 0x000000018970C290-0x000000018970C2D0
	// [XID] // 0x000000018970C290-0x000000018970C2D0
	public static new TriggerCreateGadgetToEquipPart ParseFromJson(JSONNode node) => default; // 0x0000000182AC8050-0x0000000182AC82A0
	// [XID] // 0x0000000189716820-0x0000000189716840
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3DE7 */, bool useObjectPool = false /* Metadata: 0x00AF3DEB */) => default; // 0x0000000182AC7B30-0x0000000182AC7E30
	// [XID] // 0x000000018971E280-0x000000018971E2A0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3DEC */, bool useObjectPool = false /* Metadata: 0x00AF3DF0 */) => default; // 0x0000000182AC6B30-0x0000000182AC6E30
	// [XID] // 0x00000001897257E0-0x0000000189725800
	public static new TriggerCreateGadgetToEquipPart ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3DF1 */, bool useObjectPool = false /* Metadata: 0x00AF3DF5 */) => default; // 0x0000000182AC74B0-0x0000000182AC76D0
	[BlackList] // 0x000000018972CCE0-0x000000018972CD20
	// [XID] // 0x000000018972CCE0-0x000000018972CD20
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182AC61E0-0x0000000182AC64B0
	// [XID] // 0x0000000189737860-0x0000000189737880
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182AC86A0-0x0000000182AC8960
	[BlackList] // 0x000000018973F3A0-0x000000018973F3E0
	// [XID] // 0x000000018973F3A0-0x000000018973F3E0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182AC7A40-0x0000000182AC7B30
	// [XID] // 0x0000000189749840-0x0000000189749860
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000182AC8A70-0x0000000182AC8B10
	// [XID] // 0x0000000189750DA0-0x0000000189750DC0
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000182AC6E30-0x0000000182AC6F90
	[BlackList] // 0x000000018976E8A0-0x000000018976E8E0
	// [XID] // 0x000000018976E8A0-0x000000018976E8E0
	public override void AutoAllocTypeFields() {} // 0x0000000182AC64B0-0x0000000182AC6550
	[BlackList] // 0x00000001897791E0-0x0000000189779220
	// [XID] // 0x00000001897791E0-0x0000000189779220
	public override void AutoRecycleTypeFields() {} // 0x0000000182AC6550-0x0000000182AC6630
	[BlackList] // 0x00000001897839B0-0x00000001897839F0
	// [XID] // 0x00000001897839B0-0x00000001897839F0
	public override void ReturnToObjectPool() {} // 0x0000000182AC8B10-0x0000000182AC8BB0
}

