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

public sealed class AbilityAttachToDayNightMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14471
{
	// Fields
	private AttachToDayNightMixin _config; // 0x70

	// Constructors
	public AbilityAttachToDayNightMixin() {} // 0x0000000182559060-0x00000001825590C0

	// Methods
	// [XID] // 0x000000018967CAA0-0x000000018967CAC0
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x00000001825584D0-0x0000000182558610
	// [XID] // 0x00000001896840C0-0x00000001896840E0
	public override void LazySetInstancedAbility(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x00000001825581D0-0x00000001825582D0
	// [XID] // 0x000000018968BD70-0x000000018968BD90
	public override void OnPostRecoverFromServer(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x0000000182557F40-0x0000000182558050
	// [XID] // 0x00000001896938B0-0x00000001896938D0
	protected override void AddEventListener() {} // 0x0000000182557E20-0x0000000182557F40
	// [XID] // 0x000000018969AD30-0x000000018969AD50
	protected override void RemoveEventListener() {} // 0x00000001825589F0-0x0000000182558B10
	// [XID] // 0x00000001896A27C0-0x00000001896A27E0
	public override void OnAdded(bool syncToServer) {} // 0x0000000182557B70-0x0000000182557C40
	// [XID] // 0x00000001896A9980-0x00000001896A99A0
	public override void OnRemoved(RemoveAbilityReason removeReason) {} // 0x00000001825583B0-0x00000001825584D0
	// [XID] // 0x00000001896B0940-0x00000001896B0960
	private void ClearRedundantModifiers() {} // 0x0000000182558830-0x0000000182558990
	// [XID] // 0x00000001896B8410-0x00000001896B8430
	private void CheckNeedAddModifiers() {} // 0x0000000182558610-0x0000000182558710
	// [XID] // 0x00000001896BF4C0-0x00000001896BF4E0
	private void TryApplyModifier() {} // 0x0000000182558C00-0x0000000182558D90
	// [XID] // 0x00000001896C6E50-0x00000001896C6E70
	public override void Clear() {} // 0x0000000182558780-0x0000000182558830
	// [XID] // 0x00000001896CE4E0-0x00000001896CE500
	private void OnHourPassed(int hour) {} // 0x0000000182558050-0x0000000182558170
	// [XID] // 0x00000001896D59D0-0x00000001896D59F0
	private bool IsInTimeRange(int hour) => default; // 0x00000001825582D0-0x00000001825583B0
	[BlackList] // 0x00000001896DCEB0-0x00000001896DCEF0
	// [XID] // 0x00000001896DCEB0-0x00000001896DCEF0
	public override void AutoAllocTypeFields() {} // 0x0000000182557CD0-0x0000000182557D70
	[BlackList] // 0x00000001896E74E0-0x00000001896E7520
	// [XID] // 0x00000001896E74E0-0x00000001896E7520
	public override void AutoRecycleTypeFields() {} // 0x0000000182557D70-0x0000000182557E20
	[BlackList] // 0x00000001896F1550-0x00000001896F1590
	// [XID] // 0x00000001896F1550-0x00000001896F1590
	public override void ReturnToObjectPool() {} // 0x0000000182558FC0-0x0000000182559060
}

