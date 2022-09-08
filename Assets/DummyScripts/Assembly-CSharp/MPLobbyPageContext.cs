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

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MPLobbyPageContext : BasePageContext // TypeDefIndex: 29223
{
	// Fields
	private MonoMPLobbyPage _pageMono; // 0x190
	private static List<string> _settingOptions; // 0x00
	private Mode _mode; // 0x198
	private EditMenuTarget _target; // 0x1A0
	private RectTransform _restrictRect; // 0x1A8
	private float _lastUpdateTime; // 0x1B0
	private List<uint> _playerList; // 0x1B8
	private uint _searchPlayerUid; // 0x1C0
	private uint _rttLowLimit; // 0x1C4
	private uint _rttMidLimit; // 0x1C8
	private uint _rttHighLimit; // 0x1CC
	private Dictionary<uint, MPRequestState> _currStates; // 0x1D0
	private bool _playerFilterd; // 0x1D8
	private List<int> _filteredPlayerIndex; // 0x1E0
	private bool _joinableFilterEnabled; // 0x1E8
	private bool _searchByUID; // 0x1E9
	private List<OnlinePlayerData> _playerData; // 0x1F0
	private MonoPS4IMEProxy _proxy; // 0x1F8
	private bool _isOnInputField; // 0x200

	// Nested types
	private enum Mode // TypeDefIndex: 29224
	{
		Lobby = 0,
		Team = 1
	}

	// Constructors
	public MPLobbyPageContext() {} // 0x0000000182525580-0x0000000182525840
	static MPLobbyPageContext() {} // 0x0000000182525520-0x0000000182525580

	// Methods
	// [XID] // 0x0000000189A58560-0x0000000189A58580
	public override void SetupView() {} // 0x0000000182524C20-0x0000000182525270
	// [XID] // 0x0000000189A60020-0x0000000189A60040
	protected override void BindViewCallbacks() {} // 0x000000018251C420-0x000000018251C880
	// [XID] // 0x0000000189A67C80-0x0000000189A67CA0
	public override bool OnNotify(Notify ntf) => default; // 0x0000000182524020-0x00000001825242E0
	// [XID] // 0x0000000189A6F090-0x0000000189A6F0B0
	public override void UpdateView() {} // 0x0000000182525270-0x0000000182525520
	// [XID] // 0x0000000189A768D0-0x0000000189A768F0
	public override void ClearView() {} // 0x000000018251DE80-0x000000018251DFE0
	// [XID] // 0x0000000189A7E1A0-0x0000000189A7E1C0
	private void SetupView_Lobby() {} // 0x000000018251D0C0-0x000000018251D590
	// [XID] // 0x0000000189A85B40-0x0000000189A85B60
	private void OnGetOnlinePlayerListRsp() {} // 0x00000001825212C0-0x00000001825215B0
	// [XID] // 0x0000000189A8D3E0-0x0000000189A8D400
	private void OnGetOnlinePlayerInfoNotify(uint playerUID) {} // 0x000000018251EA60-0x000000018251EB70
	// [XID] // 0x0000000189A94920-0x0000000189A94940
	private void OnGetPlayerSocialDetail(SocialDetail socialDetail) {} // 0x00000001825203F0-0x0000000182520510
	// [XID] // 0x0000000189A9C240-0x0000000189A9C260
	private void OnTeamRttRefresh(Dictionary<uint, uint> rttDict) {} // 0x000000018251D590-0x000000018251D8C0
	// [XID] // 0x0000000189AA38F0-0x0000000189AA3910
	private void RefreshPlayerListItem(Transform trans, int index) {} // 0x000000018251C340-0x000000018251C420
	// [XID] // 0x0000000189AAAFB0-0x0000000189AAAFD0
	private void RefreshPlayerListItemImpl(Transform trans, int index, int itemIndex) {} // 0x00000001825207B0-0x0000000182520FC0
	// [XID] // 0x0000000189AB2940-0x0000000189AB2960
	private void UpdatePlayerListItem(Transform trans, int itemIndex) {} // 0x000000018251D8C0-0x000000018251DE80
	// [XID] // 0x0000000189ABA470-0x0000000189ABA490
	private void RequestEnterWorld(int index) {} // 0x0000000182522340-0x0000000182522590
	// [XID] // 0x0000000189AC1DC0-0x0000000189AC1DE0
	private void SearchPlayer(uint uid) {} // 0x000000018251EBD0-0x000000018251EED0
	// [XID] // 0x0000000189AC93B0-0x0000000189AC93D0
	private void RefreshFilteredPlayerListItem(Transform trans, int itemIndex) {} // 0x00000001825215B0-0x00000001825216B0
	// [XID] // 0x0000000189AD0E40-0x0000000189AD0E60
	private void OnSearchBtnClick() {} // 0x0000000182524520-0x0000000182524800
	// [XID] // 0x0000000189AD8A70-0x0000000189AD8A90
	private void OnPasteBtnClick() {} // 0x000000018251B070-0x000000018251B170
	// [XID] // 0x0000000189AE0640-0x0000000189AE0660
	private void ChangePasteBtn(string text) {} // 0x000000018251CD60-0x000000018251D0C0
	// [XID] // 0x0000000189AE7BD0-0x0000000189AE7BF0
	private void SwitchFocusToInputField(bool value) {} // 0x00000001825242E0-0x0000000182524520
	// [XID] // 0x0000000189AEF930-0x0000000189AEF950
	private void OnClearBtnClick() {} // 0x000000018251DFE0-0x000000018251E100
	// [XID] // 0x0000000189AF6E50-0x0000000189AF6E70
	private void OnJoinableFitlerToggleChanged(bool value) {} // 0x000000018251E860-0x000000018251E920
	// [XID] // 0x0000000189AFE3C0-0x0000000189AFE3E0
	private void OnInputToggleChanged(bool value) {} // 0x000000018251E100-0x000000018251E2A0
	// [XID] // 0x0000000189B05B70-0x0000000189B05B90
	private void MpSettingTypeUpdate() {} // 0x0000000182523F30-0x0000000182524020
	// [XID] // 0x0000000189B0D300-0x0000000189B0D320
	private void OnAllowJoinChanged(int value) {} // 0x000000018251AE10-0x000000018251B070
	// [XID] // 0x0000000189B14860-0x0000000189B14880
	private void SetupExitButton() {} // 0x0000000182521C60-0x0000000182521F00
	// [XID] // 0x0000000189B1C180-0x0000000189B1C1A0
	private void SetupView_Team() {} // 0x000000018251F1A0-0x000000018251F610
	// [XID] // 0x0000000189B23810-0x0000000189B23830
	private void RefreshTeamScroller() {} // 0x00000001825216B0-0x0000000182521B00
	// [XID] // 0x0000000189B2AAB0-0x0000000189B2AAD0
	private void RefreshTeamRow(Transform trans, int index) {} // 0x00000001825230F0-0x00000001825238A0
	// [XID] // 0x0000000189B31FE0-0x0000000189B32000
	private void OnIconBtnClick(uint uid, EditMenuTarget target, MonoGridScroller scroller) {} // 0x00000001825210E0-0x00000001825212C0
	// [XID] // 0x0000000189B397A0-0x0000000189B397C0
	private void OnKickClicked(MonoMPTeamRow ins) {} // 0x0000000182522BF0-0x0000000182522FB0
	// [XID] // 0x0000000189B41150-0x0000000189B41170
	private void OnAddClicked(MonoMPTeamRow ins) {} // 0x0000000182521F00-0x0000000182522010
	// [XID] // 0x0000000189B48A40-0x0000000189B48A60
	private void OnKickGuestFailed(uint playerUID) {} // 0x0000000182520510-0x0000000182520750
	// [XID] // 0x0000000189B501D0-0x0000000189B501F0
	private void OnExitClicked() {} // 0x0000000182522FB0-0x0000000182523090
	// [XID] // 0x0000000189B57A00-0x0000000189B57A20
	private void ShowIntroductionTips() {} // 0x0000000182524B10-0x0000000182524C20
	// [XID] // 0x0000000189B5F370-0x0000000189B5F390
	private void OnOutMatching() {} // 0x000000018251CBA0-0x000000018251CD60
	// [XID] // 0x0000000189B66960-0x0000000189B66980
	private void PlayerMatchInfoUpdate() {} // 0x00000001825238A0-0x0000000182523EA0
	// [XID] // 0x0000000189B6DEC0-0x0000000189B6DEE0
	private void RefreshMatchTimeView() {} // 0x0000000182522010-0x0000000182522340
	// [XID] // 0x0000000189B755B0-0x0000000189B755D0
	private void RefreshQuitMpValidTimeView() {} // 0x000000018251AB10-0x000000018251AE10
	// [XID] // 0x0000000189B7C9E0-0x0000000189B7CA00
	private void OnWorldPlayerListUpdate() {} // 0x0000000182520FC0-0x00000001825210E0
	// [XID] // 0x0000000189B84860-0x0000000189B84880
	private void SetBlockChatImg(uint uid) {} // 0x0000000182522590-0x0000000182522BF0
	// [XID] // 0x0000000189B8B6F0-0x0000000189B8B710
	private void InitLobbyJoypadState() {} // 0x000000018251B170-0x000000018251B2D0
	// [XID] // 0x0000000189B92E20-0x0000000189B92E40
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x000000018251EED0-0x000000018251F020
	// [XID] // 0x0000000189B9A3E0-0x0000000189B9A400
	private bool HanldeLobbyNormalInputActionEvent(InputActionEvent actionEvent) => default; // 0x000000018251B2D0-0x000000018251C340
	// [XID] // 0x0000000189BA1B10-0x0000000189BA1B30
	private void RefreshCurrentPS4JoinButton() {} // 0x000000018251E560-0x000000018251E750
	// [XID] // 0x0000000189BA8F90-0x0000000189BA8FB0
	private bool HandleCommonLeftStickButtonEvent() => default; // 0x000000018251C880-0x000000018251CA10
	// [XID] // 0x0000000189BB0700-0x0000000189BB0720
	private bool HandleLobbyMultiSettingInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000182524800-0x0000000182524B10
	// [XID] // 0x0000000189BB7A80-0x0000000189BB7AA0
	private bool HanldeTeamInputActionEvent(InputActionEvent actionEvent) => default; // 0x000000018251F610-0x00000001825203F0
	// [XID] // 0x0000000189BBF0A0-0x0000000189BBF0C0
	private void OnPlayerListJoypadSelectChange(RectTransform trans, bool select) {} // 0x000000018251E920-0x000000018251EA60
	// [XID] // 0x0000000189BC6D70-0x0000000189BC6D90
	private void RefreshPlayerItemSelectState(MonoMultiplayerRow item, int index) {} // 0x000000018251CA10-0x000000018251CBA0
	// [XID] // 0x0000000189BCEA20-0x0000000189BCEA40
	private static void OnTeamListJoypadSelectChange(RectTransform trans, bool select) {} // 0x000000018251F020-0x000000018251F140
	// [XID] // 0x0000000189BD5D00-0x0000000189BD5D20
	private void RefreshTeamItemSelectState(MonoMPTeamRow item, int index) {} // 0x000000018251E340-0x000000018251E4D0
	// [XID] // 0x0000000189BDD990-0x0000000189BDD9B0
	private void RefreshTeamButtonTips() {} // 0x0000000182521B00-0x0000000182521C60
	// [XID] // 0x00000001895EA570-0x00000001895EA590
	private void ResolveScrollerItemsJoypadIcon(MonoGridScroller scroller) {} // 0x000000018251E750-0x000000018251E860
}

