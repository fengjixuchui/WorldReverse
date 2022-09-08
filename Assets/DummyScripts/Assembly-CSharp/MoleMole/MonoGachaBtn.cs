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
	public class MonoGachaBtn : MonoSpriteProxy // TypeDefIndex: 29718
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _image; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _text; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _infoText; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public Color _normalColor; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public Color _limitColor; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public Button _button; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _discountObj; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _discountText; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _discountNumObj; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _discountNumText; // 0x78
	
		// Properties
		public Image image { /* [XID] */ /* 0x0000000189994FB0-0x0000000189994FD0 */ get => default; } // 0x0000000184AF02F0-0x0000000184AF0390 
		public UnityEngine.UI.Text text { /* [XID] */ /* 0x000000018999C8F0-0x000000018999C910 */ get => default; } // 0x0000000184AF0430-0x0000000184AF04D0 
		public UnityEngine.UI.Text infoText { /* [XID] */ /* 0x00000001899A4360-0x00000001899A4380 */ get => default; } // 0x0000000184AF0390-0x0000000184AF0430 
	
		// Constructors
		public MonoGachaBtn() {} // 0x0000000184AF0270-0x0000000184AF02F0
	
		// Methods
		// [XID] // 0x00000001899ABD20-0x00000001899ABD40
		public void UpdateShopMaterial(ShopMaterial shopMaterial, uint leftGachaTimes, uint times, uint originTimes, uint gachaTimes, bool isLimit, bool isNewBie) {} // 0x0000000184AEFE50-0x0000000184AF0270
	}
}
