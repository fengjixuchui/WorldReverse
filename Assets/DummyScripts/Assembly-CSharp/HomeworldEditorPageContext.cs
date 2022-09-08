/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using HedgehogTeam.EasyTouch;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class HomeworldEditorPageContext : BasePageContext // TypeDefIndex: 29131
{
	// Fields
	private List<MonoHomeworldAreaSwitchItem> switchItems; // 0x190
	private bool _areaSwtichActive; // 0x198
	private List<HomeWorldFurnitureTypeExcelConfig> _typeConfigs; // 0x1A0
	private Dictionary<int, List<HomeWorldFurnitureTypeExcelConfig>> _1stCategoryGroups; // 0x1A8
	private Dictionary<uint, List<HomeWorldFurnitureExcelConfig>> _2ndCategoryToConfigMap; // 0x1B0
	private Dictionary<uint, List<FurnitureSuiteExcelConfig>> _2ndSuiteCategoryToConfigMap; // 0x1B8
	private Dictionary<uint, int> _tabID2CurScrollerIndexDict; // 0x1C0
	private bool _inventoryTabFolded; // 0x1C8
	private GadgetEntity _browseEntity; // 0x1D0
	private int _switchRoomIndex; // 0x1D8
	private int _switchRoomTargetID; // 0x1DC
	private int _current1stTabIndex; // 0x1E0
	private uint _current2ndTabID; // 0x1E4
	private int _current2ndTabIndex; // 0x1E8
	private List<HomeWorldFurnitureExcelConfig> _initfurnitureList; // 0x1F0
	private List<HomeWorldFurnitureExcelConfig> _initFurnitureListNoZero; // 0x1F8
	private List<FurnitureSuiteExcelConfig> _initSuiteList; // 0x200
	private List<FurnitureSuiteExcelConfig> _initSuiteListNoUnlock; // 0x208
	private MonoGridScroller _currentGrid; // 0x210
	private int _joypadDeployOptionNum; // 0x218
	private MonoHomeworldEventTrigger _apartmentTrigger; // 0x220
	private Dictionary<uint, uint> _suiteFurnitureNumReq; // 0x228
	private MonoHomeworldEventTrigger _draggingTrigger; // 0x230
	private Transform _eventTriggerParent; // 0x238
	private Vector3 _eventTriggerHidePosition; // 0x240
	private Vector3 _eventTriggerLocalPosition; // 0x24C
	private bool _moveEditTouchDown; // 0x258
	private Vector3 _moveEditMouseStartPos; // 0x25C
	private bool _anchorMarkerHasResult; // 0x268
	private Vector3 _anchorMarkerPosition; // 0x26C
	private CameraEntity _cameraEntity; // 0x278
	private int _cameraSettingIndex; // 0x280
	private List<int> _cachedList; // 0x288
	private bool _isMoving; // 0x290
	private Vector2 _saveParam; // 0x294
	private HomeworldManager _homeworldManager; // 0x2A0
	private MonoHomeworldEnvironmentSetting _environmentSetting; // 0x2A8
	private HomeworldEditCameraSetting _cameraSetting; // 0x2B0
	private Action _closePageAction; // 0x2B8
	private MonoHomeworldEditorPage _pageMono; // 0x2C0
	private HomeworldEditorState _editorState; // 0x2C8
	private float _saveTimeOfDay; // 0x2CC
	private bool _saveDirty; // 0x2D0
	private bool _saveAndClose; // 0x2D1
	private HashSet<HomeWorldFurnitureExcelConfig> _furnitureTypeNums; // 0x2D8
	private HashSet<HomeWorldFurnitureExcelConfig> _tmpFurnitureTypeNums; // 0x2E0
	private GadgetEntity _deployGadget; // 0x2E8
	private GadgetEntity _parentGadget; // 0x2F0
	private FurnitureDataInternal _deployFurnitureDataInternal; // 0x2F8
	private FurnitureSuiteDataInternal _deploySuiteDataInternal; // 0x300
	private HomeWorldFurnitureExcelConfig _deployFurnitureExcelData; // 0x308
	private bool _deployGameObjectReady; // 0x310
	private bool _deployingSpawnGadget; // 0x311
	private int _clickRaycastCountdown; // 0x314
	private bool _clickDeployGadget; // 0x318
	private Vector3 _initSpawnPos; // 0x31C
	private Vector3 _cullingWallDir; // 0x328
	private HomeworldDeployRotateMode _deployRotateMode; // 0x334
	private float innerScale; // 0x338
	private float screenScaleX; // 0x33C
	private float screenScaleY; // 0x340
	private int _raycastDeployMask; // 0x344
	private int _raycastSelectMask; // 0x348
	private int _placeColDetectMask; // 0x34C
	private int _magnetColMask; // 0x350
	private int _scenePropLayerMask; // 0x354
	private int _deployHeightLimit; // 0x358
	private int _deploySurfaceHash; // 0x35C
	private int _blockDeploySurfaceHash; // 0x360
	private int _suiteTouchDiscHash; // 0x364
	private bool _isGridMagnet; // 0x368
	private bool _isAlignMagnet; // 0x369
	private bool _alignMagnetLock; // 0x36A
	private bool _isAlignMagnetted; // 0x36B
	private RaycastHit[] _raycastHits; // 0x370
	private RaycastHit _emptyRaycastHit; // 0x378
	private bool _isRaycastValid; // 0x3B8
	private bool _isDeployValid; // 0x3B9
	private StringBuilder _raycastResultLog; // 0x3C0
	private Vector3 _lastGridSnapPosition; // 0x3C8
	private Vector3 _lastSnapMousePoint; // 0x3D4
	private GameObject _dummyGridGameObject; // 0x3E0
	private HashSet<HomeworldEditorDeployFailReason> _deployFailReasons; // 0x3E8
	private Vector3 _raycastMousePosData; // 0x3F0
	private Vector3 _raycastMouseOffset; // 0x3FC
	private StringBuilder hitResultBuilder; // 0x408
	private Collider[] _placeColColliders; // 0x410
	private List<MonoHomeworldPlaceCol> _verifyDeployableRockerys; // 0x418
	private bool _awaitConfirmOperation; // 0x420
	private Vector3 _lastEditPosition; // 0x424
	private Quaternion _lastEditRotation; // 0x430
	private GadgetEntity _lastEditParentEntity; // 0x440
	private Queue<HomeworldEditLog> _editHistoryQueue; // 0x448
	private float _rotateDiscFadeTimer; // 0x450
	private bool _lastRotateIsWall; // 0x454
	private float _lastRotateAngle; // 0x458
	private int _rotateButtonTagHash; // 0x45C
	private float _joystickRotateStartTimer; // 0x460
	private bool _joystickRotateClockwise; // 0x464
	private Vector3 _rotateDragCenter; // 0x468
	private Vector3 _rotateDragStartPos; // 0x474
	private Vector3 _rotateDragStartEuler; // 0x480
	private bool _rotateEditDraging; // 0x48C
	private Vector3 _rotateVecUp; // 0x490
	private bool _settingTabActive; // 0x49C
	private bool _blockRotateCallback; // 0x49D
	private int _currentSettingPanelJoyPadSelectIndex; // 0x4A0

	// Properties
	private bool _isDeployOnWall { /* [XID] */ /* 0x0000000189763930-0x0000000189763950 */ get => default; } // 0x00000001844A8A20-0x00000001844A8B80 
	private GameObject dummyGridGameObject { /* [XID] */ /* 0x00000001897E2660-0x00000001897E2680 */ get => default; } // 0x00000001844B4A00-0x00000001844B4B10 

	// Nested types
	private enum HomeworldEditorState // TypeDefIndex: 29132
	{
		Browse = 0,
		Deploy = 1,
		Edit = 2,
		Rotate = 3
	}

	public struct HomeworldEditLog // TypeDefIndex: 29133
	{
		// Fields
		public Vector3 position; // 0x00
		public Quaternion rotation; // 0x0C
		public GadgetEntity parentEntity; // 0x20

		// Constructors
		public HomeworldEditLog(Vector3 position, Quaternion rotation, GadgetEntity parentEntity) {
			this.position = default;
			this.rotation = default;
			this.parentEntity = default;
		} // 0x0000000181BEAA30-0x0000000181BEAAF0
	}

	// Constructors
	public HomeworldEditorPageContext() {} // Dummy constructor
	public HomeworldEditorPageContext(MonoHomeworldEnvironmentSetting envSetting) {} // 0x00000001844BFD20-0x00000001844C0360

	// Methods
	// [XID] // 0x0000000189B02B40-0x0000000189B02B60
	private void SwitchToNextEnv() {} // 0x00000001844A0260-0x00000001844A0300
	// [XID] // 0x0000000189B0A350-0x0000000189B0A370
	private void SwitchToPrevEnv() {} // 0x00000001844B2250-0x00000001844B22F0
	// [XID] // 0x0000000189B11B10-0x0000000189B11B30
	private void ShowAreaSwitchTab() {} // 0x00000001844BECD0-0x00000001844BF2C0
	// [XID] // 0x0000000189B18E00-0x0000000189B18E20
	private void RefreshAllSwitchItems() {} // 0x00000001844A8E60-0x00000001844A9070
	// [XID] // 0x0000000189B20450-0x0000000189B20470
	private void OnAreaSwitchItemInit(Transform itemTransform, int index) {} // 0x00000001844A9070-0x00000001844A9240
	// [XID] // 0x0000000189B27AD0-0x0000000189B27AF0
	private void RefreshSwitchItemStatus(MonoHomeworldAreaSwitchItem switchItem) {} // 0x000000018449EC50-0x000000018449F3B0
	// [XID] // 0x0000000189B2EE10-0x0000000189B2EE30
	private void OnSwitchAreaButtonClicked(int switchRoomID) {} // 0x00000001844B2940-0x00000001844B2A00
	// [XID] // 0x0000000189B366D0-0x0000000189B366F0
	private void HideAreaSwitchTab() {} // 0x00000001844B67F0-0x00000001844B6B20
	// [XID] // 0x0000000189B3DF40-0x0000000189B3DF60
	private bool HandleAreaSwitchInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001844B3FC0-0x00000001844B4250
	// [XID] // 0x0000000189B45C90-0x0000000189B45CB0
	public void SetupDisplayTab() {} // 0x00000001844ABBC0-0x00000001844AD040
	// [XID] // 0x0000000189B4D110-0x0000000189B4D130
	private void On1stCategoryTabClicked(List<HomeWorldFurnitureTypeExcelConfig> typeList, int tabIndex) {} // 0x00000001844AD4D0-0x00000001844ADB80
	// [XID] // 0x0000000189B54910-0x0000000189B54930
	private void On2ndCategoryTabClicked(uint tabID, int tabIndex) {} // 0x00000001844A2A80-0x00000001844A4060
	// [XID] // 0x0000000189B5C4B0-0x0000000189B5C4D0
	private void OnFurnitureItemSetup(Transform transform, int index) {} // 0x00000001844ADD80-0x00000001844AED70
	// [XID] // 0x0000000189B63A60-0x0000000189B63A80
	private void OnFurnitureSuiteSetup(Transform transform, int index) {} // 0x00000001844BAEC0-0x00000001844BBF10
	// [XID] // 0x0000000189B6B240-0x0000000189B6B260
	private void OnFurnitureSuiteInfoClicked(int selectIndex) {} // 0x00000001844B9EA0-0x00000001844B9FE0
	// [XID] // 0x0000000189B72840-0x0000000189B72860
	private void OnFurnitureItemClickSpawn(uint furnitureID, MonoHomeworldEventTrigger trigger) {} // 0x00000001844BC240-0x00000001844BC320
	// [XID] // 0x0000000189B79D70-0x0000000189B79D90
	private void OnFurnitureItemSpawn(uint furnitureID, MonoHomeworldEventTrigger trigger) {} // 0x00000001844AB260-0x00000001844AB940
	// [XID] // 0x0000000189B814A0-0x0000000189B814C0
	private void OnClickSuiteItemSpawn(uint tabID, MonoHomeworldEventTrigger trigger) {} // 0x000000018449FBB0-0x000000018449FC90
	// [XID] // 0x0000000189B88C10-0x0000000189B88C30
	private void OnSuiteItemSpawn(uint tabID, MonoHomeworldEventTrigger trigger) {} // 0x00000001844B3220-0x00000001844B39E0
	// [XID] // 0x0000000189B90100-0x0000000189B90120
	private void OnDragEndDeploySpawnGadget(uint furnitureID, MonoHomeworldEventTrigger eventTrigger) {} // 0x00000001844A0180-0x00000001844A0260
	// [XID] // 0x0000000189B975A0-0x0000000189B975C0
	private void ResetDraggingButton(MonoHomeworldEventTrigger eventTrigger) {} // 0x00000001844BCBF0-0x00000001844BCE30
	// [XID] // 0x0000000189B9EA00-0x0000000189B9EA20
	private void RefreshBrowseInventory() {} // 0x000000018449DB00-0x000000018449DBD0
	// [XID] // 0x0000000189BA6310-0x0000000189BA6330
	private void OnUnfoldButtonClicked() {} // 0x00000001844AF990-0x00000001844AFA30
	// [XID] // 0x0000000189BAD5E0-0x0000000189BAD600
	private void OnFoldButtonClicked() {} // 0x00000001844A9BD0-0x00000001844A9C70
	// [XID] // 0x0000000189BB4D10-0x0000000189BB4D30
	private void SetInventoryTabFold(bool fold) {} // 0x00000001844A6190-0x00000001844A6680
	// [XID] // 0x0000000189BBC340-0x0000000189BBC360
	private void UpdateBrowsingGadget() {} // 0x000000018449E380-0x000000018449EC50
	// [XID] // 0x0000000189BC4020-0x0000000189BC4040
	private void SetupAnchorMarker(bool active) {} // 0x00000001844BA260-0x00000001844BA310
	// [XID] // 0x0000000189BCB9F0-0x0000000189BCBA10
	private void UpdateAnchorMarker() {} // 0x00000001844A9360-0x00000001844A9BD0
	// [XID] // 0x0000000189BD2F60-0x0000000189BD2F80
	public void UpdateSitdownPointOnPatternLoaded(MonoPatternSceneProp scenePropPattern, GadgetEntity entity) {} // 0x00000001844B4B10-0x00000001844B4CC0
	// [XID] // 0x0000000189BDA780-0x0000000189BDA7A0
	private bool HandleBrowseInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001844A1F50-0x00000001844A2290
	// [XID] // 0x00000001895E7170-0x00000001895E7190
	private void Iterate1stCategoryTab(bool itrNext) {} // 0x00000001844BA7C0-0x00000001844BA8B0
	// [XID] // 0x00000001895EEAA0-0x00000001895EEAC0
	private void Iterate2ndCategoryTab(bool itrNext) {} // 0x00000001844A8B80-0x00000001844A8C70
	// [XID] // 0x00000001895F6460-0x00000001895F6480
	private int IterateMonoUIContainerList(List<MonoUIContainer> list, int currIndex, bool itrNext) => default; // 0x00000001844BCE30-0x00000001844BD0F0
	// [XID] // 0x00000001895FD7B0-0x00000001895FD7D0
	private void OnDeployOptionInit(Transform button, int index) {} // 0x00000001844BE420-0x00000001844BE8B0
	// [XID] // 0x0000000189605060-0x0000000189605080
	private void OnJoypadSelectDeploy() {} // 0x00000001844A2970-0x00000001844A2A80
	// [XID] // 0x000000018960CAB0-0x000000018960CAD0
	private void OnJoypadSelectSuiteDetail() {} // 0x00000001844ABA10-0x00000001844ABB10
	// [XID] // 0x0000000189614020-0x0000000189614040
	private void OnJoypadSelectExit() {} // 0x000000018449FB10-0x000000018449FBB0
	// [XID] // 0x000000018961B960-0x000000018961B980
	public override void OnJoypadUIModuleSelectIndex(MonoJoypadUIModule sourceModule, int index, Transform transform, JoypadSelectIndexResult selectResult = JoypadSelectIndexResult.Normal /* Metadata: 0x00B0EC90 */) {} // 0x00000001844BE0B0-0x00000001844BE210
	// [XID] // 0x0000000189622FA0-0x0000000189622FC0
	public void InitCameraSetting() {} // 0x00000001844B6260-0x00000001844B6390
	// [XID] // 0x000000018962A750-0x000000018962A770
	public void ExitEditCamera() {} // 0x00000001844BE210-0x00000001844BE360
	// [XID] // 0x0000000189631E90-0x0000000189631EB0
	public void SetCameraSettingIndex(int index, bool applyToCamera = true /* Metadata: 0x00B0EC94 */) {} // 0x00000001844B8D90-0x00000001844B9000
	// [XID] // 0x00000001896399D0-0x00000001896399F0
	private void ResetCameraView() {} // 0x00000001844AD170-0x00000001844AD2B0
	// [XID] // 0x0000000189640E60-0x0000000189640E80
	public void SetupCameraSetting(HomeworldEditCameraSetting setting) {} // 0x00000001844BEBB0-0x00000001844BECD0
	// [XID] // 0x0000000189648770-0x0000000189648790
	private bool HandleCameraInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001844A6A70-0x00000001844A7190
	// [XID] // 0x000000018964FE80-0x000000018964FEA0
	private void UpdateCameraCollider() {} // 0x00000001844BA310-0x00000001844BA7C0
	// [XID] // 0x0000000189657740-0x0000000189657760
	private void ClearCache() {} // 0x00000001844AF710-0x00000001844AF890
	// [XID] // 0x000000018965EDA0-0x000000018965EDC0
	private void SetupMoveJoystick() {} // 0x00000001844AA560-0x00000001844AA890
	// [XID] // 0x00000001896664C0-0x00000001896664E0
	private void MoveCallBack(float angle, float mold) {} // 0x00000001844B9D50-0x00000001844B9EA0
	// [XID] // 0x000000018966DCC0-0x000000018966DCE0
	private void OnMoveJoystick(float angle, float mold) {} // 0x00000001844BC320-0x00000001844BC510
	// [XID] // 0x0000000189675AE0-0x0000000189675B00
	private void UpdateMoveTouchJoystick() {} // 0x00000001844B6390-0x00000001844B6540
	// [XID] // 0x000000018967D370-0x000000018967D390
	private void ClearMoveJoystick() {} // 0x00000001844BBF10-0x00000001844BC160
	// [XID] // 0x0000000189684A40-0x0000000189684A60
	public void PrintCameraOffset() {} // 0x00000001844B22F0-0x00000001844B2940
	// [XID] // 0x000000018968C610-0x000000018968C630
	public void SetFocusedEnvSetting(MonoHomeworldEnvironmentSetting envSetting) {} // 0x00000001844A1500-0x00000001844A1660
	// [XID] // 0x0000000189694060-0x0000000189694080
	private void UpdateRoomName() {} // 0x00000001844B9AB0-0x00000001844B9C50
	// [XID] // 0x000000018969B5D0-0x000000018969B5F0
	public override void SetupView() {} // 0x00000001844BF550-0x00000001844BF970
	// [XID] // 0x00000001896A2D50-0x00000001896A2D70
	public override void Close() {} // 0x00000001844A1AC0-0x00000001844A1D20
	// [XID] // 0x00000001896AA200-0x00000001896AA220
	public void SwitchEnvironment(MonoHomeworldEnvironmentSetting newEnvSetting, bool instant) {} // 0x00000001844A9240-0x00000001844A9360
	// [XID] // 0x00000001896B1020-0x00000001896B1040
	public void SwitchEnvironmentFadeFinish() {} // 0x00000001844A5B20-0x00000001844A5BC0
	// [XID] // 0x00000001896B8C10-0x00000001896B8C30
	public override void ClearView() {} // 0x00000001844A1960-0x00000001844A1AC0
	// [XID] // 0x00000001896BFE30-0x00000001896BFE50
	protected override void BindViewCallbacks() {} // 0x00000001844A05F0-0x00000001844A0C80
	// [XID] // 0x00000001896C7730-0x00000001896C7750
	private void TryClosePage() {} // 0x00000001844A0C80-0x00000001844A0F90
	// [XID] // 0x00000001896CEED0-0x00000001896CEEF0
	private void ConfirmClosePageWithSave(bool ok) {} // 0x00000001844A5CC0-0x00000001844A5DA0
	// [XID] // 0x00000001896D62D0-0x00000001896D62F0
	public void UploadSaveComplete() {} // 0x00000001844A13F0-0x00000001844A1500
	// [XID] // 0x00000001896DD8D0-0x00000001896DD8F0
	public void UploadSaveFail(int retCode) {} // 0x00000001844AD040-0x00000001844AD170
	// [XID] // 0x00000001896E4F80-0x00000001896E4FA0
	public override void ClosePage() {} // 0x000000018449FD80-0x000000018449FEB0
	// [XID] // 0x00000001896EC440-0x00000001896EC460
	private void SaveHomeworld() {} // 0x00000001844ABB10-0x00000001844ABBC0
	// [XID] // 0x00000001896F3BD0-0x00000001896F3BF0
	private void ToggleRotateMode() {} // 0x00000001844B6750-0x00000001844B67F0
	// [XID] // 0x00000001896FB340-0x00000001896FB360
	private void SetPageEditorState(HomeworldEditorState newState) {} // 0x00000001844B5030-0x00000001844B5780
	// [XID] // 0x0000000189702AF0-0x0000000189702B10
	public override void UpdateView() {} // 0x00000001844BF970-0x00000001844BFD20
	// [XID] // 0x000000018970A210-0x000000018970A230
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001844AF350-0x00000001844AF5B0
	// [XID] // 0x0000000189711CF0-0x0000000189711D10
	private void UpdateEnvironmentCulling() {} // 0x00000001844B9110-0x00000001844B9AB0
	// [XID] // 0x0000000189719190-0x00000001897191B0
	private void On_SimpleTap(Gesture gesture) {} // 0x00000001844A8D00-0x00000001844A8DC0
	// [XID] // 0x00000001897207F0-0x0000000189720810
	private void On_TouchDown(Gesture gesture) {} // 0x000000018449FC90-0x000000018449FD80
	// [XID] // 0x0000000189727DA0-0x0000000189727DC0
	private void On_TouchUp(Gesture gesture) {} // 0x00000001844AFB20-0x00000001844AFC00
	// [XID] // 0x000000018972F420-0x000000018972F440
	private void UpdateRoomStatus() {} // 0x00000001844B15C0-0x00000001844B1EA0
	// [XID] // 0x0000000189736E20-0x0000000189736E40
	private Vector3 GetPointerScreenPosition(bool applyScaleFix = true /* Metadata: 0x00B0EC95 */, float zDepth = 10f /* Metadata: 0x00B0EC96 */) => default; // 0x00000001844B4630-0x00000001844B4A00
	// [XID] // 0x000000018973E9E0-0x000000018973EA00
	private Vector3 GetScreenPointFromWorld(Vector3 worldPosition, bool applyScaleFix = true /* Metadata: 0x00B0EC9A */) => default; // 0x00000001844A5DA0-0x00000001844A6000
	// [XID] // 0x0000000189745CE0-0x0000000189745D00
	private float GetClampedRaycastLength(float raycastLength, Vector3 start, Vector3 dir) => default; // 0x00000001844A2290-0x00000001844A2490
	// [XID] // 0x000000018974D7B0-0x000000018974D7D0
	private void EnableVirtualCursor(bool enable) {} // 0x00000001844AB130-0x00000001844AB260
	// [XID] // 0x0000000189754DD0-0x0000000189754DF0
	private void SetVirtualCursorVisible(bool visible) {} // 0x00000001844B6660-0x00000001844B6750
	// [XID] // 0x000000018975BFC0-0x000000018975BFE0
	public void ClearEditorUI() {} // 0x00000001844A5BC0-0x00000001844A5CC0
	// [XID] // 0x000000018976B0F0-0x000000018976B110
	private void ToggleGridOption(bool isOn) {} // 0x00000001844A2550-0x00000001844A2610
	// [XID] // 0x0000000189772740-0x0000000189772760
	private void ToggleAlignOption(bool isOn) {} // 0x00000001844A2490-0x00000001844A2550
	// [IDTag] // 0x0000000189779D70-0x0000000189779DB0
	// [XID] // 0x0000000189779D70-0x0000000189779DB0
	private void ToggleSpawnRotateOption() {} // 0x00000001844A60D0-0x00000001844A6190
	// [XID] // 0x0000000189784930-0x0000000189784950
	private void SetGridOptionActive(bool active) {} // 0x00000001844AFA30-0x00000001844AFB20
	// [XID] // 0x000000018978BF00-0x000000018978BF20
	private void SetAlignOptionActive(bool active) {} // 0x00000001844A5770-0x00000001844A5830
	// [IDTag] // 0x0000000189793370-0x00000001897933B0
	// [XID] // 0x0000000189793370-0x00000001897933B0
	private void ToggleSpawnRotateOption(HomeworldDeployRotateMode rotMode, bool isOn) {} // 0x00000001844A6000-0x00000001844A60D0
	// [XID] // 0x000000018979E590-0x000000018979E5B0
	private void SetSpawnRotateOption(HomeworldDeployRotateMode rotMode) {} // 0x00000001844A59E0-0x00000001844A5AA0
	// [XID] // 0x00000001897A5D50-0x00000001897A5D70
	private bool IsEdittingFurnitreSuite() => default; // 0x00000001844AACE0-0x00000001844AAD90
	// [XID] // 0x00000001897AD2C0-0x00000001897AD2E0
	private void SetupDeploy() {} // 0x00000001844B5940-0x00000001844B60C0
	// [XID] // 0x00000001897B5310-0x00000001897B5330
	private Vector3 GetSpawnRotateAngle(bool isWall) => default; // 0x00000001844B1FD0-0x00000001844B2250
	// [XID] // 0x00000001897BCFA0-0x00000001897BCFC0
	private bool SpawnGadgetForDeploy(HomeWorldFurnitureExcelConfig excelData) => default; // 0x00000001844BA8B0-0x00000001844BAEC0
	// [XID] // 0x00000001897C4320-0x00000001897C4340
	private bool SpawnFurnitureSetForDeploy(FurnitureSuiteExcelConfig suiteConfig) => default; // 0x00000001844B4350-0x00000001844B4630
	// [XID] // 0x00000001897CBB40-0x00000001897CBB60
	private void SpawnGadgetGOReady(BaseEntity entity) {} // 0x00000001844AF890-0x00000001844AF990
	// [XID] // 0x00000001897D3470-0x00000001897D3490
	private void SpawnFurnitureSuiteReady(FurnitureSuiteDataInternal suiteData) {} // 0x00000001844AB940-0x00000001844ABA10
	// [XID] // 0x00000001897DAEF0-0x00000001897DAF10
	private void UpdateEditGadgetPlaceCollider(GadgetEntity entity) {} // 0x00000001844A0F90-0x00000001844A13F0
	// [XID] // 0x00000001897E9DD0-0x00000001897E9DF0
	private bool RaycastDeployableSurface(out RaycastHit outHitInfo, out bool isWall, out Vector3 wallDir, out GadgetEntity hitGadgetEntity) {
		outHitInfo = default;
		isWall = default;
		wallDir = default;
		hitGadgetEntity = default;
		return default;
	} // 0x00000001844A4060-0x00000001844A5770
	// [XID] // 0x00000001897F1A10-0x00000001897F1A30
	private void UpdateDeployGadget() {} // 0x00000001844AFEC0-0x00000001844B13C0
	// [XID] // 0x00000001897F91E0-0x00000001897F9200
	private void UnlockMagnet() {} // 0x00000001844AA890-0x00000001844AA930
	// [XID] // 0x00000001898007B0-0x00000001898007D0
	private bool UpdateDeployGdagetCollision(GadgetEntity selfEntity, GadgetEntity parentEntity) => default; // 0x000000018449F3B0-0x000000018449FB10
	// [XID] // 0x0000000189807E30-0x0000000189807E50
	private bool VerifyDeployGadgetPlaceCol(GadgetEntity selfEntity, GadgetEntity parentEntity, out GadgetEntity hitEntity) {
		hitEntity = default;
		return default;
	} // 0x00000001844B6B20-0x00000001844B8D90
	// [XID] // 0x000000018980F730-0x000000018980F750
	private bool ApplyMagnetBettwenFurniture(MonoHomeworldPlaceCol selfPlaceCol, out Vector3 spotDiff, out float angleDiff, out GameObject alignObj, bool magnetOnWall) {
		spotDiff = default;
		angleDiff = default;
		alignObj = default;
		return default;
	} // 0x00000001844A7390-0x00000001844A8970
	// [XID] // 0x0000000189816DE0-0x0000000189816E00
	private void DeployMovingGadget() {} // 0x00000001844AFC00-0x00000001844AFEC0
	// [XID] // 0x000000018981E650-0x000000018981E670
	private void SetDeployValid(bool valid) {} // 0x00000001844ADB80-0x00000001844ADD80
	// [XID] // 0x0000000189825B30-0x0000000189825B50
	private void ClearDeployGadgetData() {} // 0x00000001844B5780-0x00000001844B5940
	// [XID] // 0x000000018982D260-0x000000018982D280
	private void CancelDeployGadget() {} // 0x00000001844BD0F0-0x00000001844BD230
	// [XID] // 0x00000001898349C0-0x00000001898349E0
	private bool HandleDeployInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001844B39E0-0x00000001844B3BB0
	// [XID] // 0x000000018983C090-0x000000018983C0B0
	private void SetupEdit() {} // 0x00000001844AD2B0-0x00000001844AD390
	// [XID] // 0x00000001898436A0-0x00000001898436C0
	private void SelectGadgetForEdit(GadgetEntity editEntity, bool fromEdit = false /* Metadata: 0x00B0EC9B */) {} // 0x000000018449DBD0-0x000000018449E2D0
	// [XID] // 0x000000018984AC00-0x000000018984AC20
	private void UpdateEditPanelButtions() {} // 0x00000001844A0300-0x00000001844A05F0
	// [XID] // 0x0000000189851F60-0x0000000189851F80
	private void EditFurnitureSuite() {} // 0x00000001844BDC90-0x00000001844BE0B0
	// [XID] // 0x0000000189859820-0x0000000189859840
	private void EditTouchDown() {} // 0x00000001844BD4E0-0x00000001844BDC90
	// [XID] // 0x00000001898609A0-0x00000001898609C0
	private void OnEditTouchUp() {} // 0x00000001844AF5B0-0x00000001844AF6B0
	// [XID] // 0x00000001898680D0-0x00000001898680F0
	private void UpdateMoveEditTouchDrag() {} // 0x00000001844BC510-0x00000001844BC6D0
	// [XID] // 0x000000018986F690-0x000000018986F6B0
	private void EnterEditFromBrowse(GadgetEntity editEntity) {} // 0x00000001844AF020-0x00000001844AF0F0
	// [XID] // 0x0000000189876C40-0x0000000189876C60
	private void EnterDeployFromEdit(GadgetEntity editEntity) {} // 0x00000001844AA930-0x00000001844AAC80
	// [XID] // 0x000000018987E740-0x000000018987E760
	private void ClearMoveEditData() {} // 0x00000001844A8970-0x00000001844A8A20
	// [XID] // 0x0000000189885B30-0x0000000189885B50
	private void ConfirmEdit() {} // 0x00000001844BE8B0-0x00000001844BEBB0
	// [XID] // 0x000000018988CE20-0x000000018988CE40
	private void ConfirmBreakSuiteEdit(bool ok) {} // 0x00000001844B4250-0x00000001844B4350
	// [XID] // 0x0000000189894510-0x0000000189894530
	private void ConfirmSetNewAppartmentEdit(bool ok) {} // 0x00000001844B9FE0-0x00000001844BA0A0
	// [XID] // 0x000000018989BAE0-0x000000018989BB00
	private void PerformConfirmEdit() {} // 0x00000001844B4E30-0x00000001844B5030
	// [XID] // 0x00000001898A2F50-0x00000001898A2F70
	private void RevertEdit() {} // 0x000000018449FEB0-0x00000001844A0180
	// [XID] // 0x00000001898AA430-0x00000001898AA450
	private void RecycleEdit() {} // 0x00000001844A1D20-0x00000001844A1F50
	// [XID] // 0x00000001898B1E30-0x00000001898B1E50
	private void ConfirmRecycleEditBreakSuite(bool isOK) {} // 0x00000001844B4CC0-0x00000001844B4E30
	// [XID] // 0x00000001898B9AD0-0x00000001898B9AF0
	private void RotateDiscFadeback(float time) {} // 0x000000018449E2D0-0x000000018449E380
	// [XID] // 0x00000001898C0EB0-0x00000001898C0ED0
	private void ResetRotateDiscFade() {} // 0x00000001844A8DC0-0x00000001844A8E60
	// [XID] // 0x00000001898C87F0-0x00000001898C8810
	private void UpdateRotateDiscFadeBack() {} // 0x00000001844AD390-0x00000001844AD470
	// [XID] // 0x00000001898D01A0-0x00000001898D01C0
	private bool HandleEditInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001844AF0F0-0x00000001844AF350
	// [XID] // 0x00000001898D7730-0x00000001898D7750
	private void SetJoystickEditButtonActive(bool active) {} // 0x00000001844BA0A0-0x00000001844BA260
	// [XID] // 0x00000001898DF480-0x00000001898DF4A0
	private void Rotate90Degree() {} // 0x00000001844AA060-0x00000001844AA560
	// [XID] // 0x00000001898E6E40-0x00000001898E6E60
	private void VerifyRotateEditGadget() {} // 0x00000001844A2610-0x00000001844A2970
	// [XID] // 0x00000001898EE610-0x00000001898EE630
	private void RotateEditDragStart() {} // 0x00000001844B13C0-0x00000001844B15C0
	// [XID] // 0x00000001898F5DA0-0x00000001898F5DC0
	private void RotateEditDragEnd() {} // 0x00000001844B9000-0x00000001844B9110
	// [XID] // 0x00000001898FD5E0-0x00000001898FD600
	private void UpdateRotateEditDrag() {} // 0x000000018449D520-0x000000018449DB00
	// [XID] // 0x0000000189904EA0-0x0000000189904EC0
	private bool HandleRotateInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001844BF2C0-0x00000001844BF3B0
	// [XID] // 0x000000018990C6A0-0x000000018990C6C0
	private void SetupSettingTab() {} // 0x00000001844BE360-0x00000001844BE420
	// [XID] // 0x0000000189913F50-0x0000000189913F70
	private void DelayBindSettingEvents() {} // 0x00000001844B2A00-0x00000001844B3220
	// [XID] // 0x000000018991B980-0x000000018991B9A0
	private void ClearToggleRotateModeEvent() {} // 0x00000001844AED70-0x00000001844AEFC0
	// [XID] // 0x0000000189922F00-0x0000000189922F20
	private void BindToggleRotateModeAnimator() {} // 0x00000001844B3BB0-0x00000001844B3DD0
	// [XID] // 0x000000018992A730-0x000000018992A750
	private void BindToggleRotateModeEvent() {} // 0x00000001844A1660-0x00000001844A1960
	// [XID] // 0x0000000189931D30-0x0000000189931D50
	private void RefreshRotationToggle() {} // 0x00000001844BC6D0-0x00000001844BCBF0
	// [XID] // 0x0000000189939740-0x0000000189939760
	private void ToggleDayNightSetting(bool isOn) {} // 0x00000001844BD2B0-0x00000001844BD4E0
	// [XID] // 0x0000000189940A10-0x0000000189940A30
	private void ShowSettingTab() {} // 0x00000001844A6680-0x00000001844A6A70
	// [XID] // 0x00000001899482D0-0x00000001899482F0
	private void HideSettingTab() {} // 0x00000001844A9C70-0x00000001844AA060
	// [XID] // 0x000000018994F9D0-0x000000018994F9F0
	private void RecycleAllFurniture() {} // 0x00000001844A7190-0x00000001844A72F0
	// [XID] // 0x0000000189957010-0x0000000189957030
	private void ConfirmRecycleAllFurniture(bool isOK) {} // 0x00000001844B1F00-0x00000001844B1FD0
	// [XID] // 0x000000018995EB00-0x000000018995EB20
	private bool HandleSettingPanelInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001844B6540-0x00000001844B6660
	// [XID] // 0x0000000189966240-0x0000000189966260
	private void SettingPanelJoyStickSelect(int newIndex, bool forceFresh = false /* Metadata: 0x00B0EC9C */) {} // 0x00000001844AAD90-0x00000001844AB130
	// [XID] // 0x000000018996D6E0-0x000000018996D700
	private void SettingPanelJoyStickTrigger() {} // 0x00000001844B3DD0-0x00000001844B3FC0
	// [XID] // 0x0000000189975280-0x00000001899752A0
	private void SettingPanelRefreshConfirmButtonText() {} // 0x00000001844A5830-0x00000001844A59E0
}

