/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using UnityEngine;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AbilityDoActionByTeamStatusMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14516
{
	// Fields
	private DoActionByTeamStatusMixin config; // 0x70
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	private List<Coroutine> _doActionCoroutines; // 0x78

	// Constructors
	public AbilityDoActionByTeamStatusMixin() {} // 0x00000001827A1510-0x00000001827A1570

	// Methods
	// [XID] // 0x0000000189A4A610-0x0000000189A4A630
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x00000001827A09E0-0x00000001827A0B20
	// [XID] // 0x0000000189A51E40-0x0000000189A51E60
	public override void OnBeforePoolRecycled() {} // 0x00000001827A12E0-0x00000001827A1390
	// [XID] // 0x0000000189A59730-0x0000000189A59750
	public override void Clear() {} // 0x00000001827A0B90-0x00000001827A0C50
	// [XID] // 0x0000000189A60F70-0x0000000189A60F90
	protected override void AddEventListener() {} // 0x00000001827A0730-0x00000001827A08C0
	// [XID] // 0x0000000189A68DB0-0x0000000189A68DD0
	protected override void RemoveEventListener() {} // 0x00000001827A0DF0-0x00000001827A0F80
	// [XID] // 0x0000000189A70040-0x0000000189A70060
	public override void OnAdded(bool syncToServer) {} // 0x00000001827A0250-0x00000001827A0320
	// [XID] // 0x0000000189A77820-0x0000000189A77840
	public override void OnRemoved(RemoveAbilityReason removeReason) {} // 0x00000001827A0920-0x00000001827A09E0
	// [IDTag] // 0x0000000189A7EF00-0x0000000189A7EF40
	// [XID] // 0x0000000189A7EF00-0x0000000189A7EF40
	private void StartCoroutine() {} // 0x00000001827A0470-0x00000001827A0510
	// [IDTag] // 0x0000000189A89B60-0x0000000189A89BA0
	// [XID] // 0x0000000189A89B60-0x0000000189A89BA0
	private void StartCoroutine(bool syncToServer) {} // 0x00000001827A0320-0x00000001827A0470
	// [XID] // 0x0000000189A94070-0x0000000189A94090
	private void ClearCoroutines() {} // 0x00000001827A0FE0-0x00000001827A11C0
	[DebuggerHidden] // 0x0000000189A9BA40-0x0000000189A9BA80
	// [XID] // 0x0000000189A9BA40-0x0000000189A9BA80
	private IEnumerator DoActionWhenAllTeamAvatarsReady(int index, bool syncToServer) => default; // 0x00000001827A0CB0-0x00000001827A0DF0
	[BlackList] // 0x0000000189AA6060-0x0000000189AA60A0
	// [XID] // 0x0000000189AA6060-0x0000000189AA60A0
	public override void AutoAllocTypeFields() {} // 0x00000001827A05A0-0x00000001827A0670
	[BlackList] // 0x0000000189AB0910-0x0000000189AB0950
	// [XID] // 0x0000000189AB0910-0x0000000189AB0950
	public override void AutoRecycleTypeFields() {} // 0x00000001827A0670-0x00000001827A0730
	[BlackList] // 0x0000000189ABB5F0-0x0000000189ABB630
	// [XID] // 0x0000000189ABB5F0-0x0000000189ABB630
	public override void ReturnToObjectPool() {} // 0x00000001827A1470-0x00000001827A1510
}

