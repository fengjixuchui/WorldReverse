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
	public class MonoNewItemGotDialog : MonoUIProxy // TypeDefIndex: 30566
	{
		// Fields
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private Button _actionButton; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _closeBtn; // 0x48
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private Image _background; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _hightlight; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _categoryIcon; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _name; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _description; // 0x70
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private Image _icon; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _buffIcon; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _iconBackground; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _iconCorner; // 0x90
		// [Range] // 0x0000000189B146B0-0x0000000189B14700
		[SerializeField] // 0x0000000189B146B0-0x0000000189B14700
		[Space] // 0x0000000189B146B0-0x0000000189B14700
		private float _completeDuration; // 0x98
		// [Range] // 0x0000000189B21A30-0x0000000189B21A70
		[SerializeField] // 0x0000000189B21A30-0x0000000189B21A70
		private float _interruptDuration; // 0x9C
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private Transform _qualityStarRoot; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _qualityStarPrefab; // 0xA8
		private MonoStarRate _qualityStar; // 0xB0
	
		// Properties
		public Image background { /* [XID] */ /* 0x0000000189B3DDB0-0x0000000189B3DDD0 */ get => default; } // 0x0000000183712330-0x00000001837123D0 
		public Image categoryIcon { /* [XID] */ /* 0x0000000189B45B30-0x0000000189B45B50 */ get => default; } // 0x00000001837123D0-0x0000000183712470 
		public string itemName { /* [XID] */ /* 0x0000000189B4CFD0-0x0000000189B4CFF0 */ set {} } // 0x0000000183712BF0-0x0000000183712CC0
		public string description { /* [XID] */ /* 0x0000000189B546F0-0x0000000189B54710 */ set {} } // 0x0000000183712720-0x00000001837127F0
		public Sprite icon { /* [XID] */ /* 0x0000000189B5C2C0-0x0000000189B5C2E0 */ set {} } // 0x0000000183712B30-0x0000000183712BF0
		public Image BuffIcon { /* [XID] */ /* 0x0000000189B638C0-0x0000000189B638E0 */ get => default; } // 0x00000001837121E0-0x0000000183712290 
		public Color iconColor { /* [XID] */ /* 0x0000000189B6B060-0x0000000189B6B080 */ set {} } // 0x0000000183712A00-0x0000000183712B30
		public Color iconBackgroundColor { /* [XID] */ /* 0x0000000189B726A0-0x0000000189B726C0 */ set {} } // 0x00000001837128D0-0x0000000183712A00
		public Color flashLightColor { /* [XID] */ /* 0x0000000189B79C10-0x0000000189B79C30 */ set {} } // 0x00000001837127F0-0x00000001837128D0
		public float completeDuration { /* [XID] */ /* 0x0000000189B81360-0x0000000189B81380 */ get => default; } // 0x0000000183712510-0x00000001837125C0 
		public float minDuration { /* [XID] */ /* 0x0000000189B88AF0-0x0000000189B88B10 */ get => default; } // 0x00000001837125C0-0x0000000183712670 
		public Button actionButton { /* [XID] */ /* 0x0000000189B973C0-0x0000000189B973E0 */ get => default; } // 0x0000000183712290-0x0000000183712330 
		public Button closeBtn { /* [XID] */ /* 0x0000000189B9E860-0x0000000189B9E880 */ get => default; } // 0x0000000183712470-0x0000000183712510 
		public Transform qualityStarRoot { /* [XID] */ /* 0x0000000189BA6210-0x0000000189BA6230 */ get => default; } // 0x0000000183712670-0x0000000183712720 
		public int quality { /* [XID] */ /* 0x0000000189BAD4C0-0x0000000189BAD4E0 */ set {} } // 0x0000000183712CC0-0x0000000183712EB0
	
		// Constructors
		public MonoNewItemGotDialog() {} // 0x0000000183712120-0x00000001837121E0
	
		// Methods
		// [XID] // 0x0000000189B8FFC0-0x0000000189B8FFE0
		public void FadeIn() {} // 0x0000000183712040-0x0000000183712120
	}
}
