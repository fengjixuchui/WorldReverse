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
	public class MonoReputationRewardListRow : MonoBehaviour // TypeDefIndex: 30884
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _rewardList; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _descObj; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _descIcon; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _descBtn; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _levelText; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _descText; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _grpUnable; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _grpCompleted; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _fetchBtn; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _completeMask; // 0x60
	
		// Properties
		public bool ShowDesc { /* [XID] */ /* 0x000000018963F6E0-0x000000018963F700 */ set {} } // 0x000000018443EAD0-0x000000018443EBC0
		public Button descBtn { /* [XID] */ /* 0x0000000189646EC0-0x0000000189646EE0 */ get => default; } // 0x000000018443E850-0x000000018443E8F0 
		public Image descIcon { /* [XID] */ /* 0x000000018964E630-0x000000018964E650 */ get => default; } // 0x000000018443E8F0-0x000000018443E990 
		public MonoUIContainer fetchBtn { /* [XID] */ /* 0x0000000189655E20-0x0000000189655E40 */ get => default; } // 0x000000018443E990-0x000000018443EA30 
		public MonoSimpleReusableList rewardList { /* [XID] */ /* 0x000000018965D600-0x000000018965D620 */ get => default; } // 0x000000018443EA30-0x000000018443EAD0 
		public string levelText { /* [XID] */ /* 0x0000000189664D20-0x0000000189664D40 */ set {} } // 0x000000018443EC90-0x000000018443ED60
		public string descText { /* [XID] */ /* 0x000000018966C320-0x000000018966C340 */ set {} } // 0x000000018443EBC0-0x000000018443EC90
		public RewardState rewardState { /* [XID] */ /* 0x00000001896741A0-0x00000001896741C0 */ set {} } // 0x000000018443ED60-0x000000018443EFD0
	
		// Constructors
		public MonoReputationRewardListRow() {} // 0x000000018443E7C0-0x000000018443E850
	}
}
