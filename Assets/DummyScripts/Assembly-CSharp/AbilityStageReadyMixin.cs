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

public sealed class AbilityStageReadyMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14574
{
	// Fields
	private StageReadyMixin _config; // 0x70

	// Constructors
	public AbilityStageReadyMixin() {} // 0x000000018397A300-0x000000018397A370

	// Methods
	// [XID] // 0x0000000189BB4530-0x0000000189BB4550
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x00000001839799A0-0x0000000183979AE0
	// [XID] // 0x0000000189BBBB30-0x0000000189BBBB50
	private static new EventID[] GetSelfListenEventIDsExcludingBase() => default; // 0x0000000183979BF0-0x0000000183979CD0
	// [XID] // 0x0000000189BC3990-0x0000000189BC39B0
	public override bool ListenEvent(BaseEvent evt) => default; // 0x0000000183979EC0-0x000000018397A0C0
	// [XID] // 0x0000000189BCB1A0-0x0000000189BCB1C0
	protected override void AddEventListener() {} // 0x00000001839796E0-0x0000000183979810
	// [XID] // 0x0000000189BD2790-0x0000000189BD27B0
	protected override void RemoveEventListener() {} // 0x0000000183979D30-0x0000000183979E60
	// [XID] // 0x0000000189BD9D10-0x0000000189BD9D30
	public override void OnAdded(bool syncToServer) {} // 0x0000000183979440-0x0000000183979500
	// [XID] // 0x00000001895E67D0-0x00000001895E67F0
	public override void OnRemoved(RemoveAbilityReason removeReason) {} // 0x00000001839798F0-0x00000001839799A0
	// [XID] // 0x00000001895EE330-0x00000001895EE350
	public override void Clear() {} // 0x0000000183979B50-0x0000000183979BF0
	[BlackList] // 0x00000001895F5AB0-0x00000001895F5AF0
	// [XID] // 0x00000001895F5AB0-0x00000001895F5AF0
	public override void AutoAllocTypeFields() {} // 0x0000000183979590-0x0000000183979630
	[BlackList] // 0x0000000189600070-0x00000001896000B0
	// [XID] // 0x0000000189600070-0x00000001896000B0
	public override void AutoRecycleTypeFields() {} // 0x0000000183979630-0x00000001839796E0
	[BlackList] // 0x000000018960AAA0-0x000000018960AAE0
	// [XID] // 0x000000018960AAA0-0x000000018960AAE0
	public override void ReturnToObjectPool() {} // 0x000000018397A260-0x000000018397A300
}

