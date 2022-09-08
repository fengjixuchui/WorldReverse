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

public sealed class AbilityRejectAttackMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14558
{
	// Fields
	private RejectAttackMixin config; // 0x70
	private float lastTime; // 0x78

	// Constructors
	public AbilityRejectAttackMixin() {} // 0x00000001854653F0-0x0000000185465460

	// Methods
	// [XID] // 0x000000018970E070-0x000000018970E090
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x0000000185464A50-0x0000000185464B90
	// [XID] // 0x0000000189715490-0x00000001897154B0
	private static new EventID[] GetSelfOnEventIDsExcludingBase() => default; // 0x0000000185464C40-0x0000000185464D20
	// [XID] // 0x000000018971D030-0x000000018971D050
	public override bool OnEvent(BaseEvent evt) => default; // 0x0000000185465270-0x0000000185465350
	// [XID] // 0x0000000189724410-0x0000000189724430
	private static new EventID[] GetSelfOnEventRemoteIDsExcludingBase() => default; // 0x0000000185464D20-0x0000000185464E00
	// [XID] // 0x000000018972BA60-0x000000018972BA80
	public override bool OnEventRemote(BaseEvent evt) => default; // 0x0000000185465190-0x0000000185465270
	// [XID] // 0x0000000189733270-0x0000000189733290
	private bool HandleEvent(BaseEvent evt) => default; // 0x0000000185464E60-0x0000000185465050
	// [XID] // 0x000000018973AAD0-0x000000018973AAF0
	public override void Clear() {} // 0x0000000185464B90-0x0000000185464C40
	[BlackList] // 0x0000000189742260-0x00000001897422A0
	// [XID] // 0x0000000189742260-0x00000001897422A0
	public override void AutoAllocTypeFields() {} // 0x0000000185464820-0x00000001854648C0
	[BlackList] // 0x000000018974CF10-0x000000018974CF50
	// [XID] // 0x000000018974CF10-0x000000018974CF50
	public override void AutoRecycleTypeFields() {} // 0x00000001854648C0-0x0000000185464970
	[BlackList] // 0x00000001897572E0-0x0000000189757320
	// [XID] // 0x00000001897572E0-0x0000000189757320
	public override void ReturnToObjectPool() {} // 0x0000000185465350-0x00000001854653F0
}

