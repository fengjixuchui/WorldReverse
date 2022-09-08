/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class InLevelReportDialogContext : BaseDialogContext // TypeDefIndex: 29591
{
	// Fields
	private MonoInLevelReportDialog _dialogMono; // 0x178
	private uint _targetUid; // 0x180
	private string _targetNickName; // 0x188
	private List<string> _reportCaseList; // 0x190
	private Dictionary<string, ReportReasonType> _ReportCaseDic; // 0x198
	private ReportReasonType _seletedReportCase; // 0x1A0
	private string _reportContent; // 0x1A8
	private int _reportContentLimit; // 0x1B0
	private int _focusSlotIdx; // 0x1B4
	private MonoBtnFilterSlot _lastActiveBtnFilterSlot; // 0x1B8
	private FocusRegionType _focusRegion; // 0x1C0
	private MonoPS4IMEProxy _proxy; // 0x1C8

	// Nested types
	private enum FocusRegionType // TypeDefIndex: 29592
	{
		None = 0,
		ReportCaseSlotRegion = 1,
		ReportContentRegion = 2
	}

	// Constructors
	public InLevelReportDialogContext() {} // Dummy constructor
	public InLevelReportDialogContext(uint uid, string nickName) {} // 0x00000001827868E0-0x0000000182786A30

	// Methods
	public override void SetupView() {} // 0x0000000182786280-0x0000000182786640
	public override void ClearView() {} // 0x0000000182784D70-0x0000000182784F10
	protected override void BindViewCallbacks() {} // 0x0000000182784C50-0x0000000182784D70
	private void OnReportBtnClick() {} // 0x00000001827857B0-0x0000000182785A40
	private void OnCancelBtnClick() {} // 0x0000000182785370-0x00000001827853E0
	private void InitReportCaseDic() {} // 0x00000001827850D0-0x0000000182785230
	private void InitReportCaseList() {} // 0x0000000182785230-0x0000000182785370
	private void RefreshReportCaseItem(Transform trans, int index) {} // 0x0000000182785B70-0x0000000182785DE0
	private void OnReportCaseToggleChanged(bool on, string text, MonoBtnFilterSlot activeBtnFilterSlot) {} // 0x0000000182785A40-0x0000000182785B70
	public override bool OnNotify(Notify ntf) => default; // 0x0000000182785690-0x00000001827857B0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000182784FD0-0x00000001827850D0
	public override void OnNavRegionFocus(MonoJoypadNavRegionBase focusRegion) {} // 0x0000000182785450-0x0000000182785690
	public override void OnJoypadUIModuleSelectIndex(MonoJoypadUIModule sourceModule, int index, Transform transform, JoypadSelectIndexResult selectResult = JoypadSelectIndexResult.Normal /* Metadata: 0x00B0F9D1 */) {} // 0x00000001827853E0-0x0000000182785450
	private void RefreshSelectBtnText(int index) {} // 0x0000000182785FD0-0x00000001827860C0
	private void RefreshSelectBtnText(bool isOn) {} // 0x00000001827860C0-0x00000001827861B0
	private void ActiveInputField() {} // 0x0000000182784AD0-0x0000000182784C50
	private void ToggleReportCaseSlot(int index) {} // 0x0000000182786780-0x00000001827868E0
	private void RefreshScrollerSlotFocus(int index, bool isFocus) {} // 0x0000000182785DE0-0x0000000182785FD0
	private void FocusScrollerSlot(int currIndex) {} // 0x0000000182784F10-0x0000000182784FD0
	private void ResetReportSlotScroller() {} // 0x00000001827861B0-0x0000000182786280
	private void SwitchSelectInputButton(bool show) {} // 0x0000000182786640-0x0000000182786780
}

