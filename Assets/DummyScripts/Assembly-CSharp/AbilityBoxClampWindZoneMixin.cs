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

public sealed class AbilityBoxClampWindZoneMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14492
{
	// Fields
	private Vector3 _bornPos; // 0x70
	private Quaternion _bornRot; // 0x7C
	private Vector3 _bornForward; // 0x8C
	private Vector3 _bornUp; // 0x98
	private Vector3 _bornRight; // 0xA4
	private BoxClampWindZoneMixin config; // 0xB0
	private Vector3 _boxSize; // 0xB8

	// Constructors
	public AbilityBoxClampWindZoneMixin() {} // 0x0000000183DFD580-0x0000000183DFD5E0

	// Methods
	// [XID] // 0x00000001898C4E00-0x00000001898C4E20
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x0000000183DFC740-0x0000000183DFC8D0
	// [XID] // 0x00000001898CC2C0-0x00000001898CC2E0
	public override void Clear() {} // 0x0000000183DFC9C0-0x0000000183DFCA60
	// [XID] // 0x00000001898D3B70-0x00000001898D3B90
	public override void OnAdded(bool syncToServer) {} // 0x0000000183DFC300-0x0000000183DFC3C0
	// [XID] // 0x00000001898DB370-0x00000001898DB390
	public override void OnRemoved(RemoveAbilityReason removeReason) {} // 0x0000000183DFC690-0x0000000183DFC740
	// [XID] // 0x00000001898E3020-0x00000001898E3040
	public override void Tick(float inDeltaTime) {} // 0x0000000183DFCCA0-0x0000000183DFD580
	[BlackList] // 0x00000001898EACB0-0x00000001898EACF0
	// [XID] // 0x00000001898EACB0-0x00000001898EACF0
	public override void AutoAllocTypeFields() {} // 0x0000000183DFC450-0x0000000183DFC4F0
	[BlackList] // 0x00000001898F54B0-0x00000001898F54F0
	// [XID] // 0x00000001898F54B0-0x00000001898F54F0
	public override void AutoRecycleTypeFields() {} // 0x0000000183DFC4F0-0x0000000183DFC630
	[BlackList] // 0x00000001898FFDC0-0x00000001898FFE00
	// [XID] // 0x00000001898FFDC0-0x00000001898FFE00
	public override void ReturnToObjectPool() {} // 0x0000000183DFCC00-0x0000000183DFCCA0
}

