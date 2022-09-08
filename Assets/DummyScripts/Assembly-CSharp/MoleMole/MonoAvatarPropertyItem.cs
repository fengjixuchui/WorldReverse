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
	public class MonoAvatarPropertyItem : MonoBehaviour // TypeDefIndex: 30443
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _background; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _icon; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _name; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _extraInfo; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _propertyObj; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _extraObj; // 0x40
		[SerializeField] // 0x00000001899A8AF0-0x00000001899A8B30
		// [Tooltip] // 0x00000001899A8AF0-0x00000001899A8B30
		private UnityEngine.UI.Text _prevValue; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _value; // 0x50
		[SerializeField] // 0x00000001899BC0C0-0x00000001899BC110
		// [Tooltip] // 0x00000001899BC0C0-0x00000001899BC110
		private Image _upHint; // 0x58
		[SerializeField] // 0x00000001899BC0C0-0x00000001899BC110
		// [Tooltip] // 0x00000001899BC0C0-0x00000001899BC110
		private Image _downHint; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _changImg; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _newImg; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _addValue; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtDetail; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Color _bgColor1; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Color _bgColor2; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Color _defaultTextColor; // 0xA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Color _upTextColor; // 0xB8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _detailIcon; // 0xC8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _actionBtn; // 0xD0
		private FightPropType _propType; // 0xD8
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private MonoSkillStateRow _unlockRow; // 0xE0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _changeRow; // 0xE8
	
		// Properties
		public UnityEngine.UI.Text valueText { /* [XID] */ /* 0x0000000189A2CE60-0x0000000189A2CE80 */ get => default; } // 0x0000000184226A70-0x0000000184226B10 
		public UnityEngine.UI.Text prevValueText { /* [XID] */ /* 0x0000000189A34810-0x0000000189A34830 */ get => default; } // 0x0000000184226920-0x00000001842269C0 
		public UnityEngine.UI.Text nameText { /* [XID] */ /* 0x0000000189A3BC30-0x0000000189A3BC50 */ get => default; } // 0x0000000184226880-0x0000000184226920 
		public UnityEngine.UI.Text DetailText { /* [XID] */ /* 0x0000000189A438C0-0x0000000189A438E0 */ get => default; } // 0x0000000184226470-0x0000000184226520 
		public Image changeImg { /* [XID] */ /* 0x0000000189A4ACF0-0x0000000189A4AD10 */ get => default; } // 0x0000000184226680-0x0000000184226720 
		public Image detailIcon { /* [XID] */ /* 0x0000000189A52410-0x0000000189A52430 */ get => default; } // 0x00000001842267D0-0x0000000184226880 
		public Button actionBtn { /* [XID] */ /* 0x0000000189A59D40-0x0000000189A59D60 */ get => default; } // 0x0000000184226520-0x00000001842265E0 
		public Image background { /* [XID] */ /* 0x0000000189A61510-0x0000000189A61530 */ get => default; } // 0x00000001842265E0-0x0000000184226680 
		public FightPropType propType { /* [XID] */ /* 0x0000000189A693F0-0x0000000189A69410 */ set {} } // 0x0000000184226CB0-0x0000000184226E00
		public bool showAddedValue { /* [XID] */ /* 0x0000000189A707A0-0x0000000189A707C0 */ set {} } // 0x0000000184226E00-0x0000000184226EE0
		public bool showDetailText { /* [XID] */ /* 0x0000000189A78070-0x0000000189A78090 */ set {} } // 0x0000000184226EE0-0x0000000184226FF0
		public Sprite icon { /* [XID] */ /* 0x0000000189AEC270-0x0000000189AEC290 */ set {} } // 0x0000000184226B10-0x0000000184226CB0
		public MonoSkillStateRow unlockRow { /* [XID] */ /* 0x0000000189AFB3A0-0x0000000189AFB3C0 */ get => default; } // 0x00000001842269C0-0x0000000184226A70 
		public Transform changeRow { /* [XID] */ /* 0x0000000189B02A40-0x0000000189B02A60 */ get => default; } // 0x0000000184226720-0x00000001842267D0 
	
		// Constructors
		public MonoAvatarPropertyItem() {} // 0x00000001842262E0-0x0000000184226470
	
		// Methods
		// [XID] // 0x0000000189A7F660-0x0000000189A7F680
		public void SetLabel(FightPropType propType, bool appendProp = false /* Metadata: 0x00B10FC5 */) {} // 0x0000000184224190-0x0000000184224370
		// [XID] // 0x0000000189A87360-0x0000000189A87380
		public void SetDefaultColor(Color color) {} // 0x0000000184223F00-0x0000000184223FC0
		// [IDTag] // 0x0000000189A8EBA0-0x0000000189A8EBE0
		// [XID] // 0x0000000189A8EBA0-0x0000000189A8EBE0
		public void Setup(float value, bool withPlus = false /* Metadata: 0x00B10FC6 */) {} // 0x0000000184225FB0-0x00000001842262E0
		// [IDTag] // 0x0000000189A99660-0x0000000189A996A0
		// [XID] // 0x0000000189A99660-0x0000000189A996A0
		public void SetValue(float value, bool appendProp = false /* Metadata: 0x00B10FC7 */) {} // 0x0000000184225430-0x0000000184225800
		// [IDTag] // 0x0000000189AA3790-0x0000000189AA37D0
		// [XID] // 0x0000000189AA3790-0x0000000189AA37D0
		public void SetValue(float from, float to, bool reverse = false /* Metadata: 0x00B10FC8 */, bool appendProp = false /* Metadata: 0x00B10FC9 */) {} // 0x0000000184224A50-0x0000000184225070
		// [XID] // 0x0000000189AADE60-0x0000000189AADE80
		public void Reset() {} // 0x0000000184223CD0-0x0000000184223DD0
		// [IDTag] // 0x0000000189AB57F0-0x0000000189AB5830
		// [XID] // 0x0000000189AB57F0-0x0000000189AB5830
		public void Setup(PropertyChange propertyChange) {} // 0x0000000184225DF0-0x0000000184225FB0
		// [IDTag] // 0x0000000189AC0220-0x0000000189AC0260
		// [XID] // 0x0000000189AC0220-0x0000000189AC0260
		public void Setup(string name, float from, float to, PropFormat fomart, bool reverse = false /* Metadata: 0x00B10FCA */) {} // 0x0000000184225800-0x0000000184225DF0
		// [IDTag] // 0x0000000189ACAB90-0x0000000189ACABD0
		// [XID] // 0x0000000189ACAB90-0x0000000189ACABD0
		public void SetValue(string name, float value, PropFormat fomart) {} // 0x0000000184225070-0x0000000184225430
		// [XID] // 0x0000000189AD5A80-0x0000000189AD5AA0
		public void SetBgColor(int index) {} // 0x0000000184223DD0-0x0000000184223F00
		// [XID] // 0x0000000189ADD410-0x0000000189ADD430
		public void SetValueByPropShowRelic(float finalValue) {} // 0x0000000184224370-0x0000000184224550
		// [XID] // 0x0000000189AE4BF0-0x0000000189AE4C10
		public void SetValueByPropShowType(PropShowType showType, float finalValue, float baseValue = 0f /* Metadata: 0x00B10FCB */) {} // 0x0000000184224550-0x0000000184224A50
		// [XID] // 0x0000000189AF3C90-0x0000000189AF3CB0
		public void SetHighLight(bool highLight = true /* Metadata: 0x00B10FCF */) {} // 0x0000000184223FC0-0x0000000184224190
	}
}
