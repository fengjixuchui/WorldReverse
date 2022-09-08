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
	public class MonoMonsterIcon : MonoBehaviour // TypeDefIndex: 30838
	{
		// Fields
		private const string COUNT_DOWN_PREFAB_PATH = "ART/UI/Menus/Widget/BagItemSlot_CountDown"; // Metadata: 0x00B1163D
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _icon; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _levelText; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _actionBtn; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _unknownIcon; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Color _unknownImgColor; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _countDownRoot; // 0x48
		private MonoItemCountDown _countDown; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _newCornerMark; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _selectedTrans; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Animator _animator; // 0x68
	
		// Properties
		public Image icon { /* [XID] */ /* 0x0000000189A0F590-0x0000000189A0F5B0 */ get => default; } // 0x0000000182F16FF0-0x0000000182F17090 
		public UnityEngine.UI.Text levelText { /* [XID] */ /* 0x0000000189A16C20-0x0000000189A16C40 */ get => default; } // 0x0000000182F17090-0x0000000182F17130 
		public Button actionBtn { /* [XID] */ /* 0x0000000189A1E280-0x0000000189A1E2A0 */ get => default; } // 0x0000000182F16D90-0x0000000182F16E30 
		public Image unknownIcon { /* [XID] */ /* 0x0000000189A25980-0x0000000189A259A0 */ get => default; } // 0x0000000182F17130-0x0000000182F171D0 
		public Color unknownImgColor { /* [XID] */ /* 0x0000000189A2CDA0-0x0000000189A2CDC0 */ get => default; } // 0x0000000182F171D0-0x0000000182F172A0 
		public MonoItemCountDown countDown { /* [XID] */ /* 0x0000000189A34770-0x0000000189A34790 */ get => default; } // 0x0000000182F16E30-0x0000000182F16FF0 
		public bool showNewCornerMark { /* [XID] */ /* 0x0000000189A3BB90-0x0000000189A3BBB0 */ set {} } // 0x0000000182F17520-0x0000000182F17660
		public bool selected { /* [XID] */ /* 0x0000000189A43820-0x0000000189A43840 */ set {} } // 0x0000000182F172A0-0x0000000182F173E0
		public bool showCucoloris { /* [XID] */ /* 0x0000000189A4AC70-0x0000000189A4AC90 */ set {} } // 0x0000000182F173E0-0x0000000182F17520
	
		// Constructors
		public MonoMonsterIcon() {} // 0x0000000182F16D00-0x0000000182F16D90
	
		// Methods
		// [XID] // 0x0000000189A52350-0x0000000189A52370
		private void OnDestroy() {} // 0x0000000182F16BB0-0x0000000182F16D00
	}
}
