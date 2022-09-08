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
	public class MonoCoopSelectItem : MonoBehaviour // TypeDefIndex: 31073
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _contentText; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _subContentText; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _icon; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _clickTipRoot; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _actionBtn; // 0x38
		private int _index; // 0x40
		public Action<int> onClickCallback; // 0x48
	
		// Properties
		public UnityEngine.UI.Text contentText { /* [XID] */ /* 0x0000000189A61420-0x0000000189A61440 */ get => default; } // 0x0000000183F37420-0x0000000183F374C0 
		public UnityEngine.UI.Text subContentText { /* [XID] */ /* 0x0000000189A69310-0x0000000189A69330 */ get => default; } // 0x0000000183F37560-0x0000000183F37600 
		public Image icon { /* [XID] */ /* 0x0000000189A706C0-0x0000000189A706E0 */ get => default; } // 0x0000000183F374C0-0x0000000183F37560 
		public GameObject clickTipRoot { /* [XID] */ /* 0x0000000189A77F90-0x0000000189A77FB0 */ get => default; } // 0x0000000183F37380-0x0000000183F37420 
		public Button actionBtn { /* [XID] */ /* 0x0000000189A7F560-0x0000000189A7F580 */ get => default; } // 0x0000000183F372E0-0x0000000183F37380 
	
		// Constructors
		public MonoCoopSelectItem() {} // 0x0000000183F37260-0x0000000183F372E0
	
		// Methods
		// [XID] // 0x0000000189A872A0-0x0000000189A872C0
		public void SetIndex(int index) {} // 0x0000000183F371B0-0x0000000183F37260
		// [XID] // 0x0000000189A8EAC0-0x0000000189A8EAE0
		private void OnCoopSelectItemClick() {} // 0x0000000183F370E0-0x0000000183F371B0
		// [XID] // 0x0000000189A960F0-0x0000000189A96110
		private void Awake() {} // 0x0000000183F36FB0-0x0000000183F370E0
	}
}
