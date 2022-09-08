/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoSettingPage : MonoUIProxy // TypeDefIndex: 31015
	{
		// Fields
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private MonoElementSwitch _elementSwitch; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _settingTabTitle; // 0x48
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private MonoTabGroup _settingCategoryTabs; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoPrefabPlugin _categoryTabsPlugin; // 0x58
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private MonoReusableList _controlSetting; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoReusableList _pressKeySetting; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoReusableList _graphicSetting; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoReusableList _soundSettings; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoReusableList _messageSetting; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoReusableList _languageSetting; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoReusableList _accountSetting; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoReusableList _otherSetting; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _sliderLeftButton; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _sliderRightButton; // 0xA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSettingGraphicsTab _graphicMonoTab; // 0xB0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _modifyingTipRoot; // 0xB8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _modifyingTip; // 0xC0
		private const string JOYPAD_CONTROL_SCHEME_ROOT_PS4 = "ART/UI/Menus/Widget/SettingPage/SettingJoystick_PS4"; // Metadata: 0x00B11D88
		private const string JOYPAD_CONTROL_SCHEME_ROOT_XBOX = "ART/UI/Menus/Widget/SettingPage/SettingJoystick_Xbox"; // Metadata: 0x00B11DBF
		private const string JOYPAD_CONTROL_SCHEME_ROOT_PS5 = "ART/UI/Menus/Widget/SettingPage/SettingJoystick_PS5"; // Metadata: 0x00B11DF7
		private GameObject xboxPrefab; // 0xC8
		private GameObject ps4Prefab; // 0xD0
		private GameObject ps5Prefab; // 0xD8
		private GameObject _joypadControlScheme; // 0xE0
		private InputJoypadType _joypadType; // 0xE8
	
		// Properties
		public MonoSettingGraphicsTab graphicMonoTab { /* [XID] */ /* 0x0000000189AC1B40-0x0000000189AC1B60 */ get => default; } // 0x000000018411D610-0x000000018411D6C0 
		public RectTransform modifyingTipRoot { /* [XID] */ /* 0x0000000189AC90D0-0x0000000189AC90F0 */ get => default; } // 0x000000018411D820-0x000000018411D8D0 
		public UnityEngine.UI.Text modifyingTip { /* [XID] */ /* 0x0000000189AD0B20-0x0000000189AD0B40 */ get => default; } // 0x000000018411D8D0-0x000000018411D980 
		public Button closeButton { /* [XID] */ /* 0x0000000189AD8740-0x0000000189AD8760 */ get => default; } // 0x000000018411CFA0-0x000000018411D180 
		public MonoUIContainer closeButtonMono { /* [XID] */ /* 0x0000000189AE03A0-0x0000000189AE03C0 */ get => default; } // 0x000000018411CDE0-0x000000018411CFA0 
		public MonoTabGroup controlSettingTabs { /* [XID] */ /* 0x0000000189AE7950-0x0000000189AE7970 */ get => default; } // 0x000000018411D340-0x000000018411D450 
		public MonoUIContainer gotoButton { /* [XID] */ /* 0x0000000189AEF650-0x0000000189AEF670 */ get => default; } // 0x000000018411D450-0x000000018411D610 
		public MonoTabGroup settingCategoryTabs { /* [XID] */ /* 0x0000000189AF6B70-0x0000000189AF6B90 */ get => default; } // 0x000000018411DA30-0x000000018411DAD0 
		public MonoPrefabPlugin categoryTabsPlugin { /* [XID] */ /* 0x0000000189AFE0A0-0x0000000189AFE0C0 */ get => default; } // 0x000000018411CD40-0x000000018411CDE0 
		public MonoUIContainer btnDefault { /* [XID] */ /* 0x0000000189B14670-0x0000000189B14690 */ get => default; } // 0x000000018411CA20-0x000000018411CBB0 
		public MonoUIContainer btnLanguagePack { /* [XID] */ /* 0x0000000189B1BE90-0x0000000189B1BEB0 */ get => default; } // 0x000000018411CBB0-0x000000018411CD40 
		public string settingTabTitle { /* [XID] */ /* 0x0000000189B23610-0x0000000189B23630 */ set {} } // 0x000000018411DCD0-0x000000018411DDA0
		public MonoReusableList soundSetting { /* [XID] */ /* 0x0000000189B48820-0x0000000189B48840 */ get => default; } // 0x000000018411DC30-0x000000018411DCD0 
		public MonoReusableList accountSetting { /* [XID] */ /* 0x0000000189B5F0F0-0x0000000189B5F110 */ get => default; } // 0x000000018411C970-0x000000018411CA20 
		public MonoReusableList otherSetting { /* [XID] */ /* 0x0000000189B75330-0x0000000189B75350 */ get => default; } // 0x000000018411D980-0x000000018411DA30 
		public MonoReusableList languageSetting { /* [XID] */ /* 0x0000000189B8B3F0-0x0000000189B8B410 */ get => default; } // 0x000000018411D6C0-0x000000018411D770 
		public MonoReusableList messageSetting { /* [XID] */ /* 0x0000000189BA1820-0x0000000189BA1840 */ get => default; } // 0x000000018411D770-0x000000018411D820 
		public bool showChangeButton { /* [XID] */ /* 0x0000000189BB77E0-0x0000000189BB7800 */ set {} } // 0x000000018411DDA0-0x000000018411DE70
		public MonoUIContainer confirmButton { /* [XID] */ /* 0x0000000189BBEE60-0x0000000189BBEE80 */ get => default; } // 0x000000018411D180-0x000000018411D340 
		public MonoUIContainer sliderLeftButton { /* [XID] */ /* 0x0000000189BDD6C0-0x0000000189BDD6E0 */ get => default; } // 0x000000018411DAD0-0x000000018411DB80 
		public MonoUIContainer sliderRightButton { /* [XID] */ /* 0x00000001895EA290-0x00000001895EA2B0 */ get => default; } // 0x000000018411DB80-0x000000018411DC30 
	
		// Constructors
		public MonoSettingPage() {} // 0x000000018411C8A0-0x000000018411C970
	
		// Methods
		// [XID] // 0x0000000189B058D0-0x0000000189B058F0
		public MonoSettingGroup AddControlSettingGroup() => default; // 0x000000018411ADD0-0x000000018411AED0
		// [XID] // 0x0000000189B0D0A0-0x0000000189B0D0C0
		public MonoSettingGroup AddPressKeySettingGroup() => default; // 0x000000018411B2D0-0x000000018411B3D0
		// [XID] // 0x0000000189B2A850-0x0000000189B2A870
		public void ClearControlSettingGroups() {} // 0x000000018411B640-0x000000018411B7F0
		// [XID] // 0x0000000189B31DC0-0x0000000189B31DE0
		public void ClearPressKeySettingGroups() {} // 0x000000018411BDB0-0x000000018411BF70
		// [XID] // 0x0000000189B395C0-0x0000000189B395E0
		public MonoSettingGroup AddGraphicSettingGroup() => default; // 0x000000018411AED0-0x000000018411AFD0
		// [XID] // 0x0000000189B40ED0-0x0000000189B40EF0
		public void ClearGraphicSettingGroups() {} // 0x000000018411B7F0-0x000000018411B960
		// [XID] // 0x0000000189B4FFB0-0x0000000189B4FFD0
		public MonoSettingGroup AddSoundSettingGroup() => default; // 0x000000018411B3D0-0x000000018411B4D0
		// [XID] // 0x0000000189B57780-0x0000000189B577A0
		public void ClearSoundSettingsGroups() {} // 0x000000018411BF70-0x000000018411C0E0
		// [XID] // 0x0000000189B666E0-0x0000000189B66700
		public MonoSettingGroup AddAccountSettingGroup() => default; // 0x000000018411ACD0-0x000000018411ADD0
		// [XID] // 0x0000000189B6DC80-0x0000000189B6DCA0
		public void ClearAccountSettingsGroups() {} // 0x000000018411B4D0-0x000000018411B640
		// [XID] // 0x0000000189B7C740-0x0000000189B7C760
		public MonoSettingGroup AddOtherSettingGroup() => default; // 0x000000018411B1D0-0x000000018411B2D0
		// [XID] // 0x0000000189B84540-0x0000000189B84560
		public void ClearOtherSettingGroups() {} // 0x000000018411BC40-0x000000018411BDB0
		// [XID] // 0x0000000189B92B80-0x0000000189B92BA0
		public MonoSettingGroup AddLanguageSettingGroup() => default; // 0x000000018411AFD0-0x000000018411B0D0
		// [XID] // 0x0000000189B9A0E0-0x0000000189B9A100
		public void ClearLanguageSettingGroups() {} // 0x000000018411B960-0x000000018411BAD0
		// [XID] // 0x0000000189BA8C70-0x0000000189BA8C90
		public MonoSettingGroup AddMessageSettingGroup() => default; // 0x000000018411B0D0-0x000000018411B1D0
		// [XID] // 0x0000000189BB03A0-0x0000000189BB03C0
		public void ClearMessageSettingGroups() {} // 0x000000018411BAD0-0x000000018411BC40
		// [XID] // 0x0000000189BC6B10-0x0000000189BC6B30
		public GameObject GetJoypadScheme(Transform parent) => default; // 0x000000018411C280-0x000000018411C650
		// [XID] // 0x0000000189BCE800-0x0000000189BCE820
		public void DestroyJoypadScheme() {} // 0x000000018411C0E0-0x000000018411C220
		// [XID] // 0x0000000189BD5A80-0x0000000189BD5AA0
		protected override void OnDestroy() {} // 0x000000018411C650-0x000000018411C8A0
	}
}
