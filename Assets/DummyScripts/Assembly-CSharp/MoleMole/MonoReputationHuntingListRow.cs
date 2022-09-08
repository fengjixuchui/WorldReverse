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
	public class MonoReputationHuntingListRow : MonoBehaviour // TypeDefIndex: 31023
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoReputationHunting _huntingpanel; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _reputationValue; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _reputationIcon; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _detailBtn; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _fetchBtn; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _rewardGrp; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _noRewardGrp; // 0x48
	
		// Properties
		public MonoReputationHunting huntingPanel { /* [XID] */ /* 0x0000000189706EF0-0x0000000189706F10 */ get => default; } // 0x0000000184437AF0-0x0000000184437B90 
		public string reputationValue { /* [XID] */ /* 0x000000018970E7F0-0x000000018970E810 */ set {} } // 0x0000000184437C30-0x0000000184437D00
		public Image reputationIcon { /* [XID] */ /* 0x0000000189715C20-0x0000000189715C40 */ get => default; } // 0x0000000184437B90-0x0000000184437C30 
		public Button detailBtn { /* [XID] */ /* 0x000000018971D660-0x000000018971D680 */ get => default; } // 0x00000001844379B0-0x0000000184437A50 
		public MonoUIContainer fetchBtn { /* [XID] */ /* 0x0000000189724A30-0x0000000189724A50 */ get => default; } // 0x0000000184437A50-0x0000000184437AF0 
		public bool showReward { /* [XID] */ /* 0x000000018972C280-0x000000018972C2A0 */ set {} } // 0x0000000184437E30-0x0000000184437F40
		public RewardState rewardState { /* [XID] */ /* 0x0000000189733940-0x0000000189733960 */ set {} } // 0x0000000184437D00-0x0000000184437E30
	
		// Constructors
		public MonoReputationHuntingListRow() {} // 0x0000000184437930-0x00000001844379B0
	}
}
