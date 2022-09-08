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
	public class MonoHomeworldVisitorListRow : MonoBehaviour, EditMenuTarget // TypeDefIndex: 30802
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _icon; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _nameLabel; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _levelLabel; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _actionBtn; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _ps4ID; // 0x40
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private GameObject _avatarIconSelector; // 0x48
	
		// Properties
		public Image icon { /* [XID] */ /* 0x0000000189BCA040-0x0000000189BCA060 */ get => default; } // 0x00000001846FB760-0x00000001846FB800 
		public UnityEngine.UI.Text nameLabel { /* [XID] */ /* 0x0000000189BD1730-0x0000000189BD1750 */ get => default; } // 0x00000001846FB960-0x00000001846FBA00 
		public UnityEngine.UI.Text levelLabel { /* [XID] */ /* 0x0000000189BD8D20-0x0000000189BD8D40 */ get => default; } // 0x00000001846FB8C0-0x00000001846FB960 
		public MonoUIContainer kickBtn { /* [XID] */ /* 0x00000001895E5900-0x00000001895E5920 */ get => default; } // 0x00000001846FB800-0x00000001846FB8C0 
		public Button actionBtn { /* [XID] */ /* 0x00000001895ED250-0x00000001895ED270 */ get => default; } // 0x00000001846FB6C0-0x00000001846FB760 
		public MonoUIContainer ps4ID { /* [XID] */ /* 0x00000001895F48B0-0x00000001895F48D0 */ get => default; } // 0x00000001846FBA00-0x00000001846FBAA0 
	
		// Constructors
		public MonoHomeworldVisitorListRow() {} // 0x00000001846FB640-0x00000001846FB6C0
	
		// Methods
		// [XID] // 0x00000001895FC060-0x00000001895FC080
		RectTransform MoleMole.EditMenuTarget.GetTransform() => default; // 0x00000001846FB440-0x00000001846FB550
		// [XID] // 0x0000000189603A60-0x0000000189603A80
		void MoleMole.EditMenuTarget.Selected(bool selected) {} // 0x00000001846FB550-0x00000001846FB640
	}
}
