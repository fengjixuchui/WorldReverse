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
	public class MonoMPInvitationDialog : MonoUIProxy // TypeDefIndex: 31123
	{
		// Fields
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private Button _actionBtn; // 0x40
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private Image _icon; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _iconBg; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _titleLabel; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private SmoothMask _progress; // 0x60
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private RectTransform _keyGrp; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _keyPrefab; // 0x70
		private MonoControlElement _keyIns; // 0x78
	
		// Properties
		public Button actionButton { /* [XID] */ /* 0x00000001895E5840-0x00000001895E5860 */ get => default; } // 0x0000000182F07330-0x0000000182F073D0 
		public Image icon { /* [XID] */ /* 0x00000001895ED190-0x00000001895ED1B0 */ get => default; } // 0x0000000182F07470-0x0000000182F07510 
		public Image iconBg { /* [XID] */ /* 0x00000001895F4810-0x00000001895F4830 */ get => default; } // 0x0000000182F073D0-0x0000000182F07470 
		public string title { /* [XID] */ /* 0x00000001895FBFA0-0x00000001895FBFC0 */ set {} } // 0x0000000182F076B0-0x0000000182F07780
		public float progress { /* [XID] */ /* 0x00000001896039E0-0x0000000189603A00 */ set {} } // 0x0000000182F07510-0x0000000182F075D0
		public bool showKeyGrp { /* [XID] */ /* 0x000000018960B340-0x000000018960B360 */ set {} } // 0x0000000182F075D0-0x0000000182F076B0
	
		// Constructors
		public MonoMPInvitationDialog() {} // 0x0000000182F072A0-0x0000000182F07330
	
		// Methods
		// [XID] // 0x00000001896126F0-0x0000000189612710
		public MonoControlElement GetKey() => default; // 0x0000000182F07150-0x0000000182F072A0
	}
}
