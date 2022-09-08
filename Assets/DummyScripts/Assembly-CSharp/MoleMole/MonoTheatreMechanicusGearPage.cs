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
	public class MonoTheatreMechanicusGearPage : MonoUIProxy // TypeDefIndex: 31317
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _gearScroller; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _gearIcon; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _gearName; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _gearDesc; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoLevelUpItem _monoLevelItem; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Animator _gearLevelEffect1; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Animator _gearLevelEffect2; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _gearLevelEffectText1; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _gearLevelEffectText2; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private List<MonoMechanicusGearPropItem> _propItemList; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _unlockTipsGrp; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _unlockTipsText; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _effectGrp1; // 0xA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _effectGrp2; // 0xB0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _coinRoot; // 0xB8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _costCount; // 0xC0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _costGrp; // 0xC8
		private bool _unlocked; // 0xD0
	
		// Properties
		public Transform coinRoot { /* [XID] */ /* 0x00000001895E57C0-0x00000001895E57E0 */ get => default; } // 0x0000000183B6EB00-0x0000000183B6EBB0 
		public UnityEngine.UI.Text costCount { /* [XID] */ /* 0x00000001895ED110-0x00000001895ED130 */ get => default; } // 0x0000000183B6EBB0-0x0000000183B6EC60 
		public GameObject costGrp { /* [XID] */ /* 0x00000001895F47B0-0x00000001895F47D0 */ get => default; } // 0x0000000183B6EC60-0x0000000183B6ED10 
		public List<MonoMechanicusGearPropItem> propItemList { /* [XID] */ /* 0x00000001895FBF60-0x00000001895FBF80 */ get => default; } // 0x0000000183B6EEF0-0x0000000183B6EFA0 
		public string unlockTipsText { /* [XID] */ /* 0x00000001896039A0-0x00000001896039C0 */ set {} } // 0x0000000183B6F410-0x0000000183B6F4F0
		public bool showUnlockTips { /* [XID] */ /* 0x000000018960B300-0x000000018960B320 */ set {} } // 0x0000000183B6F320-0x0000000183B6F410
		public MonoGridScroller gearScroller { /* [XID] */ /* 0x00000001896126B0-0x00000001896126D0 */ get => default; } // 0x0000000183B6EDB0-0x0000000183B6EE50 
		public string gearName { /* [XID] */ /* 0x0000000189619FF0-0x000000018961A010 */ set {} } // 0x0000000183B6F240-0x0000000183B6F320
		public string gearDesc { /* [XID] */ /* 0x0000000189621530-0x0000000189621550 */ set {} } // 0x0000000183B6F160-0x0000000183B6F240
		public Image gearIcon { /* [XID] */ /* 0x0000000189628E40-0x0000000189628E60 */ get => default; } // 0x0000000183B6ED10-0x0000000183B6EDB0 
		public MonoLevelUpItem monoLevelItem { /* [XID] */ /* 0x00000001896307C0-0x00000001896307E0 */ get => default; } // 0x0000000183B6EE50-0x0000000183B6EEF0 
		public MonoUIContainer BtnReturn { /* [XID] */ /* 0x0000000189638260-0x0000000189638280 */ get => default; } // 0x0000000183B6E8C0-0x0000000183B6E980 
		public MonoUIContainer BtnUnlock { /* [XID] */ /* 0x000000018963F640-0x000000018963F660 */ get => default; } // 0x0000000183B6E980-0x0000000183B6EA40 
		public MonoUIContainer BtnUpgrade { /* [XID] */ /* 0x0000000189646DB0-0x0000000189646DD0 */ get => default; } // 0x0000000183B6EA40-0x0000000183B6EB00 
		public bool ShowEffectGrp1 { /* [XID] */ /* 0x000000018965D560-0x000000018965D580 */ set {} } // 0x0000000183B6EFA0-0x0000000183B6F080
		public bool ShowEffectGrp2 { /* [XID] */ /* 0x0000000189664C80-0x0000000189664CA0 */ set {} } // 0x0000000183B6F080-0x0000000183B6F160
	
		// Constructors
		public MonoTheatreMechanicusGearPage() {} // 0x0000000183B6E7F0-0x0000000183B6E8C0
	
		// Methods
		// [XID] // 0x000000018964E570-0x000000018964E590
		public void SetLevel(uint preLevel, uint nextLevel = 0 /* Metadata: 0x00B12179 */) {} // 0x0000000183B6E710-0x0000000183B6E7F0
		// [XID] // 0x0000000189655DA0-0x0000000189655DC0
		public void SetGearLevelEffect(uint index, string effectDesc, bool unLocked, uint effectLevel) {} // 0x0000000183B6E270-0x0000000183B6E710
		// [XID] // 0x000000018966C280-0x000000018966C2A0
		private void OnEnable() {} // 0x0000000183B6E1A0-0x0000000183B6E270
	}
}
