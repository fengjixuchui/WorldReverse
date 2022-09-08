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

public sealed class FriendPageContext : BasePageContext // TypeDefIndex: 29112
{
	// Fields
	private MonoFriendPage _pageMono; // 0x190
	private FriendPageType _type; // 0x198
	private List<uint> _friendList; // 0x1A0
	private List<uint> _friendRequestList; // 0x1A8
	private List<uint> _multiplayRecentlyList; // 0x1B0
	private FriendListSortType _sortType; // 0x1B8
	private bool _isAsce; // 0x1BC
	private ChatPageContext chatContext; // 0x1C0
	private EditMenuTarget _target; // 0x1C8
	private RectTransform _restrictRect; // 0x1D0
	private Dictionary<uint, MPRequestState> _currStates; // 0x1D8
	private uint _currSelectedFriendID; // 0x1E0
	private uint _currSelectedRequestID; // 0x1E4
	private bool _isOnInputField; // 0x1E8
	private MonoPS4IMEProxy _proxy; // 0x1F0

	// Properties
	public FriendPageType type { /* [XID] */ /* 0x0000000189AF9F80-0x0000000189AF9FA0 */ get => default; } // 0x000000018390F760-0x000000018390F800 

	// Constructors
	public FriendPageContext() {} // 0x00000001839103F0-0x0000000183910570

	// Methods
	// [XID] // 0x0000000189B01490-0x0000000189B014B0
	public override void SetupView() {} // 0x000000018390FC80-0x000000018390FF40
	// [XID] // 0x0000000189B089A0-0x0000000189B089C0
	private void SetupJoypadScrollerSound() {} // 0x0000000183907410-0x0000000183907580
	// [XID] // 0x0000000189B103C0-0x0000000189B103E0
	private void PlayJoypadSelectedSound(Transform trans, int index) {} // 0x0000000183907C70-0x0000000183907DA0
	// [XID] // 0x0000000189B17500-0x0000000189B17520
	public override void ClearView() {} // 0x0000000183906BD0-0x0000000183906CD0
	// [XID] // 0x0000000189B1EE20-0x0000000189B1EE40
	protected override void BindViewCallbacks() {} // 0x0000000183906340-0x00000001839066D0
	// [XID] // 0x0000000189B26790-0x0000000189B267B0
	public override bool OnNotify(Notify ntf) => default; // 0x000000018390F460-0x000000018390F650
	// [XID] // 0x0000000189B2D9A0-0x0000000189B2D9C0
	protected override void OnEnable() {} // 0x000000018390F370-0x000000018390F460
	// [XID] // 0x0000000189B34DC0-0x0000000189B34DE0
	public override void UpdateView() {} // 0x000000018390FF40-0x00000001839103F0
	// [XID] // 0x0000000189B3C650-0x0000000189B3C670
	private void RequestFriendList() {} // 0x0000000183909640-0x0000000183909740
	// [XID] // 0x0000000189B442F0-0x0000000189B44310
	private void RequestMultiplayRecentlyList() {} // 0x00000001839055B0-0x0000000183905690
	// [XID] // 0x0000000189B4B9E0-0x0000000189B4BA00
	private void SetCommonView() {} // 0x000000018390A330-0x000000018390A5F0
	// [XID] // 0x0000000189B52FD0-0x0000000189B52FF0
	private void RerfreshCurrFriendNumText() {} // 0x0000000183906A30-0x0000000183906BD0
	// [XID] // 0x0000000189B5A9A0-0x0000000189B5A9C0
	private void SetMenuTab() {} // 0x000000018390EBA0-0x000000018390EF70
	// [XID] // 0x0000000189B61E30-0x0000000189B61E50
	private void SetupSortTypeDropdown() {} // 0x00000001839080B0-0x0000000183908390
	// [XID] // 0x0000000189B69AC0-0x0000000189B69AE0
	private FriendListSortType SortDropdownIndexToType(int index) => default; // 0x000000018390B9F0-0x000000018390BAB0
	// [XID] // 0x0000000189B71060-0x0000000189B71080
	private void OnSortTypeChange(int index) {} // 0x000000018390BAB0-0x000000018390BCC0
	// [XID] // 0x0000000189B78650-0x0000000189B78670
	public void SortFriendList(List<uint> friendList, FriendListSortType sortType, bool isAsce = false /* Metadata: 0x00B0EC4C */) {} // 0x000000018390E400-0x000000018390E540
	// [XID] // 0x0000000189B7FBF0-0x0000000189B7FC10
	private int CompareFriendItem(uint x, uint y) => default; // 0x000000018390F800-0x000000018390FA10
	// [XID] // 0x0000000189B87620-0x0000000189B87640
	private void ChangeSortOrder() {} // 0x000000018390BCC0-0x000000018390BEC0
	// [XID] // 0x0000000189B8E790-0x0000000189B8E7B0
	private void OnTabClicked(int index) {} // 0x0000000183908F20-0x00000001839090D0
	// [XID] // 0x0000000189B95CB0-0x0000000189B95CD0
	private void OnTabClickedInitial(int index) {} // 0x0000000183908CA0-0x0000000183908E40
	// [XID] // 0x0000000189B9D1F0-0x0000000189B9D210
	private void SetContentView(bool withAnimation = true /* Metadata: 0x00B0EC4D */, bool initial = false /* Metadata: 0x00B0EC4E */) {} // 0x000000018390EF70-0x000000018390F150
	// [XID] // 0x0000000189BA4B90-0x0000000189BA4BB0
	private void SetFriendListView(bool withAnimation, bool initial) {} // 0x000000018390D380-0x000000018390DAA0
	// [XID] // 0x0000000189BABED0-0x0000000189BABEF0
	private void SetAddFriendView(bool withAnimation, bool initial) {} // 0x000000018390E540-0x000000018390EBA0
	// [XID] // 0x0000000189BB3540-0x0000000189BB3560
	private void SetMultiplayRecentlyView(bool withAnimation, bool initial) {} // 0x0000000183907580-0x0000000183907C70
	// [XID] // 0x0000000189BBAB80-0x0000000189BBABA0
	private void OnSearchBtnClick() {} // 0x000000018390FA10-0x000000018390FC80
	// [XID] // 0x0000000189BC2B90-0x0000000189BC2BB0
	private void OnGetPlaySocialDetailNotify(SocialDetail serverData) {} // 0x000000018390DCE0-0x000000018390DF10
	// [XID] // 0x0000000189BCA2A0-0x0000000189BCA2C0
	private void UpdateFriendBriefFromSocial(Dictionary<uint, FriendBriefStruct> dataDic, SocialDetailStruct socialDetail) {} // 0x0000000183909740-0x0000000183909930
	// [XID] // 0x0000000189BD1930-0x0000000189BD1950
	private void RefreshFriendList(bool withAnimation) {} // 0x000000018390A8A0-0x000000018390B070
	// [XID] // 0x0000000189BD8EE0-0x0000000189BD8F00
	private void RefreshFriendRequestList(bool withAnimation) {} // 0x000000018390BEC0-0x000000018390C540
	// [XID] // 0x00000001895E5AA0-0x00000001895E5AC0
	private void RefreshFriendListRow(Transform trans, int index) {} // 0x00000001839045A0-0x00000001839053F0
	// [XID] // 0x00000001895ED3D0-0x00000001895ED3F0
	private void TryChatWithFriend(uint uid) {} // 0x0000000183909430-0x0000000183909640
	// [XID] // 0x00000001895F4B10-0x00000001895F4B30
	private void RefreshMultiplayRecentlyListRow(Transform trans, int index) {} // 0x000000018390C540-0x000000018390D2A0
	// [XID] // 0x00000001895FC220-0x00000001895FC240
	private void RefreshMPFriendList(MonoFriendListRow ins, uint uid, FriendBriefStruct friendData) {} // 0x00000001839090D0-0x0000000183909430
	// [XID] // 0x0000000189603BE0-0x0000000189603C00
	private void RequestEnterWorld(MonoFriendListRow ins, uint uid, bool canEnter = true /* Metadata: 0x00B0EC4F */) {} // 0x000000018390DAA0-0x000000018390DCE0
	// [XID] // 0x000000018960B560-0x000000018960B580
	private void RefreshFriendRequestListRow(Transform trans, int index) {} // 0x0000000183908390-0x0000000183908CA0
	// [XID] // 0x0000000189612930-0x0000000189612950
	private void OnSelectorChange(Transform trans, int index) {} // 0x0000000183906CD0-0x0000000183906F10
	// [XID] // 0x000000018961A2A0-0x000000018961A2C0
	private void OnSelectorChangeForLast(Transform trans, int index) {} // 0x0000000183907150-0x00000001839072F0
	// [XID] // 0x00000001896217F0-0x0000000189621810
	private void UpdateItemState(Transform trans, uint uid, FriendBriefStruct friendData) {} // 0x0000000183903EA0-0x00000001839044A0
	// [XID] // 0x00000001896290C0-0x00000001896290E0
	private string GetOfflineTimeText(uint day) => default; // 0x00000001839072F0-0x0000000183907410
	// [XID] // 0x0000000189630A20-0x0000000189630A40
	private void OnFriendAddRejectBtnClick(uint uid) {} // 0x00000001839058F0-0x0000000183905A00
	// [XID] // 0x0000000189638500-0x0000000189638520
	private void OnFriendAddAcceptBtnClick(uint uid) {} // 0x000000018390F650-0x000000018390F760
	// [XID] // 0x000000018963F960-0x000000018963F980
	private void OnIconBtnClick(uint uid, EditMenuTarget target, MonoGridScroller scroller) {} // 0x000000018390B8A0-0x000000018390B9F0
	// [XID] // 0x0000000189647160-0x0000000189647180
	private void OnPasteBtnClick() {} // 0x00000001839044A0-0x00000001839045A0
	// [XID] // 0x000000018964E830-0x000000018964E850
	private void OnClearBtnClick() {} // 0x0000000183906F10-0x0000000183907010
	// [XID] // 0x0000000189656020-0x0000000189656040
	private void ChangePasteBtn(string text) {} // 0x00000001839066D0-0x0000000183906A30
	// [XID] // 0x000000018965D820-0x000000018965D840
	private void SetBlockChatImg(uint uid) {} // 0x000000018390DF10-0x000000018390E3A0
	// [XID] // 0x0000000189664F00-0x0000000189664F20
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x000000018390A5F0-0x000000018390A840
	// [XID] // 0x000000018966C540-0x000000018966C560
	private bool HandleFriendListInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000183905AE0-0x0000000183906340
	// [XID] // 0x00000001896743E0-0x0000000189674400
	private bool HandleMultiplayRecentlyInputActionEvent(InputActionEvent actionEvent) => default; // 0x000000018390B070-0x000000018390B640
	// [XID] // 0x000000018967BBC0-0x000000018967BBE0
	private void CheckShowJoin(MonoFriendListRow _currentRow) {} // 0x00000001839053F0-0x00000001839055B0
	// [XID] // 0x00000001896832B0-0x00000001896832D0
	private void ResolveFriendListBtnShow(MonoFriendListRow row) {} // 0x000000018390F150-0x000000018390F2E0
	// [XID] // 0x000000018968AE20-0x000000018968AE40
	private void ResolveMultiplayRecentlyListBtnShow(MonoFriendListRow row) {} // 0x0000000183905690-0x0000000183905810
	// [XID] // 0x0000000189692AF0-0x0000000189692B10
	private bool HandleFriendAddInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000183909930-0x000000018390A2D0
	// [XID] // 0x0000000189699E00-0x0000000189699E20
	private void SwitchToAddInputField() {} // 0x0000000183907F30-0x00000001839080B0
	// [XID] // 0x00000001896A1560-0x00000001896A1580
	private void ResolveFriendRequestListBtnShow() {} // 0x000000018390B6A0-0x000000018390B8A0
	// [XID] // 0x00000001896A8A20-0x00000001896A8A40
	private void OnPrevBtnClick() {} // 0x0000000183905A00-0x0000000183905AE0
	// [XID] // 0x00000001896AFBA0-0x00000001896AFBC0
	private void OnNextBtnClick() {} // 0x0000000183905810-0x00000001839058F0
	// [XID] // 0x00000001896B74F0-0x00000001896B7510
	private void OnBlacklistBtnClick() {} // 0x0000000183907E30-0x0000000183907F30
	// [XID] // 0x00000001896BE640-0x00000001896BE660
	private List<uint> GetFriendList() => default; // 0x000000018390D2A0-0x000000018390D380
	// [XID] // 0x00000001896C5EF0-0x00000001896C5F10
	private List<uint> GetFriendRequestList() => default; // 0x0000000183907070-0x0000000183907150
	// [XID] // 0x00000001896CD5C0-0x00000001896CD5E0
	private List<uint> GetMultiplayRecentlyList() => default; // 0x0000000183908E40-0x0000000183908F20
}

