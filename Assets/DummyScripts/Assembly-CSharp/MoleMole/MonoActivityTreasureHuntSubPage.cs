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
	public class MonoActivityTreasureHuntSubPage : MonoUIProxy // TypeDefIndex: 30362
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x40
		// [Header] // 0x0000000189BAA620-0x0000000189BAA670
		[SerializeField] // 0x0000000189BAA620-0x0000000189BAA670
		private UnityEngine.UI.Text _timeDate; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _title; // 0x50
		// [Header] // 0x0000000189BBD880-0x0000000189BBD8C0
		[SerializeField] // 0x0000000189BBD880-0x0000000189BBD8C0
		private ScrollRect _scrollDesc; // 0x58
		// [Header] // 0x0000000189BCA140-0x0000000189BCA180
		[SerializeField] // 0x0000000189BCA140-0x0000000189BCA180
		private MonoGridScroller _scroller; // 0x60
		// [Header] // 0x0000000189BD5B00-0x0000000189BD5B40
		[SerializeField] // 0x0000000189BD5B00-0x0000000189BD5B40
		private MonoTreasureHuntMap _treasureHuntMap; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _grpBoxPicture; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _grpMap; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _mapTip; // 0x80
		// [Header] // 0x00000001895FD660-0x00000001895FD6B0
		[SerializeField] // 0x00000001895FD660-0x00000001895FD6B0
		private GameObject _rewardTipGrp; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _rewardTime; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _coinRoot; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _lockTipsGrp; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _unLockTipsText; // 0xA8
	
		// Properties
		public UnityEngine.UI.Text timeDate { /* [XID] */ /* 0x00000001896274B0-0x00000001896274D0 */ get => default; } // 0x00000001852E9A80-0x00000001852E9B20 
		public UnityEngine.UI.Text title { /* [XID] */ /* 0x000000018962EFB0-0x000000018962EFD0 */ get => default; } // 0x00000001852E9B20-0x00000001852E9BC0 
		public ScrollRect scrollDesc { /* [XID] */ /* 0x0000000189636950-0x0000000189636970 */ get => default; } // 0x00000001852E9940-0x00000001852E99E0 
		public MonoGridScroller scroller { /* [XID] */ /* 0x000000018963DE60-0x000000018963DE80 */ get => default; } // 0x00000001852E99E0-0x00000001852E9A80 
		public MonoTreasureHuntMap treasureHuntMap { /* [XID] */ /* 0x0000000189645810-0x0000000189645830 */ get => default; } // 0x00000001852E9BC0-0x00000001852E9C60 
		public GameObject grpBoxPicture { /* [XID] */ /* 0x000000018964CFF0-0x000000018964D010 */ get => default; } // 0x00000001852E9540-0x00000001852E95E0 
		public GameObject grpMap { /* [XID] */ /* 0x0000000189654780-0x00000001896547A0 */ get => default; } // 0x00000001852E95E0-0x00000001852E9680 
		public UnityEngine.UI.Text mapTip { /* [XID] */ /* 0x000000018965BE70-0x000000018965BE90 */ get => default; } // 0x00000001852E9730-0x00000001852E97E0 
		public GameObject rewardTipGrp { /* [XID] */ /* 0x00000001896634A0-0x00000001896634C0 */ get => default; } // 0x00000001852E9890-0x00000001852E9940 
		public UnityEngine.UI.Text rewardTime { /* [XID] */ /* 0x000000018966AE70-0x000000018966AE90 */ get => default; } // 0x00000001852E97E0-0x00000001852E9890 
		public Transform coinRoot { /* [XID] */ /* 0x0000000189672A90-0x0000000189672AB0 */ get => default; } // 0x00000001852E9490-0x00000001852E9540 
		public GameObject lockTipsGrp { /* [XID] */ /* 0x000000018967A1B0-0x000000018967A1D0 */ get => default; } // 0x00000001852E9680-0x00000001852E9730 
		public UnityEngine.UI.Text unLockTipsText { /* [XID] */ /* 0x00000001896819C0-0x00000001896819E0 */ get => default; } // 0x00000001852E9C60-0x00000001852E9D10 
		public Button btnExit { /* [XID] */ /* 0x0000000189689450-0x0000000189689470 */ get => default; } // 0x00000001852E8C70-0x00000001852E8E10 
		public Button btnBack { /* [XID] */ /* 0x00000001896910D0-0x00000001896910F0 */ get => default; } // 0x00000001852E8790-0x00000001852E8930 
		public Button btnOk { /* [XID] */ /* 0x0000000189698840-0x0000000189698860 */ get => default; } // 0x00000001852E8FB0-0x00000001852E9150 
		public Button btnCheck { /* [XID] */ /* 0x000000018969FCD0-0x000000018969FCF0 */ get => default; } // 0x00000001852E8930-0x00000001852E8AD0 
		public Button btnGoto { /* [XID] */ /* 0x00000001896A6EF0-0x00000001896A6F10 */ get => default; } // 0x00000001852E8E10-0x00000001852E8FB0 
		public Button btnDesc { /* [XID] */ /* 0x00000001896AE510-0x00000001896AE530 */ get => default; } // 0x00000001852E8AD0-0x00000001852E8C70 
		public Button btnShop { /* [XID] */ /* 0x00000001896B5D90-0x00000001896B5DB0 */ get => default; } // 0x00000001852E9150-0x00000001852E92F0 
		public Button btnTreasureHunt { /* [XID] */ /* 0x00000001896BCF50-0x00000001896BCF70 */ get => default; } // 0x00000001852E92F0-0x00000001852E9490 
	
		// Constructors
		public MonoActivityTreasureHuntSubPage() {} // 0x00000001852E86E0-0x00000001852E8790
	
		// Methods
		// [XID] // 0x00000001896C4430-0x00000001896C4450
		public void SetTreasureHuntBtnText(string text) {} // 0x00000001852E8420-0x00000001852E85C0
		// [XID] // 0x00000001896CBA90-0x00000001896CBAB0
		public void TrySetBtnInteractable(Button btn, bool interactable) {} // 0x00000001852E85C0-0x00000001852E86E0
	}
}
