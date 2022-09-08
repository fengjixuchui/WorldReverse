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
	public class MonoCodexQuestPage : MonoUIProxy // TypeDefIndex: 30501
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
		private MonoGridScroller _questScroller; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _scrollViewGrp; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _noQuestGrp; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _finishedChapterGrp; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _chapterContentGrp; // 0x78
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private Text _chapterTitle; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _chapterNum; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _mainQuestTitle; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _mainQuestDesc; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _questTitleList; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _subQuestList; // 0xA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoScrollRectExtention _questContentScrollRectExtension; // 0xB0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _btnFoldText; // 0xB8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _transForFocus; // 0xC0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _chapterImage; // 0xC8
	
		// Properties
		public Text title { /* [XID] */ /* 0x0000000189794650-0x0000000189794670 */ get => default; } // 0x0000000184BA7F10-0x0000000184BA7FB0 
		public Text collectedNum { /* [XID] */ /* 0x000000018979CAE0-0x000000018979CB00 */ get => default; } // 0x0000000184BA7770-0x0000000184BA7810 
		public MonoGridScroller questScroller { /* [XID] */ /* 0x00000001897A3F40-0x00000001897A3F60 */ get => default; } // 0x0000000184BA7B60-0x0000000184BA7C00 
		public RectTransform scrollViewGrp { /* [XID] */ /* 0x00000001897AB4C0-0x00000001897AB4E0 */ get => default; } // 0x0000000184BA7CB0-0x0000000184BA7D50 
		public RectTransform noQuestGrp { /* [XID] */ /* 0x00000001897B32B0-0x00000001897B32D0 */ get => default; } // 0x0000000184BA7A10-0x0000000184BA7AB0 
		public RectTransform finishedChapterGrp { /* [XID] */ /* 0x00000001897BB1D0-0x00000001897BB1F0 */ get => default; } // 0x0000000184BA7810-0x0000000184BA78B0 
		public RectTransform chapterContentGrp { /* [XID] */ /* 0x00000001897C29B0-0x00000001897C29D0 */ get => default; } // 0x0000000184BA74C0-0x0000000184BA7560 
		public Text chapterTitle { /* [XID] */ /* 0x00000001897CA1D0-0x00000001897CA1F0 */ get => default; } // 0x0000000184BA76C0-0x0000000184BA7770 
		public Text chapterNum { /* [XID] */ /* 0x00000001897D1870-0x00000001897D1890 */ get => default; } // 0x0000000184BA7610-0x0000000184BA76C0 
		public Text mainQuestTitle { /* [XID] */ /* 0x00000001897D9690-0x00000001897D96B0 */ get => default; } // 0x0000000184BA7960-0x0000000184BA7A10 
		public Text mainQuestDesc { /* [XID] */ /* 0x00000001897E0A10-0x00000001897E0A30 */ get => default; } // 0x0000000184BA78B0-0x0000000184BA7960 
		public MonoSimpleReusableList questTitleList { /* [XID] */ /* 0x00000001897E80D0-0x00000001897E80F0 */ get => default; } // 0x0000000184BA7C00-0x0000000184BA7CB0 
		public MonoSimpleReusableList subQuestList { /* [XID] */ /* 0x00000001897EFD70-0x00000001897EFD90 */ get => default; } // 0x0000000184BA7D50-0x0000000184BA7E00 
		public MonoScrollRectExtention questContentScrollRectExtension { /* [XID] */ /* 0x00000001897F7560-0x00000001897F7580 */ get => default; } // 0x0000000184BA7AB0-0x0000000184BA7B60 
		public Text btnFoldText { /* [XID] */ /* 0x00000001897FEC70-0x00000001897FEC90 */ get => default; } // 0x0000000184BA6EC0-0x0000000184BA6F80 
		public RectTransform transForFocus { /* [XID] */ /* 0x00000001898063B0-0x00000001898063D0 */ get => default; } // 0x0000000184BA7FB0-0x0000000184BA8060 
		public Image chapterImage { /* [XID] */ /* 0x000000018980DA50-0x000000018980DA70 */ get => default; } // 0x0000000184BA7560-0x0000000184BA7610 
		public Button btnReturn { /* [XID] */ /* 0x0000000189815230-0x0000000189815250 */ get => default; } // 0x0000000184BA71C0-0x0000000184BA7280 
		public Button btnBack { /* [XID] */ /* 0x000000018981CC50-0x000000018981CC70 */ get => default; } // 0x0000000184BA6D40-0x0000000184BA6E00 
		public Button btnOK { /* [XID] */ /* 0x0000000189824090-0x00000001898240B0 */ get => default; } // 0x0000000184BA7040-0x0000000184BA7100 
		public Button btnSwitchPrev { /* [XID] */ /* 0x000000018982BA90-0x000000018982BAB0 */ get => default; } // 0x0000000184BA7400-0x0000000184BA74C0 
		public Button btnSwitchNext { /* [XID] */ /* 0x0000000189833070-0x0000000189833090 */ get => default; } // 0x0000000184BA7340-0x0000000184BA7400 
		public Button btnFold { /* [XID] */ /* 0x000000018983A520-0x000000018983A540 */ get => default; } // 0x0000000184BA6F80-0x0000000184BA7040 
		public Button btnPlay { /* [XID] */ /* 0x0000000189841B20-0x0000000189841B40 */ get => default; } // 0x0000000184BA7100-0x0000000184BA71C0 
		public Button btnSelect { /* [XID] */ /* 0x0000000189849030-0x0000000189849050 */ get => default; } // 0x0000000184BA7280-0x0000000184BA7340 
		public Button btnCheck { /* [XID] */ /* 0x00000001898507B0-0x00000001898507D0 */ get => default; } // 0x0000000184BA6E00-0x0000000184BA6EC0 
		public MonoReusableList tabList { /* [XID] */ /* 0x0000000189857B80-0x0000000189857BA0 */ get => default; } // 0x0000000184BA7E00-0x0000000184BA7F10 
	
		// Constructors
		public MonoCodexQuestPage() {} // 0x0000000184BA6C70-0x0000000184BA6D40
	}
}
