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

public sealed class AbilityBanEntityMarkMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14487
{
	// Fields
	private uint _lastBanAvatarId; // 0x70

	// Constructors
	public AbilityBanEntityMarkMixin() {} // 0x0000000182C36560-0x0000000182C365C0

	// Methods
	// [XID] // 0x0000000189739120-0x0000000189739140
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x0000000182C36020-0x0000000182C36110
	// [XID] // 0x0000000189740EE0-0x0000000189740F00
	public override void Clear() {} // 0x0000000182C36270-0x0000000182C36320
	// [XID] // 0x00000001897486F0-0x0000000189748710
	public override void OnAdded(bool syncToServer) {} // 0x0000000182C35AF0-0x0000000182C35BB0
	// [XID] // 0x000000018974FC90-0x000000018974FCB0
	public override void OnRemoved(RemoveAbilityReason removeReason) {} // 0x0000000182C35F60-0x0000000182C36020
	// [XID] // 0x0000000189757360-0x0000000189757380
	private void TryBanEntityMark() {} // 0x0000000182C35D90-0x0000000182C35F00
	// [XID] // 0x000000018975EAB0-0x000000018975EAD0
	private void TryUnbanEntityMark() {} // 0x0000000182C36110-0x0000000182C36200
	[BlackList] // 0x0000000189765F70-0x0000000189765FB0
	// [XID] // 0x0000000189765F70-0x0000000189765FB0
	public override void AutoAllocTypeFields() {} // 0x0000000182C35C40-0x0000000182C35CE0
	[BlackList] // 0x0000000189770670-0x00000001897706B0
	// [XID] // 0x0000000189770670-0x00000001897706B0
	public override void AutoRecycleTypeFields() {} // 0x0000000182C35CE0-0x0000000182C35D90
	[BlackList] // 0x000000018977ADF0-0x000000018977AE30
	// [XID] // 0x000000018977ADF0-0x000000018977AE30
	public override void ReturnToObjectPool() {} // 0x0000000182C364C0-0x0000000182C36560
}

