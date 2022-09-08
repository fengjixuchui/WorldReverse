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

public sealed class AbilityPlayerUidNotifyMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14556
{
	// Fields
	private PlayerUidNotifyMixin _config; // 0x70

	// Constructors
	public AbilityPlayerUidNotifyMixin() {} // 0x00000001825ACD30-0x00000001825ACD90

	// Methods
	// [XID] // 0x0000000189676910-0x0000000189676930
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x00000001825AC400-0x00000001825AC540
	// [XID] // 0x000000018967E160-0x000000018967E180
	public override void Clear() {} // 0x00000001825AC5B0-0x00000001825AC660
	// [XID] // 0x0000000189685970-0x0000000189685990
	public override void OnAdded(bool syncToServer) {} // 0x00000001825AC050-0x00000001825AC110
	// [XID] // 0x000000018968D2B0-0x000000018968D2D0
	private static new EventID[] GetSelfOnEventIDsExcludingBase() => default; // 0x00000001825AC660-0x00000001825AC740
	// [XID] // 0x0000000189694EC0-0x0000000189694EE0
	public override bool OnEvent(BaseEvent evt) => default; // 0x00000001825ACB20-0x00000001825ACC10
	// [XID] // 0x000000018969C610-0x000000018969C630
	private bool OnEvtPlayUidChange(EvtPlayUidChange evt) => default; // 0x00000001825AC8E0-0x00000001825ACB20
	// [XID] // 0x00000001896A3BB0-0x00000001896A3BD0
	public override void OnRemoved(RemoveAbilityReason removeReason) {} // 0x00000001825AC350-0x00000001825AC400
	[BlackList] // 0x00000001896AAF40-0x00000001896AAF80
	// [XID] // 0x00000001896AAF40-0x00000001896AAF80
	public override void AutoAllocTypeFields() {} // 0x00000001825AC1A0-0x00000001825AC240
	[BlackList] // 0x00000001896B5520-0x00000001896B5560
	// [XID] // 0x00000001896B5520-0x00000001896B5560
	public override void AutoRecycleTypeFields() {} // 0x00000001825AC240-0x00000001825AC2F0
	[BlackList] // 0x00000001896BF480-0x00000001896BF4C0
	// [XID] // 0x00000001896BF480-0x00000001896BF4C0
	public override void ReturnToObjectPool() {} // 0x00000001825ACC90-0x00000001825ACD30
}

