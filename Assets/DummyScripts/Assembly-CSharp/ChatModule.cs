/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ChatModule : BaseModule // TypeDefIndex: 21420
{
	// Fields
	public static bool testChat; // 0x00
	private DateTime cdTime; // 0x10
	public static ChatPageContext chatPageContext; // 0x08
	public readonly uint MaxPullNum; // 0x20

	// Constructors
	public ChatModule() {} // 0x00000001841737B0-0x0000000184173870
	static ChatModule() {} // 0x0000000184173740-0x00000001841737B0

	// Methods
	// [XID] // 0x00000001899ABFB0-0x00000001899ABFD0
	public static ChatInfo GenerateFakeChatInfo() => default; // 0x0000000184170EE0-0x00000001841710D0
	// [XID] // 0x00000001899B3820-0x00000001899B3840
	public string CheckContent(string content) => default; // 0x0000000184172F50-0x0000000184173130
	// [IDTag] // 0x00000001899BAC00-0x00000001899BAC40
	// [XID] // 0x00000001899BAC00-0x00000001899BAC40
	public void Talk(ChatChannel channel, string content, uint uid = 0 /* Metadata: 0x00AFF7C4 */) {} // 0x0000000184171E70-0x0000000184172320
	// [IDTag] // 0x00000001899C56B0-0x00000001899C56F0
	// [XID] // 0x00000001899C56B0-0x00000001899C56F0
	public void Talk(ChatChannel channel, int index, uint uid = 0 /* Metadata: 0x00AFF7C8 */) {} // 0x0000000184172320-0x00000001841725C0
	// [XID] // 0x00000001899CFE10-0x00000001899CFE30
	public void PullPrivateChat(uint targetUid) {} // 0x0000000184171150-0x0000000184171280
	// [XID] // 0x00000001899D7240-0x00000001899D7260
	public void PullRecentChat() {} // 0x0000000184173130-0x0000000184173230
	// [XID] // 0x00000001899DE690-0x00000001899DE6B0
	public void SetReadPrivateReq(uint targetUid) {} // 0x0000000184172950-0x0000000184172A50
	// [XID] // 0x00000001899E63B0-0x00000001899E63D0
	private bool CheckTalkCd() => default; // 0x0000000184172D30-0x0000000184172F50
	// [XID] // 0x00000001899ED860-0x00000001899ED880
	public void TryEnableChat() {} // 0x0000000184173230-0x0000000184173360
	// [XID] // 0x00000001899F52D0-0x00000001899F52F0
	public override bool OnPacket(Packet packet) => default; // 0x0000000184171280-0x0000000184171BD0
	// [XID] // 0x00000001899FC8E0-0x00000001899FC900
	private void OnPlayerChatNotify(PlayerChatNotify notify) {} // 0x00000001841734D0-0x0000000184173740
	// [XID] // 0x0000000189A03EA0-0x0000000189A03EC0
	private void OnPrivateChatNotify(PrivateChatNotify notify) {} // 0x0000000184172A50-0x0000000184172CB0
	// [XID] // 0x0000000189A0B4F0-0x0000000189A0B510
	private void OnPullPrivateChatList(PullPrivateChatRsp rsp) {} // 0x00000001841725C0-0x00000001841728D0
	// [XID] // 0x0000000189A12CB0-0x0000000189A12CD0
	public override void ClearOnDisconnect() {} // 0x0000000184173430-0x00000001841734D0
	// [XID] // 0x0000000189A1A070-0x0000000189A1A090
	public override void ClearOnLevelDestroy() {} // 0x0000000184171BD0-0x0000000184171CE0
	// [XID] // 0x0000000189A215B0-0x0000000189A215D0
	protected override void RegisterModulesPkt(NotifyManager notifyMgr) {} // 0x0000000184171CE0-0x0000000184171E70
	// [XID] // 0x0000000189A28B70-0x0000000189A28B90
	protected override void RegsiterModuleNotify(NotifyManager notifyMgr) {} // 0x0000000184173360-0x0000000184173430
}

