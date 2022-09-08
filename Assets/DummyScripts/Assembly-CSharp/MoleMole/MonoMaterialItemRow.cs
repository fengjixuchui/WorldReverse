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
	public class MonoMaterialItemRow : MonoBehaviour // TypeDefIndex: 31059
	{
		// Fields
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private MonoUIContainer _hintButton; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _actionButton; // 0x20
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private Image _icon; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _countLabel; // 0x30
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private GameObject _tipsPrefab; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _tipsMountPoint; // 0x40
		private FourTextTips _tipsIns; // 0x48
		private int _freeClickedFrame; // 0x50
	
		// Properties
		public Image icon { /* [XID] */ /* 0x0000000189A59C80-0x0000000189A59CA0 */ get => default; } // 0x00000001849389E0-0x0000000184938A80 
		public Button hintButton { /* [XID] */ /* 0x0000000189A61440-0x0000000189A61460 */ get => default; } // 0x0000000184938930-0x00000001849389E0 
		public Button actionButton { /* [XID] */ /* 0x0000000189A69330-0x0000000189A69350 */ get => default; } // 0x00000001849387D0-0x0000000184938880 
		public bool showTipsGrp { /* [XID] */ /* 0x0000000189A7F580-0x0000000189A7F5A0 */ get => default; /* [XID] */ /* 0x0000000189A872C0-0x0000000189A872E0 */ set {} } // 0x0000000184938A80-0x0000000184938B50 0x0000000184938B50-0x0000000184938C30
		public bool freeClickedThisFrame { /* [XID] */ /* 0x0000000189A8EAE0-0x0000000189A8EB00 */ get => default; } // 0x0000000184938880-0x0000000184938930 
	
		// Constructors
		public MonoMaterialItemRow() {} // 0x0000000184938740-0x00000001849387D0
	
		// Methods
		// [XID] // 0x0000000189A706E0-0x0000000189A70700
		public void SetCount(uint current, uint? limit = default) {} // 0x00000001849385B0-0x0000000184938740
		// [XID] // 0x0000000189A77FB0-0x0000000189A77FD0
		public FourTextTips GetOrCreateTips() => default; // 0x00000001849383E0-0x0000000184938500
		// [XID] // 0x0000000189A96110-0x0000000189A96130
		public void OnFreeClick() {} // 0x0000000184938500-0x00000001849385B0
	}
}
