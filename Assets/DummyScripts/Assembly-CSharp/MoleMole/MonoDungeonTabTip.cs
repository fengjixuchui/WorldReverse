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
	public class MonoDungeonTabTip : MonoReusableListItem // TypeDefIndex: 31206
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Toggle _toggle; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _toggleOnIcon; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _toggleOffIcon; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _toggleFinishIcon; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _icon; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _title; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _desc; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoReusableList _rewardList; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _rewardTitle; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _levelLabel; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _name; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _grpDesc; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _grpExplored; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoReusableList _rewardToBeExploredList; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _exploreTips; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _rewardTitleToBeExplored; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _descToBeExplored; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _lockIcon; // 0xA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _lockDescTip; // 0xB0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _lockDescTipText; // 0xB8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _grpBossTips; // 0xC0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoReusableList _bossList; // 0xC8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _bossTitle; // 0xD0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _bossDesc; // 0xD8
		private ToggleState _state; // 0xE0
	
		// Properties
		private bool toggle { /* [XID] */ /* 0x00000001897FA7F0-0x00000001897FA810 */ get => default; /* [XID] */ /* 0x0000000189801E60-0x0000000189801E80 */ set {} } // 0x0000000184694230-0x00000001846942E0 0x00000001846940C0-0x0000000184694190
		public GameObject finishIcon { /* [XID] */ /* 0x000000018981FD30-0x000000018981FD50 */ get => default; } // 0x0000000184694EC0-0x0000000184694F60 
		public Sprite icon { /* [XID] */ /* 0x00000001898273C0-0x00000001898273E0 */ set {} } // 0x0000000184695600-0x00000001846956C0
		public string title { /* [XID] */ /* 0x000000018982E600-0x000000018982E620 */ set {} } // 0x0000000184695B10-0x0000000184695BE0
		public UnityEngine.UI.Text desc { /* [XID] */ /* 0x0000000189835FA0-0x0000000189835FC0 */ get => default; } // 0x0000000184694D70-0x0000000184694E10 
		public MonoReusableList rewardList { /* [XID] */ /* 0x000000018983D490-0x000000018983D4B0 */ get => default; } // 0x0000000184695360-0x0000000184695400 
		public UnityEngine.UI.Text rewardTitle { /* [XID] */ /* 0x0000000189844CD0-0x0000000189844CF0 */ get => default; } // 0x00000001846954B0-0x0000000184695550 
		public string levelText { /* [XID] */ /* 0x000000018984C0C0-0x000000018984C0E0 */ set {} } // 0x00000001846956C0-0x0000000184695790
		public UnityEngine.UI.Text levelLabel { /* [XID] */ /* 0x0000000189853210-0x0000000189853230 */ get => default; } // 0x0000000184695010-0x00000001846950B0 
		public Color selectedHintColor { /* [XID] */ /* 0x000000018985AD20-0x000000018985AD40 */ set {} } // 0x0000000184695790-0x0000000184695870
		public bool showName { /* [XID] */ /* 0x00000001898621E0-0x0000000189862200 */ set {} } // 0x0000000184695950-0x0000000184695A30
		public bool showDesc { /* [XID] */ /* 0x0000000189869650-0x0000000189869670 */ set {} } // 0x0000000184695870-0x0000000184695950
		public bool showToBeExplored { /* [XID] */ /* 0x0000000189870890-0x00000001898708B0 */ set {} } // 0x0000000184695A30-0x0000000184695B10
		public MonoReusableList rewardToBeExploredList { /* [XID] */ /* 0x0000000189878320-0x0000000189878340 */ get => default; } // 0x0000000184695550-0x0000000184695600 
		public UnityEngine.UI.Text exploreTips { /* [XID] */ /* 0x000000018987F7F0-0x000000018987F810 */ get => default; } // 0x0000000184694E10-0x0000000184694EC0 
		public UnityEngine.UI.Text rewardTitleToBeExplored { /* [XID] */ /* 0x0000000189886E80-0x0000000189886EA0 */ get => default; } // 0x0000000184695400-0x00000001846954B0 
		public UnityEngine.UI.Text descToBeExplored { /* [XID] */ /* 0x000000018988DFC0-0x000000018988DFE0 */ get => default; } // 0x0000000184694CC0-0x0000000184694D70 
		public RectTransform lockIcon { /* [XID] */ /* 0x00000001898A4560-0x00000001898A4580 */ get => default; } // 0x00000001846950B0-0x0000000184695160 
		public RectTransform lockTip { /* [XID] */ /* 0x00000001898AB9F0-0x00000001898ABA10 */ get => default; } // 0x0000000184695210-0x00000001846952C0 
		public UnityEngine.UI.Text lockTipText { /* [XID] */ /* 0x00000001898B31B0-0x00000001898B31D0 */ get => default; } // 0x0000000184695160-0x0000000184695210 
		public RectTransform nameTransform { /* [XID] */ /* 0x00000001898BAEF0-0x00000001898BAF10 */ get => default; } // 0x00000001846952C0-0x0000000184695360 
		public RectTransform grpBossTips { /* [XID] */ /* 0x00000001898C2220-0x00000001898C2240 */ get => default; } // 0x0000000184694F60-0x0000000184695010 
		public MonoReusableList bossList { /* [XID] */ /* 0x00000001898C9CC0-0x00000001898C9CE0 */ get => default; } // 0x0000000184694B60-0x0000000184694C10 
		public UnityEngine.UI.Text bossTitle { /* [XID] */ /* 0x00000001898D12C0-0x00000001898D12E0 */ get => default; } // 0x0000000184694C10-0x0000000184694CC0 
		public UnityEngine.UI.Text bossDesc { /* [XID] */ /* 0x00000001898D8B30-0x00000001898D8B50 */ get => default; } // 0x0000000184694AB0-0x0000000184694B60 
	
		// Nested types
		public enum ToggleState // TypeDefIndex: 31207
		{
			On = 0,
			Off = 1,
			Finish = 2
		}
	
		// Constructors
		public MonoDungeonTabTip() {} // 0x00000001846949C0-0x0000000184694AB0
	
		// Methods
		// [XID] // 0x0000000189809290-0x00000001898092B0
		public void SetToggleState(ToggleState state) {} // 0x0000000184694470-0x00000001846947A0
		// [XID] // 0x0000000189810B40-0x0000000189810B60
		public ToggleState GetToggleState() => default; // 0x0000000184694190-0x0000000184694230
		// [XID] // 0x0000000189818570-0x0000000189818590
		public void ReverseToggleState() {} // 0x00000001846943A0-0x0000000184694470
		// [XID] // 0x0000000189895660-0x0000000189895680
		public void ToHighlighted() {} // 0x00000001846947A0-0x00000001846948B0
		// [XID] // 0x000000018989CDA0-0x000000018989CDC0
		public void ToNormal() {} // 0x00000001846948B0-0x00000001846949C0
	}
}
