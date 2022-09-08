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
	public class MonoGachaItemPoster : MonoSpriteProxy // TypeDefIndex: 29719
	{
		// Fields
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private Animator _animator; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _weaponObj; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _characterObj; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _characterImage; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _weaponImage; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _weaponBgImage; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private SmoothMask _elementMask; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _text; // 0x58
		private List<GameObject> _cacheConversionObjs; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoReusableList _tokenRootTrans; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _conversionRootTrans; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform[] _conversionContents; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _conversionPrefab; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _isNewTrans; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _infoBtn; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _rankStarRoot; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject[] _starObjs; // 0xA0
		private uint _itemCount; // 0xA8
		private ItemConfig _itemConfig; // 0xB0
		private int _curTriggerHash; // 0xB8
		private uint _effectHandler; // 0xBC
		private bool _isConversion; // 0xC0
	
		// Properties
		public Animator animator { /* [XID] */ /* 0x0000000189A2CFA0-0x0000000189A2CFC0 */ get => default; } // 0x0000000184AF3DD0-0x0000000184AF3E70 
		public bool hasConversion { /* [XID] */ /* 0x0000000189A349A0-0x0000000189A349C0 */ get => default; } // 0x0000000184AF3E70-0x0000000184AF3F20 
	
		// Constructors
		public MonoGachaItemPoster() {} // 0x0000000184AF3CD0-0x0000000184AF3DD0
	
		// Methods
		// [XID] // 0x0000000189A3BD50-0x0000000189A3BD70
		private void ShowOneConversion(IList<GachaTransferItem> transferItems) {} // 0x0000000184AF2600-0x0000000184AF2BA0
		// [XID] // 0x0000000189A439A0-0x0000000189A439C0
		private void ShowOneProduct(IList<ItemParam> tokenItems) {} // 0x0000000184AF2320-0x0000000184AF2600
		// [XID] // 0x0000000189A4ADF0-0x0000000189A4AE10
		public MonoItemSlot GetItemByIndex(int index) => default; // 0x0000000184AF2120-0x0000000184AF2250
		// [XID] // 0x0000000189A52510-0x0000000189A52530
		public int GetConversionContentsCount() => default; // 0x0000000184AF2060-0x0000000184AF2120
		// [XID] // 0x0000000189A59E60-0x0000000189A59E80
		public void TriggerShow() {} // 0x0000000184AF3BD0-0x0000000184AF3CD0
		// [XID] // 0x0000000189A61630-0x0000000189A61650
		public void SetupItem(ItemParam item, bool isNew, IList<ItemParam> tokenItems, IList<GachaTransferItem> transferItems, bool isSettle) {} // 0x0000000184AF2D50-0x0000000184AF3860
		// [XID] // 0x0000000189A69570-0x0000000189A69590
		public void ShowConversion() {} // 0x0000000184AF3860-0x0000000184AF39E0
		// [XID] // 0x0000000189A708E0-0x0000000189A70900
		public void AfterShowed() {} // 0x0000000184AF1CE0-0x0000000184AF1D80
		// [XID] // 0x0000000189A78190-0x0000000189A781B0
		public void ActiveFromBack() {} // 0x0000000184AF18D0-0x0000000184AF1CE0
		// [XID] // 0x0000000189A7F780-0x0000000189A7F7A0
		public void ActiveFromBackSetElementTrigger() {} // 0x0000000184AF1650-0x0000000184AF18D0
		// [XID] // 0x0000000189A874E0-0x0000000189A87500
		public void OnItemClick() {} // 0x0000000184AF2C60-0x0000000184AF2D50
		// [XID] // 0x0000000189A8ECA0-0x0000000189A8ECC0
		public void ShowStar(int value) {} // 0x0000000184AF39E0-0x0000000184AF3BD0
		// [XID] // 0x0000000189A962D0-0x0000000189A962F0
		protected override void OnDestroy() {} // 0x0000000184AF2BA0-0x0000000184AF2C60
		// [XID] // 0x0000000189A9D800-0x0000000189A9D820
		protected virtual void Clear() {} // 0x0000000184AF1EB0-0x0000000184AF2060
	}
}
