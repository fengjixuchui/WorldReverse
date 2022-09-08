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
	public class MonoActivityTreasureHuntPage : MonoUIProxy // TypeDefIndex: 30361
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x40
		// [Header] // 0x0000000189A44D70-0x0000000189A44DC0
		[SerializeField] // 0x0000000189A44D70-0x0000000189A44DC0
		private UnityEngine.UI.Text _titleText; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _coinRoot; // 0x50
		// [Header] // 0x0000000189A58340-0x0000000189A58380
		[SerializeField] // 0x0000000189A58340-0x0000000189A58380
		private UnityEngine.UI.Text _mapTitle; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _mapDesc; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _mapTip; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoTreasureHuntMap _treasureHuntMap; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _grpMatrial; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _coinProgress; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _TxtMatrial; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _grpDescribe; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _bonusTitle; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _bonusDescription; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _bonusTip; // 0xA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _bonusImgMap; // 0xB0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ScrollRect _scrollDesc; // 0xB8
		// [Header] // 0x0000000189ABEA40-0x0000000189ABEA80
		[SerializeField] // 0x0000000189ABEA40-0x0000000189ABEA80
		private List<MonoUIContainer> _areaBtns; // 0xC0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private List<Transform> _lockLine; // 0xC8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private List<Transform> _openLine; // 0xD0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ScrollRect _scrollProgress; // 0xD8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _grpDetail; // 0xE0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _grpPicture; // 0xE8
	
		// Properties
		public UnityEngine.UI.Text title { /* [XID] */ /* 0x0000000189AF0F30-0x0000000189AF0F50 */ get => default; } // 0x00000001852E82E0-0x00000001852E8380 
		public Transform coinRoot { /* [XID] */ /* 0x0000000189AF83B0-0x0000000189AF83D0 */ get => default; } // 0x00000001852E7B50-0x00000001852E7BF0 
		public UnityEngine.UI.Text mapTitle { /* [XID] */ /* 0x0000000189AFFAC0-0x0000000189AFFAE0 */ get => default; } // 0x00000001852E7FE0-0x00000001852E8080 
		public UnityEngine.UI.Text mapDesc { /* [XID] */ /* 0x0000000189B07030-0x0000000189B07050 */ get => default; } // 0x00000001852E7EA0-0x00000001852E7F40 
		public UnityEngine.UI.Text mapTip { /* [XID] */ /* 0x0000000189B0E870-0x0000000189B0E890 */ get => default; } // 0x00000001852E7F40-0x00000001852E7FE0 
		public MonoTreasureHuntMap treasureHuntMap { /* [XID] */ /* 0x0000000189B15C60-0x0000000189B15C80 */ get => default; } // 0x00000001852E8380-0x00000001852E8420 
		public GameObject grpMatrial { /* [XID] */ /* 0x0000000189B1D370-0x0000000189B1D390 */ get => default; } // 0x00000001852E7D50-0x00000001852E7DF0 
		public UnityEngine.UI.Text coinProgress { /* [XID] */ /* 0x0000000189B24BF0-0x0000000189B24C10 */ get => default; } // 0x00000001852E7AA0-0x00000001852E7B50 
		public UnityEngine.UI.Text TxtMatrial { /* [XID] */ /* 0x0000000189B2C080-0x0000000189B2C0A0 */ get => default; } // 0x00000001852E73F0-0x00000001852E74A0 
		public GameObject grpDescribe { /* [XID] */ /* 0x0000000189B33630-0x0000000189B33650 */ get => default; } // 0x00000001852E7BF0-0x00000001852E7CA0 
		public ScrollRect scrollProgress { /* [XID] */ /* 0x0000000189B3AF30-0x0000000189B3AF50 */ get => default; } // 0x00000001852E8230-0x00000001852E82E0 
		public Rect scrollProgressRect { /* [XID] */ /* 0x0000000189B426B0-0x0000000189B426D0 */ get => default; } // 0x00000001852E8130-0x00000001852E8230 
		public UnityEngine.UI.Text bonusTitle { /* [XID] */ /* 0x0000000189B4A230-0x0000000189B4A250 */ get => default; } // 0x00000001852E76B0-0x00000001852E7760 
		public UnityEngine.UI.Text bonusDescription { /* [XID] */ /* 0x0000000189B519F0-0x0000000189B51A10 */ get => default; } // 0x00000001852E74A0-0x00000001852E7550 
		public UnityEngine.UI.Text bonusTip { /* [XID] */ /* 0x0000000189B591B0-0x0000000189B591D0 */ get => default; } // 0x00000001852E7600-0x00000001852E76B0 
		public Image bonusImgMap { /* [XID] */ /* 0x0000000189B60A00-0x0000000189B60A20 */ get => default; } // 0x00000001852E7550-0x00000001852E7600 
		public GameObject grpDetail { /* [XID] */ /* 0x0000000189B68110-0x0000000189B68130 */ get => default; } // 0x00000001852E7CA0-0x00000001852E7D50 
		public GameObject grpPicture { /* [XID] */ /* 0x0000000189B6F4B0-0x0000000189B6F4D0 */ get => default; } // 0x00000001852E7DF0-0x00000001852E7EA0 
		public ScrollRect scrollDesc { /* [XID] */ /* 0x0000000189B76B30-0x0000000189B76B50 */ get => default; } // 0x00000001852E8080-0x00000001852E8130 
		public Button btnReturn { /* [XID] */ /* 0x0000000189B944E0-0x0000000189B94500 */ get => default; } // 0x00000001852E7900-0x00000001852E7AA0 
		public Button btnDesc { /* [XID] */ /* 0x0000000189B9BBB0-0x0000000189B9BBD0 */ get => default; } // 0x00000001852E7760-0x00000001852E7900 
	
		// Constructors
		public MonoActivityTreasureHuntPage() {} // 0x00000001852E7300-0x00000001852E73F0
	
		// Methods
		// [XID] // 0x0000000189B7E0E0-0x0000000189B7E100
		public MonoActivityTreasureHuntButton GetAreaEntryBtn(int index) => default; // 0x00000001852E70B0-0x00000001852E71D0
		// [XID] // 0x0000000189B85CC0-0x0000000189B85CE0
		public RectTransform GetAreaEntryRect(int index) => default; // 0x00000001852E71D0-0x00000001852E7300
		// [XID] // 0x0000000189B8CCB0-0x0000000189B8CCD0
		public void ChangeLineStatus(int index, bool isOpen) {} // 0x00000001852E6ED0-0x00000001852E70B0
	}
}
