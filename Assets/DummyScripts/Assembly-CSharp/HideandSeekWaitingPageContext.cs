/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class HideandSeekWaitingPageContext : BaseDialogContext // TypeDefIndex: 30188
{
	// Fields
	private MonoHideandSeekWaitingPage _pageMono; // 0x178
	private HideAndSeekPlayerBattleInfo _selfBattleInfo; // 0x180
	private ActivityCountdownWidgetContext _countDownWidgetContext; // 0x188
	private List<uint> _avatarList; // 0x190
	private uint _toSelectAvatarId; // 0x198
	private int _toSelectAvatarIndex; // 0x19C
	private Dictionary<uint, uint> _bonusAvatarDic; // 0x1A0
	private List<uint> _selectedSkillList; // 0x1A8
	private List<uint> _skillList; // 0x1B0
	private int _skillIconIndex; // 0x1B8
	private uint _toSelectSkillId; // 0x1BC
	private int _toSelectSkillIndex; // 0x1C0
	private Button _btnReady; // 0x1C8
	private Color _hideColor; // 0x1D0
	private Color _huntColor; // 0x1E0
	private bool _allReady; // 0x1F0
	private bool _isChatEnabled; // 0x1F1

	// Constructors
	public HideandSeekWaitingPageContext() {} // 0x000000018222AA90-0x000000018222AC60

	// Methods
	// [XID] // 0x000000018967E790-0x000000018967E7B0
	public override void SetupView() {} // 0x000000018222A610-0x000000018222A870
	// [XID] // 0x0000000189685FE0-0x0000000189686000
	public override void ClearView() {} // 0x00000001822253B0-0x0000000182225490
	// [XID] // 0x000000018968DDB0-0x000000018968DDD0
	protected override void BindViewCallbacks() {} // 0x00000001822246A0-0x00000001822248A0
	// [XID] // 0x0000000189695720-0x0000000189695740
	public override bool OnNotify(Notify ntf) => default; // 0x000000018222A4E0-0x000000018222A610
	// [XID] // 0x000000018969CD50-0x000000018969CD70
	public override void UpdateView() {} // 0x000000018222A870-0x000000018222AA90
	// [XID] // 0x00000001896A4080-0x00000001896A40A0
	public void CheckStage() {} // 0x0000000182227AD0-0x0000000182227B70
	// [XID] // 0x00000001896AB660-0x00000001896AB680
	private void RefreshPlayerList(HideAndSeekStageInfo hideAndSeekInfo) {} // 0x00000001822263B0-0x0000000182226500
	// [XID] // 0x00000001896B28B0-0x00000001896B28D0
	private void RefreshView() {} // 0x00000001822271D0-0x0000000182227AD0
	// [XID] // 0x00000001896BA020-0x00000001896BA040
	private int SkillSort(uint a, uint b) => default; // 0x000000018222A060-0x000000018222A1D0
	// [XID] // 0x00000001896C12D0-0x00000001896C12F0
	private void RefreshPlayerListRow(Transform trans, int index) {} // 0x00000001822257F0-0x0000000182225E10
	// [XID] // 0x00000001896C89B0-0x00000001896C89D0
	private void RefreshLeftSkillRow(Transform trans, int index) {} // 0x0000000182224FA0-0x00000001822253B0
	// [XID] // 0x00000001896D0380-0x00000001896D03A0
	private void OnAvatarIconClick() {} // 0x0000000182229330-0x00000001822295F0
	// [XID] // 0x00000001896D78C0-0x00000001896D78E0
	private void SetAvatarSelectView() {} // 0x0000000182229070-0x0000000182229330
	// [XID] // 0x00000001896DF0A0-0x00000001896DF0C0
	private void CloseAvatarSelectPanel() {} // 0x0000000182225FF0-0x00000001822263B0
	// [XID] // 0x00000001896E6510-0x00000001896E6530
	private void OnAvatarRowClick(int index) {} // 0x0000000182226C60-0x0000000182226F60
	// [XID] // 0x00000001896EDA80-0x00000001896EDAA0
	private void OnSelectAvatar() {} // 0x0000000182224EC0-0x0000000182224FA0
	// [XID] // 0x00000001896F5250-0x00000001896F5270
	private void OnHideAndSeekPlayerSetAvatarNotify(uint uid) {} // 0x0000000182228970-0x0000000182228C60
	// [XID] // 0x00000001896FCAB0-0x00000001896FCAD0
	private void RefreshSelectAvatar(uint avatarId) {} // 0x0000000182228EA0-0x0000000182228FC0
	// [XID] // 0x0000000189703F70-0x0000000189703F90
	private void RefreshSelectedAvatarState() {} // 0x0000000182228C60-0x0000000182228E40
	// [XID] // 0x000000018970B860-0x000000018970B880
	private void RefreshSelectAvatarButtonState() {} // 0x0000000182226B10-0x0000000182226C60
	// [XID] // 0x00000001897130F0-0x0000000189713110
	private void InitToSelectAvatarIndex() {} // 0x00000001822295F0-0x0000000182229710
	// [XID] // 0x000000018971A910-0x000000018971A930
	private void RefreshAvatarList() {} // 0x0000000182227DE0-0x0000000182228150
	// [XID] // 0x0000000189721C70-0x0000000189721C90
	private uint CheckIsBonusAvatar(AvatarDataItem avatarData) => default; // 0x0000000182228FC0-0x0000000182229070
	// [XID] // 0x00000001897292E0-0x0000000189729300
	private void RefreshAvatarRow(Transform trans, int index) {} // 0x00000001822282C0-0x00000001822285C0
	// [XID] // 0x0000000189730B40-0x0000000189730B60
	private void OnSkillIconClick(int index) {} // 0x0000000182229710-0x0000000182229AC0
	// [XID] // 0x0000000189738470-0x0000000189738490
	private void SetSkillSelectView(int index) {} // 0x0000000182226670-0x00000001822268A0
	// [XID] // 0x00000001897401B0-0x00000001897401D0
	private void CloseSkillSelectPanel() {} // 0x00000001822248A0-0x0000000182224C60
	// [XID] // 0x0000000189747560-0x0000000189747580
	private void OnSkillRowClick(int index) {} // 0x0000000182228670-0x0000000182228970
	// [XID] // 0x000000018974ECB0-0x000000018974ECD0
	private void OnSelectSkill() {} // 0x0000000182227BD0-0x0000000182227D20
	// [XID] // 0x00000001897563C0-0x00000001897563E0
	private void OnHideAndSeekSelectSkillRsp() {} // 0x00000001822285C0-0x0000000182228670
	// [XID] // 0x000000018975D7A0-0x000000018975D7C0
	private void RefreshSelectedSkillState() {} // 0x0000000182226930-0x0000000182226B10
	// [XID] // 0x0000000189764DF0-0x0000000189764E10
	private void RefreshSelectSkillButtonState() {} // 0x0000000182226500-0x0000000182226670
	// [XID] // 0x000000018976C850-0x000000018976C870
	private void InitToSelectSkillIndex() {} // 0x0000000182224C60-0x0000000182224D80
	// [XID] // 0x0000000189773CF0-0x0000000189773D10
	private void RefreshSkillList(uint skillId) {} // 0x0000000182229AC0-0x0000000182229D30
	// [XID] // 0x000000018977B3A0-0x000000018977B3C0
	private void RefreshSkillRow(Transform trans, int index) {} // 0x0000000182229D30-0x000000018222A060
	// [XID] // 0x0000000189782EE0-0x0000000189782F00
	private void SetChatPanelStatus(bool bchatPanel, bool bchatBtn) {} // 0x0000000182225490-0x00000001822257F0
	// [XID] // 0x000000018978A370-0x000000018978A390
	private void DoCheckMainPageChat() {} // 0x0000000182228150-0x00000001822282C0
	// [XID] // 0x0000000189791BD0-0x0000000189791BF0
	private void CheckChatPage(bool isOn) {} // 0x0000000182224D80-0x0000000182224EC0
	// [XID] // 0x00000001897991B0-0x00000001897991D0
	private void OnChat() {} // 0x0000000182224440-0x00000001822245E0
	// [XID] // 0x00000001897A10B0-0x00000001897A10D0
	private void OnBtnReady() {} // 0x0000000182226F60-0x0000000182227040
	// [XID] // 0x00000001897A8720-0x00000001897A8740
	private void OnHideAndSeekPlayerReadyNotify() {} // 0x0000000182225E10-0x0000000182225F50
	// [XID] // 0x00000001897B0120-0x00000001897B0140
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001822270A0-0x00000001822271D0
	// [XID] // 0x00000001897B7E50-0x00000001897B7E70
	public override void OnJoypadUIModuleSelectIndex(MonoJoypadUIModule sourceModule, int index, Transform transform, JoypadSelectIndexResult selectResult = JoypadSelectIndexResult.Normal /* Metadata: 0x00B108A2 */) {} // 0x000000018222A2C0-0x000000018222A4E0
}

