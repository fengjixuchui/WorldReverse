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
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoDropdownExtention : Dropdown // TypeDefIndex: 30742
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _joypadImg; // 0x140
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _redPoint; // 0x148
		private ScrollRect _scrollRect; // 0x150
		private int _selectIndex; // 0x158
		public bool isShow; // 0x15C
		private List<int> _showRedPointIndexList; // 0x160
		private List<int> _noninteractableIndexList; // 0x168
	
		// Properties
		public Image joypadImg { /* [XID] */ /* 0x0000000189781890-0x00000001897818B0 */ get => default; } // 0x0000000183F44B30-0x0000000183F44BE0 
		public List<int> showRedPointIndexList { /* [XID] */ /* 0x0000000189788DB0-0x0000000189788DD0 */ get => default; } // 0x0000000183F44CC0-0x0000000183F44DA0 
		public List<int> noninteractableIndexList { /* [XID] */ /* 0x0000000189790360-0x0000000189790380 */ get => default; } // 0x0000000183F44BE0-0x0000000183F44CC0 
	
		// Constructors
		public MonoDropdownExtention() {} // 0x0000000183F44A80-0x0000000183F44B30
	
		// Methods
		// [XID] // 0x0000000189797CD0-0x0000000189797CF0
		public void SetJoypadActive(bool active) {} // 0x0000000183F446A0-0x0000000183F44780
		// [XID] // 0x000000018979F9B0-0x000000018979F9D0
		public void SetJoypadImgKey(Sprite keyIcon) {} // 0x0000000183F44780-0x0000000183F44850
		// [XID] // 0x00000001897A6FB0-0x00000001897A6FD0
		public void SetRedPointActive(bool active) {} // 0x0000000183F44850-0x0000000183F44940
		// [XID] // 0x00000001897AE8F0-0x00000001897AE910
		public void OnSelectConfirm() {} // 0x0000000183F44140-0x0000000183F44230
		// [XID] // 0x00000001897B6810-0x00000001897B6830
		public void MoveDropdownIndex(bool prevOrNext) {} // 0x0000000183F43ED0-0x0000000183F44090
		// [XID] // 0x00000001897BE670-0x00000001897BE690
		public new void Show() {} // 0x0000000183F44940-0x0000000183F44A80
		// [XID] // 0x00000001897C5CE0-0x00000001897C5D00
		public new void Hide() {} // 0x0000000183F43D90-0x0000000183F43E50
		// [XID] // 0x00000001897CD500-0x00000001897CD520
		private void RefreshDropdownList(int index) {} // 0x0000000183F43A20-0x0000000183F43D90
		// [XID] // 0x00000001897D4B20-0x00000001897D4B40
		public void RemoveDropdownList() {} // 0x0000000183F44520-0x0000000183F446A0
		// [XID] // 0x00000001897DC1A0-0x00000001897DC1C0
		public override void OnPointerClick(PointerEventData eventData) {} // 0x0000000183F44090-0x0000000183F44140
		// [XID] // 0x00000001897E3AF0-0x00000001897E3B10
		private void ShowItemRedPoint() {} // 0x0000000183F44230-0x0000000183F44520
		// [XID] // 0x00000001897EB780-0x00000001897EB7A0
		private void SetItemInteractable() {} // 0x0000000183F437C0-0x0000000183F43A20
	}
}
