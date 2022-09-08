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
	public class MonoReputationExploreListRow : MonoBehaviour // TypeDefIndex: 31021
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoJoypadSimpleResuableListHandler _joypadHandler; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _rewardList; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _title; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _fetchBtn; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _grpUnable; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _grpCompleted; // 0x40
	
		// Properties
		public MonoUIContainer fetchBtn { /* [XID] */ /* 0x0000000189651490-0x00000001896514B0 */ get => default; } // 0x0000000184436E70-0x0000000184436F10 
		public string title { /* [XID] */ /* 0x0000000189658C30-0x0000000189658C50 */ set {} } // 0x0000000184437270-0x0000000184437340
		public MonoJoypadSimpleResuableListHandler joypadHandler { /* [XID] */ /* 0x0000000189660380-0x00000001896603A0 */ get => default; } // 0x0000000184436F10-0x0000000184436FB0 
		public MonoSimpleReusableList rewardList { /* [XID] */ /* 0x0000000189667D40-0x0000000189667D60 */ get => default; } // 0x0000000184436FB0-0x0000000184437050 
		public RewardState rewardState { /* [XID] */ /* 0x000000018966F7B0-0x000000018966F7D0 */ set {} } // 0x0000000184437050-0x0000000184437270
	
		// Constructors
		public MonoReputationExploreListRow() {} // 0x0000000184436DF0-0x0000000184436E70
	}
}
