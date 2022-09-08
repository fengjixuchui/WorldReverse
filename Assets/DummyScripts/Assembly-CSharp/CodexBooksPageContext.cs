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

public sealed class CodexBooksPageContext : BasePageContext // TypeDefIndex: 28488
{
	// Fields
	private MonoCodexBooksPage _pageMono; // 0x190
	private List<CodexModule.CodexBooksSet> _bookSetList; // 0x198
	private List<CodexModule.CodexBooksSet> _bookSetAllCollectedList; // 0x1A0
	private List<CodexModule.CodexBooksSet> _bookSetUnlockedList; // 0x1A8
	private List<CodexModule.CodexBooksSet> _bookSetLockedList; // 0x1B0
	private List<CodexModule.CodexBooksSet> _currentOptionBookSetList; // 0x1B8
	private ScreenOption _screenOption; // 0x1C0
	private MonoCodexBookSetRow _currentBookSetRow; // 0x1C8
	private INavSelectable _currrentNaviSelected; // 0x1D0
	private MonoSimpleReusableList _lastNaviVolumeList; // 0x1D8
	private bool _isFoldOrUnfolding; // 0x1E0
	private CodexBooksUISceneComponent _uiSceneComp; // 0x1E8
	private Coroutine _clickSetRowCoroutine; // 0x1F0
	private CodexModule.CodexBooksSet _currentProcessingSet; // 0x1F8
	private MonoCodexBookSetRow _currentProcessingSetRow; // 0x200
	private CodexModule.CodexBooksSet _currentContentSet; // 0x208
	private MonoCodexBookTitleRow _lastClickedBookTitleRow; // 0x210
	private Coroutine _clickBookVolumeCoroutine; // 0x218

	// Nested types
	private enum ScreenOption // TypeDefIndex: 28489
	{
		All = 0,
		AllCollected = 1,
		Unlocked = 2,
		Locked = 3
	}

	// Constructors
	public CodexBooksPageContext() {} // 0x0000000183620180-0x0000000183620250

	// Methods
	// [XID] // 0x0000000189699E80-0x0000000189699EA0
	protected override void BindViewCallbacks() {} // 0x000000018361B660-0x000000018361B7C0
	// [XID] // 0x00000001896A15E0-0x00000001896A1600
	private void OnBack() {} // 0x000000018361FB80-0x000000018361FC80
	// [XID] // 0x00000001896A8AC0-0x00000001896A8AE0
	private void OnScreen() {} // 0x000000018361B3D0-0x000000018361B660
	// [XID] // 0x00000001896AFC20-0x00000001896AFC40
	private void SetScreenOption(ScreenOption option) {} // 0x000000018361E490-0x000000018361E5A0
	// [XID] // 0x00000001896B75D0-0x00000001896B75F0
	private void RefreshScreenOption(Transform trans, int index) {} // 0x000000018361D8D0-0x000000018361DCD0
	// [XID] // 0x00000001896BE6E0-0x00000001896BE700
	public override void SetupView() {} // 0x000000018361FC80-0x0000000183620180
	// [XID] // 0x00000001896C5F70-0x00000001896C5F90
	public override void ClearView() {} // 0x000000018361B970-0x000000018361BA20
	// [IDTag] // 0x00000001896CD640-0x00000001896CD680
	// [XID] // 0x00000001896CD640-0x00000001896CD680
	private void RefreshBookSet() {} // 0x000000018361AF90-0x000000018361B2F0
	// [XID] // 0x00000001896D7A60-0x00000001896D7A80
	private void SetScreenText() {} // 0x000000018361CDE0-0x000000018361D0E0
	// [IDTag] // 0x00000001896DF300-0x00000001896DF340
	// [XID] // 0x00000001896DF300-0x00000001896DF340
	private void RefreshBookSet(Transform trans, int index) {} // 0x000000018361A9F0-0x000000018361AF90
	// [XID] // 0x00000001896E97F0-0x00000001896E9810
	private void OnClickSetRow(CodexModule.CodexBooksSet setConfig, MonoCodexBookSetRow setRow) {} // 0x000000018361DF30-0x000000018361E150
	// [XID] // 0x00000001896F0A50-0x00000001896F0A70
	private void OnClickSetRowImmediately(CodexModule.CodexBooksSet setConfig, MonoCodexBookSetRow setRow) {} // 0x000000018361BA20-0x000000018361BC40
	// [XID] // 0x00000001896F8240-0x00000001896F8260
	private void SetSetTitleText(MonoCodexBookSetRow setRow, CodexModule.CodexBooksSet set) {} // 0x000000018361C790-0x000000018361C930
	// [XID] // 0x00000001896FFBA0-0x00000001896FFBC0
	private void SetSetStar(Transform startParent, uint rankLevel) {} // 0x000000018361C3A0-0x000000018361C610
	// [XID] // 0x0000000189707270-0x0000000189707290
	private void SetQuality(MonoCodexBookSetRow setRow, uint rankLevel) {} // 0x000000018361B2F0-0x000000018361B3D0
	// [XID] // 0x000000018970EB10-0x000000018970EB30
	private void RefreshBookTitle(Transform trans, int index) {} // 0x000000018361ECF0-0x000000018361F0B0
	// [XID] // 0x0000000189715EF0-0x0000000189715F10
	private void OnClickBookVolume(MonoCodexBookTitleRow row, MonoCodexBookSetRow setRow, CodexModule.CodexBooksSet codexBooksSet, int volumeIndex) {} // 0x000000018361D0E0-0x000000018361D320
	// [XID] // 0x000000018971D950-0x000000018971D970
	private void OnClickBookVolumeImmediately(MonoCodexBookTitleRow row, MonoCodexBookSetRow setRow, CodexModule.CodexBooksSet codexBooksSet, int volumeIndex) {} // 0x000000018361F930-0x000000018361FAD0
	// [XID] // 0x0000000189724D70-0x0000000189724D90
	private void CheckSetBookVolumeViewed(MonoCodexBookTitleRow row, MonoCodexBookSetRow setRow, CodexModule.CodexBooksSet codexBooksSet, int volumeIndex) {} // 0x000000018361EAA0-0x000000018361ECF0
	// [XID] // 0x000000018972C520-0x000000018972C540
	private void CheckSetBookSetViewed(MonoCodexBookSetRow setRow, CodexModule.CodexBooksSet codexBooksSet) {} // 0x000000018361CBD0-0x000000018361CDE0
	// [XID] // 0x0000000189733C80-0x0000000189733CA0
	private void CheckSwitchBookSet(CodexModule.CodexBooksSet codexBooksSet) {} // 0x000000018361C610-0x000000018361C790
	// [XID] // 0x000000018973B3A0-0x000000018973B3C0
	private void RefreshBookDetail(Transform trans, int index) {} // 0x000000018361D320-0x000000018361D7E0
	// [XID] // 0x0000000189742D10-0x0000000189742D30
	private void FocusTitleTrans(Transform trans) {} // 0x000000018361D7E0-0x000000018361D8D0
	// [XID] // 0x000000018974AA30-0x000000018974AA50
	private void FocusContentTrans(int index) {} // 0x000000018361BC40-0x000000018361BDA0
	// [XID] // 0x0000000189751B10-0x0000000189751B30
	private void OnSetSelectChange(Transform prevItem, int prevIndex, Transform curItem, int curIndex) {} // 0x000000018361C930-0x000000018361CBD0
	// [XID] // 0x0000000189759100-0x0000000189759120
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x000000018361DD30-0x000000018361DE30
	// [XID] // 0x0000000189760D50-0x0000000189760D70
	private bool HandleInputActionEventScreen(InputActionEvent actionEvent) => default; // 0x000000018361F0B0-0x000000018361F720
	// [XID] // 0x00000001897680B0-0x00000001897680D0
	private bool HandleInputActionEventMain(InputActionEvent actionEvent) => default; // 0x000000018361E5A0-0x000000018361EAA0
	// [XID] // 0x000000018976F680-0x000000018976F6A0
	private void OnNavigationUp() {} // 0x000000018361BF90-0x000000018361C1A0
	// [XID] // 0x0000000189777000-0x0000000189777020
	private void OnNavigationDown() {} // 0x000000018361BDA0-0x000000018361BF90
	// [XID] // 0x000000018977E720-0x000000018977E740
	private void SetCurrentBookSetRow(MonoCodexBookSetRow row) {} // 0x000000018361F720-0x000000018361F850
	// [XID] // 0x0000000189785ED0-0x0000000189785EF0
	private void SetCurrentNaviSelected(INavSelectable selected) {} // 0x000000018361C1A0-0x000000018361C2A0
	// [XID] // 0x000000018978D570-0x000000018978D590
	private void SetNaviSelectedBookVolume(MonoSimpleReusableList subList) {} // 0x000000018361B7C0-0x000000018361B970
	// [XID] // 0x00000001897949B0-0x00000001897949D0
	private bool BookSetNavi(ContextEventType upOrDown) => default; // 0x000000018361E150-0x000000018361E490
}

