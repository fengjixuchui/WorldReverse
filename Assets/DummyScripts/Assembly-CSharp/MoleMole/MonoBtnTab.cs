/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoBtnTab : MonoBehaviour, IPointerClickHandler // TypeDefIndex: 30721
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _btn; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Animator _animator; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _tabText; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _tabIcon; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _redPoint; // 0x40
		private bool _selected; // 0x48
		private bool _hightlighted; // 0x49
		private int _index; // 0x4C
		private Action<int> _clickHandler; // 0x50
	
		// Properties
		public UnityEngine.UI.Text tabText { /* [XID] */ /* 0x00000001895F1750-0x00000001895F1770 */ get => default; } // 0x00000001847FEFA0-0x00000001847FF040 
		public Image tabIcon { /* [XID] */ /* 0x00000001895F91D0-0x00000001895F91F0 */ get => default; } // 0x00000001847FEF00-0x00000001847FEFA0 
		public bool showRedPoint { /* [XID] */ /* 0x0000000189600800-0x0000000189600820 */ set {} } // 0x00000001847FF830-0x00000001847FF920
		public bool selected { /* [XID] */ /* 0x0000000189608120-0x0000000189608140 */ get => default; /* [XID] */ /* 0x000000018960FAA0-0x000000018960FAC0 */ set {} } // 0x00000001847FEE60-0x00000001847FEF00 0x00000001847FF760-0x00000001847FF830
		public bool highlight { /* [XID] */ /* 0x0000000189616D10-0x0000000189616D30 */ get => default; /* [XID] */ /* 0x000000018961E8C0-0x000000018961E8E0 */ set {} } // 0x00000001847FEDC0-0x00000001847FEE60 0x00000001847FF040-0x00000001847FF220
		public bool selected_Arrow { /* [XID] */ /* 0x0000000189625CE0-0x0000000189625D00 */ set {} } // 0x00000001847FF570-0x00000001847FF760
		public bool onlyHightlightState { /* [XID] */ /* 0x000000018962D600-0x000000018962D620 */ set {} } // 0x00000001847FF470-0x00000001847FF570
		public int index { /* [XID] */ /* 0x00000001896351C0-0x00000001896351E0 */ set {} } // 0x00000001847FF220-0x00000001847FF2D0
		public Action<int> onClick { /* [XID] */ /* 0x0000000189643F60-0x0000000189643F80 */ set {} } // 0x00000001847FF2D0-0x00000001847FF470
	
		// Constructors
		public MonoBtnTab() {} // 0x00000001847FED30-0x00000001847FEDC0
	
		// Methods
		// [XID] // 0x000000018963C840-0x000000018963C860
		public Button GetButton() => default; // 0x00000001847FEBD0-0x00000001847FEC70
		// [XID] // 0x000000018964B6C0-0x000000018964B6E0
		public void OnPointerClick(PointerEventData data) {} // 0x00000001847FEC70-0x00000001847FED30
	}
}
