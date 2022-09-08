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

public sealed class AbilityTriggerRageSupportMixin : AbilityTriggerTypeSupportMixin, IAutoAllocRecycle // TypeDefIndex: 14591
{
	// Fields
	private TriggerRageSupportMixin config; // 0x98
	private bool canNotBeTrigger; // 0xA0
	private TeamValue _teamValue; // 0xA8

	// Constructors
	public AbilityTriggerRageSupportMixin() {} // 0x00000001848BC330-0x00000001848BC3A0

	// Methods
	// [XID] // 0x00000001898149F0-0x0000000189814A10
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x00000001848BB820-0x00000001848BB9A0
	// [XID] // 0x000000018981C500-0x000000018981C520
	public override void Clear() {} // 0x00000001848BBA90-0x00000001848BBB50
	// [XID] // 0x0000000189823A40-0x0000000189823A60
	private static new EventID[] GetSelfListenEventIDsExcludingBase() => default; // 0x00000001848BBB50-0x00000001848BBC30
	// [XID] // 0x000000018982B370-0x000000018982B390
	public override bool ListenEvent(BaseEvent evt) => default; // 0x00000001848BBE00-0x00000001848BBF10
	// [XID] // 0x0000000189832770-0x0000000189832790
	private bool OnFlag(EvtFlag evt) => default; // 0x00000001848BBF70-0x00000001848BC050
	// [XID] // 0x0000000189839DD0-0x0000000189839DF0
	public override void Tick(float inDeltaTime) {} // 0x00000001848BC230-0x00000001848BC330
	// [XID] // 0x0000000189841380-0x00000001898413A0
	protected override void AddEventListener() {} // 0x00000001848BB540-0x00000001848BB650
	// [XID] // 0x0000000189848840-0x0000000189848860
	protected override void RemoveEventListener() {} // 0x00000001848BBC90-0x00000001848BBDA0
	// [XID] // 0x00000001898500E0-0x0000000189850100
	public override void OnAdded(bool syncToServer) {} // 0x00000001848BB1A0-0x00000001848BB350
	// [XID] // 0x0000000189857360-0x0000000189857380
	public override void OnRemoved(RemoveAbilityReason removeReason) {} // 0x00000001848BB730-0x00000001848BB820
	[BlackList] // 0x000000018985E520-0x000000018985E560
	// [XID] // 0x000000018985E520-0x000000018985E560
	public override void AutoAllocTypeFields() {} // 0x00000001848BB3E0-0x00000001848BB480
	[BlackList] // 0x0000000189869030-0x0000000189869070
	// [XID] // 0x0000000189869030-0x0000000189869070
	public override void AutoRecycleTypeFields() {} // 0x00000001848BB480-0x00000001848BB540
	[BlackList] // 0x0000000189873390-0x00000001898733D0
	// [XID] // 0x0000000189873390-0x00000001898733D0
	public override void ReturnToObjectPool() {} // 0x00000001848BC190-0x00000001848BC230
}

