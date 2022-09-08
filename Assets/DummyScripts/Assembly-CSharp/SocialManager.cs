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

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SocialManager : GlobalManager // TypeDefIndex: 21318
{
	// Fields
	private List<uint> _friendList; // 0x10
	private List<uint> _psFriendList; // 0x18
	private Dictionary<uint, FriendBriefStruct> _friendDataDic; // 0x20
	private List<uint> _friendRequestList; // 0x28
	private List<uint> _psFriendRequestList; // 0x30
	private Dictionary<uint, FriendBriefStruct> _friendRequestDataDic; // 0x38
	private List<uint> _blacklist; // 0x40
	private List<uint> _psBlacklist; // 0x48
	private Dictionary<uint, FriendBriefStruct> _blacklistDataDic; // 0x50
	private List<uint> _multiplayRecentlyList; // 0x58
	private List<uint> _psMultiplayRecentlyList; // 0x60
	private Dictionary<uint, FriendBriefStruct> _multiplayRecentlyDataDic; // 0x68
	private List<uint> _blockChatList; // 0x70
	private bool _showNewFriendRequest; // 0x78
	private bool _hasReqFriendListInPaimon; // 0x79

	// Properties
	public bool showNewFriendRequest { /* [XID] */ /* 0x0000000189647370-0x0000000189647390 */ get => default; /* [XID] */ /* 0x000000018964EAA0-0x000000018964EAC0 */ set {} } // 0x00000001829F3DC0-0x00000001829F3E60 0x00000001829F2380-0x00000001829F2430
	public bool hasReqFriendListInPaimon { /* [XID] */ /* 0x0000000189656390-0x00000001896563B0 */ get => default; /* [XID] */ /* 0x000000018965DA90-0x000000018965DAB0 */ set {} } // 0x00000001829F1370-0x00000001829F1410 0x00000001829F3E60-0x00000001829F3F10

	// Constructors
	public SocialManager() {} // 0x00000001829F4050-0x00000001829F4280

	// Methods
	// [XID] // 0x0000000189665140-0x0000000189665160
	public override void Init() {} // 0x00000001829F26D0-0x00000001829F2770
	// [XID] // 0x000000018966C840-0x000000018966C860
	public override void Destroy() {} // 0x00000001829F16F0-0x00000001829F1790
	// [XID] // 0x0000000189674650-0x0000000189674670
	public override void ReloadRes() {} // 0x00000001829F3F10-0x00000001829F3FB0
	// [XID] // 0x000000018967BF80-0x000000018967BFA0
	public List<uint> GetFriendListAcordingToPlatform() => default; // 0x00000001829F0CA0-0x00000001829F0D50
	// [XID] // 0x0000000189683530-0x0000000189683550
	public override void Tick() {} // 0x00000001829F3FB0-0x00000001829F4050
	// [XID] // 0x000000018968B170-0x000000018968B190
	public override void ClearOnLevelDestroy() {} // 0x00000001829F1650-0x00000001829F16F0
	// [XID] // 0x0000000189692E50-0x0000000189692E70
	public override void ClearOnBackHome(bool forceClear = true /* Metadata: 0x00AFF44B */) {} // 0x00000001829F1410-0x00000001829F1650
	// [XID] // 0x000000018969A0D0-0x000000018969A0F0
	public List<uint> GetFriendList() => default; // 0x00000001829F3450-0x00000001829F34F0
	// [XID] // 0x00000001896A18E0-0x00000001896A1900
	public List<uint> GetFriendRequestList() => default; // 0x00000001829F1AB0-0x00000001829F1B50
	// [XID] // 0x00000001896A8DA0-0x00000001896A8DC0
	public List<uint> GetBlacklist() => default; // 0x00000001829F1EE0-0x00000001829F1F80
	// [XID] // 0x00000001896AFE50-0x00000001896AFE70
	public List<uint> GetMultiplayRecentlyList() => default; // 0x00000001829F1DA0-0x00000001829F1E40
	// [XID] // 0x00000001896B77C0-0x00000001896B77E0
	public List<uint> GetBlockChatList() => default; // 0x00000001829F22E0-0x00000001829F2380
	// [XID] // 0x00000001896BE930-0x00000001896BE950
	public List<uint> GetPSFriendList() => default; // 0x00000001829F3BD0-0x00000001829F3DC0
	// [XID] // 0x00000001896C6230-0x00000001896C6250
	public List<uint> GetPSFriendRequestList() => default; // 0x00000001829F1B50-0x00000001829F1D40
	// [XID] // 0x00000001896CD850-0x00000001896CD870
	public List<uint> GetPSBlacklist() => default; // 0x00000001829F3140-0x00000001829F3330
	// [XID] // 0x00000001896D4CC0-0x00000001896D4CE0
	public List<uint> GetPSMultiplayRecentlyList() => default; // 0x00000001829F2F50-0x00000001829F3140
	// [XID] // 0x00000001896DC300-0x00000001896DC320
	public Dictionary<uint, FriendBriefStruct> GetFriendDataDic() => default; // 0x00000001829F1E40-0x00000001829F1EE0
	// [XID] // 0x00000001896E3B10-0x00000001896E3B30
	public Dictionary<uint, FriendBriefStruct> GetFriendRequestDataDic() => default; // 0x00000001829F2770-0x00000001829F2810
	// [XID] // 0x00000001896EAEC0-0x00000001896EAEE0
	public Dictionary<uint, FriendBriefStruct> GetBlacklistDataDic() => default; // 0x00000001829F2A50-0x00000001829F2AF0
	// [XID] // 0x00000001896F22D0-0x00000001896F22F0
	public string TryGetFriendRemarkName(uint uid) => default; // 0x00000001829F0880-0x00000001829F0970
	// [XID] // 0x00000001896F9C30-0x00000001896F9C50
	public bool TryGetFriendShowAvatarData(uint uid, out List<SocialAvatarInfoStruct> showAvatarInfoList) {
		showAvatarInfoList = default;
		return default;
	} // 0x00000001829F3330-0x00000001829F3450
	// [XID] // 0x0000000189701460-0x0000000189701480
	public bool TryGetFriendData(uint uid, out FriendBriefStruct data) {
		data = default;
		return default;
	} // 0x00000001829F2200-0x00000001829F22E0
	// [XID] // 0x0000000189708C60-0x0000000189708C80
	public bool TryGetFriendRequestData(uint uid, out FriendBriefStruct data) {
		data = default;
		return default;
	} // 0x00000001829F1F80-0x00000001829F2060
	// [XID] // 0x0000000189710500-0x0000000189710520
	public bool TryGetBlacklistData(uint uid, out FriendBriefStruct data) {
		data = default;
		return default;
	} // 0x00000001829F0BC0-0x00000001829F0CA0
	// [XID] // 0x00000001897178E0-0x0000000189717900
	public bool TryGetMultiplayRecentlyData(uint uid, out FriendBriefStruct data) {
		data = default;
		return default;
	} // 0x00000001829F1290-0x00000001829F1370
	// [XID] // 0x000000018971F3B0-0x000000018971F3D0
	public bool UpdateFriendRemarkName(uint uid, string remarkName) => default; // 0x00000001829F2060-0x00000001829F2200
	// [XID] // 0x00000001897269A0-0x00000001897269C0
	public void RefreshFriendList(RepeatedMessageField<FriendBrief> friendList) {} // 0x00000001829F2430-0x00000001829F26D0
	// [XID] // 0x000000018972DF10-0x000000018972DF30
	public void RefreshFriendRequestList(RepeatedMessageField<FriendBrief> friendList) {} // 0x00000001829F2AF0-0x00000001829F2D90
	// [XID] // 0x0000000189735590-0x00000001897355B0
	public void RefreshMultiplayRecentlyList(RepeatedMessageField<FriendBrief> friendList) {} // 0x00000001829F3930-0x00000001829F3BD0
	// [XID] // 0x000000018973D110-0x000000018973D130
	public void RefreshBlacklist(RepeatedMessageField<FriendBrief> blacklist) {} // 0x00000001829F0970-0x00000001829F0BC0
	// [XID] // 0x0000000189744630-0x0000000189744650
	public void GetSocialDetailStruct(SocialDetail serverData, out SocialDetailStruct socialData) {
		socialData = default;
	} // 0x00000001829F34F0-0x00000001829F3930
	// [XID] // 0x000000018974C330-0x000000018974C350
	public bool GetLocalPlayerDetailStruct(out SocialDetailStruct socialData) {
		socialData = default;
		return default;
	} // 0x00000001829F0D50-0x00000001829F1290
	// [XID] // 0x00000001897535A0-0x00000001897535C0
	public void GetFriendBriefStruct(FriendBrief serverData, out FriendBriefStruct friendBriefData) {
		friendBriefData = default;
	} // 0x00000001829F1790-0x00000001829F1AB0
	// [IDTag] // 0x000000018975AAC0-0x000000018975AB00
	// [XID] // 0x000000018975AAC0-0x000000018975AB00
	public void UpdatePSFriendList() {} // 0x00000001829F2810-0x00000001829F28B0
	// [IDTag] // 0x0000000189765180-0x00000001897651C0
	// [XID] // 0x0000000189765180-0x00000001897651C0
	public void UpdatePSFriendList(List<string> friendList) {} // 0x00000001829F28B0-0x00000001829F29D0
	// [IDTag] // 0x000000018976F910-0x000000018976F950
	// [XID] // 0x000000018976F910-0x000000018976F950
	public void UpdatePSBlockList() {} // 0x00000001829F2EB0-0x00000001829F2F50
	// [IDTag] // 0x000000018977A0E0-0x000000018977A120
	// [XID] // 0x000000018977A0E0-0x000000018977A120
	public void UpdatePSBlockList(List<string> blockList) {} // 0x00000001829F2D90-0x00000001829F2EB0
}

