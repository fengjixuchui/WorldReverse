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
	public class MonoJoypadGridScrollerHandler : MonoJoypadInputHandlerBase, IJoypadListHandlerAdapter, IJoypadListHandlerInputAdapter // TypeDefIndex: 30638
	{
		// Fields
		// [Header] // 0x00000001897AE930-0x00000001897AE980
		[SerializeField] // 0x00000001897AE930-0x00000001897AE980
		protected GridScrollerNavType _gridNavType; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected MonoGridScroller _gridScroller; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected ContextEventType _upItemEvent; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected ContextEventType _downItemEvent; // 0x94
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected ContextEventType _leftItemEvent; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected ContextEventType _rightItemEvent; // 0x9C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected bool _skipInactive; // 0xA0
		[SerializeField] // 0x000000018962BBC0-0x000000018962BC10
		// [Tooltip] // 0x000000018962BBC0-0x000000018962BC10
		protected bool _focusOnChildUIModule; // 0xA1
		[SerializeField] // 0x00000001897F46D0-0x00000001897F4710
		// [Tooltip] // 0x00000001897F46D0-0x00000001897F4710
		protected bool _transferChildModuleNavigateCmd; // 0xA2
		[SerializeField] // 0x0000000189640D40-0x0000000189640D80
		// [Tooltip] // 0x0000000189640D40-0x0000000189640D80
		protected ItemHighlightType _itemHighlightType; // 0xA4
		private Coroutine _coroutineOnFocus; // 0xA8
	
		// Nested types
		public enum GridScrollerNavType // TypeDefIndex: 30639
		{
			FourWay = 0,
			Vertical = 1,
			Horizontal = 2
		}
	
		// Constructors
		public MonoJoypadGridScrollerHandler() {} // 0x0000000183F82B00-0x0000000183F82C10
	
		// Methods
		// [XID] // 0x000000018980C190-0x000000018980C1B0
		public void SetResetIndexOnFocus(int index) {} // 0x0000000183F82A50-0x0000000183F82B00
		// [XID] // 0x0000000189813940-0x0000000189813960
		protected override void Init() {} // 0x0000000183F81320-0x0000000183F81450
		// [XID] // 0x000000018981B450-0x000000018981B470
		public override void SetBaseContext(BaseContext context, bool registerToContext = false /* Metadata: 0x00B113A3 */) {} // 0x0000000183F82920-0x0000000183F82A50
		// [XID] // 0x0000000189822AC0-0x0000000189822AE0
		protected override void OnFocus(bool activateObj) {} // 0x0000000183F80D00-0x0000000183F80EB0
		// [XID] // 0x000000018982A410-0x000000018982A430
		public override void ClearBaseContext() {} // 0x0000000183F80EB0-0x0000000183F80F70
		// [XID] // 0x0000000189831720-0x0000000189831740
		protected override void OnLostFocus(bool activateObj) {} // 0x0000000183F824E0-0x0000000183F82650
		// [XID] // 0x0000000189838E20-0x0000000189838E40
		protected void SelectItemOnFocus() {} // 0x0000000183F80B40-0x0000000183F80CA0
		// [XID] // 0x0000000189840440-0x0000000189840460
		protected ContextEventType ConvertScrollerEvent(ContextEventType contextEvent) => default; // 0x0000000183F81450-0x0000000183F81540
		// [XID] // 0x0000000189847A30-0x0000000189847A50
		protected override JoypadCrossNavDir ContextToNavDir(ContextEventType context) => default; // 0x0000000183F82090-0x0000000183F82150
		// [XID] // 0x000000018984F1A0-0x000000018984F1C0
		public override bool HandleInputAction(InputActionEvent actionEvent) => default; // 0x0000000183F81C40-0x0000000183F82090
		// [XID] // 0x0000000189856300-0x0000000189856320
		private void InvokeSelectCallback() {} // 0x0000000183F81140-0x0000000183F81320
		// [XID] // 0x000000018985D690-0x000000018985D6B0
		public bool SelectItem(int idx) => default; // 0x0000000183F82750-0x0000000183F82920
		// [XID] // 0x0000000189865030-0x0000000189865050
		public void DeselectItem() {} // 0x0000000183F81030-0x0000000183F81140
		// [XID] // 0x000000018986C5B0-0x000000018986C5D0
		public int GetSelectedIndex() => default; // 0x0000000183F81A20-0x0000000183F81AE0
		// [XID] // 0x0000000189873A00-0x0000000189873A20
		public void ClickItem(int idx) {} // 0x0000000183F80F70-0x0000000183F81030
		// [XID] // 0x000000018987B450-0x000000018987B470
		public Transform GetSelectedItemTrans() => default; // 0x0000000183F81AE0-0x0000000183F81BA0
		// [XID] // 0x0000000189882610-0x0000000189882630
		public int GetItemCount() => default; // 0x0000000183F81760-0x0000000183F81820
		// [XID] // 0x0000000189889DA0-0x0000000189889DC0
		public int GetColCount() => default; // 0x0000000183F81600-0x0000000183F816C0
		// [XID] // 0x0000000189891240-0x0000000189891260
		public int GetRowCount() => default; // 0x0000000183F81960-0x0000000183F81A20
		// [XID] // 0x0000000189898850-0x0000000189898870
		public void OnAdapterFocus(bool activateObj) {} // 0x0000000183F82260-0x0000000183F823D0
		// [XID] // 0x000000018989FA90-0x000000018989FAB0
		public void OnAdapterLostFocus(bool activateObj) {} // 0x0000000183F823D0-0x0000000183F824E0
		// [XID] // 0x00000001898A74C0-0x00000001898A74E0
		public ContextEventType GetUpItemEvent() => default; // 0x0000000183F81BA0-0x0000000183F81C40
		// [XID] // 0x00000001898AEEA0-0x00000001898AEEC0
		public ContextEventType GetDownItemEvent() => default; // 0x0000000183F816C0-0x0000000183F81760
		// [XID] // 0x00000001898B62B0-0x00000001898B62D0
		public ContextEventType GetLeftItemEvent() => default; // 0x0000000183F81820-0x0000000183F818C0
		// [XID] // 0x00000001898BDB80-0x00000001898BDBA0
		public ContextEventType GetRightItemEvent() => default; // 0x0000000183F818C0-0x0000000183F81960
		// [XID] // 0x00000001898C5420-0x00000001898C5440
		public ContextEventType GetClickItemEvent() => default; // 0x0000000183F81540-0x0000000183F81600
	}
}
