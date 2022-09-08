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
	public class MonoSettingGroup : MonoReusableListItem // TypeDefIndex: 31038
	{
		// Fields
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private UnityEngine.UI.Text _title; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoReusableList _sliderList; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoReusableList _sliderAudioList; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoReusableList _dropdownList; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoReusableList _keyBindingList; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoReusableList _ToggleList; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoReusableList _ButtonList; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoReusableList _joypadList; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoReusableList _joypadListSwitch; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoReusableList _dummyReuseableList; // 0x68
	
		// Properties
		public string title { /* [XID] */ /* 0x0000000189AF6B30-0x0000000189AF6B50 */ set {} } // 0x000000018411A390-0x000000018411A460
	
		// Constructors
		public MonoSettingGroup() {} // 0x000000018411A300-0x000000018411A390
	
		// Methods
		// [XID] // 0x0000000189AEF610-0x0000000189AEF630
		public void ClearAll() {} // 0x000000018411A170-0x000000018411A300
		// [XID] // 0x0000000189AFE060-0x0000000189AFE080
		public MonoSliderSetting AddSliderSetting() => default; // 0x0000000184119F70-0x000000018411A070
		// [XID] // 0x0000000189B05890-0x0000000189B058B0
		public MonoSliderAudioSetting AddSliderAudioSetting() => default; // 0x0000000184119E70-0x0000000184119F70
		// [XID] // 0x0000000189B0D060-0x0000000189B0D080
		public MonoDropdownSetting AddDropdownSetting() => default; // 0x0000000184119970-0x0000000184119A70
		// [XID] // 0x0000000189B14630-0x0000000189B14650
		public MonoControlSettingRow AddKeyBindingSetting() => default; // 0x0000000184119D70-0x0000000184119E70
		// [XID] // 0x0000000189B1BE50-0x0000000189B1BE70
		public MonoDropdownSetting AddJoyPadListSetting() => default; // 0x0000000184119B70-0x0000000184119C70
		// [XID] // 0x0000000189B235D0-0x0000000189B235F0
		public MonoScrollerSetting AddJoyPadListSwitchSetting() => default; // 0x0000000184119C70-0x0000000184119D70
		// [XID] // 0x0000000189B2A830-0x0000000189B2A850
		public MonoDummySettingItem AddDummySettingItem() => default; // 0x0000000184119A70-0x0000000184119B70
		// [XID] // 0x0000000189B31DA0-0x0000000189B31DC0
		public MonoToggleSetting AddToggleSetting() => default; // 0x000000018411A070-0x000000018411A170
		// [XID] // 0x0000000189B395A0-0x0000000189B395C0
		public MonoButtonSetting AddButtonSetting() => default; // 0x0000000184119870-0x0000000184119970
	}
}
