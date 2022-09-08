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

public sealed class AbilityExtendLifetimeByPickedGadgetMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14537
{
	// Fields
	private ExtendLifetimeByPickedGadgetMixin _config; // 0x70
	private LCTimer _lcTimer; // 0x78
	private float _extendedLifeTime; // 0x80
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	private HashSet<uint> _pickedGadgetConfigIDs; // 0x88

	// Constructors
	public AbilityExtendLifetimeByPickedGadgetMixin() {} // 0x00000001850A44F0-0x00000001850A4550

	// Methods
	// [XID] // 0x000000018964CA00-0x000000018964CA20
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x00000001850A3B50-0x00000001850A3DA0
	// [XID] // 0x0000000189653E30-0x0000000189653E50
	protected override void AddEventListener() {} // 0x00000001850A3890-0x00000001850A39C0
	// [XID] // 0x000000018965B7F0-0x000000018965B810
	protected override void RemoveEventListener() {} // 0x00000001850A4020-0x00000001850A4150
	// [XID] // 0x0000000189662BD0-0x0000000189662BF0
	public override void OnAdded(bool syncToServer) {} // 0x00000001850A3310-0x00000001850A33D0
	// [XID] // 0x000000018966A730-0x000000018966A750
	public override void OnRemoved(RemoveAbilityReason removeReason) {} // 0x00000001850A3AA0-0x00000001850A3B50
	// [XID] // 0x00000001896723D0-0x00000001896723F0
	private static new EventID[] GetSelfListenEventIDsExcludingBase() => default; // 0x00000001850A3EE0-0x00000001850A3FC0
	// [XID] // 0x0000000189679C80-0x0000000189679CA0
	public override bool ListenEvent(BaseEvent evt) => default; // 0x00000001850A41B0-0x00000001850A42B0
	// [XID] // 0x0000000189681340-0x0000000189681360
	private bool OnPickupGadget(EvtPickupGadget evt) => default; // 0x00000001850A33D0-0x00000001850A3650
	// [XID] // 0x0000000189688DC0-0x0000000189688DE0
	public override void Clear() {} // 0x00000001850A3E10-0x00000001850A3EE0
	[BlackList] // 0x0000000189690940-0x0000000189690980
	// [XID] // 0x0000000189690940-0x0000000189690980
	public override void AutoAllocTypeFields() {} // 0x00000001850A36E0-0x00000001850A37C0
	[BlackList] // 0x000000018969ACD0-0x000000018969AD10
	// [XID] // 0x000000018969ACD0-0x000000018969AD10
	public override void AutoRecycleTypeFields() {} // 0x00000001850A37C0-0x00000001850A3890
	[BlackList] // 0x00000001896A5030-0x00000001896A5070
	// [XID] // 0x00000001896A5030-0x00000001896A5070
	public override void ReturnToObjectPool() {} // 0x00000001850A4450-0x00000001850A44F0
}

