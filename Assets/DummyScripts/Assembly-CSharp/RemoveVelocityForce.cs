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
public class RemoveVelocityForce : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16603
{
	// Fields
	private VelocityForceType[] _forces; // 0x68

	// Properties
	public VelocityForceType[] forces { /* [XID] */ /* 0x0000000189718030-0x0000000189718050 */ get => default; /* [XID] */ /* 0x000000018971FA30-0x000000018971FA50 */ private set {} } // 0x00000001832F1550-0x00000001832F15F0 0x00000001832F1650-0x00000001832F1700
	protected override bool MuteAuthority { /* [XID] */ /* 0x00000001897AA8C0-0x00000001897AA8E0 */ get => default; } // 0x00000001832F1950-0x00000001832F19F0 
	protected override bool MuteRemote { /* [XID] */ /* 0x00000001897B2430-0x00000001897B2450 */ get => default; } // 0x00000001832F0E30-0x00000001832F0ED0 

	// Constructors
	public RemoveVelocityForce() {} // 0x00000001832F2080-0x00000001832F20E0

	// Methods
	// [XID] // 0x00000001897270C0-0x00000001897270E0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001832F1E50-0x00000001832F1F40
	// [XID] // 0x000000018972E690-0x000000018972E6B0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001832F1A50-0x00000001832F1B30
	// [XID] // 0x0000000189735DE0-0x0000000189735E00
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF408A */) => default; // 0x00000001832F1470-0x00000001832F1550
	// [XID] // 0x000000018973D950-0x000000018973D970
	public override int GetHashNum() => default; // 0x00000001832F00C0-0x00000001832F0190
	// [XID] // 0x0000000189744DD0-0x0000000189744DF0
	public override void InitEmpty() {} // 0x00000001832F0ED0-0x00000001832F0FA0
	[BlackList] // 0x000000018974C9A0-0x000000018974C9E0
	// [XID] // 0x000000018974C9A0-0x000000018974C9E0
	public override bool FromJson(JSONNode node) => default; // 0x00000001832F07B0-0x00000001832F0B30
	// [XID] // 0x0000000189756E80-0x0000000189756EA0
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001832EF8E0-0x00000001832EFB10
	[BlackList] // 0x000000018975E2F0-0x000000018975E330
	// [XID] // 0x000000018975E2F0-0x000000018975E330
	public static new RemoveVelocityForce ParseFromJson(JSONNode node) => default; // 0x00000001832F1700-0x00000001832F1950
	// [XID] // 0x00000001897689A0-0x00000001897689C0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF408B */, bool useObjectPool = false /* Metadata: 0x00AF408F */) => default; // 0x00000001832F1170-0x00000001832F1470
	// [XID] // 0x0000000189770030-0x0000000189770050
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4090 */, bool useObjectPool = false /* Metadata: 0x00AF4094 */) => default; // 0x00000001832F02E0-0x00000001832F0550
	// [XID] // 0x0000000189777790-0x00000001897777B0
	public static new RemoveVelocityForce ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4095 */, bool useObjectPool = false /* Metadata: 0x00AF4099 */) => default; // 0x00000001832F0B30-0x00000001832F0D50
	[BlackList] // 0x000000018977EE60-0x000000018977EEA0
	// [XID] // 0x000000018977EE60-0x000000018977EEA0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001832EFB10-0x00000001832EFDE0
	// [XID] // 0x00000001897896A0-0x00000001897896C0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001832F1C10-0x00000001832F1E50
	[BlackList] // 0x0000000189790DF0-0x0000000189790E30
	// [XID] // 0x0000000189790DF0-0x0000000189790E30
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001832F1080-0x00000001832F1170
	// [XID] // 0x000000018979BEF0-0x000000018979BF10
	public override bool isAlreadyHandledRecoverCase() => default; // 0x00000001832F1F40-0x00000001832F1FE0
	// [XID] // 0x00000001897A3360-0x00000001897A3380
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x00000001832F0550-0x00000001832F06B0
	[BlackList] // 0x00000001897B9DB0-0x00000001897B9DF0
	// [XID] // 0x00000001897B9DB0-0x00000001897B9DF0
	public override void AutoAllocTypeFields() {} // 0x00000001832EFDE0-0x00000001832EFE80
	[BlackList] // 0x00000001897C4D20-0x00000001897C4D60
	// [XID] // 0x00000001897C4D20-0x00000001897C4D60
	public override void AutoRecycleTypeFields() {} // 0x00000001832EFE80-0x00000001832EFF30
	[BlackList] // 0x00000001897CF630-0x00000001897CF670
	// [XID] // 0x00000001897CF630-0x00000001897CF670
	public override void ReturnToObjectPool() {} // 0x00000001832F1FE0-0x00000001832F2080
}

