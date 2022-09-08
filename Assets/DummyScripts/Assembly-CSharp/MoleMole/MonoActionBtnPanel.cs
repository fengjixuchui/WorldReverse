/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoActionBtnPanel : MonoSpriteProxy // TypeDefIndex: 30674
	{
		// Fields
		// [Header] // 0x0000000189AD25B0-0x0000000189AD2600
		[SerializeField] // 0x0000000189AD25B0-0x0000000189AD2600
		private Transform _slot1Root; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _slot2Root; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _slot3Root; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _slot4Root; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _slot5Root; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _slot6JoypadRoot; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _slotAMRoot; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _slotChargeRoot; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _slotQuickUseRoot; // 0x60
		// [Header] // 0x0000000189B1A530-0x0000000189B1A570
		[SerializeField] // 0x0000000189B1A530-0x0000000189B1A570
		private Transform _slot1Grp; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _slot2Grp; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _slot3Grp; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _slot4Grp; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _slot5Grp; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _slot6JoypadGrp; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _slotAMGrp; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _slotChargeGrp; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _slotQuickUseGrp; // 0xA8
		// [Header] // 0x0000000189B61C70-0x0000000189B61CB0
		[SerializeField] // 0x0000000189B61C70-0x0000000189B61CB0
		private Transform _slot1KeyContainer; // 0xB0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _slot2KeyContainer; // 0xB8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _slot3KeyContainer; // 0xC0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _slot4KeyContainer; // 0xC8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _slot5KeyContainer; // 0xD0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _slot6JoypadKeyContainer; // 0xD8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _slotAMKeyContainer; // 0xE0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _slotChargeKeyContainer; // 0xE8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _slotQuickUseKeyContainer; // 0xF0
		private const string KEY_PREFAB_PATH = "ART/UI/TemplateUI/Key"; // Metadata: 0x00B11434
		private GameObject _keyPrefab; // 0xF8
		private uint _keyPrefabHandle; // 0x100
		private MonoControlElement _slot1Key; // 0x108
		private MonoControlElement _slot2Key; // 0x110
		private MonoControlElement _slot3Key; // 0x118
		private MonoControlElement _slot4Key; // 0x120
		private MonoControlElement _slot5Key; // 0x128
		private MonoControlElement _slot6JoypadKey; // 0x130
		private MonoControlElement _slotAMKey; // 0x138
		private MonoControlElement _slotChargeKey; // 0x140
		private MonoControlElement _slotQuickUseKey; // 0x148
	
		// Properties
		public Transform slot1Grp { /* [XID] */ /* 0x0000000189600840-0x0000000189600860 */ get => default; } // 0x0000000184C68AD0-0x0000000184C68B70 
		public Transform slot2Grp { /* [XID] */ /* 0x0000000189608160-0x0000000189608180 */ get => default; } // 0x0000000184C68B70-0x0000000184C68C10 
		public Transform slot3Grp { /* [XID] */ /* 0x000000018960FAE0-0x000000018960FB00 */ get => default; } // 0x0000000184C68C10-0x0000000184C68CB0 
		public Transform slot4Grp { /* [XID] */ /* 0x0000000189616D50-0x0000000189616D70 */ get => default; } // 0x0000000184C68CB0-0x0000000184C68D60 
		public Transform slot5Grp { /* [XID] */ /* 0x000000018961E900-0x000000018961E920 */ get => default; } // 0x0000000184C68D60-0x0000000184C68E10 
		public Transform slotAMGrp { /* [XID] */ /* 0x0000000189625D20-0x0000000189625D40 */ get => default; } // 0x0000000184C68E10-0x0000000184C68EC0 
		public Transform slotChargeGrp { /* [XID] */ /* 0x000000018962D640-0x000000018962D660 */ get => default; } // 0x0000000184C68EC0-0x0000000184C68F70 
		public Transform slotQuickUseGrp { /* [XID] */ /* 0x0000000189635200-0x0000000189635220 */ get => default; } // 0x0000000184C68F70-0x0000000184C69020 
	
		// Constructors
		public MonoActionBtnPanel() {} // 0x0000000184C689A0-0x0000000184C68AD0
	
		// Methods
		// [XID] // 0x0000000189BA8CD0-0x0000000189BA8CF0
		protected override void OnDestroy() {} // 0x0000000184C67B00-0x0000000184C67BF0
		// [XID] // 0x0000000189BB0420-0x0000000189BB0440
		public Transform GetRootTrans(ActionSlotType slotType) => default; // 0x0000000184C673E0-0x0000000184C67650
		// [XID] // 0x0000000189BB7860-0x0000000189BB7880
		public Transform GetDefaultRootTrans(ActionSlotType slotType) => default; // 0x0000000184C67090-0x0000000184C671B0
		// [XID] // 0x0000000189BBEEA0-0x0000000189BBEEC0
		public Transform GetGrpTransForJoypad(ActionSlotType slotType) => default; // 0x0000000184C671B0-0x0000000184C673E0
		// [XID] // 0x0000000189BC6B50-0x0000000189BC6B70
		private int GetSlotIndexForJoyPad(ActionSlotType slotType) => default; // 0x0000000184C66F70-0x0000000184C67090
		// [XID] // 0x0000000189BCE820-0x0000000189BCE840
		public void SetTalkOrPickSlotActive(bool active) {} // 0x0000000184C68760-0x0000000184C689A0
		// [XID] // 0x0000000189BD5AA0-0x0000000189BD5AC0
		private int GetSlotIndexForJoypadByInputAction(InputActionType actionType) => default; // 0x0000000184C67920-0x0000000184C67B00
		// [XID] // 0x0000000189BDD740-0x0000000189BDD760
		private int GetSlotIndexByElementID(int elementID) => default; // 0x0000000184C66330-0x0000000184C66580
		// [XID] // 0x00000001895EA2F0-0x00000001895EA310
		private Transform GetRootOrGroupByIndex(int index, bool rootOrGroup) => default; // 0x0000000184C66D80-0x0000000184C66F10
		// [XID] // 0x00000001895F1770-0x00000001895F1790
		private Transform GetKeyContainerByIndex(int index) => default; // 0x0000000184C67800-0x0000000184C67920
		// [XID] // 0x00000001895F9210-0x00000001895F9230
		public void SetAllSlotActive(bool active) {} // 0x0000000184C67DD0-0x0000000184C67F60
		// [XID] // 0x000000018963C880-0x000000018963C8A0
		public void SetSlotKey(ActionSlotType slotType, ActionPanelType panelType, InputActionType? hint = default) {} // 0x0000000184C68560-0x0000000184C68760
		// [XID] // 0x0000000189643F80-0x0000000189643FA0
		public void SetJoypadSlotKeyForSquare() {} // 0x0000000184C67F60-0x0000000184C681E0
		// [XID] // 0x000000018964B6E0-0x000000018964B700
		private void SetPCKey(MonoControlElement keyElement, InputActionType actionType) {} // 0x0000000184C66580-0x0000000184C668D0
		// [XID] // 0x0000000189652EA0-0x0000000189652EC0
		public void SetSlotJoypadKey(ActionSlotType slotType, ref MonoControlElement keyElement, InputActionType actionType) {} // 0x0000000184C68400-0x0000000184C68560
		// [XID] // 0x000000018965A560-0x000000018965A580
		private void SetFixedSlotJoypadKey(ActionSlotType slotType, ref MonoControlElement keyElement) {} // 0x0000000184C668D0-0x0000000184C66B70
		// [XID] // 0x0000000189661BB0-0x0000000189661BD0
		private void SetNormalSlotJoypadKey(ActionSlotType slotType, ref MonoControlElement keyElement, InputActionType actionType) {} // 0x0000000184C67650-0x0000000184C67800
		// [XID] // 0x0000000189669750-0x0000000189669770
		private MonoControlElement GetValidControlElement(ActionSlotType slotType) => default; // 0x0000000184C66B70-0x0000000184C66D80
		// [XID] // 0x0000000189671240-0x0000000189671260
		private void CheckKeyInstance(ref MonoControlElement element, Transform parent) {} // 0x0000000184C67BF0-0x0000000184C67DD0
		// [XID] // 0x0000000189678B00-0x0000000189678B20
		public void SetKeyActive(ActionSlotType slotType, bool active) {} // 0x0000000184C681E0-0x0000000184C68400
	}
}
