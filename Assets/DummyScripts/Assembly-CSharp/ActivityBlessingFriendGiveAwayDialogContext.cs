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

public sealed class ActivityBlessingFriendGiveAwayDialogContext : BaseDialogContext // TypeDefIndex: 29488
{
	// Fields
	private MonoActivityBlessingFriendGiveAwayDialog _dialogMono; // 0x178
	private List<uint> _albumList; // 0x180
	private MapField<uint, uint> _photoMap; // 0x188
	private int _curPanelTabIndex; // 0x190
	private List<MonoBtnTab> _tabList; // 0x198
	private List<BlessingFriendPicData> _sendList; // 0x1A0
	private List<BlessingRecvPicRecord> _receiveList; // 0x1A8
	private int _currFriendIndex; // 0x1B0

	// Nested types
	private enum PanelState // TypeDefIndex: 29489
	{
		Send = 0,
		Receive = 1
	}

	// Constructors
	public ActivityBlessingFriendGiveAwayDialogContext() {} // 0x0000000181D3CFC0-0x0000000181D3D0F0

	// Methods
	// [XID] // 0x0000000189AA5130-0x0000000189AA5150
	public override void SetupView() {} // 0x0000000181D3CED0-0x0000000181D3CFC0
	// [XID] // 0x0000000189AAC8B0-0x0000000189AAC8D0
	public override void ClearView() {} // 0x0000000181D39EC0-0x0000000181D39F60
	// [XID] // 0x0000000189AB4170-0x0000000189AB4190
	protected override void BindViewCallbacks() {} // 0x0000000181D39A70-0x0000000181D39BD0
	// [XID] // 0x0000000189ABBEB0-0x0000000189ABBED0
	public override bool OnNotify(Notify ntf) => default; // 0x0000000181D3C6A0-0x0000000181D3C850
	// [XID] // 0x0000000189AC3640-0x0000000189AC3660
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000181D3A7A0-0x0000000181D3AA20
	// [XID] // 0x0000000189ACACD0-0x0000000189ACACF0
	private void OnGetPlaySocialDetailNotify(SocialDetail serverData) {} // 0x0000000181D3C100-0x0000000181D3C1E0
	// [XID] // 0x0000000189AD2740-0x0000000189AD2760
	private void SetupTab() {} // 0x0000000181D3A5C0-0x0000000181D3A740
	// [XID] // 0x0000000189ADA1D0-0x0000000189ADA1F0
	private void RefreshTab(Transform trans, int index) {} // 0x0000000181D3BE90-0x0000000181D3C100
	// [XID] // 0x0000000189AE1A90-0x0000000189AE1AB0
	private void OnTabClicked(int index) {} // 0x0000000181D3A1D0-0x0000000181D3A5C0
	// [XID] // 0x0000000189AE9240-0x0000000189AE9260
	private void RefreshCurrentPanel() {} // 0x0000000181D3C320-0x0000000181D3C3E0
	// [XID] // 0x0000000189AF1050-0x0000000189AF1070
	private void RefreshFriendListRow(Transform trans, int index) {} // 0x0000000181D392B0-0x0000000181D39650
	// [XID] // 0x0000000189AF84F0-0x0000000189AF8510
	private void RefreshReceiveListRow(Transform trans, int index) {} // 0x0000000181D3B590-0x0000000181D3BA30
	// [XID] // 0x0000000189AFFC00-0x0000000189AFFC20
	private void RefreshFriendData(MonoActivityBlessingFriendListRow item, uint uid, uint avatarId, string nickName, string remarkName, string signature) {} // 0x0000000181D3BB10-0x0000000181D3BE90
	// [XID] // 0x0000000189B071B0-0x0000000189B071D0
	private void SetupAlbumPanel() {} // 0x0000000181D3B1E0-0x0000000181D3B4B0
	// [XID] // 0x0000000189B0E990-0x0000000189B0E9B0
	private void RefreshPhoto(Transform trans, int index) {} // 0x0000000181D39D00-0x0000000181D39EC0
	// [XID] // 0x0000000189B15D60-0x0000000189B15D80
	private void RefreshFriendPhoto(Transform trans, int index) {} // 0x0000000181D3AF50-0x0000000181D3B1E0
	// [XID] // 0x0000000189B1D490-0x0000000189B1D4B0
	private void ShowGiveFriendPicConfirmDialog(int index, uint picId) {} // 0x0000000181D3C990-0x0000000181D3CE10
	// [XID] // 0x0000000189B24D10-0x0000000189B24D30
	private int RecvPicRecordSortOrder(BlessingRecvPicRecord record1, BlessingRecvPicRecord record2) => default; // 0x0000000181D39BD0-0x0000000181D39D00
	// [XID] // 0x0000000189B2C1C0-0x0000000189B2C1E0
	private void OnBtnAllGet() {} // 0x0000000181D3B4B0-0x0000000181D3B590
	// [XID] // 0x0000000189B33750-0x0000000189B33770
	private void ShowEmtpyText(bool show) {} // 0x0000000181D39F60-0x0000000181D3A0A0
	// [XID] // 0x0000000189B3B070-0x0000000189B3B090
	public override void OnJoypadUIModuleSelectIndex(MonoJoypadUIModule sourceModule, int index, Transform transform, JoypadSelectIndexResult selectResult = JoypadSelectIndexResult.Normal /* Metadata: 0x00B0F865 */) {} // 0x0000000181D3C470-0x0000000181D3C6A0
	// [XID] // 0x0000000189B42870-0x0000000189B42890
	protected override void RegisterHandlePacket() {} // 0x0000000181D3CE10-0x0000000181D3CED0
	// [XID] // 0x0000000189B4A390-0x0000000189B4A3B0
	public override bool OnPacket(Packet packet) => default; // 0x0000000181D3C850-0x0000000181D3C990
	// [XID] // 0x0000000189B51B30-0x0000000189B51B50
	private void RequestBlessingGetFriendPicList() {} // 0x0000000181D3BA30-0x0000000181D3BB10
	// [XID] // 0x0000000189B592F0-0x0000000189B59310
	private void OnBlessingGetFriendPicListRsp(BlessingGetFriendPicListRsp rsp) {} // 0x0000000181D39650-0x0000000181D399F0
	// [XID] // 0x0000000189B60BC0-0x0000000189B60BE0
	private void RequestBlessingGetAllRecvPicRecordList() {} // 0x0000000181D3C1E0-0x0000000181D3C2C0
	// [XID] // 0x0000000189B68230-0x0000000189B68250
	private void OnBlessingGetAllRecvPicRecordListRsp(BlessingGetAllRecvPicRecordListRsp rsp) {} // 0x0000000181D3AA80-0x0000000181D3AF50
}

