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
	public class MonoShopMaterial : MonoSpriteProxy // TypeDefIndex: 31062
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _imgIcon; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtMatName; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtNum; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _clickBtn; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _addBtn; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoControllerIcon _iconController; // 0x48
		private ShopMaterial _shopMaterial; // 0x50
		private Coroutine _updateRecoveryTextCoroutineOfResin; // 0x58
	
		// Properties
		public Image imgIcon { /* [XID] */ /* 0x00000001896E7A90-0x00000001896E7AB0 */ get => default; } // 0x00000001841246B0-0x0000000184124750 
		public UnityEngine.UI.Text txtNum { /* [XID] */ /* 0x00000001896EF140-0x00000001896EF160 */ get => default; } // 0x0000000184124750-0x00000001841247F0 
		public Button clickBtn { /* [XID] */ /* 0x00000001896F6BA0-0x00000001896F6BC0 */ get => default; } // 0x0000000184124570-0x0000000184124610 
		public MonoControllerIcon iconController { /* [XID] */ /* 0x00000001896FE460-0x00000001896FE480 */ get => default; } // 0x0000000184124610-0x00000001841246B0 
	
		// Constructors
		public MonoShopMaterial() {} // 0x00000001841244F0-0x0000000184124570
	
		// Methods
		// [XID] // 0x00000001897055E0-0x0000000189705600
		public void UpdateShopMaterial(ShopMaterial shopMaterial, Action clickCB = null, bool showAddBtn = true /* Metadata: 0x00B11E7E */) {} // 0x0000000184123D80-0x00000001841244F0
		// [XID] // 0x000000018970D0A0-0x000000018970D0C0
		public void ClickMaterialBtn() {} // 0x0000000184123500-0x0000000184123640
		// [XID] // 0x00000001897144F0-0x0000000189714510
		public void ShowAddBtnForJoyTips(ContextEventType eventType = ContextEventType.Invalid /* Metadata: 0x00B11E7F */) {} // 0x0000000184123640-0x00000001841238A0
		// [XID] // 0x000000018971BF30-0x000000018971BF50
		public void ShowAddBtn(ContextEventType eventType = ContextEventType.Invalid /* Metadata: 0x00B11E83 */, Action clickCB = null) {} // 0x00000001841238A0-0x0000000184123C80
		// [XID] // 0x0000000189723440-0x0000000189723460
		public void UpdateCount() {} // 0x0000000184123C80-0x0000000184123D80
	}
}
