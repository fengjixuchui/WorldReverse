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
	public class MonoEquipAwaken : MonoBehaviour // TypeDefIndex: 30754
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _affixScrollerRoot; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _awakenNeedScroller; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _selectPanel; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _maxTip; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _maxTipText; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _awakenLevelText; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _awakenEffectTime; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Animator _awakenAnimator; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ScrollRect _affixScrollRect; // 0x58
		private List<MonoAwakenAffixItem> _awakenAffixItemList; // 0x60
	
		// Properties
		public Transform affixScrollerRoot { /* [XID] */ /* 0x00000001895F7BF0-0x00000001895F7C10 */ get => default; } // 0x0000000183CA9980-0x0000000183CA9A20 
		public MonoGridScroller awakenNeedScroller { /* [XID] */ /* 0x00000001895FEF30-0x00000001895FEF50 */ get => default; } // 0x0000000183CA9CB0-0x0000000183CA9D50 
		public GameObject selectPanel { /* [XID] */ /* 0x0000000189606790-0x00000001896067B0 */ get => default; } // 0x0000000183CA9E90-0x0000000183CA9F30 
		public GameObject maxTip { /* [XID] */ /* 0x000000018960E130-0x000000018960E150 */ get => default; } // 0x0000000183CA9DF0-0x0000000183CA9E90 
		public UnityEngine.UI.Text maxTipText { /* [XID] */ /* 0x00000001896157A0-0x00000001896157C0 */ get => default; } // 0x0000000183CA9D50-0x0000000183CA9DF0 
		public UnityEngine.UI.Text awakenLevelText { /* [XID] */ /* 0x000000018961CF80-0x000000018961CFA0 */ get => default; } // 0x0000000183CA9C10-0x0000000183CA9CB0 
		public float awakenEffectTime { /* [XID] */ /* 0x00000001896244D0-0x00000001896244F0 */ get => default; } // 0x0000000183CA9B60-0x0000000183CA9C10 
		public List<MonoAwakenAffixItem> awakenAffixItemList { /* [XID] */ /* 0x000000018962BB80-0x000000018962BBA0 */ get => default; } // 0x0000000183CA9A20-0x0000000183CA9AC0 
		public Animator awakenAnimator { /* [XID] */ /* 0x00000001896336F0-0x0000000189633710 */ get => default; } // 0x0000000183CA9AC0-0x0000000183CA9B60 
		public ScrollRect affixScrollRect { /* [XID] */ /* 0x000000018963AF90-0x000000018963AFB0 */ get => default; } // 0x0000000183CA98E0-0x0000000183CA9980 
	
		// Constructors
		public MonoEquipAwaken() {} // 0x0000000183CA9820-0x0000000183CA98E0
	}
}
