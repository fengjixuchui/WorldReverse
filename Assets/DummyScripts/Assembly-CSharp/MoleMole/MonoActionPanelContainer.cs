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

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoActionPanelContainer : MonoBehaviour // TypeDefIndex: 30677
	{
		// Fields
		private string _actionPanelFolderPath; // 0x18
		private string _actionPanelName; // 0x20
		private GameObject _actionPanelPrefab; // 0x28
		private GameObject _actionPanel; // 0x30
		private MonoActionBtnPanel _actionPanelMono; // 0x38
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private GameObject _btnAMPrefab; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _btnJumpPrefab; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _btnSlipPrefab; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _btnSprintPrefab; // 0x58
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private GameObject _btnSkill1Prefab; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _btnSkill2Prefab; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _btnSkill3Prefab; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _btnSkill4Prefab; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _btnSkill5Prefab; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _btnSkill5PCPrefab; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _btnChargePrefab; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _btnQuickUsePrefab; // 0x98
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private GameObject _btnReconRollPrefab; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _btnReconSquatPrefab; // 0xA8
		private GameObject _btnAM; // 0xB0
		private GameObject _btnJump; // 0xB8
		private GameObject _btnSlip; // 0xC0
		private GameObject _btnSprint; // 0xC8
		private GameObject _btnSkill1; // 0xD0
		private GameObject _btnSkill2; // 0xD8
		private GameObject _btnSkill3; // 0xE0
		private GameObject _btnSkill4; // 0xE8
		private GameObject _btnSkill5; // 0xF0
		private GameObject _btnCharge; // 0xF8
		private GameObject _btnQuickUse; // 0x100
		private GameObject _btnReconRoll; // 0x108
		private GameObject _btnReconSquat; // 0x110
		private GameObject _btnToNormal; // 0x118
		private GameObject _btnToFocus; // 0x120
		// [Header] // 0x0000000189715C60-0x0000000189715CB0
		[SerializeField] // 0x0000000189715C60-0x0000000189715CB0
		private GameObject _btnSkillLeft; // 0x128
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _crosshair; // 0x130
		private MonoJumpButton _btnJumpMono; // 0x138
		private MonoSlipButton _btnSlipMono; // 0x140
		private MonoSprintButton _btnSprintMono; // 0x148
		private MonoBattleBtn _btnSkill1Mono; // 0x150
		private MonoBattleBtn _btnSkill2Mono; // 0x158
		private MonoBattleBtn _btnSkill3Mono; // 0x160
		private MonoBattleBtn _btnSkill4Mono; // 0x168
		private MonoBattleBtn _btnSkill5Mono; // 0x170
		private MonoBattleBtn _btnSkillLeftMono; // 0x178
		private MonoAttackModeBtn _btnToNormalMono; // 0x180
		private MonoAttackModeBtn _btnToFocusMono; // 0x188
		private MonoActivitySkillButton _btnChargeMono; // 0x190
		private MonoQuickUseButton _btnQuickUseMono; // 0x198
		private MonoSquatButton _btnSquatMono; // 0x1A0
		private Transform _slot1Root; // 0x1A8
		private Transform _slot2Root; // 0x1B0
		private Transform _slot3Root; // 0x1B8
		private Transform _slot4Root; // 0x1C0
		private Transform _slot5Root; // 0x1C8
		private Transform _slotAMRoot; // 0x1D0
		private Transform _slotChargeRoot; // 0x1D8
		private Transform _slotQuckUseRoot; // 0x1E0
		// [Header] // 0x0000000189729220-0x0000000189729260
		[SerializeField] // 0x0000000189729220-0x0000000189729260
		private Transform _slotLeftRoot; // 0x1E8
		private ActionPanelType _panelType; // 0x1F0
		private ActionSlotType[] _slotTypes; // 0x1F8
		private ActionPanelState _currState; // 0x200
		private Dictionary<int, MonoActionBtn> _slot2ButtonDic; // 0x208
	
		// Properties
		private GameObject btnAM { /* [XID] */ /* 0x0000000189735210-0x0000000189735230 */ get => default; } // 0x0000000184C69EF0-0x0000000184C6A010 
		private GameObject btnJump { /* [XID] */ /* 0x000000018973CC90-0x000000018973CCB0 */ get => default; } // 0x0000000184C6B330-0x0000000184C6B450 
		private GameObject btnSlip { /* [XID] */ /* 0x0000000189744210-0x0000000189744230 */ get => default; } // 0x0000000184C6E370-0x0000000184C6E490 
		private GameObject btnSprint { /* [XID] */ /* 0x000000018974BF10-0x000000018974BF30 */ get => default; } // 0x0000000184C6D4E0-0x0000000184C6D600 
		private GameObject btnSkill1 { /* [XID] */ /* 0x00000001897531F0-0x0000000189753210 */ get => default; } // 0x0000000184C6C550-0x0000000184C6C670 
		private GameObject btnSkill2 { /* [XID] */ /* 0x000000018975A5C0-0x000000018975A5E0 */ get => default; } // 0x0000000184C6D3C0-0x0000000184C6D4E0 
		private GameObject btnSkill3 { /* [XID] */ /* 0x0000000189762280-0x00000001897622A0 */ get => default; } // 0x0000000184C6B9A0-0x0000000184C6BAC0 
		private GameObject btnSkill4 { /* [XID] */ /* 0x0000000189769880-0x00000001897698A0 */ get => default; } // 0x0000000184C6A120-0x0000000184C6A240 
		private GameObject btnSkill5 { /* [XID] */ /* 0x0000000189770DD0-0x0000000189770DF0 */ get => default; } // 0x0000000184C6B450-0x0000000184C6B590 
		private GameObject btnCharge { /* [XID] */ /* 0x0000000189778760-0x0000000189778780 */ get => default; } // 0x0000000184C6D180-0x0000000184C6D2B0 
		private GameObject btnQuickUse { /* [XID] */ /* 0x000000018977FCC0-0x000000018977FCE0 */ get => default; } // 0x0000000184C6F6E0-0x0000000184C6F810 
		private GameObject btnRoll { /* [XID] */ /* 0x00000001897875A0-0x00000001897875C0 */ get => default; } // 0x0000000184C6A880-0x0000000184C6A9B0 
		private GameObject btnSquat { /* [XID] */ /* 0x000000018978EBD0-0x000000018978EBF0 */ get => default; } // 0x0000000184C6A750-0x0000000184C6A880 
		private GameObject btnToNormal { /* [XID] */ /* 0x0000000189796360-0x0000000189796380 */ get => default; } // 0x0000000184C6A240-0x0000000184C6A380 
		private GameObject btnToFocus { /* [XID] */ /* 0x000000018979E430-0x000000018979E450 */ get => default; } // 0x0000000184C69DB0-0x0000000184C69EF0 
		private MonoJumpButton btnJumpMono { /* [XID] */ /* 0x00000001897A5BB0-0x00000001897A5BD0 */ get => default; } // 0x0000000184C6E130-0x0000000184C6E250 
		private MonoSprintButton btnSprintMono { /* [XID] */ /* 0x00000001897AD120-0x00000001897AD140 */ get => default; } // 0x0000000184C6D760-0x0000000184C6D880 
		private MonoBattleBtn btnSkill1Mono { /* [XID] */ /* 0x00000001897B5150-0x00000001897B5170 */ get => default; } // 0x0000000184C6B880-0x0000000184C6B9A0 
		private MonoBattleBtn btnSkill2Mono { /* [XID] */ /* 0x00000001897BCDC0-0x00000001897BCDE0 */ get => default; } // 0x0000000184C6B760-0x0000000184C6B880 
		private MonoBattleBtn btnSkill3Mono { /* [XID] */ /* 0x00000001897C4140-0x00000001897C4160 */ get => default; } // 0x0000000184C6D060-0x0000000184C6D180 
		private MonoBattleBtn btnSkill4Mono { /* [XID] */ /* 0x00000001897CB9C0-0x00000001897CB9E0 */ get => default; } // 0x0000000184C6A630-0x0000000184C6A750 
		private MonoBattleBtn btnSkill5Mono { /* [XID] */ /* 0x00000001897D32D0-0x00000001897D32F0 */ get => default; } // 0x0000000184C6E250-0x0000000184C6E370 
		private MonoBattleBtn btnSkillLeftMono { /* [XID] */ /* 0x00000001897DAD50-0x00000001897DAD70 */ get => default; } // 0x0000000184C6A010-0x0000000184C6A120 
		private MonoAttackModeBtn btnToNormalMono { /* [XID] */ /* 0x00000001897E2460-0x00000001897E2480 */ get => default; } // 0x0000000184C6C430-0x0000000184C6C550 
		private MonoAttackModeBtn btnToFocusMono { /* [XID] */ /* 0x00000001897E9BD0-0x00000001897E9BF0 */ get => default; } // 0x0000000184C6AAC0-0x0000000184C6ABE0 
		private MonoSquatButton btnSquatMono { /* [XID] */ /* 0x00000001897F1890-0x00000001897F18B0 */ get => default; } // 0x0000000184C6DAC0-0x0000000184C6DBE0 
		private MonoActivitySkillButton btnChargeMono { /* [XID] */ /* 0x00000001897F8FC0-0x00000001897F8FE0 */ get => default; } // 0x0000000184C6D2B0-0x0000000184C6D3C0 
		private MonoQuickUseButton btnQuickUseMono { /* [XID] */ /* 0x00000001898005D0-0x00000001898005F0 */ get => default; } // 0x0000000184C6DE60-0x0000000184C6DF70 
	
		// Constructors
		public MonoActionPanelContainer() {} // 0x0000000184C71530-0x0000000184C717A0
	
		// Methods
		// [XID] // 0x0000000189807C50-0x0000000189807C70
		public void SetupActionPanel(ActionPanelType panelType) {} // 0x0000000184C70330-0x0000000184C70B60
		// [XID] // 0x000000018980F510-0x000000018980F530
		private void LoadActionPanelPrefab(string actionPanelNameNew) {} // 0x0000000184C6D880-0x0000000184C6DAC0
		// [XID] // 0x0000000189816BC0-0x0000000189816BE0
		private void UnLoadActionPanelPrefab() {} // 0x0000000184C6D600-0x0000000184C6D760
		// [XID] // 0x000000018981E470-0x000000018981E490
		private void InstantiateActionPanel() {} // 0x0000000184C6DBE0-0x0000000184C6DE60
		// [XID] // 0x0000000189825930-0x0000000189825950
		private void SetSlotRoots() {} // 0x0000000184C6BAC0-0x0000000184C6C430
		// [XID] // 0x000000018982D0E0-0x000000018982D100
		private void SetMainPageActionButtons() {} // 0x0000000184C6AF10-0x0000000184C6B330
		// [XID] // 0x0000000189834820-0x0000000189834840
		public void InstantiateSneakActionPanel() {} // 0x0000000184C6C670-0x0000000184C6C710
		// [XID] // 0x000000018983BE90-0x000000018983BEB0
		private void SetSneakActionButtons() {} // 0x0000000184C6ABE0-0x0000000184C6ACE0
		// [XID] // 0x00000001898434C0-0x00000001898434E0
		private void SetActionBtnToPanel(GameObject btn, ActionSlotType slotType) {} // 0x0000000184C6E490-0x0000000184C6E610
		// [XID] // 0x000000018984A9E0-0x000000018984AA00
		public void Clear() {} // 0x0000000184C6A9B0-0x0000000184C6AAC0
		// [XID] // 0x0000000189851DC0-0x0000000189851DE0
		public void OnDestroy() {} // 0x0000000184C6EFA0-0x0000000184C6F040
		// [XID] // 0x0000000189859660-0x0000000189859680
		public void OnAvatarChange(AvatarEntity avatar) {} // 0x0000000184C6EA00-0x0000000184C6EB60
		// [XID] // 0x00000001898607E0-0x0000000189860800
		public void OnAvatarFocusModeChanged(bool focusAttackMode, bool showCrosshair, string dragBtnName) {} // 0x0000000184C6EB60-0x0000000184C6EFA0
		// [XID] // 0x0000000189867EB0-0x0000000189867ED0
		public void ShowSkillBtnCD(bool showCDText) {} // 0x0000000184C70B60-0x0000000184C70CD0
		// [XID] // 0x000000018986F410-0x000000018986F430
		public void ResetActionButtons() {} // 0x0000000184C6FA60-0x0000000184C6FC40
		// [XID] // 0x0000000189876A40-0x0000000189876A60
		public void TrySetCrossHairActive(bool active) {} // 0x0000000184C70DE0-0x0000000184C70F50
		// [XID] // 0x000000018987E560-0x000000018987E580
		public void OnFireUIEffect(FireUIEffect config) {} // 0x0000000184C6F1C0-0x0000000184C6F360
		// [XID] // 0x0000000189885930-0x0000000189885950
		public void OnEnergyAdded() {} // 0x0000000184C6F040-0x0000000184C6F0F0
		// [XID] // 0x000000018988CC40-0x000000018988CC60
		public void OnEnergyFull(bool full) {} // 0x0000000184C6F0F0-0x0000000184C6F1C0
		// [XID] // 0x0000000189894350-0x0000000189894370
		public void InterruptSprintButton() {} // 0x0000000184C6C710-0x0000000184C6C7C0
		// [XID] // 0x000000018989B8C0-0x000000018989B8E0
		public void PlaySprintEffect() {} // 0x0000000184C6F810-0x0000000184C6F8E0
		// [XID] // 0x00000001898A2DB0-0x00000001898A2DD0
		public void RefreshSprintButtonEnable() {} // 0x0000000184C6F990-0x0000000184C6FA60
		// [XID] // 0x00000001898AA2D0-0x00000001898AA2F0
		public void OnJumpButtonPointerDown() {} // 0x0000000184C6F360-0x0000000184C6F480
		// [XID] // 0x00000001898B1CB0-0x00000001898B1CD0
		public void EnableFlyHintEffect(bool enable) {} // 0x0000000184C6AE00-0x0000000184C6AF10
		// [XID] // 0x00000001898B98D0-0x00000001898B98F0
		public MonoBattleBtn GetSkillButtonMonoByIndex(int index) => default; // 0x0000000184C6B590-0x0000000184C6B680
		// [XID] // 0x00000001898C0CF0-0x00000001898C0D10
		public void SetSkillButtonAvatar(int index, AvatarEntity avatar) {} // 0x0000000184C6FD50-0x0000000184C6FE70
		// [XID] // 0x00000001898C85D0-0x00000001898C85F0
		public void SetSkillLeftButtonAvatar(AvatarEntity avatar) {} // 0x0000000184C6FF90-0x0000000184C700A0
		// [XID] // 0x00000001898CFFA0-0x00000001898CFFC0
		public void SetSkillButtonView(int index, AvatarEntity avatar) {} // 0x0000000184C6FE70-0x0000000184C6FF90
		// [XID] // 0x00000001898D75B0-0x00000001898D75D0
		public void SetSkillLeftButtonView(AvatarEntity avatar) {} // 0x0000000184C700A0-0x0000000184C701B0
		// [XID] // 0x00000001898DF2C0-0x00000001898DF2E0
		public void EnableChargeMaxEffect(int index, bool enable) {} // 0x0000000184C6ACE0-0x0000000184C6AE00
		// [XID] // 0x00000001898E6C80-0x00000001898E6CA0
		public void SetActivitySkillButtonView(AvatarEntity avatar) {} // 0x0000000184C6FC40-0x0000000184C6FD50
		// [XID] // 0x00000001898EE3B0-0x00000001898EE3D0
		public void OnActivitySkillButton() {} // 0x0000000184C6E610-0x0000000184C6E730
		// [XID] // 0x00000001898F5C20-0x00000001898F5C40
		public void OnSkillCDChanged(uint skillID, bool isAdd) {} // 0x0000000184C6F480-0x0000000184C6F5A0
		// [XID] // 0x00000001898FD400-0x00000001898FD420
		public void SetToNormalButtonView(int triggerSkillId) {} // 0x0000000184C70270-0x0000000184C70330
		// [XID] // 0x0000000189904CC0-0x0000000189904CE0
		public void SetToFocusButtonView(int triggerSkillId) {} // 0x0000000184C701B0-0x0000000184C70270
		// [XID] // 0x000000018990C540-0x000000018990C560
		public bool ToogleAttackModeButton() => default; // 0x0000000184C70CD0-0x0000000184C70DE0
		// [XID] // 0x0000000189913DF0-0x0000000189913E10
		public bool OnAttackModeButtonDown() => default; // 0x0000000184C6E840-0x0000000184C6E920
		// [XID] // 0x000000018991B760-0x000000018991B780
		public bool OnAttackModeButtonUp() => default; // 0x0000000184C6E920-0x0000000184C6EA00
		// [XID] // 0x0000000189922D40-0x0000000189922D60
		public bool TrySlip() => default; // 0x0000000184C70F50-0x0000000184C71080
		// [XID] // 0x000000018992A630-0x000000018992A650
		public void UpdateActionPanelView(ActionPanelState actionPanelState) {} // 0x0000000184C71080-0x0000000184C71400
		// [XID] // 0x0000000189931C00-0x0000000189931C20
		public void RefreshActionPanelView() {} // 0x0000000184C6F8E0-0x0000000184C6F990
		// [XID] // 0x0000000189939660-0x0000000189939680
		public void OnActivitySkillState(ExtraAbilityState state) {} // 0x0000000184C6E730-0x0000000184C6E840
		// [XID] // 0x0000000189940910-0x0000000189940930
		public void UpdateWidgetBtn() {} // 0x0000000184C71400-0x0000000184C71530
		// [XID] // 0x0000000189948190-0x00000001899481B0
		private void SetAllActionSlotActive(bool active) {} // 0x0000000184C6F5A0-0x0000000184C6F6E0
		// [XID] // 0x000000018994F910-0x000000018994F930
		public MonoActionBtn GetSlotButton(ActionSlotType slotType) => default; // 0x0000000184C6B680-0x0000000184C6B760
		// [XID] // 0x0000000189956EB0-0x0000000189956ED0
		private void SetActionBtnOnSlot(ActionSlotType slotType, Transform slotRoot, ConfigActionButton[] btnNameList, ActionPanelState state) {} // 0x0000000184C6C900-0x0000000184C6D060
		// [XID] // 0x000000018995EA20-0x000000018995EA40
		private GameObject GetActionButtonByType(ActionBtnType btnType) => default; // 0x0000000184C6DF70-0x0000000184C6E130
		// [XID] // 0x0000000189966140-0x0000000189966160
		private Transform GetSlotByType(ActionSlotType slotType) => default; // 0x0000000184C6C7C0-0x0000000184C6C900
		// [XID] // 0x000000018996D640-0x000000018996D660
		private Transform GetSlotGrpByType(ActionSlotType slotType) => default; // 0x0000000184C6A380-0x0000000184C6A630
		// [XID] // 0x00000001899751C0-0x00000001899751E0
		private bool CheckActionBtnShow(ActionBtnType btnType, ActionPanelState actionPanelState) => default; // 0x0000000184C69990-0x0000000184C69DB0
	}
}
