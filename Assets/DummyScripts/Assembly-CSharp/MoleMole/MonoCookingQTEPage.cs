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
	public class MonoCookingQTEPage : MonoUIProxy // TypeDefIndex: 30993
	{
		// Fields
		private const string BAG_SLOT_PREFAB_ROOT = "ART/UI/Menus/Widget/BagItemSlotSmall"; // Metadata: 0x00B11BED
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private MonoElementSwitch _elementSwitch; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _cookNeedRoot; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _addInfo; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _addDescText; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _iconState; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform[] _foodPanel; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _makeBtn; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _autoMakeBtn; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _returnBtn; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _qtePanel; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _manualQteRoot; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _autoQteRoot; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoCookGotPanel _cookGotPanel; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _endBtn; // 0xA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _goodAreaTrans; // 0xB0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private SmoothMask _goodAreaFill; // 0xB8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _perfectAreaTrans; // 0xC0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private SmoothMask _perfectAreaFill; // 0xC8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _pointerTrans; // 0xD0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _qteTime; // 0xD8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _autoQteTime; // 0xDC
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _starQteDelay; // 0xE0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _selectNumberRoot; // 0xE8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _grpProficiency; // 0xF0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _proficiencyText; // 0xF8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _replaceBtn; // 0x100
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoBagProxySlot _curRecipeItemSlot; // 0x108
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _curRecipeFoodNum; // 0x110
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _grpResult; // 0x118
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _bonusAdditionalInfoIcon; // 0x120
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _additionalInfoText; // 0x128
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _grpJoypadButtons; // 0x130
		private GameObject _bagSlotPrefab; // 0x138
		private List<MonoItemSlot> _cookNeedList; // 0x140
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoCookAvatarSelect _avatarPanel; // 0x148
		private MonoAvatarIcon _avatarIcon; // 0x150
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _avatarIconRoot; // 0x158
	
		// Properties
		public bool showGrpResult { /* [XID] */ /* 0x000000018978A2B0-0x000000018978A2D0 */ set {} } // 0x0000000183F30180-0x0000000183F30270
		public GameObject selectNumberRoot { /* [XID] */ /* 0x0000000189791B30-0x0000000189791B50 */ get => default; } // 0x0000000183F2FF10-0x0000000183F2FFC0 
		public GameObject grpProficiency { /* [XID] */ /* 0x00000001897990D0-0x00000001897990F0 */ get => default; } // 0x0000000183F2F550-0x0000000183F2F600 
		public UnityEngine.UI.Text proficiencyText { /* [XID] */ /* 0x00000001897A0FB0-0x00000001897A0FD0 */ get => default; } // 0x0000000183F2FA00-0x0000000183F2FAB0 
		public Button replaceBtn { /* [XID] */ /* 0x00000001897A8620-0x00000001897A8640 */ get => default; } // 0x0000000183F2FDA0-0x0000000183F2FE60 
		public MonoBagProxySlot curRecipeItemSlot { /* [XID] */ /* 0x00000001897B0000-0x00000001897B0020 */ get => default; } // 0x0000000183F2F1F0-0x0000000183F2F2A0 
		public UnityEngine.UI.Text curRecipeFoodNum { /* [XID] */ /* 0x00000001897B7D50-0x00000001897B7D70 */ get => default; } // 0x0000000183F2F140-0x0000000183F2F1F0 
		public GameObject addInfo { /* [XID] */ /* 0x00000001897BFDA0-0x00000001897BFDC0 */ get => default; } // 0x0000000183F2E960-0x0000000183F2EA00 
		public UnityEngine.UI.Text addDescText { /* [XID] */ /* 0x00000001897C7680-0x00000001897C76A0 */ get => default; } // 0x0000000183F2E8C0-0x0000000183F2E960 
		public GameObject iconState { /* [XID] */ /* 0x00000001897CE920-0x00000001897CE940 */ get => default; } // 0x0000000183F2F600-0x0000000183F2F6A0 
		public Transform[] foodPanel { /* [XID] */ /* 0x00000001897D6100-0x00000001897D6120 */ get => default; } // 0x0000000183F2F350-0x0000000183F2F3F0 
		public MonoUIContainer makeBtn { /* [XID] */ /* 0x00000001897DD9E0-0x00000001897DDA00 */ get => default; } // 0x0000000183F2F6A0-0x0000000183F2F740 
		public MonoUIContainer autoMakeBtn { /* [XID] */ /* 0x00000001897E52D0-0x00000001897E52F0 */ get => default; } // 0x0000000183F2EB60-0x0000000183F2EC00 
		public MonoUIContainer returnBtn { /* [XID] */ /* 0x00000001897ECEB0-0x00000001897ECED0 */ get => default; } // 0x0000000183F2FE60-0x0000000183F2FF10 
		public GameObject qtePanel { /* [XID] */ /* 0x00000001897F46B0-0x00000001897F46D0 */ get => default; } // 0x0000000183F2FAB0-0x0000000183F2FB60 
		public GameObject manualQteRoot { /* [XID] */ /* 0x00000001897FC130-0x00000001897FC150 */ get => default; } // 0x0000000183F2F740-0x0000000183F2F7F0 
		public GameObject autoQteRoot { /* [XID] */ /* 0x0000000189803530-0x0000000189803550 */ get => default; } // 0x0000000183F2EC00-0x0000000183F2ECB0 
		public MonoUIContainer btnSelectAvatar { /* [XID] */ /* 0x000000018980ABA0-0x000000018980ABC0 */ get => default; } // 0x0000000183F2EFD0-0x0000000183F2F090 
		public GameObject additionalInfoBtn { /* [XID] */ /* 0x0000000189812170-0x0000000189812190 */ get => default; } // 0x0000000183F2EA00-0x0000000183F2EAB0 
		public UnityEngine.UI.Text additionalInfoText { /* [XID] */ /* 0x0000000189819D20-0x0000000189819D40 */ get => default; } // 0x0000000183F2EAB0-0x0000000183F2EB60 
		public MonoCookGotPanel cookGotPanel { /* [XID] */ /* 0x00000001898215A0-0x00000001898215C0 */ get => default; } // 0x0000000183F2F090-0x0000000183F2F140 
		public Button endBtn { /* [XID] */ /* 0x0000000189828B90-0x0000000189828BB0 */ get => default; } // 0x0000000183F2F2A0-0x0000000183F2F350 
		public RectTransform goodAreaTrans { /* [XID] */ /* 0x000000018982FFC0-0x000000018982FFE0 */ get => default; } // 0x0000000183F2F4A0-0x0000000183F2F550 
		public SmoothMask goodAreaFill { /* [XID] */ /* 0x0000000189837700-0x0000000189837720 */ get => default; } // 0x0000000183F2F3F0-0x0000000183F2F4A0 
		public RectTransform perfectAreaTrans { /* [XID] */ /* 0x000000018983EDD0-0x000000018983EDF0 */ get => default; } // 0x0000000183F2F8A0-0x0000000183F2F950 
		public SmoothMask perfectAreaFill { /* [XID] */ /* 0x0000000189846410-0x0000000189846430 */ get => default; } // 0x0000000183F2F7F0-0x0000000183F2F8A0 
		public RectTransform pointerTrans { /* [XID] */ /* 0x000000018984DA00-0x000000018984DA20 */ get => default; } // 0x0000000183F2F950-0x0000000183F2FA00 
		public float qteTime { /* [XID] */ /* 0x0000000189854A60-0x0000000189854A80 */ get => default; } // 0x0000000183F2FB60-0x0000000183F2FC10 
		public float autoQteTime { /* [XID] */ /* 0x000000018985C2C0-0x000000018985C2E0 */ get => default; } // 0x0000000183F2ECB0-0x0000000183F2ED60 
		public float starQteDelay { /* [XID] */ /* 0x0000000189863C20-0x0000000189863C40 */ get => default; } // 0x0000000183F2FFC0-0x0000000183F30070 
		public MonoCookAvatarSelect avatarPanel { /* [XID] */ /* 0x00000001898810B0-0x00000001898810D0 */ get => default; } // 0x0000000183F2EF20-0x0000000183F2EFD0 
		public MonoAvatarIcon avatarIcon { /* [XID] */ /* 0x0000000189888680-0x00000001898886A0 */ get => default; } // 0x0000000183F2ED60-0x0000000183F2EF20 
		public GameObject replaceBtnRipple { /* [XID] */ /* 0x000000018988FA40-0x000000018988FA60 */ get => default; } // 0x0000000183F2FC10-0x0000000183F2FDA0 
		public bool showJoypadButtons { /* [XID] */ /* 0x000000018989E440-0x000000018989E460 */ set {} } // 0x0000000183F30270-0x0000000183F30370
		public bool showAvatarJoypadButtons { /* [XID] */ /* 0x00000001898A5F60-0x00000001898A5F80 */ set {} } // 0x0000000183F30070-0x0000000183F30180
	
		// Constructors
		public MonoCookingQTEPage() {} // 0x0000000183F2E730-0x0000000183F2E8C0
	
		// Methods
		// [XID] // 0x000000018986AEF0-0x000000018986AF10
		public void UpdateCookNeedList(IdCountConfig[] needList) {} // 0x0000000183F2E0C0-0x0000000183F2E730
		// [XID] // 0x0000000189872300-0x0000000189872320
		public MonoItemSlot GetNeedItem(int index) => default; // 0x0000000183F2DBB0-0x0000000183F2DCB0
		// [XID] // 0x0000000189879F70-0x0000000189879F90
		protected override void OnDestroy() {} // 0x0000000183F2DCB0-0x0000000183F2DE80
		// [XID] // 0x0000000189896F40-0x0000000189896F60
		public void SetAvatarIcon(AvatarExcelConfig avatarData, bool isUp = false /* Metadata: 0x00B11BEB */, bool canUp = false /* Metadata: 0x00B11BEC */) {} // 0x0000000183F2DE80-0x0000000183F2E0C0
	}
}
