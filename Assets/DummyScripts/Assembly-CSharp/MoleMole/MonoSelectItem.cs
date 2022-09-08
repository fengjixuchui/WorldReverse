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
	public class MonoSelectItem : MonoReusableListItem // TypeDefIndex: 31079
	{
		// Fields
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private UnityEngine.UI.Text _txtContent; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _button; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _icon; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _keyTrans; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Animation _animation; // 0x40
		private int _index; // 0x48
	
		// Properties
		public string content { /* [XID] */ /* 0x00000001896080C0-0x00000001896080E0 */ set {} } // 0x0000000184117880-0x0000000184117950
		public bool interactable { /* [XID] */ /* 0x0000000189616C90-0x0000000189616CB0 */ get => default; /* [XID] */ /* 0x000000018960FA20-0x000000018960FA40 */ set {} } // 0x00000001841177D0-0x0000000184117880 0x0000000184117A10-0x0000000184117AE0
		public Sprite icon { /* [XID] */ /* 0x000000018961E840-0x000000018961E860 */ set {} } // 0x0000000184117950-0x0000000184117A10
	
		// Constructors
		public MonoSelectItem() {} // 0x0000000184117750-0x00000001841177D0
	
		// Methods
		// [XID] // 0x00000001895F1710-0x00000001895F1730
		private void Awake() {} // 0x0000000184116EC0-0x0000000184116FC0
		// [XID] // 0x00000001895F9170-0x00000001895F9190
		public void TriggerButton() {} // 0x00000001841174C0-0x0000000184117580
		// [XID] // 0x0000000189600780-0x00000001896007A0
		public void UpdateIndex(int index) {} // 0x00000001841176A0-0x0000000184117750
		// [XID] // 0x0000000189625C40-0x0000000189625C60
		public void TriggerAnimation(string anim) {} // 0x00000001841173B0-0x00000001841174C0
		// [XID] // 0x000000018962D560-0x000000018962D580
		public void TriggerHighlight(bool trigger) {} // 0x0000000184117580-0x00000001841176A0
		// [XID] // 0x0000000189635120-0x0000000189635140
		public void OnSelectItem() {} // 0x0000000184116FC0-0x0000000184117130
		// [XID] // 0x000000018963C760-0x000000018963C780
		public void SetHightLight(bool highLight = true /* Metadata: 0x00B11E89 */) {} // 0x00000001841171F0-0x00000001841172E0
		// [XID] // 0x0000000189643E90-0x0000000189643EB0
		public void SetKeyButtonPos(Transform keyInfo) {} // 0x00000001841172E0-0x00000001841173B0
		// [XID] // 0x000000018964B5D0-0x000000018964B5F0
		public void SelectButton() {} // 0x0000000184117130-0x00000001841171F0
	}
}
