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
	public class MonoElderTreeRewardListRow : MonoBehaviour // TypeDefIndex: 30751
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
		public bool ShowDesc { /* [XID] */ /* 0x0000000189B219F0-0x0000000189B21A10 */ set {} } // 0x0000000183CA07F0-0x0000000183CA08E0
		public Button descBtn { /* [XID] */ /* 0x0000000189B291A0-0x0000000189B291C0 */ get => default; } // 0x0000000183CA0570-0x0000000183CA0610 
		public Image descIcon { /* [XID] */ /* 0x0000000189B30550-0x0000000189B30570 */ get => default; } // 0x0000000183CA0610-0x0000000183CA06B0 
		public MonoUIContainer fetchBtn { /* [XID] */ /* 0x0000000189B37E70-0x0000000189B37E90 */ get => default; } // 0x0000000183CA06B0-0x0000000183CA0750 
		public MonoSimpleReusableList rewardList { /* [XID] */ /* 0x0000000189B3F7E0-0x0000000189B3F800 */ get => default; } // 0x0000000183CA0750-0x0000000183CA07F0 
		public string levelText { /* [XID] */ /* 0x0000000189B47100-0x0000000189B47120 */ set {} } // 0x0000000183CA09B0-0x0000000183CA0A80
		public string descText { /* [XID] */ /* 0x0000000189B4E800-0x0000000189B4E820 */ set {} } // 0x0000000183CA08E0-0x0000000183CA09B0
		public RewardState rewardState { /* [XID] */ /* 0x0000000189B56060-0x0000000189B56080 */ set {} } // 0x0000000183CA0A80-0x0000000183CA0CF0
	
		// Constructors
		public MonoElderTreeRewardListRow() {} // 0x0000000183CA04E0-0x0000000183CA0570
	}
}
