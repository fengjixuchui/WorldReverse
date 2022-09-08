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
	public class MonoCodexPushTipsPage : MonoUIProxy // TypeDefIndex: 30499
	{
		// Fields
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private MonoElementSwitch _elementSwitch; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _title; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _collectedNum; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _searchInputContainer; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _mainTitle; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _mainDesp; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _mainImage; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _pushTipsScroller; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _searchResult; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _notFound; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _noTips1; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _noTips2; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _searchGrp; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _detailGrp; // 0xA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _scrollViewGrp; // 0xB0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _iconTabList; // 0xB8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ScrollRect _detailDescScrollRect; // 0xC0
	
		// Properties
		public Text title { /* [XID] */ /* 0x0000000189628F40-0x0000000189628F60 */ get => default; } // 0x0000000184BA6950-0x0000000184BA69F0 
		public Text collectedNum { /* [XID] */ /* 0x00000001896308C0-0x00000001896308E0 */ get => default; } // 0x0000000184BA5E30-0x0000000184BA5ED0 
		public Text mainTitle { /* [XID] */ /* 0x0000000189638380-0x00000001896383A0 */ get => default; } // 0x0000000184BA6220-0x0000000184BA62C0 
		public Text mainDesp { /* [XID] */ /* 0x000000018963F780-0x000000018963F7A0 */ get => default; } // 0x0000000184BA60E0-0x0000000184BA6180 
		public Image mainImage { /* [XID] */ /* 0x0000000189646F80-0x0000000189646FA0 */ get => default; } // 0x0000000184BA6180-0x0000000184BA6220 
		public MonoGridScroller pushTipsScroller { /* [XID] */ /* 0x000000018964E6F0-0x000000018964E710 */ get => default; } // 0x0000000184BA64D0-0x0000000184BA6570 
		public Text searchResult { /* [XID] */ /* 0x0000000189655EE0-0x0000000189655F00 */ get => default; } // 0x0000000184BA6790-0x0000000184BA6840 
		public Text notFound { /* [XID] */ /* 0x000000018965D6C0-0x000000018965D6E0 */ get => default; } // 0x0000000184BA6420-0x0000000184BA64D0 
		public Text noTips1 { /* [XID] */ /* 0x0000000189664DC0-0x0000000189664DE0 */ get => default; } // 0x0000000184BA62C0-0x0000000184BA6370 
		public Text noTips2 { /* [XID] */ /* 0x000000018966C3E0-0x000000018966C400 */ get => default; } // 0x0000000184BA6370-0x0000000184BA6420 
		public RectTransform searchGrp { /* [XID] */ /* 0x00000001896742A0-0x00000001896742C0 */ get => default; } // 0x0000000184BA6620-0x0000000184BA66D0 
		public RectTransform detailGrp { /* [XID] */ /* 0x000000018967BA80-0x000000018967BAA0 */ get => default; } // 0x0000000184BA5F80-0x0000000184BA6030 
		public RectTransform scrollViewGrp { /* [XID] */ /* 0x0000000189683190-0x00000001896831B0 */ get => default; } // 0x0000000184BA6570-0x0000000184BA6620 
		public MonoSimpleReusableList iconTabList { /* [XID] */ /* 0x000000018968AC20-0x000000018968AC40 */ get => default; } // 0x0000000184BA6030-0x0000000184BA60E0 
		public ScrollRect detailDescScrollRect { /* [XID] */ /* 0x0000000189692920-0x0000000189692940 */ get => default; } // 0x0000000184BA5ED0-0x0000000184BA5F80 
		public Button btnReturn { /* [XID] */ /* 0x0000000189699CA0-0x0000000189699CC0 */ get => default; } // 0x0000000184BA5A70-0x0000000184BA5B30 
		public Button btnBack { /* [XID] */ /* 0x00000001896A13C0-0x00000001896A13E0 */ get => default; } // 0x0000000184BA5830-0x0000000184BA58F0 
		public Button btnSwitchPrev { /* [XID] */ /* 0x00000001896A8830-0x00000001896A8850 */ get => default; } // 0x0000000184BA5BF0-0x0000000184BA5CB0 
		public Button btnSwitchNext { /* [XID] */ /* 0x00000001896AFA00-0x00000001896AFA20 */ get => default; } // 0x0000000184BA5B30-0x0000000184BA5BF0 
		public Button btnTabPrev { /* [XID] */ /* 0x00000001896B7370-0x00000001896B7390 */ get => default; } // 0x0000000184BA5D70-0x0000000184BA5E30 
		public Button btnTabNext { /* [XID] */ /* 0x00000001896BE4A0-0x00000001896BE4C0 */ get => default; } // 0x0000000184BA5CB0-0x0000000184BA5D70 
		public Button btnClear { /* [XID] */ /* 0x00000001896C5CD0-0x00000001896C5CF0 */ get => default; } // 0x0000000184BA59B0-0x0000000184BA5A70 
		public Button btnCheck { /* [XID] */ /* 0x00000001896CD440-0x00000001896CD460 */ get => default; } // 0x0000000184BA58F0-0x0000000184BA59B0 
		public InputField searchInput { /* [XID] */ /* 0x00000001896D4870-0x00000001896D4890 */ get => default; } // 0x0000000184BA66D0-0x0000000184BA6790 
		public MonoReusableList tabList { /* [XID] */ /* 0x00000001896DBF30-0x00000001896DBF50 */ get => default; } // 0x0000000184BA6840-0x0000000184BA6950 
	
		// Constructors
		public MonoCodexPushTipsPage() {} // 0x0000000184BA5760-0x0000000184BA5830
	}
}
