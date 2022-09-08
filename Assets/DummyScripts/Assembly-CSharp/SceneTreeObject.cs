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

[fiInspectorOnly] // 0x0000000189A06FC0-0x0000000189A07000
[RecycleType] // 0x0000000189A06FC0-0x0000000189A07000
public sealed class SceneTreeObject : BaseCombatScenePropObject, IAutoAllocRecycle // TypeDefIndex: 20234
{
	// Fields
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	private SceneTreeConfig _config; // 0x70
	private ulong _lastTreeDropTimeStamp; // 0x78
	private const ulong TREE_DROP_COOLDOWN = 500; // Metadata: 0x00AFD417
	private ulong _lastHitEffectTimeStamp; // 0x80

	// Properties
	public SceneTreeConfig config { /* [XID] */ /* 0x0000000189A37DB0-0x0000000189A37DD0 */ get => default; } // 0x0000000182808F20-0x0000000182809130 

	// Constructors
	public SceneTreeObject() {} // 0x00000001828094F0-0x0000000182809570

	// Methods
	[BlackList] // 0x0000000189A18B10-0x0000000189A18B50
	// [XID] // 0x0000000189A18B10-0x0000000189A18B50
	public override void AutoAllocTypeFields() {} // 0x0000000182807930-0x00000001828079D0
	[BlackList] // 0x0000000189A232C0-0x0000000189A23300
	// [XID] // 0x0000000189A232C0-0x0000000189A23300
	public override void AutoRecycleTypeFields() {} // 0x00000001828079D0-0x0000000182807A80
	[BlackList] // 0x0000000189A2D2F0-0x0000000189A2D330
	// [XID] // 0x0000000189A2D2F0-0x0000000189A2D330
	public override void ReturnToObjectPool() {} // 0x0000000182809450-0x00000001828094F0
	// [XID] // 0x0000000189A3F4E0-0x0000000189A3F500
	private ScenePropHitEffectConfig GetHitEffectConfig(string effectName) => default; // 0x0000000182809130-0x0000000182809320
	// [XID] // 0x0000000189A46B10-0x0000000189A46B30
	protected override ScenePropCombatBaseConfig GetConfig() => default; // 0x0000000182807880-0x0000000182807930
	// [XID] // 0x0000000189A4E310-0x0000000189A4E330
	private void CheckDropItem(EvtBeingHit beingHitEvent) {} // 0x0000000182808080-0x0000000182808510
	// [XID] // 0x0000000189A55B80-0x0000000189A55BA0
	public override void BeingHit(EvtBeingHit beingHitEvent) {} // 0x00000001828086D0-0x00000001828087A0
	// [XID] // 0x0000000189A5D3C0-0x0000000189A5D3E0
	public override uint GetConfigID() => default; // 0x0000000182807DB0-0x0000000182807E60
	// [XID] // 0x0000000189A64D20-0x0000000189A64D40
	public override void LodLevelUpdate(int lodLevel) {} // 0x0000000182808510-0x0000000182808670
	// [XID] // 0x0000000189A6C4A0-0x0000000189A6C4C0
	protected override void AddScenePropToManager() {} // 0x0000000182807C10-0x0000000182807DB0
	// [XID] // 0x0000000189A73C10-0x0000000189A73C30
	protected override void RemoveScenePropFromManager() {} // 0x0000000182807E60-0x0000000182808000
	// [XID] // 0x0000000189A7B740-0x0000000189A7B760
	public override void RefreshSceneProp(GameObject obj) {} // 0x0000000182809390-0x0000000182809450
	// [XID] // 0x0000000189A82EC0-0x0000000189A82EE0
	private void PlayScenePropHitEffect() {} // 0x0000000182808880-0x0000000182808F20
}

