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

public sealed class ChatAddFriendDialog : BaseDialogContext // TypeDefIndex: 28446
{
	// Fields
	private MonoChatAddFriend _dialogMono; // 0x178
	private List<uint> _friendList; // 0x180

	// Constructors
	public ChatAddFriendDialog() {} // 0x0000000181583640-0x0000000181583710

	// Methods
	// [XID] // 0x00000001899008A0-0x00000001899008C0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x00000001815826F0-0x0000000181582C60
	// [XID] // 0x0000000189908070-0x0000000189908090
	public override void SetupView() {} // 0x0000000181583570-0x0000000181583640
	// [XID] // 0x000000018990F800-0x000000018990F820
	protected override void BindViewCallbacks() {} // 0x0000000181582160-0x0000000181582260
	// [XID] // 0x0000000189917250-0x0000000189917270
	public override bool OnNotify(Notify ntf) => default; // 0x0000000181583280-0x0000000181583390
	// [XID] // 0x000000018991E950-0x000000018991E970
	private int CompareFriendItem(uint x, uint y) => default; // 0x0000000181583390-0x0000000181583570
	// [XID] // 0x00000001899261F0-0x0000000189926210
	private void RefreshFriendList() {} // 0x0000000181582CC0-0x00000001815830A0
	// [XID] // 0x000000018992D8E0-0x000000018992D900
	private void RefreshButton(bool show) {} // 0x0000000181582030-0x0000000181582160
	// [XID] // 0x0000000189934D90-0x0000000189934DB0
	private void RefreshFriendListRow(Transform trans, int index) {} // 0x0000000181581480-0x0000000181582030
	// [XID] // 0x000000018993C880-0x000000018993C8A0
	private void TryChatWithFriend(uint uid) {} // 0x00000001815824B0-0x0000000181582690
	// [XID] // 0x0000000189943E70-0x0000000189943E90
	private void OnIconBtnClick(uint uid) {} // 0x00000001815830A0-0x0000000181583190
	// [XID] // 0x000000018994B3B0-0x000000018994B3D0
	private string GetOfflineTimeText(uint day) => default; // 0x0000000181582300-0x0000000181582420
	// [XID] // 0x0000000189952DC0-0x0000000189952DE0
	public override void ClearView() {} // 0x0000000181582260-0x0000000181582300
}

