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
	public class MonoInteePanel : MonoSpriteProxy // TypeDefIndex: 31230
	{
		// Fields
		[SerializeField] // 0x0000000189A41DD0-0x0000000189A41E20
		[Space] // 0x0000000189A41DD0-0x0000000189A41E20
		// [Tooltip] // 0x0000000189A41DD0-0x0000000189A41E20
		private MonoReusableList _dialogPanel; // 0x20
		[SerializeField] // 0x0000000189A50D00-0x0000000189A50D40
		// [Tooltip] // 0x0000000189A50D00-0x0000000189A50D40
		private MonoReusableList _pickupPanel; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoScrollRectExtention _scrollRect; // 0x30
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private GameObject _keyPrefab; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _keyContainer; // 0x40
		private MonoControlElement _currOptionKey; // 0x48
		private List<KeyCode> _talkPickKeyCodes; // 0x50
		private MonoPickupListItem _currOption; // 0x58
		private MonoControlElement _optionSwitchKey; // 0x60
	
		// Properties
		public MonoReusableList pickupPanel { /* [XID] */ /* 0x0000000189A765D0-0x0000000189A765F0 */ get => default; } // 0x0000000184324430-0x00000001843244D0 
		public MonoReusableList dialogPanel { /* [XID] */ /* 0x0000000189A7DF40-0x0000000189A7DF60 */ get => default; } // 0x00000001843242E0-0x0000000184324380 
		public int pickupOptionCount { /* [XID] */ /* 0x0000000189AC1AA0-0x0000000189AC1AC0 */ get => default; } // 0x0000000184324380-0x0000000184324430 
		public bool showOptionSwitchKey { /* [XID] */ /* 0x0000000189B39540-0x0000000189B39560 */ set {} } // 0x00000001843244D0-0x00000001843245C0
	
		// Constructors
		public MonoInteePanel() {} // 0x0000000184324220-0x00000001843242E0
	
		// Methods
		// [XID] // 0x0000000189A858C0-0x0000000189A858E0
		public MonoPickupListItem GetOptionAt(int index) => default; // 0x0000000184322C10-0x0000000184322D60
		// [XID] // 0x0000000189A8D1A0-0x0000000189A8D1C0
		public int GetClickableCount() => default; // 0x00000001843221B0-0x00000001843223F0
		// [XID] // 0x0000000189A94700-0x0000000189A94720
		public int GetFirstClickableIndex() => default; // 0x0000000184322500-0x0000000184322730
		// [XID] // 0x0000000189A9BFC0-0x0000000189A9BFE0
		public int GetLastClickableIndex() => default; // 0x0000000184322730-0x0000000184322940
		// [XID] // 0x0000000189AA3670-0x0000000189AA3690
		public int GetNextClickableIndex(int curIndex, bool iterateBack = false /* Metadata: 0x00B12086 */) => default; // 0x0000000184322940-0x0000000184322C10
		// [XID] // 0x0000000189AAAD10-0x0000000189AAAD30
		public int GetPreClickableIndex(int curIndex) => default; // 0x0000000184322E70-0x00000001843230D0
		// [XID] // 0x0000000189AB26A0-0x0000000189AB26C0
		public MonoPickupListItem AddPickupOption(int addIndex = -1 /* Metadata: 0x00B12087 */) => default; // 0x0000000184321AE0-0x0000000184321C50
		// [XID] // 0x0000000189ABA170-0x0000000189ABA190
		public bool RemovePickupOptionAt(int index) => default; // 0x0000000184323B40-0x0000000184323CB0
		// [XID] // 0x0000000189AC9050-0x0000000189AC9070
		public MonoPickupListItem GetPickupOptionAt(int index) => default; // 0x0000000184322D60-0x0000000184322E70
		// [XID] // 0x0000000189AD0AA0-0x0000000189AD0AC0
		public MonoPickupListItem AddDialogOption(int index = -1 /* Metadata: 0x00B1208B */) => default; // 0x0000000184321970-0x0000000184321AE0
		// [XID] // 0x0000000189AD86C0-0x0000000189AD86E0
		public bool ReuseDialogOptionAt(int index) => default; // 0x0000000184323CB0-0x0000000184323E20
		// [XID] // 0x0000000189AE0320-0x0000000189AE0340
		public bool RemoveDialogOptionAt(int index) => default; // 0x00000001843239D0-0x0000000184323B40
		// [XID] // 0x0000000189AE78B0-0x0000000189AE78D0
		public MonoPickupListItem GetDialogOptionAt(int index) => default; // 0x00000001843223F0-0x0000000184322500
		// [XID] // 0x0000000189AEF590-0x0000000189AEF5B0
		public void ClearInDeactivated() {} // 0x0000000184321D00-0x0000000184321DA0
		// [XID] // 0x0000000189AF6A70-0x0000000189AF6A90
		public void ClearDialogPanel() {} // 0x0000000184321C50-0x0000000184321D00
		// [XID] // 0x0000000189AFE040-0x0000000189AFE060
		public void ClearPickupPanel() {} // 0x0000000184321DA0-0x0000000184321E50
		// [XID] // 0x0000000189B05850-0x0000000189B05870
		public void TryCreateCurrOptionKey() {} // 0x0000000184323E20-0x0000000184323F80
		// [XID] // 0x0000000189B0D020-0x0000000189B0D040
		public void RefreshCurrOptionKeyIcon() {} // 0x0000000184323770-0x00000001843239D0
		// [XID] // 0x0000000189B145F0-0x0000000189B14610
		private void MountCurrOptionKey(MonoPickupListItem inteeOption) {} // 0x0000000184321E50-0x00000001843220C0
		// [XID] // 0x0000000189B1BE30-0x0000000189B1BE50
		public void MountCurrOptionKeyAt(int index) {} // 0x00000001843236B0-0x0000000184323770
		// [XID] // 0x0000000189B23550-0x0000000189B23570
		public void UnmountCurrOptionKey() {} // 0x00000001843240D0-0x0000000184324220
		// [XID] // 0x0000000189B2A810-0x0000000189B2A830
		public void TryCreateOptionSwitchKey() {} // 0x0000000184323F80-0x00000001843240D0
		// [XID] // 0x0000000189B31D80-0x0000000189B31DA0
		private void RefreshOptionSwitchKeyIcon() {} // 0x00000001843230D0-0x00000001843232C0
		// [XID] // 0x0000000189B40E70-0x0000000189B40E90
		private void UpdateKeyOnAdd(MonoPickupListItem newItem) {} // 0x00000001843232C0-0x0000000184323440
		// [XID] // 0x0000000189B487C0-0x0000000189B487E0
		private void UpdateKeyOnDialogOptionRemove(int index) {} // 0x0000000184323440-0x00000001843236B0
	}
}
