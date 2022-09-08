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

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoJoypadAbstractListHandler : MonoJoypadInputHandlerBase, IJoypadListHandlerAdapter, IJoypadListHandlerInputAdapter // TypeDefIndex: 30636
	{
		// Fields
		// [Header] // 0x000000018969E6B0-0x000000018969E720
		[SerializeField] // 0x000000018969E6B0-0x000000018969E720
		// [Tooltip] // 0x000000018969E6B0-0x000000018969E720
		private List<GameObject> _managedItems; // 0x80
		[SerializeField] // 0x00000001896AE4C0-0x00000001896AE510
		// [Tooltip] // 0x00000001896AE4C0-0x00000001896AE510
		private bool _manageAllDirectChildren; // 0x88
		[SerializeField] // 0x00000001896B9F70-0x00000001896B9FC0
		// [Tooltip] // 0x00000001896B9F70-0x00000001896B9FC0
		private JoypadListLayout _layout; // 0x8C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ContextEventType _prevItemEvent; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ContextEventType _nextItemEvent; // 0x94
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ContextEventType _clickItemEvent; // 0x98
		private int _currIndex; // 0x9C
		private List<GameObject> _runtimeManagedItems; // 0xA0
	
		// Constructors
		public MonoJoypadAbstractListHandler() {} // 0x0000000184337A30-0x0000000184337B10
	
		// Methods
		// [XID] // 0x00000001896DBF10-0x00000001896DBF30
		protected override void Init() {} // 0x0000000184336B90-0x0000000184336E00
		// [XID] // 0x00000001896E36C0-0x00000001896E36E0
		private void RefreshAndExcludeInactiveItems() {} // 0x0000000184337570-0x00000001843377A0
		// [XID] // 0x00000001896EAAE0-0x00000001896EAB00
		public bool SelectItem(int idx) => default; // 0x0000000184337940-0x0000000184337A30
		// [XID] // 0x00000001896F1E80-0x00000001896F1EA0
		public void DeselectItem() {} // 0x0000000184336AF0-0x0000000184336B90
		// [XID] // 0x00000001896F9850-0x00000001896F9870
		public int GetSelectedIndex() => default; // 0x00000001843372F0-0x00000001843373A0
		// [XID] // 0x0000000189701090-0x00000001897010B0
		public void ClickItem(int idx) {} // 0x0000000184336A40-0x0000000184336AF0
		// [XID] // 0x0000000189708780-0x00000001897087A0
		public Transform GetSelectedItemTrans() => default; // 0x00000001843373A0-0x00000001843374C0
		// [XID] // 0x00000001897100F0-0x0000000189710110
		public int GetItemCount() => default; // 0x0000000184337010-0x00000001843370D0
		// [XID] // 0x0000000189717490-0x00000001897174B0
		public int GetColCount() => default; // 0x0000000184336EA0-0x0000000184336F60
		// [XID] // 0x000000018971EF10-0x000000018971EF30
		public int GetRowCount() => default; // 0x0000000184337230-0x00000001843372F0
		// [XID] // 0x00000001897264F0-0x0000000189726510
		public void OnAdapterFocus(bool activateObj) {} // 0x00000001843377A0-0x0000000184337880
		// [XID] // 0x000000018972DAB0-0x000000018972DAD0
		public void OnAdapterLostFocus(bool activateObj) {} // 0x0000000184337880-0x0000000184337940
		// [XID] // 0x0000000189735230-0x0000000189735250
		public ContextEventType GetUpItemEvent() => default; // 0x00000001843374C0-0x0000000184337570
		// [XID] // 0x000000018973CCB0-0x000000018973CCD0
		public ContextEventType GetDownItemEvent() => default; // 0x0000000184336F60-0x0000000184337010
		// [XID] // 0x0000000189744230-0x0000000189744250
		public ContextEventType GetLeftItemEvent() => default; // 0x00000001843370D0-0x0000000184337180
		// [XID] // 0x000000018974BF30-0x000000018974BF50
		public ContextEventType GetRightItemEvent() => default; // 0x0000000184337180-0x0000000184337230
		// [XID] // 0x0000000189753210-0x0000000189753230
		public ContextEventType GetClickItemEvent() => default; // 0x0000000184336E00-0x0000000184336EA0
	}
}
