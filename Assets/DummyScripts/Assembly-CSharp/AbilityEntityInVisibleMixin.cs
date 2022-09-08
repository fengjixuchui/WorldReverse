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

public sealed class AbilityEntityInVisibleMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14534
{
	// Fields
	private bool _isInvisible; // 0x70
	private EntityInVisibleMixin _config; // 0x78
	private int _curReason; // 0x80

	// Constructors
	public AbilityEntityInVisibleMixin() {} // 0x000000018291EDF0-0x000000018291EE60

	// Methods
	// [XID] // 0x0000000189B2E620-0x0000000189B2E640
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x000000018291E5B0-0x000000018291E6F0
	// [XID] // 0x0000000189B35CD0-0x0000000189B35CF0
	public override void Clear() {} // 0x000000018291E760-0x000000018291E810
	// [XID] // 0x0000000189B3D400-0x0000000189B3D420
	public override void OnAdded(bool syncToServer) {} // 0x000000018291E1F0-0x000000018291E2B0
	// [XID] // 0x0000000189B45280-0x0000000189B452A0
	public override void OnRemoved(RemoveAbilityReason removeReason) {} // 0x000000018291E4F0-0x000000018291E5B0
	// [XID] // 0x0000000189B4C910-0x0000000189B4C930
	private int GetVisibleReason(AbilityEntityVisibleReason reason) => default; // 0x000000018291E920-0x000000018291E9E0
	// [XID] // 0x0000000189B54060-0x0000000189B54080
	private void TryStartInvisible() {} // 0x000000018291EA40-0x000000018291EC10
	// [XID] // 0x0000000189B5BAC0-0x0000000189B5BAE0
	private void TryStopInvisible() {} // 0x000000018291E810-0x000000018291E920
	[BlackList] // 0x0000000189B62E60-0x0000000189B62EA0
	// [XID] // 0x0000000189B62E60-0x0000000189B62EA0
	public override void AutoAllocTypeFields() {} // 0x000000018291E340-0x000000018291E3E0
	[BlackList] // 0x0000000189B6D690-0x0000000189B6D6D0
	// [XID] // 0x0000000189B6D690-0x0000000189B6D6D0
	public override void AutoRecycleTypeFields() {} // 0x000000018291E3E0-0x000000018291E490
	[BlackList] // 0x0000000189B77B80-0x0000000189B77BC0
	// [XID] // 0x0000000189B77B80-0x0000000189B77BC0
	public override void ReturnToObjectPool() {} // 0x000000018291ED50-0x000000018291EDF0
}

