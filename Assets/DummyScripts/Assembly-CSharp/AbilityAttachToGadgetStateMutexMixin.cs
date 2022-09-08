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

public sealed class AbilityAttachToGadgetStateMutexMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14474
{
	// Fields
	private AttachToGadgetStateMutexMixin _config; // 0x70
	private int _curGadgetState; // 0x78

	// Constructors
	public AbilityAttachToGadgetStateMutexMixin() {} // 0x000000018415C6F0-0x000000018415C760

	// Methods
	// [XID] // 0x00000001897D1190-0x00000001897D11B0
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x000000018415B520-0x000000018415B7B0
	// [XID] // 0x00000001897D91B0-0x00000001897D91D0
	private static new EventID[] GetSelfOnEventIDsExcludingBase() => default; // 0x000000018415BBF0-0x000000018415BCD0
	// [XID] // 0x00000001897E0480-0x00000001897E04A0
	public override bool OnEvent(BaseEvent evt) => default; // 0x000000018415C4D0-0x000000018415C5D0
	// [XID] // 0x00000001897E7B50-0x00000001897E7B70
	public override void LazySetInstancedAbility(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x000000018415B200-0x000000018415B300
	// [XID] // 0x00000001897EF700-0x00000001897EF720
	public override void OnPostRecoverFromServer(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x000000018415B090-0x000000018415B1A0
	// [XID] // 0x00000001897F6DA0-0x00000001897F6DC0
	private void ClearRedundantModifiers() {} // 0x000000018415BCD0-0x000000018415BF10
	// [XID] // 0x00000001897FE3E0-0x00000001897FE400
	private void RemoveCurrentModifiers(RemoveAbilityReason removeReason = RemoveAbilityReason.Default /* Metadata: 0x00AEB76F */) {} // 0x000000018415C340-0x000000018415C4D0
	// [XID] // 0x0000000189805B50-0x0000000189805B70
	private int GetGadgetStateIndex(int gadgetState) => default; // 0x000000018415C0E0-0x000000018415C250
	// [XID] // 0x000000018980D3A0-0x000000018980D3C0
	private void CheckNeedAddModifiers() {} // 0x000000018415B940-0x000000018415BAD0
	// [XID] // 0x0000000189814A30-0x0000000189814A50
	public override void Clear() {} // 0x000000018415BB40-0x000000018415BBF0
	// [XID] // 0x000000018981C540-0x000000018981C560
	public override void OnAdded(bool syncToServer) {} // 0x000000018415ADE0-0x000000018415AEB0
	// [XID] // 0x0000000189823A80-0x0000000189823AA0
	public override void OnRemoved(RemoveAbilityReason removeReason) {} // 0x000000018415B450-0x000000018415B520
	// [XID] // 0x000000018982B3F0-0x000000018982B410
	private void OnStateChanged(EvtGadgetState evt) {} // 0x000000018415B300-0x000000018415B450
	// [XID] // 0x00000001898327D0-0x00000001898327F0
	private void TryApplyModifiers(string[] modifierNames) {} // 0x000000018415B7B0-0x000000018415B940
	[BlackList] // 0x0000000189839E30-0x0000000189839E70
	// [XID] // 0x0000000189839E30-0x0000000189839E70
	public override void AutoAllocTypeFields() {} // 0x000000018415AF40-0x000000018415AFE0
	[BlackList] // 0x00000001898446B0-0x00000001898446F0
	// [XID] // 0x00000001898446B0-0x00000001898446F0
	public override void AutoRecycleTypeFields() {} // 0x000000018415AFE0-0x000000018415B090
	[BlackList] // 0x000000018984EAE0-0x000000018984EB20
	// [XID] // 0x000000018984EAE0-0x000000018984EB20
	public override void ReturnToObjectPool() {} // 0x000000018415C650-0x000000018415C6F0
}

