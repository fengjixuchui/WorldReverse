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

public sealed class AbilityDebugMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14457
{
	// Fields
	private bool _hasAdded; // 0x70

	// Constructors
	public AbilityDebugMixin() {} // 0x00000001818FF780-0x00000001818FF7E0

	// Methods
	// [XID] // 0x000000018969E000-0x000000018969E020
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x00000001818FF000-0x00000001818FF0F0
	// [XID] // 0x00000001896A5070-0x00000001896A5090
	public override void Clear() {} // 0x00000001818FF170-0x00000001818FF220
	// [XID] // 0x00000001896AC9A0-0x00000001896AC9C0
	public override void OnAdded(bool syncToServer) {} // 0x00000001818FED00-0x00000001818FEDC0
	// [XID] // 0x00000001896B3C70-0x00000001896B3C90
	public override void Tick(float inDeltaTime) {} // 0x00000001818FF6D0-0x00000001818FF780
	// [XID] // 0x00000001896BB340-0x00000001896BB360
	public override bool OnEvent(BaseEvent evt) => default; // 0x00000001818FF4F0-0x00000001818FF5B0
	// [XID] // 0x00000001896C24C0-0x00000001896C24E0
	public override void OnAbilityTriggered(EvtAbilityStart evt) {} // 0x00000001818FF300-0x00000001818FF3B0
	[BlackList] // 0x00000001896C9A70-0x00000001896C9AB0
	// [XID] // 0x00000001896C9A70-0x00000001896C9AB0
	public override void AutoAllocTypeFields() {} // 0x00000001818FEE50-0x00000001818FEEF0
	[BlackList] // 0x00000001896D3EA0-0x00000001896D3EE0
	// [XID] // 0x00000001896D3EA0-0x00000001896D3EE0
	public override void AutoRecycleTypeFields() {} // 0x00000001818FEEF0-0x00000001818FEFA0
	[BlackList] // 0x00000001896DEA10-0x00000001896DEA50
	// [XID] // 0x00000001896DEA10-0x00000001896DEA50
	public override void ReturnToObjectPool() {} // 0x00000001818FF630-0x00000001818FF6D0
}

