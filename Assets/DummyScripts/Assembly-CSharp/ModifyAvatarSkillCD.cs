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
public class ModifyAvatarSkillCD : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16673
{
	// Fields
	private SimpleSafeUInt32 skillIDRawNum; // 0x68
	private SimpleSafeUInt32[] _skillSlot; // 0x70
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _cdDelta; // 0x78
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _cdRatio; // 0x80

	// Properties
	public uint skillID { /* [XID] */ /* 0x0000000189B28470-0x0000000189B28490 */ get => default; /* [XID] */ /* 0x0000000189B2F7D0-0x0000000189B2F7F0 */ private set {} } // 0x0000000183E545B0-0x0000000183E54680 0x0000000183E559D0-0x0000000183E55AB0
	public SimpleSafeUInt32[] skillSlot { /* [XID] */ /* 0x0000000189B370B0-0x0000000189B370D0 */ get => default; /* [XID] */ /* 0x0000000189B3EA00-0x0000000189B3EA20 */ private set {} } // 0x0000000183E54470-0x0000000183E54510 0x0000000183E531D0-0x0000000183E53280
	public DynamicFloat cdDelta { /* [XID] */ /* 0x0000000189B46460-0x0000000189B46480 */ get => default; /* [XID] */ /* 0x0000000189B4D9E0-0x0000000189B4DA00 */ private set {} } // 0x0000000183E54680-0x0000000183E54720 0x0000000183E55180-0x0000000183E55230
	public DynamicFloat cdRatio { /* [XID] */ /* 0x0000000189B55270-0x0000000189B55290 */ get => default; /* [XID] */ /* 0x0000000189B5CBF0-0x0000000189B5CC10 */ private set {} } // 0x0000000183E534E0-0x0000000183E53590 0x0000000183E54E20-0x0000000183E54ED0
	protected override bool MuteAuthority { /* [XID] */ /* 0x00000001895EC6B0-0x00000001895EC6D0 */ get => default; } // 0x0000000183E55230-0x0000000183E552D0 
	protected override bool MuteRemote { /* [XID] */ /* 0x00000001895F3B50-0x00000001895F3B70 */ get => default; } // 0x0000000183E54510-0x0000000183E545B0 
	protected override bool ForceForwardToServer { /* [XID] */ /* 0x00000001895FB3F0-0x00000001895FB410 */ get => default; } // 0x0000000183E53440-0x0000000183E534E0 

	// Constructors
	public ModifyAvatarSkillCD() {} // 0x0000000183E55D60-0x0000000183E55DC0

	// Methods
	// [XID] // 0x0000000189B64250-0x0000000189B64270
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183E55AB0-0x0000000183E55C20
	// [XID] // 0x0000000189B6B910-0x0000000189B6B930
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183E553A0-0x0000000183E554B0
	// [XID] // 0x0000000189B73010-0x0000000189B73030
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF42AE */) => default; // 0x0000000183E54D40-0x0000000183E54E20
	// [XID] // 0x0000000189B7A610-0x0000000189B7A630
	public override int GetHashNum() => default; // 0x0000000183E53370-0x0000000183E53440
	// [XID] // 0x0000000189B81E50-0x0000000189B81E70
	public override void InitEmpty() {} // 0x0000000183E54720-0x0000000183E54860
	[BlackList] // 0x0000000189B894F0-0x0000000189B89530
	// [XID] // 0x0000000189B894F0-0x0000000189B89530
	public override bool FromJson(JSONNode node) => default; // 0x0000000183E53DF0-0x0000000183E54170
	// [XID] // 0x0000000189B93870-0x0000000189B93890
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183E52670-0x0000000183E52BD0
	[BlackList] // 0x0000000189B9AD80-0x0000000189B9ADC0
	// [XID] // 0x0000000189B9AD80-0x0000000189B9ADC0
	public static new ModifyAvatarSkillCD ParseFromJson(JSONNode node) => default; // 0x0000000183E54F30-0x0000000183E55180
	// [XID] // 0x0000000189BA5430-0x0000000189BA5450
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF42AF */, bool useObjectPool = false /* Metadata: 0x00AF42B3 */) => default; // 0x0000000183E54A40-0x0000000183E54D40
	// [XID] // 0x0000000189BAC610-0x0000000189BAC630
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF42B4 */, bool useObjectPool = false /* Metadata: 0x00AF42B8 */) => default; // 0x0000000183E536E0-0x0000000183E53B90
	// [XID] // 0x0000000189BB3F10-0x0000000189BB3F30
	public static new ModifyAvatarSkillCD ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF42B9 */, bool useObjectPool = false /* Metadata: 0x00AF42BD */) => default; // 0x0000000183E54170-0x0000000183E54390
	[BlackList] // 0x0000000189BBB490-0x0000000189BBB4D0
	// [XID] // 0x0000000189BBB490-0x0000000189BBB4D0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000183E52BD0-0x0000000183E52EA0
	// [XID] // 0x0000000189BC6040-0x0000000189BC6060
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183E55590-0x0000000183E559D0
	[BlackList] // 0x0000000189BCDB40-0x0000000189BCDB80
	// [XID] // 0x0000000189BCDB40-0x0000000189BCDB80
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183E54940-0x0000000183E54A40
	// [XID] // 0x0000000189BD7F30-0x0000000189BD7F50
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000183E55C20-0x0000000183E55CC0
	// [XID] // 0x0000000189BDFAC0-0x0000000189BDFAE0
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000183E53B90-0x0000000183E53CF0
	[BlackList] // 0x0000000189602B50-0x0000000189602B90
	// [XID] // 0x0000000189602B50-0x0000000189602B90
	public override void AutoAllocTypeFields() {} // 0x0000000183E52EA0-0x0000000183E52F40
	[BlackList] // 0x000000018960D460-0x000000018960D4A0
	// [XID] // 0x000000018960D460-0x000000018960D4A0
	public override void AutoRecycleTypeFields() {} // 0x0000000183E52F40-0x0000000183E53130
	[BlackList] // 0x0000000189617830-0x0000000189617870
	// [XID] // 0x0000000189617830-0x0000000189617870
	public override void ReturnToObjectPool() {} // 0x0000000183E55CC0-0x0000000183E55D60
}

