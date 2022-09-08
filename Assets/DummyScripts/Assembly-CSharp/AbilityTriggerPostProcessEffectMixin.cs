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

public sealed class AbilityTriggerPostProcessEffectMixin : BaseAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 14590
{
	// Fields
	private TriggerPostProcessEffectMixin config; // 0x70
	private NormalTimer _timer; // 0x78

	// Constructors
	public AbilityTriggerPostProcessEffectMixin() {} // 0x0000000181C85E40-0x0000000181C85EA0

	// Methods
	// [XID] // 0x00000001897C0CF0-0x00000001897C0D10
	public override void Init(ActorAbility instancedAbility, ActorModifier instancedModifier, ConfigAbilityMixin config) {} // 0x0000000181C85430-0x0000000181C855C0
	// [XID] // 0x00000001897C86B0-0x00000001897C86D0
	public override void Clear() {} // 0x0000000181C856B0-0x0000000181C85790
	// [XID] // 0x00000001897CFC10-0x00000001897CFC30
	public override void Tick(float inDeltaTime) {} // 0x0000000181C85CE0-0x0000000181C85E40
	// [XID] // 0x00000001897D7490-0x00000001897D74B0
	private void AddPostEffect() {} // 0x0000000181C85940-0x0000000181C85B00
	// [XID] // 0x00000001897DEA60-0x00000001897DEA80
	private void RemovePostEffect(bool needFadeout) {} // 0x0000000181C857F0-0x0000000181C85940
	// [XID] // 0x00000001897E6450-0x00000001897E6470
	public override void OnAdded(bool syncToServer) {} // 0x0000000181C85070-0x0000000181C85130
	// [XID] // 0x00000001897EDFC0-0x00000001897EDFE0
	public override void OnRemoved(RemoveAbilityReason removeReason) {} // 0x0000000181C85370-0x0000000181C85430
	[BlackList] // 0x00000001897F56E0-0x00000001897F5720
	// [XID] // 0x00000001897F56E0-0x00000001897F5720
	public override void AutoAllocTypeFields() {} // 0x0000000181C851C0-0x0000000181C85260
	[BlackList] // 0x00000001897FFF60-0x00000001897FFFA0
	// [XID] // 0x00000001897FFF60-0x00000001897FFFA0
	public override void AutoRecycleTypeFields() {} // 0x0000000181C85260-0x0000000181C85310
	[BlackList] // 0x000000018980A460-0x000000018980A4A0
	// [XID] // 0x000000018980A460-0x000000018980A4A0
	public override void ReturnToObjectPool() {} // 0x0000000181C85C40-0x0000000181C85CE0
}

