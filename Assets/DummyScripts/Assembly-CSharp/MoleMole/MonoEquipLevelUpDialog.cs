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
	public class MonoEquipLevelUpDialog : MonoBehaviour // TypeDefIndex: 30541
	{
		// Fields
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private RectTransform _propertyItemContainer; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _powerUpText; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _powerUpLight; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject[] _powerUpLightArray; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image[] _bgImgs; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ParticleSystem[] _particles; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _iconRoot; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _itemIconPrefab; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ScrollRect _scroller; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x60
		public float protectTime; // 0x68
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public GameObject itemIcon; // 0x70
		private List<MonoAvatarPropertyItem> _propertyItemList; // 0x78
	
		// Properties
		public Button okButton { /* [XID] */ /* 0x00000001898185F0-0x0000000189818610 */ get => default; } // 0x0000000183CAA1C0-0x0000000183CAA2E0 
		public List<MonoAvatarPropertyItem> propertyItemList { /* [XID] */ /* 0x000000018981FE40-0x000000018981FE60 */ get => default; } // 0x0000000183CAA600-0x0000000183CAA6A0 
		public RectTransform propertyItemContainer { /* [XID] */ /* 0x0000000189827420-0x0000000189827440 */ get => default; } // 0x0000000183CAA560-0x0000000183CAA600 
		public UnityEngine.UI.Text powerUpText { /* [XID] */ /* 0x000000018982E6A0-0x000000018982E6C0 */ get => default; } // 0x0000000183CAA4C0-0x0000000183CAA560 
		public GameObject powerUpLight { /* [XID] */ /* 0x0000000189836020-0x0000000189836040 */ get => default; } // 0x0000000183CAA420-0x0000000183CAA4C0 
		public GameObject[] powerUpLightArray { /* [XID] */ /* 0x000000018983D530-0x000000018983D550 */ get => default; } // 0x0000000183CAA380-0x0000000183CAA420 
		public Image[] bgImgs { /* [XID] */ /* 0x0000000189844D70-0x0000000189844D90 */ get => default; } // 0x0000000183CA9FE0-0x0000000183CAA080 
		public ParticleSystem[] particles { /* [XID] */ /* 0x000000018984C180-0x000000018984C1A0 */ get => default; } // 0x0000000183CAA2E0-0x0000000183CAA380 
		public GameObject itemIconPrefab { /* [XID] */ /* 0x0000000189853350-0x0000000189853370 */ get => default; } // 0x0000000183CAA120-0x0000000183CAA1C0 
		public Transform iconRoot { /* [XID] */ /* 0x000000018985ADE0-0x000000018985AE00 */ get => default; } // 0x0000000183CAA080-0x0000000183CAA120 
		public ScrollRect scroller { /* [XID] */ /* 0x00000001898622A0-0x00000001898622C0 */ get => default; } // 0x0000000183CAA6A0-0x0000000183CAA740 
	
		// Constructors
		public MonoEquipLevelUpDialog() {} // 0x0000000183CA9F30-0x0000000183CA9FE0
	}
}
