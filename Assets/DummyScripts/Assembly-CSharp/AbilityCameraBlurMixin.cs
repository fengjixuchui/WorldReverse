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

public sealed class AbilityCameraBlurMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14495
{
	// Fields
	private int _blurHandle; // 0x70
	private CameraBlurMixin _config; // 0x78

	// Constructors
	public AbilityCameraBlurMixin() {} // 0x0000000183667950-0x00000001836679C0

	// Methods
	// [XID] // 0x00000001899E5B10-0x00000001899E5B30
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x00000001836674A0-0x00000001836675E0
	// [XID] // 0x00000001899ECBE0-0x00000001899ECC00
	public override void Clear() {} // 0x0000000183667650-0x0000000183667710
	// [XID] // 0x00000001899F4900-0x00000001899F4920
	public override void OnAdded(bool syncToServer) {} // 0x0000000183666E80-0x00000001836670A0
	// [XID] // 0x00000001899FBF20-0x00000001899FBF40
	public override void OnRemoved(RemoveAbilityReason removeReason) {} // 0x00000001836673E0-0x00000001836674A0
	// [XID] // 0x0000000189A03330-0x0000000189A03350
	private void StopCurBlur() {} // 0x00000001836672E0-0x00000001836673E0
	[BlackList] // 0x0000000189A0A970-0x0000000189A0A9B0
	// [XID] // 0x0000000189A0A970-0x0000000189A0A9B0
	public override void AutoAllocTypeFields() {} // 0x0000000183667130-0x00000001836671D0
	[BlackList] // 0x0000000189A151E0-0x0000000189A15220
	// [XID] // 0x0000000189A151E0-0x0000000189A15220
	public override void AutoRecycleTypeFields() {} // 0x00000001836671D0-0x0000000183667280
	[BlackList] // 0x0000000189A1F450-0x0000000189A1F490
	// [XID] // 0x0000000189A1F450-0x0000000189A1F490
	public override void ReturnToObjectPool() {} // 0x00000001836678B0-0x0000000183667950
}

