/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class HomeworldManager : InLevelManager, INotifyInterface // TypeDefIndex: 20827
{
	// Fields
	private Dictionary<GadgetEntity, FurnitureDataInternal> _gadget2InternalDataCache; // 0x10
	private Dictionary<GadgetEntity, HomeWorldFurnitureExcelConfig> _gadget2ExcelConfigMap; // 0x18
	private HashSet<FurnitureDataInternal> _serilizeInternalDataSet; // 0x20
	private List<HomeworldFurnitureDataEX> _serilizeSaveDataBuffer; // 0x28
	private Dictionary<FurnitureDataInternal, int> _internalDataIndexMap; // 0x30
	private HashSet<FurnitureDataInternal> _serilizeVerifySet; // 0x38
	private List<FurnitureDataInternal> _serilizeDataBuffer; // 0x40
	private Dictionary<GadgetEntity, FurnitureSuiteDataInternal> _gadget2FurnitureSuiteIDMap; // 0x48
	private Dictionary<GadgetEntity, FurnitureSuiteDataInternal> _rootGadget2FurnitureSuiteIDMap; // 0x50
	private Dictionary<uint, uint> _itemID2NumMap; // 0x58
	private Dictionary<uint, uint> _itemID2DeployNumMap; // 0x60
	private Dictionary<uint, uint> _roomID2MinUnlockWorldLevelDict; // 0x68
	private Vector3 _editCameraAnchorPoint; // 0x70
	private float _zoomFadeOutTime; // 0x7C
	private float _rotateFadeOutTime; // 0x80
	private float _moveFadeOutTime; // 0x84
	public Vector2 zoomSpeedRatio; // 0x88
	private const string HOMEWORLD_SAVELOC = "/Homeworld/HomeworldSave.json"; // Metadata: 0x00AFE5D7
	private const string HOMEWORLD_EXTERIOR_SAVELOC = "/Homeworld/HomeworldExteriorSave.json"; // Metadata: 0x00AFE5F8
	private const string PLACE_COL_PATH = "ART/Others/Homeworld/SceneObj/"; // Metadata: 0x00AFE621
	private HomeworldSaveDataEx _saveData; // 0x90
	private HomeworldSaveDataEx _correspondingSceneSaveData; // 0x98
	public static HomeworldSaveDataEx _debugData; // 0x00
	private uint _homeworldSceneID; // 0xA0
	private Dictionary<string, ulong> _placeColPathDict; // 0xA8
	private float fadeInOutEditor; // 0xB0
	private float fadeHoldOpenEditorShort; // 0xB4
	private float fadeHoldOpenEditorLong; // 0xB8
	private float fadeHoldCloseEditorShort; // 0xBC
	private Dictionary<uint, HomeWorldFurnitureExcelConfig> _itemID2ExcelConfigMap; // 0xC0
	private Dictionary<uint, Dictionary<uint, HomeWorldSpecialFurnitureExcelConfig>> _sceneID2SpecialConfigMapDict; // 0xC8
	private Dictionary<uint, HomeworldNPCExcelData> _furnitureID2NPCExclConfigDict; // 0xD0
	private Dictionary<uint, ConfigHomeworldFurnitureSet> _furnitureSetID2JsonConfigDict; // 0xD8
	private GameObject _sceneConfig; // 0xE0
	private string _sceneConfigPath; // 0xE8
	private bool _currentSceneArrangementInfoRequested; // 0xF0
	private uint _correspondingSceneID; // 0xF4
	private List<uint> _envNPCSave; // 0xF8
	private HomeworldSaveDataEx _uploadingSaveData; // 0x100
	public Action<bool> enterHomeworldEditorCallack; // 0x108
	private List<MonoHomeworldEnvironmentSetting> _envSettings; // 0x110
	private MonoHomeworldSetting _homeSetting; // 0x118
	private MonoHomeworldEnvironmentSetting _focusedEnvSetting; // 0x120
	private float _openEditorTimer; // 0x128
	private bool _homeworldCameraReady; // 0x12C
	private bool _editorOpen; // 0x12D
	private bool _revertSaveOnClose; // 0x12E
	private bool _interiorEnvrionmentSet; // 0x12F
	private static List<uint> _defaultPersistentRoomFurnitureSet; // 0x08
	private static List<uint> _defaultGlobalFurnitureSet; // 0x10
	private static uint _defaultFurnitureSuiteGadget; // 0x18
	public bool debugLogParentship; // 0x130
	public bool debugLogFurnitureSuite; // 0x131
	public bool debugLogBreifResult; // 0x132
	public bool debugRaycastResult; // 0x133
	public bool debugVerifyCollisionResult; // 0x134
	public bool useItemLimit; // 0x135
	public static bool noCostLimit; // 0x1C
	private Dictionary<GadgetEntity, FurnitureParentshipSet> _rootEntityParentshipSets; // 0x138
	private Dictionary<GadgetEntity, FurnitureParentshipSet> _entity2ParentshipSetDict; // 0x140
	private bool _loadingSavedFurnitures; // 0x148
	private HashSet<GadgetEntity> _FirstTimeFurnitureOnLoading; // 0x150
	private List<GadgetEntity> _furnitureSetCache; // 0x158
	private Dictionary<GadgetEntity, GadgetEntity> _replacePersistentEntityMap; // 0x160
	private List<FurnitureDataInternal> _dataToBeRemoved; // 0x168
	private List<FurnitureDataInternal> _childToBeRemoveDataBuffer; // 0x170
	private List<GadgetEntity> _entityToBeRemoved; // 0x178
	private List<GadgetEntity> _cacheEntityToBeRemoved; // 0x180
	private bool _navMeshSpawned; // 0x188
	private bool _asyncBakeNavMesh; // 0x189
	private List<uint> _npcIDList; // 0x190
	private HomeWorldFurnitureExcelConfig _apartmentConfig; // 0x198
	private GadgetEntity _apartmentEntity; // 0x1A0
	private BaseEntity _apartmentEntrance; // 0x1A8
	private Transform _djinnTransform; // 0x1B0

	// Properties
	public Vector3 editCameraAnchorPoint { /* [XID] */ /* 0x00000001895EA8A0-0x00000001895EA8C0 */ get => default; /* [XID] */ /* 0x00000001895F1DB0-0x00000001895F1DD0 */ set {} } // 0x00000001838A2030-0x00000001838A2110 0x00000001838B2AB0-0x00000001838B2B80
	private static string PLACE_POL_PATH_CONFIG { /* [XID] */ /* 0x00000001896172D0-0x00000001896172F0 */ get => default; } // 0x00000001838A82F0-0x00000001838A8390 
	private static string FURNITURE_SET_DIR_PATH { /* [XID] */ /* 0x000000018961EEC0-0x000000018961EEE0 */ get => default; } // 0x00000001838AD4C0-0x00000001838AD560 
	public Dictionary<uint, HomeWorldFurnitureExcelConfig> itemID2ExcelConfigMap { /* [XID] */ /* 0x0000000189626280-0x00000001896262A0 */ get => default; } // 0x00000001838AB060-0x00000001838AB110 
	public Dictionary<uint, HomeworldNPCExcelData> furnitureID2NPCExclConfigDict { /* [XID] */ /* 0x000000018962DC30-0x000000018962DC50 */ get => default; } // 0x00000001838B0E10-0x00000001838B0EC0 
	public Dictionary<uint, ConfigHomeworldFurnitureSet> furnitureSetID2JsonConfigDict { /* [XID] */ /* 0x0000000189635830-0x0000000189635850 */ get => default; } // 0x00000001838A9550-0x00000001838A9600 
	public MonoHomeworldSetting homeSetting { /* [XID] */ /* 0x000000018972AFB0-0x000000018972AFD0 */ get => default; } // 0x00000001838AC6C0-0x00000001838AC770 
	public List<MonoHomeworldEnvironmentSetting> envSetting { /* [XID] */ /* 0x0000000189732720-0x0000000189732740 */ get => default; } // 0x00000001838B0F60-0x00000001838B1010 
	public Transform djinnTransform { /* [XID] */ /* 0x00000001898E5660-0x00000001898E5680 */ get => default; } // 0x00000001838ABA90-0x00000001838ABB40 
	public Transform _avatarBornTransform { /* [XID] */ /* 0x00000001898ECEC0-0x00000001898ECF00 */ get; /* [XID] */ /* 0x00000001898F7930-0x00000001898F7970 */ private set; } // 0x00000001838A0290-0x00000001838A02F0 0x00000001838AFEA0-0x00000001838AFF10

	// Constructors
	public HomeworldManager() {} // 0x00000001838B34B0-0x00000001838B3A30
	static HomeworldManager() {} // 0x00000001838B3320-0x00000001838B34B0

	// Methods
	// [XID] // 0x0000000189B14AB0-0x0000000189B14AD0
	public uint GetGadgetIDFromItemID(uint itemID, int slotIndex) => default; // 0x00000001838B1760-0x00000001838B1A80
	// [XID] // 0x0000000189B1C470-0x0000000189B1C490
	private FurnitureDataInternal CreateNewFurnInternalData(HomeWorldFurnitureExcelConfig excelConfig, int roomID = -1 /* Metadata: 0x00AFE5A6 */, GadgetEntity entity = null, GadgetEntity parentEntity = null) => default; // 0x000000018389ED40-0x000000018389EEB0
	// [XID] // 0x0000000189B239C0-0x0000000189B239E0
	public FurnitureDataInternal GetFurnInternalDataFromEntity(GadgetEntity editEntity) => default; // 0x00000001838A04B0-0x00000001838A06B0
	// [XID] // 0x0000000189B2ACE0-0x0000000189B2AD00
	public bool IsFurntirueDeployableProp(GadgetEntity entity) => default; // 0x00000001838A03D0-0x00000001838A04B0
	// [XID] // 0x0000000189B32220-0x0000000189B32240
	public HomeWorldFurnitureExcelConfig GetFurnitureExcelDataFromEntity(GadgetEntity entity) => default; // 0x00000001838ABB40-0x00000001838ABC30
	// [XID] // 0x0000000189B39BB0-0x0000000189B39BD0
	public void UpdateFurnitureAfterEdit(GadgetEntity targetEntity) {} // 0x00000001838A2BB0-0x00000001838A2CD0
	// [XID] // 0x0000000189B41490-0x0000000189B414B0
	public void AddFurnitureToList(FurnitureDataInternal furnData) {} // 0x000000018389F8A0-0x000000018389F9C0
	// [XID] // 0x0000000189B48DE0-0x0000000189B48E00
	public void UpdateFurnDataParentship(FurnitureDataInternal furnData) {} // 0x00000001838A0BF0-0x00000001838A0DA0
	// [XID] // 0x0000000189B50480-0x0000000189B504A0
	public void SerilizedFurnitureData(MonoHomeworldEnvironmentSetting roomSetting) {} // 0x00000001838AEBF0-0x00000001838AF9A0
	// [XID] // 0x0000000189B57CD0-0x0000000189B57CF0
	private void ClearSerilizeBuffers() {} // 0x00000001838B2F50-0x00000001838B3070
	// [XID] // 0x0000000189B5F6E0-0x0000000189B5F700
	private bool InitFurnitureSaveData(FurnitureDataInternal internData, HomeworldFurnitureDataEX saveData, int parentIndex, MonoHomeworldEnvironmentSetting roomSetting) => default; // 0x00000001838A2CD0-0x00000001838A2F40
	// [XID] // 0x0000000189B66DC0-0x0000000189B66DE0
	public FurnitureSuiteDataInternal GetFurnitureSuiteDataInternalFromEntity(GadgetEntity entity) => default; // 0x00000001838B3070-0x00000001838B3160
	// [XID] // 0x0000000189B6E120-0x0000000189B6E140
	public bool IsFurnitureBelongToSuite(GadgetEntity furniture, FurnitureSuiteDataInternal suite) => default; // 0x00000001838AF9A0-0x00000001838AFAB0
	// [XID] // 0x0000000189B75910-0x0000000189B75930
	public FurnitureSuiteDataInternal CreateNewFurnitureSuiteDataInternal(uint setID, ConfigHomeworldFurnitureSet jsonConfig, FurnitureDataInternal rootFurniture, MonoHomeworldEnvironmentSetting envSetting) => default; // 0x00000001838A8B90-0x00000001838A8EA0
	// [XID] // 0x0000000189B7CDF0-0x0000000189B7CE10
	public void AddFurnitureToFurnitureSuite(FurnitureDataInternal furniture, FurnitureSuiteDataInternal suite) {} // 0x00000001838A2390-0x00000001838A24F0
	// [XID] // 0x0000000189B84C50-0x0000000189B84C70
	public void RemoveFurnitureSuiteDataInternal(FurnitureSuiteDataInternal suite, MonoHomeworldEnvironmentSetting envSetting) {} // 0x00000001838A8730-0x00000001838A8980
	// [XID] // 0x0000000189B8BA00-0x0000000189B8BA20
	public void BreakFurnitureSuite(FurnitureSuiteDataInternal suite, MonoHomeworldEnvironmentSetting envSetting) {} // 0x00000001838AE340-0x00000001838AE4F0
	// [XID] // 0x0000000189B931F0-0x0000000189B93210
	public uint GetFurnitureItemNumTotal(uint itemID, HomeWorldFurnitureExcelConfig excelConfig = null) => default; // 0x00000001838AE160-0x00000001838AE340
	// [XID] // 0x0000000189B9A780-0x0000000189B9A7A0
	public uint GetDeployedFurnitureItemNum(uint itemID, HomeWorldFurnitureExcelConfig excelConfig = null) => default; // 0x00000001838A06B0-0x00000001838A07B0
	// [XID] // 0x0000000189BA1F70-0x0000000189BA1F90
	public uint GetUndeployedFurnitureItemNum(uint itemID) => default; // 0x000000018389F370-0x000000018389F530
	// [XID] // 0x0000000189BA9340-0x0000000189BA9360
	public void RefreshFurnitureNumber() {} // 0x00000001838AD230-0x00000001838AD4C0
	// [XID] // 0x0000000189BB0B10-0x0000000189BB0B30
	public void RefreshDeployedFurnitureNumber() {} // 0x00000001838AD560-0x00000001838ADBA0
	// [XID] // 0x0000000189BB7DC0-0x0000000189BB7DE0
	public void UpdateFurnitureSceneProp(MonoPatternSceneProp sceneProp, GadgetEntity entity) {} // 0x00000001838A38E0-0x00000001838A3A50
	// [XID] // 0x0000000189BBF490-0x0000000189BBF4B0
	private void InitHomeLevelData() {} // 0x000000018389F620-0x000000018389F8A0
	// [XID] // 0x0000000189BC7050-0x0000000189BC7070
	public uint GetCurrentHomeLevel() => default; // 0x00000001838A4C20-0x00000001838A4D10
	// [XID] // 0x0000000189BCEDA0-0x0000000189BCEDC0
	public uint GetEnvrionmentMinimunUnlockLevel(MonoHomeworldEnvironmentSetting envSetting) => default; // 0x00000001838A9D90-0x00000001838A9EC0
	// [XID] // 0x0000000189BD60C0-0x0000000189BD60E0
	public bool IsRoomUnlocked(MonoHomeworldEnvironmentSetting envSetting) => default; // 0x00000001838A02F0-0x00000001838A03D0
	// [XID] // 0x0000000189BDDC60-0x0000000189BDDC80
	public void UpdateRoomUnlockStatus() {} // 0x00000001838A9BE0-0x00000001838A9D90
	// [XID] // 0x00000001895F96F0-0x00000001895F9710
	public void SetCameraFadeOutTime(float zoom, float rotate, float move) {} // 0x00000001838A9600-0x00000001838A96F0
	// [XID] // 0x0000000189600E20-0x0000000189600E40
	public void GetCameraFadeOutSetting(out float zoom, out float rotate, out float move) {
		zoom = default;
		rotate = default;
		move = default;
	} // 0x00000001838AC390-0x00000001838AC480
	// [XID] // 0x0000000189608750-0x0000000189608770
	public void GetZoomSpeedRatio(out float zoomSpeedRatioMin, out float zoomSpeedRatioMax) {
		zoomSpeedRatioMin = default;
		zoomSpeedRatioMax = default;
	} // 0x00000001838B1BF0-0x00000001838B1CC0
	// [XID] // 0x000000018960FF70-0x000000018960FF90
	public bool GetEditCameraBound(out Transform refTransform, out Vector3 center, out Vector3 bound) {
		refTransform = default;
		center = default;
		bound = default;
		return default;
	} // 0x00000001838A3040-0x00000001838A3280
	// [XID] // 0x000000018963CEF0-0x000000018963CF10
	public bool TryGetFurnitureExcelData(uint itemID, out HomeWorldFurnitureExcelConfig excelConfig) {
		excelConfig = default;
		return default;
	} // 0x00000001838B2E60-0x00000001838B2F50
	// [XID] // 0x00000001896444B0-0x00000001896444D0
	public override void Init() {} // 0x00000001838AAE30-0x00000001838AAED0
	// [XID] // 0x000000018964BD30-0x000000018964BD50
	public override void Destroy() {} // 0x00000001838A2620-0x00000001838A2870
	// [XID] // 0x0000000189653380-0x00000001896533A0
	public override void InitOnConnect() {} // 0x00000001838AAD50-0x00000001838AAE30
	// [XID] // 0x000000018965ABD0-0x000000018965ABF0
	public override void ClearOnDisconnect() {} // 0x00000001838A1490-0x00000001838A1870
	// [XID] // 0x0000000189662060-0x0000000189662080
	private void RevertAllRoomOnDisconnect() {} // 0x00000001838A41D0-0x00000001838A4300
	// [XID] // 0x0000000189669C60-0x0000000189669C80
	public override void Tick() {} // 0x00000001838B3270-0x00000001838B3320
	// [XID] // 0x0000000189671860-0x0000000189671880
	public void InitHomeworldManager() {} // 0x00000001838A4D10-0x00000001838A5C50
	// [XID] // 0x0000000189679070-0x0000000189679090
	public bool OnNotify(Notify ntf) => default; // 0x00000001838B29E0-0x00000001838B2AB0
	// [XID] // 0x0000000189680790-0x00000001896807B0
	public string GetHomeworldName() => default; // 0x00000001838AC480-0x00000001838AC550
	// [XID] // 0x0000000189688320-0x0000000189688340
	public uint GetHomewrldID() => default; // 0x000000018389FC40-0x000000018389FD20
	// [XID] // 0x000000018968FBA0-0x000000018968FBC0
	public void RequestCurrentHomeworldArrangementInfo() {} // 0x00000001838A24F0-0x00000001838A2620
	// [XID] // 0x00000001896975A0-0x00000001896975C0
	public void RequestCorrespondingHomeworldArrangementInfo(uint sceneID) {} // 0x00000001838A7F30-0x00000001838A8020
	// [XID] // 0x000000018969EAD0-0x000000018969EAF0
	public void OnGetCurrentSceneArrangementInfoRsp(HomeworldSaveDataEx saveData) {} // 0x00000001838A1EB0-0x00000001838A2030
	// [XID] // 0x00000001896A5C20-0x00000001896A5C40
	public void OnGetHomeworldCorrespondingSceneArrangementInfoRsp(HomeworldSaveDataEx sceneSaveData) {} // 0x00000001838A4A50-0x00000001838A4B10
	// [XID] // 0x00000001896AD310-0x00000001896AD330
	public bool IsEditing() => default; // 0x00000001838ACA30-0x00000001838ACB00
	// [XID] // 0x00000001896B4A70-0x00000001896B4A90
	public void LoadHomeWorld(MonoHomeworldEnvironmentSetting roomSetting = null) {} // 0x000000018389F9C0-0x000000018389FC40
	// [XID] // 0x00000001896BBC60-0x00000001896BBC80
	private string GetDataPath() => default; // 0x00000001838AC880-0x00000001838ACA30
	// [XID] // 0x00000001896C3120-0x00000001896C3140
	private void LoadHomeWorldSave(MonoHomeworldEnvironmentSetting roomSetting) {} // 0x00000001838AB460-0x00000001838ABA90
	// [XID] // 0x00000001896CA630-0x00000001896CA650
	public void SetAllDoorFurniture(uint furnitureID) {} // 0x00000001838B3160-0x00000001838B3270
	// [XID] // 0x00000001896D1CC0-0x00000001896D1CE0
	public void SetAllStairFurniture(uint furnitureID) {} // 0x00000001838A4B10-0x00000001838A4C20
	// [XID] // 0x00000001896D9550-0x00000001896D9570
	public void LoadDefaultRoom(MonoHomeworldEnvironmentSetting roomSetting) {} // 0x00000001838A3280-0x00000001838A3430
	// [XID] // 0x00000001896E0D10-0x00000001896E0D30
	public void LoadRoomSave(HomeworldBlockData blockSave) {} // 0x00000001838AA750-0x00000001838AAD50
	// [XID] // 0x00000001896E7FC0-0x00000001896E7FE0
	public void LoadSavedFurnitureForRoom(MonoHomeworldEnvironmentSetting envSetting) {} // 0x00000001838ACD40-0x00000001838ACF30
	// [XID] // 0x00000001896EF660-0x00000001896EF680
	private void SavedFurnituresLoadComplete() {} // 0x000000018389F530-0x000000018389F620
	// [XID] // 0x00000001896F6F90-0x00000001896F6FB0
	private MonoHomeworldEnvironmentSetting GetEnvSettingByRoomID(int roomID) => default; // 0x00000001838B1180-0x00000001838B1310
	// [XID] // 0x00000001896FE8E0-0x00000001896FE900
	public static PersistentFurnitureType SurfaceToFurnitureType(FurnitureDeploySurfaceType surfaceType) => default; // 0x00000001838A4960-0x00000001838A4A50
	// [XID] // 0x0000000189705B40-0x0000000189705B60
	private void UploadSaveToServer(bool saveToDefault = false /* Metadata: 0x00AFE5AA */) {} // 0x00000001838A5D50-0x00000001838A7920
	// [XID] // 0x000000018970D590-0x000000018970D5B0
	public void OnUploadSaveToServerRsp(int retCode) {} // 0x00000001838A8390-0x00000001838A8540
	// [XID] // 0x0000000189714990-0x00000001897149B0
	public void SaveHomeWorldSetting() {} // 0x00000001838ACF30-0x00000001838ACFD0
	// [XID] // 0x000000018971C420-0x000000018971C440
	public void SaveHomeworldDefaultSetting() {} // 0x00000001838ACBF0-0x00000001838ACC90
	// [XID] // 0x0000000189723810-0x0000000189723830
	public void ClearHomeWorld(bool loadDefault = true /* Metadata: 0x00AFE5AB */) {} // 0x00000001838A7920-0x00000001838A7BD0
	// [XID] // 0x0000000189739E60-0x0000000189739E80
	public void TryOpenHomeworldEditor() {} // 0x00000001838B2610-0x00000001838B2740
	// [XID] // 0x00000001897419C0-0x00000001897419E0
	public void MarkHomeworldCameraReady() {} // 0x00000001838B0EC0-0x00000001838B0F60
	[DebuggerHidden] // 0x00000001897492E0-0x0000000189749320
	// [XID] // 0x00000001897492E0-0x0000000189749320
	private IEnumerator OpenEditorCoroutine(MonoHomeworldEnvironmentSetting roomSetting) => default; // 0x00000001838ABD60-0x00000001838ABE80
	// [XID] // 0x0000000189753660-0x0000000189753680
	public void OpenHomeworldEditor() {} // 0x00000001838AFAB0-0x00000001838AFD20
	// [XID] // 0x000000018975AB60-0x000000018975AB80
	public void TryCloseHomeworldEditor(bool revertSave) {} // 0x00000001838A7BD0-0x00000001838A7D20
	// [XID] // 0x0000000189762690-0x00000001897626B0
	public void CloseHomeworldEditor() {} // 0x00000001838A96F0-0x00000001838A9850
	[DebuggerHidden] // 0x0000000189769CF0-0x0000000189769D30
	// [XID] // 0x0000000189769CF0-0x0000000189769D30
	private IEnumerator CloseEditorCoroutine(bool revertSaveExit) => default; // 0x00000001838A2A90-0x00000001838A2BB0
	// [XID] // 0x00000001897740A0-0x00000001897740C0
	private void OnEditorPageClose() {} // 0x00000001838B2D10-0x00000001838B2E00
	// [XID] // 0x000000018977B820-0x000000018977B840
	private MonoHomeworldEnvironmentSetting GetNextNeighbourEnvSetting(MonoHomeworldEnvironmentSetting currentEnv, int itrNum) => default; // 0x00000001838B1470-0x00000001838B1760
	// [XID] // 0x00000001897832B0-0x00000001897832D0
	public bool ToNextEditEnvSetting(HomeworldEditorPageContext editPage, float fadeTime = 0.25f /* Metadata: 0x00AFE5AC */, float fadeHold = 0.1f /* Metadata: 0x00AFE5B0 */) => default; // 0x00000001838A8540-0x00000001838A8730
	// [XID] // 0x000000018978A8A0-0x000000018978A8C0
	public bool ToPrevEditEnvSetting(HomeworldEditorPageContext editPage, float fadeTime = 0.25f /* Metadata: 0x00AFE5B4 */, float fadeHold = 0.1f /* Metadata: 0x00AFE5B8 */) => default; // 0x00000001838AC1A0-0x00000001838AC390
	// [XID] // 0x0000000189791F20-0x0000000189791F40
	public void ToEditEnvOfRoomID(int roomID, HomeworldEditorPageContext editPage, float fadeTime = 0.25f /* Metadata: 0x00AFE5BC */, float fadeHold = 0.1f /* Metadata: 0x00AFE5C0 */) {} // 0x00000001838AE970-0x00000001838AEB50
	[DebuggerHidden] // 0x00000001897995F0-0x0000000189799630
	// [XID] // 0x00000001897995F0-0x0000000189799630
	private IEnumerator SwitchRoomCoroutine(MonoHomeworldEnvironmentSetting source, MonoHomeworldEnvironmentSetting target, HomeworldEditorPageContext page, float fadeTime, float holdTime) => default; // 0x00000001838AAED0-0x00000001838AB060
	// [XID] // 0x00000001897A4510-0x00000001897A4530
	public void SwitchEditEnvSetting(MonoHomeworldEnvironmentSetting currentEnv, MonoHomeworldEnvironmentSetting nextEnv, HomeworldEditorPageContext editPage, bool instant) {} // 0x00000001838AFD20-0x00000001838AFEA0
	// [XID] // 0x00000001897ABA60-0x00000001897ABA80
	public void RegisterRoomToManager(MonoHomeworldEnvironmentSetting room) {} // 0x00000001838A1870-0x00000001838A1940
	// [XID] // 0x00000001897B39E0-0x00000001897B3A00
	public void RegisterSettingToManager(MonoHomeworldSetting homeworldSetting) {} // 0x00000001838A89E0-0x00000001838A8B90
	// [XID] // 0x00000001897BB7F0-0x00000001897BB810
	public void UpdateInteriorEnvironmentSetting() {} // 0x00000001838B2740-0x00000001838B29E0
	// [XID] // 0x00000001897C3050-0x00000001897C3070
	public void RemoveRoomFromManager(MonoHomeworldEnvironmentSetting room) {} // 0x00000001838AD160-0x00000001838AD230
	// [XID] // 0x00000001897CA8F0-0x00000001897CA910
	public MonoHomeworldEnvironmentSetting GetRoomOfID(int roomID) => default; // 0x000000018389FD20-0x000000018389FE80
	// [XID] // 0x00000001897D1EB0-0x00000001897D1ED0
	public HomeWorldAreaComfortExcelConfig GetAreaConfigOfCurrentScene(int roomID) => default; // 0x00000001838AE4F0-0x00000001838AE790
	// [XID] // 0x00000001897D9D10-0x00000001897D9D30
	public void SetFocusOnSetting(MonoHomeworldEnvironmentSetting focusSetting) {} // 0x00000001838ADD10-0x00000001838AE160
	// [XID] // 0x00000001897E1060-0x00000001897E1080
	public MonoHomeworldEnvironmentSetting GetCurrentRoom(Vector3 position) => default; // 0x00000001838A3490-0x00000001838A38E0
	// [XID] // 0x00000001897E87B0-0x00000001897E87D0
	public void ResetEnvSetting(MonoHomeworldEnvironmentSetting resetSetting) {} // 0x00000001838A8020-0x00000001838A82F0
	// [XID] // 0x00000001897F0400-0x00000001897F0420
	public void CreateParentshipSet(GadgetEntity rootEntity) {} // 0x00000001838ACFD0-0x00000001838AD160
	// [XID] // 0x00000001897F7B50-0x00000001897F7B70
	public void RegisterParentshipSet(GadgetEntity entity, GadgetEntity parent) {} // 0x00000001838B2B80-0x00000001838B2D10
	// [XID] // 0x00000001897FF1D0-0x00000001897FF1F0
	public void EntityParentshipSetLoadFinish(GadgetEntity rootEntity) {} // 0x00000001838AC770-0x00000001838AC880
	// [XID] // 0x0000000189806930-0x0000000189806950
	private void UpdateEntityParentshipOnLoaded(GadgetEntity loadedEntity) {} // 0x00000001838B1010-0x00000001838B1180
	// [XID] // 0x000000018980E110-0x000000018980E130
	private void OnFirstTimeFurnitureLoaded(GadgetEntity entity) {} // 0x00000001838A5C50-0x00000001838A5D50
	// [XID] // 0x00000001898157F0-0x0000000189815810
	private void OnSuiteFurnitureLoaded(GadgetEntity entity) {} // 0x00000001838A2F40-0x00000001838A3040
	// [XID] // 0x000000018981D1E0-0x000000018981D200
	private void ClearParentshipOnFurnitureRemove(GadgetEntity entity) {} // 0x00000001838B1310-0x00000001838B1470
	// [XID] // 0x0000000189824660-0x0000000189824680
	private void CreateFurnitureFromSave(HomeworldFurnitureDataEX furnData, MonoHomeworldEnvironmentSetting roomSetting) {} // 0x00000001838ABE80-0x00000001838AC1A0
	// [XID] // 0x000000018982C110-0x000000018982C130
	private void CreateFurnitureSuiteFromSave(HomeworldFurnitureSuiteDataEX suiteSaveData, MonoHomeworldEnvironmentSetting roomSetting) {} // 0x00000001838B1CC0-0x00000001838B1FF0
	// [XID] // 0x00000001898335E0-0x0000000189833600
	private GadgetEntity SetPersistentFurniture(PersistentFurnitureType furnType, uint furnID, MonoHomeworldEnvironmentSetting roomSetting, int paramIndex = 0 /* Metadata: 0x00AFE5C4 */) => default; // 0x000000018389EF80-0x000000018389F370
	// [XID] // 0x000000018983AAC0-0x000000018983AAE0
	public void ReplacePersistentFurniture(FurnitureDeploySurfaceType surfaceType, uint furnID, MonoHomeworldEnvironmentSetting roomSetting, int paramIndex = 0 /* Metadata: 0x00AFE5C8 */) {} // 0x00000001838A98B0-0x00000001838A9BE0
	// [XID] // 0x0000000189842120-0x0000000189842140
	public void SetGlobalFurniture(uint furnitureID, int slotIndex) {} // 0x00000001838A8F50-0x00000001838A9550
	// [XID] // 0x0000000189849580-0x00000001898495A0
	public GadgetEntity CreateFurnitureEntityForRoom(HomeWorldFurnitureExcelConfig furnExcelData, MonoHomeworldEnvironmentSetting roomSetting, Vector3 spawnPos, Vector3 spawnRot, int parentIndex = -1 /* Metadata: 0x00AFE5CC */, bool isPersistent = false /* Metadata: 0x00AFE5D0 */) => default; // 0x00000001838A4300-0x00000001838A4960
	// [XID] // 0x0000000189850DF0-0x0000000189850E10
	public GadgetEntity CreateFurnitureSetForRoom(FurnitureSuiteExcelConfig suiteExcelConfig, MonoHomeworldEnvironmentSetting envSetting, Vector3 spawnPos, Vector3 rotateAngle) => default; // 0x00000001838A9EC0-0x00000001838AA750
	// [XID] // 0x00000001898581E0-0x0000000189858200
	private GadgetEntity CreateFurnitureGadget(HomeWorldFurnitureExcelConfig furnitureExcelData, Vector3 spawnPos, Vector3 spawnRot, int slotIndex = -1 /* Metadata: 0x00AFE5D1 */, Action<BaseEntity> finishLoadCallback = null) => default; // 0x00000001838B1FF0-0x00000001838B2610
	private T GetComponentInChildrenShallow<T>(GameObject gameObject)
		where T : UnityEngine.Object => default;
	// [XID] // 0x000000018985F2B0-0x000000018985F2D0
	private void OnRoomFurnitureEntityLoaded(BaseEntity entity) {} // 0x00000001838AFF10-0x00000001838B0E10
	// [XID] // 0x0000000189866AB0-0x0000000189866AD0
	private void RemoveOldPersistentFurniturePostLoaded(BaseEntity newEntity) {} // 0x00000001838A1040-0x00000001838A1490
	// [XID] // 0x000000018986E350-0x000000018986E370
	public bool RemoveFurnitureGlobal(GadgetEntity removeEntity) => default; // 0x00000001838A1940-0x00000001838A1A80
	// [XID] // 0x0000000189875800-0x0000000189875820
	public bool RemoveFurnitureFromCurrentRoom(GadgetEntity removeEntity) => default; // 0x00000001838A07B0-0x00000001838A0870
	// [XID] // 0x000000018987D350-0x000000018987D370
	public bool RemoveFurnitureFromRoom(GadgetEntity removeEntity, MonoHomeworldEnvironmentSetting envSetting) => default; // 0x00000001838A3A50-0x00000001838A41D0
	// [XID] // 0x0000000189884250-0x0000000189884270
	public void RemoveAllDeployFurnitureFromRoom(MonoHomeworldEnvironmentSetting envSetting, bool removeApartment = true /* Metadata: 0x00AFE5D5 */) {} // 0x000000018389FFE0-0x00000001838A0290
	// [XID] // 0x000000018988B9E0-0x000000018988BA00
	private void UpdateNavMesh() {} // 0x00000001838AB2F0-0x00000001838AB460
	// [XID] // 0x0000000189893050-0x0000000189893070
	private void DelayUpdateNavMesh() {} // 0x00000001838AB110-0x00000001838AB2F0
	// [XID] // 0x000000018989A770-0x000000018989A790
	private void UpdateBakeNavMesh() {} // 0x00000001838ACB00-0x00000001838ACBF0
	// [XID] // 0x00000001898A1A00-0x00000001898A1A20
	private void DelayLoadRoomNPCs() {} // 0x00000001838AEB50-0x00000001838AEBF0
	// [XID] // 0x00000001898A92B0-0x00000001898A92D0
	private void CreateNPCForEnvironment(HomeworldNPCExcelData npcData, Vector3 position, Vector3 rotation, MonoHomeworldEnvironmentSetting envSetting) {} // 0x00000001838A0DA0-0x00000001838A1040
	// [XID] // 0x00000001898B0B20-0x00000001898B0B40
	public void RemoveNPCFromEnvironment(uint npcExcelID, MonoHomeworldEnvironmentSetting envSetting) {} // 0x00000001838ADBA0-0x00000001838ADD10
	// [XID] // 0x00000001898B8200-0x00000001898B8220
	public void SetNPCForSlot(uint npcExcelID, MonoHomeworldEnvironmentSetting envSetting, int slot) {} // 0x000000018389EEB0-0x000000018389EF80
	// [XID] // 0x00000001898BF900-0x00000001898BF920
	private void SpawnNPCFromFurnitureData(FurnitureDataInternal furnitureData, MonoHomeworldEnvironmentSetting envSetting) {} // 0x00000001838A7D20-0x00000001838A7F30
	// [XID] // 0x00000001898C71A0-0x00000001898C71C0
	private void SpawnNPCForEnviroment(MonoHomeworldEnvironmentSetting envSetting) {} // 0x00000001838AE790-0x00000001838AE970
	// [XID] // 0x00000001898CE710-0x00000001898CE730
	private void RemoveNPCFromEnviornment(MonoHomeworldEnvironmentSetting envSetting) {} // 0x00000001838A0870-0x00000001838A0B40
	// [XID] // 0x00000001898D6110-0x00000001898D6130
	private void SpawnNPCForAllEnvironment() {} // 0x000000018389FE80-0x000000018389FFE0
	// [XID] // 0x00000001898DDD60-0x00000001898DDD80
	private void RemoveNPCForAllEnvironment(bool showPlaceholderFurniture = false /* Metadata: 0x00AFE5D6 */) {} // 0x00000001838AC550-0x00000001838AC6C0
	// [XID] // 0x0000000189902170-0x0000000189902190
	public void SetApartment(GadgetEntity newApartmentEntity, HomeWorldFurnitureExcelConfig apartmentConfig) {} // 0x00000001838A2870-0x00000001838A2A90
	// [XID] // 0x00000001899098E0-0x0000000189909900
	public Vector3? GetEntrancePoint() => default; // 0x00000001838ABC30-0x00000001838ABD60
	// [XID] // 0x0000000189910F70-0x0000000189910F90
	public void SetInteriorExit() {} // 0x00000001838B1A80-0x00000001838B1BF0
	// [XID] // 0x0000000189918AB0-0x0000000189918AD0
	private void OnApartmentEntityLoaded(BaseEntity entity) {} // 0x00000001838A8EA0-0x00000001838A8F50
	// [XID] // 0x0000000189920230-0x0000000189920250
	private void UpdateApartmentAttachments() {} // 0x00000001838A1A80-0x00000001838A1EB0
	// [XID] // 0x0000000189927A90-0x0000000189927AB0
	public GadgetEntity GetCurrentApartment() => default; // 0x00000001838A0B40-0x00000001838A0BF0
	// [XID] // 0x000000018992F260-0x000000018992F280
	public uint GetCurrentApartmentSceneID() => default; // 0x00000001838ACC90-0x00000001838ACD40
	// [XID] // 0x0000000189936630-0x0000000189936650
	public WeekendDjinnConfig[] GetWeekendDjinnSpawnPoints() => default; // 0x00000001838A2110-0x00000001838A2390
}

