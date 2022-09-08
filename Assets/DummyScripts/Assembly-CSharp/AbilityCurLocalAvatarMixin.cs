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

public sealed class AbilityCurLocalAvatarMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14505
{
	// Fields
	private CurLocalAvatarMixin _config; // 0x70
	private bool _alreadyRemoved; // 0x78

	// Constructors
	public AbilityCurLocalAvatarMixin() {} // 0x00000001850B5150-0x00000001850B51C0

	// Methods
	// [XID] // 0x0000000189625650-0x0000000189625670
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x00000001850B3F60-0x00000001850B40A0
	// [XID] // 0x000000018962CE90-0x000000018962CEB0
	protected override void AddEventListener() {} // 0x00000001850B3A70-0x00000001850B3BF0
	// [XID] // 0x0000000189634A40-0x0000000189634A60
	protected override void RemoveEventListener() {} // 0x00000001850B42E0-0x00000001850B4460
	// [XID] // 0x000000018963C1A0-0x000000018963C1C0
	public override void OnAdded(bool syncToServer) {} // 0x00000001850B3750-0x00000001850B3890
	// [XID] // 0x0000000189643840-0x0000000189643860
	public override void OnRemoved(RemoveAbilityReason removeReason) {} // 0x00000001850B3E20-0x00000001850B3F60
	// [XID] // 0x000000018964AE00-0x000000018964AE20
	public override void Clear() {} // 0x00000001850B4110-0x00000001850B41B0
	// [XID] // 0x0000000189652640-0x0000000189652660
	private static new EventID[] GetSelfListenEventIDsExcludingBase() => default; // 0x00000001850B41B0-0x00000001850B4280
	// [XID] // 0x0000000189659DF0-0x0000000189659E10
	public override bool ListenEvent(BaseEvent evt) => default; // 0x00000001850B44C0-0x00000001850B4700
	// [XID] // 0x00000001896614E0-0x0000000189661500
	private bool OnAvatarChanged(EvtAvatarChanged evt) => default; // 0x00000001850B3C50-0x00000001850B3DA0
	// [XID] // 0x0000000189669070-0x0000000189669090
	private void TryApplyModifier(AvatarEntity avatar, bool syncToServer = true /* Metadata: 0x00AEB7A5 */) {} // 0x00000001850B4700-0x00000001850B4B70
	// [XID] // 0x0000000189670A20-0x0000000189670A40
	private void TryRemoveModifier(AvatarEntity avatar, RemoveAbilityReason removeReason = RemoveAbilityReason.Default /* Metadata: 0x00AEB7A6 */) {} // 0x00000001850B4C90-0x00000001850B5030
	[BlackList] // 0x0000000189678290-0x00000001896782D0
	// [XID] // 0x0000000189678290-0x00000001896782D0
	public override void AutoAllocTypeFields() {} // 0x00000001850B3920-0x00000001850B39C0
	[BlackList] // 0x0000000189682960-0x00000001896829A0
	// [XID] // 0x0000000189682960-0x00000001896829A0
	public override void AutoRecycleTypeFields() {} // 0x00000001850B39C0-0x00000001850B3A70
	[BlackList] // 0x000000018968D2D0-0x000000018968D310
	// [XID] // 0x000000018968D2D0-0x000000018968D310
	public override void ReturnToObjectPool() {} // 0x00000001850B50B0-0x00000001850B5150
}

