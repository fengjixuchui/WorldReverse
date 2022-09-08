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

public sealed class MultiplayerModule : BaseModule // TypeDefIndex: 21580
{
	// Fields
	public bool isSkipMatch; // 0x10
	private Dictionary<ulong, uint> _guid2PeerId; // 0x18
	private Dictionary<uint, AvatarEntity> _otherUid2avatarDic; // 0x20
	private Dictionary<uint, Vector3> _uid2positionDic; // 0x28
	private Dictionary<uint, Vector3> _uid2rotationDic; // 0x30
	private Dictionary<uint, Vector3> _uid2BigWorldPositionDic; // 0x38
	private Dictionary<uint, Vector3> _uid2BigWorldRotationDic; // 0x40
	private Dictionary<uint, OnlinePlayerData> _uid2playerData; // 0x48
	private List<uint> _homeworldVisitorList; // 0x50
	private Dictionary<uint, OnlinePlayerData> _uid2HomeworldVisitorPlayerDataDic; // 0x58
	private Dictionary<uint, uint> _uid2PeerID; // 0x60
	private List<uint> _squadUids; // 0x70
	private List<uint> _bigWorldSquadUids; // 0x78
	private List<uint> _dungeonSquadUids; // 0x80
	private bool _dungeonMultiplayer; // 0x88
	public const uint MAX_WORLD_PLAYER = 4; // Metadata: 0x00AFF9A3
	private List<uint> _hostPlayers; // 0x90
	private Dictionary<uint, HostPlayerData> _hostUID2index; // 0x98
	private List<uint> _worldLevelEqualHosts; // 0xA0
	private List<uint> _worldLevelGreaterHosts; // 0xA8
	private List<uint> _worldLevelLowerHosts; // 0xB0
	private Dictionary<uint, float> _applyLimit; // 0xB8
	private uint _acceptedHostUID; // 0xC0
	private string _acceptedHostNickname; // 0xC8
	private const float APPLY_COOLDOWN = 5f; // Metadata: 0x00AFF9A7
	private Dictionary<uint, MPRequestState> _uid2requestState; // 0xD0
	public const float ENTER_CONFIRM_TIME = 10f; // Metadata: 0x00AFF9AB
	private List<ApplingGuestData> _applingGuestDataList; // 0xD8
	private Dictionary<uint, MPRequestState> _uid2HomeworldRequestState; // 0xE0
	private Dictionary<uint, float> _applyHomeworldLimitTime; // 0xE8
	public FriendEnterHomeOption friendEnterHomeOption; // 0xF0
	private uint _dungeonID; // 0xF4
	private List<uint> _dungeonReadyPlayers; // 0xF8
	private Dictionary<uint, float> _dungeonInvitedUids; // 0x100
	private uint _invitedPlayerUID; // 0x108
	private uint _invitedDungeonID; // 0x10C
	private InvitingHostData? _invitingHost; // 0x110
	private const float INVITING_HANDLE_TIME = 9f; // Metadata: 0x00AFF9AF
	private bool _openMPTeamPageAfterTrans; // 0x170
	private GeneralDialogContext _matchDialog; // 0x198
	public Dictionary<uint, OnlinePlayerData> matchUid2playerData; // 0x1A0
	public uint matchConfirmEndTime; // 0x1A8
	public uint matchResponseTime; // 0x1AC
	private List<uint> _blockMpMainQuestList; // 0x1B0
	private RepeatedMessageField<ScenePlayInfo> _playInfoList; // 0x1B8
	private Dictionary<uint, Dictionary<uint, bool>> _mpPlayStateDic; // 0x1C0
	private Dictionary<uint, bool> _mpDungeonStateDic; // 0x1C8
	private ScenePlayBattleInfoNotify _scenePlayBattleInfoNotify; // 0x1D8
	private bool _isScenePlayBattle; // 0x1F8
	private DraftOwnerTwiceConfirmNotify draftOwnerTwiceConfirmNotify; // 0x200
	private bool _beenBlockedInMPAsGuest; // 0x208

	// Properties
	public int scenePlayerCount { /* [XID] */ /* 0x0000000189B78860-0x0000000189B788A0 */ get; /* [XID] */ /* 0x0000000189B82F60-0x0000000189B82FA0 */ private set; } // 0x00000001819D2990-0x00000001819D29F0 0x00000001819D1040-0x00000001819D10A0
	public uint quitMpValidTime { /* [XID] */ /* 0x0000000189B8D0B0-0x0000000189B8D0F0 */ get; /* [XID] */ /* 0x0000000189B97770-0x0000000189B977B0 */ private set; } // 0x00000001819D05A0-0x00000001819D0600 0x00000001819C5F80-0x00000001819C5FE0
	public List<uint> squadUids { /* [XID] */ /* 0x0000000189A5B080-0x0000000189A5B0A0 */ get => default; } // 0x00000001819CCA50-0x00000001819CCAF0 
	public List<uint> bigWorldSquadUids { /* [XID] */ /* 0x000000018962C010-0x000000018962C030 */ get => default; } // 0x00000001819BE530-0x00000001819BE5D0 
	public List<uint> dungeonSquadUids { /* [XID] */ /* 0x0000000189642BE0-0x0000000189642C00 */ get => default; } // 0x00000001819C39F0-0x00000001819C3AA0 
	public List<uint> currWorldSquadUids { /* [XID] */ /* 0x0000000189651980-0x00000001896519A0 */ get => default; } // 0x00000001819C0390-0x00000001819C04A0 
	public List<uint> homeworldVisitorList { /* [XID] */ /* 0x000000018966FD70-0x000000018966FD90 */ get => default; } // 0x00000001819D28F0-0x00000001819D2990 
	public bool bigworldMultiplayer { /* [XID] */ /* 0x0000000189686410-0x0000000189686430 */ get => default; } // 0x00000001819CBB50-0x00000001819CBC00 
	public bool dungeonMultiplayer { /* [XID] */ /* 0x000000018968E2B0-0x000000018968E2D0 */ get => default; /* [XID] */ /* 0x0000000189695B50-0x0000000189695B70 */ set {} } // 0x00000001819B6270-0x00000001819B6320 0x00000001819C6630-0x00000001819C66E0
	public bool currWorldMultiplayer { /* [XID] */ /* 0x00000001899BA340-0x00000001899BA360 */ get => default; } // 0x00000001819C9E80-0x00000001819C9F90 
	public uint acceptedHostUID { /* [XID] */ /* 0x000000018977A060-0x000000018977A080 */ get => default; } // 0x00000001819D0430-0x00000001819D04D0 
	public List<ApplingGuestData> applingGuestDataList { /* [XID] */ /* 0x00000001897B6C00-0x00000001897B6C20 */ get => default; } // 0x00000001819B5440-0x00000001819B54F0 
	public uint dungeonID { /* [XID] */ /* 0x0000000189895B00-0x0000000189895B20 */ get => default; } // 0x00000001819C9950-0x00000001819C99F0 
	public uint matchHostUid { /* [XID] */ /* 0x000000018997DFE0-0x000000018997E020 */ get; /* [XID] */ /* 0x0000000189988F90-0x0000000189988FD0 */ private set; } // 0x00000001819C7390-0x00000001819C73F0 0x00000001819CB650-0x00000001819CB6C0
	public MatchType matchType { /* [XID] */ /* 0x0000000189993B50-0x0000000189993B90 */ get; /* [XID] */ /* 0x000000018999E5B0-0x000000018999E5F0 */ private set; } // 0x00000001819CE950-0x00000001819CE9B0 0x00000001819BFB60-0x00000001819BFBD0
	public uint matchBeginTime { /* [XID] */ /* 0x00000001899A8E60-0x00000001899A8EA0 */ get; /* [XID] */ /* 0x00000001899B37C0-0x00000001899B3800 */ private set; } // 0x00000001819C5190-0x00000001819C51F0 0x00000001819CAFB0-0x00000001819CB020
	public uint estimateMatchTime { /* [XID] */ /* 0x00000001899BDF10-0x00000001899BDF50 */ get; /* [XID] */ /* 0x00000001899C8370-0x00000001899C83B0 */ private set; } // 0x00000001819BB4B0-0x00000001819BB510 0x00000001819C8160-0x00000001819C81D0
	public uint matchDungeonId { /* [XID] */ /* 0x00000001899D2AF0-0x00000001899D2B30 */ get; /* [XID] */ /* 0x00000001899DCF60-0x00000001899DCFA0 */ private set; } // 0x00000001819C9B50-0x00000001819C9BB0 0x00000001819B7CE0-0x00000001819B7D50
	public uint mpPlayId { /* [XID] */ /* 0x00000001899E7C00-0x00000001899E7C40 */ get; /* [XID] */ /* 0x00000001899F22B0-0x00000001899F22F0 */ private set; } // 0x00000001819C98F0-0x00000001819C9950 0x00000001819B54F0-0x00000001819B5560
	public uint mechanicusDifficultLevel { get; /* [XID] */ /* 0x0000000189A03E60-0x0000000189A03EA0 */ private set; } // 0x00000001819BF470-0x00000001819BF4D0 0x00000001819B9530-0x00000001819B95A0
	public uint matchId { /* [XID] */ /* 0x0000000189A0E5B0-0x0000000189A0E5F0 */ get; /* [XID] */ /* 0x0000000189A18930-0x0000000189A18970 */ private set; } // 0x00000001819D1640-0x00000001819D16A0 0x00000001819C7F90-0x00000001819C8000
	public RepeatedMessageField<ScenePlayInfo> playInfoList { /* [XID] */ /* 0x0000000189AB89A0-0x0000000189AB89C0 */ get => default; } // 0x00000001819BC980-0x00000001819BCA30 
	public ScenePlayBattleResultNotify ScenePlayBattleResult { /* [XID] */ /* 0x0000000189AC0570-0x0000000189AC05B0 */ get; /* [XID] */ /* 0x0000000189ACAF60-0x0000000189ACAFA0 */ private set; } // 0x00000001819B6320-0x00000001819B6380 0x00000001819C59F0-0x00000001819C5A60
	public ScenePlayBattleInfo scenePlayBattleInfo { /* [XID] */ /* 0x0000000189AD5D60-0x0000000189AD5DA0 */ get; /* [XID] */ /* 0x0000000189AE0860-0x0000000189AE08A0 */ private set; } // 0x00000001819D00B0-0x00000001819D0110 0x00000001819BA650-0x00000001819BA6C0
	public uint scenePlayBattleStage { /* [XID] */ /* 0x0000000189AEAEF0-0x0000000189AEAF30 */ get; /* [XID] */ /* 0x0000000189AF57B0-0x0000000189AF57F0 */ private set; } // 0x00000001819C51F0-0x00000001819C5250 0x00000001819C73F0-0x00000001819C7460
	public ScenePlayBattleUidOpNotify scenePlayBattleUidInfo { /* [XID] */ /* 0x0000000189AFFE90-0x0000000189AFFED0 */ get; /* [XID] */ /* 0x0000000189B0A5E0-0x0000000189B0A620 */ private set; } // 0x00000001819B9100-0x00000001819B9160 0x00000001819C54B0-0x00000001819C5520
	public bool isScenePlayBattle { /* [XID] */ /* 0x0000000189B149D0-0x0000000189B149F0 */ get => default; /* [XID] */ /* 0x0000000189B1C3D0-0x0000000189B1C3F0 */ set {} } // 0x00000001819CC340-0x00000001819CC3F0 0x00000001819BDAC0-0x00000001819BDD80

	// Constructors
	public MultiplayerModule() {} // 0x00000001819D34C0-0x00000001819D39F0

	// Methods
	// [XID] // 0x0000000189B01720-0x0000000189B01740
	protected override void RegisterModulesPkt(NotifyManager notifyMgr) {} // 0x00000001819B95A0-0x00000001819B9CB0
	// [XID] // 0x0000000189B08C70-0x0000000189B08C90
	protected override void RegsiterModuleNotify(NotifyManager notifyMgr) {} // 0x00000001819D01C0-0x00000001819D02C0
	// [XID] // 0x0000000189B106F0-0x0000000189B10710
	public override void ClearOnLevelDestroy() {} // 0x00000001819B9160-0x00000001819B92D0
	// [XID] // 0x0000000189B17820-0x0000000189B17840
	public override void ClearOnDisconnect() {} // 0x00000001819D02C0-0x00000001819D0430
	// [XID] // 0x0000000189B1F0E0-0x0000000189B1F100
	public override void ClearOnBackHome() {} // 0x00000001819BF320-0x00000001819BF470
	// [XID] // 0x000000018968D570-0x000000018968D590
	public bool ClientAbilityCheck(MultiplayerCheckItem checkItem) => default; // 0x00000001819C4330-0x00000001819C4440
	// [XID] // 0x0000000189B2DBA0-0x0000000189B2DBC0
	public override bool OnPacket(Packet packet) => default; // 0x00000001819B7D50-0x00000001819B8E50
	// [XID] // 0x0000000189B34FB0-0x0000000189B34FD0
	private void OnDungeonRestartInviteNotify(DungeonRestartInviteNotify dungeonRestartInviteNotify) {} // 0x00000001819C06A0-0x00000001819C0890
	// [XID] // 0x0000000189B3C880-0x0000000189B3C8A0
	private void OnDungeonRestartInviteReplyRsp(DungeonRestartInviteReplyRsp dungeonRestartInviteReplyRsp) {} // 0x00000001819BE340-0x00000001819BE530
	// [XID] // 0x0000000189B44630-0x0000000189B44650
	private void OnDungeonRestartRsp(DungeonRestartRsp dungeonRestartRsp) {} // 0x00000001819C4F40-0x00000001819C50A0
	// [XID] // 0x0000000189B4BDC0-0x0000000189B4BDE0
	private void OnChangeWorldToSingleModeRsp(ChangeWorldToSingleModeRsp rsp) {} // 0x00000001819C7620-0x00000001819C78A0
	// [XID] // 0x0000000189B53230-0x0000000189B53250
	private void OnGetWorldMpInfoRsp(GetWorldMpInfoRsp rsp) {} // 0x00000001819C2860-0x00000001819C2A00
	// [XID] // 0x0000000189B5AC10-0x0000000189B5AC30
	private void OnDungeonRestartInviteReplyNotify(DungeonRestartInviteReplyNotify dungeonRestartInviteReplyNotify) {} // 0x00000001819C7DE0-0x00000001819C7F90
	// [XID] // 0x0000000189B62010-0x0000000189B62030
	private void OnDungeonRestartResultNotify(DungeonRestartResultNotify dungeonRestartResultNotify) {} // 0x00000001819BB510-0x00000001819BB720
	// [XID] // 0x0000000189B69C50-0x0000000189B69C70
	public void TryShutDownChat() {} // 0x00000001819BAB90-0x00000001819BACB0
	// [XID] // 0x0000000189B71200-0x0000000189B71220
	public override bool OnNotify(Notify ntf) => default; // 0x00000001819D18A0-0x00000001819D1B10
	// [XID] // 0x0000000189BA1E30-0x0000000189BA1E50
	public int GetOtherUidCount() => default; // 0x00000001819B5B90-0x00000001819B5C50
	// [XID] // 0x0000000189BA9220-0x0000000189BA9240
	public bool IsHostOnline() => default; // 0x00000001819C21F0-0x00000001819C2300
	// [XID] // 0x0000000189BB09B0-0x0000000189BB09D0
	public string GetHostNickname() => default; // 0x00000001819C5520-0x00000001819C56B0
	// [XID] // 0x0000000189BB7CC0-0x0000000189BB7CE0
	public AvatarEntity GetAvatarEntityByUid(uint uid) => default; // 0x00000001819CE450-0x00000001819CE5A0
	// [XID] // 0x0000000189BBF3B0-0x0000000189BBF3D0
	public void UpdateAvatarEntity(uint uid, AvatarEntity avatarEntity) {} // 0x00000001819D1220-0x00000001819D13C0
	// [XID] // 0x0000000189BC6F70-0x0000000189BC6F90
	public void RemoveAvatarEntity(uint uid) {} // 0x00000001819B9CB0-0x00000001819B9D80
	// [XID] // 0x0000000189BCEC80-0x0000000189BCECA0
	public ulong GetCompanionCurrAvatarID(uint uid) => default; // 0x00000001819BA830-0x00000001819BA930
	// [IDTag] // 0x0000000189BD5FC0-0x0000000189BD6000
	// [XID] // 0x0000000189BD5FC0-0x0000000189BD6000
	public Vector3 GetCompanionPosition(uint sceneID, uint uid) => default; // 0x00000001819CDCC0-0x00000001819CDF40
	// [XID] // 0x00000001895E5D30-0x00000001895E5D50
	public Vector3 GetCompanionBigWorldPosition(uint uid) => default; // 0x00000001819D16A0-0x00000001819D18A0
	// [XID] // 0x00000001895ED6F0-0x00000001895ED710
	public Vector3 GetPlayerBigWorldPosition() => default; // 0x00000001819C2300-0x00000001819C2600
	// [XID] // 0x00000001895F4CC0-0x00000001895F4CE0
	public Vector3 GetCompanionCurrScenePosition(uint uid) => default; // 0x00000001819CD560-0x00000001819CD860
	// [IDTag] // 0x00000001895FC470-0x00000001895FC4B0
	// [XID] // 0x00000001895FC470-0x00000001895FC4B0
	public Vector3 GetCompanionPosition(uint uid) => default; // 0x00000001819CDAB0-0x00000001819CDCC0
	// [XID] // 0x0000000189606BE0-0x0000000189606C00
	public Vector3 GetCompanionRotation(uint uid) => default; // 0x00000001819D0E30-0x00000001819D1040
	// [XID] // 0x000000018960E4E0-0x000000018960E500
	private void PushCompanionMark() {} // 0x00000001819CB6C0-0x00000001819CB8E0
	// [XID] // 0x000000018961D3F0-0x000000018961D410
	public bool isInMultiPlayerMode(bool checkPlayerNumber = false /* Metadata: 0x00AFF998 */) => default; // 0x00000001819D1B10-0x00000001819D1C40
	// [XID] // 0x00000001896248B0-0x00000001896248D0
	public int GetSquadIndex(uint uid) => default; // 0x00000001819C5A60-0x00000001819C5B30
	// [XID] // 0x0000000189633BB0-0x0000000189633BD0
	public int GetBigWorldSquadMarkIndex(uint uid) => default; // 0x00000001819CE5A0-0x00000001819CE790
	// [XID] // 0x000000018963B430-0x000000018963B450
	public int GetBigWorldAvailableAvatarCount() => default; // 0x00000001819C5E50-0x00000001819C5F80
	// [XID] // 0x000000018964A210-0x000000018964A230
	public int GetDungeonSquadIndex(uint uid) => default; // 0x00000001819D04D0-0x00000001819D05A0
	// [XID] // 0x0000000189659210-0x0000000189659230
	public int GetCurrWorldSquadIndex(uint uid) => default; // 0x00000001819C8EA0-0x00000001819C8F70
	// [XID] // 0x0000000189660890-0x00000001896608B0
	public OnlinePlayerData GetPlayerData(uint uid) => default; // 0x00000001819B5DB0-0x00000001819B5FB0
	// [XID] // 0x00000001896682A0-0x00000001896682C0
	public void SetPlayerData(uint uid, OnlinePlayerData playerData) {} // 0x00000001819BCE60-0x00000001819BCFB0
	// [XID] // 0x0000000189677560-0x0000000189677580
	public OnlinePlayerData GetHomeworldPlayerData(uint uid) => default; // 0x00000001819C4D40-0x00000001819C4F40
	// [XID] // 0x000000018967EB60-0x000000018967EB80
	public void UpdatePlayerDataNickname(string nickname) {} // 0x00000001819BCC90-0x00000001819BCE60
	// [XID] // 0x00000001896A43A0-0x00000001896A43C0
	private void OnWorldPlayerInfoNotify(WorldPlayerInfoNotify ntf) {} // 0x00000001819C81D0-0x00000001819C8EA0
	// [XID] // 0x00000001896ABB90-0x00000001896ABBB0
	private bool CompareWorldPlayersList(List<uint> squadUids, RepeatedField<uint> currRepeatedField) => default; // 0x00000001819BEC70-0x00000001819BEE30
	// [XID] // 0x00000001896B2CD0-0x00000001896B2CF0
	private void OnWorldPlayerLeave(uint uid) {} // 0x00000001819CDF40-0x00000001819CE2F0
	// [XID] // 0x00000001896BA370-0x00000001896BA390
	private void OnScenePlayerInfoNotify(ScenePlayerInfoNotify ntf) {} // 0x00000001819CEBE0-0x00000001819CF100
	// [XID] // 0x00000001896C1600-0x00000001896C1620
	private void OnWorldPlayerLocationNotify(WorldPlayerLocationNotify ntf) {} // 0x00000001819CF850-0x00000001819CFC80
	// [XID] // 0x00000001896C8D40-0x00000001896C8D60
	private void OnScenePlayerLocationNotify(ScenePlayerLocationNotify ntf) {} // 0x00000001819D0BF0-0x00000001819D0E30
	// [XID] // 0x00000001896D06E0-0x00000001896D0700
	private void OnPlayerQuitFromMpNotify(PlayerQuitFromMpNotify ntf) {} // 0x00000001819BBBC0-0x00000001819BC0C0
	// [XID] // 0x00000001896D7C10-0x00000001896D7C30
	public void UpdateSelfPeerID(uint uid, uint peerID) {} // 0x00000001819C6E10-0x00000001819C6EF0
	// [XID] // 0x00000001896DF460-0x00000001896DF480
	public uint GetPeerIDByUID(uint uid) => default; // 0x00000001819B5FB0-0x00000001819B6190
	// [XID] // 0x00000001896E6800-0x00000001896E6820
	public uint GetPeerIDByGUID(ulong guid) => default; // 0x00000001819D10A0-0x00000001819D1220
	// [XID] // 0x00000001896EDDD0-0x00000001896EDDF0
	public void AddGUIDPeerIdMap(ulong guid, uint peerId) {} // 0x00000001819CB170-0x00000001819CB250
	// [XID] // 0x00000001896F5630-0x00000001896F5650
	public void UpdateAvatarPeerIDByPlayerUID(ulong avatarGUID, uint playerUID) {} // 0x00000001819C2CF0-0x00000001819C2DD0
	// [XID] // 0x00000001896FCE10-0x00000001896FCE30
	public Dictionary<ulong, uint> GetGUIDPeerIdMap() => default; // 0x00000001819C4CA0-0x00000001819C4D40
	// [XID] // 0x00000001897042C0-0x00000001897042E0
	public void MapGUIDListToInLevelDataPeerId(List<ulong> guidList) {} // 0x00000001819B6900-0x00000001819B6AC0
	// [XID] // 0x000000018970BB10-0x000000018970BB30
	public AvatarEntity GetActiveAvatarEntityByPeerId(uint peerId) => default; // 0x00000001819C3AA0-0x00000001819C3F00
	// [XID] // 0x00000001897133C0-0x00000001897133E0
	public void ChangeBigWorldTeam(List<ulong> avatarGuidList, ulong currAvatarGuid) {} // 0x00000001819C63C0-0x00000001819C6630
	// [XID] // 0x000000018971AC40-0x000000018971AC60
	private void OnChangeMpTeamAvatarRsp(ChangeMpTeamAvatarRsp rsp) {} // 0x00000001819C04A0-0x00000001819C06A0
	// [XID] // 0x0000000189721F40-0x0000000189721F60
	public void GetHostPlayers(ref List<uint> uidList, bool filterOutUnreachable = false /* Metadata: 0x00AFF999 */) {} // 0x00000001819BA6C0-0x00000001819BA830
	// [XID] // 0x0000000189729690-0x00000001897296B0
	public bool TryGetHostPlayerData(uint hostUID, out HostPlayerData data) {
		data = default;
		return default;
	} // 0x00000001819C50A0-0x00000001819C5190
	// [XID] // 0x0000000189730EA0-0x0000000189730EC0
	private void OnGetOnlinePlayerListRsp(GetOnlinePlayerListRsp rsp) {} // 0x00000001819C6EF0-0x00000001819C7390
	// [IDTag] // 0x0000000189738730-0x0000000189738770
	// [XID] // 0x0000000189738730-0x0000000189738770
	public void GetOnlinePlayerInfoReq(uint uid) {} // 0x00000001819BDE80-0x00000001819BDF80
	// [IDTag] // 0x0000000189743000-0x0000000189743040
	// [XID] // 0x0000000189743000-0x0000000189743040
	public void GetOnlinePlayerInfoReq(string onlineId) {} // 0x00000001819BDF80-0x00000001819BE080
	// [XID] // 0x000000018974DA30-0x000000018974DA50
	public void GetOnlinePlayerInfoReqByPsnId(string psnId) {} // 0x00000001819CCAF0-0x00000001819CCBF0
	// [XID] // 0x00000001897550A0-0x00000001897550C0
	private void OnGetOnlinePlayerInfoRsp(GetOnlinePlayerInfoRsp rsp) {} // 0x00000001819B6380-0x00000001819B67E0
	// [XID] // 0x000000018975C210-0x000000018975C230
	public bool RequestPlayerApplyEnterMp(uint targetUid, bool request = true /* Metadata: 0x00AFF99A */) => default; // 0x00000001819BEE30-0x00000001819BEFE0
	// [XID] // 0x0000000189763BC0-0x0000000189763BE0
	public bool CanReapply(uint targetUID) => default; // 0x00000001819D21C0-0x00000001819D2320
	// [XID] // 0x000000018976B3C0-0x000000018976B3E0
	private void OnPlayerApplyEnterMpRsp(PlayerApplyEnterMpRsp rsp) {} // 0x00000001819D2EA0-0x00000001819D3200
	// [XID] // 0x00000001897729E0-0x0000000189772A00
	public float GetApplyCooldown(uint uid) => default; // 0x00000001819C4060-0x00000001819C41B0
	// [XID] // 0x0000000189781D40-0x0000000189781D60
	public MPRequestState GetRequestState(uint hostUID) => default; // 0x00000001819C9180-0x00000001819C9270
	// [XID] // 0x00000001897890E0-0x0000000189789100
	private void OnPlayerApplyEnterMpResultNotify(PlayerApplyEnterMpResultNotify ntf) {} // 0x00000001819CBC00-0x00000001819CC0F0
	// [XID] // 0x0000000189790770-0x0000000189790790
	public void RemoveHostPlayerAt(uint uid) {} // 0x00000001819CB250-0x00000001819CB490
	// [XID] // 0x0000000189798080-0x00000001897980A0
	public void RequestJoinPlayerScene(uint targetUID) {} // 0x00000001819D1FE0-0x00000001819D2120
	// [XID] // 0x000000018979FF10-0x000000018979FF30
	private void OnJoinPlayerSceneRsp(JoinPlayerSceneRsp rsp) {} // 0x00000001819B6C70-0x00000001819B6F50
	// [XID] // 0x00000001897A7420-0x00000001897A7440
	private void OnJoinPlayerFailNotify(JoinPlayerFailNotify ntf) {} // 0x00000001819BE670-0x00000001819BE800
	// [XID] // 0x00000001897AEEF0-0x00000001897AEF10
	private void ClearApplyEnterData() {} // 0x00000001819BD170-0x00000001819BD290
	// [XID] // 0x00000001897BEC50-0x00000001897BEC70
	public void RemoveTimeoutRequest() {} // 0x00000001819D1450-0x00000001819D1640
	// [XID] // 0x00000001897C60F0-0x00000001897C6110
	public void DeniedApplingGuest(uint guestUID, ApplingGuestType type) {} // 0x00000001819B7B40-0x00000001819B7CE0
	// [XID] // 0x00000001897CD960-0x00000001897CD980
	public void AcceptApplingGuest(uint guestUID, ApplingGuestType type) {} // 0x00000001819CAE00-0x00000001819CAFB0
	// [XID] // 0x00000001897D4ED0-0x00000001897D4EF0
	private void OnPlayerApplyEnterMpNotify(PlayerApplyEnterMpNotify ntf) {} // 0x00000001819BE080-0x00000001819BE340
	// [XID] // 0x00000001897DC630-0x00000001897DC650
	private void RequestPlayerApplyEnterMpResult(uint uid, bool accept) {} // 0x00000001819CFD80-0x00000001819CFEB0
	// [XID] // 0x00000001897E4030-0x00000001897E4050
	private void OnPlayerApplyEnterMpResultRsp(PlayerApplyEnterMpResultRsp rsp) {} // 0x00000001819C6840-0x00000001819C69A0
	// [XID] // 0x00000001897EBBA0-0x00000001897EBBC0
	private void ClearHandleApplyEnterData() {} // 0x00000001819C99F0-0x00000001819C9AB0
	// [XID] // 0x00000001897F3470-0x00000001897F3490
	private void OnPlayerPreEnterMpNotify(PlayerPreEnterMpNotify ntf) {} // 0x00000001819C2DD0-0x00000001819C2FF0
	// [XID] // 0x00000001897FAE70-0x00000001897FAE90
	public bool CanReapplyHomeworld(uint targetUID) => default; // 0x00000001819C2FF0-0x00000001819C3150
	// [XID] // 0x0000000189802370-0x0000000189802390
	public float GetHomeworldApplyCooldown(uint uid) => default; // 0x00000001819CB020-0x00000001819CB170
	// [XID] // 0x0000000189809780-0x00000001898097A0
	public MPRequestState GetHomeworldRequestState(uint hostUID) => default; // 0x00000001819BE900-0x00000001819BE9F0
	// [XID] // 0x0000000189810F10-0x0000000189810F30
	public void ChangeHomeworldRequestState2Cooldown(uint uid) {} // 0x00000001819BD290-0x00000001819BD3A0
	// [XID] // 0x0000000189818A70-0x0000000189818A90
	public void RequestEnterHomeworld(uint uid) {} // 0x00000001819D3360-0x00000001819D34C0
	// [XID] // 0x00000001898202B0-0x00000001898202D0
	private void OnPlayerApplyEnterHomeNotify(PlayerApplyEnterHomeNotify ntf) {} // 0x00000001819B8E50-0x00000001819B9100
	// [XID] // 0x0000000189827910-0x0000000189827930
	private void RequestPlayerApplyEnterHomeResult(uint uid, bool accept) {} // 0x00000001819B6B40-0x00000001819B6C70
	// [XID] // 0x000000018982EB30-0x000000018982EB50
	private void OnPlayerApplyEnterHomeResultRsp(PlayerApplyEnterHomeResultRsp rsp) {} // 0x00000001819BF550-0x00000001819BF6B0
	// [XID] // 0x00000001898364D0-0x00000001898364F0
	private void OnPlayerApplyEnterHomeResultNotify(PlayerApplyEnterHomeResultNotify ntf) {} // 0x00000001819B5560-0x00000001819B5690
	// [XID] // 0x000000018983D8E0-0x000000018983D900
	public void RequestHomeGetOnlineStatus() {} // 0x00000001819D2DC0-0x00000001819D2EA0
	// [XID] // 0x00000001898451B0-0x00000001898451D0
	private void OnHomeGetOnlineStatusRsp(HomeGetOnlineStatusRsp rsp) {} // 0x00000001819C3460-0x00000001819C3820
	// [XID] // 0x000000018984C620-0x000000018984C640
	public void RequestSetFriendEnterHomeOption(FriendEnterHomeOption option) {} // 0x00000001819B92D0-0x00000001819B93D0
	// [XID] // 0x00000001898536A0-0x00000001898536C0
	private void OnSetFriendEnterHomeOptionRsp(SetFriendEnterHomeOptionRsp rsp) {} // 0x00000001819B93D0-0x00000001819B9530
	// [XID] // 0x000000018985B190-0x000000018985B1B0
	public void RequestHomeKickPlayer(uint uid) {} // 0x00000001819C9D80-0x00000001819C9E80
	// [XID] // 0x0000000189862690-0x00000001898626B0
	private void OnHomeKickPlayerRsp(HomeKickPlayerRsp rsp) {} // 0x00000001819CA180-0x00000001819CA4D0
	// [XID] // 0x0000000189869A80-0x0000000189869AA0
	private void OnPlayerQuitFromHomeNotify(PlayerQuitFromHomeNotify ntf) {} // 0x00000001819C56B0-0x00000001819C57D0
	// [XID] // 0x0000000189870D80-0x0000000189870DA0
	public void RequestSceneKickPlayer(uint uid) {} // 0x00000001819BDD80-0x00000001819BDE80
	// [XID] // 0x00000001898787B0-0x00000001898787D0
	private void OnSceneKickPlayerRsp(SceneKickPlayerRsp rsp) {} // 0x00000001819BE9F0-0x00000001819BEC70
	// [XID] // 0x000000018987FD60-0x000000018987FD80
	private void OnSceneKickPlayerNotify(SceneKickPlayerNotify ntf) {} // 0x00000001819CE2F0-0x00000001819CE450
	// [XID] // 0x0000000189887360-0x0000000189887380
	public void RequestBackMyWorld() {} // 0x00000001819D1C40-0x00000001819D1D20
	// [XID] // 0x000000018988E4E0-0x000000018988E500
	private void OnBackMyWorldRsp(BackMyWorldRsp rsp) {} // 0x00000001819C57D0-0x00000001819C5970
	// [XID] // 0x000000018989D1A0-0x000000018989D1C0
	public bool IsPlayerReady(uint uid) => default; // 0x00000001819C0080-0x00000001819C0150
	// [XID] // 0x00000001898A4AC0-0x00000001898A4AE0
	private void OnDungeonCandidateTeamInfoNotify(DungeonCandidateTeamInfoNotify ntf) {} // 0x00000001819C9270-0x00000001819C98F0
	// [XID] // 0x00000001898ABFA0-0x00000001898ABFC0
	private void CheckAvatarDuplicated(List<MPTeamAvatarData> teamData) {} // 0x00000001819BCA30-0x00000001819BCC90
	// [XID] // 0x00000001898B3660-0x00000001898B3680
	public void ChangeDungeonTeam(List<ulong> avatarGuidList) {} // 0x00000001819C5B30-0x00000001819C5E50
	// [XID] // 0x00000001898BB490-0x00000001898BB4B0
	private int DungeonTeamSelfAvatarCount(int playerCount, bool host) => default; // 0x00000001819B9D80-0x00000001819B9E90
	// [XID] // 0x00000001898C2740-0x00000001898C2760
	private void OnDungeonCandidateTeamChangeAvatarRsp(DungeonCandidateTeamChangeAvatarRsp rsp) {} // 0x00000001819CFEB0-0x00000001819D00B0
	// [XID] // 0x00000001898CA1A0-0x00000001898CA1C0
	public void LeaveDungeonTeam() {} // 0x00000001819B6190-0x00000001819B6270
	// [XID] // 0x00000001898D18F0-0x00000001898D1910
	private void OnDungeonCandidateTeamLeaveRsp(DungeonCandidateTeamLeaveRsp rsp) {} // 0x00000001819C3F00-0x00000001819C4060
	// [XID] // 0x00000001898D9050-0x00000001898D9070
	private void OnDungeonCandidateTeamPlayerLeaveNotify(DungeonCandidateTeamPlayerLeaveNotify ntf) {} // 0x00000001819CD130-0x00000001819CD300
	// [XID] // 0x00000001898E0D10-0x00000001898E0D30
	private void OnDungeonCandidateTeamDismissNotify(DungeonCandidateTeamDismissNotify ntf) {} // 0x00000001819BF1A0-0x00000001819BF320
	// [XID] // 0x00000001898E8880-0x00000001898E88A0
	public void RequestCreateDungeonMPTeam(uint pointID, uint dungeonID) {} // 0x00000001819C0150-0x00000001819C0270
	// [XID] // 0x00000001898EFFA0-0x00000001898EFFC0
	private void OnDungeonCandidateTeamCreateRsp(DungeonCandidateTeamCreateRsp rsp) {} // 0x00000001819C8000-0x00000001819C8160
	// [XID] // 0x00000001898F7830-0x00000001898F7850
	public bool IsInvitedToDungeon(uint uid) => default; // 0x00000001819C4580-0x00000001819C4650
	// [XID] // 0x00000001898FEED0-0x00000001898FEEF0
	public bool CheckInviteTimeout(uint uid) => default; // 0x00000001819CD980-0x00000001819CDAB0
	// [XID] // 0x00000001899066F0-0x0000000189906710
	public int GetDungeonInvitingCount() => default; // 0x00000001819D2320-0x00000001819D23E0
	// [XID] // 0x000000018990E170-0x000000018990E190
	public void InviteAllCompanionsToDungeon() {} // 0x00000001819CF5E0-0x00000001819CF850
	// [XID] // 0x00000001899158C0-0x00000001899158E0
	public void InviteCompanionToDungeon(uint uid) {} // 0x00000001819B7560-0x00000001819B76F0
	// [XID] // 0x000000018991D2B0-0x000000018991D2D0
	private void OnDungeonCandidateTeamInviteRsp(DungeonCandidateTeamInviteRsp rsp) {} // 0x00000001819C2090-0x00000001819C21F0
	// [XID] // 0x0000000189924B60-0x0000000189924B80
	public bool IsPlayerInDungeonTeam(uint uid) => default; // 0x00000001819CA4D0-0x00000001819CA5A0
	// [XID] // 0x000000018992C0A0-0x000000018992C0C0
	public bool IsPlayerInvitedToDungeon(uint uid) => default; // 0x00000001819BADF0-0x00000001819BAEC0
	// [XID] // 0x0000000189933520-0x0000000189933540
	public void KickFromDungeonTeam(uint playerUid) {} // 0x00000001819BE800-0x00000001819BE900
	// [XID] // 0x000000018993B1B0-0x000000018993B1D0
	public void OnDungeonCandidateTeamKickRsp(DungeonCandidateTeamKickRsp rsp) {} // 0x00000001819C7460-0x00000001819C75C0
	// [XID] // 0x00000001899422E0-0x0000000189942300
	private void OnDungeonCandidateTeamRefuseNotify(DungeonCandidateTeamRefuseNotify ntf) {} // 0x00000001819C5250-0x00000001819C54B0
	// [XID] // 0x0000000189949BC0-0x0000000189949BE0
	private void OnDungeonCandidateTeamInviteNotify(DungeonCandidateTeamInviteNotify ntf) {} // 0x00000001819BB270-0x00000001819BB4B0
	// [XID] // 0x00000001899517C0-0x00000001899517E0
	public bool TryGetDungeonInvitation(out InvitingHostData invitingHost) {
		invitingHost = default;
		return default;
	} // 0x00000001819C41B0-0x00000001819C4330
	// [XID] // 0x0000000189958D50-0x0000000189958D70
	private void CheckNeedOpenTeamPage() {} // 0x00000001819BCFB0-0x00000001819BD170
	// [XID] // 0x0000000189960400-0x0000000189960420
	public void HandleDungeonInvitaion(bool accept) {} // 0x00000001819C3340-0x00000001819C3460
	// [XID] // 0x0000000189967E00-0x0000000189967E20
	private void OnDungeonCandidateTeamReplyInviteRsp(DungeonCandidateTeamReplyInviteRsp rsp) {} // 0x00000001819C69A0-0x00000001819C6CA0
	// [XID] // 0x000000018996F080-0x000000018996F0A0
	public void SetDungeonReady(bool ready) {} // 0x00000001819CFC80-0x00000001819CFD80
	// [XID] // 0x0000000189976BB0-0x0000000189976BD0
	private void OnDungeonCandidateTeamSetReadyRsp(DungeonCandidateTeamSetReadyRsp rsp) {} // 0x00000001819B5C50-0x00000001819B5DB0
	// [XID] // 0x0000000189928A30-0x0000000189928A50
	public bool IsHostOnlineMatching() => default; // 0x00000001819BB140-0x00000001819BB270
	// [XID] // 0x0000000189A2A300-0x0000000189A2A320
	public void RequestPlayerStartMatch(uint id, MatchType matchType = MatchType.Dungeon /* Metadata: 0x00AFF99B */, uint difficultLevel = 0 /* Metadata: 0x00AFF99F */) {} // 0x00000001819CF470-0x00000001819CF5E0
	// [XID] // 0x0000000189A31750-0x0000000189A31770
	private void OnPlayerStartMatchRsp(PlayerStartMatchRsp rsp) {} // 0x00000001819BA050-0x00000001819BA650
	// [XID] // 0x0000000189A39270-0x0000000189A39290
	private void OnPlayerMatchInfoNotify(PlayerMatchInfoNotify ntf) {} // 0x00000001819CF240-0x00000001819CF470
	// [XID] // 0x0000000189A40A70-0x0000000189A40A90
	public void RequestPlayerCancelMatch() {} // 0x00000001819BACB0-0x00000001819BADF0
	// [XID] // 0x0000000189A480B0-0x0000000189A480D0
	private void OnPlayerCancelMatchRsp(PlayerCancelMatchRsp rsp) {} // 0x00000001819C5FE0-0x00000001819C61E0
	// [XID] // 0x0000000189A4F940-0x0000000189A4F960
	private void ClearMatchInfo() {} // 0x00000001819BC720-0x00000001819BC980
	// [XID] // 0x0000000189A56F70-0x0000000189A56F90
	private void OnPlayerMatchStopNotify(PlayerMatchStopNotify ntf) {} // 0x00000001819D3200-0x00000001819D3360
	// [XID] // 0x0000000189A5EB50-0x0000000189A5EB70
	private void OnPlayerMatchSuccNotify(PlayerMatchSuccNotify ntf) {} // 0x00000001819B6F50-0x00000001819B7360
	// [XID] // 0x0000000189A66250-0x0000000189A66270
	private void OnPlayerGeneralMatchSuccNotify(PlayerMatchSuccNotify ntf) {} // 0x00000001819BC1A0-0x00000001819BC510
	// [XID] // 0x0000000189A6D9C0-0x0000000189A6D9E0
	public void TryShowGeneralMatchMPPlayDialog() {} // 0x00000001819CB490-0x00000001819CB650
	// [XID] // 0x0000000189A75110-0x0000000189A75130
	public void RequestPlayerConfirmMatch(MatchType matchType, bool isAgree) {} // 0x00000001819D29F0-0x00000001819D2BF0
	// [XID] // 0x0000000189A7CD70-0x0000000189A7CD90
	private void OnPlayerConfirmMatchRsp(PlayerConfirmMatchRsp rsp) {} // 0x00000001819C7A70-0x00000001819C7DE0
	// [XID] // 0x0000000189A84600-0x0000000189A84620
	private void OnPlayerGeneralMatchConfirmNotify(PlayerGeneralMatchConfirmNotify ntf) {} // 0x00000001819C9BB0-0x00000001819C9D80
	// [XID] // 0x0000000189A8BF40-0x0000000189A8BF60
	private void OnPlayerGeneralMatchDismissNotify(PlayerGeneralMatchDismissNotify ntf) {} // 0x00000001819C6CA0-0x00000001819C6E10
	// [XID] // 0x0000000189A93470-0x0000000189A93490
	private void ShowMatchInviteResult() {} // 0x00000001819CC5B0-0x00000001819CCA50
	// [XID] // 0x0000000189A9AF60-0x0000000189A9AF80
	private void OnPlayerMatchAgreedResultNotify(PlayerMatchAgreedResultNotify ntf) {} // 0x00000001819BFBD0-0x00000001819C0080
	// [XID] // 0x0000000189AA22F0-0x0000000189AA2310
	public void RequestChangeWorldToSingleMode() {} // 0x00000001819B7360-0x00000001819B7440
	// [XID] // 0x0000000189AA9820-0x0000000189AA9840
	public void RequestGetWorldMpInfo() {} // 0x00000001819C2600-0x00000001819C2710
	// [XID] // 0x0000000189AB15E0-0x0000000189AB1600
	private void OnGetPlayerMpModeAvailabilityRsp(GetPlayerMpModeAvailabilityRsp rsp) {} // 0x00000001819C0E40-0x00000001819C14F0
	// [XID] // 0x0000000189B23940-0x0000000189B23960
	private Dictionary<uint, bool> GetMPPlayStateDic(uint uid) => default; // 0x00000001819BB720-0x00000001819BB870
	// [XID] // 0x0000000189B2AC20-0x0000000189B2AC40
	public Dictionary<uint, bool> TryGetMPPlayStateDic(uint uid) => default; // 0x00000001819CC0F0-0x00000001819CC1D0
	// [XID] // 0x0000000189B32180-0x0000000189B321A0
	public int GetMatchReadyNum() => default; // 0x00000001819C2A00-0x00000001819C2CF0
	// [XID] // 0x0000000189B39B30-0x0000000189B39B50
	public Dictionary<uint, bool> GetMPDungeonStateDic() => default; // 0x00000001819D0110-0x00000001819D01C0
	// [XID] // 0x0000000189B41330-0x0000000189B41350
	public void RequestMpPlayOwnerCheck(uint playId) {} // 0x00000001819B7440-0x00000001819B7560
	// [XID] // 0x0000000189B48C80-0x0000000189B48CA0
	public void RequestScenePlayOwnerCheck(uint playId) {} // 0x00000001819B67E0-0x00000001819B6900
	// [XID] // 0x0000000189B503E0-0x0000000189B50400
	private void OnMpPlayOwnerCheckRsp(MpPlayOwnerCheckRsp rsp) {} // 0x00000001819B76F0-0x00000001819B7B40
	// [XID] // 0x0000000189B57BD0-0x0000000189B57BF0
	private void OnScenePlayOwnerCheckRsp(ScenePlayOwnerCheckRsp rsp) {} // 0x00000001819C0890-0x00000001819C0E40
	// [XID] // 0x0000000189B5F5E0-0x0000000189B5F600
	private void TryRequestMpPlayOwnerStartInvite(uint playId) {} // 0x00000001819CD300-0x00000001819CD560
	// [XID] // 0x0000000189B66D00-0x0000000189B66D20
	private void TryRequestScenePlayOwnerStartInvite(uint playId) {} // 0x00000001819BA930-0x00000001819BAB90
	// [XID] // 0x0000000189B6E060-0x0000000189B6E080
	public void TryRequestDraftOwnerStartInvite(uint draftId) {} // 0x00000001819BD620-0x00000001819BD8B0
	// [XID] // 0x0000000189B75810-0x0000000189B75830
	private void RequestMpPlayOwnerStartInvite(uint playId) {} // 0x00000001819CF100-0x00000001819CF240
	// [XID] // 0x0000000189B7CCB0-0x0000000189B7CCD0
	private void RequestScenePlayOwnerStartInvite(uint playId) {} // 0x00000001819C4440-0x00000001819C4580
	// [XID] // 0x0000000189B84B50-0x0000000189B84B70
	private void RequestDraftOwnerStartInvite(uint draftId) {} // 0x00000001819C4A50-0x00000001819C4B80
	// [XID] // 0x0000000189B8B900-0x0000000189B8B920
	private void OnMpPlayOwnerStartInviteRsp(MpPlayOwnerStartInviteRsp rsp) {} // 0x00000001819BBA60-0x00000001819BBBC0
	// [XID] // 0x0000000189B930F0-0x0000000189B93110
	private void OnScenePlayOwnerStartInviteRsp(ScenePlayOwnerStartInviteRsp rsp) {} // 0x00000001819CCBF0-0x00000001819CCDE0
	// [XID] // 0x0000000189B9A640-0x0000000189B9A660
	private void OnDraftOwnerStartInviteRsp(DraftOwnerStartInviteRsp rsp) {} // 0x00000001819D23E0-0x00000001819D28F0
	// [XID] // 0x0000000189BA1E10-0x0000000189BA1E30
	private void OnMpPlayOwnerInviteNotify(MpPlayOwnerInviteNotify ntf) {} // 0x00000001819C4650-0x00000001819C4880
	// [XID] // 0x0000000189BA9200-0x0000000189BA9220
	private void OnScenePlayOwnerInviteNotify(ScenePlayOwnerInviteNotify ntf) {} // 0x00000001819CE9B0-0x00000001819CEBE0
	// [XID] // 0x0000000189BB0990-0x0000000189BB09B0
	private void OnDraftOwnerInviteNotify(DraftOwnerInviteNotify ntf) {} // 0x00000001819BD3A0-0x00000001819BD620
	// [XID] // 0x0000000189BB7CA0-0x0000000189BB7CC0
	private void OnDraftOwnerTwiceConfirmNotify(DraftOwnerTwiceConfirmNotify ntf) {} // 0x00000001819CD050-0x00000001819CD130
	// [XID] // 0x0000000189BBF390-0x0000000189BBF3B0
	public void ShowDraftOwnerTwiceConfirmDialog() {} // 0x00000001819BAEC0-0x00000001819BB140
	// [XID] // 0x0000000189BC6F50-0x0000000189BC6F70
	public void RequestMpPlayGuestReplyInvite(bool isAgree, uint playId) {} // 0x00000001819B9E90-0x00000001819BA050
	// [XID] // 0x0000000189BCEC60-0x0000000189BCEC80
	public void RequestScenePlayGuestReplyInvite(bool isAgree, uint playId) {} // 0x00000001819CC3F0-0x00000001819CC5B0
	// [XID] // 0x0000000189BD5FA0-0x0000000189BD5FC0
	public void RequestDraftGuestReplyInvite(bool isAgree, uint draftId) {} // 0x00000001819BEFE0-0x00000001819BF1A0
	// [XID] // 0x0000000189BDDBC0-0x0000000189BDDBE0
	public void RequestDraftGuestReplyTwiceConfirm(bool isAgree, uint draftId) {} // 0x00000001819CE790-0x00000001819CE950
	// [XID] // 0x00000001895EA720-0x00000001895EA740
	public void RequestDungeonRestartReplyInvite(bool isAgree) {} // 0x00000001819BF6B0-0x00000001819BF840
	// [XID] // 0x00000001895F1CB0-0x00000001895F1CD0
	public void RequestDungeonRestart() {} // 0x00000001819BC0C0-0x00000001819BC1A0
	// [XID] // 0x00000001895F9630-0x00000001895F9650
	private void OnMpPlayGuestReplyInviteRsp(MpPlayGuestReplyInviteRsp rsp) {} // 0x00000001819C9F90-0x00000001819CA180
	// [XID] // 0x0000000189600D00-0x0000000189600D20
	private void OnScenePlayGuestReplyInviteRsp(ScenePlayGuestReplyInviteRsp rsp) {} // 0x00000001819BB870-0x00000001819BBA60
	// [XID] // 0x0000000189608670-0x0000000189608690
	private void OnDraftGuestReplyInviteRsp(DraftGuestReplyInviteRsp rsp) {} // 0x00000001819C3150-0x00000001819C3340
	// [XID] // 0x000000018960FE90-0x000000018960FEB0
	private void OnDraftGuestReplyTwiceConfirmRsp(DraftGuestReplyTwiceConfirmRsp rsp) {} // 0x00000001819C1630-0x00000001819C1820
	// [XID] // 0x00000001896171D0-0x00000001896171F0
	private void OnMpPlayGuestReplyNotify(MpPlayGuestReplyNotify ntf) {} // 0x00000001819C4880-0x00000001819C4A50
	// [XID] // 0x000000018961EDC0-0x000000018961EDE0
	private void OnScenePlayGuestReplyNotify(ScenePlayGuestReplyNotify ntf) {} // 0x00000001819D2BF0-0x00000001819D2DC0
	// [XID] // 0x0000000189626140-0x0000000189626160
	private void OnDraftGuestReplyInviteNotify(DraftGuestReplyInviteNotify ntf) {} // 0x00000001819C78A0-0x00000001819C7A70
	// [XID] // 0x000000018962DB70-0x000000018962DB90
	private void OnDraftGuestReplyTwiceConfirmNotify(DraftGuestReplyTwiceConfirmNotify ntf) {} // 0x00000001819C3820-0x00000001819C39F0
	// [XID] // 0x0000000189635730-0x0000000189635750
	private void OnMpPlayInviteResultNotify(MpPlayInviteResultNotify ntf) {} // 0x00000001819C8F70-0x00000001819C9180
	// [XID] // 0x000000018963CE10-0x000000018963CE30
	private void OnScenePlayInviteResultNotify(ScenePlayInviteResultNotify ntf) {} // 0x00000001819BD8B0-0x00000001819BDAC0
	// [XID] // 0x0000000189644390-0x00000001896443B0
	private void OnDraftInviteResultNotify(DraftInviteResultNotify ntf) {} // 0x00000001819BC510-0x00000001819BC720
	// [XID] // 0x000000018964BBD0-0x000000018964BBF0
	private void OnDraftTwiceConfirmResultNotify(DraftTwiceConfirmResultNotify ntf) {} // 0x00000001819C66E0-0x00000001819C6840
	// [XID] // 0x0000000189653260-0x0000000189653280
	private void OnMpPlayPrepareNotify(MpPlayPrepareNotify ntf) {} // 0x00000001819C14F0-0x00000001819C1630
	// [XID] // 0x000000018965AAF0-0x000000018965AB10
	private void OnMpPlayPrepareInterruptNotify(MpPlayPrepareInterruptNotify ntf) {} // 0x00000001819C0270-0x00000001819C0390
	// [XID] // 0x0000000189661F80-0x0000000189661FA0
	private void OnScenePlayInfoListNotify(ScenePlayInfoListNotify ntf) {} // 0x00000001819CD860-0x00000001819CD980
	// [XID] // 0x0000000189669B40-0x0000000189669B60
	public ScenePlayInfo GetScenePlayInfoByType(MpPlayType playType) => default; // 0x00000001819CC1D0-0x00000001819CC340
	// [XID] // 0x0000000189671780-0x00000001896717A0
	private void OnScenePlayBattleInfoListNotify(ScenePlayBattleInfoListNotify ntf) {} // 0x00000001819D1D20-0x00000001819D1FE0
	// [XID] // 0x0000000189678FB0-0x0000000189678FD0
	private void OnScenePlayBattleInfoNotify(ScenePlayBattleInfoNotify ntf) {} // 0x00000001819B5690-0x00000001819B5930
	// [IDTag] // 0x00000001896806B0-0x00000001896806F0
	// [XID] // 0x00000001896806B0-0x00000001896806F0
	private void CheckScenePlayBattle(ScenePlayBattleInfo oldInfo, ScenePlayBattleInfo newInfo) {} // 0x00000001819D0600-0x00000001819D0AE0
	// [IDTag] // 0x000000018968B0D0-0x000000018968B110
	// [XID] // 0x000000018968B0D0-0x000000018968B110
	public void CheckScenePlayBattle() {} // 0x00000001819D0AE0-0x00000001819D0BF0
	// [XID] // 0x0000000189695B30-0x0000000189695B50
	private uint GetScenePlayStage(IList<uint> progressStageList, uint progress) => default; // 0x00000001819C4B80-0x00000001819C4CA0
	// [XID] // 0x000000018969D280-0x000000018969D2A0
	private void OnScenePlayBattleInterruptNotify(ScenePlayBattleInterruptNotify ntf) {} // 0x00000001819CCDE0-0x00000001819CD050
	// [XID] // 0x00000001896A4380-0x00000001896A43A0
	private void ClearScenePlayBattle() {} // 0x00000001819C2710-0x00000001819C2860
	// [XID] // 0x00000001896ABB70-0x00000001896ABB90
	private void OnScenePlayBattleResultNotify(ScenePlayBattleResultNotify ntf) {} // 0x00000001819BF840-0x00000001819BFB60
	// [XID] // 0x00000001896B2CB0-0x00000001896B2CD0
	private void OnScenePlayBattleUidOpNotify(ScenePlayBattleUidOpNotify notify) {} // 0x00000001819CA5A0-0x00000001819CAE00
	// [XID] // 0x00000001896BA350-0x00000001896BA370
	private void OnMpBlockNotify(MpBlockNotify ntf) {} // 0x00000001819B5930-0x00000001819B5B90
	// [XID] // 0x00000001896C15E0-0x00000001896C1600
	public void QuitMp() {} // 0x00000001819C61E0-0x00000001819C63C0
	// [XID] // 0x00000001896C8D20-0x00000001896C8D40
	private void OnPlayerGetForceQuitBanInfoRsp(PlayerGetForceQuitBanInfoRsp rsp) {} // 0x00000001819C1820-0x00000001819C2090
	// [XID] // 0x00000001896D06C0-0x00000001896D06E0
	public void HandleGM(string[] args) {} // 0x00000001819CB8E0-0x00000001819CBB50
}

