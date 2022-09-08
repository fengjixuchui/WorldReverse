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

public sealed class AbilityOverrideStickElemUIMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14555
{
	// Fields
	private OverrideStickElemUIMixin config; // 0x70
	private VCBillboard vcBillboard; // 0x78

	// Constructors
	public AbilityOverrideStickElemUIMixin() {} // 0x00000001831866B0-0x0000000183186710

	// Methods
	// [XID] // 0x0000000189613880-0x00000001896138A0
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x0000000183185D20-0x0000000183185E80
	// [XID] // 0x000000018961B110-0x000000018961B130
	public override void Clear() {} // 0x0000000183185EF0-0x0000000183185FB0
	// [XID] // 0x0000000189622640-0x0000000189622660
	public override void OnBeforePoolRecycled() {} // 0x0000000183186480-0x0000000183186530
	// [XID] // 0x0000000189629FA0-0x0000000189629FC0
	public override void OnAdded(bool syncToServer) {} // 0x0000000183185890-0x0000000183185950
	// [XID] // 0x0000000189631780-0x00000001896317A0
	public override void OnRemoved(RemoveAbilityReason removeReason) {} // 0x0000000183185C60-0x0000000183185D20
	// [XID] // 0x0000000189639180-0x00000001896391A0
	private void AddElementOverride() {} // 0x0000000183186080-0x00000001831861F0
	// [XID] // 0x00000001896405A0-0x00000001896405C0
	private void RemoveElementOverride() {} // 0x00000001831862B0-0x0000000183186420
	// [XID] // 0x0000000189647F20-0x0000000189647F40
	private void DoAddElementOverride(VCElementReactionPlugin plugin) {} // 0x0000000183185B90-0x0000000183185C60
	// [XID] // 0x000000018964F5D0-0x000000018964F5F0
	private void DoRemoveElementOverride(VCElementReactionPlugin plugin) {} // 0x0000000183185FB0-0x0000000183186080
	[BlackList] // 0x0000000189656FA0-0x0000000189656FE0
	// [XID] // 0x0000000189656FA0-0x0000000189656FE0
	public override void AutoAllocTypeFields() {} // 0x00000001831859E0-0x0000000183185A80
	[BlackList] // 0x00000001896614A0-0x00000001896614E0
	// [XID] // 0x00000001896614A0-0x00000001896614E0
	public override void AutoRecycleTypeFields() {} // 0x0000000183185A80-0x0000000183185B30
	[BlackList] // 0x000000018966BAF0-0x000000018966BB30
	// [XID] // 0x000000018966BAF0-0x000000018966BB30
	public override void ReturnToObjectPool() {} // 0x0000000183186610-0x00000001831866B0
}

