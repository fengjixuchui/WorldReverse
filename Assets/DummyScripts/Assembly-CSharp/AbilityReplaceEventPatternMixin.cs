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

public sealed class AbilityReplaceEventPatternMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14560
{
	// Fields
	private ReplaceEventPatternMixin _config; // 0x70
	private bool _hasResetEventPattern; // 0x78

	// Constructors
	public AbilityReplaceEventPatternMixin() {} // 0x0000000183AA51E0-0x0000000183AA5250

	// Methods
	// [XID] // 0x0000000189797410-0x0000000189797430
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x0000000183AA4C30-0x0000000183AA4D70
	// [XID] // 0x000000018979F310-0x000000018979F330
	public override void Clear() {} // 0x0000000183AA4DE0-0x0000000183AA4E90
	// [XID] // 0x00000001897A6960-0x00000001897A6980
	private void setEventPattern() {} // 0x0000000183AA45D0-0x0000000183AA47C0
	// [XID] // 0x00000001897AE0C0-0x00000001897AE0E0
	private void resetEventPattern() {} // 0x0000000183AA4970-0x0000000183AA4B70
	// [XID] // 0x00000001897B6170-0x00000001897B6190
	public override void OnAdded(bool syncToServer) {} // 0x0000000183AA4480-0x0000000183AA4540
	// [XID] // 0x00000001897BDF60-0x00000001897BDF80
	public override void OnRemoved(RemoveAbilityReason removeReason) {} // 0x0000000183AA4B70-0x0000000183AA4C30
	// [XID] // 0x00000001897C5560-0x00000001897C5580
	public override void OnBeforePoolRecycled() {} // 0x0000000183AA4FB0-0x0000000183AA5060
	[BlackList] // 0x00000001897CCB60-0x00000001897CCBA0
	// [XID] // 0x00000001897CCB60-0x00000001897CCBA0
	public override void AutoAllocTypeFields() {} // 0x0000000183AA47C0-0x0000000183AA4860
	[BlackList] // 0x00000001897D74B0-0x00000001897D74F0
	// [XID] // 0x00000001897D74B0-0x00000001897D74F0
	public override void AutoRecycleTypeFields() {} // 0x0000000183AA4860-0x0000000183AA4910
	[BlackList] // 0x00000001897E1C60-0x00000001897E1CA0
	// [XID] // 0x00000001897E1C60-0x00000001897E1CA0
	public override void ReturnToObjectPool() {} // 0x0000000183AA5140-0x0000000183AA51E0
}

