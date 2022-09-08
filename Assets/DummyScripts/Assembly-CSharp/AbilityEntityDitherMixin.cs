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

public sealed class AbilityEntityDitherMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14533
{
	// Fields
	private uint _ditherUniqId; // 0x70
	private EntityDitherMixin _config; // 0x78

	// Constructors
	public AbilityEntityDitherMixin() {} // 0x0000000183062490-0x0000000183062500

	// Methods
	// [XID] // 0x0000000189AE2700-0x0000000189AE2720
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x0000000183061FF0-0x0000000183062130
	// [XID] // 0x0000000189AEA1D0-0x0000000189AEA1F0
	public override void Clear() {} // 0x00000001830621A0-0x0000000183062250
	// [XID] // 0x0000000189AF1D30-0x0000000189AF1D50
	public override void OnAdded(bool syncToServer) {} // 0x0000000183061920-0x00000001830619E0
	// [XID] // 0x0000000189AF96E0-0x0000000189AF9700
	public override void OnRemoved(RemoveAbilityReason removeReason) {} // 0x0000000183061F30-0x0000000183061FF0
	// [XID] // 0x0000000189B00B30-0x0000000189B00B50
	private void TryStartDither() {} // 0x0000000183061D60-0x0000000183061F30
	// [XID] // 0x0000000189B08110-0x0000000189B08130
	private void TryStopDither() {} // 0x0000000183061BC0-0x0000000183061D00
	[BlackList] // 0x0000000189B0F950-0x0000000189B0F990
	// [XID] // 0x0000000189B0F950-0x0000000189B0F990
	public override void AutoAllocTypeFields() {} // 0x0000000183061A70-0x0000000183061B10
	[BlackList] // 0x0000000189B19CA0-0x0000000189B19CE0
	// [XID] // 0x0000000189B19CA0-0x0000000189B19CE0
	public override void AutoRecycleTypeFields() {} // 0x0000000183061B10-0x0000000183061BC0
	[BlackList] // 0x0000000189B24480-0x0000000189B244C0
	// [XID] // 0x0000000189B24480-0x0000000189B244C0
	public override void ReturnToObjectPool() {} // 0x00000001830623F0-0x0000000183062490
}

