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
	public class MonoHideandSeekPreviewMapDialog : MonoUIProxy // TypeDefIndex: 29726
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _mapName; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _mapDesc; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _mapIcon; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _lockGrp; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoReusableList _tabPanel; // 0x68
	
		// Properties
		public MonoReusableList tabPanel { /* [XID] */ /* 0x0000000189745C80-0x0000000189745CA0 */ get => default; } // 0x0000000184B5E4D0-0x0000000184B5E570 
		public Image mapIcon { /* [XID] */ /* 0x000000018974D730-0x000000018974D750 */ get => default; } // 0x0000000184B5E430-0x0000000184B5E4D0 
		public string mapName { /* [XID] */ /* 0x0000000189754D70-0x0000000189754D90 */ set {} } // 0x0000000184B5E650-0x0000000184B5E730
		public string mapDesc { /* [XID] */ /* 0x000000018975BF60-0x000000018975BF80 */ set {} } // 0x0000000184B5E570-0x0000000184B5E650
		public bool showLockGrp { /* [XID] */ /* 0x00000001897638D0-0x00000001897638F0 */ set {} } // 0x0000000184B5E730-0x0000000184B5E820
		public MonoUIContainer BtnClose { /* [XID] */ /* 0x000000018976B0B0-0x000000018976B0D0 */ get => default; } // 0x0000000184B5E1F0-0x0000000184B5E2B0 
		public MonoUIContainer BtnSwitchPrev { /* [XID] */ /* 0x0000000189772700-0x0000000189772720 */ get => default; } // 0x0000000184B5E370-0x0000000184B5E430 
		public MonoUIContainer BtnSwitchNext { /* [XID] */ /* 0x0000000189779D30-0x0000000189779D50 */ get => default; } // 0x0000000184B5E2B0-0x0000000184B5E370 
	
		// Constructors
		public MonoHideandSeekPreviewMapDialog() {} // 0x0000000184B5E170-0x0000000184B5E1F0
	}
}
