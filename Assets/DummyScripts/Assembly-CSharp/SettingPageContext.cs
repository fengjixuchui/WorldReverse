/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text.RegularExpressions;
using IFix.Core;
using MoleMole;
using Rewired;
using UnityEngine;
using UnityEngine.Events;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class SettingPageContext : BasePageContext // TypeDefIndex: 29269
{
	// Fields
	private bool _canShow_UserCenterButton; // 0x190
	private bool _canShow_BindAccountButton; // 0x191
	private bool _canShow_CdKeyButton; // 0x192
	private bool _canShow_PrivacyButton; // 0x193
	private MonoButtonSetting _userCenterButton; // 0x198
	private MonoButtonSetting _bindAccountButton; // 0x1A0
	private MonoButtonSetting _cdKeyButton; // 0x1A8
	private MonoButtonSetting _privacyButton; // 0x1B0
	private List<string> _settingAccountConfirmButtonText; // 0x1B8
	private MonoDropdownSetting _gyroAimingSetting; // 0x1C0
	private MonoDropdownSetting _inputTypeSetting; // 0x1C8
	private List<string> _inputTypeSettingOptions; // 0x1D0
	private static string IOS_VERSION_DETECT_PATTERN; // 0x00
	private static Regex iosVersionDetectRegex; // 0x08
	private const float ENABLE_SWITCH_TO_JOYPAD_IOS_VERSION = 14f; // Metadata: 0x00B0F475
	private MonoSliderSetting _mouseSensitivitySetting; // 0x1D8
	private MonoSliderSetting _defaultCameraSensitivitySetting; // 0x1E0
	private MonoSliderSetting _focusCameraSensitivitySetting; // 0x1E8
	private MonoDropdownSetting _focusCameraAccelerationSetting; // 0x1F0
	private MonoDropdownSetting _cameraInvertXSetting; // 0x1F8
	private MonoDropdownSetting _cameraInvertYSetting; // 0x200
	private MonoDropdownSetting _focusCameraInvertXSetting; // 0x208
	private MonoDropdownSetting _focusCameraInvertYSetting; // 0x210
	private MonoSliderSetting _uiBorderOffsetSetting; // 0x218
	private Coroutine _refreshUIBorderOffsetCoroutine; // 0x220
	private int _uiBorderOffset; // 0x228
	private MonoSettingPage _pageMono; // 0x230
	private int _currCategoryIndex; // 0x238
	private int _initIndex; // 0x23C
	private MonoScrollRectExtention scrollRectExtension; // 0x240
	private bool _shouldRefreshPageOnClearView; // 0x248
	private bool _isKeySettingDirty; // 0x249
	private MonoToggleSetting resinNotification; // 0x250
	private MonoToggleSetting exploreNotification; // 0x258
	private MonoDropdownSetting _miniMapDropDown; // 0x260
	private Dictionary<int, string> _settingOtherConfirmTextDic; // 0x268
	private MonoSliderSetting _cameraDistanceSetting; // 0x270
	private const int INPUT_STATE_DEFAULT = 0; // Metadata: 0x00B0F479
	private const int INPUT_STATE_DROPDOWN = 1; // Metadata: 0x00B0F47D
	private const int INPUT_STATE_SCROLLER = 2; // Metadata: 0x00B0F481
	private bool focusOnTab; // 0x278
	private int _selectedSettingItemIndex; // 0x27C
	private List<MonoBaseSettingItem> _settingItems; // 0x280
	private MonoDropdownSetting dropdownSetting; // 0x288
	private List<string> _graphicsSettingLevels; // 0x290
	private PerfCostRatioGrade _perfGrade; // 0x298
	private bool _perfInitialized; // 0x29C
	private MonoButtonSetting _PS4HDRSetting; // 0x2A0
	private MonoDropdownSetting _volatileSetting; // 0x2A8
	private List<string> _fullScreenSettingOptions; // 0x2B0
	private List<MonoDropdownSetting> _customVolatileSettings; // 0x2B8
	private List<string> _customVolatileGrades; // 0x2C0
	private Dictionary<GraphicsSettingEntryType, Dictionary<int, int>> _entryResortIndexMap; // 0x2C8
	private MonoDropdownSetting _volumetricSetting; // 0x2D0
	private ConfigGraphicsSettingEntry _volumeSettingEntry; // 0x2D8
	private MonoDropdownSetting _languageDropdown; // 0x2E0
	private MonoDropdownSetting _languageVoiceDropDown; // 0x2E8
	private List<string> _languageVoiceTypes; // 0x2F0
	private bool isVoiceDownloadDialogShowing; // 0x2F8
	private ConfigLanguageSetting _languageConfig; // 0x300
	private LanguageType _beforeTextLanguage; // 0x308
	private LanguageType _afterTextLanguage; // 0x30C
	private VoiceLanguageType _beforeVoiceLanguage; // 0x310
	private VoiceLanguageType _afterVoiceLanguage; // 0x314
	private MonoGridScroller _currentMenuSwitchScroller; // 0x318
	private InputActionType[] _gameplayDisplayActionsJoypad; // 0x320
	private SwitchInputActionType[] _menuSwitchActionsJoypad; // 0x328
	private int[] _gameplayChangeableElementIDPS4; // 0x330
	private int[] _gameplayChangeableElementIDXBox; // 0x338
	private int[] _gameplayChangeableElementIDUnknown; // 0x340
	private InputActionType[] _gameplayDisplayActionsKeyboard; // 0x348
	private InputActionType[] _menuDisplayActionsKeyboard; // 0x350
	private HashSet<KeyCode> _ignoreKeyCodeWhenChangingPressKey; // 0x358
	private List<ModifyMapData> _gameplayActionKeyCodePairs; // 0x360
	private List<ModifyMapData> _menuActionKeyCodePairs; // 0x368
	private List<Sprite> _gameplayChangeableElementIDSprite; // 0x370
	private int _currentSelectMenuSwitchIndex; // 0x378
	private bool _modifyingMap; // 0x37C
	private bool _hasModifySource; // 0x37D
	private InputActionGroupType _inputActionGroupType; // 0x380
	private MonoControlSettingRow _selectedSettingRow; // 0x388
	private ModifyMapData _modifyMapData; // 0x390
	private const string CHANGE_PRESSKEY_TEXT_TEMPLATE = "<color=#4A5366FF>{0}</color>"; // Metadata: 0x00B0F485
	private const string RESOLVE_CONFLICT_TEXT_TEMPLATE = "<color=#FF5E41FF>{0}({1})</color>"; // Metadata: 0x00B0F4A5
	private const float AUDIO_SETTING_SLIDER_VOICE_AUTO_RESET_TIME = 4f; // Metadata: 0x00B0F4CA
	private UnsignedDumbAutoIncreaser _audioSettingSliderIdGenerator; // 0x398
	private uint _audioSettingSliderCurrentOperateId; // 0x3A0
	private int _audioSettingSliderVoiceCurrentIndex; // 0x3A4
	private int _audioSettingSliderVoiceCurrentCnt; // 0x3A8
	private bool _audioSettingSliderVoicePlaying; // 0x3AC
	private int _audioSettingSliderVoiceCurrentStub; // 0x3B0
	private float _audioSettingSliderVoiceLastTime; // 0x3B4

	// Properties
	private static string LanguageSettingConfigPath { /* [XID] */ /* 0x0000000189AA51B0-0x0000000189AA51D0 */ get => default; } // 0x00000001815DA850-0x00000001815DA8F0 
	private int[] gameplayChangeableElementID { /* [XID] */ /* 0x000000018964B930-0x000000018964B950 */ get => default; } // 0x00000001815DABD0-0x00000001815DACD0 

	// Nested types
	private class SwitchInputActionType // TypeDefIndex: 29270
	{
		// Fields
		public InputActionType action1; // 0x10
		public InputActionType action2; // 0x14

		// Constructors
		public SwitchInputActionType() {} // Dummy constructor
		public SwitchInputActionType(InputActionType action1, InputActionType action2) {} // 0x0000000182F8BA60-0x0000000182F8BAE0
	}

	private class ActionKeyCodePair // TypeDefIndex: 29271
	{
		// Fields
		public InputActionType action; // 0x10
		public KeyCode keycode; // 0x14

		// Constructors
		public ActionKeyCodePair() {} // Dummy constructor
		public ActionKeyCodePair(InputActionType action, KeyCode keycode) {} // 0x0000000182F8CAE0-0x0000000182F8CB60
	}

	private enum ModifyMapDataType // TypeDefIndex: 29272
	{
		ActionKeyCodePair = 0,
		AssignConflictInfo = 1
	}

	private class ModifyMapData // TypeDefIndex: 29273
	{
		// Properties
		public ModifyMapDataType modifyMapDataType { /* [XID] */ /* 0x000000018974D770-0x000000018974D7B0 */ get; private set; } // 0x0000000182F8CF70-0x0000000182F8CFD0 0x0000000182F8CE50-0x0000000182F8CEB0
		public ActionKeyCodePair actionKeyCodePair { /* [XID] */ /* 0x000000018975F4B0-0x000000018975F4F0 */ get; private set; } // 0x0000000182F8CF10-0x0000000182F8CF70 0x0000000182F8CCB0-0x0000000182F8CD10
		public RewiredWrapper.AssignConflictInfo assignConflictInfo { /* [XID] */ /* 0x0000000189770F70-0x0000000189770FB0 */ get; private set; } // 0x0000000182F8CFD0-0x0000000182F8D030 0x0000000182F8CEB0-0x0000000182F8CF10
		public InputActionType inputActionType { /* [XID] */ /* 0x000000018978A4D0-0x000000018978A4F0 */ get => default; } // 0x0000000182F8CD10-0x0000000182F8CE50 

		// Constructors
		public ModifyMapData() {} // Dummy constructor
		public ModifyMapData(ActionKeyCodePair actionKeyCodePair) {} // 0x0000000182F8D120-0x0000000182F8D210
		public ModifyMapData(RewiredWrapper.AssignConflictInfo assignConflictInfo) {} // 0x0000000182F8D030-0x0000000182F8D120

		// Methods
		// [XID] // 0x0000000189783020-0x0000000189783040
		public bool IsValid() => default; // 0x0000000182F8CB60-0x0000000182F8CCB0
	}

	// Constructors
	public SettingPageContext() {} // 0x00000001815F42B0-0x00000001815F4900
	static SettingPageContext() {} // 0x00000001815F41F0-0x00000001815F42B0

	// Methods
	// [XID] // 0x00000001897A7150-0x00000001897A7170
	private void RefreshAccountSetting() {} // 0x00000001815F1B50-0x00000001815F2250
	// [XID] // 0x00000001897AEB00-0x00000001897AEB20
	private void CheckAccountPlatformSettingShow() {} // 0x00000001815E0240-0x00000001815E0430
	// [XID] // 0x00000001897B6990-0x00000001897B69B0
	public static bool CanPlatformShowRedPoint() => default; // 0x00000001815E4DD0-0x00000001815E4E70
	// [XID] // 0x00000001897BE7D0-0x00000001897BE7F0
	private string GetAccountSettingConfirmButtonText(int index) => default; // 0x00000001815DDBC0-0x00000001815DDCB0
	// [XID] // 0x00000001897C5EE0-0x00000001897C5F00
	private void OnUserCenterClicked() {} // 0x00000001815E1280-0x00000001815E1400
	// [XID] // 0x00000001897CD6C0-0x00000001897CD6E0
	private void OnBindAccountButtonClicked() {} // 0x00000001815E3020-0x00000001815E3290
	// [XID] // 0x00000001897D4C40-0x00000001897D4C60
	private void OnCdCodeButtonClicked() {} // 0x00000001815E3BE0-0x00000001815E3CF0
	// [XID] // 0x00000001897DC360-0x00000001897DC380
	private void OnPrivacyButtonClicked() {} // 0x00000001815E7C90-0x00000001815E7E60
	// [XID] // 0x00000001897E3CB0-0x00000001897E3CD0
	private void RefreshControlSetting() {} // 0x00000001815EA8A0-0x00000001815EAB90
	// [XID] // 0x00000001897EB8E0-0x00000001897EB900
	private void RefreshTouchScreenControllTagGroup() {} // 0x00000001815E8EB0-0x00000001815E90C0
	// [XID] // 0x00000001897F31C0-0x00000001897F31E0
	private void RefreshInputTypeGroup() {} // 0x00000001815DDE50-0x00000001815DE050
	// [XID] // 0x00000001897FAA30-0x00000001897FAA50
	private void RefreshInputTypeGroupWithTouchScreen() {} // 0x00000001815EDBD0-0x00000001815EDDD0
	// [XID] // 0x0000000189802000-0x0000000189802020
	private void RefreshGyroAimingSetting(MonoSettingGroup inputTypeGroup) {} // 0x00000001815F3920-0x00000001815F3E20
	// [XID] // 0x0000000189809470-0x0000000189809490
	private void RefreshInputTypeSetting(MonoSettingGroup inputTypeGroup) {} // 0x00000001815EBE50-0x00000001815EC1D0
	// [XID] // 0x0000000189810C80-0x0000000189810CA0
	private void UpdateInputTabOptions() {} // 0x00000001815E5D10-0x00000001815E6170
	// [XID] // 0x0000000189818730-0x0000000189818750
	private bool CurrentPlatformEnableSwitchToJoypad() => default; // 0x00000001815EFDC0-0x00000001815F0140
	// [XID] // 0x0000000189820000-0x0000000189820020
	private void OnInputTypeChanged(int index) {} // 0x00000001815E3460-0x00000001815E3720
	// [XID] // 0x0000000189827600-0x0000000189827620
	private void DelaySwitchInputDevice(int switchIndex) {} // 0x00000001815EB480-0x00000001815EB880
	// [XID] // 0x000000018982E840-0x000000018982E860
	private void SwitchInputDeviceToKeyboardWithMouse() {} // 0x00000001815EDE70-0x00000001815EE0E0
	// [XID] // 0x00000001898361C0-0x00000001898361E0
	private void SwitchInputDeviceToJoypad() {} // 0x00000001815DD020-0x00000001815DD290
	// [XID] // 0x000000018983D630-0x000000018983D650
	private void SwitchInputDeviceToTouchScreen() {} // 0x00000001815DACD0-0x00000001815DAF40
	// [XID] // 0x0000000189844E30-0x0000000189844E50
	private void RefreshVoiceVibrate(MonoSettingGroup inputTypeGroup) {} // 0x00000001815E2A70-0x00000001815E2D80
	// [XID] // 0x000000018984C2E0-0x000000018984C300
	private void OnVoiceVibrate(int value) {} // 0x00000001815F0250-0x00000001815F0340
	// [XID] // 0x0000000189853470-0x0000000189853490
	private void RefreshKeyboardMouseControlSetting() {} // 0x00000001815EE810-0x00000001815EEA10
	// [XID] // 0x000000018985AEE0-0x000000018985AF00
	private void RefreshKeyboardControlSetting() {} // 0x00000001815E47B0-0x00000001815E49B0
	// [XID] // 0x0000000189862340-0x0000000189862360
	private void RefreshTouchpadControlSetting() {} // 0x00000001815E01A0-0x00000001815E0240
	// [XID] // 0x00000001898697F0-0x0000000189869810
	private void OnMouseSensitivityChanged(float value) {} // 0x00000001815E2710-0x00000001815E28B0
	// [XID] // 0x0000000189870A10-0x0000000189870A30
	private void RefreshSensitivitySetting(MonoSettingGroup keyGroup) {} // 0x00000001815E9C90-0x00000001815EA480
	// [XID] // 0x00000001898784C0-0x00000001898784E0
	private void OnDefaultCameraSensitiviyChanged(float value) {} // 0x00000001815E0F00-0x00000001815E10D0
	// [XID] // 0x000000018987F9B0-0x000000018987F9D0
	private void OnFocusCameraSensitivityChanged(float value) {} // 0x00000001815DD630-0x00000001815DD800
	// [XID] // 0x0000000189887040-0x0000000189887060
	private void RefreshFocusAccelerationSetting(MonoSettingGroup keyGroup) {} // 0x00000001815E4AD0-0x00000001815E4DD0
	// [XID] // 0x000000018988E1B0-0x000000018988E1D0
	private void OnTouchPadFocusAccelerationChange(bool enable) {} // 0x00000001815E3AF0-0x00000001815E3BE0
	// [XID] // 0x0000000189895820-0x0000000189895840
	private void RefreshInvertCameraSetting(MonoSettingGroup keyGroup) {} // 0x00000001815F2D30-0x00000001815F3520
	// [XID] // 0x000000018989CFA0-0x000000018989CFC0
	private void OnJoypadInvertCameraChange(InputManager.InvertCameraType cameraType, InputManager.InvertCameraAxisType axisType, int value) {} // 0x00000001815E49B0-0x00000001815E4AD0
	// [XID] // 0x00000001898A4800-0x00000001898A4820
	private void RefreshControlSettingRow(MonoControlSettingRow ins, InputActionType actionType, InputDeviceType deviceType) {} // 0x00000001815E92C0-0x00000001815E95C0
	// [XID] // 0x00000001898ABCA0-0x00000001898ABCC0
	private bool TrySteupToAvatarTriggerSkillAction(MonoControlSettingRow ins, InputActionType actionType) => default; // 0x00000001815E38F0-0x00000001815E3AF0
	// [XID] // 0x00000001898B33D0-0x00000001898B33F0
	private bool IsAvatarTriggerSkillAction(InputActionType actionType) => default; // 0x00000001815EE390-0x00000001815EE460
	// [XID] // 0x00000001898BB0B0-0x00000001898BB0D0
	private void RefreshRunWalkSwitchSetting(MonoSettingGroup keyGroup) {} // 0x00000001815E4030-0x00000001815E4300
	// [XID] // 0x00000001898C2440-0x00000001898C2460
	private void OnChangeWalkRunSwitchSetting(bool useBtn) {} // 0x00000001815E8C90-0x00000001815E8E40
	// [XID] // 0x00000001898C9E60-0x00000001898C9E80
	private void RefreshUIBorderOffsetSetting(MonoSettingGroup keyGroup) {} // 0x00000001815E66D0-0x00000001815E6AF0
	// [XID] // 0x00000001898D1520-0x00000001898D1540
	private void OnUIBorderOffsetChanged(float value) {} // 0x00000001815EF650-0x00000001815EF800
	// [XID] // 0x00000001898D8D60-0x00000001898D8D80
	private void UIBorderOffset() {} // 0x00000001815EFC20-0x00000001815EFDC0
	// [XID] // 0x00000001898E0A50-0x00000001898E0A70
	public override void SetupView() {} // 0x00000001815F3EC0-0x00000001815F4130
	// [XID] // 0x00000001898E8590-0x00000001898E85B0
	public override void UpdateView() {} // 0x00000001815F4130-0x00000001815F41F0
	// [XID] // 0x00000001898EFD30-0x00000001898EFD50
	protected override void OnEnable() {} // 0x00000001815F2410-0x00000001815F24B0
	// [XID] // 0x00000001898F7570-0x00000001898F7590
	protected override void BindRedPoints() {} // 0x00000001815DB370-0x00000001815DB640
	// [XID] // 0x00000001898FECC0-0x00000001898FECE0
	protected override void BindViewCallbacks() {} // 0x00000001815DB640-0x00000001815DB910
	// [XID] // 0x0000000189906440-0x0000000189906460
	private void OnSettingCategoryTabChanged(int index) {} // 0x00000001815E6340-0x00000001815E66D0
	// [XID] // 0x000000018990DEC0-0x000000018990DEE0
	public override void ClearView() {} // 0x00000001815DD800-0x00000001815DDBC0
	[DebuggerHidden] // 0x0000000189915610-0x0000000189915650
	// [XID] // 0x0000000189915610-0x0000000189915650
	private IEnumerator RefreshCurrentPage() => default; // 0x00000001815EA480-0x00000001815EA550
	// [XID] // 0x000000018991FEE0-0x000000018991FF00
	private void SetupTab(int index) {} // 0x00000001815E5680-0x00000001815E5740
	// [XID] // 0x0000000189927740-0x0000000189927760
	private void RefreshSettingPage() {} // 0x00000001815DE530-0x00000001815DEB80
	// [XID] // 0x000000018992EEC0-0x000000018992EEE0
	private void ClearTab(int index) {} // 0x00000001815F2BE0-0x00000001815F2D30
	// [XID] // 0x00000001899362D0-0x00000001899362F0
	public void TrySetTab(int index) {} // 0x00000001815EF990-0x00000001815EFA60
	// [XID] // 0x000000018993DCB0-0x000000018993DCD0
	private void RefreshMessageSetting() {} // 0x00000001815EB880-0x00000001815EB950
	// [XID] // 0x0000000189945400-0x0000000189945420
	private void SetupNotificationToggle() {} // 0x00000001815DC570-0x00000001815DCBD0
	// [XID] // 0x000000018994C940-0x000000018994C960
	private void RefreshNotificationValue() {} // 0x00000001815E8380-0x00000001815E8570
	// [XID] // 0x0000000189953FE0-0x0000000189954000
	private void RefreshOtherSetting() {} // 0x00000001815EC8A0-0x00000001815EDBD0
	// [XID] // 0x000000018995B890-0x000000018995B8B0
	private void OnDefaultCameraDistanceAdjust(float value) {} // 0x00000001815E1830-0x00000001815E1A80
	// [XID] // 0x00000001899634A0-0x00000001899634C0
	private string GetCameraDistanceValueShow(float value) => default; // 0x00000001815DDCB0-0x00000001815DDDB0
	// [XID] // 0x000000018996A7C0-0x000000018996A7E0
	private void OnFileIntegrityCheckClicked() {} // 0x00000001815DB180-0x00000001815DB370
	// [XID] // 0x0000000189972520-0x0000000189972540
	private void OnNeedDownloadPreResClicked() {} // 0x00000001815DCBD0-0x00000001815DD020
	// [XID] // 0x0000000189979D00-0x0000000189979D20
	public override bool OnNotify(Notify ntf) => default; // 0x00000001815F24B0-0x00000001815F2680
	// [XID] // 0x0000000189981530-0x0000000189981550
	private void SetInputFocus(bool inTab) {} // 0x00000001815F28A0-0x00000001815F2BE0
	// [XID] // 0x0000000189988D00-0x0000000189988D20
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001815E6AF0-0x00000001815E7010
	// [XID] // 0x0000000189990560-0x0000000189990580
	private void UnselectSettingItem() {} // 0x00000001815E28B0-0x00000001815E2A70
	// [XID] // 0x00000001899980D0-0x00000001899980F0
	private void ToNextSettingItem() {} // 0x00000001815E0BC0-0x00000001815E0F00
	// [XID] // 0x000000018999F7F0-0x000000018999F810
	private void ToPrevSettingItem() {} // 0x00000001815E5740-0x00000001815E5A60
	// [XID] // 0x00000001899A7370-0x00000001899A7390
	private void HandleSettingItem() {} // 0x00000001815E71A0-0x00000001815E7470
	// [XID] // 0x00000001899AECA0-0x00000001899AECC0
	private void HandleSliderItem(bool nextVal) {} // 0x00000001815DF540-0x00000001815DF850
	// [XID] // 0x00000001899B6000-0x00000001899B6020
	private void RefreshSliderButton(MonoSliderSetting sliderItem) {} // 0x00000001815E2070-0x00000001815E23B0
	// [XID] // 0x00000001899BDD60-0x00000001899BDD80
	private void ShowDropdown() {} // 0x00000001815F12F0-0x00000001815F1470
	// [XID] // 0x00000001899C5480-0x00000001899C54A0
	private void ToNextDropdownOption() {} // 0x00000001815F06E0-0x00000001815F07F0
	// [XID] // 0x00000001899CCB50-0x00000001899CCB70
	private void ToPrevDropdownOption() {} // 0x00000001815E2D80-0x00000001815E2E90
	// [XID] // 0x00000001899D4170-0x00000001899D4190
	private void CancelDropdown() {} // 0x00000001815EF530-0x00000001815EF650
	// [XID] // 0x00000001899DB760-0x00000001899DB780
	private void ConfirmSelectDropdown() {} // 0x00000001815E8940-0x00000001815E8A60
	// [XID] // 0x00000001899E2E80-0x00000001899E2EA0
	private void ShowScroller() {} // 0x00000001815D9D90-0x00000001815D9E40
	// [XID] // 0x00000001899EA570-0x00000001899EA590
	private void ToPrevScrollerItem() {} // 0x00000001815EDDD0-0x00000001815EDE70
	// [XID] // 0x00000001899F1FE0-0x00000001899F2000
	private void ToNextScrollerItem() {} // 0x00000001815DDDB0-0x00000001815DDE50
	// [XID] // 0x00000001899F9720-0x00000001899F9740
	private void CancelScroller() {} // 0x00000001815E81C0-0x00000001815E8270
	// [XID] // 0x0000000189A00A80-0x0000000189A00AA0
	private void ConfirmScroller() {} // 0x00000001815DC4C0-0x00000001815DC570
	// [XID] // 0x0000000189A08360-0x0000000189A08380
	private void OnControllerConnectOrDisconnect() {} // 0x00000001815E74C0-0x00000001815E75B0
	// [XID] // 0x0000000189A0F880-0x0000000189A0F8A0
	private void SetConfirmButtonText() {} // 0x00000001815DF120-0x00000001815DF540
	// [XID] // 0x0000000189A16E60-0x0000000189A16E80
	private void RefreshGraphicsSetting() {} // 0x00000001815EA550-0x00000001815EA650
	// [XID] // 0x0000000189A1E520-0x0000000189A1E540
	private void RefreshGraphicsGroup() {} // 0x00000001815F3520-0x00000001815F36A0
	// [XID] // 0x0000000189A25C00-0x0000000189A25C20
	private void RefreshPS4HDRSetting(MonoSettingGroup graphicsGroup) {} // 0x00000001815DEE50-0x00000001815DF120
	// [XID] // 0x0000000189A2D060-0x0000000189A2D080
	private void RefreshVolatileSetting(MonoSettingGroup graphicsGroup) {} // 0x00000001815E95C0-0x00000001815E9C00
	// [XID] // 0x0000000189A34A60-0x0000000189A34A80
	private void RefreshDisplayMode(MonoSettingGroup settingGroup) {} // 0x00000001815DA1D0-0x00000001815DA750
	// [XID] // 0x0000000189A3BE10-0x0000000189A3BE30
	private void OnUIResolutionChanged(int index) {} // 0x00000001815E6250-0x00000001815E6340
	// [XID] // 0x0000000189A43A60-0x0000000189A43A80
	private void OnGraphicsVolatileChanged(int index) {} // 0x00000001815EC5F0-0x00000001815EC8A0
	// [XID] // 0x0000000189A4AEB0-0x0000000189A4AED0
	private void OnFullScreenChanged(int index) {} // 0x00000001815E2590-0x00000001815E2680
	// [XID] // 0x0000000189A525D0-0x0000000189A525F0
	private void RefreshGraphicsCustomGroup() {} // 0x00000001815DE050-0x00000001815DE530
	// [XID] // 0x0000000189A59F20-0x0000000189A59F40
	private int SortCustomVolatileGradesByNumAscend(string a, string b) => default; // 0x00000001815E7010-0x00000001815E7140
	// [XID] // 0x0000000189A616F0-0x0000000189A61710
	private int SortCustomVolatileGradesByNumDescend(string a, string b) => default; // 0x00000001815F22E0-0x00000001815F2410
	// [XID] // 0x0000000189A69630-0x0000000189A69650
	private int GetSortedEntryGrade(int grade, GraphicsSettingEntryType entryType) => default; // 0x00000001815F04A0-0x00000001815F06E0
	// [XID] // 0x0000000189A70980-0x0000000189A709A0
	private void RefreshCustomVolatieSetting(MonoDropdownSetting setting, ConfigGraphicsSettingEntry entry) {} // 0x00000001815EADE0-0x00000001815EB480
	// [XID] // 0x0000000189A78250-0x0000000189A78270
	private void AddTextMapString(List<string> list, string[] textStr) {} // 0x00000001815EA770-0x00000001815EA8A0
	// [XID] // 0x0000000189A7F860-0x0000000189A7F880
	private void AddGradeString(List<string> list, int count) {} // 0x00000001815DA8F0-0x00000001815DABD0
	// [XID] // 0x0000000189A87560-0x0000000189A87580
	private void OnVolatileSettingEntryChanged(int index, GraphicsSettingEntryType entryType) {} // 0x00000001815DD290-0x00000001815DD630
	// [XID] // 0x0000000189A8ED00-0x0000000189A8ED20
	private void RefreshCustomVolatileEntry() {} // 0x00000001815E0650-0x00000001815E0930
	// [XID] // 0x0000000189A96370-0x0000000189A96390
	private void RefreshUpdatePerfCost() {} // 0x00000001815F1470-0x00000001815F1B50
	// [XID] // 0x0000000189A9D8C0-0x0000000189A9D8E0
	private void RefreshVolumetricFogOptions() {} // 0x00000001815DB990-0x00000001815DBCA0
	// [XID] // 0x0000000189AAC930-0x0000000189AAC950
	private void RefreshLanguageSetting() {} // 0x00000001815E76D0-0x00000001815E7C30
	// [XID] // 0x0000000189AB41F0-0x0000000189AB4210
	private void OnGetVoiceBundleSize(VoiceLanguageType langType) {} // 0x00000001815E4E70-0x00000001815E5520
	// [XID] // 0x0000000189ABBF30-0x0000000189ABBF50
	private void SetupLanguageDropdown() {} // 0x00000001815E3CF0-0x00000001815E4030
	// [XID] // 0x0000000189AC36C0-0x0000000189AC36E0
	private bool SetupLangueVoiceDropDown() => default; // 0x00000001815EEBE0-0x00000001815EF530
	// [XID] // 0x0000000189ACAD50-0x0000000189ACAD70
	private void ResetVoiceDropDownCurValue(string value = null) {} // 0x00000001815F1040-0x00000001815F12F0
	// [XID] // 0x0000000189AD27E0-0x0000000189AD2800
	private void OnLanguageChange(int index) {} // 0x00000001815EF800-0x00000001815EF990
	// [XID] // 0x0000000189ADA230-0x0000000189ADA250
	private void OnLanguageVoiceChange(int index) {} // 0x00000001815E4380-0x00000001815E47B0
	// [XID] // 0x0000000189AE1AF0-0x0000000189AE1B10
	private void OnLanguagePackBtnClick() {} // 0x00000001815E5A60-0x00000001815E5BB0
	// [XID] // 0x0000000189AE92A0-0x0000000189AE92C0
	private void RefreshPressKeySetting() {} // 0x00000001815EC1D0-0x00000001815EC5F0
	// [XID] // 0x0000000189AF10B0-0x0000000189AF10D0
	private void UpdatePressKeySettingPageView() {} // 0x00000001815E7630-0x00000001815E76D0
	// [XID] // 0x0000000189AF8570-0x0000000189AF8590
	private void CheckAndGetKeyCodeToChange() {} // 0x00000001815DBE70-0x00000001815DC1A0
	// [XID] // 0x0000000189AFFC40-0x0000000189AFFC60
	private void TryToModifyMap(KeyCode keyCodeToChange) {} // 0x00000001815DFC10-0x00000001815E0100
	// [XID] // 0x0000000189B071F0-0x0000000189B07210
	private void CommonMenuUpEventPressKeySetting() {} // 0x00000001815E0B10-0x00000001815E0BC0
	// [XID] // 0x0000000189B0E9F0-0x0000000189B0EA10
	private void ChangeKeyCode(KeyCode keyCodeToChange) {} // 0x00000001815EE690-0x00000001815EE810
	// [XID] // 0x0000000189B15D80-0x0000000189B15DA0
	private void ResolveConflict(KeyCode keyCodeToChange) {} // 0x00000001815F0340-0x00000001815F04A0
	// [XID] // 0x0000000189B1D4B0-0x0000000189B1D4D0
	private void ResetModifyingMapState() {} // 0x00000001815E2E90-0x00000001815E3020
	// [XID] // 0x0000000189B24D30-0x0000000189B24D50
	private void RefreshResetToDefaultBtn(ControllerType controllerType) {} // 0x00000001815E3290-0x00000001815E3460
	// [XID] // 0x0000000189B2C1E0-0x0000000189B2C200
	private void ResetMapToDefault(ControllerType controllerType) {} // 0x00000001815E8020-0x00000001815E81C0
	// [XID] // 0x0000000189B33770-0x0000000189B33790
	private void RefreshInputTypeGroupJoyPad() {} // 0x00000001815F3860-0x00000001815F3920
	// [XID] // 0x0000000189B3B090-0x0000000189B3B0B0
	private void RefreshJoypadControlSetting() {} // 0x00000001815DF850-0x00000001815DFB10
	// [XID] // 0x0000000189B42890-0x0000000189B428B0
	private void RefreshInputTypeGroupJoyPadGamePlay() {} // 0x00000001815EAB90-0x00000001815EAD30
	// [XID] // 0x0000000189B4A3B0-0x0000000189B4A3D0
	private void OnChangeJoypadMap(int sourceIndex, int targetIndex) {} // 0x00000001815E23B0-0x00000001815E2590
	// [XID] // 0x0000000189B51B50-0x0000000189B51B70
	private void RefreshInputTypeGroupJoyPadMenu() {} // 0x00000001815E3720-0x00000001815E38F0
	// [XID] // 0x0000000189B59350-0x0000000189B59370
	private void RefreshJoyPadListSettingRow(MonoDropdownSetting dropDownSetting, InputActionType actionType) {} // 0x00000001815E1CB0-0x00000001815E2070
	// [XID] // 0x0000000189B60BE0-0x0000000189B60C00
	private void RefreshJoyPadListSwitchSettingRow(MonoScrollerSetting joypadListSetting, SwitchInputActionType switchInputActionType, int menuSwitchIndex) {} // 0x00000001815EE460-0x00000001815EE5B0
	// [XID] // 0x0000000189B68250-0x0000000189B68270
	private void SetTwoKeyItemDisplay(MonoUIContainer key1Container, MonoUIContainer key2Container, SwitchInputActionType switchInputActionType, bool invert = false /* Metadata: 0x00B0F474 */) {} // 0x00000001815DEB80-0x00000001815DEE50
	// [XID] // 0x0000000189B6F5D0-0x0000000189B6F5F0
	private void SetSwitchSettingRowDesc(MonoScrollerSetting joypadListSetting, SwitchInputActionType switchInputActionType) {} // 0x00000001815DBCA0-0x00000001815DBE70
	// [XID] // 0x0000000189B76C70-0x0000000189B76C90
	private void SetSwitchSettingRowScroller(MonoScrollerSetting joypadListSetting, SwitchInputActionType switchInputActionType, int menuSwitchIndex) {} // 0x00000001815EEA10-0x00000001815EEBE0
	// [XID] // 0x0000000189B7E1E0-0x0000000189B7E200
	private void OnJoypadSwitchButtonClick(MonoScrollerSetting joypadListSetting, SwitchInputActionType switchInputActionType, int menuSwitchIndex) {} // 0x00000001815DC270-0x00000001815DC4C0
	// [XID] // 0x0000000189B85DE0-0x0000000189B85E00
	private void RefreshJoypadSwitchScrollerItem(Transform trans, int index) {} // 0x00000001815E1A80-0x00000001815E1CB0
	// [XID] // 0x0000000189B8CE30-0x0000000189B8CE50
	private void RefreshInputTypeGroupKeyboard() {} // 0x00000001815EB950-0x00000001815EBA00
	// [XID] // 0x0000000189B94620-0x0000000189B94640
	private void RefreshInputTypeGroupKeyboardGameplay() {} // 0x00000001815F36A0-0x00000001815F3860
	// [XID] // 0x0000000189B9BC70-0x0000000189B9BC90
	private void RefreshInputTypeGroupKeyboardMenu() {} // 0x00000001815EFA60-0x00000001815EFC20
	// [IDTag] // 0x0000000189BA33F0-0x0000000189BA3430
	// [XID] // 0x0000000189BA33F0-0x0000000189BA3430
	private void RefreshConflictGroupKeyboard(RewiredWrapper.AssignConflictInfo assignConflictInfo, MonoSettingGroup keyGroup) {} // 0x00000001815D9E40-0x00000001815D9F80
	// [IDTag] // 0x0000000189BAD5A0-0x0000000189BAD5E0
	// [XID] // 0x0000000189BAD5A0-0x0000000189BAD5E0
	private void RefreshConflictGroupKeyboard() {} // 0x00000001815D9F80-0x00000001815DA1D0
	// [IDTag] // 0x0000000189BB7A40-0x0000000189BB7A80
	// [XID] // 0x0000000189BB7A40-0x0000000189BB7A80
	private void RefreshKeyboardPressKeySettingRow(MonoControlSettingRow ins, ModifyMapData modifyMapData, InputActionGroupType inputActionGroupType) {} // 0x00000001815F0EF0-0x00000001815F1040
	// [IDTag] // 0x0000000189BC2B10-0x0000000189BC2B50
	// [XID] // 0x0000000189BC2B10-0x0000000189BC2B50
	private void RefreshKeyboardPressKeySettingRow(MonoControlSettingRow ins, ModifyMapData modifyMapData, ActionKeyCodePair actionKeyCodePair, InputActionGroupType inputActionGroupType) {} // 0x00000001815F0850-0x00000001815F0BB0
	// [IDTag] // 0x0000000189BCD160-0x0000000189BCD1A0
	// [XID] // 0x0000000189BCD160-0x0000000189BCD1A0
	private void RefreshKeyboardPressKeySettingRow(MonoControlSettingRow ins, ModifyMapData modifyMapData, RewiredWrapper.AssignConflictInfo assignConflictInfo, InputActionGroupType inputActionGroupType) {} // 0x00000001815F0BB0-0x00000001815F0EF0
	// [XID] // 0x0000000189BD7590-0x0000000189BD75B0
	private bool TrySteupToAvatarTriggerSkillInPressKeyMenu(MonoControlSettingRow ins, InputActionType actionType) => default; // 0x00000001815DB020-0x00000001815DB180
	// [XID] // 0x0000000189BDF090-0x0000000189BDF0B0
	private void OnKeyboardPressKeySettingClick(MonoControlSettingRow ins, ModifyMapData modifyMapData, bool canChange, InputActionGroupType inputActionGroupType) {} // 0x00000001815E5520-0x00000001815E5680
	// [XID] // 0x00000001895EBD00-0x00000001895EBD20
	private void StartModifyingMap(MonoControlSettingRow ins, ModifyMapData modifyMapData, InputActionGroupType inputActionGroupType) {} // 0x00000001815E15D0-0x00000001815E1830
	// [XID] // 0x00000001895F30A0-0x00000001895F30C0
	private void RefreshSpriteList() {} // 0x00000001815F3E20-0x00000001815F3EC0
	// [IDTag] // 0x00000001895FA8E0-0x00000001895FA920
	// [XID] // 0x00000001895FA8E0-0x00000001895FA920
	private void RefreshActionKeyCodePairList() {} // 0x00000001815E8570-0x00000001815E8640
	// [IDTag] // 0x0000000189605020-0x0000000189605060
	// [XID] // 0x0000000189605020-0x0000000189605060
	private void RefreshActionKeyCodePairList(List<ModifyMapData> pairList, InputActionType[] displayActions) {} // 0x00000001815E8640-0x00000001815E8940
	// [XID] // 0x000000018960FCC0-0x000000018960FCE0
	private void RefreshGameplayChangeableElementIDSpriteJoypad() {} // 0x00000001815E8A60-0x00000001815E8C90
	// [XID] // 0x0000000189616FA0-0x0000000189616FC0
	private void ShowScrollerMenuSwitch() {} // 0x00000001815E0490-0x00000001815E0650
	// [XID] // 0x000000018961EB20-0x000000018961EB40
	private void ToPrevScrollerItemMenuSwitch() {} // 0x00000001815DA750-0x00000001815DA850
	// [XID] // 0x0000000189625F20-0x0000000189625F40
	private void ToNextScrollerItemMenuSwitch() {} // 0x00000001815DFB10-0x00000001815DFC10
	// [XID] // 0x000000018962D8E0-0x000000018962D900
	private void CancelScrollerMenuSwitch() {} // 0x00000001815E1480-0x00000001815E15D0
	// [XID] // 0x0000000189635460-0x0000000189635480
	private void ConfirmScrollerMenuSwitch() {} // 0x00000001815E10D0-0x00000001815E1280
	// [XID] // 0x000000018963CB40-0x000000018963CB60
	private void OnMenuSwitchScrollerItemConfirm(int index) {} // 0x00000001815E0930-0x00000001815E0B10
	// [XID] // 0x0000000189644180-0x00000001896441A0
	private int GetElementIDByAction(InputActionType action) => default; // 0x00000001815E7E60-0x00000001815E8020
	// [XID] // 0x00000001896530C0-0x00000001896530E0
	private void CheckPressKeyRPShow() {} // 0x00000001815E5BB0-0x00000001815E5D10
	// [XID] // 0x000000018965A780-0x000000018965A7A0
	private void RefreshSoundSettings() {} // 0x00000001815EBA00-0x00000001815EBE50
	// [XID] // 0x0000000189661DB0-0x0000000189661DD0
	private void OnSoundSettingsTabClose() {} // 0x00000001815F0140-0x00000001815F0250
	// [XID] // 0x0000000189669990-0x00000001896699B0
	private void ResetSoundSettingSliderVoicePost() {} // 0x00000001815EAD30-0x00000001815EADE0
	// [XID] // 0x00000001896714C0-0x00000001896714E0
	private MonoSliderAudioSetting AddSoundSettingSlider(MonoSettingGroup group, int value, AudioSettingSlider sliderConfig) => default; // 0x00000001815EE0E0-0x00000001815EE390
	// [XID] // 0x0000000189678D80-0x0000000189678DA0
	private void AddPostVoiceSoundSettingSlider(MonoSettingGroup group, uint id, int value, AudioSettingSlider_PostVoice sliderConfig, UnityAction<float, uint> onChangeCallback) {} // 0x00000001815F2680-0x00000001815F28A0
	// [XID] // 0x00000001896804D0-0x00000001896804F0
	private void AddPostEventSoundSettingSlider(MonoSettingGroup group, int value, AudioSettingSlider_PostEvent sliderConfig, UnityAction<float> onChangeCallback) {} // 0x00000001815E90C0-0x00000001815E92C0
}

