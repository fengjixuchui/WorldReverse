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
	public class MonoJoypadSimpleResuableListHandler : MonoJoypadInputHandlerBase, IJoypadListHandlerAdapter, IJoypadListHandlerInputAdapter // TypeDefIndex: 30664
	{
		// Fields
		// [Header] // 0x00000001896098E0-0x0000000189609930
		[SerializeField] // 0x00000001896098E0-0x0000000189609930
		protected MonoSimpleReusableList _simpleResuableList; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected ContextEventType _prevItemEvent; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected ContextEventType _nextItemEvent; // 0x8C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected ContextEventType _confirmItemEvent; // 0x90
		[SerializeField] // 0x000000018962BBC0-0x000000018962BC10
		// [Tooltip] // 0x000000018962BBC0-0x000000018962BC10
		protected bool _focusOnChildUIModule; // 0x94
		[SerializeField] // 0x00000001897F46D0-0x00000001897F4710
		// [Tooltip] // 0x00000001897F46D0-0x00000001897F4710
		protected bool _transferChildModuleNavigateCmd; // 0x95
		protected int _selectIndex; // 0x98
		[SerializeField] // 0x0000000189640D40-0x0000000189640D80
		// [Tooltip] // 0x0000000189640D40-0x0000000189640D80
		protected ItemHighlightType _itemHighlightType; // 0x9C
		[SerializeField] // 0x000000018964B700-0x000000018964B750
		// [Tooltip] // 0x000000018964B700-0x000000018964B750
		protected bool _isGridNavigation; // 0xA0
		[SerializeField] // 0x0000000189657600-0x0000000189657640
		// [Tooltip] // 0x0000000189657600-0x0000000189657640
		protected bool _CrossNavByIndex; // 0xA1
		protected int _col; // 0xA4
		protected int _row; // 0xA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected ContextEventType _upItemEvent; // 0xAC
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected ContextEventType _downItemEvent; // 0xB0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected ContextEventType _leftItemEvent; // 0xB4
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected ContextEventType _rightItemEvent; // 0xB8
		[SerializeField] // 0x0000000189681980-0x00000001896819C0
		// [Tooltip] // 0x0000000189681980-0x00000001896819C0
		protected bool _skipInactive; // 0xBC
		[SerializeField] // 0x000000018968C480-0x000000018968C4D0
		// [Tooltip] // 0x000000018968C480-0x000000018968C4D0
		protected bool _skipAccordingToCustomRules; // 0xBD
		private NavigationCustomRules _navigationCustomRules; // 0xC0
		private Coroutine _coroutineOnFocus; // 0xC8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private JoypadListLayout _layout; // 0xD0
	
		// Properties
		public int selectIndex { /* [XID] */ /* 0x000000018969FC90-0x000000018969FCB0 */ get => default; } // 0x0000000183F8E090-0x0000000183F8E130 
	
		// Nested types
		public delegate bool NavigationCustomRules(int index); // TypeDefIndex: 30665; 0x0000000183FA0470-0x0000000183FA0600
	
		// Constructors
		public MonoJoypadSimpleResuableListHandler() {} // 0x0000000183F8DF50-0x0000000183F8E090
	
		// Methods
		// [XID] // 0x00000001896A6ED0-0x00000001896A6EF0
		public override bool HandleInputAction(InputActionEvent actionEvent) => default; // 0x0000000183F8C380-0x0000000183F8C730
		// [XID] // 0x00000001896AE4A0-0x00000001896AE4C0
		private bool NeedToHandleEvent(InputActionEvent actionEvent) => default; // 0x0000000183F8CE10-0x0000000183F8CF60
		// [XID] // 0x00000001896B5D70-0x00000001896B5D90
		protected ContextEventType ConvertScrollerEvent(ContextEventType contextEvent) => default; // 0x0000000183F8BB90-0x0000000183F8BC80
		// [XID] // 0x00000001896BCF30-0x00000001896BCF50
		protected override JoypadCrossNavDir ContextToNavDir(ContextEventType context) => default; // 0x0000000183F8C730-0x0000000183F8C7F0
		// [XID] // 0x00000001896C4410-0x00000001896C4430
		protected int GetNavigationIndexByType(InputActionEvent actionEvent, bool isGridNavigation) => default; // 0x0000000183F8B810-0x0000000183F8BB90
		// [IDTag] // 0x00000001896CBA50-0x00000001896CBA90
		// [XID] // 0x00000001896CBA50-0x00000001896CBA90
		protected void SelectListItem(int index, bool select) {} // 0x0000000183F8A8C0-0x0000000183F8AE20
		// [XID] // 0x00000001896D6110-0x00000001896D6130
		protected void ClickListItem(int index) {} // 0x0000000183F8C7F0-0x0000000183F8CE10
		// [XID] // 0x00000001896DD730-0x00000001896DD750
		protected override void OnFocus(bool activateObj) {} // 0x0000000183F8B350-0x0000000183F8B500
		// [XID] // 0x00000001896E4DA0-0x00000001896E4DC0
		private void DelaySelectItemOnFocus() {} // 0x0000000183F8B670-0x0000000183F8B720
		// [XID] // 0x00000001896EC2A0-0x00000001896EC2C0
		protected void SelectItemOnFocus() {} // 0x0000000183F8B000-0x0000000183F8B2F0
		// [XID] // 0x00000001896F3A70-0x00000001896F3A90
		protected override void OnLostFocus(bool activateObj) {} // 0x0000000183F8D5B0-0x0000000183F8D700
		// [XID] // 0x00000001896FB160-0x00000001896FB180
		public void SetCurrentItemHighlight(bool active) {} // 0x0000000183F8DA30-0x0000000183F8DB60
		// [XID] // 0x0000000189702900-0x0000000189702920
		public override void ClearBaseContext() {} // 0x0000000183F8B500-0x0000000183F8B5C0
		// [IDTag] // 0x000000018970A070-0x000000018970A0B0
		// [XID] // 0x000000018970A070-0x000000018970A0B0
		public void SelectListItem(int nextIndex) {} // 0x0000000183F8D940-0x0000000183F8DA30
		// [XID] // 0x0000000189714590-0x00000001897145B0
		public void SetNumOfRowAndCol(int row, int col) {} // 0x0000000183F8DC10-0x0000000183F8DCE0
		// [XID] // 0x000000018971C010-0x000000018971C030
		public void SetupRowColInfo(int num) {} // 0x0000000183F8DE40-0x0000000183F8DF50
		// [XID] // 0x00000001897234C0-0x00000001897234E0
		private int GetFixSideItemCount() => default; // 0x0000000183F8AE20-0x0000000183F8B000
		// [XID] // 0x000000018972AC00-0x000000018972AC20
		public override void NavigateFromTarget(MonoJoypadUIModule source, JoypadCrossNavDir fromDir, Vector3 navScreenPos, int sourceIndex) {} // 0x0000000183F8D070-0x0000000183F8D2E0
		// [XID] // 0x0000000189732310-0x0000000189732330
		public void SetResetIndexOnFocus(int index) {} // 0x0000000183F8DCE0-0x0000000183F8DD90
		// [XID] // 0x0000000189739A00-0x0000000189739A20
		public void SetSelectedIndex(int index) {} // 0x0000000183F8DD90-0x0000000183F8DE40
		// [XID] // 0x00000001897415C0-0x00000001897415E0
		public void SetNavigationCustomRules(NavigationCustomRules rules) {} // 0x0000000183F8DB60-0x0000000183F8DC10
		// [XID] // 0x0000000189748EA0-0x0000000189748EC0
		public bool SelectItem(int idx) => default; // 0x0000000183F8D800-0x0000000183F8D940
		// [XID] // 0x0000000189750350-0x0000000189750370
		public void DeselectItem() {} // 0x0000000183F8B720-0x0000000183F8B810
		// [XID] // 0x00000001897578F0-0x0000000189757910
		public void ClickItem(int idx) {} // 0x0000000183F8B5C0-0x0000000183F8B670
		// [XID] // 0x000000018975F2F0-0x000000018975F310
		public int GetSelectedIndex() => default; // 0x0000000183F8C160-0x0000000183F8C220
		// [XID] // 0x0000000189766730-0x0000000189766750
		public Transform GetSelectedItemTrans() => default; // 0x0000000183F8C220-0x0000000183F8C2E0
		// [XID] // 0x000000018976DD90-0x000000018976DDB0
		public int GetItemCount() => default; // 0x0000000183F8BE90-0x0000000183F8BF50
		// [XID] // 0x00000001897754A0-0x00000001897754C0
		public int GetColCount() => default; // 0x0000000183F8BD20-0x0000000183F8BDF0
		// [XID] // 0x000000018977CD50-0x000000018977CD70
		public int GetRowCount() => default; // 0x0000000183F8C090-0x0000000183F8C160
		// [XID] // 0x0000000189784770-0x0000000189784790
		public void OnAdapterFocus(bool activateObj) {} // 0x0000000183F8D390-0x0000000183F8D4E0
		// [XID] // 0x000000018978BD20-0x000000018978BD40
		public void OnAdapterLostFocus(bool activateObj) {} // 0x0000000183F8D4E0-0x0000000183F8D5B0
		// [XID] // 0x00000001897931D0-0x00000001897931F0
		public ContextEventType GetUpItemEvent() => default; // 0x0000000183F8C2E0-0x0000000183F8C380
		// [XID] // 0x000000018979B4A0-0x000000018979B4C0
		public ContextEventType GetDownItemEvent() => default; // 0x0000000183F8BDF0-0x0000000183F8BE90
		// [XID] // 0x00000001897A2960-0x00000001897A2980
		public ContextEventType GetLeftItemEvent() => default; // 0x0000000183F8BF50-0x0000000183F8BFF0
		// [XID] // 0x00000001897A9E40-0x00000001897A9E60
		public ContextEventType GetRightItemEvent() => default; // 0x0000000183F8BFF0-0x0000000183F8C090
		// [XID] // 0x00000001897B1850-0x00000001897B1870
		public ContextEventType GetClickItemEvent() => default; // 0x0000000183F8BC80-0x0000000183F8BD20
	}
}
