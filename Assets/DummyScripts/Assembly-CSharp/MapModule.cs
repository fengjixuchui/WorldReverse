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
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MapModule : BaseModule // TypeDefIndex: 21553
{
	// Fields
	public const float TRANSPOINT_DIST = 200f; // Metadata: 0x00AFF926
	public const float DUNGEON_DIST = 500f; // Metadata: 0x00AFF92A
	public const float GODDNESS_DIST = 1000f; // Metadata: 0x00AFF92E
	public const float OFFSET_DIST = 100f; // Metadata: 0x00AFF932
	private const string CONFIG_POINT_POST_PATH = "_point"; // Metadata: 0x00AFF936
	private Dictionary<uint, Dictionary<uint, ScenePointData>> _scenePointDics; // 0x10
	private Vector3 _bigworldPos; // 0x18
	private SortedDictionary<int, string> _limitRegions; // 0x28
	private string _curLimitRegion; // 0x30
	private string _activityLimitRegion; // 0x38
	private string _homeworldLimitRegion; // 0x40
	private uint _checkScenePointTimer; // 0x48
	public List<uint> dungeonDataLevelConfigIdList; // 0x60
	public Vector3? curClientAvatarRebornPoint; // 0x68
	public Dictionary<uint, Dictionary<uint, uint>> toBeExploredDungeonEntryDic; // 0x78
	public Dictionary<uint, Dictionary<uint, uint>> canNotBeExploredDungeonEntryDic; // 0x80
	private Dictionary<uint, ConfigScene> _cfgSceneDic; // 0x88
	private Dictionary<uint, Dictionary<uint, ConfigScenePoint>> _cfgPointDic; // 0x90
	private List<uint> _currTransPointList; // 0x98
	private float MAX_IN_LIMIT_REGION_TIME; // 0xA4
	private float _startInLimitRegionTime; // 0xA8
	private Dictionary<uint, Dictionary<uint, CityData>> _cityDataDic; // 0xB0
	private Dictionary<uint, Dictionary<uint, WorldAreaData>> _worldAreaDataDic; // 0xB8
	private Dictionary<uint, uint> _areaId2ExplorePointDic; // 0xC0
	private WorldAreaConfig _currAreaConfig; // 0xC8
	private BaseEntity _dungeonQuitPoint; // 0xD0
	private Dictionary<uint, BaseEntity> _dungeonWayPointDic; // 0xD8
	private Dictionary<uint, List<uint>> _dungeonToEntrytDic; // 0xE0
	private Dictionary<uint, List<uint>> _dungeonToDateDic; // 0xE8
	private uint _dungeonCloseTime; // 0xF0
	private static Action<EvtEntityReadyPost> _onEntityReadyPostCallback; // 0x00
	private Dictionary<string, BaseEntity> _forceFieldDic; // 0xF8
	private bool _playerAudioOnEnterDungeonSuccess; // 0x100
	private HashSet<uint> _activatedDungeonWayPoint; // 0x108
	private bool _dungeonEntryOpen; // 0x110

	// Properties
	private static string CONFIG_POINT_PRE_PATH { /* [XID] */ /* 0x00000001898F2FA0-0x00000001898F2FC0 */ get => default; } // 0x000000018148DF80-0x000000018148E020 
	public uint curDungeonID { /* [XID] */ /* 0x00000001898FA680-0x00000001898FA6C0 */ get; /* [XID] */ /* 0x00000001899051A0-0x00000001899051E0 */ private set; } // 0x000000018148E890-0x000000018148E8F0 0x00000001814887A0-0x0000000181488800
	public uint dungeonEndTime { /* [XID] */ /* 0x000000018990F9B0-0x000000018990F9F0 */ get; /* [XID] */ /* 0x000000018991A450-0x000000018991A490 */ private set; } // 0x000000018148C8A0-0x000000018148C900 0x000000018148ED50-0x000000018148EDB0
	public uint dungeonMonsterDieCount { /* [XID] */ /* 0x0000000189924BA0-0x0000000189924BE0 */ get; /* [XID] */ /* 0x000000018992F140-0x000000018992F180 */ private set; } // 0x0000000181485250-0x00000001814852B0 0x0000000181489980-0x00000001814899E0
	public bool isTowerUnlocked { /* [XID] */ /* 0x0000000189939990-0x00000001899399D0 */ get; /* [XID] */ /* 0x0000000189944040-0x0000000189944080 */ private set; } // 0x000000018148EDB0-0x000000018148EE10 0x0000000181485870-0x00000001814858D0
	public Vector3 bigworldPos { /* [XID] */ /* 0x000000018994E5A0-0x000000018994E5C0 */ get => default; /* [XID] */ /* 0x0000000189955C20-0x0000000189955C40 */ set {} } // 0x0000000181484800-0x00000001814848E0 0x0000000181488DA0-0x0000000181488E70
	public uint activityPlayId { /* [XID] */ /* 0x0000000189A1E700-0x0000000189A1E740 */ get; /* [XID] */ /* 0x0000000189A28B30-0x0000000189A28B70 */ set; } // 0x0000000181478B50-0x0000000181478BB0 0x0000000181479880-0x00000001814798F0
	public uint homeworldRegionSceneId { /* [XID] */ /* 0x0000000189A33090-0x0000000189A330D0 */ get; /* [XID] */ /* 0x0000000189A3DAD0-0x0000000189A3DB10 */ set; } // 0x000000018147CE40-0x000000018147CEA0 0x000000018147F1A0-0x000000018147F210
	public string activityLimitRegion { /* [XID] */ /* 0x0000000189A480F0-0x0000000189A48110 */ get => default; /* [XID] */ /* 0x0000000189A4F980-0x0000000189A4F9A0 */ set {} } // 0x000000018148FC10-0x000000018148FCB0 0x000000018148DD40-0x000000018148DE60
	public bool isActivityLimitRegion { /* [XID] */ /* 0x0000000189A56F90-0x0000000189A56FB0 */ get => default; } // 0x000000018147D930-0x000000018147DA10 
	public string homeworldLimitRegion { /* [XID] */ /* 0x0000000189A5EB70-0x0000000189A5EB90 */ get => default; /* [XID] */ /* 0x0000000189A66270-0x0000000189A66290 */ set {} } // 0x000000018148A420-0x000000018148A4C0 0x0000000181480CE0-0x0000000181480E00
	public bool isHomeworldLimitRegion { /* [XID] */ /* 0x0000000189A6D9E0-0x0000000189A6DA00 */ get => default; } // 0x0000000181478680-0x0000000181478750 
	public string curLimitRegion { /* [XID] */ /* 0x0000000189A75130-0x0000000189A75150 */ get => default; /* [XID] */ /* 0x0000000189A7CD90-0x0000000189A7CDB0 */ set {} } // 0x0000000181487330-0x0000000181487480 0x0000000181481840-0x00000001814818F0
	public WorldAreaConfig currAreaConfig { /* [XID] */ /* 0x0000000189B3C8A0-0x0000000189B3C8C0 */ get => default; } // 0x0000000181482E10-0x0000000181482F40 
	public uint dungeonCloseTime { /* [XID] */ /* 0x0000000189B44650-0x0000000189B44670 */ get => default; } // 0x00000001814870D0-0x0000000181487170 
	public bool DungeonEntryOpen { /* [XID] */ /* 0x00000001896A8D60-0x00000001896A8D80 */ get => default; /* [XID] */ /* 0x00000001896AFD90-0x00000001896AFDB0 */ set {} } // 0x00000001814845A0-0x0000000181484650 0x0000000181485AA0-0x0000000181485B50

	// Nested types
	public struct ScenePointData // TypeDefIndex: 21554
	{
		// Fields
		public bool isUnlocked; // 0x00
		public ConfigScenePoint config; // 0x08
		public bool isGroupLimit; // 0x10
		public uint entityId; // 0x14
		public uint level; // 0x18
	}

	public struct CityData // TypeDefIndex: 21555
	{
		// Fields
		public uint level; // 0x00
		public uint crystalNum; // 0x04

		// Properties
		public static CityData Default { /* [XID] */ /* 0x0000000189858060-0x0000000189858080 */ get => default; } // 0x0000000182B47E00-0x0000000182B47EB0 

		// Constructors
		public CityData(uint level, uint crystalNum) : this() {
			this.level = default;
			this.crystalNum = default;
		} // 0x0000000182B47EB0-0x0000000182B47F20
	}

	private struct WorldAreaData // TypeDefIndex: 21556
	{
		// Fields
		public bool unlocked; // 0x00
		public float exploreDegree; // 0x04
	}

	// Constructors
	public MapModule() {} // 0x0000000181490490-0x0000000181490830
	static MapModule() {} // 0x00000001814903C0-0x0000000181490490

	// Methods
	// [XID] // 0x000000018995D700-0x000000018995D720
	private string GetTransPointCfgBySceneID(uint sceneID) => default; // 0x00000001814834A0-0x00000001814835D0
	// [IDTag] // 0x0000000189964D70-0x0000000189964DB0
	// [XID] // 0x0000000189964D70-0x0000000189964DB0
	public ConfigScene GetScenePointConfig(uint sceneId) => default; // 0x0000000181479510-0x0000000181479880
	// [XID] // 0x00000001899A3C40-0x00000001899A3C60
	public Dictionary<uint, ScenePointData> GetScenePointDic(uint sceneID) => default; // 0x0000000181485100-0x0000000181485250
	// [XID] // 0x0000000189976BD0-0x0000000189976BF0
	public Dictionary<uint, ScenePointData> TryGetScenePointDic(uint sceneID) => default; // 0x0000000181479970-0x0000000181479A50
	// [XID] // 0x00000001898B9340-0x00000001898B9360
	public Dictionary<uint, uint> GetSceneToBeExploredDungeonEntryDic(uint sceneID) => default; // 0x0000000181484A50-0x0000000181484BA0
	// [XID] // 0x0000000189985B70-0x0000000189985B90
	public Dictionary<uint, uint> GetSceneCanNotBeExploredDungeonEntryDic(uint sceneID) => default; // 0x0000000181479270-0x00000001814793C0
	// [XID] // 0x00000001899D80D0-0x00000001899D80F0
	private Dictionary<uint, ConfigScenePoint> LoadTransPointConfig(uint sceneId) => default; // 0x000000018148D430-0x000000018148D9C0
	// [IDTag] // 0x00000001899951B0-0x00000001899951F0
	// [XID] // 0x00000001899951B0-0x00000001899951F0
	public ConfigScenePoint GetScenePointConfig(uint sceneId, uint pointId) => default; // 0x00000001814793C0-0x0000000181479510
	// [XID] // 0x0000000189B914D0-0x0000000189B914F0
	private void AddTransPoint(uint sceneID, uint pointID, ConfigScenePoint config) {} // 0x0000000181483720-0x0000000181483980
	// [XID] // 0x00000001899A7760-0x00000001899A7780
	private void AddOtherPoint(uint sceneID, uint pointID, ConfigScenePoint config) {} // 0x000000018147DFC0-0x000000018147E1A0
	// [XID] // 0x00000001899AEF70-0x00000001899AEF90
	private void UpdatePointUnlock(uint sceneID, uint pointID, bool isUnlocked, bool init, bool isGroupLimitUnfreeze) {} // 0x0000000181481E80-0x0000000181482490
	// [XID] // 0x00000001899B62F0-0x00000001899B6310
	private void UpdatePointMark(uint sceneID, uint pointID, ConfigScenePoint config, bool unlocked) {} // 0x0000000181488980-0x0000000181488BA0
	// [XID] // 0x00000001899BDF50-0x00000001899BDF70
	private void UpdatePointMark_BuildingPoint(uint sceneID, uint pointID, SceneBuildingPoint config, bool unlocked) {} // 0x000000018147DB10-0x000000018147DE10
	// [XID] // 0x00000001899C5690-0x00000001899C56B0
	private void UpdatePointMark_DungeonEntry(uint sceneID, uint pointID, DungeonEntry config, bool unlocked) {} // 0x0000000181484D00-0x0000000181485100
	// [XID] // 0x00000001899CCDC0-0x00000001899CCDE0
	private void UpdatePointMark_TransPoint(uint sceneID, uint pointID, SceneTransPoint config, bool unlocked) {} // 0x0000000181489660-0x0000000181489980
	// [XID] // 0x00000001899D4300-0x00000001899D4320
	public BaseEntity GetTransPointEntity(uint pointID) => default; // 0x000000018147BA50-0x000000018147BBC0
	// [XID] // 0x00000001899DB9B0-0x00000001899DB9D0
	private void PlayUnlockEffect(BaseEntity entity, bool first) {} // 0x000000018148C5D0-0x000000018148C740
	// [XID] // 0x00000001899E3210-0x00000001899E3230
	private void PlayUnlockEffectImp(BaseEntity entity, bool first) {} // 0x0000000181488BA0-0x0000000181488DA0
	// [XID] // 0x00000001899EA7A0-0x00000001899EA7C0
	private void PlayLevelupEffect(BaseEntity entity, bool first, int level) {} // 0x00000001814852B0-0x00000001814854B0
	// [XID] // 0x00000001899F22F0-0x00000001899F2310
	private void PlayAutoHealEffect(uint pointID) {} // 0x0000000181484140-0x0000000181484390
	// [XID] // 0x00000001899F98D0-0x00000001899F98F0
	private void StopAutoHealEffect(uint pointID) {} // 0x0000000181487900-0x0000000181487B50
	// [XID] // 0x0000000189A00CB0-0x0000000189A00CD0
	public ScenePointData GetTransPointData(uint sceneId, uint pointId) => default; // 0x00000001814899E0-0x0000000181489B50
	// [XID] // 0x0000000189A08590-0x0000000189A085B0
	public bool TryGetTransPointData(uint sceneID, uint pointID, out ScenePointData data) {
		data = default;
		return default;
	} // 0x000000018148A300-0x000000018148A420
	// [XID] // 0x0000000189A0FB90-0x0000000189A0FBB0
	public bool IsPointUnlock(uint sceneId, uint pointId) => default; // 0x0000000181477BE0-0x0000000181477CF0
	// [XID] // 0x0000000189A17010-0x0000000189A17030
	public void LocalTransport(uint sceneID, Vector2 levelMapPos) {} // 0x0000000181483070-0x00000001814834A0
	// [XID] // 0x0000000189A84620-0x0000000189A84640
	public void CheckNeedTransport(bool isInLimitRegion) {} // 0x000000018148F900-0x000000018148FA20
	// [IDTag] // 0x0000000189A8BF60-0x0000000189A8BFA0
	// [XID] // 0x0000000189A8BF60-0x0000000189A8BFA0
	public bool CreateLimitRegion(string name) => default; // 0x0000000181482490-0x00000001814825B0
	// [IDTag] // 0x0000000189A96540-0x0000000189A96580
	// [XID] // 0x0000000189A96540-0x0000000189A96580
	public void DestroyLimitRegion(string name) {} // 0x000000018148D9C0-0x000000018148DAE0
	// [XID] // 0x0000000189AA09C0-0x0000000189AA09E0
	private void InitLimitRegion() {} // 0x00000001814868D0-0x0000000181486CA0
	// [IDTag] // 0x0000000189AA7F60-0x0000000189AA7FA0
	// [XID] // 0x0000000189AA7F60-0x0000000189AA7FA0
	private void CreateLimitRegion(int index, string name) {} // 0x00000001814825B0-0x0000000181482820
	// [IDTag] // 0x0000000189AB2B80-0x0000000189AB2BC0
	// [XID] // 0x0000000189AB2B80-0x0000000189AB2BC0
	private void DestroyLimitRegion(int index) {} // 0x000000018148DAE0-0x000000018148DD40
	// [XID] // 0x0000000189ABD630-0x0000000189ABD650
	private Dictionary<uint, CityData> GetCityDataDic(uint sceneID) => default; // 0x000000018148E020-0x000000018148E170
	// [XID] // 0x0000000189AC50D0-0x0000000189AC50F0
	public bool TryGetCityDataByAreaID(uint sceneID, uint areaID, out CityData cityData) {
		cityData = default;
		return default;
	} // 0x0000000181483F60-0x0000000181484140
	// [XID] // 0x0000000189ACC600-0x0000000189ACC620
	public bool TryGetCityData(uint sceneID, uint cityID, out CityData cityData) {
		cityData = default;
		return default;
	} // 0x00000001814780F0-0x0000000181478240
	// [XID] // 0x0000000189AD4330-0x0000000189AD4350
	private void UpdateCityData(uint sceneID, uint cityID, ref CityData cityData) {} // 0x0000000181485B50-0x0000000181485CE0
	// [XID] // 0x0000000189ADBC80-0x0000000189ADBCA0
	public CityData GetCurrWorldAreaData() => default; // 0x0000000181481600-0x0000000181481720
	// [XID] // 0x0000000189A53850-0x0000000189A53870
	private bool TryGetWorldAreaData(uint sceneID, uint areaID, out WorldAreaData data) {
		data = default;
		return default;
	} // 0x000000018148F7C0-0x000000018148F900
	// [XID] // 0x0000000189AEAF30-0x0000000189AEAF50
	private void UpdateWorldAreaData(uint sceneID, uint areaID, ref WorldAreaData data) {} // 0x0000000181490030-0x00000001814901C0
	// [XID] // 0x0000000189AF2880-0x0000000189AF28A0
	private void UpdateCityLevel(uint sceneID, uint cityID, uint level, uint crystalNum, bool isInit = true /* Metadata: 0x00AFF915 */, uint areaID = 0 /* Metadata: 0x00AFF916 */) {} // 0x000000018147E2C0-0x000000018147E960
	// [XID] // 0x0000000189AFA180-0x0000000189AFA1A0
	private void InitCityLevelView(uint sceneID, uint cityID, uint level) {} // 0x0000000181486E00-0x00000001814870D0
	// [XID] // 0x0000000189B01740-0x0000000189B01760
	private void UpdateCityLevelView(uint sceneID, uint cityID, uint level, uint updateAreaID) {} // 0x0000000181483980-0x0000000181483F60
	// [XID] // 0x0000000189B08C90-0x0000000189B08CB0
	public void DebugUnlock() {} // 0x0000000181478A10-0x0000000181478B50
	// [XID] // 0x0000000189B10710-0x0000000189B10730
	public void RemoveUnlockedArea(uint sceneID, uint areaID) {} // 0x000000018148CB20-0x000000018148CC30
	// [XID] // 0x0000000189B17840-0x0000000189B17860
	public void UnlockArea(uint sceneID, uint areaID) {} // 0x0000000181482820-0x0000000181482900
	// [XID] // 0x0000000189B1F100-0x0000000189B1F120
	private void UnlockWorldArea(uint sceneID, uint areaID, bool isInit = true /* Metadata: 0x00AFF91A */) {} // 0x0000000181480F90-0x00000001814811A0
	// [XID] // 0x0000000189A627C0-0x0000000189A627E0
	public bool IsAreaUnlock(uint sceneID, uint areaID) => default; // 0x000000018147CD40-0x000000018147CE40
	// [XID] // 0x0000000189977FD0-0x0000000189977FF0
	public uint GetCityLevelByAreaID(uint sceneId, uint areaId) => default; // 0x0000000181489570-0x0000000181489660
	// [XID] // 0x0000000189B34FD0-0x0000000189B34FF0
	private void UpdateAreaUnlockView(uint sceneId, uint areaId, bool isInit = true /* Metadata: 0x00AFF91B */) {} // 0x000000018147BFF0-0x000000018147C9B0
	// [XID] // 0x0000000189B4BDE0-0x0000000189B4BE00
	public List<uint> GetDungeonToEntryList(uint dungeonID) => default; // 0x000000018148A1B0-0x000000018148A300
	// [XID] // 0x0000000189B53250-0x0000000189B53270
	public List<uint> GetDungeonToDateList(uint dungeonID) => default; // 0x000000018148F2C0-0x000000018148F410
	// [XID] // 0x0000000189B5AC30-0x0000000189B5AC50
	public void CreateLocalPoints() {} // 0x000000018148B2F0-0x000000018148C2B0
	// [XID] // 0x0000000189B62030-0x0000000189B62050
	private void CreateRandomDungeonDic(uint pointID, SimpleSafeUInt32[] randomDungeonList) {} // 0x0000000181478D90-0x00000001814790B0
	// [XID] // 0x0000000189B69C70-0x0000000189B69C90
	private void CreateRandomDungeonToDateDic(uint whichDate, SimpleSafeUInt32[] randomDungeonList) {} // 0x000000018147FC80-0x000000018147FFA0
	// [XID] // 0x0000000189B71220-0x0000000189B71240
	private void CreateLocalEntity(string id, ConfigLocalEntity config) {} // 0x000000018147D020-0x000000018147D690
	// [XID] // 0x0000000189B788A0-0x0000000189B788C0
	private static void OnEntityReadyPostCallback(EvtEntityReadyPost evt) {} // 0x00000001814818F0-0x0000000181481A00
	// [XID] // 0x0000000189B7FDD0-0x0000000189B7FDF0
	private BaseEntity CreateAirflowField(string id, ConfigAirflowField config) => default; // 0x000000018147DE10-0x000000018147DFC0
	// [XID] // 0x0000000189B878A0-0x0000000189B878C0
	private void LockForceField(string id) {} // 0x000000018147B8F0-0x000000018147BA50
	// [XID] // 0x0000000189B8E9E0-0x0000000189B8EA00
	private void UnlockForceField(string id) {} // 0x000000018148E8F0-0x000000018148ED50
	// [XID] // 0x0000000189B95E80-0x0000000189B95EA0
	public override bool OnPacket(Packet packet) => default; // 0x000000018147A340-0x000000018147AD90
	// [XID] // 0x0000000189B9D440-0x0000000189B9D460
	public void RequestSceneAreas(uint sceneID = 1 /* Metadata: 0x00AFF91C */) {} // 0x0000000181480AE0-0x0000000181480CE0
	// [XID] // 0x0000000189BA4E50-0x0000000189BA4E70
	private void OnGetSceneAreaRsp(GetSceneAreaRsp rsp) {} // 0x000000018148AC90-0x000000018148AFE0
	// [XID] // 0x0000000189BAC030-0x0000000189BAC050
	private void OnSceneAreaUnlockNotify(SceneAreaUnlockNotify notify) {} // 0x0000000181487790-0x0000000181487900
	// [XID] // 0x0000000189BB3830-0x0000000189BB3850
	public void RequestScenePoints(uint sceneID = 1 /* Metadata: 0x00AFF920 */) {} // 0x000000018148A4C0-0x000000018148A6C0
	// [XID] // 0x0000000189BBADC0-0x0000000189BBADE0
	private bool CheckDungeonSatisfiedCond(DungeonEntryExcelConfig dungeonEntryExcelConfig) => default; // 0x000000018147FFA0-0x0000000181480680
	// [XID] // 0x0000000189BC2DB0-0x0000000189BC2DD0
	private void OnGetScenePointRsp(GetScenePointRsp rsp) {} // 0x000000018147F210-0x000000018147FC80
	// [XID] // 0x0000000189BCA510-0x0000000189BCA530
	public void RequestEnterTransPointRegionNotify(uint sceneId, uint pointId) {} // 0x00000001814808C0-0x0000000181480AE0
	// [XID] // 0x0000000189BD1B80-0x0000000189BD1BA0
	public void RequestExitTransPointRegionNotify(uint sceneId, uint pointId) {} // 0x000000018148C900-0x000000018148CB20
	// [XID] // 0x0000000189BD9150-0x0000000189BD9170
	public void ReqPlayerEnterDungeon(uint pointId, uint dungeonID, bool playAudioOnSuccess = false /* Metadata: 0x00AFF924 */) {} // 0x0000000181488E70-0x0000000181489020
	// [XID] // 0x00000001895E5D50-0x00000001895E5D70
	private void OnPlayerEnterDungeonRsp(PlayerEnterDungeonRsp rsp) {} // 0x0000000181482A40-0x0000000181482CD0
	// [XID] // 0x00000001895ED710-0x00000001895ED730
	public void ReqPlayerQuitDungeon(bool isImmediately = false /* Metadata: 0x00AFF925 */) {} // 0x000000018147DA10-0x000000018147DB10
	// [XID] // 0x00000001895F4CE0-0x00000001895F4D00
	private void OnPlayerQuitDungeonRsp(PlayerQuitDungeonRsp rsp) {} // 0x00000001814812E0-0x0000000181481440
	// [XID] // 0x00000001895FC4B0-0x00000001895FC4D0
	private void OnDungeonWayPointNotify(DungeonWayPointNotify rsp) {} // 0x000000018148A6C0-0x000000018148AC90
	// [XID] // 0x000000018988C8A0-0x000000018988C8C0
	public void ReqDungeonWayPointActivate(uint wayPointId) {} // 0x0000000181482F40-0x0000000181483070
	// [XID] // 0x000000018960B750-0x000000018960B770
	private void OnDungeonWayPointActivate(DungeonWayPointActivateRsp rsp) {} // 0x000000018147F020-0x000000018147F1A0
	// [XID] // 0x0000000189612BE0-0x0000000189612C00
	public void SendClientTriggerEventNotify(EventTriggerType eventType, uint forceId) {} // 0x000000018148DE60-0x000000018148DF80
	// [XID] // 0x000000018961A4A0-0x000000018961A4C0
	private void OnSceneForceUnlockNotify(SceneForceUnlockNotify rsp) {} // 0x0000000181484390-0x00000001814845A0
	// [XID] // 0x0000000189621A20-0x0000000189621A40
	private void OnSceneForceLockNotify(SceneForceLockNotify rsp) {} // 0x000000018148F410-0x000000018148F620
	// [XID] // 0x0000000189629330-0x0000000189629350
	private void OnScenePointUnlockNotify(ScenePointUnlockNotify notify) {} // 0x0000000181486040-0x00000001814868D0
	// [XID] // 0x0000000189630C80-0x0000000189630CA0
	private void OnClientTransmitRsp(ClientTransmitRsp rsp) {} // 0x000000018147B710-0x000000018147B8F0
	// [XID] // 0x00000001896386E0-0x0000000189638700
	private void OnQuestTransmitRsp(QuestTransmitRsp rsp) {} // 0x000000018148C2B0-0x000000018148C490
	// [XID] // 0x000000018963FB70-0x000000018963FB90
	private void OnSceneTransToPointRsp(SceneTransToPointRsp rsp) {} // 0x0000000181489150-0x0000000181489330
	// [XID] // 0x0000000189647350-0x0000000189647370
	public void RequestEnterWorldAreaReq(WorldAreaConfig areaCfg) {} // 0x000000018147CBA0-0x000000018147CD40
	// [XID] // 0x000000018964EA40-0x000000018964EA60
	private void OnEnterWorldAreaRsp(EnterWorldAreaRsp rsp) {} // 0x000000018148F620-0x000000018148F7C0
	// [XID] // 0x0000000189656310-0x0000000189656330
	public void RequestSceneGetAreaExplorePointReq() {} // 0x0000000181481A80-0x0000000181481CC0
	// [XID] // 0x000000018965DA30-0x000000018965DA50
	private void OnGetAreaExplorePointRsp(GetAreaExplorePointRsp rsp) {} // 0x0000000181478750-0x0000000181478A10
	// [XID] // 0x0000000189665120-0x0000000189665140
	public string GetAreaExplorePercentText(uint areaId) => default; // 0x0000000181477E50-0x00000001814780F0
	// [XID] // 0x000000018966C7E0-0x000000018966C800
	public void SendScenePlayOutofRegionNotify() {} // 0x000000018147CEA0-0x000000018147D020
	// [XID] // 0x0000000189674630-0x0000000189674650
	public override bool OnNotify(Notify ntf) => default; // 0x000000018148E740-0x000000018148E890
	// [XID] // 0x000000018967BF20-0x000000018967BF40
	private void OnEnterArea(Notify ntf) {} // 0x0000000181478590-0x0000000181478680
	// [XID] // 0x0000000189683510-0x0000000189683530
	private bool OnOpenStateInit(Notify ntf) => default; // 0x0000000181489B50-0x0000000181489C20
	// [XID] // 0x000000018968B110-0x000000018968B130
	private bool OnOpenStateChange(Notify ntf) => default; // 0x0000000181485590-0x0000000181485870
	// [XID] // 0x0000000189692DD0-0x0000000189692DF0
	public override void ClearOnLevelDestroy() {} // 0x000000018147B070-0x000000018147B340
	// [XID] // 0x000000018969A090-0x000000018969A0B0
	public override void ClearOnDisconnect() {} // 0x000000018148E260-0x000000018148E300
	// [XID] // 0x00000001896A18A0-0x00000001896A18C0
	public override void ClearOnBackHome() {} // 0x0000000181481440-0x0000000181481600
	// [XID] // 0x00000001897FD150-0x00000001897FD170
	public void OnDungeonEntryTriggerEnter(uint pointID) {} // 0x000000018148CC30-0x000000018148D430
	// [XID] // 0x00000001896BE8F0-0x00000001896BE910
	public void CloseDungeonEntry(uint pointID) {} // 0x0000000181478BB0-0x0000000181478D90
	// [XID] // 0x00000001896C61F0-0x00000001896C6210
	private void OnDungeonEntryInfoRsp(DungeonEntryInfoRsp rsp) {} // 0x00000001814901C0-0x00000001814903C0
	// [XID] // 0x00000001896CD810-0x00000001896CD830
	private void OnDungeonSettleNotify(DungeonSettleNotify ntf) {} // 0x000000018147BBC0-0x000000018147BFF0
	// [XID] // 0x00000001896D4C40-0x00000001896D4C60
	private void OnDropItemEnterBagInfoNotify(GadgetAutoPickDropInfoNotify dropItemEnterBagInfoNotify) {} // 0x00000001814848E0-0x0000000181484A50
	// [XID] // 0x00000001896DC2C0-0x00000001896DC2E0
	private void OnDungeonPlayerDieNotify(DungeonPlayerDieNotify notify) {} // 0x000000018148E540-0x000000018148E6B0
	// [XID] // 0x00000001896E3A90-0x00000001896E3AB0
	private void OnDungeonShowReminderNotify(DungeonShowReminderNotify rsp) {} // 0x0000000181477AA0-0x0000000181477BE0
	// [XID] // 0x00000001896EAE80-0x00000001896EAEA0
	private void OnDungeonDieOptionRsp(DungeonDieOptionRsp rsp) {} // 0x0000000181486CA0-0x0000000181486E00
	// [XID] // 0x00000001896F2250-0x00000001896F2270
	public void OnPlayerEnterDungeon(PlayerEnterSceneNotify notify) {} // 0x000000018148C490-0x000000018148C5D0
	// [XID] // 0x00000001896F9BF0-0x00000001896F9C10
	public void OnPlayerEnterDungeonReplay() {} // 0x000000018147E960-0x000000018147EF20
	// [XID] // 0x00000001898603D0-0x00000001898603F0
	public void RequestDungeonPlayerDie() {} // 0x0000000181485950-0x0000000181485AA0
	// [XID] // 0x0000000189708C20-0x0000000189708C40
	private void OnDungeonPlayerDieRsp(DungeonPlayerDieRsp rsp) {} // 0x0000000181477970-0x0000000181477AA0
	// [XID] // 0x00000001897104C0-0x00000001897104E0
	public void RequestLevelupCity(uint sceneID, uint areaID, uint crystalNum) {} // 0x0000000181485CE0-0x0000000181485E20
	// [XID] // 0x0000000189717840-0x0000000189717860
	private void OnLevelupCityRsp(LevelupCityRsp rsp) {} // 0x0000000181485E20-0x0000000181486040
	// [XID] // 0x000000018971F370-0x000000018971F390
	private void OnScenePlayerSoundNotify(ScenePlayerSoundNotify rsp) {} // 0x000000018148AFE0-0x000000018148B2F0
	// [XID] // 0x0000000189726960-0x0000000189726980
	private void OnDungeonDataNotify(DungeonDataNotify ntf) {} // 0x0000000181487480-0x0000000181487790
	// [XID] // 0x000000018972DEB0-0x000000018972DED0
	public bool HasDungeonDataLevelConfigId() => default; // 0x000000018148FD70-0x0000000181490030
	// [XID] // 0x0000000189735550-0x0000000189735570
	public void RequestElementResonance(uint sceneID, uint areaID) {} // 0x0000000181481720-0x0000000181481840
	// [XID] // 0x000000018973D0B0-0x000000018973D0D0
	private void OnSceneRouteChangeNotify(SceneRouteChangeNotify notify) {} // 0x0000000181481CC0-0x0000000181481E80
	// [XID] // 0x00000001897445D0-0x00000001897445F0
	private void DoOnPlatformStartRouteNotify(PlatformStartRouteNotify notify) {} // 0x000000018147D770-0x000000018147D930
	// [XID] // 0x000000018974C290-0x000000018974C2B0
	private void OnPlatformStartRouteNotify(PlatformStartRouteNotify notify) {} // 0x0000000181489330-0x0000000181489570
	// [XID] // 0x0000000189753540-0x0000000189753560
	private void DoOnPlatformStopRouteNotify(PlatformStopRouteNotify notify) {} // 0x0000000181484650-0x0000000181484800
	// [XID] // 0x000000018975AA60-0x000000018975AA80
	private void OnPlatformStopRouteNotify(PlatformStopRouteNotify notify) {} // 0x0000000181489E10-0x000000018148A050
	// [XID] // 0x00000001897625D0-0x00000001897625F0
	private void DoOnPlatformChangeRouteNotify(PlatformChangeRouteNotify notify) {} // 0x00000001814790B0-0x0000000181479270
	// [XID] // 0x0000000189769C50-0x0000000189769C70
	private void OnPlatformChangeRouteNotify(PlatformChangeRouteNotify notify) {} // 0x000000018148E300-0x000000018148E540
	// [XID] // 0x0000000189771240-0x0000000189771260
	public void RequestPersonalSceneJump(uint pointID) {} // 0x0000000181482CD0-0x0000000181482E10
	// [XID] // 0x0000000189778AC0-0x0000000189778AE0
	private void OnPersonalSceneJumpRsp(PersonalSceneJumpRsp rsp) {} // 0x00000001814871D0-0x0000000181487330
	// [XID] // 0x00000001897F5910-0x00000001897F5930
	public void RequestUnlockTransPoint(LCScenePoint lcTransPoint) {} // 0x000000018147AD90-0x000000018147B070
	// [XID] // 0x0000000189787920-0x0000000189787940
	private void OnUnlockTransPointRsp(UnlockTransPointRsp rsp) {} // 0x0000000181477CF0-0x0000000181477E50
	// [XID] // 0x000000018978EF40-0x000000018978EF60
	public void RequestDungeonGetStatueDrop() {} // 0x00000001814854B0-0x0000000181485590
	// [XID] // 0x00000001897967B0-0x00000001897967D0
	private void OnDungeonGetStatueDropRsp(DungeonGetStatueDropRsp rsp) {} // 0x0000000181484BA0-0x0000000181484D00
	// [XID] // 0x000000018979E890-0x000000018979E8B0
	public Vector3? GetPersonalSceneEntryPosition(uint sceneID) => default; // 0x00000001814811A0-0x00000001814812E0
	// [XID] // 0x00000001897A5FA0-0x00000001897A5FC0
	public Vector3? GetBigWorldEntryPosition(uint sceneID) => default; // 0x0000000181489020-0x0000000181489150
	// [XID] // 0x00000001897AD470-0x00000001897AD490
	private Vector3? GetEntryPositionFromTo(uint currSceneID, uint sceneID) => default; // 0x0000000181478240-0x0000000181478590
	// [IDTag] // 0x00000001897B5570-0x00000001897B55B0
	// [XID] // 0x00000001897B5570-0x00000001897B55B0
	public bool IsBigWorldScene(SceneType type) => default; // 0x0000000181480ED0-0x0000000181480F90
	// [XID] // 0x00000001897C02E0-0x00000001897C0300
	public bool IsHomeWorldScene(SceneType type) => default; // 0x000000018148FCB0-0x000000018148FD70
	// [IDTag] // 0x00000001897C7AF0-0x00000001897C7B30
	// [XID] // 0x00000001897C7AF0-0x00000001897C7B30
	public bool IsBigWorldScene(uint tarSceneId) => default; // 0x0000000181480E00-0x0000000181480ED0
	// [XID] // 0x00000001897D1D10-0x00000001897D1D30
	public bool GetBigworldEntryScenePos(uint tarSceneId, out uint tarBigWorldSceneId, out Vector3? pos) {
		tarBigWorldSceneId = default;
		pos = default;
		return default;
	} // 0x000000018148EE10-0x000000018148F2C0
	// [XID] // 0x00000001897D9BB0-0x00000001897D9BD0
	public Vector3? GetSceneEntryPos(uint fromSceneId, uint toSceneId) => default; // 0x0000000181479A50-0x000000018147A340
	// [XID] // 0x00000001897E0EE0-0x00000001897E0F00
	public bool TryGetDungeonEntryLevel(uint sceneID, uint dungeonEntryID, out int level) {
		level = default;
		return default;
	} // 0x00000001814835D0-0x0000000181483720
	// [XID] // 0x00000001897E85B0-0x00000001897E85D0
	private void OnDungeonEntryToBeExploreNotify(DungeonEntryToBeExploreNotify notify) {} // 0x0000000181487B50-0x0000000181488110
	// [XID] // 0x00000001897F02C0-0x00000001897F02E0
	private void OnUnfreezeGroupLimitNotify(UnfreezeGroupLimitNotify notify) {} // 0x0000000181480680-0x00000001814808C0
	// [XID] // 0x00000001897F7A10-0x00000001897F7A30
	private void OnGetDailyDungeonEntryInfoRsp(GetDailyDungeonEntryInfoRsp rsp) {} // 0x000000018147C9B0-0x000000018147CBA0
	// [XID] // 0x00000001897FF090-0x00000001897FF0B0
	private void OnGetDungeonEntryExploreConditionRsp(GetDungeonEntryExploreConditionRsp rsp) {} // 0x0000000181489C20-0x0000000181489E10
	// [XID] // 0x0000000189806810-0x0000000189806830
	public void RequestGetDailyDungeonEntryInfo() {} // 0x000000018147E1A0-0x000000018147E2C0
	// [XID] // 0x000000018980DFD0-0x000000018980DFF0
	public void RequestDungeonSlipRevivePointActivate(uint sipRevivePointId) {} // 0x000000018147EF20-0x000000018147F020
	// [XID] // 0x0000000189815670-0x0000000189815690
	private void OnDungeonSlipRevivePointActivateRsp(DungeonSlipRevivePointActivateRsp rsp) {} // 0x0000000181488800-0x0000000181488980
	// [XID] // 0x000000018981D0C0-0x000000018981D0E0
	public void OnShowTemplateReminderNotify(ShowTemplateReminderNotify notify) {} // 0x000000018148C740-0x000000018148C8A0
	// [XID] // 0x00000001898244E0-0x0000000189824500
	public void OnNormalUidOpNotify(NormalUidOpNotify notify) {} // 0x000000018148A050-0x000000018148A1B0
	// [XID] // 0x000000018982BFB0-0x000000018982BFD0
	public void RequestAllMapMarkTips() {} // 0x000000018147D690-0x000000018147D770
	// [XID] // 0x00000001898334C0-0x00000001898334E0
	private void OnGetMapMarkTipsRsp(GetMapMarkTipsRsp rsp) {} // 0x000000018148FA20-0x000000018148FC10
	// [XID] // 0x000000018983A9C0-0x000000018983A9E0
	private bool CheckRemoveEntityIfUnlocked(ConfigScenePoint config, bool isUnlocked) => default; // 0x0000000181482900-0x0000000181482A40
	// [XID] // 0x0000000189841FA0-0x0000000189841FC0
	public bool CheckScenePoint(float time) => default; // 0x0000000181488110-0x00000001814887A0
	// [XID] // 0x0000000189849480-0x00000001898494A0
	protected override void RegisterModulesPkt(NotifyManager notifyMgr) {} // 0x000000018147B340-0x000000018147B710
	// [XID] // 0x0000000189850C60-0x0000000189850C80
	protected override void RegsiterModuleNotify(NotifyManager notifyMgr) {} // 0x000000018148E170-0x000000018148E260
}

