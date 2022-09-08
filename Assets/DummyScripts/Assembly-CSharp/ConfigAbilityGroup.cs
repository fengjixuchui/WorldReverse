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
public class ConfigAbilityGroup : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 16864
{
	// Fields
	private AbilityGroupSourceType _abilityGroupSourceType; // 0x10
	private AbilityGroupTargetType _abilityGroupTargetType; // 0x14
	private SimpleSafeUInt32[] _abilityGroupTargetIDList; // 0x18
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigEntityAbilityEntry[] _targetAbilities; // 0x20
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigDynamicTalent[] _targetTalents; // 0x28

	// Properties
	public AbilityGroupSourceType abilityGroupSourceType { /* [XID] */ /* 0x0000000189632880-0x00000001896328A0 */ get => default; /* [XID] */ /* 0x000000018963A3B0-0x000000018963A3D0 */ private set {} } // 0x000000018366E4E0-0x000000018366E580 0x000000018366E9E0-0x000000018366EA90
	public AbilityGroupTargetType abilityGroupTargetType { /* [XID] */ /* 0x0000000189641900-0x0000000189641920 */ get => default; /* [XID] */ /* 0x0000000189649360-0x0000000189649380 */ private set {} } // 0x000000018366ED30-0x000000018366EDD0 0x000000018366DAA0-0x000000018366DB50
	public SimpleSafeUInt32[] abilityGroupTargetIDList { /* [XID] */ /* 0x00000001896508F0-0x0000000189650910 */ get => default; /* [XID] */ /* 0x0000000189658150-0x0000000189658170 */ private set {} } // 0x000000018366D5B0-0x000000018366D650 0x000000018366E030-0x000000018366E0E0
	public ConfigEntityAbilityEntry[] targetAbilities { /* [XID] */ /* 0x000000018965F700-0x000000018965F720 */ get => default; /* [XID] */ /* 0x0000000189667110-0x0000000189667130 */ private set {} } // 0x000000018366EDD0-0x000000018366EE70 0x000000018366DC00-0x000000018366DCB0
	public ConfigDynamicTalent[] targetTalents { /* [XID] */ /* 0x000000018966E820-0x000000018966E840 */ get => default; /* [XID] */ /* 0x00000001896763A0-0x00000001896763C0 */ private set {} } // 0x000000018366D510-0x000000018366D5B0 0x000000018366DB50-0x000000018366DC00

	// Constructors
	public ConfigAbilityGroup() {} // 0x000000018366EF10-0x000000018366EF70

	// Methods
	// [XID] // 0x000000018967DBC0-0x000000018967DBE0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018366EA90-0x000000018366EBF0
	// [XID] // 0x0000000189685320-0x0000000189685340
	public void InitEmpty() {} // 0x000000018366E0E0-0x000000018366E1E0
	[BlackList] // 0x000000018968CE20-0x000000018968CE60
	// [XID] // 0x000000018968CE20-0x000000018968CE60
	public bool FromJson(JSONNode node) => default; // 0x000000018366DCB0-0x000000018366E030
	// [XID] // 0x0000000189697BA0-0x0000000189697BC0
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018366CB90-0x000000018366D0E0
	// [XID] // 0x000000018969EF10-0x000000018969EF30
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5BBF */, bool useObjectPool = false /* Metadata: 0x00AF5BC3 */) => default; // 0x000000018366E1E0-0x000000018366E4E0
	// [XID] // 0x00000001896A63B0-0x00000001896A63D0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5BC4 */, bool useObjectPool = false /* Metadata: 0x00AF5BC8 */) => default; // 0x000000018366D650-0x000000018366DAA0
	[BlackList] // 0x00000001896AD930-0x00000001896AD970
	// [XID] // 0x00000001896AD930-0x00000001896AD970
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018366D0E0-0x000000018366D3B0
	// [XID] // 0x00000001896B7E70-0x00000001896B7E90
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018366E580-0x000000018366E9E0
	[BlackList] // 0x00000001896BEF10-0x00000001896BEF50
	// [XID] // 0x00000001896BEF10-0x00000001896BEF50
	public virtual void AutoAllocTypeFields() {} // 0x000000018366D3B0-0x000000018366D450
	[BlackList] // 0x00000001896C93F0-0x00000001896C9430
	// [XID] // 0x00000001896C93F0-0x00000001896C9430
	public virtual void AutoRecycleTypeFields() {} // 0x000000018366D450-0x000000018366D510
	[BlackList] // 0x00000001896D37C0-0x00000001896D3800
	// [XID] // 0x00000001896D37C0-0x00000001896D3800
	public virtual void ReturnToObjectPool() {} // 0x000000018366EE70-0x000000018366EF10
	[BlackList] // 0x00000001896DE1A0-0x00000001896DE1E0
	// [XID] // 0x00000001896DE1A0-0x00000001896DE1E0
	public virtual void OnPoolAllocated() {} // 0x000000018366EC90-0x000000018366ED30
	[BlackList] // 0x00000001896E8620-0x00000001896E8660
	// [XID] // 0x00000001896E8620-0x00000001896E8660
	public virtual void OnBeforePoolRecycled() {} // 0x000000018366EBF0-0x000000018366EC90
}

