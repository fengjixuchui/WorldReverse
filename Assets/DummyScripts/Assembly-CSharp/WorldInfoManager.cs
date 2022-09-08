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
using MoleMole.Config;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class WorldInfoManager : GlobalManager // TypeDefIndex: 21388
{
	// Fields
	private Dictionary<string, LocalEntityInfoData> _localEntityDataInfoDic; // 0x10
	private List<string> _tempKeyCacheList; // 0x18
	private TickDictionary<uint, WorldTimer> _timerDic; // 0x20
	private TickDictionary<uint, WorldTimer> _globalTimerDic; // 0x28
	private uint _globalTimerId; // 0x30
	private Dictionary<int, TickDictionary<uint, CommonInfoData>> _commonInfoDic; // 0x38
	private Dictionary<uint, Dictionary<uint, EntityMetaData>> _series2Dic; // 0x40
	private Dictionary<uint, Dictionary<uint, EntityMetaData>> _metaDic; // 0x48
	private Dictionary<string, EntityMetaData> _alias2MetaDic; // 0x50

	// Properties
	private uint globalTimerId { /* [XID] */ /* 0x0000000189A01AE0-0x0000000189A01B00 */ get => default; } // 0x0000000181C74850-0x0000000181C74900 

	// Constructors
	public WorldInfoManager() {} // 0x0000000181C75530-0x0000000181C756A0

	// Methods
	// [XID] // 0x0000000189778B00-0x0000000189778B20
	public override void ReloadRes() {} // 0x0000000181C75200-0x0000000181C752A0
	// [XID] // 0x00000001897800C0-0x00000001897800E0
	public void ClearAllLocalEntityInfo() {} // 0x0000000181C72D60-0x0000000181C72E30
	// [XID] // 0x0000000189787960-0x0000000189787980
	public bool HasLocalEntityInfo(string alias) => default; // 0x0000000181C73140-0x0000000181C73210
	// [XID] // 0x000000018978EF80-0x000000018978EFA0
	public LocalEntityInfoData CreateLocalEntityInfoData(uint entityId, ActorType actorType, string alias, string metaPath, uint configId, Vector3 initPos, Vector3 initEuler, uint sceneId, uint roomId, uint dropId, float scale) => default; // 0x0000000181C73BC0-0x0000000181C73E40
	// [XID] // 0x00000001897967F0-0x0000000189796810
	public void ReleaseLocalEntityInfoData(string alias) {} // 0x0000000181C74F20-0x0000000181C75050
	// [XID] // 0x000000018979E8D0-0x000000018979E8F0
	public void RewindLocalEntity() {} // 0x0000000181C733F0-0x0000000181C737D0
	// [XID] // 0x00000001897A6000-0x00000001897A6020
	public void ClearAllTimer() {} // 0x0000000181C738D0-0x0000000181C73980
	// [XID] // 0x0000000189B37A20-0x0000000189B37A40
	public WorldTimer CreateTimer(uint entityId, float duration, WorldTimer.FinishHandler finishHandler) => default; // 0x0000000181C73A30-0x0000000181C73B60
	// [XID] // 0x0000000189AB52C0-0x0000000189AB52E0
	public void ReleaseTimer(WorldTimer timer) {} // 0x0000000181C737D0-0x0000000181C738D0
	// [XID] // 0x00000001897C4560-0x00000001897C4580
	public void ClearAllGlobalTimer() {} // 0x0000000181C73980-0x0000000181C73A30
	// [XID] // 0x00000001897CBD50-0x00000001897CBD70
	public WorldTimer CreateGlobalTimer(float duration, WorldTimer.FinishHandler finishHandler) => default; // 0x0000000181C74DF0-0x0000000181C74F20
	// [XID] // 0x00000001897D3780-0x00000001897D37A0
	public void ReleaseGlobalTimer(WorldTimer timer) {} // 0x0000000181C73F30-0x0000000181C74030
	// [XID] // 0x00000001897DB1F0-0x00000001897DB210
	public void ClearAllCommonInfoData() {} // 0x0000000181C74AC0-0x0000000181C74B70
	public void CreateCommonInfoData<DataType>(uint pkey, params /* 0x000000018989F6F0-0x000000018989F700 */ object[] list)
		where DataType : CommonInfoData, new() {}
	// [XID] // 0x00000001897E9FC0-0x00000001897E9FE0
	public void ReleaseCommonInfoData(CommonInfoData.InfoType infoType, uint pkey) {} // 0x0000000181C73210-0x0000000181C73320
	// [XID] // 0x00000001897F1CB0-0x00000001897F1CD0
	public void RefreshAllCommonInfoData() {} // 0x0000000181C724E0-0x0000000181C72620
	// [XID] // 0x00000001897F94F0-0x00000001897F9510
	private void RefreshCommonInfoData(CommonInfoData infoData) {} // 0x0000000181C75050-0x0000000181C751A0
	// [XID] // 0x0000000189800AD0-0x0000000189800AF0
	public override void Init() {} // 0x0000000181C74420-0x0000000181C744C0
	// [XID] // 0x0000000189808020-0x0000000189808040
	public override void Tick() {} // 0x0000000181C752A0-0x0000000181C75530
	// [XID] // 0x000000018980F9F0-0x000000018980FA10
	public override void ClearOnLevelDestroy() {} // 0x0000000181C72FB0-0x0000000181C73050
	// [XID] // 0x0000000189817000-0x0000000189817020
	public override void ClearOnBackHome(bool forceClear = true /* Metadata: 0x00AFF76E */) {} // 0x0000000181C72E30-0x0000000181C72EF0
	// [XID] // 0x000000018981E890-0x000000018981E8B0
	public override void Destroy() {} // 0x0000000181C73320-0x0000000181C733F0
	// [XID] // 0x0000000189825DA0-0x0000000189825DC0
	public override void ClearOnDisconnect() {} // 0x0000000181C72EF0-0x0000000181C72FB0
	// [XID] // 0x000000018982D4E0-0x000000018982D500
	private EntityMetaData CreateDummyEntityMetaData(string alias) => default; // 0x0000000181C74750-0x0000000181C74850
	// [XID] // 0x00000001896540F0-0x0000000189654110
	private EntityMetaData CreateEntityMetaData(uint configId, uint subKeyId, uint sceneId, uint roomId) => default; // 0x0000000181C728F0-0x0000000181C72A30
	// [IDTag] // 0x000000018983C310-0x000000018983C350
	// [XID] // 0x000000018983C310-0x000000018983C350
	public EntityMetaData GetEntityMetaData(uint configId, uint subKeyId, uint sceneId, uint roomId) => default; // 0x0000000181C722D0-0x0000000181C724E0
	// [IDTag] // 0x00000001898468B0-0x00000001898468F0
	// [XID] // 0x00000001898468B0-0x00000001898468F0
	public EntityMetaData GetEntityMetaData(uint configId, uint subKeyId) => default; // 0x0000000181C721A0-0x0000000181C722D0
	// [XID] // 0x0000000189850CC0-0x0000000189850CE0
	public EntityMetaData GetEntityMetaByAlias(string alias) => default; // 0x0000000181C72800-0x0000000181C728F0
	// [XID] // 0x00000001898580C0-0x00000001898580E0
	public void RemoveEntityMeta(uint configId, uint subKeyId) {} // 0x0000000181C74540-0x0000000181C74750
	// [XID] // 0x000000018985F190-0x000000018985F1B0
	public void UpdateAlias(uint configId, uint subKeyId, string newAlias = null, string newMetaPath = null) {} // 0x0000000181C74030-0x0000000181C74370
	// [XID] // 0x0000000189A62780-0x0000000189A627A0
	private uint GetSeriesId(uint mainQuestId) => default; // 0x0000000181C73050-0x0000000181C73140
	// [XID] // 0x000000018986E270-0x000000018986E290
	public void UpdateNpcSeriesEntity(uint configId, uint mainQuestId) {} // 0x0000000181C72B70-0x0000000181C72D60
	// [XID] // 0x0000000189A53810-0x0000000189A53830
	public void UpdateNpcSeriesMeta(uint configId, uint mainQuestId) {} // 0x0000000181C720A0-0x0000000181C721A0
	// [XID] // 0x0000000189A5AFA0-0x0000000189A5AFC0
	private bool UpdateNpcSeriesMetaInternal(uint configId, uint mainQuestId, out EntityMetaData destroyNpcMeta, out bool needRemoveOld) {
		destroyNpcMeta = default;
		needRemoveOld = default;
		return default;
	} // 0x0000000181C74C20-0x0000000181C74DF0
	// [XID] // 0x0000000189A6A5A0-0x0000000189A6A5C0
	private bool GetNpcSeriesMetaData(uint configId, uint seriesId, out EntityMetaData metaData, out bool needRemoveOld) {
		metaData = default;
		needRemoveOld = default;
		return default;
	} // 0x0000000181C72620-0x0000000181C72800
	// [XID] // 0x0000000189A71970-0x0000000189A71990
	private void RemoveNpcSeriesMetaData(uint configId, uint seriesId) {} // 0x0000000181C72A30-0x0000000181C72B70
	// [XID] // 0x0000000189A80C00-0x0000000189A80C20
	private void AddNpcSeriesMetaData(uint configId, uint seriesId, EntityMetaData metaData) {} // 0x0000000181C74900-0x0000000181C74AC0
	// [XID] // 0x000000018989A6F0-0x000000018989A710
	public EntityMetaData AddDummyEntityMetaData(string alias) => default; // 0x0000000181C73E40-0x0000000181C73F30
	// [XID] // 0x00000001898A1940-0x00000001898A1960
	public void ClearMetaDataDic() {} // 0x0000000181C74B70-0x0000000181C74C20
	// [XID] // 0x00000001898A9170-0x00000001898A9190
	public void ClearMetaDataAlias() {} // 0x0000000181C74370-0x0000000181C74420
}

