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
using MoleMole.Config;
using UnityEngine;
using UnityEngine.Scripting;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500
/// <summary>
/// 已完成-加载管理器
/// 主要负责场景的加载切换
/// 天理选名字场景也主要是在这里初始化
/// </summary>
public sealed class LoadingManager : GlobalManager // TypeDefIndex: 21029
{
    // Fields
    private Dictionary<uint, LoadingTask> _loadingTasks = new Dictionary<uint, LoadingTask>(); // 0x10
    private LoadingTask _curLoadingTask; // 0x18
    private LoadingTask _lastLoadingTask; // 0x20
    private BornTask _bornTask; // 0x28
    private Coroutine _bornCoroutine; // 0x30
    private Action<ILuaActor> _transPreCallback; // 0x38
    private Action<ILuaActor> _transFinishCallback; // 0x40
    private ILuaActor _curActor; // 0x48
    private Vector3 _cacheJumpPos; // 0x50
    private EnterType _cacheEnterType; // 0x5C
    private uint _cacheToken; // 0x60
    private bool _cacheIsSkipUI; // 0x64
    private bool _isPlayerTransStart; // 0x65
    private Coroutine _delayTransmitInCSCoroutine; // 0x68

    // Properties
    public bool isPlayerTransStarted { /* [XID] */ /* 0x0000000189B1AAC0-0x0000000189B1AAE0 */ get => false; } // 0x0000000181D9B950-0x0000000181D9B9F0 

    // Constructors
    public LoadingManager() { } // 0x0000000181D9DA20-0x0000000181D9DAD0

    // Methods
    // [XID] // 0x00000001896AB2B0-0x00000001896AB2D0
    public bool IsLoaded()
    {
        if (_curLoadingTask != null)
        {
            return _curLoadingTask.loadState == LoadingTask.LoadState.LoginFinish;
        }
        return false;
    }
    // 0x0000000181D9BEF0-0x0000000181D9BFB0
    // [XID] // 0x00000001899FB430-0x00000001899FB450
    public LoadingTask GetCurLoadingTask()
    {

        if (_curLoadingTask != null)
        {
            SuperDebug.VeryImportantError("[Loading] LoadingManager curLoadingTask is Null", ErrorLevel.Medium, ErrorCategory.Level);
            _curLoadingTask = RecycleExtension.AllocateAutoAllocRecycleType<LoadingTask>();
        }
        return _curLoadingTask;
    } // 0x0000000181D9B810-0x0000000181D9B950
      // [XID] // 0x0000000189A02690-0x0000000189A026B0
    public LoadingTask GetLastLoadingTask() => _lastLoadingTask; // 0x0000000181D966F0-0x0000000181D96790
                                                                 // [XID] // 0x0000000189A09E60-0x0000000189A09E80
    public BornTask GetBornTask() => _bornTask; // 0x0000000181D99980-0x0000000181D99A20
                                                // [XID] // 0x0000000189A116C0-0x0000000189A116E0
    public LoadingTask GetLoadingTask(uint token, bool forceCreate = false /* Metadata: 0x00AFED2A */)
    {
        LoadingTask task = null;
        if (forceCreate)
        {
            if (_loadingTasks.ContainsKey(token))
            {
                RecycleExtension.RecycleAutoAllocRecycleType(_loadingTasks[token]);
            }
            _loadingTasks[token] = RecycleExtension.AllocateAutoAllocRecycleType<LoadingTask>();
            _loadingTasks[token].token = token;
            if (_lastLoadingTask != null && _lastLoadingTask != _curLoadingTask)
            {
                RecycleExtension.RecycleAutoAllocRecycleType(_lastLoadingTask);
                _lastLoadingTask = null;
            }
            _lastLoadingTask = _curLoadingTask;
            if (_curLoadingTask != null)
            {
                _curLoadingTask.ClearCoroutine();
                _curLoadingTask = _loadingTasks[token];
            }
            else
            {
                _curLoadingTask = _loadingTasks[token];
                _curLoadingTask.isLoadNewScene = true;
                _curLoadingTask.isFirstEnterScene = true;
            }
            if (_loadingTasks.ContainsKey(token))
            {
                task = _loadingTasks[token];
            }
            else
            {
                SuperDebug.VeryImportantError("[Loading] LoadingTask GetLoadingTask is Null token:" + token, ErrorLevel.High, ErrorCategory.Level);
                task = RecycleExtension.AllocateAutoAllocRecycleType<LoadingTask>();
            }
        }
        return task;
    }// 0x0000000181D995B0-0x0000000181D99980
     // [XID] // 0x0000000189A18A30-0x0000000189A18A50
    public override void ClearOnLevelDestroy() { } // 0x0000000181D96D70-0x0000000181D96E10
                                                   // [XID] // 0x0000000189A200F0-0x0000000189A20110
    public override void Destroy() { } // 0x0000000181D97980-0x0000000181D97A20
                                       // [XID] // 0x0000000189A27460-0x0000000189A27480
    public override void Init() { } // 0x0000000181D9A6E0-0x0000000181D9A780
                                    // [XID] // 0x0000000189A2ECA0-0x0000000189A2ECC0
    public override void ReloadRes() { } // 0x0000000181D9D980-0x0000000181D9DA20
                                         // [XID] // 0x0000000189A36590-0x0000000189A365B0
    public override void ClearOnDisconnect()
    {
        base.ClearOnDisconnect();
        _transPreCallback = null;
        _transFinishCallback = null;
    } // 0x0000000181D96CC0-0x0000000181D96D70
      // [XID] // 0x0000000189A3DB90-0x0000000189A3DBB0
    public override void ClearOnBackHome(bool forceClear = true /* Metadata: 0x00AFED2B */)
    {
        base.ClearOnBackHome(forceClear);
        foreach (var task in _loadingTasks)
        {
            task.Value.ClearCoroutine();
        }
        _curLoadingTask = null;
        _lastLoadingTask = null;
        _bornTask = null;
        if (_bornCoroutine != null)
        {
            Singleton<CoroutineManager>.Instance.StopCoroutine(_bornCoroutine);
            _bornCoroutine = null;
        }
        _loadingTasks.Clear();
    } // 0x0000000181D96A60-0x0000000181D96CC0
      // [XID] // 0x0000000189A45310-0x0000000189A45330
    public void OnDoSetPlayerBornData()
    {
        Singleton<PlayerModule>.Instance.TrySetOpenState(OpenStateType.OPEN_STATE_FRESHMAN_GUIDE, true);
        var baseContext = Singleton<UIManager>.Instance.CurrentPageContext;
        if (baseContext != null)
        {
            InLevelNamePageContext context = baseContext as InLevelNamePageContext;
            CloseInLevelNamePageAndMusic(context);
            float fadeTime = context.FadeOutDuration();
            _bornCoroutine = Singleton<CoroutineManager>.Instance.Invoke(fadeTime, () => PlayFirstEnterVideo());
        }
        else
        {
            PlayFirstEnterVideo();
        }
        var initParams = new List<uint>();
        initParams.Add(351);
        Singleton<QuestModule>.Instance.ResetTrackingLocalData(initParams);
    } // 0x0000000181D974A0-0x0000000181D97740
      // [XID] // 0x0000000189A4C9E0-0x0000000189A4CA00
    private void PlayFirstEnterVideo()
    {
        if (_bornTask != null)
        {
            string useVideoName = "MDAQ001_OPNew_Part2_PlayerBoy.usm";
            if (!_bornTask.isMale)
            {
                useVideoName = "MDAQ001_OPNew_Part2_PlayerGirl.usm";
            }
            _bornTask.isBornVideoPlaying = true;
            Singleton<UIManager>.Instance.TryHideSelectPageContext();
            Singleton<UIManager>.Instance.TryCloseMaskHintByType(UIManager.DisconnectHintType.Disconnect);
            Singleton<AudioManager>.Instance.ui.PostVideoStartEvent(useVideoName);
            Singleton<VideoManager>.Instance.TryPlayVideoByPath(
                useVideoName,
                _bornTask.isMale ? GlobalVars.BORN_BOY_VIDEO_TEXT : GlobalVars.BORN_Girl_VIDEO_TEXT,
                true,
                () =>
                {
                    Singleton<UIManager>.Instance.EnableCurtain(false, true, true, 0.5f);
                },
                () =>
                {
                    Singleton<UIManager>.Instance.loadingDialogType = UIManager.LoadingDialogType.FirstEnter;
                    OnPlayerEnterSceneNotify(_bornTask.enterSceneNotify);
                    Singleton<AudioManager>.Instance.ui.PostVideoEndEvent(useVideoName);
                },
                () =>
                {
                    Singleton<UIManager>.Instance.loadingDialogType = UIManager.LoadingDialogType.FirstEnter;
                    OnPlayerEnterSceneNotify(_bornTask.enterSceneNotify);
                    Singleton<AudioManager>.Instance.ui.PostVideoEndEvent(useVideoName);
                }
                );
        }
        else
        {
            SuperDebug.VeryImportantError("[Loading] LoadingManager BornTask is Null:", ErrorLevel.High, ErrorCategory.Level);
        }
    } // 0x0000000181D97CC0-0x0000000181D98170
      // [XID] // 0x0000000189A54210-0x0000000189A54230
    private void CloseInLevelNamePageAndMusic(InLevelNamePageContext context)
    {
        context.ClosePage();
        ConfigWwiseString eventName = AudioData.ui.characterSelectMusicEndEvent;
        Singleton<AudioManager>.Instance.ui.PostEvent2D(eventName);
    } // 0x0000000181D9CF20-0x0000000181D9D090
      // [XID] // 0x0000000189A5BC20-0x0000000189A5BC40
    public void OnPlayerEnterSceneNotify(PlayerEnterSceneNotify notify)
    {
        if (_bornTask != null && _bornTask.isBornEnterScene)
        {
            _bornTask.enterSceneNotify = notify.Clone();
            if (_bornTask.isBornVideoPlaying)
            {
                _bornTask.isBornEnterScene = false;
                _bornTask.isBornVideoPlaying = false;
                Singleton<UIManager>.Instance.loadingDialogType = UIManager.LoadingDialogType.FirstEnter;
                OnPlayerEnterSceneNotify(_bornTask.enterSceneNotify);
            }
        }
        else
        {
            var token = notify.EnterSceneToken;
            var loadTask = GetLoadingTask(token, true);
            loadTask.dungeonId = notify.DungeonId;
            loadTask.initPos = notify.Pos.FromProto();
            if (notify.SceneId == InLevelData.BIGWORLD_SCENE_ID)
            {
                UpdateSceneTags(notify.SceneTagIdList);
            }
            ActorUtils.InterruptReminder();
            if (SuperDebug.IsSwitchOn(SuperDebug.DEFAULT))
            {
                //这不是现在该做的
            }
            switch (notify.Type)
            {
                case EnterType.EnterSelf:
                case EnterType.EnterJump:
                case EnterType.EnterOther:
                case EnterType.EnterBack:
                case EnterType.EnterDungeon:
                case EnterType.EnterSelfHome:
                case EnterType.EnterOtherHome:
                    RealEnterScene(notify);
                    break;
                case EnterType.EnterGoto:
                case EnterType.EnterDungeonReplay:
                case EnterType.EnterGotoByPortal:
                    SceneGoto(notify);
                    break;
                default:
                    SuperDebug.VeryImportantError("Unknown OnPlayerEnterSceneNotify type", ErrorLevel.High, ErrorCategory.Level);
                    break;
            }
            if (!OpenStateUtils.IsCodeSwitchesEnable(PlayerEnterSceneNotify.IsSkipUiFieldNumber))
            {
                bool settingUseRagdoll = false;
                if (notify.DungeonId == 0 && DungeonExcelConfigLoader.GetData(notify.DungeonId) == null && DungeonExcelConfigLoader.GetData(notify.DungeonId).type != DungeonType.DUNGEON_THEATRE_MECHANICUS)
                {
                    settingUseRagdoll = GlobalVars.settingUseRagdoll;
                }
                GlobalVars.useRagdoll = settingUseRagdoll;
            }
        }
    } // 0x0000000181D98B70-0x0000000181D99270
      // [XID] // 0x0000000189A63390-0x0000000189A633B0
    private void UpdateSceneTags(IList<uint> lst)
    {
        List<string> str = new List<string>();
        foreach (var id in lst)
        {
            var data = SceneTagConfigLoader.GetData(id);
            if (data != null)
            {
                str.Add(data.sceneTagName);
            }
        }
        str.Sort();
        if (!Miscs.CompareList(SECTR_Utils.festivalNams, str, StringComparer.Ordinal))
        {
            SECTR_Utils.forceReset = true;
            SECTR_Utils.festivalNams.Clear();
            SECTR_Utils.festivalNams.AddRange(str);
        }
    } // 0x0000000181D9B2D0-0x0000000181D9B5E0
      // [XID] // 0x0000000189A6AED0-0x0000000189A6AEF0
    private bool NeedLoadNewScene(PlayerEnterSceneNotify notify)
    {
        var lastTask = GetLastLoadingTask();
        bool isReady;
        if (Singleton<PlayerModule>.Instance.sceneOwnerUid == notify.TargetUid
           && Singleton<PlayerModule>.Instance.curSceneID == notify.SceneId
           && lastTask != null
           && lastTask.loadState == LoadingTask.LoadState.LoginFinish
           && !notify.IsFirstLoginEnterScene
           && Singleton<LevelModule>.Instance.curLevel != null)
        {
            isReady = !Singleton<LevelModule>.Instance.curLevel.IsReady();
        }
        else
        {
            isReady = true;
        }
        if (!isReady)
        {
            var sharedPosition = Singleton<SECTR_Manager>.Instance.GetSharedPosition();
            isReady = (Vector3.Distance(notify.Pos.FromProto(), sharedPosition) > 60f | Singleton<SECTR_Manager>.Instance.NeedReload()) != false;
        }
        if (SuperDebug.IsSwitchOn(SuperDebug.NETWORK) && isReady)
        {
            //这不是现在该做的
        }
        return isReady;
    }// 0x0000000181D958A0-0x0000000181D95F20
     // [XID] // 0x0000000189A72580-0x0000000189A725A0
    private void RealEnterScene(PlayerEnterSceneNotify notify)
    {
        Singleton<LevelModule>.Instance.worldLevel = notify.WorldLevel;
        TimeUtil.SetSceneCurTime(notify.SceneBeginTime);
        Singleton<PlayerModule>.Instance.accountData.lastChangeAvatarTime = TimeUtil.PlayerChangeTime;
        var loadTask = GetLoadingTask(notify.EnterSceneToken);
        switch (notify.Type)
        {
            case EnterType.EnterSelf:
            case EnterType.EnterJump:
            case EnterType.EnterOther:
            case EnterType.EnterBack:
            case EnterType.EnterSelfHome:
            case EnterType.EnterOtherHome:
                loadTask.isLoadNewScene = NeedLoadNewScene(notify);
                loadTask.loadType = LoadingTask.LoadType.Scene;
                loadTask.loadState = LoadingTask.LoadState.EnterScene;
                Singleton<PlayerModule>.Instance.sceneOwnerUid = notify.TargetUid;
                CheckNeedToLoadScene(notify);
                break;
            case EnterType.EnterDungeon:
                loadTask.isLoadNewScene = true;
                loadTask.loadType = LoadingTask.LoadType.Dungeon;
                loadTask.loadState = LoadingTask.LoadState.EnterScene;
                Singleton<PlayerModule>.Instance.sceneOwnerUid = notify.TargetUid;
                LoadNewScene(notify);
                Singleton<MapModule>.Instance.OnPlayerEnterDungeon(notify);
                break;
            default:
                SuperDebug.VeryImportantError("Unknown OnPlayerEnterSceneNotify type", ErrorLevel.High, ErrorCategory.Level);
                break;
        }
        if (notify.PrevSceneId == InLevelData.BIGWORLD_SCENE_ID)
        {
            Singleton<MapModule>.Instance.bigworldPos = notify.PrevPos.FromProto();
        }
    } // 0x0000000181D98170-0x0000000181D98640
      // [XID] // 0x0000000189A7A1D0-0x0000000189A7A1F0
    private void SceneGoto(PlayerEnterSceneNotify notify)
    {
        var loadTask = GetLoadingTask(notify.EnterSceneToken);
        Singleton<LevelModule>.Instance.worldLevel = notify.WorldLevel;
        TimeUtil.SetSceneCurTime(notify.SceneBeginTime);
        Singleton<PlayerModule>.Instance.accountData.lastChangeAvatarTime = TimeUtil.PlayerChangeTime;
        switch (notify.Type)
        {
            case EnterType.EnterNone:
            case EnterType.EnterSelf:
            case EnterType.EnterGoto:
            case EnterType.EnterJump:
            case EnterType.EnterOther:
            case EnterType.EnterBack:
            case EnterType.EnterDungeon:
            case EnterType.EnterDungeonReplay:
            case EnterType.EnterGotoByPortal:
                loadTask.isLoadNewScene = false;
                loadTask.loadType = LoadingTask.LoadType.Goto;
                loadTask.loadState = LoadingTask.LoadState.EnterScene;
                SetCurLevelBeforeLoadScene(false, notify.Type != EnterType.EnterGotoByPortal, true);
                if (notify.SceneId == notify.PrevSceneId)
                {
                    if (notify.SceneId != InLevelData.BIGWORLD_SCENE_ID)
                    {
                        Singleton<UIManager>.Instance.loadingSituationType = UIManager.LoadingSituationType.Revival;
                        Singleton<UIManager>.Instance.loadingPicType = UIManager.LoadingSituationType.EnterDailyDungeon;
                    }
                }
                PlayerJumpPos(loadTask.initPos, notify.Type, notify.EnterSceneToken, notify.IsSkipUi);
                break;
            default:
                SuperDebug.VeryImportantError("Unknown OnPlayerEnterSceneNotify type", ErrorLevel.High, ErrorCategory.Level);
                break;
        }
        if (notify.PrevSceneId == InLevelData.BIGWORLD_SCENE_ID)
        {
            Singleton<MapModule>.Instance.bigworldPos = notify.PrevPos.FromProto();
        }
    } // 0x0000000181D99D50-0x0000000181D9A210
      // [XID] // 0x0000000189A81690-0x0000000189A816B0
    private void SetCurLevelBeforeLoadScene(bool isPrepare, bool asyncLoad, bool isTransmit)
    {
        if (Singleton<LevelModule>.Instance.curLevel != null)
        {
            Singleton<LevelModule>.Instance.curLevel.PrepareBeforeLoad(isPrepare, asyncLoad, isTransmit);
        }
    } // 0x0000000181D9D840-0x0000000181D9D980
      // [XID] // 0x0000000189A89090-0x0000000189A890B0
    private void LoadNewScene(PlayerEnterSceneNotify notify)
    {
        var loadTask = GetLoadingTask(notify.EnterSceneToken);
        if (SuperDebug.IsSwitchOn(SuperDebug.NETWORK))
        {
            //这不是现在该做的
        }
        SetCurLevelBeforeLoadScene(true, false, false);
        loadTask.loadType = LoadingTask.LoadType.Goto;
        Singleton<UIManager>.Instance.MaskPage(false);
        Singleton<UIManager>.Instance.SetLoadingSituationType(notify);
        Singleton<UIManager>.Instance.ShowLoadingPage(() =>
        {
            Singleton<NetworkManager>.Instance.RequestEnterSceneReady(notify.EnterSceneToken);
        });
    } // 0x0000000181D99270-0x0000000181D995B0
      // [XID] // 0x0000000189A90870-0x0000000189A90890
    private void ReloadCurScene(PlayerEnterSceneNotify notify)
    {
        SetCurLevelBeforeLoadScene(false, false, false);
        Singleton<NetworkManager>.Instance.RequestEnterSceneReady(notify.EnterSceneToken);
        Singleton<LevelModule>.Instance.curLevel.OnPlayerEnterSceneFinish(notify.EnterSceneToken, true);
    } // 0x0000000181D9D090-0x0000000181D9D220
      // [XID] // 0x0000000189A980B0-0x0000000189A980D0
    private void CheckNeedToLoadScene(PlayerEnterSceneNotify notify)
    {
        var loadTask = GetLoadingTask(notify.EnterSceneToken);
        if (loadTask.isLoadNewScene)
            LoadNewScene(notify);
        else
            ReloadCurScene(notify);
    } // 0x0000000181D96860-0x0000000181D96950
      // [XID] // 0x0000000189A9F490-0x0000000189A9F4B0
    public void OnBeginLoadScene(EnterScenePeerNotify notify)
    {
        var loadTask = GetLoadingTask(notify.EnterSceneToken);
        if (SuperDebug.IsSwitchOn(SuperDebug.NETWORK))
        {
            //这不是现在该做的
        }
        if (loadTask.loadType != LoadingTask.LoadType.Goto)
        {
            loadTask.loadState = LoadingTask.LoadState.SceneReady;
        }
        if (loadTask.isLoadNewScene)
        {
            if (Singleton<LuaManager>.Instance != null)
            {
                Singleton<LuaManager>.Instance.OnLevelLoad(loadTask.sceneID);
                Singleton<LuaManager>.Instance.ForceGC();
            }
            Singleton<PlayerModule>.Instance.curSceneID = loadTask.sceneID;
            Singleton<PlayerModule>.Instance.curSceneConfig = SceneExcelConfigLoader.GetData(loadTask.sceneID);
            var curSceneConfig = Singleton<PlayerModule>.Instance.curSceneConfig;
            if (curSceneConfig != null)
            {
                GameManager.Instance.ChangeGameWorld(GlobalVars.WorldType.Level, notify.EnterSceneToken, curSceneConfig.scriptData, null, curSceneConfig.overrideDefaultProfile);
            }
            else
            {
                SuperDebug.VeryImportantError("OnEnterScenePeerNotify invalid sceneId:" + loadTask.sceneID, ErrorLevel.High, ErrorCategory.Level);
                return;
            }
        }
        InLevelData.peerId = notify.PeerId;
        Singleton<MultiplayerModule>.Instance.UpdateSelfPeerID(Singleton<PlayerModule>.Instance.accountData.userId, notify.PeerId);
        InLevelData.hostPeerId = notify.HostPeerId;
        if (SuperDebug.IsSwitchOn(SuperDebug.NETWORK))
        {
            //这不是现在该做的
        }
    } // 0x0000000181D9A8D0-0x0000000181D9B2D0
      // [XID] // 0x0000000189AA6CA0-0x0000000189AA6CC0
    public void AfterInitFinish(PlayerEnterSceneInfoNotify notify)
    {
        if (Singleton<EntityManager>.Instance != null)
        {
            var localAvatarEntity = Singleton<EntityManager>.Instance.GetLocalAvatarEntity();
            localAvatarEntity.SetActive(false);
            Singleton<EntityManager>.Instance.SetLocalAvatarEntityID(notify.CurAvatarEntityId);
        }
        uint enterSceneToken = 0;
        uint teamEntityId = 0;
        AbilitySyncStateInfo teamAbilityInfo = null;
        if (Singleton<LevelModule>.Instance.curLevel != null)
        {
            if (notify.TeamEnterInfo != null)
            {
                enterSceneToken = notify.EnterSceneToken;
                teamEntityId = notify.TeamEnterInfo.TeamEntityId;
                teamAbilityInfo = notify.TeamEnterInfo.TeamAbilityInfo;
            }
            Singleton<LevelModule>.Instance.curLevel.LevelCreateLuaTeamAndAvatars(enterSceneToken, teamEntityId, teamAbilityInfo);
            Singleton<LevelModule>.Instance.curLevel.CreateMPLevelEntity(notify.MpLevelEntityInfo);
            if (Singleton<EntityManager>.Instance != null)
            {
                var levelComponent = Singleton<EntityManager>.Instance.levelEntity.GetLCLevelComponent();
                if (levelComponent.isReconnectingSceneInitFinish)
                {
                    levelComponent.isReconnectingSceneInitFinish = false;
                    levelComponent.ClearRedundantLocalGadgets();
                }
            }
            Singleton<UIManager>.Instance.TryCloseMPLoadingDialog();
            var type = Singleton<PlayerModule>.Instance.curSceneConfig.type;
            var stageType = Singleton<LevelModule>.Instance.curLevel.GetStageType();
            if (stageType == StageType.Dungeon)
            {
                if (type == SceneType.SCENE_DUNGEON)
                    return;
            }
            else if (stageType == StageType.Room)
            {
                if (type == SceneType.SCENE_ROOM)
                    return;
            }
            else if (stageType > StageType.World || type == SceneType.SCENE_WORLD)
                return;
            SuperDebug.LogError("SceneConfig和LevelScript中的类型不对应，分别为:" + type + "," + stageType);
        }
        else
        {
            SuperDebug.VeryImportantError("[Login] AfterInitFinish curLevel is Null", ErrorLevel.High, ErrorCategory.Level);
        }
    } // 0x0000000181D9C5E0-0x0000000181D9CC60
      // [XID] // 0x0000000189AAE410-0x0000000189AAE430
    public void AfterEnterSceneDone(EnterSceneDoneRsp rsp)
    {
        var loadTask = GetLoadingTask(rsp.EnterSceneToken);
        if (loadTask.isReLogin) loadTask.isReLogin = false;
        Singleton<LevelModule>.Instance.ForceAppearAllWaitForOwnerInfos();
        if (Singleton<LevelModule>.Instance.curLevel != null)
        {
            Singleton<LevelModule>.Instance.curLevel.FinishLoadScene(rsp.EnterSceneToken, loadTask.isLoadNewScene, loadTask.loadType == LoadingTask.LoadType.Goto);
        }
        else
        {
            SuperDebug.VeryImportantError("[Login] AfterEnterSceneDone curLevel is Null", ErrorLevel.High, ErrorCategory.Level);
        }
    } // 0x0000000181D9CD20-0x0000000181D9CF20
      // [XID] // 0x0000000189AB5C80-0x0000000189AB5CA0
    public void OnChooseName(bool isBornEnterScene, bool isMale)
    {
        if (_bornTask == null)
        {
            _bornTask = new BornTask();
        }
        _bornTask.isBornEnterScene = isBornEnterScene;
        _bornTask.isMale = isMale;
    } // 0x0000000181D9A5C0-0x0000000181D9A6E0
      // [XID] // 0x0000000189ABD6F0-0x0000000189ABD710
    public void OnTokenRspFail()
    {
        if (_curLoadingTask != null)
        {
            _curLoadingTask.loadState = LoadingTask.LoadState.Invalid;
        }
    } // 0x0000000181D9C1B0-0x0000000181D9C260
      // [XID] // 0x0000000189AC5190-0x0000000189AC51B0
    public void OnLoginRspSucc(bool isRelogin)
    {
        if (_curLoadingTask != null)
        {
            _curLoadingTask.isReLogin = isRelogin;
        }
    } // 0x0000000181D9CC60-0x0000000181D9CD20
      // [XID] // 0x0000000189A9E970-0x0000000189A9E990
    public void OnLoginRspQueuing()
    {
        if (_curLoadingTask != null)
        {
            _curLoadingTask.loadState = LoadingTask.LoadState.Queuing;
        }
    } // 0x0000000181D9BE40-0x0000000181D9BEF0
      // [XID] // 0x0000000189886B00-0x0000000189886B20
    public void OnLoginRspFail()
    {
        if (_curLoadingTask != null)
        {
            _curLoadingTask.loadState = LoadingTask.LoadState.Invalid;
        }
    } // 0x0000000181D9A780-0x0000000181D9A830
      // [XID] // 0x0000000189ADBDC0-0x0000000189ADBDE0
    public void SetReloadScene()
    {
        if (_curLoadingTask != null)
        {
            _curLoadingTask.sceneID = 0;
        }
    } // 0x0000000181D96950-0x0000000181D96A00
      // [XID] // 0x0000000189AE36F0-0x0000000189AE3710
    public void EnterSceneInitFinish(uint token)
    {
        GetLoadingTask(token).loadState = LoadingTask.LoadState.SceneInitFinish;
    } // 0x0000000181D96790-0x0000000181D96860
      // [XID] // 0x0000000189AEB050-0x0000000189AEB070
    public void EnterSceneDoneFinish(uint token)
    {
        GetLoadingTask(token).loadState = LoadingTask.LoadState.SceneDone;
    } // 0x0000000181D9A2C0-0x0000000181D9A390
      // [XID] // 0x0000000189AF2920-0x0000000189AF2940
    public void EnterInitScene(uint token)
    {
        GetLoadingTask(token).loadState = LoadingTask.LoadState.InitScene;
    } // 0x0000000181D98640-0x0000000181D98710
      // [XID] // 0x0000000189AFA220-0x0000000189AFA240
    public void EnterLoadStage(uint token, bool isNewScene)
    {
        GetLoadingTask(token).loadState = LoadingTask.LoadState.LoadStage;
        Singleton<SECTR_Manager>.Instance.EnterGameSceneLoad();
        if (Singleton<EventManager>.Instance != null)
        {
            var evtStageCreated = EventHelper.Allocate<EvtStageCreated>();
            evtStageCreated.Init(isNewScene);
            Singleton<EventManager>.Instance.FireEvent(evtStageCreated);
        }
    } // 0x0000000181D99A20-0x0000000181D99C00
      // [XID] // 0x0000000189B017A0-0x0000000189B017C0
    public void EnterScenePostFinish(uint token, bool isNewScene)
    {
        Singleton<SECTR_Manager>.Instance.FinishGameSceneLoad();
        if (Singleton<EventManager>.Instance != null)
        {
            var evtStageReady = EventHelper.Allocate<EvtStageReady>();
            evtStageReady.Init(isNewScene);
            Singleton<EventManager>.Instance.FireEvent(evtStageReady);
        }
        GetLoadingTask(token).loadState = LoadingTask.LoadState.LoginFinish;
        _loadingTasks.Remove(token);
    } // 0x0000000181D96100-0x0000000181D96300
      // [XID] // 0x0000000189B08CF0-0x0000000189B08D10
    public void StopLoading()
    {
        if (_curLoadingTask != null)
            _curLoadingTask.loadState = LoadingTask.LoadState.Invalid;
        if (Singleton<NetworkManager>.Instance != null)
        {
            Singleton<NetworkManager>.Instance.Disconnect(ENetReason.EnetClientClose);
        }
    } // 0x0000000181D9BD10-0x0000000181D9BE40
    [DebuggerHidden] // 0x0000000189B107F0-0x0000000189B10830
                     // [XID] // 0x0000000189B107F0-0x0000000189B10830
    public IEnumerator PlayerTeleport(Vector3 pos, Action<SECTR_Manager.ProgressType, float> progressFunc)
    {
        if (Singleton<SECTR_Manager>.Instance.IsStreamWorld())
        {
            yield return Singleton<SECTR_Manager>.Instance.InitIter(pos, progressFunc);
        }
        else
        {
            progressFunc(SECTR_Manager.ProgressType.Finish, 1f);
            if (GlobalVars.loadingUseEntityASyncLoad)
            {
                AssetBundleExternalResourceProvider.Instance.CollectBatchLoad((float progress) => { });
            }
            yield return null;
            yield break;
        }
        if (GlobalVars.loadingUseEntityASyncLoad)
        {
            AssetBundleExternalResourceProvider.Instance.CollectBatchLoad((float progress) => { });
            yield break;
        }
        while (!AssetBundleExternalResourceProvider.Instance.idle)
        {
            yield return null;
        }
    }
    // 0x0000000181D99C00-0x0000000181D99D50
    // [XID] // 0x0000000189B220B0-0x0000000189B220D0
    public void PlayerJumpPos(Vector3 jumpPos, EnterType enterType, uint token, bool isSkipUI)
    {
        if (Singleton<LevelModule>.Instance.curLevel.worldType == GlobalVars.WorldType.Level)
        {
            if (enterType == EnterType.EnterDungeonReplay)
            {
                Singleton<MapModule>.Instance.OnPlayerEnterDungeonReplay();
            }
            _cacheJumpPos = jumpPos;
            _cacheEnterType = enterType;
            _cacheToken = token;
            _cacheIsSkipUI = isSkipUI;
            if (Singleton<InteractionManager>.Instance != null)
            {
                if (!CheckTransmitInCutscene())
                {
                    Singleton<InteractionManager>.Instance.CallOnKeyListFinish(PerformSafePlayerTransmit);
                }
            }
            else
            {
                PerformSafePlayerTransmit();
            }
        }
        else
        {
            SuperDebug.LogError("OnPlayerEnterSceneNotify cur level is not level");
        }
    } // 0x0000000181D9BA90-0x0000000181D9BD10
      // [XID] // 0x0000000189B29640-0x0000000189B29660
    private bool CheckTransmitInCutscene()
    {
        ConfigBaseCutscene cutsceneCfg = null;
        if (Singleton<InteractionManager>.Instance != null)
        {
            var inerAction = Singleton<InteractionManager>.Instance.GetInerAction(InteractionType.CUTSCENE);
            if (inerAction != null)
            {
                if (inerAction.cfg != null)
                {
                    cutsceneCfg = (inerAction.cfg as ConfigCutsceneInterAction).cutsceneCfg;
                }
            }
            if (Singleton<CutsceneManager>.Instance.currRunningTask != null)
            {
                if (!Singleton<CutsceneManager>.Instance.currRunningTask.isFinished)
                {
                    cutsceneCfg = Singleton<CutsceneManager>.Instance.currRunningTask.cfg;
                }
            }
            if (cutsceneCfg != null)
            {
                if (cutsceneCfg.directTransmit)
                {
                    if (cutsceneCfg.delayTransmit > 0f)
                    {
                        if (_delayTransmitInCSCoroutine != null)
                        {
                            _delayTransmitInCSCoroutine = Singleton<CoroutineManager>.Instance.Invoke(cutsceneCfg.delayTransmit, PerformDirectlyPlayerTransmit);
                            return true;
                        }
                        if (!_isPlayerTransStart)
                        {
                            PerformDirectlyPlayerTransmit();
                            return true;
                        }
                    }
                }
            }
        }
        return false;
    }
    // 0x0000000181D988D0-0x0000000181D98B70
    // [XID] // 0x0000000189B30BF0-0x0000000189B30C10
    public void OnCutSceneFinish()
    {
        if (_delayTransmitInCSCoroutine != null)
        {
            PerformDirectlyPlayerTransmit();
        }
    } // 0x0000000181D9A210-0x0000000181D9A2C0
      // [XID] // 0x0000000189B38250-0x0000000189B38270
    private void PerformDirectlyPlayerTransmit()
    {
        _isPlayerTransStart = true;
        PerformPlayerTransmit(_cacheJumpPos, _cacheEnterType, _cacheToken, EvtTransmitAvatar.TransmitType.DirectlySetPos);
        StopDelayTransmitCoroutine();
    } // 0x0000000181D9D310-0x0000000181D9D3F0
      // [XID] // 0x0000000189B3FCA0-0x0000000189B3FCC0
    private void StopDelayTransmitCoroutine()
    {
        if (_delayTransmitInCSCoroutine != null)
        {
            Singleton<CoroutineManager>.Instance.StopCoroutine(_delayTransmitInCSCoroutine);
        }
        _delayTransmitInCSCoroutine = null;
    } // 0x0000000181D9A410-0x0000000181D9A500
      // [XID] // 0x0000000189B47490-0x0000000189B474B0
    private void PerformSafePlayerTransmit()
    {
        _isPlayerTransStart = true;
        PerformPlayerTransmit(_cacheJumpPos, _cacheEnterType, _cacheToken, _cacheIsSkipUI ? EvtTransmitAvatar.TransmitType.DirectlySetPos : EvtTransmitAvatar.TransmitType.Default);
    } // 0x0000000181D9B5E0-0x0000000181D9B6C0
      // [XID] // 0x0000000189B4ECD0-0x0000000189B4ECF0
    public void RequestSceneTransToPoint(uint sceneId, uint pointId, Action finishCallBackInForceDrag = null)
    {
        bool gotoBlock = false;
        if (PlayerVars.canTransport)
        {
            if (!Ban.IsBan(BanType.BAN_TRANSPORT))
            {
                MapModule.ScenePointData scenePointData = Singleton<MapModule>.Instance.GetTransPointData(sceneId, pointId);
                AvatarEntity localAvatar = Singleton<EntityManager>.Instance.GetLocalAvatarEntity();
                var absPos = localAvatar.GetAbsolutePosition();
                var tarPos = scenePointData.config.tranPos.ToVector3();
                var tarRot = scenePointData.config.tranRot.ToVector3();
                if (localAvatar != null && localAvatar.isAlive && scenePointData.config.gadgetId == 0 && Vector3.Distance(tarPos, absPos) < 60f)
                {
                    if (sceneId != 0 || sceneId == Singleton<PlayerModule>.Instance.curSceneID)
                    {
                        ActorUtils.InterruptReminder();
                        Singleton<ActorManager>.Instance.Transmiting(true);
                        UIUtil.ShowBlackScreen(0.5f, 1f, 0.5f, () =>
                        {
                            UIUtil.BackToMainPage();
                            var camera = Singleton<EntityManager>.Instance.GetMainCameraEntity();
                            LCBaseInter autoOpenDoor = localAvatar.GetLogicComponent<LCBaseInter>(LCBaseComponentTypeIDs.LCBaseInter);
                            if (autoOpenDoor != null)
                            {
                                autoOpenDoor.LostAllInteeAttention();
                            }
                            if (InLevelData.hasOtherPlayerArround)
                            {
                                tarPos = VCHumanoidMove.GetSafeAppearPos(tarPos, localAvatar);
                            }
                            localAvatar.SetAbsolutePosition(tarPos);
                            localAvatar.SetTransformYaw(tarRot.y);
                            camera.ResetCameraToAvatarBackward(localAvatar.GetRelativePosition());
                            var humanMove = localAvatar.GetVisualComponent<VCHumanoidMove>(VCBaseComponentTypeIDs.VCHumanoidMove);
                            if (humanMove != null)
                            {
                                humanMove.NotifyQuestForceDrag();
                                humanMove.ResetFSMKeepMajorAnimatorState();
                            }
                            ActorUtils.SyncEntityPos(localAvatar, 0);
                        },
                        () =>
                        {
                            Singleton<ActorManager>.Instance.Transmiting(false);
                            if (finishCallBackInForceDrag != null)
                                finishCallBackInForceDrag();
                        });
                    }
                    else if (sceneId != Singleton<PlayerModule>.Instance.curSceneID)
                    {
                        gotoBlock = true;
                    }
                }
                else
                {
                    gotoBlock = true;
                }
            }
        }
        else
        {
            UIUtil.TryShowMessage(TextMap.Get("INFO_CAN_NOT_USE_TRANSPOINT"));
        }
        if (gotoBlock)
        {
            var messageCache = MessageHelper.GetMessageCache<SceneTransToPointReq>();
            messageCache.SceneId = sceneId;
            messageCache.PointId = pointId;
            G.SendPacket(messageCache);
            var notify = UniRx.Tuple.Create(InLevelMainPageContext.MapNotify.CloseLevelMap);
            var notifyPack = Notify.CreateNotify(NotifyTypes.MapToggle, notify);
            Singleton<NotifyManager>.Instance.FireNotify(notifyPack);
            TryToTransmitPlayer();
        }
    } // 0x0000000181D96E10-0x0000000181D974A0
      // [XID] // 0x0000000189B56600-0x0000000189B56620
    public void RequestTransToPacketAnchor(uint anchorID)
    {
        if (PlayerVars.canTransport)
        {
            if (Ban.IsBan(BanType.BAN_TRANSPORT))
            {
                Singleton<WidgetSystemModule>.Instance.UsePacketAnchor(anchorID);
                var notify = UniRx.Tuple.Create(InLevelMainPageContext.MapNotify.CloseLevelMap);
                var notifyPack = Notify.CreateNotify(NotifyTypes.MapToggle, notify);
                Singleton<NotifyManager>.Instance.FireNotify(notifyPack);
                TryToTransmitPlayer();
            }
            else
            {
                UIUtil.TryShowMessage(TextMap.Get("INFO_CAN_NOT_USE_TRANSPOINT"));
            }
        }
    } // 0x0000000181D9C260-0x0000000181D9C4D0
      // [XID] // 0x0000000189B5DDC0-0x0000000189B5DDE0
    public void RequestClientTransmit(uint sceneId, Vector3 targetPos, Vector3 targetEuler, TransmitReason reason, ILuaActor actor, Action<ILuaActor> transFinishCallback, Action<ILuaActor> transPreCallback, uint questId = 0 /* Metadata: 0x00AFED2C */, uint pointId = 0 /* Metadata: 0x00AFED30 */)
    {
        _transPreCallback = transPreCallback;
        _transFinishCallback = transFinishCallback;
        _curActor = actor;
        if (questId != 0)
        {
            var messageCache = MessageHelper.GetMessageCache<QuestTransmitReq>();
            messageCache.QuestId = questId;
            messageCache.PointId = pointId;
            G.SendPacket(messageCache);
        }
        else
        {
            var messageCache = MessageHelper.GetMessageCache<ClientTransmitReq>();
            messageCache.SceneId = sceneId;
            messageCache.Pos = Miscs.ToProto(targetPos, messageCache.Pos);
            messageCache.Rot = Miscs.ToProto(targetEuler, messageCache.Pos);
            G.SendPacket(messageCache);
        }
        TryToTransmitPlayer();
    } // 0x0000000181D9D500-0x0000000181D9D7E0
      // [XID] // 0x0000000189B65320-0x0000000189B65340
    public void CheckTransPreCB()
    {
        if (_transPreCallback != null)
        {
            _transPreCallback(_curActor);
            _transPreCallback = null;
        }
    } // 0x0000000181D9A500-0x0000000181D9A5C0
      // [XID] // 0x0000000189B6C980-0x0000000189B6C9A0
    public void TransFinishCB()
    {
        TransmitPlayerFail();
        if (_transFinishCallback != null)
        {
            _transFinishCallback(_curActor);
            _curActor = null;
            _transFinishCallback = null;
        }
    } // 0x0000000181D9B740-0x0000000181D9B810
      // [XID] // 0x0000000189B740A0-0x0000000189B740C0
    public void TransmitPlayerFail()
    {
        if (Singleton<ActorManager>.Instance != null)
        {
            Singleton<ActorManager>.Instance.Transmiting(false);
        }
    } // 0x0000000181D9C4D0-0x0000000181D9C5E0
      // [XID] // 0x0000000189B7B650-0x0000000189B7B670
    public void TryToTransmitPlayer()
    {
        if (Singleton<ActorManager>.Instance != null)
        {
            Singleton<ActorManager>.Instance.Transmiting(true);
        }
    } // 0x0000000181D96300-0x0000000181D96410
      // [XID] // 0x0000000189B83040-0x0000000189B83060
    public void PlayerTransmitStart()
    {
        _isPlayerTransStart = true;
    } // 0x0000000181D9B9F0-0x0000000181D9BA90
      // [XID] // 0x0000000189B8A590-0x0000000189B8A5B0
    public void ClearTransNotify()
    {
        _isPlayerTransStart = false;
    } // 0x0000000181D9A830-0x0000000181D9A8D0
      // [XID] // 0x0000000189B91B80-0x0000000189B91BA0
    private void PerformPlayerTransmit(Vector3 targetPos, EnterType enterType, uint token, EvtTransmitAvatar.TransmitType transType = EvtTransmitAvatar.TransmitType.Default /* Metadata: 0x00AFED34 */)
    {
        if (_isPlayerTransStart)
        {
            var evtTransmitAvatar = EventHelper.Allocate<EvtTransmitAvatar>();
            evtTransmitAvatar.Init(targetPos, transType, enterType, token);
            Singleton<EventManager>.Instance.FireEvent(evtTransmitAvatar);
        }
        else
        {
            SuperDebug.LogWarning("PerformPlayerTransmit is Loading");
        }
    } // 0x0000000181D95F20-0x0000000181D96100
    [Preserve] // 0x0000000189B99020-0x0000000189B99060
               // [XID] // 0x0000000189B99020-0x0000000189B99060
    public override string Dump(string tag) => default; // 0x0000000181D97A20-0x0000000181D97CC0
                                                        // [XID] // 0x0000000189BA3710-0x0000000189BA3730
    public void ReportTasks() { } // 0x0000000181D9D3F0-0x0000000181D9D500
                                  // [XID] // 0x0000000189BAAAE0-0x0000000189BAAB00
    public void GoToLevelWithSceneId(uint sceneID, GlobalVars.WorldType worldType, string selectedDataName = null, Action createNewWorldCallback = null)
    {
        var loadTask = GetLoadingTask(0, true);
        loadTask.sceneID = sceneID;
        GoToLevelImp(worldType, selectedDataName, createNewWorldCallback);
    } // 0x0000000181D9BFB0-0x0000000181D9C0D0
      // [XID] // 0x0000000189BB2050-0x0000000189BB2070
    public void GoToLevel(GlobalVars.WorldType worldType, string selectedDataName = null, Action createNewWorldCallback = null)
    {
        GetLoadingTask(0, true);
        GoToLevelImp(worldType, selectedDataName, createNewWorldCallback);
    } // 0x0000000181D95690-0x0000000181D95790
      // [XID] // 0x0000000189BB9440-0x0000000189BB9460
    private void GoToLevelImp(GlobalVars.WorldType worldType, string selectedDataName = null, Action createNewWorldCallback = null)
    {
        var game = GameManager.Instance;
        var curWOrld = game.GetCurGameWorld();
        GlobalVars.WorldType curWorldType = default;
        if (curWOrld != null)
        {
            curWorldType = curWOrld.worldType;
        }
        if (curWorldType != worldType || worldType == GlobalVars.WorldType.Level || worldType == GlobalVars.WorldType.TestCutscene)
        {
            Singleton<PlayerModule>.Instance.curSceneID = GetCurLoadingTask().sceneID;
            Singleton<UIManager>.Instance.ShowLoadingPage(() =>
            {
                GameManager.Instance.ChangeGameWorld(worldType, 0, selectedDataName, createNewWorldCallback);
            });
        }
    } // 0x0000000181D96410-0x0000000181D966F0
    [DebuggerHidden] // 0x0000000189BC1260-0x0000000189BC12A0
                     // [XID] // 0x0000000189BC1260-0x0000000189BC12A0
    public IEnumerator WaitLevelLoaded(uint sceneID)
    {
        BaseLevel level = GameManager.Instance.GetCurGameWorld() as BaseLevel;
        while (!level.IsReady())
        {
            yield return null;
        }
        var localAvatar = Singleton<EntityManager>.Instance.GetLocalAvatarEntity();
        if (localAvatar != null)
        {
            string luaPath = string.Format("Lua/Scene/{0}/scene{0}.lua", sceneID);
            var luaEnv = Singleton<LuaManager>.Instance;
            luaEnv.DoLua(luaPath, luaPath);
            var luaSceneConfig = luaEnv.GetILua<LuaTable>("scene_config");
            var luaBornPos = luaSceneConfig.Get<LuaTable>("born_pos");
            float x = luaBornPos.Get<float>("x");
            float y = luaBornPos.Get<float>("y");
            float z = luaBornPos.Get<float>("z");
            Vector3 bornPos = new Vector3(x, y, z);
            localAvatar.SetAbsolutePosition(bornPos);
        }
        else
        {
            yield return null;
        }
    }
    // 0x0000000181D95790-0x0000000181D958A0
    // [XID] // 0x0000000189BCBC60-0x0000000189BCBC80
    public void DebugLocalGoToLevelWithDungeonId(uint dungeonID)
    {
        uint sceneId = 3;
        if (dungeonID != 0)
        {
            sceneId = DungeonExcelConfigLoader.GetData(dungeonID).sceneId;
        }
        DebugLocalGoToLevelWithSceneId(sceneId);
    } // 0x0000000181D9C0D0-0x0000000181D9C1B0
      // [XID] // 0x0000000189BD31B0-0x0000000189BD31D0
    public void DebugLocalGoToLevelWithSceneId(uint sceneID)
    {
        if (sceneID == 0)
        {
            sceneID = 3;
        }
        var data = SceneExcelConfigLoader.GetData(sceneID).scriptData;
        GoToLevelWithSceneId(sceneID + 1000000, GlobalVars.WorldType.Level, data, () =>
        {
            Singleton<CoroutineManager>.Instance.StartCoroutine(WaitLevelLoaded(sceneID));
        });
    } // 0x0000000181D98710-0x0000000181D988D0
      // [XID] // 0x0000000189BDAA90-0x0000000189BDAAB0
    public void DebugLocalTransport(Vector3 gotoPos)
    {
        var notify = UniRx.Tuple.Create(InLevelMainPageContext.MapNotify.CloseLevelMap);
        var notifyPack = Notify.CreateNotify(NotifyTypes.MapToggle, notify);
        Singleton<NotifyManager>.Instance.FireNotify(notifyPack);
        GetLoadingTask(0, true);
        _isPlayerTransStart = true;
        _cacheJumpPos = gotoPos;
        Singleton<LevelModule>.Instance.curLevel.levelState = BaseLevel.LevelState.SceneInitFinish;
        PerformPlayerTransmit(_cacheJumpPos, EnterType.EnterGoto, _cacheToken);
    } // 0x0000000181D97740-0x0000000181D97980
}

