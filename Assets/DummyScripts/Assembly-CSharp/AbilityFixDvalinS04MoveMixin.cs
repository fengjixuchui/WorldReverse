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

public sealed class AbilityFixDvalinS04MoveMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14539
{
	// Fields
	private Vector3 _selfPoint; // 0x70
	private Vector3 _tarPoint; // 0x7C
	private MoveSmoothedSpeedPlugin _smoothedSpeed; // 0x88
	private VCAnimatorMove _vcMove; // 0x90
	public static Vector3 Center; // 0x00
	private MonoTestDvalinS04 _stage; // 0x98

	// Constructors
	public AbilityFixDvalinS04MoveMixin() {} // 0x00000001837006B0-0x0000000183700720
	static AbilityFixDvalinS04MoveMixin() {} // 0x0000000183700610-0x00000001837006B0

	// Methods
	// [XID] // 0x00000001897276C0-0x00000001897276E0
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x00000001836FF9C0-0x00000001836FFDC0
	// [XID] // 0x000000018972EB70-0x000000018972EB90
	public override void OnAbilityTriggered(EvtAbilityStart evt) {} // 0x00000001836FFFC0-0x0000000183700220
	// [XID] // 0x00000001897362E0-0x0000000189736300
	public override void Clear() {} // 0x00000001836FFE40-0x00000001836FFEE0
	// [XID] // 0x000000018973E180-0x000000018973E1A0
	public override void Tick(float inDeltaTime) {} // 0x0000000183700380-0x0000000183700610
	// [XID] // 0x0000000189745470-0x0000000189745490
	private void UpdateSetSpeed(Vector3 tarPoint) {} // 0x00000001836FF6E0-0x00000001836FF9C0
	[BlackList] // 0x000000018974CF50-0x000000018974CF90
	// [XID] // 0x000000018974CF50-0x000000018974CF90
	public override void AutoAllocTypeFields() {} // 0x00000001836FF4F0-0x00000001836FF590
	[BlackList] // 0x0000000189757320-0x0000000189757360
	// [XID] // 0x0000000189757320-0x0000000189757360
	public override void AutoRecycleTypeFields() {} // 0x00000001836FF590-0x00000001836FF680
	[BlackList] // 0x0000000189761BC0-0x0000000189761C00
	// [XID] // 0x0000000189761BC0-0x0000000189761C00
	public override void ReturnToObjectPool() {} // 0x00000001837002E0-0x0000000183700380
}

