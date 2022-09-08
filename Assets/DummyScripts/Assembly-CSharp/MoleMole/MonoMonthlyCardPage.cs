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
	public class MonoMonthlyCardPage : MonoUIProxy // TypeDefIndex: 30841
	{
		// Fields
		// [Range] // 0x0000000189AF0EB0-0x0000000189AF0EF0
		[SerializeField] // 0x0000000189AF0EB0-0x0000000189AF0EF0
		private float _rewardFetchDuration; // 0x40
		// [Range] // 0x0000000189A1E420-0x0000000189A1E460
		[SerializeField] // 0x0000000189A1E420-0x0000000189A1E460
		private float _doubleClickTime; // 0x44
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _remainDaysText; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _rewardItemList; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _skipTips; // 0x60
	
		// Properties
		public float rewardFetchDuration { /* [XID] */ /* 0x0000000189B23630-0x0000000189B23650 */ get => default; } // 0x0000000182F17CB0-0x0000000182F17D60 
		public float doubleClickTime { /* [XID] */ /* 0x0000000189B2A870-0x0000000189B2A890 */ get => default; } // 0x0000000182F17A80-0x0000000182F17B30 
		public int remainDays { /* [XID] */ /* 0x0000000189B31DE0-0x0000000189B31E00 */ set {} } // 0x0000000182F180A0-0x0000000182F181E0
		public MonoSimpleReusableList rewardItemList { /* [XID] */ /* 0x0000000189B395E0-0x0000000189B39600 */ get => default; } // 0x0000000182F17D60-0x0000000182F17E00 
		public MonoUIContainer fetchBtn { /* [XID] */ /* 0x0000000189B40F10-0x0000000189B40F30 */ get => default; } // 0x0000000182F17B30-0x0000000182F17BF0 
		public MonoUIContainer checkBtn { /* [XID] */ /* 0x0000000189B48860-0x0000000189B48880 */ get => default; } // 0x0000000182F179C0-0x0000000182F17A80 
		public MonoUIContainer okBtn { /* [XID] */ /* 0x0000000189B4FFD0-0x0000000189B4FFF0 */ get => default; } // 0x0000000182F17BF0-0x0000000182F17CB0 
		public MonoUIContainer skipBtn { /* [XID] */ /* 0x0000000189B577C0-0x0000000189B577E0 */ get => default; } // 0x0000000182F17FE0-0x0000000182F180A0 
		public MonoMaskController skipBtnMask { /* [XID] */ /* 0x0000000189B5F130-0x0000000189B5F150 */ get => default; } // 0x0000000182F17E00-0x0000000182F17FE0 
		public bool showSkipTips { /* [XID] */ /* 0x0000000189B66700-0x0000000189B66720 */ set {} } // 0x0000000182F181E0-0x0000000182F182D0
	
		// Constructors
		public MonoMonthlyCardPage() {} // 0x0000000182F17940-0x0000000182F179C0
	}
}
