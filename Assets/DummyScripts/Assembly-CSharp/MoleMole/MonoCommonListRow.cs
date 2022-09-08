/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoCommonListRow : MonoBehaviour // TypeDefIndex: 30732
	{
		// Fields
		[NonSerialized]
		public uint flag; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _icon1; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _icon2; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _icon3; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _trans1; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _trans2; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _titleText; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _descText; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _actionButton; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Toggle _toggle; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _simpleReusableList; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private CanvasGroup _canvasGroup; // 0x70
		private UnityAction<bool> onToggleValueChanged; // 0x78
	
		// Properties
		public Image icon1 { /* [XID] */ /* 0x0000000189A21240-0x0000000189A21260 */ get => default; } // 0x0000000184BB1AA0-0x0000000184BB1B40 
		public Image icon2 { /* [XID] */ /* 0x0000000189A28870-0x0000000189A28890 */ get => default; } // 0x0000000184BB1B40-0x0000000184BB1BE0 
		public Image icon3 { /* [XID] */ /* 0x0000000189A2FE70-0x0000000189A2FE90 */ get => default; } // 0x0000000184BB1BE0-0x0000000184BB1C80 
		public RectTransform trans1 { /* [XID] */ /* 0x0000000189A37840-0x0000000189A37860 */ get => default; } // 0x0000000184BB1E60-0x0000000184BB1F00 
		public RectTransform trans2 { /* [XID] */ /* 0x0000000189A3EF90-0x0000000189A3EFB0 */ get => default; } // 0x0000000184BB1F00-0x0000000184BB1FA0 
		public UnityEngine.UI.Text titleText { /* [XID] */ /* 0x0000000189A46610-0x0000000189A46630 */ get => default; } // 0x0000000184BB1D20-0x0000000184BB1DC0 
		public UnityEngine.UI.Text descText { /* [XID] */ /* 0x0000000189A4DE00-0x0000000189A4DE20 */ get => default; } // 0x0000000184BB1A00-0x0000000184BB1AA0 
		public Button actionButton { /* [XID] */ /* 0x0000000189A55610-0x0000000189A55630 */ get => default; } // 0x0000000184BB1960-0x0000000184BB1A00 
		public Toggle toggle { /* [XID] */ /* 0x0000000189A5CF10-0x0000000189A5CF30 */ get => default; } // 0x0000000184BB1DC0-0x0000000184BB1E60 
		public MonoSimpleReusableList simpleReusableList { /* [XID] */ /* 0x0000000189A647B0-0x0000000189A647D0 */ get => default; } // 0x0000000184BB1C80-0x0000000184BB1D20 
		public float alpha { /* [XID] */ /* 0x0000000189A6C010-0x0000000189A6C030 */ set {} } // 0x0000000184BB1FA0-0x0000000184BB2060
	
		// Constructors
		public MonoCommonListRow() {} // 0x0000000184BB18D0-0x0000000184BB1960
	
		// Methods
		// [XID] // 0x0000000189A73700-0x0000000189A73720
		private void OnToggleValueChanged(bool isOn) {} // 0x0000000184BB1810-0x0000000184BB18D0
		// [XID] // 0x0000000189A7B260-0x0000000189A7B280
		public void AddToggleValueChanged(UnityAction<bool> callback) {} // 0x0000000184BB1630-0x0000000184BB1810
	}
}
