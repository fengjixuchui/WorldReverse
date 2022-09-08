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
	internal class MonoFleurFairMiniGameRewardListRow : MonoBehaviour // TypeDefIndex: 30384
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Animator _animator; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _title; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _desc; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _completeMask; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _itemList; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoFleurFairMiniGameRewardBtn _rewardBtn; // 0x40
		private bool _hightlighted; // 0x48
	
		// Properties
		public UnityEngine.UI.Text title { /* [XID] */ /* 0x000000018988E0D0-0x000000018988E0F0 */ get => default; } // 0x0000000184ADCB40-0x0000000184ADCBE0 
		public UnityEngine.UI.Text desc { /* [XID] */ /* 0x0000000189895720-0x0000000189895740 */ get => default; } // 0x0000000184ADC8C0-0x0000000184ADC960 
		public MonoSimpleReusableList itemList { /* [XID] */ /* 0x000000018989CE80-0x000000018989CEA0 */ get => default; } // 0x0000000184ADCA00-0x0000000184ADCAA0 
		public MonoFleurFairMiniGameRewardBtn rewardBtn { /* [XID] */ /* 0x00000001898A4640-0x00000001898A4660 */ get => default; } // 0x0000000184ADCAA0-0x0000000184ADCB40 
		public bool highlight { /* [XID] */ /* 0x00000001898BAFB0-0x00000001898BAFD0 */ get => default; /* [XID] */ /* 0x00000001898C2320-0x00000001898C2340 */ set {} } // 0x0000000184ADC960-0x0000000184ADCA00 0x0000000184ADCBE0-0x0000000184ADCD80
	
		// Constructors
		public MonoFleurFairMiniGameRewardListRow() {} // 0x0000000184ADC840-0x0000000184ADC8C0
	
		// Methods
		// [XID] // 0x00000001898ABB00-0x00000001898ABB20
		public void SetCompleted(bool bDone) {} // 0x0000000184ADC660-0x0000000184ADC740
		// [XID] // 0x00000001898B32B0-0x00000001898B32D0
		public void SetSelectedState(bool selected) {} // 0x0000000184ADC740-0x0000000184ADC840
	}
}
