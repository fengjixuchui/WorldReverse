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
	public class MonoGachaItemSlot : MonoSpriteProxy // TypeDefIndex: 29721
	{
		// Fields
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private Animator _animator; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _image; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _text; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _button; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _newItem; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _conversionPrefab; // 0x48
		private List<GameObject> _cacheConversionObjs; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _conversionRootTrans; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform[] _conversionContents; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _colorBg; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _colorIcon; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _iconElement; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _iconWeapon; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _infoBtn; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image[] _qualityImages1; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image[] _qualityImages2; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject[] _weaponQualityEffectPrefab; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject[] _avatarQualityEffectPrefab; // 0xA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _rankStarRoot; // 0xB0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _noticeTrans; // 0xB8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _effectTrans; // 0xC0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _numTextObj; // 0xC8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _numText; // 0xD0
		private MonoStarRate _rankStar; // 0xD8
		private GameObject _rankStarObj; // 0xE0
		private uint _itemCount; // 0xE8
		private ItemConfig _itemConfig; // 0xF0
		private int _curTriggerHash; // 0xF8
		private bool _hasConversion; // 0xFC
		private uint _effectHandler; // 0x100
	
		// Properties
		public Animator animator { /* [XID] */ /* 0x0000000189B78590-0x0000000189B785B0 */ get => default; } // 0x0000000184AF6520-0x0000000184AF65C0 
		public bool hasConversion { /* [XID] */ /* 0x0000000189B7FAF0-0x0000000189B7FB10 */ get => default; } // 0x0000000184AF6660-0x0000000184AF6710 
		public Button infoBtn { /* [XID] */ /* 0x0000000189B87580-0x0000000189B875A0 */ get => default; } // 0x0000000184AF67B0-0x0000000184AF6860 
		public Image image { /* [XID] */ /* 0x00000001895F4A90-0x00000001895F4AB0 */ get => default; } // 0x0000000184AF6710-0x0000000184AF67B0 
		public UnityEngine.UI.Text text { /* [XID] */ /* 0x00000001895FC180-0x00000001895FC1A0 */ get => default; } // 0x0000000184AF6900-0x0000000184AF69A0 
		public Button button { /* [XID] */ /* 0x0000000189603B60-0x0000000189603B80 */ get => default; } // 0x0000000184AF65C0-0x0000000184AF6660 
		public GameObject newItem { /* [XID] */ /* 0x000000018960B4C0-0x000000018960B4E0 */ get => default; } // 0x0000000184AF6860-0x0000000184AF6900 
		public Color backgroundColor { /* [XID] */ /* 0x0000000189612890-0x00000001896128B0 */ set {} } // 0x0000000184AF69A0-0x0000000184AF6A80
		public Color cornerMarkColor { /* [XID] */ /* 0x000000018961A220-0x000000018961A240 */ set {} } // 0x0000000184AF6A80-0x0000000184AF6BC0
	
		// Constructors
		public MonoGachaItemSlot() {} // 0x0000000184AF63E0-0x0000000184AF6520
	
		// Methods
		// [XID] // 0x0000000189B8E6D0-0x0000000189B8E6F0
		private void ShowOneConversion(IList<GachaTransferItem> transferItems) {} // 0x0000000184AF4960-0x0000000184AF4EF0
		// [XID] // 0x0000000189B95BF0-0x0000000189B95C10
		public MonoItemSlot GetItemByIndex(int index) => default; // 0x0000000184AF4830-0x0000000184AF4960
		// [XID] // 0x0000000189B9D150-0x0000000189B9D170
		public int GetConversionContentsCount() => default; // 0x0000000184AF4770-0x0000000184AF4830
		// [XID] // 0x0000000189BA4AB0-0x0000000189BA4AD0
		public void TriggerShow() {} // 0x0000000184AF62E0-0x0000000184AF63E0
		// [XID] // 0x0000000189BABE10-0x0000000189BABE30
		public void ActiveFromBack() {} // 0x0000000184AF3F20-0x0000000184AF42E0
		// [XID] // 0x0000000189BB3460-0x0000000189BB3480
		public void SetupItem(ItemParam item, bool isNew, IList<GachaTransferItem> transferItems, bool isSettle, bool showNum = false /* Metadata: 0x00B0FD3B */) {} // 0x0000000184AF5060-0x0000000184AF5CD0
		// [XID] // 0x0000000189BBAAC0-0x0000000189BBAAE0
		public void ShowConversion() {} // 0x0000000184AF5CD0-0x0000000184AF5E30
		// [XID] // 0x0000000189BC2AF0-0x0000000189BC2B10
		public void AfterShowed() {} // 0x0000000184AF42E0-0x0000000184AF43E0
		// [XID] // 0x0000000189BCA220-0x0000000189BCA240
		private void OnItemClick() {} // 0x0000000184AF4680-0x0000000184AF4770
		// [XID] // 0x0000000189BD18B0-0x0000000189BD18D0
		public void ShowQualityRank(uint inputRank) {} // 0x0000000184AF5E30-0x0000000184AF6020
		// [XID] // 0x0000000189BD8E60-0x0000000189BD8E80
		public void ShowStar(int value) {} // 0x0000000184AF6020-0x0000000184AF62E0
		// [XID] // 0x00000001895E5A20-0x00000001895E5A40
		protected override void OnDestroy() {} // 0x0000000184AF4EF0-0x0000000184AF5060
		// [XID] // 0x00000001895ED350-0x00000001895ED370
		protected virtual void Clear() {} // 0x0000000184AF44A0-0x0000000184AF4680
	}
}
