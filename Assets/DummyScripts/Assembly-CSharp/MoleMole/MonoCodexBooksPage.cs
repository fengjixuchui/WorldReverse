/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoCodexBooksPage : MonoUIProxy // TypeDefIndex: 30490
	{
		// Fields
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private MonoElementSwitch _elementSwitch; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _title; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _collectedNum; // 0x50
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private MonoSimpleReusableList _setTitleList; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _bookDetailList; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _scrollViewGrp; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _noBookGrp; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _screeningPanelGrp; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _bookContentGrp; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoScrollRectExtention _bookContentScrollRectExtension; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _btnFoldText; // 0x90
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private MonoGridScroller _screenScroller; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _screenTitle; // 0xA0
	
		// Properties
		public Text title { /* [XID] */ /* 0x0000000189703ED0-0x0000000189703EF0 */ get => default; } // 0x0000000184BA1B80-0x0000000184BA1C20 
		public Text collectedNum { /* [XID] */ /* 0x000000018970B7B0-0x000000018970B7D0 */ get => default; } // 0x0000000184BA1700-0x0000000184BA17A0 
		public MonoSimpleReusableList setTitleList { /* [XID] */ /* 0x0000000189713030-0x0000000189713050 */ get => default; } // 0x0000000184BA1AE0-0x0000000184BA1B80 
		public MonoSimpleReusableList bookDetailList { /* [XID] */ /* 0x000000018971A8B0-0x000000018971A8D0 */ get => default; } // 0x0000000184BA11E0-0x0000000184BA1280 
		public RectTransform scrollViewGrp { /* [XID] */ /* 0x0000000189721C10-0x0000000189721C30 */ get => default; } // 0x0000000184BA1A40-0x0000000184BA1AE0 
		public RectTransform noBookGrp { /* [XID] */ /* 0x0000000189729280-0x00000001897292A0 */ get => default; } // 0x0000000184BA17A0-0x0000000184BA1840 
		public RectTransform screeningPanelGrp { /* [XID] */ /* 0x0000000189730AA0-0x0000000189730AC0 */ get => default; } // 0x0000000184BA19A0-0x0000000184BA1A40 
		public RectTransform bookContentGrp { /* [XID] */ /* 0x00000001897383F0-0x0000000189738410 */ get => default; } // 0x0000000184BA1080-0x0000000184BA1130 
		public MonoScrollRectExtention bookContentScrollRectExtension { /* [XID] */ /* 0x00000001897400F0-0x0000000189740110 */ get => default; } // 0x0000000184BA1130-0x0000000184BA11E0 
		public MonoGridScroller screenScroller { /* [XID] */ /* 0x00000001897474C0-0x00000001897474E0 */ get => default; } // 0x0000000184BA1840-0x0000000184BA18F0 
		public Text screenTitle { /* [XID] */ /* 0x000000018974EC10-0x000000018974EC30 */ get => default; } // 0x0000000184BA18F0-0x0000000184BA19A0 
		public Text btnFoldText { /* [XID] */ /* 0x0000000189756320-0x0000000189756340 */ get => default; } // 0x0000000184BA1400-0x0000000184BA14C0 
		public Button btnFold { /* [XID] */ /* 0x000000018975D700-0x000000018975D720 */ get => default; } // 0x0000000184BA14C0-0x0000000184BA1580 
		public Button btnScreen { /* [XID] */ /* 0x0000000189764D50-0x0000000189764D70 */ get => default; } // 0x0000000184BA1640-0x0000000184BA1700 
		public Button btnBack { /* [XID] */ /* 0x000000018976C7B0-0x000000018976C7D0 */ get => default; } // 0x0000000184BA1280-0x0000000184BA1340 
		public Button btnReturn { /* [XID] */ /* 0x0000000189773C70-0x0000000189773C90 */ get => default; } // 0x0000000184BA1580-0x0000000184BA1640 
		public Button btnCheck { /* [XID] */ /* 0x000000018977B320-0x000000018977B340 */ get => default; } // 0x0000000184BA1340-0x0000000184BA1400 
	
		// Constructors
		public MonoCodexBooksPage() {} // 0x0000000184BA0FD0-0x0000000184BA1080
	}
}
