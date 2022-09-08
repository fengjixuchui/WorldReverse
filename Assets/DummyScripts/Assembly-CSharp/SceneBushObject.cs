/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using FullInspector;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using UnityEngine;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[fiInspectorOnly] // 0x000000018987FF20-0x000000018987FF60
[RecycleType] // 0x000000018987FF20-0x000000018987FF60
public sealed class SceneBushObject : BaseCombatScenePropObject, IAutoAllocRecycle // TypeDefIndex: 20232
{
	// Fields
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	private SceneBushConfig _config; // 0x70
	private ScenePropEffectConfig _effectConfig; // 0x78

	// Properties
	public SceneBushConfig config { /* [XID] */ /* 0x00000001898B0BC0-0x00000001898B0BE0 */ get => default; } // 0x00000001819085B0-0x0000000181908830 

	// Constructors
	public SceneBushObject() {} // 0x00000001819089A0-0x0000000181908A10

	// Methods
	[BlackList] // 0x0000000189891680-0x00000001898916C0
	// [XID] // 0x0000000189891680-0x00000001898916C0
	public override void AutoAllocTypeFields() {} // 0x0000000181907A40-0x0000000181907AE0
	[BlackList] // 0x000000018989BDA0-0x000000018989BDE0
	// [XID] // 0x000000018989BDA0-0x000000018989BDE0
	public override void AutoRecycleTypeFields() {} // 0x0000000181907AE0-0x0000000181907B90
	[BlackList] // 0x00000001898A64A0-0x00000001898A64E0
	// [XID] // 0x00000001898A64A0-0x00000001898A64E0
	public override void ReturnToObjectPool() {} // 0x0000000181908900-0x00000001819089A0
	// [XID] // 0x00000001898B82A0-0x00000001898B82C0
	public override void RefreshSceneProp(GameObject obj) {} // 0x0000000181908830-0x0000000181908900
	// [XID] // 0x00000001898BFA20-0x00000001898BFA40
	public override void RefreshEffectConfig() {} // 0x0000000181908430-0x00000001819085B0
	// [XID] // 0x00000001898C72A0-0x00000001898C72C0
	protected override ScenePropCombatBaseConfig GetConfig() => default; // 0x0000000181907990-0x0000000181907A40
	// [XID] // 0x00000001898CE850-0x00000001898CE870
	private void CheckDropItem() {} // 0x0000000181907EB0-0x00000001819080C0
	// [XID] // 0x00000001898D6280-0x00000001898D62A0
	public override void BeingHit(EvtBeingHit beingHitEvent) {} // 0x0000000181908240-0x00000001819082F0
	// [XID] // 0x00000001898DDE20-0x00000001898DDE40
	public override void Die() {} // 0x00000001819080C0-0x0000000181908170
	// [XID] // 0x00000001898E5700-0x00000001898E5720
	public override uint GetConfigID() => default; // 0x0000000181907D80-0x0000000181907E30
	// [XID] // 0x00000001898ECFE0-0x00000001898ED000
	public override int GetEffectConfigID() => default; // 0x0000000181907B90-0x0000000181907C50
}

