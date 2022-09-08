/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MonsterEntity : CharacterEntity, IAutoAllocRecycle // TypeDefIndex: 19879
{
	// Fields
	public uint groupId; // 0x4E8
	public uint markFlag; // 0x4EC
	private bool _lifeByOwnerLife; // 0x4F0
	private bool _registedLifeToOwner; // 0x4F1
	private uint _ownerRuntimeID; // 0x4F4
	private Action _ownerReadyAction; // 0x4F8
	private uint _originOwnerRuntimeID; // 0x500
	private List<uint> _childrenRuntimeIds; // 0x508
	private ConfigLevelMonsterUnit _levelMonster; // 0x510
	public static float[] monsterLevelEntityBudgets; // 0x00

	// Properties
	public override EntityReuseType entityReuseType { /* [XID] */ /* 0x00000001899FE230-0x00000001899FE250 */ get => default; } // 0x0000000181CF69D0-0x0000000181CF6A70 
	public override bool LifeByOwnerLife { /* [XID] */ /* 0x0000000189A40CF0-0x0000000189A40D10 */ get => default; /* [XID] */ /* 0x0000000189A48330-0x0000000189A48350 */ set {} } // 0x0000000181CF4EC0-0x0000000181CF4F70 0x0000000181CF4250-0x0000000181CF43A0

	// Constructors
	public MonsterEntity() {} // 0x0000000181CF6BB0-0x0000000181CF6C40
	static MonsterEntity() {} // 0x0000000181CF6B10-0x0000000181CF6BB0

	// Methods
	// [XID] // 0x00000001899E7E20-0x00000001899E7E40
	protected override bool ShouldFireEntityRemoved() => default; // 0x0000000181CF56A0-0x0000000181CF5740
	// [XID] // 0x00000001899EF200-0x00000001899EF220
	public override void ReInit(ReInitReason reason = ReInitReason.Default /* Metadata: 0x00AFCFD3 */, bool runtimeIDChange = false /* Metadata: 0x00AFCFD7 */) {} // 0x0000000181CF4780-0x0000000181CF4860
	// [XID] // 0x00000001899F6B70-0x00000001899F6B90
	private void CheckOwnerAndChildrenValid() {} // 0x0000000181CF5E20-0x0000000181CF5FE0
	// [XID] // 0x0000000189A05B10-0x0000000189A05B30
	public override bool CanReuseEntity() => default; // 0x0000000181CF3BE0-0x0000000181CF3CC0
	// [XID] // 0x0000000189A0CE20-0x0000000189A0CE40
	public override bool Destroy(SliceFrameWatch watch) => default; // 0x0000000181CF3720-0x0000000181CF3880
	// [XID] // 0x0000000189A14680-0x0000000189A146A0
	protected override bool ChangeAuthority() => default; // 0x0000000181CF4FE0-0x0000000181CF54B0
	// [XID] // 0x00000001896FDE90-0x00000001896FDEB0
	public bool IsInAnimatorTag(MonsterData.MonsterTagGroup tagGroup) => default; // 0x0000000181CF4B30-0x0000000181CF4DF0
	// [XID] // 0x0000000189A23300-0x0000000189A23320
	public bool IsNotInAnimatorTag(MonsterData.MonsterTagGroup tagGroup) => default; // 0x0000000181CF6710-0x0000000181CF69D0
	// [XID] // 0x0000000189A2A540-0x0000000189A2A560
	public bool IsOnlyInAnimatorTag(MonsterData.MonsterTagGroup tagGroup) => default; // 0x0000000181CF4860-0x0000000181CF4B30
	// [XID] // 0x0000000189A31A70-0x0000000189A31A90
	public bool IsCurrentInAnimatorTag(MonsterData.MonsterTagGroup tagGroup) => default; // 0x0000000181CF2EC0-0x0000000181CF30F0
	// [XID] // 0x0000000189A39590-0x0000000189A395B0
	public bool IsNextInAnimatorTag(MonsterData.MonsterTagGroup tagGroup) => default; // 0x0000000181CF57C0-0x0000000181CF59F0
	// [XID] // 0x0000000189A4FC40-0x0000000189A4FC60
	protected override void OnOwnerDie(BaseEntity ownerEntity) {} // 0x0000000181CF3880-0x0000000181CF39A0
	// [XID] // 0x0000000189A57170-0x0000000189A57190
	public override BaseEntity GetOwnerEntity() => default; // 0x0000000181CF3470-0x0000000181CF3610
	// [XID] // 0x0000000189A5ED10-0x0000000189A5ED30
	public override void SetOwnerRuntimeId(uint ownerRuntimeId) {} // 0x0000000181CF3FD0-0x0000000181CF4250
	// [XID] // 0x0000000189A66510-0x0000000189A66530
	public override void Clear(ClearReason clearReason) {} // 0x0000000181CF4650-0x0000000181CF4710
	// [XID] // 0x0000000189A6DD60-0x0000000189A6DD80
	public override uint GetOwnerRuntimeID() => default; // 0x0000000181CF2BF0-0x0000000181CF2C90
	// [XID] // 0x0000000189A75330-0x0000000189A75350
	public override void SetOriginOwnerRuntimeId(uint originOwnerRuntimeID) {} // 0x0000000181CF3D90-0x0000000181CF3E40
	// [XID] // 0x0000000189A7D030-0x0000000189A7D050
	public override BaseEntity GetOriginOwnerEntity() => default; // 0x0000000181CF3EE0-0x0000000181CF3FD0
	// [XID] // 0x0000000189A848A0-0x0000000189A848C0
	public override uint GetOriginOwnerRuntimeID() => default; // 0x0000000181CF3260-0x0000000181CF3300
	// [XID] // 0x0000000189A8C120-0x0000000189A8C140
	public override void ClearOwners() {} // 0x0000000181CF5CD0-0x0000000181CF5D70
	// [XID] // 0x0000000189A93610-0x0000000189A93630
	public override void ClearOriginOwners() {} // 0x0000000181CF3610-0x0000000181CF36B0
	// [XID] // 0x0000000189A9B1E0-0x0000000189A9B200
	private void ResetOwners() {} // 0x0000000181CF43A0-0x0000000181CF4550
	// [XID] // 0x0000000189AA2470-0x0000000189AA2490
	public override List<uint> GetChildrenRuntimeIds() => default; // 0x0000000181CF5D70-0x0000000181CF5E20
	// [XID] // 0x0000000189AA9A00-0x0000000189AA9A20
	public override void AddChild(uint childRuntimeID) {} // 0x0000000181CF5BA0-0x0000000181CF5CD0
	// [XID] // 0x0000000189AB1880-0x0000000189AB18A0
	public override void RemoveChild(uint childRuntimeID) {} // 0x0000000181CF2C90-0x0000000181CF2D80
	// [XID] // 0x0000000189AB8BA0-0x0000000189AB8BC0
	public override void ClearChildren() {} // 0x0000000181CF6370-0x0000000181CF6420
	// [XID] // 0x0000000189AC06F0-0x0000000189AC0710
	private void ResetChildren() {} // 0x0000000181CF6420-0x0000000181CF65C0
	// [XID] // 0x0000000189AC8150-0x0000000189AC8170
	public ConfigLevelMonsterUnit GetLevelMonster() => default; // 0x0000000181CF61A0-0x0000000181CF6370
	// [XID] // 0x0000000189ACF8F0-0x0000000189ACF910
	public override bool ShouldUseSyncReadyOnCreatedSkillObject() => default; // 0x0000000181CF5FE0-0x0000000181CF60B0
	// [XID] // 0x0000000189AD7620-0x0000000189AD7640
	public override EntityMultiPlayerExcelConfig GetMultiPlayerExcelConfig() => default; // 0x0000000181CF4550-0x0000000181CF4650
	// [XID] // 0x0000000189ADF090-0x0000000189ADF0B0
	public override float GetStaticBudget() => default; // 0x0000000181CF54B0-0x0000000181CF56A0
	[BlackList] // 0x0000000189AE6960-0x0000000189AE69A0
	// [XID] // 0x0000000189AE6960-0x0000000189AE69A0
	public override void AutoAllocTypeFields() {} // 0x0000000181CF30F0-0x0000000181CF3190
	[BlackList] // 0x0000000189AF1510-0x0000000189AF1550
	// [XID] // 0x0000000189AF1510-0x0000000189AF1550
	public override void AutoRecycleTypeFields() {} // 0x0000000181CF3190-0x0000000181CF3260
	[BlackList] // 0x0000000189AFB9E0-0x0000000189AFBA20
	// [XID] // 0x0000000189AFB9E0-0x0000000189AFBA20
	public override void ReturnToObjectPool() {} // 0x0000000181CF6A70-0x0000000181CF6B10
	// [XID] // 0x0000000189B06100-0x0000000189B06120
	public override uint GetGroupIDForStat() => default; // 0x0000000181CF3AD0-0x0000000181CF3B70
}

