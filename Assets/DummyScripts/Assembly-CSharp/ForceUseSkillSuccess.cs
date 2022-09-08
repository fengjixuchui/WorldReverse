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
public class ForceUseSkillSuccess : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16791
{
	// Fields
	private SimpleSafeUInt32 skillIDRawNum; // 0x68
	private UseSkillType _type; // 0x6C
	private bool _immediately; // 0x70

	// Properties
	public uint skillID { /* [XID] */ /* 0x0000000189ADF5F0-0x0000000189ADF610 */ get => default; /* [XID] */ /* 0x0000000189AE6DD0-0x0000000189AE6DF0 */ private set {} } // 0x0000000184CA4240-0x0000000184CA4310 0x0000000184CA5420-0x0000000184CA5500
	public UseSkillType type { /* [XID] */ /* 0x0000000189AEE8E0-0x0000000189AEE900 */ get => default; /* [XID] */ /* 0x0000000189AF5EF0-0x0000000189AF5F10 */ private set {} } // 0x0000000184CA5630-0x0000000184CA56D0 0x0000000184CA4EA0-0x0000000184CA4F50
	public bool immediately { /* [XID] */ /* 0x0000000189AFD370-0x0000000189AFD390 */ get => default; /* [XID] */ /* 0x0000000189B04BE0-0x0000000189B04C00 */ private set {} } // 0x0000000184CA4310-0x0000000184CA43B0 0x0000000184CA5370-0x0000000184CA5420
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189B87E20-0x0000000189B87E40 */ get => default; } // 0x0000000184CA4CF0-0x0000000184CA4D90 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189B8F030-0x0000000189B8F050 */ get => default; } // 0x0000000184CA41A0-0x0000000184CA4240 

	// Constructors
	public ForceUseSkillSuccess() {} // 0x0000000184CA5770-0x0000000184CA57E0

	// Methods
	// [XID] // 0x0000000189B0C3B0-0x0000000189B0C3D0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184CA5500-0x0000000184CA5630
	// [XID] // 0x0000000189B13950-0x0000000189B13970
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184CA4DF0-0x0000000184CA4EA0
	// [XID] // 0x0000000189B1AF60-0x0000000189B1AF80
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF465E */) => default; // 0x0000000184CA4960-0x0000000184CA4A40
	// [XID] // 0x0000000189B226D0-0x0000000189B226F0
	public override int GetHashNum() => default; // 0x0000000184CA33C0-0x0000000184CA3490
	// [XID] // 0x0000000189B29C60-0x0000000189B29C80
	public override void InitEmpty() {} // 0x0000000184CA43B0-0x0000000184CA4480
	[BlackList] // 0x0000000189B31230-0x0000000189B31270
	// [XID] // 0x0000000189B31230-0x0000000189B31270
	public override bool FromJson(JSONNode node) => default; // 0x0000000184CA3B90-0x0000000184CA3F10
	// [XID] // 0x0000000189B3B8B0-0x0000000189B3B8D0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184CA29C0-0x0000000184CA2DE0
	[BlackList] // 0x0000000189B432B0-0x0000000189B432F0
	// [XID] // 0x0000000189B432B0-0x0000000189B432F0
	public static new ForceUseSkillSuccess ParseFromJson(JSONNode node) => default; // 0x0000000184CA4AA0-0x0000000184CA4CF0
	// [XID] // 0x0000000189B4D940-0x0000000189B4D960
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF465F */, bool useObjectPool = false /* Metadata: 0x00AF4663 */) => default; // 0x0000000184CA4660-0x0000000184CA4960
	// [XID] // 0x0000000189B551F0-0x0000000189B55210
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4664 */, bool useObjectPool = false /* Metadata: 0x00AF4668 */) => default; // 0x0000000184CA35E0-0x0000000184CA3930
	// [XID] // 0x0000000189B5CBB0-0x0000000189B5CBD0
	public static new ForceUseSkillSuccess ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4669 */, bool useObjectPool = false /* Metadata: 0x00AF466D */) => default; // 0x0000000184CA3F10-0x0000000184CA4130
	[BlackList] // 0x0000000189B641F0-0x0000000189B64230
	// [XID] // 0x0000000189B641F0-0x0000000189B64230
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184CA2DE0-0x0000000184CA30B0
	// [XID] // 0x0000000189B6E700-0x0000000189B6E720
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184CA5030-0x0000000184CA5370
	[BlackList] // 0x0000000189B75F30-0x0000000189B75F70
	// [XID] // 0x0000000189B75F30-0x0000000189B75F70
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184CA4560-0x0000000184CA4660
	// [XID] // 0x0000000189B80390-0x0000000189B803B0
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000184CA3930-0x0000000184CA3A90
	[BlackList] // 0x0000000189B96520-0x0000000189B96560
	// [XID] // 0x0000000189B96520-0x0000000189B96560
	public override void AutoAllocTypeFields() {} // 0x0000000184CA30B0-0x0000000184CA3150
	[BlackList] // 0x0000000189BA0AB0-0x0000000189BA0AF0
	// [XID] // 0x0000000189BA0AB0-0x0000000189BA0AF0
	public override void AutoRecycleTypeFields() {} // 0x0000000184CA3150-0x0000000184CA3230
	[BlackList] // 0x0000000189BAB100-0x0000000189BAB140
	// [XID] // 0x0000000189BAB100-0x0000000189BAB140
	public override void ReturnToObjectPool() {} // 0x0000000184CA56D0-0x0000000184CA5770
}

