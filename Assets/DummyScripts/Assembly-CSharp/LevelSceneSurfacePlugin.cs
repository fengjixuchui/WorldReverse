/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UniRx;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class LevelSceneSurfacePlugin : BaseComponentPlugin // TypeDefIndex: 12117
{
	// Fields
	private List<Tuple<uint, Vector3, MoleMole.SceneSurfaceMaterial>?> _entitiesCheckInfo; // 0x58
	private float _checkXZDistance; // 0x60
	private float _checkStartHeightAboveEntity; // 0x64
	private float _checkRayLength; // 0x68
	private const int TICK_INTERVAL = 15; // Metadata: 0x00AEB508
	private int _tickIntervalCounter; // 0x6C
	private int _tickIndex; // 0x70

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x00000001898FFEC0-0x00000001898FFEE0 */ get => default; } // 0x00000001810D1960-0x00000001810D1A00 

	// Constructors
	public LevelSceneSurfacePlugin() {} // 0x00000001810D18B0-0x00000001810D1960

	// Methods
	// [XID] // 0x0000000189907620-0x0000000189907640
	private static new EventID[] GetSelfOnEventIDsExcludingBase() => default; // 0x00000001810CFF20-0x00000001810CFFF0
	// [XID] // 0x000000018990EF70-0x000000018990EF90
	public override bool OnEvent(BaseEvent evt) => default; // 0x00000001810D0FF0-0x00000001810D12B0
	// [XID] // 0x0000000189916840-0x0000000189916860
	private static new EventID[] GetSelfListenEventIDsExcludingBase() => default; // 0x00000001810CFE40-0x00000001810CFF20
	// [XID] // 0x000000018991DFF0-0x000000018991E010
	public override bool ListenEvent(BaseEvent evt) => default; // 0x00000001810D0710-0x00000001810D0830
	// [XID] // 0x00000001899258E0-0x0000000189925900
	public override void Init() {} // 0x00000001810CFFF0-0x00000001810D00F0
	// [XID] // 0x000000018992CD90-0x000000018992CDB0
	public override void Tick(float inDeltaTime) {} // 0x00000001810D17F0-0x00000001810D18B0
	// [XID] // 0x0000000189934280-0x00000001899342A0
	public override void Destroy() {} // 0x00000001810CF590-0x00000001810CF6B0
	// [XID] // 0x000000018993BF90-0x000000018993BFB0
	public bool CheckEntitySurface(uint entityRuntimeID, bool forceReset) => default; // 0x00000001810D00F0-0x00000001810D0320
	// [XID] // 0x0000000189943350-0x0000000189943370
	private bool OnEntityRemoved(uint entityRuntimeID) => default; // 0x00000001810D0320-0x00000001810D0480
	// [XID] // 0x000000018994AA60-0x000000018994AA80
	private bool OnEntitySetActive(uint entityRuntimeID, bool active, bool reset) => default; // 0x00000001810D04E0-0x00000001810D0710
	// [XID] // 0x0000000189952490-0x00000001899524B0
	public void RegisterCheckSceneSurface(uint runtimeID) {} // 0x00000001810CE800-0x00000001810CE990
	// [XID] // 0x0000000189959930-0x0000000189959950
	private Tuple<uint, Vector3, MoleMole.SceneSurfaceMaterial> RecheckEntitySurface(BaseEntity entity, Vector3 entityPos, MoleMole.SceneSurfaceMaterial lastSurfaceType, MoleMole.SceneSurfaceMaterial curSurfaceType) => default; // 0x00000001810CF7B0-0x00000001810CFA80
	// [XID] // 0x0000000189961250-0x0000000189961270
	private void CheckSurfaceOnce(BaseEntity entity, Vector3 entityPos) {} // 0x00000001810D0830-0x00000001810D09C0
	// [XID] // 0x0000000189968930-0x0000000189968950
	public void UnRegisterCheckSceneSurface(uint runtimeID) {} // 0x00000001810CFC40-0x00000001810CFE40
	// [XID] // 0x000000018996FF20-0x000000018996FF40
	private int CheckHasEntity(uint runtimeID) => default; // 0x00000001810CF1C0-0x00000001810CF360
	// [XID] // 0x0000000189977D10-0x0000000189977D30
	private MoleMole.SceneSurfaceMaterial CheckEntityInSurface(uint entityId) => default; // 0x00000001810D0AB0-0x00000001810D0C60
	// [XID] // 0x000000018997EF30-0x000000018997EF50
	private void TryRemoveEntity(uint runtimeID) {} // 0x00000001810CFA80-0x00000001810CFC40
	// [XID] // 0x0000000189986830-0x0000000189986850
	private void TickCheckInSceneSurface() {} // 0x00000001810D12B0-0x00000001810D17F0
	// [XID] // 0x000000018998E430-0x000000018998E450
	private void ClearOnStageDestroying() {} // 0x00000001810CF360-0x00000001810CF590
	// [IDTag] // 0x0000000189995F60-0x0000000189995FA0
	// [XID] // 0x0000000189995F60-0x0000000189995FA0
	public MoleMole.SceneSurfaceMaterial GetCurrentSurfaceType(Vector3 entityPos) => default; // 0x00000001810CF0B0-0x00000001810CF1C0
	// [XID] // 0x00000001899A0990-0x00000001899A09B0
	public MoleMole.SceneSurfaceMaterial CheckIsWaterSurfaceType(Vector3 entityPos, float aboveHeightOffset, float hitRayLengthAdded, out Vector3 hitPoint) {
		hitPoint = default;
		return default;
	} // 0x00000001810D0C60-0x00000001810D0FF0
	// [IDTag] // 0x00000001899A8460-0x00000001899A84A0
	// [XID] // 0x00000001899A8460-0x00000001899A84A0
	public MoleMole.SceneSurfaceMaterial GetCurrentSurfaceType(Vector3 entityPos, float aboveHeightOffset, float hitRayLengthAdded, out Vector3 hitPoint) {
		hitPoint = default;
		return default;
	} // 0x00000001810CED60-0x00000001810CF0B0
	// [XID] // 0x00000001899B2F70-0x00000001899B2F90
	public void EntitySurfaceChanged(uint entityId) {} // 0x00000001810CE9F0-0x00000001810CED60
}

