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

public class LevelEntity : BaseEntity, IAutoAllocRecycle // TypeDefIndex: 19878
{
	// Fields
	private LevelSceneGrassPlugin _grassScenePlugin; // 0x4B8
	private LevelSceneWaterPlugin _waterScenePlugin; // 0x4C0
	private LevelSceneBushPlugin _bushScenePlugin; // 0x4C8
	private LevelSceneTreePlugin _treeScenePlugin; // 0x4D0
	private LevelTileAttackPlugin _tileAttackPlugin; // 0x4D8
	private LevelSceneSubEmitterPlugin _subEmitterPlugin; // 0x4E0
	private LCAIManager _aiMgr; // 0x4E8

	// Constructors
	public LevelEntity() {} // 0x00000001822D1FD0-0x00000001822D2060

	// Methods
	// [XID] // 0x00000001899487C0-0x00000001899487E0
	public override void Init(uint runtimeID, uint configID = 0 /* Metadata: 0x00AFCFCE */) {} // 0x00000001822D0F30-0x00000001822D1040
	// [XID] // 0x000000018994FF50-0x000000018994FF70
	public override bool Destroy(SliceFrameWatch watch) => default; // 0x00000001822D0BE0-0x00000001822D0CF0
	// [XID] // 0x0000000189957500-0x0000000189957520
	public override bool IsLevelReadyToExecuteTickFunctions() => default; // 0x00000001822D16C0-0x00000001822D1760
	// [XID] // 0x000000018995EF50-0x000000018995EF70
	public override bool ShouldTickComponents() => default; // 0x00000001822D19D0-0x00000001822D1A80
	// [XID] // 0x0000000189966790-0x00000001899667B0
	public override bool ShouldLateTickComponents() => default; // 0x00000001822D12B0-0x00000001822D1360
	// [XID] // 0x000000018996DB90-0x000000018996DBB0
	protected override void InitTimeScale() {} // 0x00000001822D0DC0-0x00000001822D0F30
	// [XID] // 0x00000001899757B0-0x00000001899757D0
	public override void OnTimeScaleChanged(bool force = false /* Metadata: 0x00AFCFD2 */) {} // 0x00000001822D1880-0x00000001822D19D0
	// [XID] // 0x000000018997C8D0-0x000000018997C8F0
	protected override void InitAuthority() {} // 0x00000001822D1040-0x00000001822D10F0
	// [XID] // 0x0000000189984630-0x0000000189984650
	public LevelTileAttackPlugin GetTileAttackPlugin() => default; // 0x00000001822D1CA0-0x00000001822D1D80
	// [XID] // 0x0000000189B58EC0-0x0000000189B58EE0
	public LevelSceneTreePlugin GetTreePlugin() => default; // 0x00000001822D15E0-0x00000001822D16C0
	// [XID] // 0x000000018977E000-0x000000018977E020
	public LevelSceneWaterPlugin GetWaterPlugin() => default; // 0x00000001822D1BC0-0x00000001822D1CA0
	// [XID] // 0x0000000189851AE0-0x0000000189851B00
	public LevelSceneGrassPlugin GetGrassPlugin() => default; // 0x00000001822D1500-0x00000001822D15E0
	// [XID] // 0x00000001898593D0-0x00000001898593F0
	public LevelSceneBushPlugin GetBushPlugin() => default; // 0x00000001822D10F0-0x00000001822D11D0
	// [XID] // 0x00000001899AA860-0x00000001899AA880
	public LevelSceneSubEmitterPlugin GetSubEmitterPlugin() => default; // 0x00000001822D1E50-0x00000001822D1F30
	// [XID] // 0x00000001899B21C0-0x00000001899B21E0
	public LCAIManager GetLCAIManager() => default; // 0x00000001822D1D80-0x00000001822D1E50
	// [XID] // 0x00000001898EDE30-0x00000001898EDE50
	public void PlayAudioEvent(string eventName, Vector3 position) {} // 0x00000001822D1760-0x00000001822D1880
	// [XID] // 0x000000018994F350-0x000000018994F370
	public void StopAudioEvent(string eventName) {} // 0x00000001822D1AE0-0x00000001822D1BC0
	[BlackList] // 0x00000001899C8590-0x00000001899C85D0
	// [XID] // 0x00000001899C8590-0x00000001899C85D0
	public override void AutoAllocTypeFields() {} // 0x00000001822D0A60-0x00000001822D0B00
	[BlackList] // 0x00000001899D2D70-0x00000001899D2DB0
	// [XID] // 0x00000001899D2D70-0x00000001899D2DB0
	public override void AutoRecycleTypeFields() {} // 0x00000001822D0B00-0x00000001822D0BE0
	[BlackList] // 0x00000001899DD240-0x00000001899DD280
	// [XID] // 0x00000001899DD240-0x00000001899DD280
	public override void ReturnToObjectPool() {} // 0x00000001822D1F30-0x00000001822D1FD0
}

