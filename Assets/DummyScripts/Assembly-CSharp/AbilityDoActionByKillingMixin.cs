/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AbilityDoActionByKillingMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14513
{
	// Fields
	private DoActionByKillingMixin _config; // 0x70
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	private Dictionary<uint, DateTime> _lastHitTime; // 0x78

	// Constructors
	public AbilityDoActionByKillingMixin() {} // 0x0000000182EE4030-0x0000000182EE4090

	// Methods
	// [XID] // 0x00000001898F5490-0x00000001898F54B0
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x0000000182EE3110-0x0000000182EE3250
	// [XID] // 0x00000001898FCBE0-0x00000001898FCC00
	public override void Clear() {} // 0x0000000182EE32C0-0x0000000182EE3390
	// [XID] // 0x00000001899045C0-0x00000001899045E0
	protected override void AddEventListener() {} // 0x0000000182EE2CF0-0x0000000182EE2DF0
	// [XID] // 0x000000018990BD80-0x000000018990BDA0
	protected override void RemoveEventListener() {} // 0x0000000182EE3860-0x0000000182EE3960
	// [XID] // 0x0000000189913760-0x0000000189913780
	public override void OnAdded(bool syncToServer) {} // 0x0000000182EE2A00-0x0000000182EE2AD0
	// [XID] // 0x000000018991B0A0-0x000000018991B0C0
	public override void OnRemoved(RemoveAbilityReason removeReason) {} // 0x0000000182EE3060-0x0000000182EE3110
	// [XID] // 0x00000001899226F0-0x0000000189922710
	private static new EventID[] GetSelfOnEventIDsExcludingBase() => default; // 0x0000000182EE3720-0x0000000182EE3800
	// [XID] // 0x0000000189929E00-0x0000000189929E20
	public override bool OnEvent(BaseEvent evt) => default; // 0x0000000182EE3E20-0x0000000182EE3F10
	// [XID] // 0x0000000189931550-0x0000000189931570
	private static new EventID[] GetSelfListenEventIDsExcludingBase() => default; // 0x0000000182EE3640-0x0000000182EE3720
	// [XID] // 0x0000000189938C20-0x0000000189938C40
	public override bool ListenEvent(BaseEvent evt) => default; // 0x0000000182EE3B90-0x0000000182EE3C80
	// [XID] // 0x0000000189940410-0x0000000189940430
	private bool OnHittingOther(EvtHittingOther evt) => default; // 0x0000000182EE2E50-0x0000000182EE2FE0
	// [XID] // 0x0000000189947A50-0x0000000189947A70
	private void OnHittingOtherSingle(uint attackeeID, AttackResult attackResult) {} // 0x0000000182EE39C0-0x0000000182EE3B90
	// [XID] // 0x000000018994F150-0x000000018994F170
	private bool OnKillingOther(EvtKill evt) => default; // 0x0000000182EE3390-0x0000000182EE3640
	[BlackList] // 0x00000001899566A0-0x00000001899566E0
	// [XID] // 0x00000001899566A0-0x00000001899566E0
	public override void AutoAllocTypeFields() {} // 0x0000000182EE2B60-0x0000000182EE2C30
	[BlackList] // 0x0000000189961150-0x0000000189961190
	// [XID] // 0x0000000189961150-0x0000000189961190
	public override void AutoRecycleTypeFields() {} // 0x0000000182EE2C30-0x0000000182EE2CF0
	[BlackList] // 0x000000018996B6B0-0x000000018996B6F0
	// [XID] // 0x000000018996B6B0-0x000000018996B6F0
	public override void ReturnToObjectPool() {} // 0x0000000182EE3F90-0x0000000182EE4030
}

