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
using SimpleJSON;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CrowdManager : InLevelManager, INotifyInterface, IWorldShiftAgent // TypeDefIndex: 20794
{
	// Fields
	private const float CANDIDATE_GROUP_ENABLE_DISTANCE = 60f; // Metadata: 0x00AFE361
	private const float CANDIDATE_GROUP_DISABLE_DISTANCE = 80f; // Metadata: 0x00AFE365
	private const string CROWD_TPYE_CONFIG_PATH = "Build/Crowd/CrowdTypeConfigs"; // Metadata: 0x00AFE369
	private const string CROWD_AREA_INFO_PATH = "Build/Crowd/CrowdAreaConfigs"; // Metadata: 0x00AFE389
	private const string CROWD_COLLIDER_PREFAB = "Build/Crowd/CrowdCapsule"; // Metadata: 0x00AFE3A9
	private const float UPDATE_CANDIDATE_GROUP_INTERVAL = 5f; // Metadata: 0x00AFE3C5
	private const float UPDATE_CAMERA_HIDE = 0.3f; // Metadata: 0x00AFE3C9
	private float _lastCameraCheck; // 0x10
	private CrowdAreaBlockConfig _currentAreaBlock; // 0x18
	private CrowdGroupInfo[] _groupsInSector; // 0x20
	private List<CrowdGroupInfo> _candidateSpawnGroups; // 0x28
	private List<CrowdGroupInfo> _activeSpawnGroups; // 0x30
	private List<List<CrowdInstData>> _activeCrowdInstGroups; // 0x38
	private List<List<CapsuleCollider>> _activeCrowdColliderGroups; // 0x40
	private IndexHandleObjectList<CrowdInstData> _crowdInstRequireChair; // 0x48
	private int _crowdInstOnSitItrIdx; // 0x50
	private CrowdTypeConfig[] _crowdTypeConfigs; // 0x58
	private CrowdAreaBlockConfig[] _crowdAreaConfigs; // 0x60
	private Dictionary<int, CrowdAreaBlockConfig> _crowdAreaConfigMap; // 0x68
	private uint _crowdTypeHandle; // 0x70
	private uint _crowdAreaHandle; // 0x74
	private float _candidateGroupEnableDistSqr; // 0x78
	private float _candidateGroupDisableDistSqr; // 0x7C
	private float _lastCandidateCheckTime; // 0x80
	private bool _spawnGroupInfoLoading; // 0x84
	private bool _refreshRestrictionNextFrame; // 0x85
	private bool _crowdDisabled; // 0x86
	private bool _lowPerfMode; // 0x87
	private ConfigCrowdGroupInfo[] _asyncLoadedGroupInfos; // 0x88
	private Dictionary<ulong, CrowdGroupInfo> _asyncSpawnGroupInstDic; // 0x90
	private GameObject _colliderPrefab; // 0x98
	private CrowdSpawnInfo _cacheSpawnInfo; // 0xA0
	private float[] _crowdLODArray; // 0xA8
	private EntityLODQualityInfo _crowdLODQualityInfo; // 0xB0
	private float[] _cutSceneLODArray; // 0xB8
	private SliceFrameWatch _candidateUpdateWatch; // 0xC0
	private int _candidateGroupIndex; // 0xC8
	private int _sectorGroupIndex; // 0xCC
	private bool _onSliceWatch; // 0xD0
	private List<CrowdInstData> _currHideCrowdDataList; // 0xD8
	private List<CrowdInstData> _newHideCrowdDataList; // 0xE0
	private const float _crowdCheckHeight = 2f; // Metadata: 0x00AFE3CD
	private const float _crowdCheckRadius = 1f; // Metadata: 0x00AFE3D1
	private SliceFrameWatch _despawnUpdateWatch; // 0xE8
	private int _despawnGroupIndex; // 0xF0
	private List<List<CrowdInstData>> _despawnCrowdInstGroups; // 0xF8
	private List<List<CapsuleCollider>> _despawnCrowdColliderGroups; // 0x100

	// Properties
	private static string CROWD_AREA_GROUPINFO_NAMEPATTERN { /* [XID] */ /* 0x00000001896C3140-0x00000001896C3160 */ get => default; } // 0x000000018220E620-0x000000018220E6C0 
	private static string CROWD_GROUP_SPAWNINFO_NAMEPATTERN { /* [XID] */ /* 0x00000001896CA650-0x00000001896CA670 */ get => default; } // 0x0000000182211EF0-0x0000000182211F90 

	// Constructors
	public CrowdManager() {} // 0x0000000182215510-0x00000001822156B0

	// Methods
	// [XID] // 0x00000001896D1CE0-0x00000001896D1D00
	public void DebugSpawnCrowdInstClean(int groupID, int crowdIndexID = -1 /* Metadata: 0x00AFE347 */, int crowdTypeID = -1 /* Metadata: 0x00AFE34B */) {} // 0x0000000182210A60-0x0000000182210B50
	// [XID] // 0x00000001896D9570-0x00000001896D9590
	public void DebugSpawnCrowdInst(int groupID, int crowdIndexID = -1 /* Metadata: 0x00AFE34F */, int crowdTypeID = -1 /* Metadata: 0x00AFE353 */) {} // 0x00000001822133E0-0x0000000182213580
	// [XID] // 0x00000001896E0D30-0x00000001896E0D50
	public void DebugRefreshCrowdGroup() {} // 0x000000018220E400-0x000000018220E540
	// [XID] // 0x00000001896E7FE0-0x00000001896E8000
	public void DebugRemoveGroup(bool disableCrowd = false /* Metadata: 0x00AFE357 */) {} // 0x0000000182212260-0x0000000182212400
	// [XID] // 0x00000001896EF680-0x00000001896EF6A0
	public void DebugDrawCrowdData() {} // 0x0000000182214B10-0x0000000182214BB0
	// [XID] // 0x00000001896F6FB0-0x00000001896F6FD0
	public override void Init() {} // 0x0000000182211070-0x00000001822115D0
	// [XID] // 0x00000001896FE900-0x00000001896FE920
	public void UpdateCrowdSpawnDistance() {} // 0x0000000182213C00-0x0000000182213FD0
	// [XID] // 0x0000000189705B60-0x0000000189705B80
	public bool OnNotify(Notify ntf) => default; // 0x00000001822140B0-0x00000001822141B0
	// [XID] // 0x000000018970D5B0-0x000000018970D5D0
	private void LoadCrowdManageAssets() {} // 0x0000000182212E30-0x00000001822131D0
	// [XID] // 0x00000001897149B0-0x00000001897149D0
	public override void Destroy() {} // 0x000000018220E920-0x000000018220EBD0
	// [XID] // 0x000000018971C440-0x000000018971C460
	public void SetCrowdManagerEnable(bool enable) {} // 0x00000001822120A0-0x0000000182212170
	// [XID] // 0x0000000189723830-0x0000000189723850
	public void SetLowPerfModeEnable(bool enable) {} // 0x00000001822131D0-0x0000000182213290
	// [XID] // 0x000000018972AFD0-0x000000018972AFF0
	public override void Tick() {} // 0x0000000182215250-0x0000000182215510
	// [XID] // 0x0000000189732740-0x0000000189732760
	private void UpdateCurrentArea() {} // 0x000000018220F220-0x000000018220F330
	// [XID] // 0x0000000189739E80-0x0000000189739EA0
	private void UpdateActiveSpawnGroups() {} // 0x000000018220EBD0-0x000000018220ED70
	// [XID] // 0x00000001897419E0-0x0000000189741A00
	private void StartSlicedCandidateSpawnCheck() {} // 0x0000000182212400-0x00000001822124F0
	// [XID] // 0x0000000189749320-0x0000000189749340
	private void UpdateCandidateSpawnGroupList() {} // 0x0000000182213580-0x0000000182213C00
	// [XID] // 0x00000001897507A0-0x00000001897507C0
	private void UpdateSpawnedCrowdInsts() {} // 0x00000001822141B0-0x0000000182214370
	// [XID] // 0x0000000189757C90-0x0000000189757CB0
	private void CheckCrowdCameraCollistion() {} // 0x000000018220F430-0x000000018220FA00
	// [XID] // 0x000000018975F710-0x000000018975F730
	private void CheckCrowdActive(CrowdInstData data, bool active) {} // 0x000000018220E320-0x000000018220E400
	// [XID] // 0x0000000189766BC0-0x0000000189766BE0
	private bool CheckCameraCollideWithCrowd(Vector3 cameraPos, Vector3 crowdPos) => default; // 0x0000000182212CE0-0x0000000182212E30
	// [XID] // 0x000000018976E160-0x000000018976E180
	private void UnregsiterSpawnGroup(int spawnGroupIndex, bool sliceDespawn = false /* Metadata: 0x00AFE358 */) {} // 0x00000001822115D0-0x0000000182211DA0
	// [XID] // 0x00000001897759E0-0x0000000189775A00
	private void UpdateDespawnGroupSliceFrame() {} // 0x00000001822126B0-0x0000000182212B90
	// [XID] // 0x000000018977D220-0x000000018977D240
	public void UnregisterAllActiveSpawnGroups() {} // 0x00000001822124F0-0x00000001822125E0
	// [XID] // 0x0000000189784CA0-0x0000000189784CC0
	private void RegisterCrowdRequireSit(CrowdInstData sitCrowd) {} // 0x000000018220E540-0x000000018220E620
	// [XID] // 0x000000018978C190-0x000000018978C1B0
	private void RemoveCrowdRequireSit(CrowdInstData sitCrowd) {} // 0x0000000182212B90-0x0000000182212CE0
	// [XID] // 0x00000001897936C0-0x00000001897936E0
	private void UpdateCrowdInstRequireSit() {} // 0x0000000182214370-0x00000001822146E0
	// [XID] // 0x000000018979B8F0-0x000000018979B910
	private void DoAsyncLoadCrowdGroupInfo(int blockID) {} // 0x000000018220F330-0x000000018220F430
	// [XID] // 0x00000001897A2D20-0x00000001897A2D40
	private void AsyncLoadCrowdGroupInfoByBlockID(int blockID, Action asyncLoadFinishCallback) {} // 0x0000000182210DA0-0x0000000182211070
	// [XID] // 0x00000001897AA320-0x00000001897AA340
	private void AsyncLoadGroupInfoFinished() {} // 0x0000000182214800-0x0000000182214B10
	// [XID] // 0x00000001897B1DB0-0x00000001897B1DD0
	private object SerializedGroupInfoBin(ByteArray byteArr, int threadFlag = 0 /* Metadata: 0x00AFE359 */) => default; // 0x00000001822146E0-0x0000000182214800
	// [XID] // 0x00000001897B97D0-0x00000001897B97F0
	private object SerializedGroupInfoJson(JSONNode node) => default; // 0x0000000182211F90-0x00000001822120A0
	// [XID] // 0x00000001897C1830-0x00000001897C1850
	private void OnSerializedGroupInfoAsync(object obj, ulong path) {} // 0x0000000182213FD0-0x00000001822140B0
	// [XID] // 0x00000001897C9240-0x00000001897C9260
	private void DoAsyncSpawnCrowdInstance(CrowdGroupInfo spawnCrowdGroup) {} // 0x00000001822125E0-0x00000001822126B0
	// [XID] // 0x00000001897D0870-0x00000001897D0890
	private void AsyncLoadCrowdSpawnInfoByID(int blockID, CrowdGroupInfo spawnGroup, Action asyncLoadFinishCallback) {} // 0x0000000182214BB0-0x0000000182214F10
	// [XID] // 0x00000001897D8580-0x00000001897D85A0
	private void SpawnInstanceOnAsyncLoadFinish(ulong hash, ConfigCrowdSpawnInfos configInfo) {} // 0x000000018220FA00-0x0000000182210A60
	// [XID] // 0x00000001897DF650-0x00000001897DF670
	private object SerializedSpawnInfoBin(ByteArray byteArr, int threadFlag = 0 /* Metadata: 0x00AFE35D */) => default; // 0x000000018220E810-0x000000018220E920
	// [XID] // 0x00000001897E6E90-0x00000001897E6EB0
	private object SerializedSpawnInfoJson(JSONNode node) => default; // 0x0000000182212170-0x0000000182212260
	// [XID] // 0x00000001897EEBA0-0x00000001897EEBC0
	private void OnSerializedSpawnInfoAsync(object obj, ulong path) {} // 0x0000000182213290-0x00000001822133E0
	// [XID] // 0x00000001897F6280-0x00000001897F62A0
	public void SetCrowdLODEnable(int[] crowdGroupIDs, bool enable) {} // 0x0000000182210B50-0x0000000182210DA0
	// [XID] // 0x00000001897FD8E0-0x00000001897FD900
	private CrowdAnimSet GetAnimInstConfig(CrowdTypeConfig typeConfig, int animInstConfigIdx) => default; // 0x000000018220E6C0-0x000000018220E810
	// [XID] // 0x0000000189805150-0x0000000189805170
	private CrowdAreaBlockConfig GetAvatarLocatedBlockConfig() => default; // 0x000000018220ED70-0x000000018220F1C0
	// [XID] // 0x000000018980C670-0x000000018980C690
	private CrowdTypeConfig GetCrowdTypeConfig(int crowdTypeID) => default; // 0x0000000182211DA0-0x0000000182211EF0
	// [XID] // 0x0000000189813E00-0x0000000189813E20
	public bool ShiftWorld(Vector3 offset, Vector3 oldOffset) => default; // 0x0000000182214F10-0x0000000182215250
}

