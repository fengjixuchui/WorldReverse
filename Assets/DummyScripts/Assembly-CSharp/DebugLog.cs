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
public class DebugLog : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16486
{
	// Fields
	private string _content; // 0x68

	// Properties
	public string content { /* [XID] */ /* 0x0000000189A954B0-0x0000000189A954D0 */ get => default; /* [XID] */ /* 0x0000000189A9CCB0-0x0000000189A9CCD0 */ private set {} } // 0x0000000184348D70-0x0000000184348E10 0x0000000184349670-0x0000000184349720
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189B284D0-0x0000000189B284F0 */ get => default; } // 0x00000001843490C0-0x0000000184349160 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189B2F830-0x0000000189B2F850 */ get => default; } // 0x0000000184348650-0x00000001843486F0 

	// Constructors
	public DebugLog() {} // 0x0000000184349860-0x00000001843498C0

	// Methods
	// [XID] // 0x0000000189AA44C0-0x0000000189AA44E0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184349580-0x0000000184349670
	// [XID] // 0x0000000189AAB990-0x0000000189AAB9B0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001843491C0-0x00000001843492A0
	// [XID] // 0x0000000189AB3360-0x0000000189AB3380
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3CF0 */) => default; // 0x0000000184348C90-0x0000000184348D70
	// [XID] // 0x0000000189ABB050-0x0000000189ABB070
	public override int GetHashNum() => default; // 0x00000001843478E0-0x00000001843479B0
	// [XID] // 0x0000000189AC2860-0x0000000189AC2880
	public override void InitEmpty() {} // 0x00000001843486F0-0x00000001843487C0
	[BlackList] // 0x0000000189AC9E40-0x0000000189AC9E80
	// [XID] // 0x0000000189AC9E40-0x0000000189AC9E80
	public override bool FromJson(JSONNode node) => default; // 0x0000000184347FD0-0x0000000184348350
	// [XID] // 0x0000000189AD4B60-0x0000000189AD4B80
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184347100-0x0000000184347330
	[BlackList] // 0x0000000189ADC500-0x0000000189ADC540
	// [XID] // 0x0000000189ADC500-0x0000000189ADC540
	public static new DebugLog ParseFromJson(JSONNode node) => default; // 0x0000000184348E70-0x00000001843490C0
	// [XID] // 0x0000000189AE6E90-0x0000000189AE6EB0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3CF1 */, bool useObjectPool = false /* Metadata: 0x00AF3CF5 */) => default; // 0x0000000184348990-0x0000000184348C90
	// [XID] // 0x0000000189AEE9A0-0x0000000189AEE9C0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3CF6 */, bool useObjectPool = false /* Metadata: 0x00AF3CFA */) => default; // 0x0000000184347B00-0x0000000184347D70
	// [XID] // 0x0000000189AF5FB0-0x0000000189AF5FD0
	public static new DebugLog ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3CFB */, bool useObjectPool = false /* Metadata: 0x00AF3CFF */) => default; // 0x0000000184348350-0x0000000184348570
	[BlackList] // 0x0000000189AFD4B0-0x0000000189AFD4F0
	// [XID] // 0x0000000189AFD4B0-0x0000000189AFD4F0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184347330-0x0000000184347600
	// [XID] // 0x0000000189B07BB0-0x0000000189B07BD0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184349380-0x0000000184349580
	[BlackList] // 0x0000000189B0F470-0x0000000189B0F4B0
	// [XID] // 0x0000000189B0F470-0x0000000189B0F4B0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001843488A0-0x0000000184348990
	// [XID] // 0x0000000189B19730-0x0000000189B19750
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000184349720-0x00000001843497C0
	// [XID] // 0x0000000189B20E10-0x0000000189B20E30
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000184347D70-0x0000000184347ED0
	[BlackList] // 0x0000000189B37130-0x0000000189B37170
	// [XID] // 0x0000000189B37130-0x0000000189B37170
	public override void AutoAllocTypeFields() {} // 0x0000000184347600-0x00000001843476A0
	[BlackList] // 0x0000000189B41CD0-0x0000000189B41D10
	// [XID] // 0x0000000189B41CD0-0x0000000189B41D10
	public override void AutoRecycleTypeFields() {} // 0x00000001843476A0-0x0000000184347750
	[BlackList] // 0x0000000189B4C520-0x0000000189B4C560
	// [XID] // 0x0000000189B4C520-0x0000000189B4C560
	public override void ReturnToObjectPool() {} // 0x00000001843497C0-0x0000000184349860
}

