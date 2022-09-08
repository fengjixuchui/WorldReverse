/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using HedgehogTeam.EasyTouch;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class HomeworldEditPageContext : BasePageContext // TypeDefIndex: 29147
{
	// Fields
	private MonoHomeworldEnvironmentSetting _environmentSetting; // 0x190
	private HomeworldEditCameraSetting _cameraSetting; // 0x198
	private int _cameraSettingIndex; // 0x1A0
	private Action _closePageAction; // 0x1A8
	private MonoHomeworldEditPage _pageMono; // 0x1B0
	private static Dictionary<uint, List<HomeWorldFurnitureExcelConfig>> _furnitureConfigMap; // 0x00
	private static List<HomeWorldFurnitureTypeExcelConfig> _typeConfigs; // 0x08
	private static List<HomeWorldFurnitureExcelConfig> _itemConfigs; // 0x10
	private CameraEntity _cameraEntity; // 0x1B8
	private int _scenePropLayerMask; // 0x1C0
	private int _scenePropPlaceColMask; // 0x1C4
	private int _magnetColMask; // 0x1C8
	private int _uiLayerMask; // 0x1CC
	private HomeworldManager _homeworldManager; // 0x1D0
	private bool _npcDialogOpen; // 0x1D8
	private bool _exitHomeworldCamera; // 0x1D9
	private HomeworldEditVerifyState _editVerifyState; // 0x1DC
	private HomeworldEditPageState _homeworldEditPageState; // 0x1E0
	private HomeworldEditSubState _homewordEditSubState; // 0x1E4
	private bool _spawnGOReady; // 0x1E8
	private HomeWorldFurnitureExcelConfig _movingFurnData; // 0x1F0
	private GadgetEntity _browseEntity; // 0x1F8
	private GadgetEntity _editEntity; // 0x200
	private GadgetEntity _spawnGadget; // 0x208
	private GadgetEntity _movingGadget; // 0x210
	private GadgetEntity _parentGadget; // 0x218
	private float innerScale; // 0x220
	private bool _isRaycastValid; // 0x224
	private RaycastHit[] _raycastHits; // 0x228
	private RaycastHit _emptyRaycastHit; // 0x230
	private FurnitureDataInternal _movingFurnDataInternal; // 0x270
	private HomeWorldFurnitureExcelConfig _editFurnExcelData; // 0x278
	private Vector3 _cullingWallDir; // 0x280
	private Vector3 _initSpawnPos; // 0x28C
	private MonoHomeworldPlaceCol _movingGadgetPlaceCol; // 0x298
	private bool _isAlignMagnetted; // 0x2A0
	private bool _alignMagnettedLock; // 0x2A1
	private HomeworldMagnetSpot _selfMagSpot; // 0x2A8
	private HomeworldMagnetSpot _tarMagSpot; // 0x2D0
	private bool _isGridMagnet; // 0x2F8
	private bool _isAlignMagnet; // 0x2F9
	private HomeworldDeployRotateMode _spawnRotMode; // 0x2FC
	private float _lastRotateAngle; // 0x300
	private bool _lastRotateIsWall; // 0x304
	private Vector3 _startEditPosition; // 0x308
	private Quaternion _startEditRotation; // 0x314
	private Vector3 _positionBeforeMoveEdit; // 0x324
	private Quaternion _quatBeforeMoveEdit; // 0x330
	private bool _moveEditTouchDown; // 0x340
	private Vector3 _moveEditMouseStartPos; // 0x344
	private bool _rotateEditDraging; // 0x350
	private Quaternion _quatBeforeRotateEdit; // 0x354
	private Vector3 _rotateDragStartEuler; // 0x364
	private Vector3 _rotateDragStartPos; // 0x370
	private Vector3 _rotateDragCenter; // 0x37C
	private Vector3 _rotateVecUp; // 0x388
	private bool _isRotateValid; // 0x394
	private bool _moveGadgetHasValidLastPos; // 0x395
	private Collider[] _placeColColliders; // 0x398

	// Constructors
	public HomeworldEditPageContext() {} // Dummy constructor
	public HomeworldEditPageContext(MonoHomeworldEnvironmentSetting envSetting, int cameraIndex) {} // 0x00000001826C0110-0x00000001826C03D0
	static HomeworldEditPageContext() {} // 0x00000001826C0020-0x00000001826C0110

	// Methods
	// [XID] // 0x0000000189A72200-0x0000000189A72220
	public override void SetupView() {} // 0x00000001826BF7E0-0x00000001826BFEB0
	// [XID] // 0x0000000189A79EA0-0x0000000189A79EC0
	protected override void BindViewCallbacks() {} // 0x00000001826B5D40-0x00000001826B62F0
	// [XID] // 0x0000000189A81320-0x0000000189A81340
	public override void UpdateView() {} // 0x00000001826BFEB0-0x00000001826C0020
	// [XID] // 0x0000000189A88D20-0x0000000189A88D40
	public override void ClosePage() {} // 0x00000001826B5460-0x00000001826B5700
	// [XID] // 0x0000000189A904B0-0x0000000189A904D0
	private void OpenNPCDialog() {} // 0x00000001826BEBD0-0x00000001826BEE10
	// [XID] // 0x0000000189A97CC0-0x0000000189A97CE0
	private void OnNPCDialogClose() {} // 0x00000001826BE540-0x00000001826BE6E0
	// [XID] // 0x0000000189A9F090-0x0000000189A9F0B0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001826BB3D0-0x00000001826BB7F0
	// [XID] // 0x0000000189AA6990-0x0000000189AA69B0
	public override void ClearView() {} // 0x00000001826B6750-0x00000001826B68A0
	// [XID] // 0x0000000189AAE020-0x0000000189AAE040
	public void SetEditState(HomeworldEditPageState newState) {} // 0x00000001826B6620-0x00000001826B6750
	// [XID] // 0x0000000189AB5950-0x0000000189AB5970
	public void SetEnvSetting(MonoHomeworldEnvironmentSetting envSetting, int cameraIndex = 0 /* Metadata: 0x00B0ECF1 */, bool applyCamera = false /* Metadata: 0x00B0ECF5 */) {} // 0x00000001826BDD80-0x00000001826BDEF0
	// [XID] // 0x0000000189ABD330-0x0000000189ABD350
	public void SetCameraSettingIndex(int index, bool applyToCamera = true /* Metadata: 0x00B0ECF6 */) {} // 0x00000001826BD140-0x00000001826BD3A0
	// [XID] // 0x0000000189AC4D60-0x0000000189AC4D80
	public void SetupAvaliableFurnitureConfigs() {} // 0x00000001826BF010-0x00000001826BF7E0
	// [XID] // 0x0000000189ACC3E0-0x0000000189ACC400
	public void SelectFurnitureType(int index) {} // 0x00000001826BB0A0-0x00000001826BB310
	// [XID] // 0x0000000189AD3F40-0x0000000189AD3F60
	private void SetupTypeButton(Transform btnTrans, int index) {} // 0x00000001826BA1B0-0x00000001826BA4C0
	// [XID] // 0x0000000189ADBA00-0x0000000189ADBA20
	private void OnTypeButtonClicked(int index) {} // 0x00000001826BCD40-0x00000001826BCDF0
	// [XID] // 0x0000000189AE3360-0x0000000189AE3380
	private void SetupItemButton(Transform btnTrans, int index) {} // 0x00000001826B5700-0x00000001826B5B70
	// [XID] // 0x0000000189AEACD0-0x0000000189AEACF0
	private void OnItemButtonClicked(int index, MonoHomeworldEventTrigger trigger) {} // 0x00000001826BB990-0x00000001826BBCF0
	// [XID] // 0x0000000189AF25A0-0x0000000189AF25C0
	private void SaveRoom() {} // 0x00000001826B62F0-0x00000001826B63A0
	// [XID] // 0x0000000189AF9F60-0x0000000189AF9F80
	private void ClearRoom() {} // 0x00000001826B6560-0x00000001826B6620
	// [XID] // 0x0000000189B01470-0x0000000189B01490
	private void LoadRoom() {} // 0x00000001826BC8B0-0x00000001826BC970
	// [XID] // 0x0000000189B08980-0x0000000189B089A0
	private void UpdateEnvironmentCulling() {} // 0x00000001826BD470-0x00000001826BDC70
	// [XID] // 0x0000000189B103A0-0x0000000189B103C0
	public void ClearPageState() {} // 0x00000001826B2FA0-0x00000001826B3080
	// [XID] // 0x0000000189B174E0-0x0000000189B17500
	private void UpdateBrowsingGadget() {} // 0x00000001826B3740-0x00000001826B3BE0
	// [XID] // 0x0000000189B1EE00-0x0000000189B1EE20
	private void SetEditSubStatE(HomeworldEditSubState subState) {} // 0x00000001826B5B70-0x00000001826B5D40
	// [XID] // 0x0000000189B26770-0x0000000189B26790
	private void SelectGadgetForEdit() {} // 0x00000001826B3460-0x00000001826B3740
	// [XID] // 0x0000000189B2D980-0x0000000189B2D9A0
	private void RemoveEditingGadget() {} // 0x00000001826B8510-0x00000001826B8630
	// [XID] // 0x0000000189B34DA0-0x0000000189B34DC0
	private void RotateEditGadget() {} // 0x00000001826BA4C0-0x00000001826BA5A0
	// [XID] // 0x0000000189B3C630-0x0000000189B3C650
	private void ConfirmEditGadget() {} // 0x00000001826BA020-0x00000001826BA110
	// [XID] // 0x0000000189B442D0-0x0000000189B442F0
	private void CancelEditGadget() {} // 0x00000001826BCDF0-0x00000001826BCFA0
	// [XID] // 0x0000000189B4B9C0-0x0000000189B4B9E0
	private void MoveEditTouchDown() {} // 0x00000001826BAA50-0x00000001826BB0A0
	// [XID] // 0x0000000189B52FB0-0x0000000189B52FD0
	private void MoveEditTouchUp() {} // 0x00000001826BEE10-0x00000001826BEF10
	// [XID] // 0x0000000189B5A980-0x0000000189B5A9A0
	private void MoveEditGadget() {} // 0x00000001826BC570-0x00000001826BC780
	// [XID] // 0x0000000189B61E10-0x0000000189B61E30
	private void CancelMoveEditGadget() {} // 0x00000001826B81A0-0x00000001826B83C0
	// [XID] // 0x0000000189B69AA0-0x0000000189B69AC0
	private void UpdateMoveEditTouchDrag() {} // 0x00000001826BE9C0-0x00000001826BEBD0
	// [XID] // 0x0000000189B71040-0x0000000189B71060
	private void RotateEditGadget90Deg() {} // 0x00000001826B4EB0-0x00000001826B5380
	// [XID] // 0x0000000189B78630-0x0000000189B78650
	private void RotateEditConfirm() {} // 0x00000001826BDEF0-0x00000001826BE070
	// [XID] // 0x0000000189B7FBD0-0x0000000189B7FBF0
	private void RotateEditCancel() {} // 0x00000001826B63A0-0x00000001826B6560
	// [XID] // 0x0000000189B87600-0x0000000189B87620
	private void RotateEditTouchDown() {} // 0x00000001826BA6F0-0x00000001826BAA50
	// [XID] // 0x0000000189B8E770-0x0000000189B8E790
	private void RotateEditDragStart() {} // 0x00000001826BC230-0x00000001826BC4B0
	// [XID] // 0x0000000189B95C90-0x0000000189B95CB0
	private void RotateEditDragEnd() {} // 0x00000001826BD3A0-0x00000001826BD470
	// [XID] // 0x0000000189B9D1D0-0x0000000189B9D1F0
	private void UpdateRotateEditDrag() {} // 0x00000001826B3080-0x00000001826B3460
	// [XID] // 0x0000000189BA4B70-0x0000000189BA4B90
	private void UpdateRotateMenu() {} // 0x00000001826BC970-0x00000001826BCB40
	// [XID] // 0x0000000189BABEB0-0x0000000189BABED0
	private Vector3 GetCursorPosition() => default; // 0x00000001826BDC70-0x00000001826BDD80
	// [XID] // 0x0000000189BB3520-0x0000000189BB3540
	private void On_SimpleTap(Gesture gesture) {} // 0x00000001826B8450-0x00000001826B8510
	// [XID] // 0x0000000189BBAB60-0x0000000189BBAB80
	private void On_TouchDown(Gesture gesture) {} // 0x00000001826B5380-0x00000001826B5460
	// [XID] // 0x0000000189BC2B70-0x0000000189BC2B90
	private void On_TouchUp(Gesture gesture) {} // 0x00000001826BBE70-0x00000001826BBF60
	// [XID] // 0x0000000189BCA280-0x0000000189BCA2A0
	private void OnMoveJoystick(float angle, float mold) {} // 0x00000001826BE740-0x00000001826BE9C0
	// [XID] // 0x0000000189BD1910-0x0000000189BD1930
	private bool SpawnGadgetForDeploy(HomeWorldFurnitureExcelConfig excelData) => default; // 0x00000001826BE070-0x00000001826BE540
	// [XID] // 0x0000000189BD8EC0-0x0000000189BD8EE0
	private void SpawnGadgetGOReady(BaseEntity gadget) {} // 0x00000001826BB850-0x00000001826BB990
	// [XID] // 0x00000001895E5A80-0x00000001895E5AA0
	private void SetupPlaceColListenrs(BaseEntity entity) {} // 0x00000001826B6A00-0x00000001826B6BB0
	// [XID] // 0x00000001895ED3B0-0x00000001895ED3D0
	private void ClearPlaceColListeners() {} // 0x00000001826BEF10-0x00000001826BF010
	// [XID] // 0x00000001895F4AF0-0x00000001895F4B10
	private void ToggleGridOption() {} // 0x00000001826B6950-0x00000001826B6A00
	// [XID] // 0x00000001895FC200-0x00000001895FC220
	private void ToggleAlignOption() {} // 0x00000001826B68A0-0x00000001826B6950
	// [XID] // 0x0000000189603BC0-0x0000000189603BE0
	private void ToggleSpawnRotateOption() {} // 0x00000001826B6EA0-0x00000001826B6F60
	// [XID] // 0x000000018960B540-0x000000018960B560
	private void SetGridOptionActive(bool active) {} // 0x00000001826BBCF0-0x00000001826BBE70
	// [XID] // 0x0000000189612910-0x0000000189612930
	private void SetAlignOptionActive(bool active) {} // 0x00000001826B6BB0-0x00000001826B6D00
	// [XID] // 0x000000018961A280-0x000000018961A2A0
	private void SetSpawnRotateOption(HomeworldDeployRotateMode rotMode) {} // 0x00000001826B6D00-0x00000001826B6EA0
	// [XID] // 0x00000001896217D0-0x00000001896217F0
	private void SaveLastRotationInfo() {} // 0x00000001826BA5A0-0x00000001826BA6F0
	// [XID] // 0x00000001896290A0-0x00000001896290C0
	private void UpdateMoveGadget() {} // 0x00000001826B8630-0x00000001826BA020
	// [XID] // 0x0000000189630A00-0x0000000189630A20
	private void UnlockMagnet() {} // 0x00000001826BA110-0x00000001826BA1B0
	// [XID] // 0x00000001896384E0-0x0000000189638500
	private bool UpdateMovingGdagetCollision(GadgetEntity selfEntity, GadgetEntity parentEntity) => default; // 0x00000001826BCB40-0x00000001826BCD40
	// [XID] // 0x000000018963F940-0x000000018963F960
	private bool VerifyMovingGadgetPlaceCol(GadgetEntity selfEntity, GadgetEntity parentEntity, out GadgetEntity colliderEntity) {
		colliderEntity = default;
		return default;
	} // 0x00000001826B3BE0-0x00000001826B4EB0
	// [XID] // 0x0000000189647140-0x0000000189647160
	private bool ApplyMagnetBettwenFurniture(MonoHomeworldPlaceCol selfPlaceCol, out Vector3 spotDiff, out float angleDiff, out GameObject alignObj) {
		spotDiff = default;
		angleDiff = default;
		alignObj = default;
		return default;
	} // 0x00000001826B6F60-0x00000001826B81A0
	// [XID] // 0x000000018964E810-0x000000018964E830
	private void DeployMovingGadget() {} // 0x00000001826BBF60-0x00000001826BC230
	// [XID] // 0x0000000189656000-0x0000000189656020
	private void CancelMovingGadget() {} // 0x00000001826BC780-0x00000001826BC8B0
}

