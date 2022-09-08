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
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoJoypadItemNavigator : MonoJoypadInputHandlerBase // TypeDefIndex: 30642
	{
		// Fields
		public Action<GameObject, int> onSelectItem; // 0x80
		public Action<GameObject, int> onClickItem; // 0x88
		[NonSerialized]
		public bool disableNav; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected ContextNavDirConfig[] customNavContexts; // 0x98
		// [Header] // 0x0000000189930390-0x00000001899303D0
		[SerializeField] // 0x0000000189930390-0x00000001899303D0
		protected JoypadItemNavigateMode _navMode; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected List<JoypadItemNavigatorData> _navItems; // 0xA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected ContextEventType _confirmInputType; // 0xB0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected bool _simulateClickOnSelect; // 0xB4
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected bool _simulateClickOnConfirm; // 0xB5
		[SerializeField] // 0x0000000189640D40-0x0000000189640D80
		// [Tooltip] // 0x0000000189640D40-0x0000000189640D80
		protected ItemHighlightType _itemHighlightType; // 0xB8
		protected int _itemIndex; // 0xBC
		[SerializeField] // 0x0000000189681980-0x00000001896819C0
		// [Tooltip] // 0x0000000189681980-0x00000001896819C0
		protected bool _skipInactive; // 0xC0
		[SerializeField] // 0x0000000189970B50-0x0000000189970B90
		// [Tooltip] // 0x0000000189970B50-0x0000000189970B90
		protected bool _skipDisable; // 0xC1
		private static readonly uint _selectAudio; // 0x00
	
		// Properties
		public int itemIndex { /* [XID] */ /* 0x000000018997C380-0x000000018997C3A0 */ get => default; } // 0x0000000183F85980-0x0000000183F85A20 
	
		// Nested types
		public enum JoypadItemNavigateMode // TypeDefIndex: 30643
		{
			Custom = 0,
			Vertical = 1,
			Horizontal = 2
		}
	
		[Serializable]
		public struct JoypadItemNavigatorLink // TypeDefIndex: 30644
		{
			// Fields
			public JoypadCrossNavDir dir; // 0x00
			public int navIndex; // 0x04
		}
	
		[Serializable]
		public class JoypadItemNavigatorData // TypeDefIndex: 30645
		{
			// Fields
			public GameObject item; // 0x10
			public List<JoypadItemNavigatorLink> navTargets; // 0x18
			public Button itemButton; // 0x20
			public GameObject activeObject; // 0x28
	
			// Constructors
			public JoypadItemNavigatorData() {} // 0x0000000183F7DD20-0x0000000183F7DDA0
		}
	
		// Constructors
		public MonoJoypadItemNavigator() {} // 0x0000000183F85790-0x0000000183F85980
		static MonoJoypadItemNavigator() {} // 0x0000000183F85700-0x0000000183F85790
	
		// Methods
		// [XID] // 0x00000001899840A0-0x00000001899840C0
		protected override void OnFocus(bool activateObj) {} // 0x0000000183F840B0-0x0000000183F84250
		// [XID] // 0x000000018998BC30-0x000000018998BC50
		protected override void OnLostFocus(bool activateObj) {} // 0x0000000183F84A20-0x0000000183F84D70
		// [XID] // 0x0000000189993800-0x0000000189993820
		protected void SelectItemOnFocus() {} // 0x0000000183F83F40-0x0000000183F840B0
		// [XID] // 0x000000018999B0C0-0x000000018999B0E0
		private bool IsItemValid(int index) => default; // 0x0000000183F83950-0x0000000183F83C10
		// [XID] // 0x00000001899A28E0-0x00000001899A2900
		public override bool HandleInputAction(InputActionEvent actionEvent) => default; // 0x0000000183F84360-0x0000000183F84910
		// [XID] // 0x00000001899AA200-0x00000001899AA220
		public void SelectItem(int index) {} // 0x0000000183F84DF0-0x0000000183F85700
		// [XID] // 0x00000001899B1BF0-0x00000001899B1C10
		protected void ClickItem(int index) {} // 0x0000000183F83C10-0x0000000183F83F40
		// [XID] // 0x00000001899B8F40-0x00000001899B8F60
		public GameObject GetItemByIndex(int index) => default; // 0x0000000183F84250-0x0000000183F84360
	}
}
