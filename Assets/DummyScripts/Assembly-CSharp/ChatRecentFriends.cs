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

public class ChatRecentFriends : IChatDataListener // TypeDefIndex: 28469
{
	// Fields
	private List<ChatFriendData> _friendList; // 0x10
	public MonoGridScroller scroller; // 0x18
	private uint _talkingUid; // 0x20
	private uint _currSelectUid; // 0x24
	private ChatChannel _talkingChannel; // 0x28
	private ChatChannel _currSelectedChannel; // 0x2C
	private ChatFriendTab _currSelected; // 0x30
	private ChatFriendTab _currHighlighted; // 0x38
	private DataPack<uint> _notifyRefreshPlayerSocialDetail; // 0x40
	private DataPack<uint, bool, ChatChannel> _notifyChangeChatTalkBgUid; // 0x48
	private int _chatDialogStatus; // 0x50

	// Constructors
	public ChatRecentFriends() {} // 0x00000001825E9690-0x00000001825E9770

	// Methods
	// [XID] // 0x0000000189966360-0x0000000189966380
	public uint GetRecommand() => default; // 0x00000001825E7240-0x00000001825E7330
	// [XID] // 0x000000018996D7C0-0x000000018996D7E0
	public void ReadFriendChatData(uint targetUid) {} // 0x00000001825E8B40-0x00000001825E8CF0
	// [XID] // 0x0000000189975360-0x0000000189975380
	public bool Navigate(ContextEventType contextEventType) => default; // 0x00000001825E89B0-0x00000001825E8B40
	// [XID] // 0x000000018997C560-0x000000018997C580
	public void SetStatus(int status) {} // 0x00000001825E9590-0x00000001825E9690
	// [XID] // 0x0000000189984280-0x00000001899842A0
	private void OnSelect(Transform trans, int index) {} // 0x00000001825E9220-0x00000001825E9590
	// [XID] // 0x000000018998BDB0-0x000000018998BDD0
	private void OnSelectLast(Transform trans, int index) {} // 0x00000001825E6DB0-0x00000001825E6F10
	// [XID] // 0x0000000189993980-0x00000001899939A0
	public bool ConfirmSelect() => default; // 0x00000001825E8480-0x00000001825E86F0
	// [XID] // 0x000000018999B280-0x000000018999B2A0
	public uint GetCurrFriendUid() => default; // 0x00000001825E82D0-0x00000001825E8480
	// [XID] // 0x00000001899A2A80-0x00000001899A2AA0
	public void InitChatFriend() {} // 0x00000001825E7330-0x00000001825E7790
	// [XID] // 0x00000001899AA380-0x00000001899AA3A0
	public void RefreshFriendTabList(bool highlightToSelect = false /* Metadata: 0x00B0D89D */) {} // 0x00000001825E8CF0-0x00000001825E8F30
	// [XID] // 0x00000001899B1DD0-0x00000001899B1DF0
	public void Refocus() {} // 0x00000001825E9110-0x00000001825E9220
	// [XID] // 0x00000001899B9110-0x00000001899B9130
	public void RefreshFriendTabByRemarkNameUpdate() {} // 0x00000001825E8180-0x00000001825E82D0
	// [XID] // 0x00000001899C09F0-0x00000001899C0A10
	private bool IsTargetTalkingWith(ChatFriendData data) => default; // 0x00000001825E7A10-0x00000001825E7AE0
	// [XID] // 0x00000001899C8200-0x00000001899C8220
	private bool IsTargetSelected(ChatFriendData data) => default; // 0x00000001825E7940-0x00000001825E7A10
	// [XID] // 0x00000001899CFBE0-0x00000001899CFC00
	private void RefreshFriendTab(Transform trans, int index) {} // 0x00000001825E7F60-0x00000001825E8180
	// [XID] // 0x00000001899D6FB0-0x00000001899D6FD0
	private void RefreshFriendTabToTalkingTarget(Transform trans, int index) {} // 0x00000001825E7030-0x00000001825E7240
	// [XID] // 0x00000001899DE520-0x00000001899DE540
	public void RemoveFriend(uint uid) {} // 0x00000001825E8F30-0x00000001825E9110
	// [XID] // 0x00000001899E6220-0x00000001899E6240
	public ChatFriendData TryFindTalkingTarget() => default; // 0x00000001825E6F10-0x00000001825E7030
	// [XID] // 0x00000001899ED5F0-0x00000001899ED610
	public ChatFriendData TalkToFriend(uint uid, bool tryAdd, ChatChannel channel) => default; // 0x00000001825E86F0-0x00000001825E89B0
	// [XID] // 0x00000001899F5180-0x00000001899F51A0
	public void Clear() {} // 0x00000001825E7790-0x00000001825E7890
	// [XID] // 0x00000001899FC710-0x00000001899FC730
	public void AddChatData(ChatChannel channel, ChatInfo chatInfo, int msgType) {} // 0x00000001825E7AE0-0x00000001825E7F60
	// [XID] // 0x0000000189A03D00-0x0000000189A03D20
	public void PushChatData(List<ChatInfo> listChatInfo) {} // 0x00000001825E7890-0x00000001825E7940
	// [XID] // 0x0000000189A0B210-0x0000000189A0B230
	public bool CheckChannel(ChatChannel channel, uint id) => default; // 0x00000001825E6CE0-0x00000001825E6DB0
}

