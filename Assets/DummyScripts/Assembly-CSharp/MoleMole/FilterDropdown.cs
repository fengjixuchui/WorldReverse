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
using UnityEngine.Events;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	// [RequireComponent] // 0x0000000189620260-0x00000001896202B0
	public class FilterDropdown : MonoBehaviour // TypeDefIndex: 28580
	{
		// Fields
		public RectTransform dropdownList; // 0x18
		public RectTransform itemTemplate; // 0x20
		public bool enablePinYin; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private readonly List<string> _options; // 0x30
		private InputField _inputField; // 0x38
		private RectTransform _itemContainer; // 0x40
		private ScrollRect _scrollRect; // 0x48
		private float _dropdownMaxHeight; // 0x50
		private Vector2 _firstItemPosition; // 0x54
		private float _itemHeight; // 0x5C
		private float _margin; // 0x60
		private readonly List<RectTransform> _items; // 0x68
		private FilterDropdownEvent _onValueChanged; // 0x70
		private bool _lastIsSelected; // 0x78
		private bool _textChangedByUser; // 0x79
		public int _firstShownIndex; // 0x7C
		private int _value; // 0x80
	
		// Properties
		public int value { /* [XID] */ /* 0x0000000189633990-0x00000001896339B0 */ get => default; /* [XID] */ /* 0x000000018963B2B0-0x000000018963B2D0 */ set {} } // 0x0000000181F7C560-0x0000000181F7C600 0x0000000181F7C6B0-0x0000000181F7C840
		public FilterDropdownEvent onValueChanged { /* [XID] */ /* 0x00000001896429E0-0x0000000189642A00 */ get => default; /* [XID] */ /* 0x000000018964A0F0-0x000000018964A110 */ set {} } // 0x0000000181F7C4C0-0x0000000181F7C560 0x0000000181F7C600-0x0000000181F7C6B0
		private bool _isSelected { /* [XID] */ /* 0x00000001896517B0-0x00000001896517D0 */ get => default; } // 0x0000000181F7BB40-0x0000000181F7BCE0 
		private bool _isLegalValue { /* [XID] */ /* 0x0000000189658FD0-0x0000000189658FF0 */ get => default; } // 0x0000000181F7B120-0x0000000181F7B290 
		private string _text { /* [XID] */ /* 0x00000001896606A0-0x00000001896606C0 */ get => default; /* [XID] */ /* 0x0000000189668000-0x0000000189668020 */ set {} } // 0x0000000181F7BE20-0x0000000181F7BED0 0x0000000181F7B290-0x0000000181F7B3A0
	
		// Nested types
		public class FilterDropdownEvent : UnityEvent<int> // TypeDefIndex: 28581
		{
			// Constructors
			public FilterDropdownEvent() {} // 0x0000000181F6BD90-0x0000000181F6BE00
		}
	
		// Constructors
		public FilterDropdown() {} // 0x0000000181F7C3A0-0x0000000181F7C4C0
	
		// Methods
		// [XID] // 0x000000018966FAA0-0x000000018966FAC0
		public void ClearOptions() {} // 0x0000000181F7B3A0-0x0000000181F7B460
		// [XID] // 0x00000001896773C0-0x00000001896773E0
		public void AddOption(string option) {} // 0x0000000181F7AB10-0x0000000181F7AC10
		// [XID] // 0x000000018967E930-0x000000018967E950
		public void AddOptions(IEnumerable<string> options) {} // 0x0000000181F7AC10-0x0000000181F7ACF0
		// [XID] // 0x00000001896861E0-0x0000000189686200
		private void Awake() {} // 0x0000000181F7ACF0-0x0000000181F7AFE0
		// [XID] // 0x000000018968DFF0-0x000000018968E010
		private void Update() {} // 0x0000000181F7C2D0-0x0000000181F7C3A0
		// [XID] // 0x0000000189695940-0x0000000189695960
		public void OpenDropDown() {} // 0x0000000181F7BD50-0x0000000181F7BE20
		// [XID] // 0x000000018969CFD0-0x000000018969CFF0
		private void CloseDropDown() {} // 0x0000000181F7AFE0-0x0000000181F7B120
		// [XID] // 0x00000001896A42A0-0x00000001896A42C0
		private void UpdateItems() {} // 0x0000000181F7B650-0x0000000181F7BB40
		// [XID] // 0x00000001896AB860-0x00000001896AB880
		public void UpdateShownItems() {} // 0x0000000181F7BED0-0x0000000181F7C2D0
		// [XID] // 0x00000001896B2A90-0x00000001896B2AB0
		private bool Filter(string input, string item) => default; // 0x0000000181F7B460-0x0000000181F7B650
	}
}
