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
	public class MonoInLevelQuestDialog : MonoUIProxy // TypeDefIndex: 29761
	{
		// Fields
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private MonoQuestBook _questBook; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _restrictionTips; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _restrictionText; // 0x58
	
		// Properties
		public MonoQuestBook questBook { /* [XID] */ /* 0x0000000189767F30-0x0000000189767F50 */ get => default; } // 0x0000000183D74F40-0x0000000183D74FE0 
		public MonoElementSwitch elementSwitch { /* [XID] */ /* 0x000000018977E5A0-0x000000018977E5C0 */ get => default; } // 0x0000000183D74580-0x0000000183D74620 
		public GameObject RestrictionTips { /* [XID] */ /* 0x0000000189785D10-0x0000000189785D30 */ get => default; } // 0x0000000183D74210-0x0000000183D742B0 
		public UnityEngine.UI.Text RestrictionText { /* [XID] */ /* 0x000000018978D430-0x000000018978D450 */ get => default; } // 0x0000000183D74170-0x0000000183D74210 
		public Button BtnCheck { /* [XID] */ /* 0x00000001897947B0-0x00000001897947D0 */ get => default; } // 0x0000000183D73E90-0x0000000183D73F90 
		public Button closeButton { /* [XID] */ /* 0x000000018979CC40-0x000000018979CC60 */ get => default; } // 0x0000000183D74470-0x0000000183D74580 
		public MonoUIContainer closeBtnContainer { /* [XID] */ /* 0x00000001897A40A0-0x00000001897A40C0 */ get => default; } // 0x0000000183D742B0-0x0000000183D74470 
		public MonoUIContainer lockBtnContainer { /* [XID] */ /* 0x00000001897AB600-0x00000001897AB620 */ get => default; } // 0x0000000183D747E0-0x0000000183D749A0 
		public MonoUIContainer rewardBtnContainer { /* [XID] */ /* 0x00000001897B3450-0x00000001897B3470 */ get => default; } // 0x0000000183D751A0-0x0000000183D75360 
		public Button ChapterSelectBtn { /* [XID] */ /* 0x00000001897BB330-0x00000001897BB350 */ get => default; } // 0x0000000183D73F90-0x0000000183D74170 
		public MonoReusableList questTab { /* [XID] */ /* 0x00000001897C2B10-0x00000001897C2B30 */ get => default; } // 0x0000000183D74FE0-0x0000000183D751A0 
		public Button navigateButton { /* [XID] */ /* 0x00000001897CA370-0x00000001897CA390 */ get => default; } // 0x0000000183D749A0-0x0000000183D74B80 
		public UnityEngine.UI.Text txtNavigationBtn { /* [XID] */ /* 0x00000001897D19D0-0x00000001897D19F0 */ get => default; } // 0x0000000183D75520-0x0000000183D756A0 
		public MonoUIContainer foldBtnContainer { /* [XID] */ /* 0x00000001897D97F0-0x00000001897D9810 */ get => default; } // 0x0000000183D74620-0x0000000183D747E0 
		public MonoUIContainer unfoldBtnContainer { /* [XID] */ /* 0x00000001897E0BB0-0x00000001897E0BD0 */ get => default; } // 0x0000000183D756A0-0x0000000183D75860 
		public MonoUIContainer rewardConfirmBtnContainer { /* [XID] */ /* 0x00000001897E8210-0x00000001897E8230 */ get => default; } // 0x0000000183D75360-0x0000000183D75520 
		public Button prevSwitchButton { /* [XID] */ /* 0x00000001897EFF30-0x00000001897EFF50 */ get => default; } // 0x0000000183D74D60-0x0000000183D74F40 
		public Button nextSwitchButton { /* [XID] */ /* 0x00000001897F76C0-0x00000001897F76E0 */ get => default; } // 0x0000000183D74B80-0x0000000183D74D60 
		public bool showSwitchButton { /* [XID] */ /* 0x00000001897FEDB0-0x00000001897FEDD0 */ set {} } // 0x0000000183D75B90-0x0000000183D75D40
		public bool showNavigationButton { /* [XID] */ /* 0x0000000189806530-0x0000000189806550 */ set {} } // 0x0000000183D75970-0x0000000183D75A80
		public bool showChapterSelectBtn { /* [XID] */ /* 0x000000018980DC30-0x000000018980DC50 */ set {} } // 0x0000000183D75860-0x0000000183D75970
		public bool showQuestTab { /* [XID] */ /* 0x0000000189815370-0x0000000189815390 */ set {} } // 0x0000000183D75A80-0x0000000183D75B90
	
		// Constructors
		public MonoInLevelQuestDialog() {} // 0x0000000183D73E10-0x0000000183D73E90
	
		// Methods
		// [XID] // 0x000000018976F4A0-0x000000018976F4C0
		public void AnimRefreshSubQuest() {} // 0x0000000183D73D40-0x0000000183D73E10
		// [XID] // 0x0000000189776EE0-0x0000000189776F00
		public void AnimNoQuest() {} // 0x0000000183D73C50-0x0000000183D73D40
	}
}
