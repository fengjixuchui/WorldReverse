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

public sealed class ChatDataManager : GlobalManager, INotifyInterface // TypeDefIndex: 28461
{
	// Fields
	private MainPageChatDataMgr _mainPageChatDataMgr; // 0x18
	private Dictionary<ChatChannel, List<ChatInfo>> _dataTypeDic; // 0x20
	private Dictionary<uint, List<ChatInfo>> _dataFriendData; // 0x28
	private string[] _runtimeChannelTalkDrafts; // 0x30
	private Dictionary<uint, string> _runtimeFriendTalkDrafts; // 0x38
	private List<uint> _talkingFriendList; // 0x40
	private HashSet<uint> _targetHasNewData; // 0x48
	private ChatChannel _recentChannel; // 0x50
	private List<ChatInfo> _recentTalkList; // 0x58
	private List<IChatDataListener> _listenerList; // 0x60
	private SpriteLoadProxy _iconProxy; // 0x68
	private List<uint> _currChannelList; // 0x70
	public ChatRecentFriends chatRecentFriend; // 0x78
	public static readonly string myNameColor; // 0x00
	public static readonly string otherNameColor; // 0x08
	private static FriendBriefStruct friendData; // 0x10
	private readonly string emojiPrefix; // 0x80
	public List<Sprite> emojiList; // 0x88
	public List<uint> emojiHandlerList; // 0x90
	private readonly string emojiTextPrefix; // 0x98
	public List<string> emojiNameList; // 0xA0
	private readonly string quickChatPrefix; // 0xA8
	public List<string> quickChatList; // 0xB0
	private bool _isHomeworld; // 0xB8

	// Properties
	public uint lastQuitTalkUid { /* [XID] */ /* 0x0000000189B63AE0-0x0000000189B63B20 */ get; /* [XID] */ /* 0x0000000189B6DF40-0x0000000189B6DF80 */ set; } // 0x0000000183078BF0-0x0000000183078C50 0x000000018307B6E0-0x000000018307B740
	public ChatChannel lastQuitTalkChannel { /* [XID] */ /* 0x0000000189B786F0-0x0000000189B78730 */ get; /* [XID] */ /* 0x0000000189B82E20-0x0000000189B82E60 */ set; } // 0x0000000183077140-0x00000001830771A0 0x0000000183077B10-0x0000000183077B70
	public MainPageChatDataMgr mainPageChatDataMgr { /* [XID] */ /* 0x0000000189B8CF90-0x0000000189B8CFB0 */ get => default; } // 0x000000018307A7F0-0x000000018307A890 
	public List<uint> TalkingFriendList { /* [XID] */ /* 0x0000000189B94780-0x0000000189B947A0 */ get => default; } // 0x00000001830779D0-0x0000000183077A70 
	public List<uint> CurrChannelList { /* [XID] */ /* 0x0000000189B9BDF0-0x0000000189B9BE10 */ get => default; } // 0x0000000183078A80-0x0000000183078B20 

	// Constructors
	public ChatDataManager() {} // 0x000000018307BBB0-0x000000018307BE50
	static ChatDataManager() {} // 0x000000018307BB30-0x000000018307BBB0

	// Methods
	// [XID] // 0x0000000189BA3530-0x0000000189BA3550
	public bool CheckInChannel(ChatChannel channel) => default; // 0x000000018307A890-0x000000018307A960
	// [XID] // 0x0000000189BAA890-0x0000000189BAA8B0
	public void AddChannel(uint channel) {} // 0x0000000183078C50-0x0000000183078D40
	// [XID] // 0x0000000189BB1ED0-0x0000000189BB1EF0
	public void ClearChannel() {} // 0x0000000183078620-0x00000001830786D0
	// [XID] // 0x0000000189BB92F0-0x0000000189BB9310
	public void RemoveChannel(uint channel) {} // 0x0000000183079FB0-0x000000018307A080
	// [XID] // 0x0000000189BC10C0-0x0000000189BC10E0
	public ChatChannel GetLastChatChannel() => default; // 0x0000000183077A70-0x0000000183077B10
	// [XID] // 0x0000000189BC8890-0x0000000189BC88B0
	public ChatInfo GetLastChatInfo() => default; // 0x0000000183079910-0x0000000183079B30
	// [XID] // 0x0000000189BD00B0-0x0000000189BD00D0
	public void CleanseRecentFriend() {} // 0x00000001830786D0-0x0000000183078850
	// [XID] // 0x0000000189BD76B0-0x0000000189BD76D0
	public void CleaseTargetHasNew() {} // 0x000000018307B800-0x000000018307BA90
	// [XID] // 0x0000000189BDF1B0-0x0000000189BDF1D0
	public void ClearRecentTalkTargetWithUid(uint uidToClear) {} // 0x000000018307B560-0x000000018307B6E0
	// [XID] // 0x00000001895EBE40-0x00000001895EBE60
	public void SetTalkDraft(uint uid, ChatChannel channel, string text) {} // 0x000000018307A080-0x000000018307A1D0
	// [XID] // 0x00000001895F3220-0x00000001895F3240
	public void RemoveTalkDraft(uint uid, ChatChannel channel) {} // 0x0000000183077C80-0x0000000183077D90
	// [XID] // 0x00000001895FAA80-0x00000001895FAAA0
	public string GetTalkDraft(uint uid, ChatChannel channel) => default; // 0x000000018307B090-0x000000018307B1C0
	// [XID] // 0x00000001896023D0-0x00000001896023F0
	public override void Init() {} // 0x00000001830797B0-0x0000000183079910
	// [XID] // 0x0000000189609C30-0x0000000189609C50
	public override void Destroy() {} // 0x0000000183078510-0x0000000183078620
	// [XID] // 0x00000001896113E0-0x0000000189611400
	public override void InitByLocalData() {} // 0x00000001830795C0-0x00000001830797B0
	// [XID] // 0x0000000189618E30-0x0000000189618E50
	public override void ReloadRes() {} // 0x000000018307BA90-0x000000018307BB30
	// [XID] // 0x00000001896202D0-0x00000001896202F0
	public override void ClearOnLevelDestroy() {} // 0x00000001830782C0-0x0000000183078360
	// [XID] // 0x0000000189627750-0x0000000189627770
	public void Save() {} // 0x000000018307B340-0x000000018307B560
	// [XID] // 0x000000018962F210-0x000000018962F230
	public void Subscribe(IChatDataListener listener) {} // 0x0000000183078420-0x0000000183078510
	// [XID] // 0x0000000189636BD0-0x0000000189636BF0
	public void Unsubscribe(IChatDataListener listener) {} // 0x00000001830778E0-0x00000001830779D0
	// [XID] // 0x000000018963E100-0x000000018963E120
	public List<ChatInfo> GetChatChannelData(ChatChannel channel, uint uid) => default; // 0x0000000183079B30-0x0000000183079F50
	// [XID] // 0x0000000189645AD0-0x0000000189645AF0
	public void PushFriendChatInfoList(uint uid, List<ChatInfo> listChatInfo) {} // 0x000000018307A570-0x000000018307A7F0
	// [XID] // 0x000000018964D2E0-0x000000018964D300
	public void PushRecentChatInfo(RepeatedMessageField<ChatInfo> listChatInfo) {} // 0x0000000183079340-0x00000001830795C0
	// [XID] // 0x0000000189654A80-0x0000000189654AA0
	private void AddRecentChatInfo(ChatChannel recentChannel, ChatInfo chatInfo) {} // 0x0000000183078D40-0x0000000183078EF0
	// [XID] // 0x000000018965C150-0x000000018965C170
	public void AddRecentTalkingFriend(uint uid) {} // 0x000000018307B1C0-0x000000018307B340
	// [XID] // 0x00000001896637D0-0x00000001896637F0
	public void RemoveRecentTalkingFriend(uint uid) {} // 0x0000000183078360-0x0000000183078420
	// [XID] // 0x000000018966B110-0x000000018966B130
	public static bool GetChatIsNotFriend(ChatInfo chatInfo) => default; // 0x000000018307B740-0x000000018307B800
	// [XID] // 0x0000000189672D10-0x0000000189672D30
	public static bool GetChatIsSelf(ChatInfo chatInfo) => default; // 0x0000000183077EE0-0x0000000183078020
	// [XID] // 0x000000018967A410-0x000000018967A430
	public static uint GetChatTargetUid(ChatInfo chatInfo) => default; // 0x0000000183077D90-0x0000000183077EE0
	// [XID] // 0x0000000189681C60-0x0000000189681C80
	public void PushChatData(ChatChannel channel, ChatInfo chatInfo, int msgType = 0 /* Metadata: 0x00B0D889 */) {} // 0x0000000183078EF0-0x0000000183079340
	// [XID] // 0x00000001896896D0-0x00000001896896F0
	public bool HasNewData() => default; // 0x0000000183078850-0x0000000183078910
	// [XID] // 0x0000000189691370-0x0000000189691390
	public bool TargetHasNewData(uint uid) => default; // 0x0000000183078B20-0x0000000183078BF0
	// [XID] // 0x0000000189698AE0-0x0000000189698B00
	public void TargetClearNewData(uint uid) {} // 0x00000001830781F0-0x00000001830782C0
	// [XID] // 0x000000018969FF30-0x000000018969FF50
	public ChatExcelConfig GetConfig(ChatChannel channel) => default; // 0x0000000183077610-0x00000001830778E0
	// [XID] // 0x00000001896A7190-0x00000001896A71B0
	public string ExtructText(ChatInfo chatInfo, ChatChannel channel, bool withName = true /* Metadata: 0x00B0D88D */) => default; // 0x000000018307A960-0x000000018307B090
	// [XID] // 0x00000001896AE7B0-0x00000001896AE7D0
	public void TryInitEmojiList() {} // 0x00000001830771A0-0x0000000183077610
	// [XID] // 0x00000001896B5FD0-0x00000001896B5FF0
	public void TryInitQuickChatList() {} // 0x0000000183078910-0x0000000183078A80
	// [XID] // 0x00000001896BD190-0x00000001896BD1B0
	public void ClearTeamData() {} // 0x0000000183077B70-0x0000000183077C80
	// [XID] // 0x00000001896C4690-0x00000001896C46B0
	public void TryClearTeamData() {} // 0x000000018307A3C0-0x000000018307A570
	// [XID] // 0x00000001897B65D0-0x00000001897B65F0
	public void ClearAll() {} // 0x0000000183078020-0x00000001830781F0
	// [XID] // 0x00000001896D2FB0-0x00000001896D2FD0
	bool MoleMole.INotifyInterface.OnNotify(Notify ntf) => default; // 0x000000018307A1D0-0x000000018307A3C0
}

