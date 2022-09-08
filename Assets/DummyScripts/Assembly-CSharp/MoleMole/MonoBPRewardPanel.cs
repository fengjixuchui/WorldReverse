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
	public class MonoBPRewardPanel : MonoBehaviour // TypeDefIndex: 30713
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _rewardScroller; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoBPRewardItem _lastRewardItem; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _paidRewardLockImg; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _paidRewardBtn; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _prevIcon; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _nextIcon; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Animator _paidUnlockAnim; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _unlockAnimDuration; // 0x50
		// [Header] // 0x000000018999F620-0x000000018999F650
		public bool playUnlockAnimOnRefresh; // 0x54
	
		// Properties
		public MonoGridScroller rewardScroller { /* [XID] */ /* 0x00000001899A8A50-0x00000001899A8A70 */ get => default; } // 0x00000001847FA0E0-0x00000001847FA180 
		public MonoBPRewardItem lastRewardItem { /* [XID] */ /* 0x00000001899B0370-0x00000001899B0390 */ get => default; } // 0x00000001847F9D20-0x00000001847F9DC0 
		public GameObject paidRewardLockImg { /* [XID] */ /* 0x00000001899B76E0-0x00000001899B7700 */ get => default; } // 0x00000001847F9F00-0x00000001847F9FA0 
		public Button paidRewardBtn { /* [XID] */ /* 0x00000001899BF0C0-0x00000001899BF0E0 */ get => default; } // 0x00000001847F9E60-0x00000001847F9F00 
		public GameObject prevIcon { /* [XID] */ /* 0x00000001899C6A60-0x00000001899C6A80 */ get => default; } // 0x00000001847FA040-0x00000001847FA0E0 
		public GameObject nextIcon { /* [XID] */ /* 0x00000001899CE000-0x00000001899CE020 */ get => default; } // 0x00000001847F9DC0-0x00000001847F9E60 
		public Animator paidUnlockAnim { /* [XID] */ /* 0x00000001899D5760-0x00000001899D5780 */ get => default; } // 0x00000001847F9FA0-0x00000001847FA040 
		public float unlockAnimDuration { /* [XID] */ /* 0x00000001899DCAF0-0x00000001899DCB10 */ get => default; } // 0x00000001847FA180-0x00000001847FA230 
	
		// Constructors
		public MonoBPRewardPanel() {} // 0x00000001847F9C90-0x00000001847F9D20
	}
}
