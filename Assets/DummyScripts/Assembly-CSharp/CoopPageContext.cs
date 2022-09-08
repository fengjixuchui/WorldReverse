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

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CoopPageContext : BasePageContext // TypeDefIndex: 30208
{
	// Fields
	private MonoCoopPage _pageMono; // 0x190
	private CoopPageContextData _pageData; // 0x198
	private CoopPageUI3DComponet _ui3DComponet; // 0x1A0
	private CoopUISceneComponent _uiSceneComp; // 0x1A8
	private uint _chapterId; // 0x1B0
	private CoopManager _coopManager; // 0x1B8
	private uint _locatePosId; // 0x1C0
	private Vector2? _lastCameraPos; // 0x1C4
	private bool _canHandleUI3D; // 0x1D0
	private uint _startPointId; // 0x1D4
	private bool _isStartPointFinish; // 0x1D8
	private CoopChapterExcelConfig _chapterConfig; // 0x1E0
	private Vector2? _screenCenterPos; // 0x1E8
	private MonoUIContainer _currOverUIContainer; // 0x1F8
	private bool _needCheckCameraMove; // 0x200
	private Vector3 _lastCursorPos; // 0x204
	private CoopRewardDialogContext _rewardDialog; // 0x210
	private CoopAlbumDialogContext _albumDialog; // 0x218
	private MonoUIContainer _tmpOverUIContainer; // 0x220

	// Constructors
	public CoopPageContext() {} // Dummy constructor
	public CoopPageContext(uint chapterId) {} // 0x0000000182AE1590-0x0000000182AE16D0

	// Methods
	// [XID] // 0x000000018980DB50-0x000000018980DB70
	public void UpdateCoopPageChapterId(uint chapterId) {} // 0x0000000182ADCE80-0x0000000182ADCF30
	// [XID] // 0x00000001898152D0-0x00000001898152F0
	public override void SetupView() {} // 0x0000000182AE12E0-0x0000000182AE1590
	// [XID] // 0x000000018981CCD0-0x000000018981CCF0
	private ElementType GetChapterElementType() => default; // 0x0000000182ADF580-0x0000000182ADF6B0
	// [XID] // 0x0000000189824110-0x0000000189824130
	private bool IsStartPointFinish() => default; // 0x0000000182ADB820-0x0000000182ADB970
	// [XID] // 0x000000018982BB60-0x000000018982BB80
	private void SetupStartChapterView() {} // 0x0000000182ADF830-0x0000000182ADFE50
	// [XID] // 0x00000001898330D0-0x00000001898330F0
	private void SetupCommonInfo() {} // 0x0000000182ADD790-0x0000000182ADDA60
	// [XID] // 0x000000018983A5A0-0x000000018983A5C0
	private void SetupJoypadView() {} // 0x0000000182ADF0E0-0x0000000182ADF300
	// [XID] // 0x0000000189841BA0-0x0000000189841BC0
	public override void ClearView() {} // 0x0000000182ADCD60-0x0000000182ADCE80
	// [XID] // 0x00000001898490B0-0x00000001898490D0
	public override bool OnNotify(Notify ntf) => default; // 0x0000000182AE0E30-0x0000000182AE0F90
	// [XID] // 0x0000000189850830-0x0000000189850850
	protected override void OnEnable() {} // 0x0000000182AE0D80-0x0000000182AE0E30
	// [XID] // 0x0000000189857C00-0x0000000189857C20
	private void onUI3DSetupFinish() {} // 0x0000000182ADEA40-0x0000000182ADEC00
	// [XID] // 0x000000018985ECB0-0x000000018985ECD0
	private void OnViewChange(float viewX, float viewY, float viewWidth, float viewHeight) {} // 0x0000000182ADE020-0x0000000182ADE2C0
	// [XID] // 0x0000000189866450-0x0000000189866470
	private void BindSlider() {} // 0x0000000182AE0F90-0x0000000182AE12E0
	// [XID] // 0x000000018986DDF0-0x000000018986DE10
	private void ChangeZoom(float value) {} // 0x0000000182AE0BE0-0x0000000182AE0CF0
	// [XID] // 0x0000000189875140-0x0000000189875160
	private void OnZoomChanged(float value) {} // 0x0000000182ADEF20-0x0000000182ADEFF0
	// [XID] // 0x000000018987CDB0-0x000000018987CDD0
	private void OnSliderChanged(float value) {} // 0x0000000182ADEC00-0x0000000182ADEF20
	// [XID] // 0x0000000189883D50-0x0000000189883D70
	private void ZoomEvent(float value) {} // 0x0000000182ADE6D0-0x0000000182ADE860
	// [XID] // 0x000000018988B3F0-0x000000018988B410
	private void CheckHidePoint(float value) {} // 0x0000000182ADEFF0-0x0000000182ADF0E0
	// [XID] // 0x0000000189892B30-0x0000000189892B50
	protected override void BindViewCallbacks() {} // 0x0000000182ADBE30-0x0000000182ADC0A0
	// [XID] // 0x000000018989A1B0-0x000000018989A1D0
	protected override void BindRedPoints() {} // 0x0000000182ADBCF0-0x0000000182ADBE30
	// [XID] // 0x00000001898A1470-0x00000001898A1490
	private void OnLocationBtnClick() {} // 0x0000000182ADCF30-0x0000000182ADCFF0
	// [XID] // 0x00000001898A8CE0-0x00000001898A8D00
	private void OnRewardBtnClick() {} // 0x0000000182ADE8C0-0x0000000182ADEA40
	// [XID] // 0x00000001898B0660-0x00000001898B0680
	private void OnAlbumBtnClick() {} // 0x0000000182ADCBE0-0x0000000182ADCD60
	// [XID] // 0x00000001898B7C50-0x00000001898B7C70
	private void RefreshPoint(uint chapterId) {} // 0x0000000182ADDD90-0x0000000182ADE020
	// [XID] // 0x00000001898BF240-0x00000001898BF260
	private void OnPointClick(CoopPoint info) {} // 0x0000000182ADC590-0x0000000182ADCBE0
	// [XID] // 0x00000001898C6BE0-0x00000001898C6C00
	private void SetupOngoingView() {} // 0x0000000182ADF6B0-0x0000000182ADF830
	// [XID] // 0x00000001898CE1A0-0x00000001898CE1C0
	private void StartPoint(uint pointId) {} // 0x0000000182ADD050-0x0000000182ADD2D0
	// [XID] // 0x00000001898D5BF0-0x00000001898D5C10
	private void OpenPointInfo(uint pointId) {} // 0x0000000182ADC0A0-0x0000000182ADC1B0
	// [XID] // 0x00000001898DD8E0-0x00000001898DD900
	private void ShowCG(uint pointId, bool isMale) {} // 0x0000000182AE09B0-0x0000000182AE0BE0
	// [XID] // 0x00000001898E5170-0x00000001898E5190
	private void OnStartPointSuccess(uint pointId) {} // 0x0000000182ADF300-0x0000000182ADF580
	// [XID] // 0x00000001898EC960-0x00000001898EC980
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000182ADE3C0-0x0000000182ADE6D0
	// [XID] // 0x00000001898F4350-0x00000001898F4370
	private void MoveCursor(Vector2 input) {} // 0x0000000182ADD2D0-0x0000000182ADD700
	// [XID] // 0x00000001898FBB20-0x00000001898FBB40
	private void CheckMoveCamera() {} // 0x0000000182ADC1B0-0x0000000182ADC590
	// [XID] // 0x0000000189903550-0x0000000189903570
	private void CameraMoveCallback() {} // 0x0000000182ADE2C0-0x0000000182ADE360
	// [XID] // 0x000000018990AAA0-0x000000018990AAC0
	private void CheckUpdateCursorPos() {} // 0x0000000182ADDA60-0x0000000182ADDD90
	// [XID] // 0x0000000189912750-0x0000000189912770
	private void UpdateCurrOverGameObject() {} // 0x0000000182AE0110-0x0000000182AE0950
	// [XID] // 0x000000018991A020-0x000000018991A040
	private void CalScreenCenterPos() {} // 0x0000000182ADB9D0-0x0000000182ADBCF0
	// [XID] // 0x0000000189921860-0x0000000189921880
	public bool IsPosInScreenFocusRange(Vector2 pos) => default; // 0x0000000182ADFE50-0x0000000182AE00A0
}

