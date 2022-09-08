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

public sealed class AbilityAttachToPlayStageMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14477
{
	// Fields
	private AttachToPlayStageMixin _config; // 0x70

	// Constructors
	public AbilityAttachToPlayStageMixin() {} // 0x00000001819A31B0-0x00000001819A3210

	// Methods
	// [XID] // 0x000000018996FE80-0x000000018996FEA0
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x00000001819A2940-0x00000001819A2A80
	// [XID] // 0x0000000189977C70-0x0000000189977C90
	public override void Clear() {} // 0x00000001819A2AF0-0x00000001819A2BA0
	// [XID] // 0x000000018997EE90-0x000000018997EEB0
	public override void OnAdded(bool syncToServer) {} // 0x00000001819A2590-0x00000001819A2650
	// [XID] // 0x0000000189986790-0x00000001899867B0
	private static new EventID[] GetSelfOnEventIDsExcludingBase() => default; // 0x00000001819A2BA0-0x00000001819A2C80
	// [XID] // 0x000000018998E390-0x000000018998E3B0
	public override bool OnEvent(BaseEvent evt) => default; // 0x00000001819A2E20-0x00000001819A2F10
	// [XID] // 0x0000000189995EC0-0x0000000189995EE0
	private bool OnEvtPlayStageChange(EvtPlayStageChange evt) => default; // 0x00000001819A2F90-0x00000001819A3110
	// [XID] // 0x000000018999D940-0x000000018999D960
	public override void OnRemoved(RemoveAbilityReason removeReason) {} // 0x00000001819A2890-0x00000001819A2940
	[BlackList] // 0x00000001899A5240-0x00000001899A5280
	// [XID] // 0x00000001899A5240-0x00000001899A5280
	public override void AutoAllocTypeFields() {} // 0x00000001819A26E0-0x00000001819A2780
	[BlackList] // 0x00000001899AFB50-0x00000001899AFB90
	// [XID] // 0x00000001899AFB50-0x00000001899AFB90
	public override void AutoRecycleTypeFields() {} // 0x00000001819A2780-0x00000001819A2830
	[BlackList] // 0x00000001899B9FB0-0x00000001899B9FF0
	// [XID] // 0x00000001899B9FB0-0x00000001899B9FF0
	public override void ReturnToObjectPool() {} // 0x00000001819A3110-0x00000001819A31B0
}

