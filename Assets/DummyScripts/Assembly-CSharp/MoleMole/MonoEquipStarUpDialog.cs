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
	public class MonoEquipStarUpDialog : MonoBehaviour // TypeDefIndex: 30543
	{
		// Fields
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private RectTransform _propertyItemContainer; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoStarRate _starRate; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image[] _bgImgs; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ParticleSystem[] _particles; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _iconRoot; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _itemIconPrefab; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ScrollRect _scroller; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x50
		public float protectTime; // 0x58
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public GameObject itemIcon; // 0x60
		private List<MonoAvatarPropertyItem> _propertyItemList; // 0x68
	
		// Properties
		public Button okButton { /* [XID] */ /* 0x0000000189972400-0x0000000189972420 */ get => default; } // 0x000000018561BF60-0x000000018561C080 
		public RectTransform propertyItemContainer { /* [XID] */ /* 0x0000000189979BE0-0x0000000189979C00 */ get => default; } // 0x000000018561C120-0x000000018561C1C0 
		public MonoStarRate star { /* [XID] */ /* 0x0000000189981410-0x0000000189981430 */ get => default; } // 0x000000018561C300-0x000000018561C3A0 
		public List<MonoAvatarPropertyItem> propertyItemList { /* [XID] */ /* 0x0000000189988BE0-0x0000000189988C00 */ get => default; } // 0x000000018561C1C0-0x000000018561C260 
		public Image[] bgImgs { /* [XID] */ /* 0x0000000189990380-0x00000001899903A0 */ get => default; } // 0x000000018561BD80-0x000000018561BE20 
		public ParticleSystem[] particles { /* [XID] */ /* 0x0000000189997F70-0x0000000189997F90 */ get => default; } // 0x000000018561C080-0x000000018561C120 
		public GameObject itemIconPrefab { /* [XID] */ /* 0x000000018999F650-0x000000018999F670 */ get => default; } // 0x000000018561BEC0-0x000000018561BF60 
		public Transform iconRoot { /* [XID] */ /* 0x00000001899A7190-0x00000001899A71B0 */ get => default; } // 0x000000018561BE20-0x000000018561BEC0 
		public ScrollRect scroller { /* [XID] */ /* 0x00000001899AEB00-0x00000001899AEB20 */ get => default; } // 0x000000018561C260-0x000000018561C300 
	
		// Constructors
		public MonoEquipStarUpDialog() {} // 0x000000018561BD00-0x000000018561BD80
	
		// Methods
		// [XID] // 0x000000018996A6C0-0x000000018996A6E0
		private void Awake() {} // 0x000000018561BC30-0x000000018561BD00
	}
}
