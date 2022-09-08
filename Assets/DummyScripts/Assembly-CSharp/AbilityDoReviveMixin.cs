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

public sealed class AbilityDoReviveMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14518
{
	// Fields
	private DoReviveMixin config; // 0x70

	// Constructors
	public AbilityDoReviveMixin() {} // 0x0000000184C2A400-0x0000000184C2A460

	// Methods
	// [XID] // 0x0000000189B09980-0x0000000189B099A0
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x0000000184C29830-0x0000000184C29970
	// [XID] // 0x0000000189B11400-0x0000000189B11420
	public override void Clear() {} // 0x0000000184C299E0-0x0000000184C29A90
	// [XID] // 0x0000000189B18650-0x0000000189B18670
	private static new EventID[] GetSelfListenEventIDsExcludingBase() => default; // 0x0000000184C29A90-0x0000000184C29B90
	// [XID] // 0x0000000189B1FD10-0x0000000189B1FD30
	public override bool ListenEvent(BaseEvent evt) => default; // 0x0000000184C29DE0-0x0000000184C2A1C0
	// [XID] // 0x0000000189B27460-0x0000000189B27480
	protected override void AddEventListener() {} // 0x0000000184C29510-0x0000000184C296A0
	// [XID] // 0x0000000189B2E640-0x0000000189B2E660
	protected override void RemoveEventListener() {} // 0x0000000184C29BF0-0x0000000184C29D80
	// [XID] // 0x0000000189B35CF0-0x0000000189B35D10
	public override void OnAdded(bool syncToServer) {} // 0x0000000184C29270-0x0000000184C29330
	// [XID] // 0x0000000189B3D420-0x0000000189B3D440
	public override void OnRemoved(RemoveAbilityReason removeReason) {} // 0x0000000184C29780-0x0000000184C29830
	[BlackList] // 0x0000000189B452A0-0x0000000189B452E0
	// [XID] // 0x0000000189B452A0-0x0000000189B452E0
	public override void AutoAllocTypeFields() {} // 0x0000000184C293C0-0x0000000184C29460
	[BlackList] // 0x0000000189B4F970-0x0000000189B4F9B0
	// [XID] // 0x0000000189B4F970-0x0000000189B4F9B0
	public override void AutoRecycleTypeFields() {} // 0x0000000184C29460-0x0000000184C29510
	[BlackList] // 0x0000000189B5A160-0x0000000189B5A1A0
	// [XID] // 0x0000000189B5A160-0x0000000189B5A1A0
	public override void ReturnToObjectPool() {} // 0x0000000184C2A360-0x0000000184C2A400
}

