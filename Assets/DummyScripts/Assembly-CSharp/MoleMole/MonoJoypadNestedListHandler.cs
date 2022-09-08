/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoJoypadNestedListHandler : MonoJoypadInputHandlerBase // TypeDefIndex: 30651
	{
		// Fields
		// [Header] // 0x0000000189A0F610-0x0000000189A0F680
		[SerializeField] // 0x0000000189A0F610-0x0000000189A0F680
		// [Tooltip] // 0x0000000189A0F610-0x0000000189A0F680
		private Component _listHandler; // 0x80
		[SerializeField] // 0x0000000189A1FB30-0x0000000189A1FB80
		// [Tooltip] // 0x0000000189A1FB30-0x0000000189A1FB80
		private bool _penetrateSelect; // 0x88
		[SerializeField] // 0x0000000189A2B6F0-0x0000000189A2B740
		// [Tooltip] // 0x0000000189A2B6F0-0x0000000189A2B740
		private bool _useChildIndexWhenChangeSelect; // 0x89
		public Action<bool, Transform, int> onSelectItem; // 0x90
		public Action onFirstSelect; // 0x98
		public Action onDeselect; // 0xA0
		private bool _onFocusFlag; // 0xA8
		private Coroutine _onFocusCoroutine; // 0xB0
	
		// Properties
		public int itemCount { /* [XID] */ /* 0x0000000189A5CF30-0x0000000189A5CF50 */ get => default; } // 0x0000000183F892B0-0x0000000183F89390 
		public int rowCount { /* [XID] */ /* 0x0000000189A647D0-0x0000000189A647F0 */ get => default; } // 0x0000000183F89390-0x0000000183F89470 
		public int colCount { /* [XID] */ /* 0x0000000189A6C030-0x0000000189A6C050 */ get => default; } // 0x0000000183F88F40-0x0000000183F89020 
		public bool isSelected { /* [XID] */ /* 0x0000000189A73720-0x0000000189A73740 */ get => default; } // 0x0000000183F89200-0x0000000183F892B0 
		public int selectedIndex { /* [XID] */ /* 0x0000000189A7B280-0x0000000189A7B2A0 */ get => default; } // 0x0000000183F89550-0x0000000183F89630 
		public int selectedRow { /* [XID] */ /* 0x0000000189A82980-0x0000000189A829A0 */ get => default; } // 0x0000000183F89710-0x0000000183F897F0 
		public int selectedCol { /* [XID] */ /* 0x0000000189A8A390-0x0000000189A8A3B0 */ get => default; } // 0x0000000183F89470-0x0000000183F89550 
		public Transform selectedItem { /* [XID] */ /* 0x0000000189A91B10-0x0000000189A91B30 */ get => default; } // 0x0000000183F89630-0x0000000183F89710 
		public MonoJoypadNestedListHandler deepestSelectedList { /* [XID] */ /* 0x0000000189AAF780-0x0000000189AAF7A0 */ get => default; } // 0x0000000183F890E0-0x0000000183F89200 
		public Transform deepestSelectedItem { /* [XID] */ /* 0x0000000189AB7000-0x0000000189AB7020 */ get => default; } // 0x0000000183F89020-0x0000000183F890E0 
	
		// Nested types
		private enum ListEventType // TypeDefIndex: 30652
		{
			None = 0,
			Left = 1,
			Right = 2,
			Up = 3,
			Down = 4
		}
	
		private interface ISelectCommand // TypeDefIndex: 30653
		{
			// Methods
			void Execute(MonoJoypadNestedListHandler handler, SelectCmdContext context);
		}
	
		private struct CmdSelectTop : ISelectCommand // TypeDefIndex: 30654
		{
			// Methods
			// [XID] // 0x0000000189B264B0-0x0000000189B264D0
			public void Execute(MonoJoypadNestedListHandler handler, SelectCmdContext context) {} // 0x0000000183F7DB20-0x0000000183F7DCA0
		}
	
		private struct CmdSelectBottom : ISelectCommand // TypeDefIndex: 30655
		{
			// Methods
			// [XID] // 0x0000000189B2D780-0x0000000189B2D7A0
			public void Execute(MonoJoypadNestedListHandler handler, SelectCmdContext context) {} // 0x0000000183F7DCA0-0x0000000183F7DCC0
		}
	
		private struct CmdSelectLeft : ISelectCommand // TypeDefIndex: 30656
		{
			// Methods
			// [XID] // 0x0000000189B34C00-0x0000000189B34C20
			public void Execute(MonoJoypadNestedListHandler handler, SelectCmdContext context) {} // 0x0000000183F7D400-0x0000000183F7D420
		}
	
		private struct CmdSelectRight : ISelectCommand // TypeDefIndex: 30657
		{
			// Methods
			// [XID] // 0x0000000189B3C410-0x0000000189B3C430
			public void Execute(MonoJoypadNestedListHandler handler, SelectCmdContext context) {} // 0x0000000183F7D280-0x0000000183F7D400
		}
	
		private struct SelectCmdContext // TypeDefIndex: 30658
		{
			// Fields
			public int fromRow; // 0x00
			public int fromCol; // 0x04
			public int fromIndex; // 0x08
			public bool shouldAffectChild; // 0x0C
			public bool useFromIndex; // 0x0D
	
			// Constructors
			public SelectCmdContext(MonoJoypadNestedListHandler cur, MonoJoypadNestedListHandler child, ISelectCommand command) {
				fromRow = default;
				fromCol = default;
				fromIndex = default;
				shouldAffectChild = default;
				useFromIndex = default;
			} // 0x0000000183F7D700-0x0000000183F7D860
		}
	
		// Constructors
		public MonoJoypadNestedListHandler() {} // 0x0000000183F88E60-0x0000000183F88F40
	
		// Methods
		// [XID] // 0x0000000189A37860-0x0000000189A37880
		private void CallOnSelectItem(bool selected, Transform item, int idx) {} // 0x0000000183F88820-0x0000000183F88920
		// [XID] // 0x0000000189A3EFB0-0x0000000189A3EFD0
		private void CallOnFirstSelect() {} // 0x0000000183F88770-0x0000000183F88820
		// [XID] // 0x0000000189A46630-0x0000000189A46650
		private void CallOnDeselect() {} // 0x0000000183F87E30-0x0000000183F87EE0
		// [XID] // 0x0000000189A4DE20-0x0000000189A4DE40
		public bool SelectItem(int idx) => default; // 0x0000000183F88CD0-0x0000000183F88E60
		// [XID] // 0x0000000189A55630-0x0000000189A55650
		public void DeselectItem() {} // 0x0000000183F87A70-0x0000000183F87BD0
		// [XID] // 0x0000000189A99620-0x0000000189A99640
		protected override void OnFocus(bool activateObj) {} // 0x0000000183F87110-0x0000000183F872D0
		// [XID] // 0x0000000189AA06D0-0x0000000189AA06F0
		protected override void OnLostFocus(bool activateObj) {} // 0x0000000183F88B20-0x0000000183F88C50
		// [XID] // 0x0000000189AA7C90-0x0000000189AA7CB0
		public override void ClearBaseContext() {} // 0x0000000183F87460-0x0000000183F87520
		// [XID] // 0x0000000189ABE9E0-0x0000000189ABEA00
		public override bool HandleInputAction(InputActionEvent actionEvent) => default; // 0x0000000183F87EE0-0x0000000183F880F0
		// [IDTag] // 0x0000000189AC65B0-0x0000000189AC65F0
		// [XID] // 0x0000000189AC65B0-0x0000000189AC65F0
		private void SetNavItem(bool selected) {} // 0x0000000183F87640-0x0000000183F87710
		// [IDTag] // 0x0000000189AD0BE0-0x0000000189AD0C20
		// [XID] // 0x0000000189AD0BE0-0x0000000189AD0C20
		private void SetNavItem(bool selected, Transform item) {} // 0x0000000183F87710-0x0000000183F87840
		// [XID] // 0x0000000189ADB840-0x0000000189ADB860
		private bool HandleSelectChangeInputRecursively(ContextEventType input, ref MonoJoypadNestedListHandler handledBy, ref bool handledListIndexChanged) => default; // 0x0000000183F86B40-0x0000000183F870B0
		// [XID] // 0x0000000189AE3140-0x0000000189AE3160
		private void ExecuteCmdRecursively(ISelectCommand command, SelectCmdContext context) {} // 0x0000000183F87840-0x0000000183F87A70
		// [XID] // 0x0000000189AEAAD0-0x0000000189AEAAF0
		private bool HandleClickInputRecursively(ContextEventType input) => default; // 0x0000000183F88920-0x0000000183F88B20
		// [XID] // 0x0000000189AF23C0-0x0000000189AF23E0
		private void DeselectRecursively() {} // 0x0000000183F880F0-0x0000000183F88200
		// [XID] // 0x0000000189AF9D60-0x0000000189AF9D80
		private void OnFocusRecursively(bool activateObj) {} // 0x0000000183F88200-0x0000000183F88380
		// [XID] // 0x0000000189B01290-0x0000000189B012B0
		private void OnLostFocusRecursively(bool activateObj, bool force = false /* Metadata: 0x00B113DC */) {} // 0x0000000183F872D0-0x0000000183F87460
		// [XID] // 0x0000000189B087E0-0x0000000189B08800
		private MonoJoypadNestedListHandler FindFirstChildNestedList(Transform trans) => default; // 0x0000000183F88380-0x0000000183F88660
		// [XID] // 0x0000000189B10180-0x0000000189B101A0
		private ListEventType ToListEventType(ContextEventType input) => default; // 0x0000000183F87CE0-0x0000000183F87E30
		// [XID] // 0x0000000189B172A0-0x0000000189B172C0
		private ISelectCommand ToSelectCommand(ListEventType listEvent) => default; // 0x0000000183F87BD0-0x0000000183F87CE0
		// [XID] // 0x0000000189B1EC40-0x0000000189B1EC60
		public int ColRowToIdx(int col, int row) => default; // 0x0000000183F87520-0x0000000183F87640
	}
}
