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
	public class MonoReputationHuntingPanel : MonoReputationHunting // TypeDefIndex: 31024
	{
		// Fields
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private UnityEngine.UI.Text _title; // 0xA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _author; // 0xB0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _desc; // 0xB8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _objCompleted; // 0xC0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ScrollRect _scrollRect; // 0xC8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoJoypadScrollRect _scrollRectHandler; // 0xD0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _rewardList; // 0xD8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoJoypadSimpleResuableListHandler _rewardListHandler; // 0xE0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0xE8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _grpPS4Button; // 0xF0
		private MonoReputationPage _pageMono; // 0xF8
		private List<RewardItemConfig> _tempRewardList; // 0x100
		private RewardState _rewardState; // 0x108
	
		// Properties
		private string title { /* [XID] */ /* 0x0000000189790300-0x0000000189790320 */ set {} } // 0x00000001844381E0-0x00000001844382B0
		private string author { /* [XID] */ /* 0x0000000189797C50-0x0000000189797C70 */ set {} } // 0x0000000184438350-0x0000000184438430
		private string desc { /* [XID] */ /* 0x000000018979F910-0x000000018979F930 */ set {} } // 0x00000001844384A0-0x0000000184438580
		public MonoJoypadScrollRect scrollRectHandler { /* [XID] */ /* 0x00000001897A6EB0-0x00000001897A6ED0 */ get => default; } // 0x0000000184439090-0x0000000184439140 
		public MonoJoypadSimpleResuableListHandler rewardListHandler { /* [XID] */ /* 0x00000001897AE830-0x00000001897AE850 */ get => default; } // 0x0000000184438FE0-0x0000000184439090 
		public MonoUIContainer BtnAccept { /* [XID] */ /* 0x00000001897B67B0-0x00000001897B67D0 */ get => default; } // 0x0000000184438B90-0x0000000184438D00 
		public MonoUIContainer BtnGiveup { /* [XID] */ /* 0x00000001897BE5F0-0x00000001897BE610 */ get => default; } // 0x0000000184438E70-0x0000000184438FE0 
		public MonoUIContainer BtnFetchHint { /* [XID] */ /* 0x00000001897C5CA0-0x00000001897C5CC0 */ get => default; } // 0x0000000184438D00-0x0000000184438E70 
		public override RewardState rewardState { /* [XID] */ /* 0x00000001897E3A50-0x00000001897E3A70 */ set {} } // 0x0000000184439140-0x0000000184439390
	
		// Constructors
		public MonoReputationHuntingPanel() {} // 0x0000000184438AD0-0x0000000184438B90
	
		// Methods
		// [XID] // 0x0000000189788D50-0x0000000189788D70
		public void OnEnable() {} // 0x0000000184438580-0x0000000184438630
		// [XID] // 0x00000001897CD4C0-0x00000001897CD4E0
		public void RefreshHunting(HuntingOfferData huntingData, MonoReputationPage pageMono = null) {} // 0x0000000184438630-0x0000000184438AD0
		// [XID] // 0x00000001897D4AE0-0x00000001897D4B00
		private void RefreshRewardItem(Transform trans, int index) {} // 0x0000000184437F40-0x00000001844381E0
		// [XID] // 0x00000001897DC160-0x00000001897DC180
		public RewardState GetRewardState() => default; // 0x00000001844382B0-0x0000000184438350
	}
}
