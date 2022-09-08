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

public sealed class AbilityUrgentHotFixMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14596
{
	// Fields
	private UrgentHotFixMixin _config; // 0x70
	private float _timer; // 0x78

	// Constructors
	public AbilityUrgentHotFixMixin() {} // 0x0000000184A7E390-0x0000000184A7E400

	// Methods
	// [XID] // 0x00000001899AFAF0-0x00000001899AFB10
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x0000000184A7CED0-0x0000000184A7D010
	// [XID] // 0x00000001899B6FC0-0x00000001899B6FE0
	public override void Clear() {} // 0x0000000184A7D180-0x0000000184A7D240
	// [XID] // 0x00000001899BEA40-0x00000001899BEA60
	public override void OnAdded(bool syncToServer) {} // 0x0000000184A7C330-0x0000000184A7C3F0
	// [XID] // 0x00000001899C64A0-0x00000001899C64C0
	public override void OnRemoved(RemoveAbilityReason removeReason) {} // 0x0000000184A7CE10-0x0000000184A7CED0
	// [XID] // 0x00000001899CDA00-0x00000001899CDA20
	public override void Tick(float inDeltaTime) {} // 0x0000000184A7E1D0-0x0000000184A7E390
	// [XID] // 0x00000001899D4FC0-0x00000001899D4FE0
	public override void LazySetInstancedAbility(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x0000000184A7CB80-0x0000000184A7CC90
	// [XID] // 0x00000001899DC540-0x00000001899DC560
	public override void OnPostRecoverFromServer(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x0000000184A7C700-0x0000000184A7C810
	// [XID] // 0x00000001899E3DC0-0x00000001899E3DE0
	public override void OnAbilityTriggered(EvtAbilityStart evt) {} // 0x0000000184A7D8C0-0x0000000184A7D970
	// [XID] // 0x00000001899EB310-0x00000001899EB330
	private static new EventID[] GetSelfOnEventIDsExcludingBase() => default; // 0x0000000184A7D4F0-0x0000000184A7D5C0
	// [XID] // 0x00000001899F2FA0-0x00000001899F2FC0
	public override bool OnEvent(BaseEvent evt) => default; // 0x0000000184A7DF30-0x0000000184A7DFE0
	// [XID] // 0x00000001899FA610-0x00000001899FA630
	private static new EventID[] GetSelfOnEventRemoteIDsExcludingBase() => default; // 0x0000000184A7D5C0-0x0000000184A7D6A0
	// [XID] // 0x0000000189A01820-0x0000000189A01840
	public override bool OnEventRemote(BaseEvent evt) => default; // 0x0000000184A7DDD0-0x0000000184A7DE80
	// [XID] // 0x0000000189A09310-0x0000000189A09330
	private static new EventID[] GetSelfOnEventResolvedIDsExcludingBase() => default; // 0x0000000184A7D6A0-0x0000000184A7D780
	// [XID] // 0x0000000189A107A0-0x0000000189A107C0
	public override bool OnEventResolved(BaseEvent evt) => default; // 0x0000000184A7DE80-0x0000000184A7DF30
	// [XID] // 0x0000000189A17E30-0x0000000189A17E50
	private static new EventID[] GetSelfListenEventIDsExcludingBase() => default; // 0x0000000184A7D420-0x0000000184A7D4F0
	// [XID] // 0x0000000189A1F3B0-0x0000000189A1F3D0
	public override bool ListenEvent(BaseEvent evt) => default; // 0x0000000184A7D970-0x0000000184A7DA20
	// [XID] // 0x0000000189A26950-0x0000000189A26970
	public override void OnEnable() {} // 0x0000000184A7CC90-0x0000000184A7CD30
	// [XID] // 0x0000000189A2DE80-0x0000000189A2DEA0
	public override void OnDisable() {} // 0x0000000184A7C8B0-0x0000000184A7C950
	// [XID] // 0x0000000189A358A0-0x0000000189A358C0
	public override void Retarget(uint oldEntityRuntimeID, uint entityRuntimeID) {} // 0x0000000184A7D360-0x0000000184A7D420
	// [XID] // 0x0000000189A3CE50-0x0000000189A3CE70
	public override void OnRefresh() {} // 0x0000000184A7C9B0-0x0000000184A7CA50
	// [XID] // 0x0000000189A44750-0x0000000189A44770
	private void HotFixInit() {} // 0x0000000184A7C810-0x0000000184A7C8B0
	// [XID] // 0x0000000189A4BE30-0x0000000189A4BE50
	private void HotFixClear() {} // 0x0000000184A7D2C0-0x0000000184A7D360
	// [XID] // 0x0000000189A534D0-0x0000000189A534F0
	private void HotFixOnAdded(bool syncToServer) {} // 0x0000000184A7DB90-0x0000000184A7DC40
	// [XID] // 0x0000000189A5AC60-0x0000000189A5AC80
	private void HotFixOnRemoved(RemoveAbilityReason removeReaso) {} // 0x0000000184A7C5D0-0x0000000184A7C680
	// [XID] // 0x0000000189A62440-0x0000000189A62460
	private void HotFixOnThinkInterval() {} // 0x0000000184A7DC40-0x0000000184A7DCE0
	// [XID] // 0x0000000189A6A300-0x0000000189A6A320
	private void HotFixLazySetInstancedAbility(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x0000000184A7CA50-0x0000000184A7CB20
	// [XID] // 0x0000000189A716D0-0x0000000189A716F0
	private void HotFixOnPostRecoverFromServer(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x0000000184A7E060-0x0000000184A7E130
	[BlackList] // 0x0000000189A79190-0x0000000189A791D0
	// [XID] // 0x0000000189A79190-0x0000000189A791D0
	public override void AutoAllocTypeFields() {} // 0x0000000184A7C480-0x0000000184A7C520
	[BlackList] // 0x0000000189A83B80-0x0000000189A83BC0
	// [XID] // 0x0000000189A83B80-0x0000000189A83BC0
	public override void AutoRecycleTypeFields() {} // 0x0000000184A7C520-0x0000000184A7C5D0
	[BlackList] // 0x0000000189A8E4D0-0x0000000189A8E510
	// [XID] // 0x0000000189A8E4D0-0x0000000189A8E510
	public override void ReturnToObjectPool() {} // 0x0000000184A7E130-0x0000000184A7E1D0
}

