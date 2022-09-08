/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoNameCardSlot : MonoBehaviour // TypeDefIndex: 30422
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _actionButton; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _cardIcon; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _cardName; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _usingTip; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _lockedTip; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _newCornerMark; // 0x40
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private GameObject _numMark; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _numText; // 0x50
		private int _selectedIndex; // 0x5C
	
		// Properties
		public Button actionButton { /* [XID] */ /* 0x0000000189AC1C20-0x0000000189AC1C40 */ get => default; } // 0x0000000183711490-0x0000000183711530 
		public bool selected { /* [XID] */ /* 0x0000000189AC91D0-0x0000000189AC91F0 */ set {} } // 0x0000000183711760-0x0000000183711830
		public Image nameCardIcon { /* [XID] */ /* 0x0000000189AD0C60-0x0000000189AD0C80 */ get => default; } // 0x0000000183711590-0x0000000183711630 
		public string nameCardName { /* [XID] */ /* 0x0000000189AD8860-0x0000000189AD8880 */ set {} } // 0x0000000183711690-0x0000000183711760
		public bool showUsingTip { /* [XID] */ /* 0x0000000189AE04C0-0x0000000189AE04E0 */ set {} } // 0x0000000183711A10-0x0000000183711B00
		public bool showLockedTip { /* [XID] */ /* 0x0000000189AE7A30-0x0000000189AE7A50 */ set {} } // 0x0000000183711830-0x0000000183711920
		public bool showNewCornerMark { /* [XID] */ /* 0x0000000189AEF750-0x0000000189AEF770 */ set {} } // 0x0000000183711920-0x0000000183711A10
		public uint configId { /* [XID] */ /* 0x0000000189AF6C70-0x0000000189AF6CB0 */ get; /* [XID] */ /* 0x0000000189B01310-0x0000000189B01350 */ set; } // 0x0000000183711530-0x0000000183711590 0x0000000183711630-0x0000000183711690
	
		// Constructors
		public MonoNameCardSlot() {} // 0x0000000183711400-0x0000000183711490
	
		// Methods
		// [XID] // 0x0000000189B0B990-0x0000000189B0B9B0
		public void SetMarkNo(int index = 0 /* Metadata: 0x00B10EE1 */) {} // 0x0000000183711340-0x0000000183711400
		// [XID] // 0x0000000189B12E80-0x0000000189B12EA0
		public void RefreshMarkNo() {} // 0x00000001837111E0-0x0000000183711340
	}
}
