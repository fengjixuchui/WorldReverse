/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PlayerModule : CharacterModule // TypeDefIndex: 21567
{
    // Fields
    public PlayerOpenStateData openState; // 0x20
    public uint curSceneID; // 0x28
    private SceneExcelConfig _curSceneConfig; // 0x30
    public bool isServerLevelPaused; // 0x38
    public uint extraAbilityId; // 0x3C
    public bool extraAbilityEnable; // 0x40
    public ulong extraAbilityUseTime; // 0x48
    public float lastSendChangeAvatarTime; // 0x50
    public float lastPressSkillButtonTime; // 0x54
    private float _nextLoginReqTime; // 0x58
    private const float DUPLICATE_LOGIN_TIME = 120f; // Metadata: 0x00AFF980
    private Dictionary<ulong, uint> _backgroundAvatarRecoverTime; // 0x60
    private MapField<ulong, AvatarExpeditionInfo> _currExpeditionInfo; // 0x68
    private AvatarExpeditionAllDataRsp _currAllDataRsp; // 0x70
    private List<ulong> _teamToLoad; // 0x78
    private bool needRecoverAbilities; // 0x80
    private Coroutine _changeAvatarCoroutine; // 0x88
    private Miscs.ChangeAvatarFailType _failType; // 0x90
    private const float SKILL_TO_CHANGE_AVATAR_CD_TIME = 0.4f; // Metadata: 0x00AFF984
    private const float CHANGE_AVATER_BUFFER_TIME = 0.26f; // Metadata: 0x00AFF988
    private const uint TEST_SYNC_AVATAR_ID = 11000013; // Metadata: 0x00AFF98C
    private static Vector3 BornPos; // 0x00
    private static Action<EvtEntityReadyPost> _handleRemoteAvatarAppearEntityReadyPost; // 0x10
    private uint _sceneOwnerUid; // 0x94
    private static GameObject _cbTestToolGo; // 0x18
    private static GameObject _waterMaskGo; // 0x20
    private static MonoUIWaterMask _monoUIWaterMask; // 0x28
    private string CBTEST_TOOL_PATH; // 0x98
    private string WATER_MASK_PATH; // 0xA0
    private Dictionary<uint, uint> _openstateDic; // 0xB0
    private float _satiationCriticalValue; // 0xB8
    private float _satiationRecoverySpeed; // 0xBC
    private uint _nextRecoveryTimestampOfResin; // 0xC0
    private List<uint> _buyResinCost; // 0xC8
    private uint _dailyBoughtCountOfResin; // 0xD0
    private bool _resinParamsParsed; // 0xD4
    private uint _resinTotalLimit; // 0xD8
    private uint _autoRecoveryResinLimit; // 0xDC
    private uint _resinAutoRecoverySpeed; // 0xE0
    private uint _resinCountPerPurchase; // 0xE4
    private AntiAddictNotify _antiAddictNotify; // 0xE8

    // Properties
    public AccountDataItem accountData { /* [XID] */ /* 0x0000000189BBC5C0-0x0000000189BBC600 */ get; private set; } // 0x00000001811980A0-0x0000000181198100 0x00000001811ADA80-0x00000001811ADAE0
    public Vector3 initPos { /* [XID] */ /* 0x0000000189BCECA0-0x0000000189BCECC0 */ get => default; } // 0x00000001811A6ED0-0x00000001811A7000 
    public uint curDungeonID { /* [XID] */ /* 0x0000000189BD6000-0x0000000189BD6020 */ get => default; } // 0x00000001811BBC20-0x00000001811BBD10 
    public SceneExcelConfig curSceneConfig { /* [XID] */ /* 0x00000001899C1D80-0x00000001899C1DA0 */ get => default; /* [XID] */ /* 0x00000001895EA740-0x00000001895EA760 */ set { } } // 0x00000001811A90B0-0x00000001811A9170 0x00000001811B59B0-0x00000001811B5A60
    public float nextLoginReqTime { /* [XID] */ /* 0x00000001897C0F30-0x00000001897C0F50 */ get => default; } // 0x00000001811A6E20-0x00000001811A6ED0 
    private float loginQueuingTime { /* [XID] */ /* 0x00000001895F9650-0x00000001895F9670 */ get => default; } // 0x00000001811BE810-0x00000001811BE8F0 
    public MapField<ulong, AvatarExpeditionInfo> CurrExpeditionInfo { /* [XID] */ /* 0x0000000189600D20-0x0000000189600D40 */ get => default; } // 0x00000001811BD870-0x00000001811BD910 
    public AvatarExpeditionAllDataRsp CurrAllDataRsp { /* [XID] */ /* 0x0000000189608690-0x00000001896086B0 */ get => default; } // 0x000000018119BCF0-0x000000018119BD90 
    public uint sceneOwnerUid { /* [XID] */ /* 0x00000001899CE430-0x00000001899CE450 */ get => default; /* [XID] */ /* 0x00000001899D5BF0-0x00000001899D5C10 */ set { } } // 0x000000018119A640-0x000000018119A6E0 0x00000001811B77E0-0x00000001811B7890
    public bool isSquadLead { /* [XID] */ /* 0x00000001899EC090-0x00000001899EC0B0 */ get => default; } // 0x00000001811B43D0-0x00000001811B44D0 
    public bool canTriggerSpringAutoUse { /* [XID] */ /* 0x0000000189A02570-0x0000000189A02590 */ get => default; } // 0x00000001811AA330-0x00000001811AA6B0 
    public static GameObject cbTestToolGO { /* [XID] */ /* 0x0000000189A724C0-0x0000000189A724E0 */ get => default; } // 0x00000001811B8CE0-0x00000001811B8DB0 
    public uint SyncAvatarEntityID { /* [XID] */ /* 0x0000000189AA6BC0-0x0000000189AA6C00 */ get; /* [XID] */ /* 0x0000000189AB1600-0x0000000189AB1640 */ private set; } // 0x00000001811A7A90-0x00000001811A7AF0 0x00000001811B92D0-0x00000001811B9340
    public float satiationCriticalValue { /* [XID] */ /* 0x00000001896639C0-0x00000001896639E0 */ get => default; } // 0x0000000181191CD0-0x0000000181191E80 
    public float satiationRecoverySpeed { /* [XID] */ /* 0x000000018966B1E0-0x000000018966B200 */ get => default; } // 0x0000000181192EB0-0x0000000181193060 
    public uint nextRecoveryInMSOfResin { /* [XID] */ /* 0x0000000189672EA0-0x0000000189672EC0 */ get => default; } // 0x0000000181196C60-0x0000000181196D40 
    public ulong totalRecoveryInMSOfResin { /* [XID] */ /* 0x000000018967A510-0x000000018967A530 */ get => default; } // 0x00000001811B0920-0x00000001811B0A70 
    public List<uint> buyResinCost { /* [XID] */ /* 0x00000001896897E0-0x0000000189689800 */ get => default; } // 0x00000001811B2A90-0x00000001811B2C50 
    public uint resinDailyRemainBuyCount { /* [XID] */ /* 0x0000000189691540-0x0000000189691560 */ get => default; } // 0x00000001811A7E00-0x00000001811A7EE0 
    public uint currentBuyResinCost { /* [XID] */ /* 0x0000000189698BF0-0x0000000189698C10 */ get => default; } // 0x00000001811A4F30-0x00000001811A5030 
    public uint currentResin { /* [XID] */ /* 0x00000001896A00B0-0x00000001896A00D0 */ get => default; } // 0x000000018119F6A0-0x000000018119F790 
    public uint resinTotalLimit { /* [XID] */ /* 0x00000001896A73E0-0x00000001896A7400 */ get => default; } // 0x0000000181192740-0x00000001811927F0 
    public uint autoRecoveryResinLimit { /* [XID] */ /* 0x00000001896AE900-0x00000001896AE920 */ get => default; } // 0x00000001811AEE30-0x00000001811AEEE0 
    public uint resinAutoRecoverySpeed { /* [XID] */ /* 0x00000001896B60C0-0x00000001896B60E0 */ get => default; } // 0x00000001811A4C90-0x00000001811A4D40 
    public uint resinCountPerPurchase { /* [XID] */ /* 0x00000001896BD340-0x00000001896BD360 */ get => default; } // 0x0000000181192280-0x0000000181192330 
    public bool isRecoveryResin { /* [XID] */ /* 0x00000001896CBE10-0x00000001896CBE30 */ get => default; } // 0x00000001811B4BB0-0x00000001811B4C60 
    public bool isResinOverTotalLimit { /* [XID] */ /* 0x00000001896E24A0-0x00000001896E24C0 */ get => default; } // 0x00000001811BE750-0x00000001811BE810 
    public long coinCount { /* [XID] */ /* 0x00000001896E9940-0x00000001896E9960 */ get => default; } // 0x00000001811B2C50-0x00000001811B2D00 
    public long crystalCount { /* [XID] */ /* 0x00000001896F0B40-0x00000001896F0B60 */ get => default; } // 0x00000001811B9700-0x00000001811B97B0 
    public long mcoinCount { /* [XID] */ /* 0x00000001896F83C0-0x00000001896F83E0 */ get => default; } // 0x00000001811AED80-0x00000001811AEE30 
    public bool hasNewNameCard { /* [XID] */ /* 0x0000000189786080-0x00000001897860A0 */ get => default; } // 0x00000001811B3A50-0x00000001811B3C80 

    // Nested types
    public enum QueueType // TypeDefIndex: 21568
    {
        PlayerToken = 1,
        PlayerLogin = 2
    }

    // Constructors
    public PlayerModule() { } // 0x00000001811BEA20-0x00000001811BEC60
    static PlayerModule() { } // 0x00000001811BE8F0-0x00000001811BEA20

    // Methods
    // [XID] // 0x0000000189BB4FA0-0x0000000189BB4FC0
    protected override void RegisterModulesPkt(NotifyManager notifyMgr) { } // 0x0000000181196DA0-0x0000000181197820
                                                                            // [XID] // 0x000000018960FEB0-0x000000018960FED0
    public void Init() { } // 0x00000001811A3EE0-0x00000001811A3F80
                           // [XID] // 0x00000001896171F0-0x0000000189617210
    public override bool OnPacket(Packet packet) => default; // 0x0000000181193CE0-0x0000000181195890
                                                             // [XID] // 0x000000018961EDE0-0x000000018961EE00
    private void OnPlayerInjectFixNotify(PlayerInjectFixNotify playerInjectFixNotify) { } // 0x00000001811B7460-0x00000001811B76A0
                                                                                          // [XID] // 0x0000000189626160-0x0000000189626180
    private void OnReciveLuaShell(PlayerLuaShellNotify playerLuaShellNotify) { } // 0x00000001811B5F10-0x00000001811B6090
                                                                                 // [XID] // 0x000000018962DB90-0x000000018962DBB0
    private void HandleExpeditionAllData(AvatarExpeditionAllDataRsp allData, string typeInfo) { } // 0x000000018119A360-0x000000018119A530
                                                                                                  // [XID] // 0x0000000189635750-0x0000000189635770
    private void RefreshExpeditionData() { } // 0x000000018119FF20-0x00000001811A02D0
                                             // [XID] // 0x000000018963CE30-0x000000018963CE50
    private void HandleExpeditionSingleRsp(int retCode, MapField<ulong, AvatarExpeditionInfo> expeditionInfo, string typeInfo) { } // 0x00000001811BC0E0-0x00000001811BC520
                                                                                                                                   // [XID] // 0x00000001896443B0-0x00000001896443D0
    private void HandleAvatarExpeditionStartRsp(MapField<ulong, AvatarExpeditionInfo> expeditionInfo) { } // 0x0000000181192A90-0x0000000181192E30
                                                                                                          // [XID] // 0x000000018964BBF0-0x000000018964BC10
    private void DeallocateCurrExpeditionInfo() { } // 0x00000001811A3160-0x00000001811A33C0
                                                    // [XID] // 0x0000000189653280-0x00000001896532A0
    private void HandleExpeditionRsp(int retCode, MapField<ulong, AvatarExpeditionInfo> expeditionInfo, string typeInfo) { } // 0x00000001811A2D30-0x00000001811A3070
                                                                                                                             // [XID] // 0x000000018965AB10-0x000000018965AB30
    public double TotalExplorationTimeLeftInSecond() => default; // 0x00000001811B00E0-0x00000001811B04F0
                                                                 // [XID] // 0x0000000189661FA0-0x0000000189661FC0
    public string CheckExplorationTimeLeft(ulong avatarID) => default; // 0x00000001811B4C60-0x00000001811B4FD0
                                                                       // [IDTag] // 0x0000000189669B60-0x0000000189669BA0
                                                                       // [XID] // 0x0000000189669B60-0x0000000189669BA0
    public bool CheckExplorationReward(ulong avatarID) => default; // 0x00000001811BDD00-0x00000001811BDE20
                                                                   // [IDTag] // 0x00000001896745F0-0x0000000189674630
                                                                   // [XID] // 0x00000001896745F0-0x0000000189674630
    public bool CheckExplorationReward() => default; // 0x00000001811BDE20-0x00000001811BE090
                                                     // [XID] // 0x000000018967EB80-0x000000018967EBA0
    public bool CheckCompoundCookFinish() => default; // 0x00000001811A54E0-0x00000001811A5740
                                                      // [XID] // 0x0000000189686430-0x0000000189686450
    public void LogoutLevel() { } // 0x00000001811961E0-0x00000001811962C0
                                  // [XID] // 0x000000018968E2D0-0x000000018968E2F0
    private void OnPlayerForceExitRsp(PlayerForceExitRsp rsp) { } // 0x00000001811B76A0-0x00000001811B77E0
                                                                  // [XID] // 0x0000000189695B70-0x0000000189695B90
    private void OnLeaveSceneRsp(LeaveSceneRsp rsp) { } // 0x00000001811BAAE0-0x00000001811BAC80
                                                        // [XID] // 0x000000018969D2A0-0x000000018969D2C0
    private void OnPlayerLogoutNotify(PlayerLogoutNotify notify) { } // 0x00000001811A4D40-0x00000001811A4F30
                                                                     // [XID] // 0x00000001896A43C0-0x00000001896A43E0
    public void OnGetPlayerTokenRsp(GetPlayerTokenRsp rsp) { } // 0x00000001811B2110-0x00000001811B2A90
                                                               // [XID] // 0x00000001896ABBB0-0x00000001896ABBD0
    private void OnBundleDownloadCheckFinishNext() { } // 0x0000000181198820-0x0000000181198BA0
                                                       // [XID] // 0x00000001896B2CF0-0x00000001896B2D10
    private void OnBundleDownloadCheckFinish() { } // 0x00000001811B1D80-0x00000001811B1F10
                                                   // [XID] // 0x00000001896BA390-0x00000001896BA3B0
    private void OnPlayerLoginRsp(PlayerLoginRsp rsp) { } // 0x000000018118CEB0-0x000000018118E830
                                                          // [XID] // 0x00000001896C1620-0x00000001896C1640
    public void OnLoginRspQueuing(QueueType type) { } // 0x00000001811B67D0-0x00000001811B6D30
                                                      // [XID] // 0x00000001896C8D60-0x00000001896C8D80
    private void OnPlayerDataNotify(PlayerDataNotify notify, Packet packet) { } // 0x00000001811BAE10-0x00000001811BB780
                                                                                // [XID] // 0x00000001896D0700-0x00000001896D0720
    private void OnAvatarDataNotify(AvatarDataNotify notify) { } // 0x00000001811BCA60-0x00000001811BD2A0
                                                                 // [XID] // 0x00000001896D7C30-0x00000001896D7C50
    private void OnDoSetPlayerBornDataNotify(DoSetPlayerBornDataNotify notify) { } // 0x000000018119BD90-0x000000018119C2F0
                                                                                   // [XID] // 0x00000001896DF480-0x00000001896DF4A0
    private void OnSetPlayerBornDataRsp(SetPlayerBornDataRsp rsp) { } // 0x00000001811ACD40-0x00000001811ACF80
                                                                      // [XID] // 0x00000001896E6820-0x00000001896E6840
    public void OnPlayerEnterSceneNotify(PlayerEnterSceneNotify notify) { } // 0x00000001811A6240-0x00000001811A6660
                                                                            // [XID] // 0x00000001896EDDF0-0x00000001896EDE10
    private void OnEnterScenePeerNotify(EnterScenePeerNotify notify) { } // 0x000000018119FCC0-0x000000018119FDB0
                                                                         // [XID] // 0x00000001896F5650-0x00000001896F5670
    private void OnEnterSceneReadyRsp(EnterSceneReadyRsp rsp) { } // 0x00000001811B3C80-0x00000001811B3FD0
                                                                  // [XID] // 0x00000001896FCE30-0x00000001896FCE50
    private void OnSceneInitFinishRsp(SceneInitFinishRsp rsp) { } // 0x00000001811A0C80-0x00000001811A1090
                                                                  // [XID] // 0x00000001897042E0-0x0000000189704300
    private void OnPlayerEnterSceneInfoNotify(PlayerEnterSceneInfoNotify notify) { } // 0x00000001811B0EE0-0x00000001811B11B0
                                                                                     // [XID] // 0x000000018970BB30-0x000000018970BB50
    private void UpdateAvatarEnterSceneInfos(RepeatedMessageField<AvatarEnterSceneInfo> avatarEnterInfos) { } // 0x00000001811B0A70-0x00000001811B0EE0
                                                                                                              // [XID] // 0x00000001897133E0-0x0000000189713400
    private void OnEnterSceneDoneRsp(EnterSceneDoneRsp rsp) { } // 0x00000001811BB780-0x00000001811BBC20
                                                                // [XID] // 0x000000018971AC60-0x000000018971AC80
    private void OnPostEnterSceneRsp(PostEnterSceneRsp rsp) { } // 0x000000018118EDF0-0x000000018118F540
                                                                // [XID] // 0x0000000189721F60-0x0000000189721F80
    private void OnClientReconnectNotify(ClientReconnectNotify notify) { } // 0x00000001811B9930-0x00000001811B9D40
                                                                           // [XID] // 0x00000001897296B0-0x00000001897296D0
    public void TryClientReconnect(ClientReconnectReason reason = ClientReconnectReason.ClientReconnnectNone /* Metadata: 0x00AFF95C */) { } // 0x00000001811A5030-0x00000001811A54E0
                                                                                                                                             // [XID] // 0x0000000189730EC0-0x0000000189730EE0
    private void OnDataResVersionNotify(DataResVersionNotify notify) { } // 0x0000000181193300-0x0000000181193BA0
                                                                         // [XID] // 0x0000000189738770-0x0000000189738790
    private void OnPlayerPropNotify(PlayerPropNotify notify) { } // 0x00000001811B7ED0-0x00000001811B7FF0
                                                                 // [XID] // 0x00000001897404B0-0x00000001897404D0
    public void OnAvatarFetterDataNotify(AvatarFetterDataNotify notify) { } // 0x00000001811B6310-0x00000001811B6620
                                                                            // [XID] // 0x0000000189747850-0x0000000189747870
    public void OnAvatarFetterLevelRewardRsp(AvatarFetterLevelRewardRsp rsp) { } // 0x00000001811BA840-0x00000001811BA9C0
                                                                                 // [XID] // 0x000000018974EFD0-0x000000018974EFF0
    public void OnAvatarAddNotify(AvatarAddNotify notify, uint entityId = 0 /* Metadata: 0x00AFF960 */) { } // 0x000000018119E6B0-0x000000018119EBD0
                                                                                                            // [XID] // 0x00000001897566C0-0x00000001897566E0
    public void OnAvatarDelNotify(AvatarDelNotify notify) { } // 0x0000000181199BE0-0x0000000181199FA0
                                                              // [XID] // 0x000000018975DB30-0x000000018975DB50
    public void OnAddNoGachaAvatarCardNotify(AddNoGachaAvatarCardNotify notify) { } // 0x00000001811A3F80-0x00000001811A4100
                                                                                    // [XID] // 0x0000000189765120-0x0000000189765140
    public void OnSceneTeamUpdateNotify(SceneTeamUpdateNotify notify) { } // 0x00000001811AE7B0-0x00000001811AE8B0
                                                                          // [XID] // 0x000000018976CBE0-0x000000018976CC00
    public void CheckTeamToLoad(ulong avatarGUID) { } // 0x00000001811B5650-0x00000001811B5800
                                                      // [XID] // 0x0000000189774020-0x0000000189774040
    private void DoUpdateSceneTeam(SceneTeamUpdateNotify notify) { } // 0x00000001811AB390-0x00000001811ABF80
                                                                     // [XID] // 0x000000018977B760-0x000000018977B780
    private bool NeedReplaceLocalAvatar(uint userId, uint runtimeId) => default; // 0x0000000181195CB0-0x0000000181195E70
                                                                                 // [XID] // 0x00000001897831F0-0x0000000189783210
    private void UpdateSceneTeamAvatar(SceneTeamAvatar proto, AvatarDataItem avatarDataItem) { } // 0x0000000181198100-0x0000000181198820
                                                                                                 // [XID] // 0x000000018978A800-0x000000018978A820
    private void UpdateTeamResonance(RepeatedMessageField<SceneTeamAvatar> teamAvatars) { } // 0x00000001811A8840-0x00000001811A90B0
                                                                                            // [XID] // 0x0000000189791E60-0x0000000189791E80
    public void OnAvatarTeamUpdateNotify(AvatarTeamUpdateNotify notify) { } // 0x000000018119ABB0-0x000000018119B5A0
                                                                            // [XID] // 0x0000000189799530-0x0000000189799550
    public void OnSetUpAvatarTeamRsp(SetUpAvatarTeamRsp rsp) { } // 0x00000001811B7980-0x00000001811B7C70
                                                                 // [XID] // 0x00000001897A1420-0x00000001897A1440
    public void OnSetUpTeamNameRsp(ChangeTeamNameRsp rsp) { } // 0x000000018119A840-0x000000018119AAA0
                                                              // [XID] // 0x00000001897A8B60-0x00000001897A8B80
    public void OnFocusAvatarRsp(FocusAvatarRsp rsp) { } // 0x000000018119DCE0-0x000000018119DF50
                                                         // [XID] // 0x00000001897B0480-0x00000001897B04A0
    private void OnChooseCurAvatarTeamRsp(ChooseCurAvatarTeamRsp rsp) { } // 0x00000001811A7000-0x00000001811A71B0
                                                                          // [XID] // 0x00000001897B8260-0x00000001897B8280
    private void UpdateAvatarEntityIdMap(MapField<ulong, uint> avatarEntityIdMap) { } // 0x000000018119C2F0-0x000000018119C980
                                                                                      // [XID] // 0x00000001897C02C0-0x00000001897C02E0
    private void OnPlayerTimeNotify(PlayerTimeNotify notify, Packet packet) { } // 0x00000001811A4900-0x00000001811A4C90
                                                                                // [XID] // 0x00000001897C7AD0-0x00000001897C7AF0
    private void OnServerTimeNotify(ServerTimeNotify notify, Packet packet) { } // 0x00000001811A7EE0-0x00000001811A8020
                                                                                // [XID] // 0x00000001897CEDD0-0x00000001897CEDF0
    private void OnSceneTimeNotify(SceneTimeNotify notify, Packet packet) { } // 0x00000001811B9340-0x00000001811B9700
                                                                              // [XID] // 0x00000001897D65A0-0x00000001897D65C0
    private void OnChangeGameTimeRsp(ChangeGameTimeRsp rsp) { } // 0x00000001811AE8B0-0x00000001811AECC0
                                                                // [XID] // 0x00000001897DDDB0-0x00000001897DDDD0
    private void OnPlayerGameTimeNotify(PlayerGameTimeNotify notify) { } // 0x00000001811BBD10-0x00000001811BC0E0
                                                                         // [XID] // 0x00000001897E5840-0x00000001897E5860
    public void ChangeGameTime(float value, bool force, bool forceLocal = false /* Metadata: 0x00AFF964 */) { } // 0x00000001811B6ED0-0x00000001811B7160
                                                                                                                // [XID] // 0x00000001897ED2F0-0x00000001897ED310
    public float GetStartTimeInLevel(uint curGameTime) => default; // 0x000000018119F5A0-0x000000018119F6A0
                                                                   // [XID] // 0x00000001897F4A90-0x00000001897F4AB0
    public float GetDayTimeLength() => default; // 0x00000001811B1800-0x00000001811B18E0
                                                // [XID] // 0x00000001897FC580-0x00000001897FC5A0
    public int GetDayTimeLengthInSeconds() => default; // 0x00000001811B6D30-0x00000001811B6DE0
                                                       // [XID] // 0x0000000189803A90-0x0000000189803AB0
    private void OnChangeAvatarRsp(ChangeAvatarRsp rsp) { } // 0x00000001811A0A50-0x00000001811A0C80
                                                            // [XID] // 0x000000018980AF30-0x000000018980AF50
    public float ChangeAvatarCD() => default; // 0x00000001811A67F0-0x00000001811A6D20
                                              // [XID] // 0x00000001898125C0-0x00000001898125E0
    public bool TryToChangeAvatarByIndex(int index, bool triggerEnergySkill = false /* Metadata: 0x00AFF965 */) => default; // 0x000000018118C900-0x000000018118CB90
                                                                                                                            // [XID] // 0x000000018981A200-0x000000018981A220
    public void BufferingChangeAvatarByIndex(int index, bool triggerEnergySkill = false /* Metadata: 0x00AFF966 */) { } // 0x00000001811AB110-0x00000001811AB390
                                                                                                                        // [XID] // 0x0000000189821950-0x0000000189821970
    public bool TryToChangeAvatar(ulong guid, uint skillID = 0 /* Metadata: 0x00AFF967 */, bool showFailMessage = true /* Metadata: 0x00AFF96B */, bool isManuallyChange = false /* Metadata: 0x00AFF96C */) => default; // 0x00000001811B9D40-0x00000001811BA2C0
                                                                                                                                                                                                                         // [XID] // 0x0000000189828EE0-0x0000000189828F00
    private bool checkCanChangeAvater() => default; // 0x0000000181196BB0-0x0000000181196C60
                                                    // [XID] // 0x00000001898303F0-0x0000000189830410
    public void BufferingChangeAvatar(ulong guid, uint skillID = 0 /* Metadata: 0x00AFF96D */, bool isManuallyChange = false /* Metadata: 0x00AFF971 */) { } // 0x00000001811BA470-0x00000001811BA6F0
    [DebuggerHidden] // 0x0000000189837AB0-0x0000000189837AF0
                     // [XID] // 0x0000000189837AB0-0x0000000189837AF0
    private IEnumerator TickChangeAvatar(ulong guid, uint skillID, bool isManuallyChange = false /* Metadata: 0x00AFF972 */) => default; // 0x00000001811AAC80-0x00000001811AADA0
                                                                                                                                         // [XID] // 0x0000000189841F80-0x0000000189841FA0
    private void OnPlayerPropChangeReasonNotify(PlayerPropChangeReasonNotify ntf) { } // 0x00000001811A75F0-0x00000001811A79B0
                                                                                      // [XID] // 0x0000000189849460-0x0000000189849480
    private void OnPlayerStaminaChange(uint oldValue, uint curValue) { } // 0x00000001811A8250-0x00000001811A83C0
                                                                         // [XID] // 0x0000000189850C40-0x0000000189850C60
    private void OnPlayerExpChange(uint oldValue, uint curValue) { } // 0x00000001811B7280-0x00000001811B7460
                                                                     // [XID] // 0x0000000189858040-0x0000000189858060
    private void OnPlayerWorldLevelAdjust(uint oldValue, uint curValue) { } // 0x000000018119F790-0x000000018119F930
                                                                            // [XID] // 0x000000018985F130-0x000000018985F150
    private void OnSetPlayerNameRsp(SetPlayerNameRsp rsp) { } // 0x000000018119D210-0x000000018119D540
                                                              // [XID] // 0x0000000189866910-0x0000000189866930
    public void UpdateAvatarPropsByID(uint entityID, MapField<uint, PropValue> propMap) { } // 0x00000001811B7890-0x00000001811B7980
                                                                                            // [XID] // 0x000000018986E1F0-0x000000018986E210
    public void UpdateAvatarPropsByGUID(ulong guid, MapField<uint, long> propMap) { } // 0x000000018119B5A0-0x000000018119B6D0
                                                                                      // [XID] // 0x00000001898756E0-0x0000000189875700
    public void UpdateAvatarFightPropsByID(uint entityID, MapField<FightPropType, float> propMap, bool doClear = false /* Metadata: 0x00AFF973 */) { } // 0x00000001811A94B0-0x00000001811A95C0
                                                                                                                                                       // [XID] // 0x000000018987D210-0x000000018987D230
    private void OnAvatarFightPropUpdateNotify(AvatarFightPropUpdateNotify notify) { } // 0x0000000181193BA0-0x0000000181193CE0
                                                                                       // [XID] // 0x0000000189884150-0x0000000189884170
    private void OnAvatarFightPropNotify(AvatarFightPropNotify notify) { } // 0x00000001811BC520-0x00000001811BC760
                                                                           // [XID] // 0x000000018988B8A0-0x000000018988B8C0
    private void OnAvatarPropNotify(AvatarPropNotify ntf) { } // 0x00000001811B6DE0-0x00000001811B6ED0
                                                              // [XID] // 0x0000000189892F70-0x0000000189892F90
    private void OnAvatarDieAnimationEndRsp(AvatarDieAnimationEndRsp rsp) { } // 0x000000018118C4A0-0x000000018118C600
                                                                              // [XID] // 0x000000018989A670-0x000000018989A690
    private void OnWorldPlayerDieNotify(WorldPlayerDieNotify notify) { } // 0x0000000181199FA0-0x000000018119A0F0
                                                                         // [XID] // 0x00000001898A18E0-0x00000001898A1900
    private void OnWorldPlayerReviveRsp(WorldPlayerReviveRsp rsp) { } // 0x000000018119EBD0-0x000000018119ED30
                                                                      // [XID] // 0x00000001898A90F0-0x00000001898A9110
    private void OnAvatarSkillInfoNotify(AvatarSkillInfoNotify ntf) { } // 0x00000001811AC950-0x00000001811ACB10
                                                                        // [XID] // 0x00000001898B0A20-0x00000001898B0A40
    private void OnAvatarSkillMaxChargeCountNotify(AvatarSkillMaxChargeCountNotify ntf) { } // 0x00000001811A8610-0x00000001811A87E0
                                                                                            // [XID] // 0x00000001898B8140-0x00000001898B8160
    private void OnAvatarPropChangeReasonNotify(AvatarPropChangeReasonNotify ntf) { } // 0x00000001811A5C90-0x00000001811A5D40
                                                                                      // [XID] // 0x00000001898BF7E0-0x00000001898BF800
    public void TryToUnlockAvatarTalent(ulong guid, uint talentID) { } // 0x00000001811AF0E0-0x00000001811AF240
                                                                       // [XID] // 0x00000001898C70C0-0x00000001898C70E0
    private void OnUnlockAvatarTalentRsp(UnlockAvatarTalentRsp rsp) { } // 0x000000018119A6E0-0x000000018119A840
                                                                        // [XID] // 0x00000001898CE610-0x00000001898CE630
    private void OnChangeAvatarSkillDepotNotify(AvatarSkillDepotChangeNotify notify) { } // 0x00000001811AE0C0-0x00000001811AE3A0
                                                                                         // [XID] // 0x00000001898D6050-0x00000001898D6070
    private void OnUnlockAvatarTalentNotify(AvatarUnlockTalentNotify notify) { } // 0x00000001811B1710-0x00000001811B1800
                                                                                 // [XID] // 0x00000001898DDCA0-0x00000001898DDCC0
    private void UnlockAvatarTalentID(ulong guid, uint talentID) { } // 0x000000018119E480-0x000000018119E6B0
                                                                     // [XID] // 0x00000001898E55A0-0x00000001898E55C0
    private void UpdateAvatarTalentRPShow(ulong guid) { } // 0x00000001811AF240-0x00000001811AF390
                                                          // [XID] // 0x00000001898ECD60-0x00000001898ECD80
    private AvatarDataItem GetAvatarDataByID(uint entityId) => default; // 0x000000018119AAA0-0x000000018119ABB0
                                                                        // [XID] // 0x00000001898F46A0-0x00000001898F46C0
    public AvatarDataItem GetLocalAvatarDataItem() => default; // 0x000000018119CE10-0x000000018119CF50
                                                               // [XID] // 0x00000001898FBF30-0x00000001898FBF50
    public void PreLoadTestSyncAvatar() { } // 0x00000001811A38A0-0x00000001811A3EE0
                                            // [XID] // 0x0000000189903A30-0x0000000189903A50
    private void PreLoadTestSyncAvatarPostEntityReady(EvtEntityReadyPost evt) { } // 0x00000001811A84C0-0x00000001811A8610
                                                                                  // [XID] // 0x000000018990AE90-0x000000018990AEB0
    public void PreLoadAllAvatars(List<ulong> reloadAvatarList, bool anyncLoad = false /* Metadata: 0x00AFF974 */)
    {
        EntityManager entityManager = Singleton<EntityManager>.Instance;
        if (entityManager != null)
        {
            if (reloadAvatarList != null)
            {
                bool isSameWithAvatar = reloadAvatarList.Contains(Singleton<PlayerModule>.Instance.accountData.chooseAvatarGuid);
                entityManager.CreateHeroEntity(isSameWithAvatar);
                foreach (var avatar in reloadAvatarList)
                {
                    PreloadAvatarByGUID(avatar, anyncLoad);
                }
                var camera = entityManager.GetMainCameraEntity();
                if (camera != null)
                {
                    camera.TryRefreshHeroEntity();
                }

                Singleton<CoroutineManager>.Instance.InvokeNextFrame(() =>
                {
                    Singleton<NotifyManager>.Instance.FireNotify(Notify.CreateNotify(NotifyTypes.TeamInfoRefresh));
                });
            }
        }
    } // 0x00000001811A5740-0x00000001811A5B60
      // [XID] // 0x0000000189912B40-0x0000000189912B60
    public void PreloadAvatarByGUID(ulong guid, bool anyncLoad = false /* Metadata: 0x00AFF975 */)
    {
        var dataItem = Singleton<DataItemManager>.Instance;
        var avatar = dataItem.GetAvatarDataByGUID(guid);
        var entityManager = Singleton<EntityManager>.Instance;
        bool isCachedEntity = false;
        bool runtimeIdChange = false;
        if (avatar != null)
        {
            //if (avatar.sceneId != 0 && avatar.sceneId == curSceneID)
            //{
            //    goto localGame;
            //}
            if ((avatar.sceneId != 0 && avatar.sceneId == curSceneID) || !GameManager.Instance.isOnlineMode)
            {
                localGame:
                if (avatar.entityId != 0)
                {
                    var entity = entityManager.GetAvatarEntity(avatar.entityId);
                    if (entity != null)
                    {
                        isCachedEntity = entityManager.IsCachedEntity(entity);
                    }
                    if (entity != null && isCachedEntity)
                    {
                        readyEntity:
                        if (entity.isAuthority && !needRecoverAbilities)
                        {
                            avatar.abilitySyncInfo = null;
                        }
                        if (entity.IsEntityReady())
                        {
                            avatar.RefreshEntityOnPreEntityReady();
                            avatar.RefreshEntityOnPostEntityReady();
                        }
                        else
                        {
                            entity.onEntityReadyPreCallback += (BaseEntity readyEntity) => { avatar.RefreshEntityOnPreEntityReady(); };
                            entity.AddEventListener((EvtEntityReadyPost evt) =>
                            {
                                if (entity == null) entity = evt.en as AvatarEntity;
                                else dataItem.GetAvatarDataByGUID(entity.questID).RefreshEntityOnPostEntityReady();
                            });
                        }
                        return;
                    }
                    else
                    {
                        runtimeIdChange = true;
                        AvatarEntity cachedEntity = entityManager.GetCacheEntity(avatar.configId, avatar.entityId) as AvatarEntity;
                        if (cachedEntity != null)
                        {
                            if (avatar.entityId != entityManager.GetLocalAvatarEntityID())
                            {
                                PreloadAvatar(avatar, anyncLoad);
                                return;
                            }
                        }
                    }
                    avatar.RefreshEntityOnPreEntityReady();
                    entityManager.ReuseCachedEntity(entity, false, runtimeIdChange);
                    if (entity.runtimeID != entityManager.GetLocalAvatarEntityID())
                    {
                        entity.SetActive(false);
                        //goto readyEntity;
                        if (entity.isAuthority && !needRecoverAbilities)
                        {
                            avatar.abilitySyncInfo = null;
                        }
                        if (entity.IsEntityReady())
                        {
                            avatar.RefreshEntityOnPreEntityReady();
                            avatar.RefreshEntityOnPostEntityReady();
                        }
                        else
                        {
                            entity.onEntityReadyPreCallback += (BaseEntity readyEntity) => { avatar.RefreshEntityOnPreEntityReady(); };
                            entity.AddEventListener((EvtEntityReadyPost evt) =>
                            {
                                if (entity == null) entity = evt.en as AvatarEntity;
                                else dataItem.GetAvatarDataByGUID(entity.questID).RefreshEntityOnPostEntityReady();
                            });
                        }
                        return;
                    }
                }
            }
            if (GameManager.Instance.isOnlineMode)
            {
                BaseEntity entity = entityManager.GetEntity(avatar.entityId);
                if (entity != null)
                {
                    if (entity.gameObject)
                    {
                        entity.gameObject.SetActive(false);
                    }
                    entity.SetToBeRemoved<BaseEntity>(ref entity);
                }
                avatar.entityId = 0;
            }
        }
        else
        {
            SuperDebug.Error("PreLoadAllAvatars Team Has No Avatar:" + guid);
        }
    } // 0x0000000181191430-0x0000000181191CD0
      // [XID] // 0x000000018991A410-0x000000018991A430
    public static void OnAvatarEntityReadyPostCallBack(EvtEntityReadyPost evt) { } // 0x00000001811A8120-0x00000001811A8250
                                                                                   // [XID] // 0x0000000189921BE0-0x0000000189921C00
    private AvatarEntity PreloadAvatar(AvatarDataItem avatar, bool anyncLoad = false /* Metadata: 0x00AFF976 */) => default; // 0x000000018119DF50-0x000000018119E430
                                                                                                                             // [XID] // 0x0000000189929340-0x0000000189929360
    public static void OnPreloadAvatarEntityReadyPostCallBack(EvtEntityReadyPost evt) { } // 0x00000001811BD620-0x00000001811BD810
                                                                                          // [XID] // 0x00000001899309C0-0x00000001899309E0
    private Vector3 GetAppearPos(SceneEntityInfo entity) => default; // 0x00000001811AAA10-0x00000001811AAC80
                                                                     // [XID] // 0x0000000189937DD0-0x0000000189937DF0
    private void HandleAuthorityAvatarAppear(SceneEntityInfo entity, VisionType type, uint infoParam) { } // 0x00000001811A1370-0x00000001811A2A00
                                                                                                          // [XID] // 0x000000018993F860-0x000000018993F880
    private void HandleRemoteAvatarAppear(SceneEntityInfo entity, VisionType type, uint infoParam) { } // 0x0000000181198BA0-0x0000000181199BE0
                                                                                                       // [XID] // 0x0000000189946F40-0x0000000189946F60
    private static void HandleRemoteAvatarAppearEntityReadyPost(EvtEntityReadyPost evt) { } // 0x00000001811B7FF0-0x00000001811B8240
                                                                                            // [XID] // 0x000000018994E560-0x000000018994E580
    public override void EntityAppear(SceneEntityInfo entity, VisionType type, uint infoParam) { } // 0x00000001811BE560-0x00000001811BE750
                                                                                                   // [XID] // 0x0000000189955BE0-0x0000000189955C00
    public override void EntityDisappear(uint entityId, VisionType type) { } // 0x00000001811BE090-0x00000001811BE560
                                                                             // [XID] // 0x000000018995D6C0-0x000000018995D6E0
    private void HandleAvatarDefault(uint entityId, VisionType type) { } // 0x00000001811A5B60-0x00000001811A5C90
                                                                         // [XID] // 0x0000000189964D30-0x0000000189964D50
    private void HandleRemoteAvatarDefault(BaseEntity entity) { } // 0x00000001811A5D40-0x00000001811A5FA0
                                                                  // [XID] // 0x000000018996C2D0-0x000000018996C2F0
    private void HandleAvatarMissing(uint entityId, VisionType type) { } // 0x00000001811AFC60-0x00000001811AFD90
                                                                         // [XID] // 0x0000000189973DD0-0x0000000189973DF0
    private void HandleRemoteAvatarMissing(BaseEntity entity) { } // 0x00000001811B5BB0-0x00000001811B5F10
                                                                  // [XID] // 0x000000018997B590-0x000000018997B5B0
    private void EntityDisappearEntityReadyPost(EvtEntityReadyPost evt) { } // 0x00000001811A3070-0x00000001811A3160
                                                                            // [XID] // 0x0000000189982FB0-0x0000000189982FD0
    public void GetOnlinePlayerList() { } // 0x00000001811B44D0-0x00000001811B45B0
                                          // [XID] // 0x000000018998A760-0x000000018998A780
    public void SetSpringAutoUse(bool autoUse, uint threshold) { } // 0x00000001811A9290-0x00000001811A94B0
                                                                   // [XID] // 0x0000000189992000-0x0000000189992020
    private void OnSetPlayerPropRsp(SetPlayerPropRsp rsp) { } // 0x00000001811A7490-0x00000001811A75F0
                                                              // [XID] // 0x0000000189999D90-0x0000000189999DB0
    public void RequestSpringUse(ulong avatarGuid) { } // 0x0000000181195F80-0x0000000181196080
                                                       // [XID] // 0x00000001899A1470-0x00000001899A1490
    public void OnSpringUseRsp(SpringUseRsp rsp) { } // 0x0000000181196520-0x0000000181196680
                                                     // [XID] // 0x00000001899A8EA0-0x00000001899A8EC0
    public void RequestRefreshBackgroundAvatar() { } // 0x00000001811AC440-0x00000001811AC520
                                                     // [XID] // 0x00000001899B0830-0x00000001899B0850
    private void OnRefreshBackgroundAvatarRsp(RefreshBackgroundAvatarRsp rsp) { } // 0x000000018119CA60-0x000000018119CE10
                                                                                  // [XID] // 0x00000001899B7BD0-0x00000001899B7BF0
    private void OnBeginCameraSceneLookNotify(BeginCameraSceneLookNotify notify) { } // 0x00000001811AC520-0x00000001811AC950
                                                                                     // [XID] // 0x00000001899BF5F0-0x00000001899BF610
    private void OnEndCameraSceneLookNotify(EndCameraSceneLookNotify notify) { } // 0x00000001811B1F10-0x00000001811B2110
                                                                                 // [XID] // 0x00000001899C6F90-0x00000001899C6FB0
    public uint GetBackgroundAvatarRecoverSeconds(ulong avatarGuid) => default; // 0x00000001811AEEE0-0x00000001811AEFC0
                                                                                // [XID] // 0x00000001899DCFA0-0x00000001899DCFC0
    public bool IsSquadLead(uint uid) => default; // 0x00000001811AECC0-0x00000001811AED80
                                                  // [XID] // 0x00000001899E4B60-0x00000001899E4B80
    public bool IsOtherWorld() => default; // 0x00000001811ADAE0-0x00000001811ADC40
                                           // [XID] // 0x00000001899F3A70-0x00000001899F3A90
    public void UpgradeAvatar(ulong target, uint itemID, uint count) { } // 0x00000001811B9190-0x00000001811B92D0
                                                                         // [XID] // 0x00000001899FB350-0x00000001899FB370
    private void OnAvatarUpgradeRsp(AvatarUpgradeRsp rsp) { } // 0x0000000181192550-0x0000000181192740
                                                              // [XID] // 0x0000000189A09D00-0x0000000189A09D20
    public void NeedReloadScene() { } // 0x00000001811B07A0-0x00000001811B08C0
                                      // [XID] // 0x0000000189A11540-0x0000000189A11560
    public void ConfirmGoBackHome() { } // 0x00000001811B7160-0x00000001811B7280
                                        // [XID] // 0x000000018995E4F0-0x000000018995E510
    public void GoBackHome() { } // 0x00000001811A79B0-0x00000001811A7A90
                                 // [XID] // 0x0000000189A1FFD0-0x0000000189A1FFF0
    private void GoBackHomeAutoLogout() { } // 0x00000001811BA9C0-0x00000001811BAAE0
                                            // [XID] // 0x0000000189A27360-0x0000000189A27380
    private void GoBackHomeResponse(string response) { } // 0x0000000181197CB0-0x0000000181197E80
                                                         // [XID] // 0x0000000189A2EBA0-0x0000000189A2EBC0
    public void GoBackHomeWithoutConfirmResponse(string response) { } // 0x00000001811B47C0-0x00000001811B4960
                                                                      // [XID] // 0x000000018996D390-0x000000018996D3B0
    public void GoBackHomeInternal() { } // 0x00000001811AF390-0x00000001811AFC60
                                         // [XID] // 0x00000001899F6110-0x00000001899F6130
    public void ChangeToHomeLevel() { } // 0x000000018118E830-0x000000018118E950
                                        // [XID] // 0x0000000189A45210-0x0000000189A45230
    private void ChangeToHomeLevelResponse(string response) { } // 0x000000018119ED30-0x000000018119EED0
                                                                // [XID] // 0x0000000189A4C920-0x0000000189A4C940
    public void ChangeToHomeLevelInternal() { } // 0x0000000181190DA0-0x0000000181191330
                                                // [XID] // 0x0000000189A54150-0x0000000189A54170
    public override void InitOnLevelInit() { } // 0x00000001811B6620-0x00000001811B6770
                                               // [XID] // 0x0000000189A5BB60-0x0000000189A5BB80
    public override void ClearOnBackHome() { } // 0x00000001811A6660-0x00000001811A67F0
                                               // [XID] // 0x0000000189A632F0-0x0000000189A63310
    public override void ClearOnLevelDestroy() { } // 0x0000000181196680-0x00000001811967D0
                                                   // [XID] // 0x0000000189A6AE10-0x0000000189A6AE30
    public override void ClearOnDisconnect() { } // 0x00000001811BA3D0-0x00000001811BA470
                                                 // [XID] // 0x0000000189A7A0D0-0x0000000189A7A0F0
    public void InitCBTest() { } // 0x0000000181193060-0x0000000181193300
                                 // [XID] // 0x0000000189A81570-0x0000000189A81590
    public void InitWaterMaskPerfab() { } // 0x000000018119CF50-0x000000018119D210
                                          // [XID] // 0x00000001896DD210-0x00000001896DD230
    public void InitWaterMask() { } // 0x000000018118CB90-0x000000018118CEB0
                                    // [XID] // 0x0000000189A907D0-0x0000000189A907F0
    public void CreateFakeAvatarItem()
    {
        TimeUtil.ClearServerTimeSpan();
        Singleton<LevelTimeManager>.Instance.SetInternalTimeOfDay(GetStartTimeInLevel(720));
        accountData.lastChangeAvatarTime = TimeUtil.PlayerChangeTime;
        Singleton<LuaManager>.Instance.OnLevelLoad(curSceneID);
        TeamManager team = Singleton<TeamManager>.Instance;
        DataItemManager dataItem = Singleton<DataItemManager>.Instance;
        team.curTeamId = 1;
        var lastTeamList = Singleton<MiHoYoGameData>.Instance.LocalData.lastTeamList;
        for (int i = 0; i < lastTeamList.Count; i++)
        {
            var data = AvatarExcelConfigLoader.dataDict;
            if (!data.ContainsKey((uint)lastTeamList[i])) lastTeamList.RemoveAt(i);
        }
        foreach (var data in AvatarExcelConfigLoader.dataDict)
        {
            if (data.Value.useType == AvatarUseType.AVATAR_FORMAL)
            {
                if (!lastTeamList.Contains(data.Key))
                {
                    lastTeamList.Add(data.Key);
                }
            }
        }
        for (int j = 0; j < lastTeamList.Count; j++)
        {
            if (j < 4)
            {
                team.AddTeamMember(1, lastTeamList[j]);
            }
        }
        if (!lastTeamList.Contains(TEST_SYNC_AVATAR_ID))
        {
            lastTeamList.Add(TEST_SYNC_AVATAR_ID);
        }

        foreach (var guid in lastTeamList)
        {
            if (guid != TEST_SYNC_AVATAR_ID)
            {

                AvatarDataItem avatarData = dataItem.CreateDataItemByGUID<AvatarDataItem>(guid);
                avatarData.entityId = Singleton<RuntimeIDManager>.Instance.GetNextRuntimeID(RuntimeIDManager.AVATAR_CATE);
                avatarData.configId = (uint)guid;
                avatarData.uid = accountData.userId;
                avatarData.avatarType = AvatarType.Formal;
                Singleton<MultiplayerModule>.Instance.AddGUIDPeerIdMap(avatarData.guid, InLevelData.peerId);
                team.AddAvatar(avatarData.guid);
            }
        }
        foreach (var avatarGuid in team.allAvatars)
        {
            AvatarDataItem avatarData = dataItem.GetAvatarDataByGUID(avatarGuid);
            AvatarExcelConfig data = AvatarExcelConfigLoader.GetData(avatarData.configId);
            if (data != null)
            {
                avatarData.skillDepotId = data.skillDepotId;
                avatarData.entityId = data.skillDepotId;
                EntityPropNotify entityPropNotify = MessageHelper.Allocate<EntityPropNotify>();
                PropValue propValue = MessageHelper.Allocate<PropValue>();
                propValue.Type = (uint)PropType.PROP_LEVEL;
                propValue.Ival = 1;
                entityPropNotify.EntityId = avatarData.entityId;
                entityPropNotify.PropMap.Add(propValue.Type, propValue);
                UpdateAvatarPropsByID(avatarData.entityId, entityPropNotify.PropMap);

                EntityFightPropUpdateNotify entityFightPropUpdateNotify = MessageHelper.Allocate<EntityFightPropUpdateNotify>();
                entityFightPropUpdateNotify.EntityId = avatarData.entityId;

                PropValue propValue2 = MessageHelper.Allocate<PropValue>();
                propValue2.Type = (uint)FightPropType.FIGHT_PROP_MAX_HP;
                propValue2.Ival = Miscs.ProtoFloat2Int(data.hp_base, FightPropType.FIGHT_PROP_MAX_HP);
                entityFightPropUpdateNotify.FightPropMap.Add((FightPropType)propValue2.Type, data.hp_base);

                PropValue propValue3 = MessageHelper.Allocate<PropValue>();
                propValue3.Type = (uint)FightPropType.FIGHT_PROP_CUR_HP;
                propValue3.Ival = Miscs.ProtoFloat2Int(data.hp_base, FightPropType.FIGHT_PROP_CUR_HP);
                entityFightPropUpdateNotify.FightPropMap.Add((FightPropType)propValue3.Type, data.hp_base);

                var avatarSkillDepotExcelConfigLoader = AvatarSkillDepotExcelConfigLoader.GetData(data.skillDepotId);
                var avatarSkillExcelConfigLoader = AvatarSkillExcelConfigLoader.GetData(avatarSkillDepotExcelConfigLoader.energySkill);
                if (avatarSkillExcelConfigLoader != null)
                {
                    PropValue propValue4 = MessageHelper.Allocate<PropValue>();
                    propValue4.Type = (uint)Miscs.ElemTypeToProtoMax(avatarSkillExcelConfigLoader.costElemType);
                    propValue4.Ival = Miscs.ProtoFloat2Int(avatarSkillExcelConfigLoader.costElemVal, (PropType)propValue4.Type);
                    entityFightPropUpdateNotify.FightPropMap.Add((FightPropType)propValue4.Type, avatarSkillExcelConfigLoader.costElemVal);

                    PropValue propValue5 = MessageHelper.Allocate<PropValue>();
                    propValue5.Type = (uint)Miscs.ElemTypeToProto(avatarSkillExcelConfigLoader.costElemType);
                    propValue5.Ival = Miscs.ProtoFloat2Int(avatarSkillExcelConfigLoader.costElemVal, (PropType)propValue5.Type);
                    entityFightPropUpdateNotify.FightPropMap.Add((FightPropType)propValue5.Type, avatarSkillExcelConfigLoader.costElemVal);
                }

                PropValue propValue6 = MessageHelper.Allocate<PropValue>();
                propValue6.Type = (uint)FightPropType.FIGHT_PROP_BASE_ATTACK;
                propValue6.Ival = Miscs.ProtoFloat2Int(data.attack_base, FightPropType.FIGHT_PROP_BASE_ATTACK);
                entityFightPropUpdateNotify.FightPropMap.Add((FightPropType)propValue6.Type, data.attack_base);

                PropValue propValue7 = MessageHelper.Allocate<PropValue>();
                propValue7.Type = (uint)FightPropType.FIGHT_PROP_CUR_ATTACK;
                propValue7.Ival = Miscs.ProtoFloat2Int(data.attack_base, FightPropType.FIGHT_PROP_CUR_ATTACK);
                entityFightPropUpdateNotify.FightPropMap.Add((FightPropType)propValue7.Type, data.attack_base);

                PropValue propValue8 = MessageHelper.Allocate<PropValue>();
                propValue8.Type = (uint)FightPropType.FIGHT_PROP_BASE_DEFENSE;
                propValue8.Ival = Miscs.ProtoFloat2Int(data.defense_base, FightPropType.FIGHT_PROP_BASE_DEFENSE);
                entityFightPropUpdateNotify.FightPropMap.Add((FightPropType)propValue8.Type, data.defense_base);

                PropValue propValue9 = MessageHelper.Allocate<PropValue>();
                propValue9.Type = (uint)FightPropType.FIGHT_PROP_CUR_DEFENSE;
                propValue9.Ival = Miscs.ProtoFloat2Int(data.defense_base, FightPropType.FIGHT_PROP_CUR_DEFENSE);
                entityFightPropUpdateNotify.FightPropMap.Add((FightPropType)propValue9.Type, data.defense_base);

                UpdateAvatarFightPropsByID(avatarData.entityId, entityFightPropUpdateNotify.FightPropMap);
                MapField<uint, uint> combatSkillMap = new MapField<uint, uint>();
                if (avatarSkillDepotExcelConfigLoader.energySkill != 0)
                {
                    combatSkillMap.Add(avatarSkillDepotExcelConfigLoader.energySkill, 1);
                }
                foreach (var skill in avatarSkillDepotExcelConfigLoader.skills)
                {
                    if (skill != 0)
                    {
                        combatSkillMap.Add(skill, 1);
                    }
                }
                avatarData.UpdateProudSkillList(combatSkillMap, null, avatarData.skillDepotId, 1, null);
            }
            PreLoadAllAvatars(team.curTeamList);
        }
    } // 0x000000018118F540-0x00000001811909C0
      // [XID] // 0x0000000189A97FF0-0x0000000189A98010
    public void AvatarFakeIsDead(uint entityId) { } // 0x00000001811A47E0-0x00000001811A48B0
                                                    // [XID] // 0x0000000189A9F3D0-0x0000000189A9F3F0
    public void ChangeAvatarLocal(uint entityId, uint skillID = 0 /* Metadata: 0x00AFF977 */, bool playShowUp = false /* Metadata: 0x00AFF97B */) { } // 0x00000001811AE420-0x00000001811AE6B0
                                                                                                                                                      // [XID] // 0x0000000189ABC1E0-0x0000000189ABC200
    public void TrySetOpenState(OpenStateType type, bool active) { } // 0x00000001811BA6F0-0x00000001811BA840
                                                                     // [XID] // 0x0000000189AC3AC0-0x0000000189AC3AE0
    private void OnSetOpenStateRsp(SetOpenStateRsp rsp) { } // 0x0000000181197820-0x00000001811979A0
                                                            // [XID] // 0x0000000189ACAFA0-0x0000000189ACAFC0
    private void UpdateOpenState(uint type, bool active) { } // 0x00000001811AFD90-0x00000001811B00E0
                                                             // [XID] // 0x0000000189AD2A80-0x0000000189AD2AA0
    private void OnOpenStateUpdateNotify(OpenStateUpdateNotify ntf) { } // 0x00000001811A1090-0x00000001811A1370
                                                                        // [XID] // 0x0000000189ADA440-0x0000000189ADA460
    private void OnOpenStateChangeNotify(OpenStateChangeNotify ntf) { } // 0x000000018119D830-0x000000018119DAA0
                                                                        // [XID] // 0x0000000189AE1D50-0x0000000189AE1D70
    public void ShowPopOpenStateSystem() { } // 0x00000001811979A0-0x0000000181197B80
                                             // [XID] // 0x0000000189AE95F0-0x0000000189AE9610
    private void OnDungeonFollowNotify(DungeonFollowNotify ntf) { } // 0x000000018119B9E0-0x000000018119BA90
                                                                    // [XID] // 0x0000000189AF1390-0x0000000189AF13B0
    private void OnWorldPlayerRTTNotify(WorldPlayerRTTNotify ntf) { } // 0x00000001811B3100-0x00000001811B3390
                                                                      // [XID] // 0x0000000189AF8970-0x0000000189AF8990
    private void OnCookDataNotify(CookDataNotify ntf) { } // 0x00000001811B11B0-0x00000001811B1490
                                                          // [XID] // 0x0000000189AFFED0-0x0000000189AFFEF0
    private void OnCookRecipeDataNotify(CookRecipeDataNotify ntf) { } // 0x00000001811BD400-0x00000001811BD5C0
                                                                      // [XID] // 0x0000000189B07470-0x0000000189B07490
    private void OnCookGradeDataNotify(CookGradeDataNotify ntf) { } // 0x00000001811AD870-0x00000001811AD980
                                                                    // [XID] // 0x0000000189B0EC30-0x0000000189B0EC50
    public void RequestPlayerCook(uint recipeId, uint avatarId, uint qteQuality, uint count = 1 /* Metadata: 0x00AFF97C */) { } // 0x00000001811A02D0-0x00000001811A0430
                                                                                                                                // [XID] // 0x0000000189B15FF0-0x0000000189B16010
    private void OnPlayerCookRsp(PlayerCookRsp rsp) { } // 0x000000018118E950-0x000000018118EC00
                                                        // [XID] // 0x0000000189B1D670-0x0000000189B1D690
    private void UpdateCookRecipeDic(CookRecipeData cookRecipeData) { } // 0x00000001811ACF80-0x00000001811AD180
                                                                        // [XID] // 0x0000000189B25060-0x0000000189B25080
    public void RequestPlayerCookArgs(uint recipeId, uint avatarId) { } // 0x00000001811A9170-0x00000001811A9290
                                                                        // [XID] // 0x0000000189B2C4F0-0x0000000189B2C510
    private void OnPlayerCookArgsRsp(PlayerCookArgsRsp rsp) { } // 0x00000001811967D0-0x00000001811969E0
                                                                // [XID] // 0x0000000189B33A20-0x0000000189B33A40
    private void OnCompoundDataNotify(CompoundDataNotify ntf) { } // 0x00000001811B3010-0x00000001811B3100
                                                                  // [XID] // 0x0000000189B3B330-0x0000000189B3B350
    public void RequestGetCompoundData() { } // 0x00000001811B5570-0x00000001811B5650
                                             // [XID] // 0x0000000189B42B70-0x0000000189B42B90
    private void OnGetCompoundDataRsp(GetCompoundDataRsp rsp) { } // 0x00000001811AC080-0x00000001811AC290
                                                                  // [XID] // 0x0000000189B4A5D0-0x0000000189B4A5F0
    public void RequestPlayerCompoundMaterial(uint compoundId, uint count) { } // 0x00000001811AEFC0-0x00000001811AF0E0
                                                                               // [XID] // 0x0000000189B51D60-0x0000000189B51D80
    private void OnPlayerCompoundMaterialRsp(PlayerCompoundMaterialRsp rsp) { } // 0x00000001811B8240-0x00000001811B85D0
                                                                                // [XID] // 0x0000000189B59580-0x0000000189B595A0
    private void UpdateCompoundData(RepeatedField<uint> unlockCompoundList, RepeatedMessageField<CompoundQueueData> compoundQueDataList) { } // 0x00000001811B85D0-0x00000001811B8910
                                                                                                                                             // [XID] // 0x0000000189B60DF0-0x0000000189B60E10
    public void RequestTakeCompoundOutput(uint compoundId) { } // 0x00000001811AA6B0-0x00000001811AA7B0
                                                               // [XID] // 0x0000000189B68550-0x0000000189B68570
    private void OnTakeCompoundOutputRsp(TakeCompoundOutputRsp rsp) { } // 0x00000001811AA030-0x00000001811AA330
                                                                        // [XID] // 0x0000000189B6F8E0-0x0000000189B6F900
    public void RequestPlayerSetLanguage(uint lanType) { } // 0x00000001811A98D0-0x00000001811A99D0
                                                           // [XID] // 0x0000000189B76ED0-0x0000000189B76EF0
    private void OnPlayerSetLanguageRsp(PlayerSetLanguageRsp rsp) { } // 0x00000001811BD2A0-0x00000001811BD400
                                                                      // [XID] // 0x0000000189B7E420-0x0000000189B7E440
    public void RequestProudSkillUpgrade(ulong avatarGuid, uint proudSkillId) { } // 0x000000018119B6D0-0x000000018119B800
                                                                                  // [XID] // 0x0000000189B86030-0x0000000189B86050
    public void RequestAvatarSkillUpgrade(ulong avatarGuid, uint skillId, uint currLevel) { } // 0x000000018118C180-0x000000018118C2C0
                                                                                              // [XID] // 0x0000000189B8D0F0-0x0000000189B8D110
    private void OnProudSkillUpgradeRsp(ProudSkillUpgradeRsp rsp) { } // 0x00000001811A9E20-0x00000001811AA030
                                                                      // [XID] // 0x0000000189B948B0-0x0000000189B948D0
    private void OnAvatarSkillUpgradeRsp(AvatarSkillUpgradeRsp rsp) { } // 0x00000001811B7C70-0x00000001811B7ED0
                                                                        // [XID] // 0x0000000189B9BF80-0x0000000189B9BFA0
    private void OnProudSkillChangeNotify(ProudSkillChangeNotify ntf) { } // 0x0000000181197EE0-0x00000001811980A0
                                                                          // [XID] // 0x0000000189BA3690-0x0000000189BA36B0
    private void OnAvatarSkillChangeNotify(AvatarSkillChangeNotify ntf) { } // 0x000000018118EC00-0x000000018118EDF0
                                                                            // [XID] // 0x0000000189BAAA60-0x0000000189BAAA80
    private void OnProudSkillExtraLevelNotify(ProudSkillExtraLevelNotify ntf) { } // 0x000000018119EED0-0x000000018119F0C0
                                                                                  // [XID] // 0x0000000189BB1FD0-0x0000000189BB1FF0
    private void OnAvatarEquipAffixStartNotify(AvatarEquipAffixStartNotify ntf) { } // 0x00000001811A2A00-0x00000001811A2D30
                                                                                    // [XID] // 0x0000000189BB93C0-0x0000000189BB93E0
    private void OnTeamResonanceChangeNotify(TeamResonanceChangeNotify ntf) { } // 0x00000001811AC290-0x00000001811AC440
                                                                                // [XID] // 0x0000000189BC11C0-0x0000000189BC11E0
    public bool CheckTeamResonanceAdded(uint resonanceId) => default; // 0x00000001811B4960-0x00000001811B4BB0
                                                                      // [XID] // 0x0000000189BC8A20-0x0000000189BC8A40
    public bool IsNewCombine(uint combineID) => default; // 0x0000000181192170-0x0000000181192280
                                                         // [XID] // 0x0000000189BD0170-0x0000000189BD0190
    public bool IsNewForge(uint forgeID) => default; // 0x00000001811BA2C0-0x00000001811BA3D0
                                                     // [XID] // 0x0000000189BD7810-0x0000000189BD7830
    public void RemoveNewCombine(uint combineID) { } // 0x00000001811BAC80-0x00000001811BAE10
                                                     // [XID] // 0x0000000189BDF380-0x0000000189BDF3A0
    public void RemoveNewForge(uint forgeID) { } // 0x00000001811B8B50-0x00000001811B8CE0
                                                 // [XID] // 0x00000001895EBF30-0x00000001895EBF50
    private void SaveNewMarkData() { } // 0x00000001811B4FD0-0x00000001811B5420
                                       // [XID] // 0x00000001895F3310-0x00000001895F3330
    private void OnMarkNewNotify(MarkNewNotify ntf) { } // 0x00000001811A33C0-0x00000001811A38A0
                                                        // [XID] // 0x00000001895FAC10-0x00000001895FAC30
    public bool isUnlockForge(uint forgeId) => default; // 0x0000000181195E70-0x0000000181195F80
                                                        // [XID] // 0x0000000189602560-0x0000000189602580
    public bool isUnlockCombine(uint combineId) => default; // 0x000000018119A530-0x000000018119A640
                                                            // [XID] // 0x0000000189609DD0-0x0000000189609DF0
    public void SetAllUnlockForgeId(RepeatedField<uint> allData) { } // 0x00000001811B97B0-0x00000001811B9930
                                                                     // [XID] // 0x0000000189611600-0x0000000189611620
    public void SetAllUnlockCombineId(RepeatedField<uint> allData) { } // 0x00000001811A4100-0x00000001811A4280
                                                                       // [XID] // 0x0000000189618F00-0x0000000189618F20
    public void UnlockForgeChanged(uint id, bool isLocked) { } // 0x00000001811909C0-0x0000000181190DA0
                                                               // [XID] // 0x0000000189620440-0x0000000189620460
    public void UnlockCombineChanged(uint id, bool isLocked) { } // 0x00000001811B2D00-0x00000001811B3010
                                                                 // [XID] // 0x00000001896278F0-0x0000000189627910
    private void OnPlayerLevelRewardUpdateNotify(PlayerLevelRewardUpdateNotify ntf) { } // 0x00000001811B89B0-0x00000001811B8B50
                                                                                        // [XID] // 0x000000018962F2F0-0x000000018962F310
    public void RequestTakePlayerLevelReward(uint playerLevel) { } // 0x0000000181191330-0x0000000181191430
                                                                   // [XID] // 0x0000000189636D60-0x0000000189636D80
    private void OnTakePlayerLevelRewardRsp(TakePlayerLevelRewardRsp rsp) { } // 0x00000001811962C0-0x0000000181196520
                                                                              // [XID] // 0x000000018963E2C0-0x000000018963E2E0
    private void OnAvatarPromoteGetRewardRsp(AvatarPromoteGetRewardRsp rsp) { } // 0x00000001811A4280-0x00000001811A47E0
                                                                                // [XID] // 0x0000000189645BA0-0x0000000189645BC0
    private void OnGmTalkRsp(GmTalkRsp rsp) { } // 0x00000001811B1490-0x00000001811B1710
                                                // [XID] // 0x000000018964D400-0x000000018964D420
    private void OnPlayerSetPauseRsp(PlayerSetPauseRsp rsp) { } // 0x00000001811B5800-0x00000001811B5960
                                                                // [XID] // 0x0000000189654C40-0x0000000189654C60
    private void OnSceneAvatarStaminaStepRsp(SceneAvatarStaminaStepRsp rsp) { } // 0x0000000181196080-0x00000001811961E0
                                                                                // [XID] // 0x000000018965C1D0-0x000000018965C1F0
    public void OnAvatarSatiationDataNotify(AvatarSatiationDataNotify notify) { } // 0x000000018119D540-0x000000018119D830
                                                                                  // [XID] // 0x0000000189681D70-0x0000000189681D90
    private void OnResinChangeNotify(ResinChangeNotify ntf) { } // 0x000000018119FDB0-0x000000018119FF20
                                                                // [XID] // 0x00000001896C4840-0x00000001896C4860
    private void TryParseResinParam() { } // 0x0000000181195890-0x0000000181195CB0
                                          // [XID] // 0x00000001896D3160-0x00000001896D3180
    public void RequestBuyResin() { } // 0x000000018119C980-0x000000018119CA60
                                      // [XID] // 0x00000001896DAD40-0x00000001896DAD60
    private void OnBuyResinRsp(BuyResinRsp rsp) { } // 0x00000001811B3830-0x00000001811B3A50
                                                    // [XID] // 0x00000001896FFD40-0x00000001896FFD60
    public void GetPlayerFriendList() { } // 0x000000018119B800-0x000000018119B8E0
                                          // [XID] // 0x0000000189707440-0x0000000189707460
    private void OnGetPlayerFriendListRsp(GetPlayerFriendListRsp rsp) { } // 0x000000018119FAE0-0x000000018119FCC0
                                                                          // [XID] // 0x000000018970ECE0-0x000000018970ED00
    public void GetPlayerBlacklist() { } // 0x00000001811B3750-0x00000001811B3830
                                         // [XID] // 0x00000001897160E0-0x0000000189716100
    private void OnGetPlayerBlacklistRsp(GetPlayerBlacklistRsp rsp) { } // 0x00000001811A7C50-0x00000001811A7E00
                                                                        // [XID] // 0x000000018971DB20-0x000000018971DB40
    private void OnUpdatePS4BlockListRsp(UpdatePS4BlockListRsp rsp) { } // 0x00000001811A7AF0-0x00000001811A7C50
                                                                        // [XID] // 0x0000000189724FA0-0x0000000189724FC0
    public void GetPlayerSocialDetail(uint uid) { } // 0x00000001811B6090-0x00000001811B6190
                                                    // [XID] // 0x000000018972C6E0-0x000000018972C700
    private void OnGetPlayerSocialDetailRsp(GetPlayerSocialDetailRsp rsp) { } // 0x00000001811AD180-0x00000001811AD870
                                                                              // [XID] // 0x0000000189733E30-0x0000000189733E50
    private void OnAskAddFriendRsp(AskAddFriendRsp rsp) { } // 0x00000001811ADC40-0x00000001811ADE70
                                                            // [XID] // 0x000000018973B590-0x000000018973B5B0
    private void OnDealAddFriendRsp(DealAddFriendRsp rsp) { } // 0x00000001811BD910-0x00000001811BDD00
                                                              // [XID] // 0x0000000189743040-0x0000000189743060
    private void OnDeleteFriendRsp(DeleteFriendRsp rsp) { } // 0x000000018118C600-0x000000018118C900
                                                            // [XID] // 0x000000018974ABC0-0x000000018974ABE0
    private void OnSetPlayerHeadImageRsp(SetPlayerHeadImageRsp rsp) { } // 0x000000018119DAA0-0x000000018119DCE0
                                                                        // [XID] // 0x0000000189751C30-0x0000000189751C50
    private void OnSetPlayerSignatureRsp(SetPlayerSignatureRsp rsp) { } // 0x00000001811B04F0-0x00000001811B07A0
                                                                        // [XID] // 0x0000000189759360-0x0000000189759380
    private void OnSetPlayerBirthdayRsp(SetPlayerBirthdayRsp rsp) { } // 0x00000001811927F0-0x0000000181192A90
                                                                      // [XID] // 0x0000000189760ED0-0x0000000189760EF0
    private void OnAddFriendNotify(AddFriendNotify notify) { } // 0x00000001811ACB10-0x00000001811ACD40
                                                               // [XID] // 0x0000000189768260-0x0000000189768280
    private void OnDeleteFriendNotify(DeleteFriendNotify notify) { } // 0x00000001811A7250-0x00000001811A7490
                                                                     // [XID] // 0x000000018976F830-0x000000018976F850
    private void OnAskAddFriendNotify(AskAddFriendNotify notify) { } // 0x00000001811B8DB0-0x00000001811B9190
                                                                     // [XID] // 0x0000000189777190-0x00000001897771B0
    private void OnSetNameCardRsp(SetNameCardRsp rsp) { } // 0x00000001811A5FA0-0x00000001811A61E0
                                                          // [XID] // 0x000000018977E8C0-0x000000018977E8E0
    private void OnGetAllUnlockNameCardRsp(GetAllUnlockNameCardRsp rsp) { } // 0x0000000181192330-0x0000000181192550
                                                                            // [XID] // 0x000000018978D730-0x000000018978D750
    private void OnUnlockNameCardNotify(UnlockNameCardNotify ntf) { } // 0x00000001811A0900-0x00000001811A0A50
                                                                      // [XID] // 0x0000000189794BC0-0x0000000189794BE0
    public void RequestAddInBlacklist(uint uid) { } // 0x00000001811ABF80-0x00000001811AC080
                                                    // [XID] // 0x000000018979D0F0-0x000000018979D110
    public void RequestRemoveFromBlacklist(uint uid) { } // 0x00000001811AE6B0-0x00000001811AE7B0
                                                         // [XID] // 0x00000001897A43F0-0x00000001897A4410
    private void OnAddBlacklistRsp(AddBlacklistRsp rsp) { } // 0x000000018119F1B0-0x000000018119F5A0
                                                            // [XID] // 0x00000001897AB960-0x00000001897AB980
    private void OnRemoveBlacklistRsp(RemoveBlacklistRsp rsp) { } // 0x00000001811B3FD0-0x00000001811B43D0
                                                                  // [XID] // 0x00000001897B38C0-0x00000001897B38E0
    private void OnGetRecentMpPlayerListRsp(GetRecentMpPlayerListRsp rsp) { } // 0x000000018119F930-0x000000018119FAE0
                                                                              // [XID] // 0x00000001897BB6B0-0x00000001897BB6D0
    public void RequestAddFriend(uint uid) { } // 0x00000001811AD980-0x00000001811ADA80
                                               // [XID] // 0x00000001897C2ED0-0x00000001897C2EF0
    public void RequestDeleteFriend(uint uid) { } // 0x000000018119B8E0-0x000000018119B9E0
                                                  // [XID] // 0x00000001897CA7D0-0x00000001897CA7F0
    public void OnSetFriendRemarkNameRsp(SetFriendRemarkNameRsp rsp) { } // 0x00000001811AAEC0-0x00000001811AB110
                                                                         // [XID] // 0x00000001897D1CF0-0x00000001897D1D10
    public void OnUpdatePlayerShowAvatarListRsp(UpdatePlayerShowAvatarListRsp rsp) { } // 0x00000001811A99D0-0x00000001811A9E20
                                                                                       // [XID] // 0x00000001897D9B90-0x00000001897D9BB0
    public void OnGetFriendShowAvatarInfoRsp(GetFriendShowAvatarInfoRsp rsp) { } // 0x00000001811A0430-0x00000001811A0860
                                                                                 // [XID] // 0x00000001897E0EC0-0x00000001897E0EE0
    private void OnUpdatePlayerShowNameCardListRsp(UpdatePlayerShowNameCardListRsp rsp) { } // 0x000000018119BA90-0x000000018119BCF0
                                                                                            // [XID] // 0x00000001897E8590-0x00000001897E85B0
    private AvatarDataItem CreateOtherPlayerFakeAvatarDataItem(uint avatarId) => default; // 0x00000001811B6190-0x00000001811B6310
                                                                                          // [XID] // 0x00000001897F02A0-0x00000001897F02C0
    public void RequestFriendShowAvatarInfo(uint uid) { } // 0x00000001811A8020-0x00000001811A8120
                                                          // [XID] // 0x00000001897F79F0-0x00000001897F7A10
    public void RequestUpdatePlayerShowAvatarList(bool isShowAvatar, List<uint> avatarList) { } // 0x000000018119A0F0-0x000000018119A360
                                                                                                // [XID] // 0x00000001897FF070-0x00000001897FF090
    public void RequestUpdatePlayerShowNameCardList(List<uint> nameCardList) { } // 0x00000001811B5420-0x00000001811B5570
                                                                                 // [XID] // 0x00000001898067F0-0x0000000189806810
    public void OnAntiAddictNotify(AntiAddictNotify notify) { } // 0x00000001811969E0-0x0000000181196BB0
                                                                // [XID] // 0x000000018980DFB0-0x000000018980DFD0
    private void OnBindResponse(string response) { } // 0x00000001811B45B0-0x00000001811B47C0
                                                     // [XID] // 0x0000000189815650-0x0000000189815670
    public void RequestAvatarWearFlycloak(ulong avatarGuid, uint flycloakId) { } // 0x0000000181197B80-0x0000000181197CB0
                                                                                 // [XID] // 0x000000018981D0A0-0x000000018981D0C0
    private void OnAvatarWearFlycloakRsp(AvatarWearFlycloakRsp rsp) { } // 0x000000018118C340-0x000000018118C4A0
                                                                        // [XID] // 0x00000001898244C0-0x00000001898244E0
    private void OnAvatarFlycloakChangeNotify(AvatarFlycloakChangeNotify notify) { } // 0x00000001811ADE70-0x00000001811AE0C0
                                                                                     // [XID] // 0x000000018982BF90-0x000000018982BFB0
    private void OnAvatarGainFlycloakNotify(AvatarGainFlycloakNotify notify) { } // 0x0000000181191E80-0x0000000181192170
                                                                                 // [XID] // 0x00000001898334A0-0x00000001898334C0
    private void OnWindSeedClientNotify(WindSeedClientNotify notify) { } // 0x00000001811B3390-0x00000001811B3750
                                                                         // [XID] // 0x000000018983A9A0-0x000000018983A9C0
    public void SendClientLockGameTimeNotify(bool isLock) { } // 0x00000001811A6D20-0x00000001811A6E20
                                                              // [XID] // 0x0000000189841F60-0x0000000189841F80
    private void OnTakeFirstShareRewardRsp(TakeFirstShareRewardRsp rsp) { } // 0x00000001811BC760-0x00000001811BCA60
                                                                            // [XID] // 0x0000000189849440-0x0000000189849460
    private void OnPlayerReportRsp(PlayerReportRsp playerReportRsp) { } // 0x00000001811AA7B0-0x00000001811AAA10
                                                                        // [XID] // 0x0000000189850C20-0x0000000189850C40
    private void OnGetSceneAudioNotify(SceneAudioNotify sceneAudioNotify) { } // 0x00000001811B18E0-0x00000001811B1D80
                                                                              // [XID] // 0x0000000189858020-0x0000000189858040
    public void RequestGetNextResourceInfo() { } // 0x00000001811AADA0-0x00000001811AAEC0
                                                 // [XID] // 0x000000018985F110-0x000000018985F130
    private void OnGetNextResourceInfoRsp(GetNextResourceInfoRsp rsp) { } // 0x00000001811A95C0-0x00000001811A98D0
    private void __iFixBaseProxy_RegisterModulesPkt(NotifyManager P0) { } // 0x00000001811AE3A0-0x00000001811AE420
    private bool __iFixBaseProxy_OnPacket(Packet P0) => default; // 0x0000000181192E30-0x0000000181192EB0
    private void __iFixBaseProxy_EntityAppear(SceneEntityInfo P0, VisionType P1, uint P2) { } // 0x00000001811A8420-0x00000001811A84C0
    private void __iFixBaseProxy_EntityDisappear(uint P0, VisionType P1) { } // 0x000000018118C2C0-0x000000018118C340
    private void __iFixBaseProxy_InitOnLevelInit() { } // 0x00000001811BD5C0-0x00000001811BD620
    private void __iFixBaseProxy_ClearOnBackHome() { } // 0x00000001811B08C0-0x00000001811B0920
}

