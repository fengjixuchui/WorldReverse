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

public sealed class AbilityTileComplexManagerMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14582
{
	// Fields
	private TileComplexManagerMixin _config; // 0x70
	private LevelTileAttackPlugin _tilePlugin; // 0x78
	private NormalTimer _normalTimer; // 0x80
	private const int MaxAttackeeNum = 128; // Metadata: 0x00AEB917
	private BaseEntity[] _attackees; // 0x88
	private Vector3[] _hitPoints; // 0x90
	private LCBaseCombat _lcAttackerCombat; // 0x98
	private LCAbility _lcAttackerAbility; // 0xA0

	// Constructors
	public AbilityTileComplexManagerMixin() {} // 0x0000000182BA73C0-0x0000000182BA7420

	// Methods
	// [XID] // 0x00000001899EB330-0x00000001899EB350
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x0000000182BA5AA0-0x0000000182BA5CA0
	// [XID] // 0x00000001899F2FC0-0x00000001899F2FE0
	public override void Clear() {} // 0x0000000182BA5D90-0x0000000182BA5E40
	// [XID] // 0x00000001899FA630-0x00000001899FA650
	protected override void AddEventListener() {} // 0x0000000182BA5710-0x0000000182BA5840
	// [XID] // 0x0000000189A01840-0x0000000189A01860
	protected override void RemoveEventListener() {} // 0x0000000182BA5FE0-0x0000000182BA6110
	// [XID] // 0x0000000189A09330-0x0000000189A09350
	public override void OnAdded(bool syncToServer) {} // 0x0000000182BA5440-0x0000000182BA5510
	// [XID] // 0x0000000189A107C0-0x0000000189A107E0
	public override void OnRemoved(RemoveAbilityReason removeReason) {} // 0x0000000182BA5920-0x0000000182BA59D0
	// [XID] // 0x0000000189A17E50-0x0000000189A17E70
	private static new EventID[] GetSelfListenEventIDsExcludingBase() => default; // 0x0000000182BA5E40-0x0000000182BA5F20
	// [XID] // 0x0000000189A1F3D0-0x0000000189A1F3F0
	public override bool ListenEvent(BaseEvent evt) => default; // 0x0000000182BA6480-0x0000000182BA6560
	// [XID] // 0x0000000189A26970-0x0000000189A26990
	public void UpdateGlobalValues() {} // 0x0000000182BA59D0-0x0000000182BA5AA0
	// [XID] // 0x0000000189A2DEA0-0x0000000189A2DEC0
	public override void Tick(float inDeltaTime) {} // 0x0000000182BA7240-0x0000000182BA73C0
	// [XID] // 0x0000000189A358C0-0x0000000189A358E0
	private void InitTileManager() {} // 0x0000000182BA6370-0x0000000182BA6480
	// [XID] // 0x0000000189A3CE70-0x0000000189A3CE90
	private void DoAttackAction() {} // 0x0000000182BA6C60-0x0000000182BA71A0
	// [XID] // 0x0000000189A44770-0x0000000189A44790
	public void UpdateBaseReactionDamage(string abilityName) {} // 0x0000000182BA6170-0x0000000182BA6370
	// [XID] // 0x0000000189A4BE50-0x0000000189A4BE70
	private void TrySyncBaseReactionDamage(uint sourceCasterID, uint reactionType, string abilityName) {} // 0x0000000182BA65C0-0x0000000182BA6820
	// [XID] // 0x0000000189A534F0-0x0000000189A53510
	public override void OnBeforePoolRecycled() {} // 0x0000000182BA68E0-0x0000000182BA6A30
	// [XID] // 0x0000000189A5AC80-0x0000000189A5ACA0
	public override void OnPoolAllocated() {} // 0x0000000182BA6A30-0x0000000182BA6B80
	[BlackList] // 0x0000000189A62460-0x0000000189A624A0
	// [XID] // 0x0000000189A62460-0x0000000189A624A0
	public override void AutoAllocTypeFields() {} // 0x0000000182BA55A0-0x0000000182BA5640
	[BlackList] // 0x0000000189A6CFB0-0x0000000189A6CFF0
	// [XID] // 0x0000000189A6CFB0-0x0000000189A6CFF0
	public override void AutoRecycleTypeFields() {} // 0x0000000182BA5640-0x0000000182BA5710
	[BlackList] // 0x0000000189A777C0-0x0000000189A77800
	// [XID] // 0x0000000189A777C0-0x0000000189A77800
	public override void ReturnToObjectPool() {} // 0x0000000182BA71A0-0x0000000182BA7240
}

