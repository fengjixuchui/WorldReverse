/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AbilityAttachToAnimatorStateIDMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14470
{
	// Fields
	private AttachToAnimatorStateIDMixin config; // 0x70
	private AnimatorStateInfo fromState; // 0x78
	private AnimatorStateInfo toState; // 0x9C

	// Constructors
	public AbilityAttachToAnimatorStateIDMixin() {} // 0x00000001818B2060-0x00000001818B20C0

	// Methods
	// [XID] // 0x00000001895FB920-0x00000001895FB940
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x00000001818B0F30-0x00000001818B1070
	// [XID] // 0x00000001896030C0-0x00000001896030E0
	public override void LazySetInstancedAbility(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x00000001818B0D10-0x00000001818B0E10
	// [XID] // 0x000000018960AAE0-0x000000018960AB00
	public override void OnPostRecoverFromServer(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x00000001818B0BA0-0x00000001818B0CB0
	// [XID] // 0x0000000189612090-0x00000001896120B0
	private void ClearRedundantModifiers() {} // 0x00000001818B1330-0x00000001818B1530
	// [XID] // 0x0000000189619A10-0x0000000189619A30
	private void CheckNeedAddModifiers() {} // 0x00000001818B1070-0x00000001818B1210
	// [XID] // 0x0000000189620EB0-0x0000000189620ED0
	public override void Clear() {} // 0x00000001818B1280-0x00000001818B1330
	// [XID] // 0x0000000189628640-0x0000000189628660
	protected override void AddEventListener() {} // 0x00000001818B0A90-0x00000001818B0BA0
	// [XID] // 0x000000018962FF30-0x000000018962FF50
	protected override void RemoveEventListener() {} // 0x00000001818B1590-0x00000001818B16A0
	// [XID] // 0x0000000189637C20-0x0000000189637C40
	public override void OnAdded(bool syncToServer) {} // 0x00000001818B0720-0x00000001818B07E0
	// [XID] // 0x000000018963EE50-0x000000018963EE70
	private void OnAnimatorStateChanged(EvtAnimatorStateChanged evt) {} // 0x00000001818B1700-0x00000001818B1940
	// [XID] // 0x0000000189646760-0x0000000189646780
	public override void OnRemoved(RemoveAbilityReason removeReason) {} // 0x00000001818B0E10-0x00000001818B0F30
	// [XID] // 0x000000018964DF00-0x000000018964DF20
	private void TryApplyModifier() {} // 0x00000001818B19D0-0x00000001818B1B60
	// [XID] // 0x00000001896557B0-0x00000001896557D0
	public override string ToString() => default; // 0x00000001818B1E30-0x00000001818B2060
	[BlackList] // 0x000000018965CF80-0x000000018965CFC0
	// [XID] // 0x000000018965CF80-0x000000018965CFC0
	public override void AutoAllocTypeFields() {} // 0x00000001818B0870-0x00000001818B0910
	[BlackList] // 0x00000001896677A0-0x00000001896677E0
	// [XID] // 0x00000001896677A0-0x00000001896677E0
	public override void AutoRecycleTypeFields() {} // 0x00000001818B0910-0x00000001818B0A20
	[BlackList] // 0x00000001896723F0-0x0000000189672430
	// [XID] // 0x00000001896723F0-0x0000000189672430
	public override void ReturnToObjectPool() {} // 0x00000001818B1D90-0x00000001818B1E30
}

