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
	public class MonoUseMaterialDialog : MonoUIProxy // TypeDefIndex: 30484
	{
		// Fields
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private Button _freeClickButton; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _prevButtonContainer; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _nextButtonContainer; // 0x58
		public MonoGridScroller scroller; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _dropLinkButtonContainer; // 0x68
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private UnityEngine.UI.Text _title; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _currLevelLabel; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _levelIncrease; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _maxHint; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _noItemHint; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoLocalizedText _noItemHintLabel; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUseCount _useCount; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _helpBtn; // 0xA8
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private UnityEngine.UI.Text _currExpLabel; // 0xB0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _expAddLabel; // 0xB8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private SmoothMask _currFill; // 0xC0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private SmoothMask _postFill; // 0xC8
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private RectTransform _avatarInfoGrp; // 0xD0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _tipsGrp; // 0xD8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _tipsLabel; // 0xE0
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private RectTransform _detailsGrp; // 0xE8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ScrollRect _detailsScrollRect; // 0xF0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtName; // 0xF8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtEffect; // 0x100
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtDesc; // 0x108
		public GameObject useMolaGo; // 0x110
		public MonoNeedLabel useMolaLabel; // 0x118
		private uint _currLevel; // 0x120
		private uint _currExp; // 0x124
		private uint _currLevelMaxExp; // 0x128
		private MonoScrollRectExtention _itemScrollExt; // 0x130
	
		// Properties
		public Button freeClickButton { /* [XID] */ /* 0x0000000189A3EFF0-0x0000000189A3F010 */ get => default; } // 0x000000018489DA10-0x000000018489DAB0 
		public Button closeButton { /* [XID] */ /* 0x0000000189A46670-0x0000000189A46690 */ get => default; } // 0x000000018489D610-0x000000018489D7F0 
		public Button cancleButton { /* [XID] */ /* 0x0000000189A4DE60-0x0000000189A4DE80 */ get => default; } // 0x000000018489D430-0x000000018489D610 
		public Button useButton { /* [XID] */ /* 0x0000000189A55670-0x0000000189A55690 */ get => default; } // 0x000000018489DF70-0x000000018489E150 
		public Button prevButton { /* [XID] */ /* 0x0000000189A5CFB0-0x0000000189A5CFD0 */ get => default; } // 0x000000018489DE20-0x000000018489DED0 
		public Button nextButton { /* [XID] */ /* 0x0000000189A64850-0x0000000189A64870 */ get => default; } // 0x000000018489DD70-0x000000018489DE20 
		public Button helpButton { /* [XID] */ /* 0x0000000189A6C070-0x0000000189A6C090 */ get => default; } // 0x000000018489DAB0-0x000000018489DB60 
		public Button increaseButton { /* [XID] */ /* 0x0000000189A737A0-0x0000000189A737C0 */ get => default; } // 0x000000018489DB60-0x000000018489DC20 
		public Button decreaseButton { /* [XID] */ /* 0x0000000189A7B2C0-0x0000000189A7B2E0 */ get => default; } // 0x000000018489D7F0-0x000000018489D8B0 
		public Button dropLinkButton { /* [XID] */ /* 0x0000000189A829C0-0x0000000189A829E0 */ get => default; } // 0x000000018489D960-0x000000018489DA10 
		public UnityEngine.UI.Text title { /* [XID] */ /* 0x0000000189A8A3B0-0x0000000189A8A3D0 */ get => default; } // 0x000000018489DED0-0x000000018489DF70 
		public bool showCountGroup { /* [XID] */ /* 0x0000000189A91B30-0x0000000189A91B50 */ set {} } // 0x000000018489E320-0x000000018489E420
		public bool showAvatarInfoGroup { /* [XID] */ /* 0x0000000189A99640-0x0000000189A99660 */ set {} } // 0x000000018489E220-0x000000018489E320
		public bool showDetailsGroup { /* [XID] */ /* 0x0000000189AA06F0-0x0000000189AA0710 */ set {} } // 0x000000018489E420-0x000000018489E520
		public ScrollRect detailsScrollRect { /* [XID] */ /* 0x0000000189AA7CF0-0x0000000189AA7D10 */ get => default; } // 0x000000018489D8B0-0x000000018489D960 
		public bool showTipsGroup { /* [XID] */ /* 0x0000000189AAF7C0-0x0000000189AAF7E0 */ set {} } // 0x000000018489E620-0x000000018489E720
		public bool showNoItemHint { /* [XID] */ /* 0x0000000189AB7040-0x0000000189AB7060 */ set {} } // 0x000000018489E520-0x000000018489E620
		public string noItemHintTextID { /* [XID] */ /* 0x0000000189ABEA20-0x0000000189ABEA40 */ set {} } // 0x000000018489E150-0x000000018489E220
		public string tips { /* [XID] */ /* 0x0000000189AC6610-0x0000000189AC6630 */ set {} } // 0x000000018489E810-0x000000018489E8E0
		public MonoScrollRectExtention itemScrollExt { /* [XID] */ /* 0x0000000189AEC250-0x0000000189AEC270 */ get => default; } // 0x000000018489DC20-0x000000018489DD70 
		public bool showUseMolaGrp { /* [XID] */ /* 0x0000000189AF3C70-0x0000000189AF3C90 */ set {} } // 0x000000018489E720-0x000000018489E810
	
		// Constructors
		public MonoUseMaterialDialog() {} // 0x000000018489D2B0-0x000000018489D430
	
		// Methods
		// [XID] // 0x0000000189ACDC40-0x0000000189ACDC60
		public void SetCurrInfo(uint currLevel, uint currExp, uint currLevelMaxExp, bool isMax, bool noItem) {} // 0x000000018489CCB0-0x000000018489D050
		// [XID] // 0x0000000189AD59F0-0x0000000189AD5A10
		public void SetUseCount(int min, int max, int use) {} // 0x000000018489D1B0-0x000000018489D2B0
		// [XID] // 0x0000000189ADD3F0-0x0000000189ADD410
		public void HintExpAdd(uint levelAdd, uint expAdd, bool isMax) {} // 0x000000018489C9E0-0x000000018489CCB0
		// [XID] // 0x0000000189AE4BD0-0x0000000189AE4BF0
		public void SetDetailsInfo(MaterialExcelConfig config) {} // 0x000000018489D050-0x000000018489D1B0
	}
}
