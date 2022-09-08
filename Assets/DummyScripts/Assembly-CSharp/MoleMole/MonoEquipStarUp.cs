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
	public class MonoEquipStarUp : MonoBehaviour // TypeDefIndex: 30759
	{
		// Fields
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private UnityEngine.UI.Text _currLevel; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _currMaxLevel; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _postLevel; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _postMaxLevel; // 0x30
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private MonoStarRate _starRate; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoStarRate _starAfterRate; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _weaponPropChangeScroller; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _weaponMainPropScroller; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _selectedMaterialScroller; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _avatarInfoAfter; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _changeIamge; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _weaponPanel; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _relicPanel; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _relicAffixScroller; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _relicMainPropScroller; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _relicBreakTip; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _relicBreakNeedScroller; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _weaponMaxTip; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _weaponMaxTipText; // 0xA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _weaponSelectPanel; // 0xB0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _relicMaxTip; // 0xB8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _relicMaxTipText; // 0xC0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _relicSelectPanel; // 0xC8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _breakThroughEffectTime; // 0xD0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Animator _starUpAnimator; // 0xD8
	
		// Properties
		public uint currLevel { /* [XID] */ /* 0x00000001898E0890-0x00000001898E08B0 */ set {} } // 0x0000000183CB2880-0x0000000183CB2990
		public uint breakLevel { /* [XID] */ /* 0x00000001898E83F0-0x00000001898E8410 */ set {} } // 0x0000000183CB27C0-0x0000000183CB2880
		public uint maxBreakLevel { /* [XID] */ /* 0x00000001898EFB20-0x00000001898EFB40 */ set {} } // 0x0000000183CB2A90-0x0000000183CB2B70
		public uint afterBreakLevel { /* [XID] */ /* 0x00000001898F73B0-0x00000001898F73D0 */ set {} } // 0x0000000183CB2700-0x0000000183CB27C0
		public uint currMaxLevel { /* [XID] */ /* 0x00000001898FEB20-0x00000001898FEB40 */ set {} } // 0x0000000183CB2990-0x0000000183CB2A90
		public uint postMaxLevel { /* [XID] */ /* 0x0000000189906260-0x0000000189906280 */ set {} } // 0x0000000183CB2B70-0x0000000183CB2C70
		public MonoGridScroller propertyChangeScroller { /* [XID] */ /* 0x000000018990DD20-0x000000018990DD40 */ get => default; } // 0x0000000183CB1BA0-0x0000000183CB1C40 
		public MonoGridScroller weaponMainPropScroller { /* [XID] */ /* 0x00000001899154B0-0x00000001899154D0 */ get => default; } // 0x0000000183CB23B0-0x0000000183CB2450 
		public MonoGridScroller selectedMaterialScroller { /* [XID] */ /* 0x000000018991CF00-0x000000018991CF20 */ get => default; } // 0x0000000183CB21B0-0x0000000183CB2250 
		public GameObject avatarInfoAfter { /* [XID] */ /* 0x0000000189924790-0x00000001899247B0 */ get => default; } // 0x0000000183CB19B0-0x0000000183CB1A50 
		public GameObject changeIamge { /* [XID] */ /* 0x000000018992BD40-0x000000018992BD60 */ get => default; } // 0x0000000183CB1B00-0x0000000183CB1BA0 
		public GameObject starAfterRate { /* [XID] */ /* 0x0000000189933270-0x0000000189933290 */ get => default; } // 0x0000000183CB2250-0x0000000183CB2300 
		public GameObject weaponPanel { /* [XID] */ /* 0x000000018993ADE0-0x000000018993AE00 */ get => default; } // 0x0000000183CB25B0-0x0000000183CB2650 
		public GameObject relicPanel { /* [XID] */ /* 0x0000000189941E30-0x0000000189941E50 */ get => default; } // 0x0000000183CB2060-0x0000000183CB2100 
		public MonoGridScroller relicAffixScroller { /* [XID] */ /* 0x0000000189949910-0x0000000189949930 */ get => default; } // 0x0000000183CB1C40-0x0000000183CB1CF0 
		public MonoGridScroller relicMainPropScroller { /* [XID] */ /* 0x0000000189951340-0x0000000189951360 */ get => default; } // 0x0000000183CB1E50-0x0000000183CB1F00 
		public UnityEngine.UI.Text relicBreakTip { /* [XID] */ /* 0x0000000189958930-0x0000000189958950 */ get => default; } // 0x0000000183CB1DA0-0x0000000183CB1E50 
		public MonoGridScroller relicBreakNeedScroller { /* [XID] */ /* 0x000000018995FFB0-0x000000018995FFD0 */ get => default; } // 0x0000000183CB1CF0-0x0000000183CB1DA0 
		public GameObject weaponMaxTip { /* [XID] */ /* 0x0000000189967A50-0x0000000189967A70 */ get => default; } // 0x0000000183CB2500-0x0000000183CB25B0 
		public UnityEngine.UI.Text weaponMaxTipText { /* [XID] */ /* 0x000000018996EBD0-0x000000018996EBF0 */ get => default; } // 0x0000000183CB2450-0x0000000183CB2500 
		public GameObject weaponSelectPanel { /* [XID] */ /* 0x00000001899767B0-0x00000001899767D0 */ get => default; } // 0x0000000183CB2650-0x0000000183CB2700 
		public GameObject relicMaxTip { /* [XID] */ /* 0x000000018997DBF0-0x000000018997DC10 */ get => default; } // 0x0000000183CB1FB0-0x0000000183CB2060 
		public UnityEngine.UI.Text relicMaxTipText { /* [XID] */ /* 0x00000001899855A0-0x00000001899855C0 */ get => default; } // 0x0000000183CB1F00-0x0000000183CB1FB0 
		public GameObject relicSelectPanel { /* [XID] */ /* 0x000000018998D390-0x000000018998D3B0 */ get => default; } // 0x0000000183CB2100-0x0000000183CB21B0 
		public float breakThroughEffectTime { /* [XID] */ /* 0x0000000189994E30-0x0000000189994E50 */ get => default; } // 0x0000000183CB1A50-0x0000000183CB1B00 
		public Animator starUpAnimator { /* [XID] */ /* 0x000000018999C6D0-0x000000018999C6F0 */ get => default; } // 0x0000000183CB2300-0x0000000183CB23B0 
	
		// Constructors
		public MonoEquipStarUp() {} // 0x0000000183CB18C0-0x0000000183CB19B0
	}
}
