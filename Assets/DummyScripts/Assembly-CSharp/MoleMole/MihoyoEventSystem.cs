/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.EventSystems;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MihoyoEventSystem : EventSystem // TypeDefIndex: 29975
	{
		// Fields
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private GameObject _currSelectGO; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool _enableGroupSelect; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private List<MihoyoSelectableGroup> _selectableGroups; // 0x60
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private bool _enableVirtualCursor; // 0x68
		private PointerEventData _simulatePointer; // 0x70
		private bool _groupSelectActive; // 0x78
	
		// Properties
		public PointerEventData simulatePointerEventData { /* [XID] */ /* 0x00000001899ABCC0-0x00000001899ABCE0 */ get => default; } // 0x00000001811444D0-0x0000000181144570 
		public bool enableVirtualCursor { /* [XID] */ /* 0x0000000189A22D90-0x0000000189A22DB0 */ get => default; /* [XID] */ /* 0x0000000189A2A0A0-0x0000000189A2A0C0 */ set {} } // 0x0000000181144360-0x0000000181144400 0x0000000181144620-0x00000001811446E0
		public GameObject currSelectGameObject { /* [XID] */ /* 0x0000000189A31540-0x0000000189A31560 */ get => default; } // 0x0000000181144220-0x00000001811442C0 
		public bool enableGroupSelect { /* [XID] */ /* 0x0000000189A38FF0-0x0000000189A39010 */ get => default; /* [XID] */ /* 0x0000000189A407D0-0x0000000189A407F0 */ set {} } // 0x00000001811442C0-0x0000000181144360 0x0000000181144570-0x0000000181144620
		public bool shouldSendNavigationEvents { /* [XID] */ /* 0x0000000189A5E860-0x0000000189A5E880 */ get => default; } // 0x0000000181144400-0x00000001811444D0 
	
		// Constructors
		public MihoyoEventSystem() {} // 0x0000000181144180-0x0000000181144220
	
		// Methods
		// [XID] // 0x0000000189994F50-0x0000000189994F70
		protected override void Awake() {} // 0x0000000181142C90-0x0000000181142D70
		// [XID] // 0x000000018999C830-0x000000018999C850
		protected override void Update() {} // 0x00000001811440E0-0x0000000181144180
		// [XID] // 0x00000001899A42C0-0x00000001899A42E0
		public void Tick() {} // 0x0000000181143EF0-0x00000001811440E0
		// [IDTag] // 0x00000001899B35D0-0x00000001899B3610
		// [XID] // 0x00000001899B35D0-0x00000001899B3610
		public bool SimulatePointerClick(GameObject gameObject) => default; // 0x0000000181143310-0x0000000181143420
		// [IDTag] // 0x00000001899BDC80-0x00000001899BDCC0
		// [XID] // 0x00000001899BDC80-0x00000001899BDCC0
		public bool SimulatePointerClick(Component component) => default; // 0x0000000181143420-0x0000000181143570
		// [IDTag] // 0x00000001899C8100-0x00000001899C8140
		// [XID] // 0x00000001899C8100-0x00000001899C8140
		public bool SimulatePointerDown(GameObject gameObject) => default; // 0x00000001811436C0-0x00000001811437D0
		// [IDTag] // 0x00000001899D27C0-0x00000001899D2800
		// [XID] // 0x00000001899D27C0-0x00000001899D2800
		public bool SimulatePointerDown(Component component) => default; // 0x0000000181143570-0x00000001811436C0
		// [IDTag] // 0x00000001899DCB90-0x00000001899DCBD0
		// [XID] // 0x00000001899DCB90-0x00000001899DCBD0
		public bool SimulatePointerUp(GameObject gameObject) => default; // 0x0000000181143DE0-0x0000000181143EF0
		// [IDTag] // 0x00000001899E77A0-0x00000001899E77E0
		// [XID] // 0x00000001899E77A0-0x00000001899E77E0
		public bool SimulatePointerUp(Component component) => default; // 0x0000000181143C90-0x0000000181143DE0
		// [IDTag] // 0x00000001899F1E60-0x00000001899F1EA0
		// [XID] // 0x00000001899F1E60-0x00000001899F1EA0
		public bool SimulatePointerExit(GameObject gameObject) => default; // 0x0000000181143A30-0x0000000181143B40
		// [IDTag] // 0x00000001899FC590-0x00000001899FC5D0
		// [XID] // 0x00000001899FC590-0x00000001899FC5D0
		public bool SimulatePointerExit(Component component) => default; // 0x0000000181143B40-0x0000000181143C90
		// [IDTag] // 0x0000000189A06C50-0x0000000189A06C90
		// [XID] // 0x0000000189A06C50-0x0000000189A06C90
		public bool SimulatePointerEnter(GameObject gameObject) => default; // 0x00000001811437D0-0x00000001811438E0
		// [IDTag] // 0x0000000189A11190-0x0000000189A111D0
		// [XID] // 0x0000000189A11190-0x0000000189A111D0
		public bool SimulatePointerEnter(Component component) => default; // 0x00000001811438E0-0x0000000181143A30
		// [XID] // 0x0000000189A1B490-0x0000000189A1B4B0
		public bool SimulatePointerClickMuteAudio(Component component) => default; // 0x00000001811431B0-0x0000000181143310
		// [XID] // 0x0000000189A47E70-0x0000000189A47E90
		public void AddSelectableGroup(MihoyoSelectableGroup group) {} // 0x0000000181142B60-0x0000000181142C90
		// [XID] // 0x0000000189A4F610-0x0000000189A4F630
		public void RemoveSelectableGroup(MihoyoSelectableGroup group) {} // 0x00000001811430A0-0x00000001811431B0
		// [XID] // 0x0000000189A56D50-0x0000000189A56D70
		private void UpdateGroupSelectActive() {} // 0x0000000181142E30-0x00000001811430A0
	}
}
