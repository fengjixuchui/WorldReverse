/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class VCLevel : VCBase // TypeDefIndex: 11887
{
	// Fields
	private LevelSceneGrassPlugin _sceneGrassPlugin; // 0x108
	private LevelSceneWaterPlugin _sceneWaterPlugin; // 0x110
	private LevelSceneBushPlugin _sceneBushPlugin; // 0x118
	private LevelSceneTreePlugin _sceneTreePlugin; // 0x120
	private LevelSceneIcePlugin _sceneIcePlugin; // 0x128
	private LevelTileAttackPlugin _tileAttackPlugin; // 0x130
	private LevelSceneSurfacePlugin _sceneSurfacePlugin; // 0x138
	private LevelSceneNavMeshPlugin _sceneNavMeshPlugin; // 0x140
	private LevelTrafficPlugin _trafficPlugin; // 0x148
	private LevelSceneGuidePathPlugin _sceneGuidePathPlugin; // 0x150
	private LevelSceneAirflowFieldPlugin _sceneAirflowFieldPlugin; // 0x158
	private LevelTransmitAvatarPlugin _transportAvatarPlugin; // 0x160
	private LevelSceneDungeonEffectsPlugin _dungeonEffectsPlugin; // 0x168
	private LevelSceneSubEmitterPlugin _subEmitterPlugin; // 0x170
	private LevelSceneElementViewPlugin _elementViewPlugin; // 0x178
	public LevelRecordPlugin _levelRecordPlugin; // 0x180
	private Light _mainCastShadowLight; // 0x188
	private readonly List<Light> _dungeonAvatarPointLights; // 0x190
	private HashSet<uint> _noReviveTriggerList; // 0x198

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x000000018984ED60-0x000000018984ED80 */ get => default; } // 0x00000001813E65F0-0x00000001813E6690 
	public LevelSceneDungeonEffectsPlugin dungeonEffectsPlugin { /* [XID] */ /* 0x00000001899103B0-0x00000001899103D0 */ get => default; } // 0x00000001813E5910-0x00000001813E59C0 
	public LevelSceneSubEmitterPlugin subEmitterPlugin { /* [XID] */ /* 0x00000001898D3E50-0x00000001898D3E70 */ get => default; } // 0x00000001813E6120-0x00000001813E61D0 
	public LevelSceneElementViewPlugin elementViewPlugin { /* [XID] */ /* 0x000000018985D100-0x000000018985D120 */ get => default; } // 0x00000001813E50B0-0x00000001813E5160 
	public LevelRecordPlugin levelRecordPlugin { /* [XID] */ /* 0x00000001899270E0-0x0000000189927100 */ get => default; } // 0x00000001813E62C0-0x00000001813E6370 
	public Light mainCastShadowLight { /* [XID] */ /* 0x0000000189850300-0x0000000189850320 */ get => default; /* [XID] */ /* 0x000000018986C150-0x000000018986C170 */ set {} } // 0x00000001813E5660-0x00000001813E5710 0x00000001813E4CF0-0x00000001813E4DA0
	public List<Light> dungeonAvatarPointLights { /* [XID] */ /* 0x0000000189873650-0x0000000189873670 */ get => default; } // 0x00000001813E4DA0-0x00000001813E4E50 

	// Constructors
	public VCLevel() {} // 0x00000001813E6530-0x00000001813E65F0

	// Methods
	// [XID] // 0x0000000189944C50-0x0000000189944C70
	public override void Init() {} // 0x00000001813E59C0-0x00000001813E5EA0
	// [XID] // 0x0000000189882180-0x00000001898821A0
	public override void Destroy() {} // 0x00000001813E5160-0x00000001813E5260
	// [XID] // 0x00000001898897D0-0x00000001898897F0
	private static new EventID[] GetSelfOnEventIDsExcludingBase() => default; // 0x00000001813E5710-0x00000001813E57F0
	// [XID] // 0x0000000189890D40-0x0000000189890D60
	protected override bool OnEvent(BaseEvent e) => default; // 0x00000001813E6430-0x00000001813E6530
	// [XID] // 0x00000001898982E0-0x0000000189898300
	private void OnEvtStageReady(EvtStageReady evt) {} // 0x00000001813E57F0-0x00000001813E5910
	// [Conditional] // 0x000000018996A090-0x000000018996A0F0
	// [IDTag] // 0x000000018996A090-0x000000018996A0F0
	// [XID] // 0x000000018996A090-0x000000018996A0F0
	public void AttachLabelToTransform(Transform target, Vector3 offset, Func<string> textCallback, bool removeOnDisable = false /* Metadata: 0x00AEAE31 */) {} // 0x00000001813E5390-0x00000001813E5480
	// [Conditional] // 0x0000000189977D70-0x0000000189977DE0
	// [IDTag] // 0x0000000189977D70-0x0000000189977DE0
	// [XID] // 0x0000000189977D70-0x0000000189977DE0
	public void AttachLabelToTransform(Transform target, Vector3 offset, Func<string> textCallback, Color color, int size, FontStyle fontStyle, bool removeOnDisable = false /* Metadata: 0x00AEAE32 */) {} // 0x00000001813E5260-0x00000001813E5390
	// [Conditional] // 0x0000000189985060-0x00000001899850C0
	// [IDTag] // 0x0000000189985060-0x00000001899850C0
	// [XID] // 0x0000000189985060-0x00000001899850C0
	public void PopupLabelToTransform(Transform target, Vector3 offset, string text, float duration = 2f /* Metadata: 0x00AEAE33 */) {} // 0x00000001813E6030-0x00000001813E6120
	// [Conditional] // 0x00000001899930A0-0x0000000189993100
	// [IDTag] // 0x00000001899930A0-0x0000000189993100
	// [XID] // 0x00000001899930A0-0x0000000189993100
	public void PopupLabelToPosition(Vector3 position, Vector3 offset, string text, float duration = 2f /* Metadata: 0x00AEAE37 */) {} // 0x00000001813E4E50-0x00000001813E4F60
	// [Conditional] // 0x00000001899A09F0-0x00000001899A0A50
	// [IDTag] // 0x00000001899A09F0-0x00000001899A0A50
	// [XID] // 0x00000001899A09F0-0x00000001899A0A50
	public void PopupLabelToTransform(Transform target, Vector3 offset, string text, Color color, int size, FontStyle fontStyle, float duration = 2f /* Metadata: 0x00AEAE3B */) {} // 0x00000001813E5F00-0x00000001813E6030
	// [Conditional] // 0x00000001899AE340-0x00000001899AE3B0
	// [IDTag] // 0x00000001899AE340-0x00000001899AE3B0
	// [XID] // 0x00000001899AE340-0x00000001899AE3B0
	public void PopupLabelToPosition(Vector3 position, Vector3 offset, string text, Color color, int size, FontStyle fontStyle, float duration = 2f /* Metadata: 0x00AEAE3F */) {} // 0x00000001813E4F60-0x00000001813E50B0
	// [XID] // 0x00000001899BBA30-0x00000001899BBA50
	public bool IsPlayerInNoRevivePlace() => default; // 0x00000001813E6370-0x00000001813E6430
	// [XID] // 0x00000001899289D0-0x00000001899289F0
	public void SetNoReviveTrigger(uint id, bool enter) {} // 0x00000001813E5480-0x00000001813E5660
}

