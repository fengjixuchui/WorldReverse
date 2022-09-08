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

public sealed class AbilityHitLevelGaugeMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14543
{
	// Fields
	private HitLevelGaugeMixin _config; // 0x70
	private float _currentCharge; // 0x78
	private float _fadeTimeLeft; // 0x7C

	// Constructors
	public AbilityHitLevelGaugeMixin() {} // 0x000000018553D820-0x000000018553D880

	// Methods
	// [XID] // 0x00000001898A0D50-0x00000001898A0D70
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x000000018553CD40-0x000000018553CE80
	// [XID] // 0x00000001898A83A0-0x00000001898A83C0
	public override void OnAdded(bool syncToServer) {} // 0x000000018553C6C0-0x000000018553C780
	// [XID] // 0x00000001898AFF10-0x00000001898AFF30
	public override void OnRemoved(RemoveAbilityReason removeReason) {} // 0x000000018553CC80-0x000000018553CD40
	// [XID] // 0x00000001898B7370-0x00000001898B7390
	public override void OnEnable() {} // 0x000000018553CB70-0x000000018553CC20
	// [XID] // 0x00000001898BEB00-0x00000001898BEB20
	public override void OnDisable() {} // 0x000000018553C960-0x000000018553CA10
	// [XID] // 0x00000001898C63C0-0x00000001898C63E0
	public override void Clear() {} // 0x000000018553CF70-0x000000018553D020
	// [XID] // 0x00000001898CDAD0-0x00000001898CDAF0
	public override void Tick(float inDeltaTime) {} // 0x000000018553D6F0-0x000000018553D820
	// [XID] // 0x00000001898D54D0-0x00000001898D54F0
	private static new EventID[] GetSelfOnEventIDsExcludingBase() => default; // 0x000000018553D020-0x000000018553D100
	// [XID] // 0x00000001898DCE50-0x00000001898DCE70
	public override bool OnEvent(BaseEvent evt) => default; // 0x000000018553D4C0-0x000000018553D5D0
	// [XID] // 0x00000001898E4930-0x00000001898E4950
	private bool OnBeingHit(EvtBeingHit evt) => default; // 0x000000018553D100-0x000000018553D320
	// [XID] // 0x00000001898EC290-0x00000001898EC2B0
	private void ResetCharge() {} // 0x000000018553CA70-0x000000018553CB10
	[BlackList] // 0x00000001898F3BE0-0x00000001898F3C20
	// [XID] // 0x00000001898F3BE0-0x00000001898F3C20
	public override void AutoAllocTypeFields() {} // 0x000000018553C810-0x000000018553C8B0
	[BlackList] // 0x00000001898FE4E0-0x00000001898FE520
	// [XID] // 0x00000001898FE4E0-0x00000001898FE520
	public override void AutoRecycleTypeFields() {} // 0x000000018553C8B0-0x000000018553C960
	[BlackList] // 0x0000000189908D90-0x0000000189908DD0
	// [XID] // 0x0000000189908D90-0x0000000189908DD0
	public override void ReturnToObjectPool() {} // 0x000000018553D650-0x000000018553D6F0
}

