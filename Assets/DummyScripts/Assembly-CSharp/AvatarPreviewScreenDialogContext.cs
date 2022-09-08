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

public sealed class AvatarPreviewScreenDialogContext : BaseDialogContext // TypeDefIndex: 28808
{
	// Fields
	private List<ulong> _avatarScreenList; // 0x178
	private List<ulong> _avatarManualList; // 0x180
	private MonoInLevelAvatarPreviewScreenDialog _dialogMono; // 0x188
	private FilterReceiver _parentContext; // 0x190
	private List<string> _elementNameList; // 0x198
	private List<string> _weaponNameList; // 0x1A0
	private Dictionary<string, bool> _screenElementFlagDictionary; // 0x1A8
	private Dictionary<string, bool> _screenWeaponFlagDictionary; // 0x1B0
	private Dictionary<string, bool> _screenElementLastFlagDictionary; // 0x1B8
	private Dictionary<string, bool> _screenWeaponLastFlagDictionary; // 0x1C0
	private bool _isScreened; // 0x1C8
	private List<string> _screenNameList; // 0x1D0
	private int _lastScreenNameListCount; // 0x1D8
	private bool _isOn; // 0x1DC
	private ParentPageType _parentPageType; // 0x1E0
	private bool _validForOnEnable; // 0x1E4
	private float _width; // 0x1E8
	private bool _isElement; // 0x1EC
	private int _selectIndex; // 0x1F0
	private const int INPUT_STATE_PARENT_INVALID = 101; // Metadata: 0x00B0E749

	// Properties
	public bool isScreened { /* [XID] */ /* 0x000000018999C9F0-0x000000018999CA10 */ get => default; } // 0x0000000183CFA4B0-0x0000000183CFA560 
	public bool validForOnEnable { /* [XID] */ /* 0x00000001899A43C0-0x00000001899A43E0 */ get => default; /* [XID] */ /* 0x00000001899ABDA0-0x00000001899ABDC0 */ set {} } // 0x0000000183CF97C0-0x0000000183CF9870 0x0000000183CFDD20-0x0000000183CFDDD0
	public FilterReceiver parentContext { /* [XID] */ /* 0x00000001899B36D0-0x00000001899B36F0 */ get => default; /* [XID] */ /* 0x00000001899BAA90-0x00000001899BAAB0 */ set {} } // 0x0000000183CFB020-0x0000000183CFB0D0 0x0000000183CFB580-0x0000000183CFB630

	// Nested types
	public enum ParentPageType // TypeDefIndex: 28809
	{
		Normal = 0,
		CharacterSelect = 1
	}

	// Constructors
	public AvatarPreviewScreenDialogContext() {} // Dummy constructor
	public AvatarPreviewScreenDialogContext(ParentPageType parentPageType = ParentPageType.Normal /* Metadata: 0x00B0E740 */, float width = 0f /* Metadata: 0x00B0E744 */, List<string> screenNameList = null, List<ulong> manualList = null) {} // 0x0000000183CFE7E0-0x0000000183CFEA70

	// Methods
	// [XID] // 0x00000001899C23B0-0x00000001899C23D0
	public override void SetupView() {} // 0x0000000183CFDDD0-0x0000000183CFE7E0
	// [XID] // 0x00000001899C9AA0-0x00000001899C9AC0
	public override void ClearView() {} // 0x0000000183CF9870-0x0000000183CF9910
	// [XID] // 0x00000001899D1350-0x00000001899D1370
	protected override void BindViewCallbacks() {} // 0x0000000183CF9480-0x0000000183CF9640
	// [XID] // 0x00000001899D87E0-0x00000001899D8800
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000183CFB130-0x0000000183CFB520
	// [XID] // 0x00000001899DFF10-0x00000001899DFF30
	protected override void OnEnable() {} // 0x0000000183CFDB70-0x0000000183CFDD20
	// [XID] // 0x00000001899E7900-0x00000001899E7920
	private void RefreshElementScreenItem(Transform trans, int index) {} // 0x0000000183CFC2B0-0x0000000183CFC530
	// [XID] // 0x00000001899EEE70-0x00000001899EEE90
	private void RefreshWeaponScreenItem(Transform trans, int index) {} // 0x0000000183CFC530-0x0000000183CFC7B0
	// [XID] // 0x00000001899F6790-0x00000001899F67B0
	private void RefreshLastElementScreenItem(Transform trans, int index) {} // 0x0000000183CF8640-0x0000000183CF8890
	// [XID] // 0x00000001899FDD10-0x00000001899FDD30
	private void RefreshLastWeaponScreenItem(Transform trans, int index) {} // 0x0000000183CFD440-0x0000000183CFD690
	// [XID] // 0x0000000189A056D0-0x0000000189A056F0
	private void RefreshElementScreenItemState(Transform trans, int index) {} // 0x0000000183CF9640-0x0000000183CF97C0
	// [XID] // 0x0000000189A0C9D0-0x0000000189A0C9F0
	private void RefreshWeaponScreenItemState(Transform trans, int index) {} // 0x0000000183CFCDF0-0x0000000183CFCF70
	// [XID] // 0x0000000189A14320-0x0000000189A14340
	private void RefreshScreenNameList() {} // 0x0000000183CFBC80-0x0000000183CFC130
	// [XID] // 0x0000000189A1B590-0x0000000189A1B5B0
	private void RefreshScreenNameListItem(Transform trans, int index) {} // 0x0000000183CFCCA0-0x0000000183CFCDF0
	// [XID] // 0x0000000189A22F50-0x0000000189A22F70
	private void InitialElementNameList() {} // 0x0000000183CF9A30-0x0000000183CF9C00
	// [XID] // 0x0000000189A2A1A0-0x0000000189A2A1C0
	private void InitialWeaponNameList() {} // 0x0000000183CFC130-0x0000000183CFC2B0
	// [XID] // 0x0000000189A31620-0x0000000189A31640
	private void InitialElementFlagDictionary() {} // 0x0000000183CF9C60-0x0000000183CF9FA0
	// [XID] // 0x0000000189A390F0-0x0000000189A39110
	private void InitialWeaponFlagDictionary() {} // 0x0000000183CFA190-0x0000000183CFA420
	// [XID] // 0x0000000189A408D0-0x0000000189A408F0
	private void OnScreenElementToggleChanged(bool on, string text) {} // 0x0000000183CFC8D0-0x0000000183CFCA30
	// [XID] // 0x0000000189A47F50-0x0000000189A47F70
	private void OnScreenWeaponToggleChanged(bool on, string text) {} // 0x0000000183CFCA30-0x0000000183CFCB90
	// [XID] // 0x0000000189A4F710-0x0000000189A4F730
	public void OnClose() {} // 0x0000000183CFABE0-0x0000000183CFAF20
	// [XID] // 0x0000000189A56E30-0x0000000189A56E50
	public void OnParentClose() {} // 0x0000000183CFD9B0-0x0000000183CFDB70
	// [XID] // 0x0000000189A5E9A0-0x0000000189A5E9C0
	private void OnReset() {} // 0x0000000183CF92A0-0x0000000183CF9480
	// [XID] // 0x0000000189A66120-0x0000000189A66140
	private void OnReturn() {} // 0x0000000183CFA670-0x0000000183CFABE0
	// [XID] // 0x0000000189A6D7B0-0x0000000189A6D7D0
	private void OnScreenBtnClick() {} // 0x0000000183CF8890-0x0000000183CF90D0
	// [XID] // 0x0000000189A74ED0-0x0000000189A74EF0
	private bool GetScreenDicState(Dictionary<string, bool> dic) => default; // 0x0000000183CF9FA0-0x0000000183CFA190
	// [XID] // 0x0000000189A7CB20-0x0000000189A7CB40
	public void SetFadeInTrigger() {} // 0x0000000183CFB630-0x0000000183CFBC80
	// [XID] // 0x0000000189A84460-0x0000000189A84480
	public void SetListFadeOutTrigger() {} // 0x0000000183CFCF70-0x0000000183CFD0C0
	// [XID] // 0x0000000189A8BDD0-0x0000000189A8BDF0
	private void SetDialogWidth() {} // 0x0000000183CF8510-0x0000000183CF8640
	// [XID] // 0x0000000189A93320-0x0000000189A93340
	private void SelectPrevSlot(int currIndex) {} // 0x0000000183CFCB90-0x0000000183CFCCA0
	// [XID] // 0x0000000189A9AD60-0x0000000189A9AD80
	private void SelectNextSlot(int currIndex) {} // 0x0000000183CFA560-0x0000000183CFA670
	// [XID] // 0x0000000189AA2110-0x0000000189AA2130
	private void SelectUpwardSlot(int currIndex) {} // 0x0000000183CF9910-0x0000000183CF9A30
	// [XID] // 0x0000000189AA95B0-0x0000000189AA95D0
	private void SelectBelowSlot(int currIndex) {} // 0x0000000183CFC7B0-0x0000000183CFC8D0
	// [XID] // 0x0000000189AB14B0-0x0000000189AB14D0
	private int GetRealMoveSlotIndex(int index) => default; // 0x0000000183CFAF20-0x0000000183CFB020
	// [XID] // 0x0000000189AB8760-0x0000000189AB8780
	private int GetFixSideItemCount(MonoSimpleReusableList scroller) => default; // 0x0000000183CF90D0-0x0000000183CF92A0
	// [XID] // 0x0000000189AC0430-0x0000000189AC0450
	private void SelectScrollerSlot(int currIndex, bool exchange = false /* Metadata: 0x00B0E748 */) {} // 0x0000000183CFD0C0-0x0000000183CFD440
	// [XID] // 0x0000000189AC7E00-0x0000000189AC7E20
	private void OnSelectToggle(int currIndex) {} // 0x0000000183CFD690-0x0000000183CFD950
}

