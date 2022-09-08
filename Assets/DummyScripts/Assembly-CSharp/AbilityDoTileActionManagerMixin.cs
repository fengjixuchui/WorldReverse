/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AbilityDoTileActionManagerMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14519
{
	// Fields
	private DoTileActionManagerMixin _config; // 0x70
	private LevelTileAttackPlugin _tilePlugin; // 0x78
	private const int MaxTileGroupNum = 5; // Metadata: 0x00AEB7AA
	private LCBaseCombat _lcAttackerCombat; // 0x80
	private LCAbility _lcAttackerAbility; // 0x88
	private Vector3[] _groupPosList; // 0x90
	private float[] _groupRadiusList; // 0x98
	private uint[] _groupEntityIdList; // 0xA0

	// Constructors
	public AbilityDoTileActionManagerMixin() {} // 0x00000001813F25A0-0x00000001813F2600

	// Methods
	// [XID] // 0x0000000189B64950-0x0000000189B64970
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x00000001813F0CF0-0x00000001813F0EF0
	// [XID] // 0x0000000189B6BDC0-0x0000000189B6BDE0
	private void InitTileManager() {} // 0x00000001813F1610-0x00000001813F16B0
	// [XID] // 0x0000000189B73670-0x0000000189B73690
	public override void OnPoolAllocated() {} // 0x00000001813F1DC0-0x00000001813F1F10
	// [XID] // 0x0000000189B7AB10-0x0000000189B7AB30
	public override void OnBeforePoolRecycled() {} // 0x00000001813F1B90-0x00000001813F1CE0
	// [XID] // 0x0000000189B82370-0x0000000189B82390
	public override void Clear() {} // 0x00000001813F0F60-0x00000001813F1010
	// [XID] // 0x0000000189B89C10-0x0000000189B89C30
	protected override void AddEventListener() {} // 0x00000001813F0960-0x00000001813F0A90
	// [XID] // 0x0000000189B911A0-0x0000000189B911C0
	protected override void RemoveEventListener() {} // 0x00000001813F1290-0x00000001813F13C0
	// [XID] // 0x0000000189B983F0-0x0000000189B98410
	public override void OnAdded(bool syncToServer) {} // 0x00000001813F0690-0x00000001813F0760
	// [XID] // 0x0000000189B9F940-0x0000000189B9F960
	private static new EventID[] GetSelfListenEventIDsExcludingBase() => default; // 0x00000001813F1010-0x00000001813F10F0
	// [XID] // 0x0000000189BA71D0-0x0000000189BA71F0
	public override bool ListenEvent(BaseEvent evt) => default; // 0x00000001813F16B0-0x00000001813F1790
	// [XID] // 0x0000000189BAE320-0x0000000189BAE340
	private void UpdateGlobalValues(BaseEntity caster = null) {} // 0x00000001813F0C20-0x00000001813F0CF0
	// [XID] // 0x0000000189BB5C30-0x0000000189BB5C50
	private static new EventID[] GetSelfOnEventIDsExcludingBase() => default; // 0x00000001813F10F0-0x00000001813F11D0
	// [XID] // 0x0000000189BBD230-0x0000000189BBD250
	public override bool OnEvent(BaseEvent evt) => default; // 0x00000001813F1CE0-0x00000001813F1DC0
	// [XID] // 0x0000000189BC4DE0-0x0000000189BC4E00
	private void DoAttackAction() {} // 0x00000001813F1FF0-0x00000001813F2500
	// [XID] // 0x0000000189BCC980-0x0000000189BCC9A0
	public override void OnRemoved(RemoveAbilityReason removeReason) {} // 0x00000001813F0B70-0x00000001813F0C20
	// [XID] // 0x0000000189BD3F90-0x0000000189BD3FB0
	public void UpdateBaseReactionDamage(string abilityName, BaseEntity caster = null) {} // 0x00000001813F1420-0x00000001813F1610
	// [XID] // 0x0000000189BDB8F0-0x0000000189BDB910
	private void TrySyncBaseReactionDamage(uint sourceCasterID, uint reactionType, string abilityName) {} // 0x00000001813F17F0-0x00000001813F1A50
	[BlackList] // 0x00000001895E81D0-0x00000001895E8210
	// [XID] // 0x00000001895E81D0-0x00000001895E8210
	public override void AutoAllocTypeFields() {} // 0x00000001813F07F0-0x00000001813F0890
	[BlackList] // 0x00000001895F2800-0x00000001895F2840
	// [XID] // 0x00000001895F2800-0x00000001895F2840
	public override void AutoRecycleTypeFields() {} // 0x00000001813F0890-0x00000001813F0960
	[BlackList] // 0x00000001895FCFB0-0x00000001895FCFF0
	// [XID] // 0x00000001895FCFB0-0x00000001895FCFF0
	public override void ReturnToObjectPool() {} // 0x00000001813F2500-0x00000001813F25A0
}

