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

public sealed class AbilityAirFlowMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14458
{
	// Fields
	private AirFlowMixin _config; // 0x70
	private uint _airFlowRuntimeID; // 0x78

	// Constructors
	public AbilityAirFlowMixin() {} // 0x00000001829CBB60-0x00000001829CBBC0

	// Methods
	// [XID] // 0x00000001896E8E30-0x00000001896E8E50
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x00000001829CAE40-0x00000001829CAFC0
	// [XID] // 0x00000001896F0050-0x00000001896F0070
	private GadgetEntity CheckAirFlowEntity() => default; // 0x00000001829CB0E0-0x00000001829CB670
	// [XID] // 0x00000001896F7910-0x00000001896F7930
	public override void OnAdded(bool syncToServer) {} // 0x00000001829CA820-0x00000001829CAB40
	// [XID] // 0x00000001896FF3F0-0x00000001896FF410
	public override void OnRemoved(RemoveAbilityReason removeReason) {} // 0x00000001829CAD80-0x00000001829CAE40
	// [XID] // 0x00000001897067C0-0x00000001897067E0
	private void ClearData() {} // 0x00000001829CB790-0x00000001829CB930
	// [XID] // 0x000000018970E090-0x000000018970E0B0
	public override void Clear() {} // 0x00000001829CB030-0x00000001829CB0E0
	// [XID] // 0x00000001897154B0-0x00000001897154D0
	public override void OnBeforePoolRecycled() {} // 0x00000001829CB930-0x00000001829CB9E0
	[BlackList] // 0x000000018971D090-0x000000018971D0D0
	// [XID] // 0x000000018971D090-0x000000018971D0D0
	public override void AutoAllocTypeFields() {} // 0x00000001829CABD0-0x00000001829CAC70
	[BlackList] // 0x0000000189727700-0x0000000189727740
	// [XID] // 0x0000000189727700-0x0000000189727740
	public override void AutoRecycleTypeFields() {} // 0x00000001829CAC70-0x00000001829CAD20
	[BlackList] // 0x0000000189731B80-0x0000000189731BC0
	// [XID] // 0x0000000189731B80-0x0000000189731BC0
	public override void ReturnToObjectPool() {} // 0x00000001829CBAC0-0x00000001829CBB60
}

