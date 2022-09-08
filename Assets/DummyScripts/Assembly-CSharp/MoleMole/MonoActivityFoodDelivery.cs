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
	public class MonoActivityFoodDelivery : MonoBehaviour // TypeDefIndex: 31162
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _title; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _timeDate; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtDesc; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _unlockDesc; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _lockedHintTrans; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _order_1; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _order_2; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _order_3; // 0x58
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private Animator _rewardAtor; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _rewardItem; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _rewardHint; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _rewardProgress; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _takeReward; // 0x80
		private FOOD_DELIVERY_REWARD_STATE _rewardState; // 0x88
		private int TriggerHash; // 0x8C
	
		// Properties
		public MonoUIContainer btnExit { /* [XID] */ /* 0x00000001898E4FB0-0x00000001898E4FD0 */ get => default; } // 0x000000018631AEE0-0x000000018631AFA0 
		public MonoUIContainer btnBack { /* [XID] */ /* 0x00000001898EC860-0x00000001898EC880 */ get => default; } // 0x000000018631AD60-0x000000018631AE20 
		public MonoUIContainer btnOk { /* [XID] */ /* 0x00000001898F4270-0x00000001898F4290 */ get => default; } // 0x000000018631AFA0-0x000000018631B060 
		public MonoUIContainer btnDesc { /* [XID] */ /* 0x00000001898FB9C0-0x00000001898FB9E0 */ get => default; } // 0x000000018631AE20-0x000000018631AEE0 
		public MonoUIContainer recvDesc { /* [XID] */ /* 0x00000001899033D0-0x00000001899033F0 */ get => default; } // 0x000000018631B1C0-0x000000018631B280 
		public MonoUIContainer checkDesc { /* [XID] */ /* 0x000000018990A920-0x000000018990A940 */ get => default; } // 0x000000018631B060-0x000000018631B120 
		public string descText { /* [XID] */ /* 0x0000000189912570-0x0000000189912590 */ set {} } // 0x000000018631B470-0x000000018631B540
		public string timeDesc { /* [XID] */ /* 0x0000000189919E80-0x0000000189919EA0 */ set {} } // 0x000000018631B540-0x000000018631B610
		public string titleText { /* [XID] */ /* 0x00000001899216C0-0x00000001899216E0 */ set {} } // 0x000000018631B610-0x000000018631B6E0
		public string unlockText { /* [XID] */ /* 0x0000000189928DE0-0x0000000189928E00 */ set {} } // 0x000000018631B6E0-0x000000018631B7B0
		public Transform reward { /* [XID] */ /* 0x0000000189930310-0x0000000189930330 */ get => default; } // 0x000000018631B320-0x000000018631B3C0 
		public UnityEngine.UI.Text hintProgress { /* [XID] */ /* 0x00000001899377D0-0x00000001899377F0 */ get => default; } // 0x000000018631B120-0x000000018631B1C0 
		public UnityEngine.UI.Text rewardProgress { /* [XID] */ /* 0x000000018993F2F0-0x000000018993F310 */ get => default; } // 0x000000018631B280-0x000000018631B320 
		public Button takeReward { /* [XID] */ /* 0x00000001899468C0-0x00000001899468E0 */ get => default; } // 0x000000018631B3C0-0x000000018631B470 
		public FOOD_DELIVERY_REWARD_STATE RewardState { /* [XID] */ /* 0x000000018994DF60-0x000000018994DF80 */ get => default; } // 0x000000018631ACC0-0x000000018631AD60 
	
		// Constructors
		public MonoActivityFoodDelivery() {} // 0x000000018631AC00-0x000000018631ACC0
	
		// Methods
		// [XID] // 0x00000001899555E0-0x0000000189955600
		public void SetOpenState(bool isOpen) {} // 0x000000018631A9F0-0x000000018631AAF0
		// [XID] // 0x000000018995D0A0-0x000000018995D0C0
		public MonoUIContainer GetOrder(int index) => default; // 0x000000018631A8F0-0x000000018631A9F0
		// [XID] // 0x0000000189964740-0x0000000189964760
		public void SetRewardState(FOOD_DELIVERY_REWARD_STATE state) {} // 0x000000018631AAF0-0x000000018631AC00
	}
}
