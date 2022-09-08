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
	public class MonoElderTreePage : MonoUIProxy // TypeDefIndex: 30999
	{
		// Fields
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private MonoElementSwitch _elementSwitch; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _nextLevelRewardsScroller; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _requireMaterialsScroller; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _eventListScroller; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _levelText; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _nextLevelRewardText; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _eventTitleText; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _taskRefreshTimeText; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Animator _levelTreeAnimator; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _rewardGrp; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _rewardNoneGrp; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _requireMaterialsGrp; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _eventListGrp; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _eventEnterGrp; // 0xA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _btnEventList; // 0xB0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _imgEventListLocked; // 0xB8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _levelUpEff; // 0xC0
		[Space] // 0x00000001898E0F50-0x00000001898E0F60
		public float transDuration; // 0xC8
		public Vector3 eventCameralPositionOffet; // 0xCC
		public Vector3 eventCameralForwardOffet; // 0xD8
	
		// Properties
		public MonoGridScroller nextLevelRewardsScroller { /* [XID] */ /* 0x000000018974A700-0x000000018974A720 */ get => default; } // 0x0000000183C9F9E0-0x0000000183C9FA80 
		public MonoGridScroller requireMaterialsScroller { /* [XID] */ /* 0x0000000189751810-0x0000000189751830 */ get => default; } // 0x0000000183C9FB30-0x0000000183C9FBD0 
		public MonoGridScroller eventListScroller { /* [XID] */ /* 0x0000000189758DD0-0x0000000189758DF0 */ get => default; } // 0x0000000183C9F550-0x0000000183C9F5F0 
		public UnityEngine.UI.Text levelText { /* [XID] */ /* 0x0000000189760AB0-0x0000000189760AD0 */ get => default; } // 0x0000000183C9F740-0x0000000183C9F7E0 
		public UnityEngine.UI.Text nextLevelRewardText { /* [XID] */ /* 0x0000000189767D70-0x0000000189767D90 */ get => default; } // 0x0000000183C9F940-0x0000000183C9F9E0 
		public UnityEngine.UI.Text eventTitleText { /* [XID] */ /* 0x000000018976F300-0x000000018976F320 */ get => default; } // 0x0000000183C9F5F0-0x0000000183C9F690 
		public UnityEngine.UI.Text taskRefreshTimeText { /* [XID] */ /* 0x0000000189776D60-0x0000000189776D80 */ get => default; } // 0x0000000183C9FD30-0x0000000183C9FDD0 
		public Animator levelTreeAnimator { /* [XID] */ /* 0x000000018977E400-0x000000018977E420 */ get => default; } // 0x0000000183C9F7E0-0x0000000183C9F890 
		public Transform rewardGrp { /* [XID] */ /* 0x0000000189785B10-0x0000000189785B30 */ get => default; } // 0x0000000183C9FBD0-0x0000000183C9FC80 
		public Transform rewardNoneGrp { /* [XID] */ /* 0x000000018978D200-0x000000018978D220 */ get => default; } // 0x0000000183C9FC80-0x0000000183C9FD30 
		public Transform requireMaterialsGrp { /* [XID] */ /* 0x0000000189794570-0x0000000189794590 */ get => default; } // 0x0000000183C9FA80-0x0000000183C9FB30 
		public Transform eventListGrp { /* [XID] */ /* 0x000000018979CA20-0x000000018979CA40 */ get => default; } // 0x0000000183C9F4A0-0x0000000183C9F550 
		public Transform eventEnterGrp { /* [XID] */ /* 0x00000001897A3E80-0x00000001897A3EA0 */ get => default; } // 0x0000000183C9F3F0-0x0000000183C9F4A0 
		public Button btnEventList { /* [XID] */ /* 0x00000001897AB430-0x00000001897AB450 */ get => default; } // 0x0000000183C9EF80-0x0000000183C9F030 
		public Image imgEventListLocked { /* [XID] */ /* 0x00000001897B3230-0x00000001897B3250 */ get => default; } // 0x0000000183C9F690-0x0000000183C9F740 
		public GameObject levelUpEff { /* [XID] */ /* 0x00000001897BB150-0x00000001897BB170 */ get => default; } // 0x0000000183C9F890-0x0000000183C9F940 
		public MonoUIContainer btnReturn { /* [XID] */ /* 0x00000001897C2950-0x00000001897C2970 */ get => default; } // 0x0000000183C9F270-0x0000000183C9F330 
		public MonoUIContainer btnReturnBG { /* [XID] */ /* 0x00000001897CA110-0x00000001897CA130 */ get => default; } // 0x0000000183C9F1B0-0x0000000183C9F270 
		public MonoUIContainer btnRewards { /* [XID] */ /* 0x00000001897D17F0-0x00000001897D1810 */ get => default; } // 0x0000000183C9F330-0x0000000183C9F3F0 
		public MonoUIContainer btnOffering { /* [XID] */ /* 0x00000001897D9590-0x00000001897D95B0 */ get => default; } // 0x0000000183C9F030-0x0000000183C9F0F0 
		public MonoUIContainer btnDetail { /* [XID] */ /* 0x00000001897E09D0-0x00000001897E09F0 */ get => default; } // 0x0000000183C9EE00-0x0000000183C9EEC0 
		public MonoUIContainer btnEventDetailContainer { /* [XID] */ /* 0x00000001897E8070-0x00000001897E8090 */ get => default; } // 0x0000000183C9EEC0-0x0000000183C9EF80 
		public MonoUIContainer btnBackEventList { /* [XID] */ /* 0x00000001897EFCB0-0x00000001897EFCD0 */ get => default; } // 0x0000000183C9ED40-0x0000000183C9EE00 
		public MonoUIContainer btnBackEventListBG { /* [XID] */ /* 0x00000001897F74E0-0x00000001897F7500 */ get => default; } // 0x0000000183C9EC80-0x0000000183C9ED40 
		public MonoUIContainer btnRead { /* [XID] */ /* 0x00000001897FEBD0-0x00000001897FEBF0 */ get => default; } // 0x0000000183C9F0F0-0x0000000183C9F1B0 
	
		// Constructors
		public MonoElderTreePage() {} // 0x0000000183C9EB20-0x0000000183C9EC80
	
		// Methods
		// [XID] // 0x0000000189806310-0x0000000189806330
		public void SwitchToEventList(bool b) {} // 0x0000000183C9E810-0x0000000183C9EA40
		// [XID] // 0x000000018980D970-0x000000018980D990
		public void TriggerLevelUp() {} // 0x0000000183C9EA40-0x0000000183C9EB20
	}
}
