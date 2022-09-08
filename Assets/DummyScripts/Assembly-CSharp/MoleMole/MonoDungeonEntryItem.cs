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
	public class MonoDungeonEntryItem : MonoBehaviour // TypeDefIndex: 30743
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _actionButton; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _icon; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _title; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoLocalizedText _typeLabel; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _levelRect; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _levelLabel; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _selectedHintGrp; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _randomInfo; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _randomButton; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _randomFactor; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _iconOnlineMatching; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _lockIcon; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _questIcon; // 0x78
	
		// Properties
		public RectTransform iconOnlineMatching { /* [XID] */ /* 0x00000001898532D0-0x00000001898532F0 */ get => default; } // 0x0000000183F4A9E0-0x0000000183F4AA80 
		public Button actionButton { /* [XID] */ /* 0x000000018985ADA0-0x000000018985ADC0 */ get => default; } // 0x0000000183F4A940-0x0000000183F4A9E0 
		public string title { /* [XID] */ /* 0x0000000189862260-0x0000000189862280 */ set {} } // 0x0000000183F4B300-0x0000000183F4B3D0
		public string level { /* [XID] */ /* 0x0000000189869710-0x0000000189869730 */ set {} } // 0x0000000183F4B050-0x0000000183F4B120
		public DungeonType dungeonType { /* [XID] */ /* 0x0000000189870910-0x0000000189870930 */ set {} } // 0x0000000183F4AE40-0x0000000183F4AF90
		public bool selected { /* [XID] */ /* 0x00000001898783A0-0x00000001898783C0 */ set {} } // 0x0000000183F4B200-0x0000000183F4B300
		public Color selectedHintColor { /* [XID] */ /* 0x000000018987F8B0-0x000000018987F8D0 */ set {} } // 0x0000000183F4B120-0x0000000183F4B200
		public Sprite icon { /* [XID] */ /* 0x0000000189886F00-0x0000000189886F20 */ set {} } // 0x0000000183F4AF90-0x0000000183F4B050
		public RectTransform randomInfo { /* [XID] */ /* 0x000000018988E090-0x000000018988E0B0 */ get => default; } // 0x0000000183F4ADA0-0x0000000183F4AE40 
		public Button randomButton { /* [XID] */ /* 0x00000001898956E0-0x0000000189895700 */ get => default; } // 0x0000000183F4AC60-0x0000000183F4AD00 
		public RectTransform randomFactor { /* [XID] */ /* 0x000000018989CE20-0x000000018989CE40 */ get => default; } // 0x0000000183F4AD00-0x0000000183F4ADA0 
		public RectTransform levelRect { /* [XID] */ /* 0x00000001898A45E0-0x00000001898A4600 */ get => default; } // 0x0000000183F4AA80-0x0000000183F4AB20 
		public RectTransform lockIcon { /* [XID] */ /* 0x00000001898ABAA0-0x00000001898ABAC0 */ get => default; } // 0x0000000183F4AB20-0x0000000183F4ABC0 
		public RectTransform questIcon { /* [XID] */ /* 0x00000001898B3250-0x00000001898B3270 */ get => default; } // 0x0000000183F4ABC0-0x0000000183F4AC60 
	
		// Constructors
		public MonoDungeonEntryItem() {} // 0x0000000183F4A8A0-0x0000000183F4A940
	}
}
