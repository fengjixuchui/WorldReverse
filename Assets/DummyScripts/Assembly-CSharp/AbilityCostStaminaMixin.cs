/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AbilityCostStaminaMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14504
{
	// Fields
	private CostStaminaMixin config; // 0x70
	private AvatarEntity _avatar; // 0x78
	private VCHumanoidMoveData _moveData; // 0x80
	private bool _triggeredStaminaEmptyAction; // 0x88
	private const float INTERVAL_TIME = 0.3f; // Metadata: 0x00AEB7A1
	private float _cur_interval; // 0x8C

	// Constructors
	public AbilityCostStaminaMixin() {} // 0x000000018338F1A0-0x000000018338F210

	// Methods
	// [XID] // 0x0000000189BD3FB0-0x0000000189BD3FD0
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x000000018338E700-0x000000018338E8D0
	// [XID] // 0x0000000189BDB910-0x0000000189BDB930
	public override void Clear() {} // 0x000000018338E9C0-0x000000018338EA80
	// [XID] // 0x00000001895E8210-0x00000001895E8230
	public override void OnAdded(bool syncToServer) {} // 0x000000018338E330-0x000000018338E3F0
	// [XID] // 0x00000001895EFAC0-0x00000001895EFAE0
	public override void OnRemoved(RemoveAbilityReason removeReason) {} // 0x000000018338E640-0x000000018338E700
	// [XID] // 0x00000001895F74B0-0x00000001895F74D0
	public override void Tick(float inDeltaTime) {} // 0x000000018338EE50-0x000000018338F1A0
	// [XID] // 0x00000001895FE850-0x00000001895FE870
	private void OnStaminaEmpty() {} // 0x000000018338EB40-0x000000018338ECD0
	[BlackList] // 0x00000001896061F0-0x0000000189606230
	// [XID] // 0x00000001896061F0-0x0000000189606230
	public override void AutoAllocTypeFields() {} // 0x000000018338E480-0x000000018338E520
	[BlackList] // 0x0000000189610AA0-0x0000000189610AE0
	// [XID] // 0x0000000189610AA0-0x0000000189610AE0
	public override void AutoRecycleTypeFields() {} // 0x000000018338E520-0x000000018338E5E0
	[BlackList] // 0x000000018961B130-0x000000018961B170
	// [XID] // 0x000000018961B130-0x000000018961B170
	public override void ReturnToObjectPool() {} // 0x000000018338EDB0-0x000000018338EE50
}

