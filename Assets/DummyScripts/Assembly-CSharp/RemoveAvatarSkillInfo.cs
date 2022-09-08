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
public class RemoveAvatarSkillInfo : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16619
{
	// Fields
	private SimpleSafeUInt32 skillIDRawNum; // 0x68

	// Properties
	public uint skillID { /* [XID] */ /* 0x000000018977D9A0-0x000000018977D9C0 */ get => default; /* [XID] */ /* 0x0000000189785180-0x00000001897851A0 */ private set {} } // 0x000000018511F290-0x000000018511F360 0x0000000185120160-0x0000000185120240
	protected override bool MuteAuthority { /* [XID] */ /* 0x00000001898116C0-0x00000001898116E0 */ get => default; } // 0x000000018511FCA0-0x000000018511FD40 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189819230-0x0000000189819250 */ get => default; } // 0x000000018511F1F0-0x000000018511F290 

	// Constructors
	public RemoveAvatarSkillInfo() {} // 0x0000000185120470-0x00000001851204D0

	// Methods
	// [XID] // 0x000000018978C690-0x000000018978C6B0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000185120240-0x0000000185120330
	// [XID] // 0x0000000189793B80-0x0000000189793BA0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018511FDA0-0x000000018511FE50
	// [XID] // 0x000000018979BED0-0x000000018979BEF0
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF410A */) => default; // 0x000000018511F910-0x000000018511F9F0
	// [XID] // 0x00000001897A3340-0x00000001897A3360
	public override int GetHashNum() => default; // 0x000000018511E480-0x000000018511E550
	// [XID] // 0x00000001897AA8A0-0x00000001897AA8C0
	public override void InitEmpty() {} // 0x000000018511F360-0x000000018511F430
	[BlackList] // 0x00000001897B23F0-0x00000001897B2430
	// [XID] // 0x00000001897B23F0-0x00000001897B2430
	public override bool FromJson(JSONNode node) => default; // 0x000000018511EB70-0x000000018511EEF0
	// [XID] // 0x00000001897BD980-0x00000001897BD9A0
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018511DC40-0x000000018511DEA0
	[BlackList] // 0x00000001897C4CE0-0x00000001897C4D20
	// [XID] // 0x00000001897C4CE0-0x00000001897C4D20
	public static new RemoveAvatarSkillInfo ParseFromJson(JSONNode node) => default; // 0x000000018511FA50-0x000000018511FCA0
	// [XID] // 0x00000001897CF610-0x00000001897CF630
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF410B */, bool useObjectPool = false /* Metadata: 0x00AF410F */) => default; // 0x000000018511F610-0x000000018511F910
	// [XID] // 0x00000001897D6EE0-0x00000001897D6F00
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4110 */, bool useObjectPool = false /* Metadata: 0x00AF4114 */) => default; // 0x000000018511E6A0-0x000000018511E910
	// [XID] // 0x00000001897DE530-0x00000001897DE550
	public static new RemoveAvatarSkillInfo ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4115 */, bool useObjectPool = false /* Metadata: 0x00AF4119 */) => default; // 0x000000018511EEF0-0x000000018511F110
	[BlackList] // 0x00000001897E6010-0x00000001897E6050
	// [XID] // 0x00000001897E6010-0x00000001897E6050
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018511DEA0-0x000000018511E170
	// [XID] // 0x00000001897F0B20-0x00000001897F0B40
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018511FF30-0x0000000185120160
	[BlackList] // 0x00000001897F8320-0x00000001897F8360
	// [XID] // 0x00000001897F8320-0x00000001897F8360
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018511F510-0x000000018511F610
	// [XID] // 0x00000001898029E0-0x0000000189802A00
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000185120330-0x00000001851203D0
	// [XID] // 0x000000018980A030-0x000000018980A050
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x000000018511E910-0x000000018511EA70
	[BlackList] // 0x0000000189820A50-0x0000000189820A90
	// [XID] // 0x0000000189820A50-0x0000000189820A90
	public override void AutoAllocTypeFields() {} // 0x000000018511E170-0x000000018511E210
	[BlackList] // 0x000000018982AE70-0x000000018982AEB0
	// [XID] // 0x000000018982AE70-0x000000018982AEB0
	public override void AutoRecycleTypeFields() {} // 0x000000018511E210-0x000000018511E2F0
	[BlackList] // 0x0000000189835290-0x00000001898352D0
	// [XID] // 0x0000000189835290-0x00000001898352D0
	public override void ReturnToObjectPool() {} // 0x00000001851203D0-0x0000000185120470
}

