﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using miHoYoThread;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public abstract class BaseLevel : GameWorld // TypeDefIndex: 19897
{
    // Fields
    public SceneScriptData levelCreateData; // 0x20
    private string _overloadDefaultWeatherProfile; // 0x28
    private uint configHandle; // 0x30
    public string sceneDataName; // 0x38
    protected float curProgress; // 0x40
    protected Coroutine curCoroutine; // 0x48
    private bool _loadEntityAsync; // 0x50
    private const float nonStreamEntitySliceframeWatchScale = 4f; // Metadata: 0x00AFD062
    private bool _isNewScene; // 0x51
    public static float intervalLoadMill; // 0x00
    private LevelState _levelState; // 0x54
    public static Dictionary<int, float> LoadStatePerc; // 0x08
    private float _startTime; // 0x58
    private bool wait; // 0x5C
    public static bool isLoading; // 0x10
    private List<TransmitRequest> _transmitRequests; // 0x60

    // Properties
    public LevelState levelState { /* [XID] */ /* 0x0000000189AA4C50-0x0000000189AA4C70 */ get; /* [XID] */ /* 0x0000000189AAFE10-0x0000000189AAFE30 */ set; } // 0x00000001814F10E0-0x00000001814F1180 0x00000001814EA1C0-0x00000001814EA270

    // Nested types
    public enum LevelState // TypeDefIndex: 19898
    {
        Invalid = 0,
        Preparing = 1,
        Loading = 2,
        SceneInitFinish = 3,
        Ready = 4,
        Destroied = 5
    }

    public enum LoadState // TypeDefIndex: 19899
    {
        None = 0,
        ClearAsset = 1,
        LoadScene = 2,
        PreLoadRes = 3,
        PreInit = 4,
        Init = 5,
        LoadStage = 6,
        LoadEntity = 7,
        AllReady = 8,
        UIInit = 9,
        PostLua = 10,
        PostReady = 11,
        Finish = 12,
        Transmit = 13
    }

    // Constructors
    protected BaseLevel()
    {
        _loadEntityAsync = true;
    } // Dummy constructor
    public BaseLevel(string dataName, string overloadDefaultWeatherProfile = null) { } // 0x00000001814F15D0-0x00000001814F1690
    static BaseLevel() { } // 0x00000001814F13B0-0x00000001814F15D0

    // Methods
    // [XID] // 0x0000000189A4E410-0x0000000189A4E430
    public bool IsLoadObjectAsync() => default; // 0x00000001814E9B80-0x00000001814E9C20
                                                // [XID] // 0x0000000189A55C40-0x0000000189A55C60
    public bool IsDungeon() => default; // 0x00000001814F1300-0x00000001814F13B0
                                        // [XID] // 0x0000000189832B50-0x0000000189832B70
    public bool IsRoom() => default; // 0x00000001814F0BC0-0x00000001814F0C70
                                     // [XID] // 0x0000000189A64D80-0x0000000189A64DA0
    public bool IsBigWorld() => default; // 0x00000001814F00A0-0x00000001814F0150
                                         // [XID] // 0x0000000189A6C500-0x0000000189A6C520
    public bool IsHomeworld() => default; // 0x00000001814EF640-0x00000001814EF710
                                          // [XID] // 0x0000000189A73CB0-0x0000000189A73CD0
    public bool IsHomeInternel() => default; // 0x00000001814E82C0-0x00000001814E8370
                                             // [XID] // 0x0000000189A7B7C0-0x0000000189A7B7E0
    public bool HasMapData() => default; // 0x00000001814E9D90-0x00000001814E9E80
                                         // [XID] // 0x0000000189A83000-0x0000000189A83020
    public StageType GetStageType() => default; // 0x00000001814ED4D0-0x00000001814ED580
                                                // [XID] // 0x0000000189A8A840-0x0000000189A8A860
    public DungeonPlayType GetDungeonPlayType() => default; // 0x00000001814F0C70-0x00000001814F0D80
                                                            // [XID] // 0x0000000189A92120-0x0000000189A92140
    public bool InActivityDungeon() => default; // 0x00000001814EE2C0-0x00000001814EE3D0
                                                // [XID] // 0x0000000189A99B00-0x0000000189A99B20
    public bool InElementChallengeDungeon() => default; // 0x00000001814EDDE0-0x00000001814EDEF0
                                                        // [XID] // 0x0000000189AA0AC0-0x0000000189AA0AE0
    public bool InTheatreMechanicusDungeon() => default; // 0x00000001814F0AB0-0x00000001814F0BC0
                                                         // [XID] // 0x0000000189AB7510-0x0000000189AB7530
    public float GetProgress() => default; // 0x00000001814E7B40-0x00000001814E7BF0
                                           // [XID] // 0x0000000189ABEFD0-0x0000000189ABEFF0
    public bool IsPreparing() => default; // 0x00000001814EFCF0-0x00000001814EFDB0
                                          // [XID] // 0x0000000189AC6A50-0x0000000189AC6A70
    public bool IsReady() => default; // 0x00000001814E9EE0-0x00000001814E9F90
                                      // [XID] // 0x0000000189ACE250-0x0000000189ACE270
    public bool IsDestroied() => default; // 0x00000001814F1180-0x00000001814F1230
                                          // [XID] // 0x0000000189AEA540-0x0000000189AEA560
    public bool IsSceneInitFinishAndReady() => default; // 0x00000001814E7FA0-0x00000001814E8060
                                                        // [XID] // 0x0000000189ADD8D0-0x0000000189ADD8F0
    public bool IsCoroutineStop() => default; // 0x00000001814E7EF0-0x00000001814E7FA0
                                              // [XID] // 0x0000000189AE51A0-0x0000000189AE51C0
    private void SetAsyncLoadEntity(bool isAsync) { } // 0x00000001814EAFF0-0x00000001814EB140
                                                      // [XID] // 0x0000000189AEC7E0-0x0000000189AEC800
    public void PrepareBeforeLoad(bool isPrepare, bool asyncLoad, bool isTrans) { } // 0x00000001814E7BF0-0x00000001814E7DA0
                                                                                    // [XID] // 0x0000000189AF41F0-0x0000000189AF4210
    public void OnPlayerEnterSceneFinish(uint token, bool isReconnecting) { } // 0x00000001814EBAC0-0x00000001814EBC80
                                                                              // [XID] // 0x0000000189AFB9C0-0x0000000189AFB9E0
    public void OnPlayerTransmitFinish(uint token) { } // 0x00000001814E83D0-0x00000001814E86A0
                                                       // [XID] // 0x0000000189B03070-0x0000000189B03090
    public override void Init(uint token)
    {
        ClearConfig();
        GlobalVars.time = Time.realtimeSinceStartup;
        _startTime = Time.realtimeSinceStartup;
        scenePath = "Level";
        SetAsyncLoadEntity(false);
        SchedulerMgr.Create();
        SchedulerMgr.SwitchThread(GlobalVars.lockScene);
        if (string.IsNullOrEmpty(sceneDataName))
        {
            levelCreateData = CommonMiscs.LoadExternal<SceneScriptData>(("Data/Level/" + sceneDataName), out configHandle);
        }
        if (!levelCreateData)
        {
            SuperDebug.Error("OnEnterScenePeerNotify is Null:" + sceneDataName);
        }
        else
        {
            NotifyManager notifyManager = Singleton<NotifyManager>.Instance;
            notifyManager.FireNotify(Notify.CreateNotify(NotifyTypes.LevelLoadBegin));
            Singleton<LevelModule>.Instance.curLevel = this;
            LoadingLevelProgress(BaseLevel.LoadState.ClearAsset);
            ClearLevelCoroutine();
            Singleton<CoroutineManager>.Instance.StartCoroutine(PreInitIter(token));
            Singleton<SecurityModule>.Instance.StartReportCoroutine();
        }
    } // 0x00000001814EB2D0-0x00000001814EB750
      // [XID] // 0x0000000189B0A7E0-0x0000000189B0A800
    public override void FixedTick() { } // 0x00000001814EC980-0x00000001814ECAB0
                                         // [XID] // 0x0000000189B11EC0-0x0000000189B11EE0
    public override void Tick() { } // 0x00000001814EB750-0x00000001814EB9E0
                                    // [XID] // 0x0000000189B191D0-0x0000000189B191F0
    public override void LateTick() { } // 0x00000001814EF5A0-0x00000001814EF640
                                        // [XID] // 0x0000000189B20890-0x0000000189B208B0
    private void OnFrameEnd() { } // 0x00000001814E95B0-0x00000001814E9710
                                  // [XID] // 0x0000000189B27F10-0x0000000189B27F30
    private void ClearLevelCoroutine() { } // 0x00000001814EF4B0-0x00000001814EF5A0
                                           // [XID] // 0x0000000189B2F2B0-0x0000000189B2F2D0
    public override void Destroy() { } // 0x00000001814E9710-0x00000001814E9B80
                                       // [XID] // 0x0000000189B36C10-0x0000000189B36C30
    public static void ClearConfig() { } // 0x00000001814EDEF0-0x00000001814EE070
    [DebuggerHidden] // 0x0000000189B3E3D0-0x0000000189B3E410
                     // [XID] // 0x0000000189B3E3D0-0x0000000189B3E410
    protected virtual IEnumerator PreInitIter(uint token) => default; // 0x00000001814EFBB0-0x00000001814EFC90
                                                                      // [XID] // 0x0000000189B49000-0x0000000189B49020
    protected void LoadScene() { } // 0x00000001814E9F90-0x00000001814EA060
                                   // [XID] // 0x0000000189B50600-0x0000000189B50620
    protected void OnSceneLoadedPreInit() { } // 0x00000001814F0690-0x00000001814F0980
                                              // [XID] // 0x0000000189B57F10-0x0000000189B57F30
    protected void OnSceneLoadedInit() { } // 0x00000001814E8E60-0x00000001814E93E0
                                           // [XID] // 0x0000000189B5F8B0-0x0000000189B5F8D0
    protected virtual void OnSceneLoadedPostInit(uint token) { } // 0x00000001814EE6A0-0x00000001814EED10
    [DebuggerHidden] // 0x0000000189B66FC0-0x0000000189B67000
                     // [XID] // 0x0000000189B66FC0-0x0000000189B67000
    protected virtual IEnumerator PreloadRes() => default; // 0x00000001814F09E0-0x00000001814F0AB0
    [DebuggerHidden] // 0x0000000189B71550-0x0000000189B71590
                     // [XID] // 0x0000000189B71550-0x0000000189B71590
    protected virtual IEnumerator LoadStage() => default; // 0x00000001814EE1F0-0x00000001814EE2C0
    [DebuggerHidden] // 0x0000000189B7B830-0x0000000189B7B870
                     // [XID] // 0x0000000189B7B830-0x0000000189B7B870
    protected virtual IEnumerator WaitAudioFinish() => default; // 0x00000001814EEF50-0x00000001814EF010
                                                                // [XID] // 0x0000000189B86290-0x0000000189B862B0
    public void LevelCreateLuaTeamAndAvatars(uint token, uint teamEntityId = 0 /* Metadata: 0x00AFD05A */, AbilitySyncStateInfo teamAbilityInfo = null) { } // 0x00000001814EC040-0x00000001814EC2F0
    [DebuggerHidden] // 0x0000000189B8D350-0x0000000189B8D390
                     // [XID] // 0x0000000189B8D350-0x0000000189B8D390
    protected virtual IEnumerator PreLoadAllAvatars(uint token) => default; // 0x00000001814EB9E0-0x00000001814EBAC0
                                                                            // [XID] // 0x0000000189B97950-0x0000000189B97970
    public void CreateTeamEntity(uint teamEntityId, uint authorityPeerId, AbilitySyncStateInfo teamAbilityInfo, bool isLocalTeamEntity) { } // 0x00000001814ECF40-0x00000001814ED470
                                                                                                                                            // [XID] // 0x0000000189B9EDB0-0x0000000189B9EDD0
    public void CreatePlayTeamEntity(uint teamEntityId, uint playerUid, uint authorityPeerId, uint configId, AbilitySyncStateInfo abilityInfo) { } // 0x00000001814F0150-0x00000001814F0690
                                                                                                                                                   // [XID] // 0x0000000189BA6660-0x0000000189BA6680
    public void CreateLocalMPLevelEntity() { } // 0x00000001814ECAB0-0x00000001814ECC30
                                               // [XID] // 0x0000000189BAD920-0x0000000189BAD940
    public void CreateMPLevelEntity(MPLevelEntityInfo mpLevelEntityInfo) { } // 0x00000001814EF010-0x00000001814EF4B0
                                                                             // [XID] // 0x0000000189BB5120-0x0000000189BB5140
    public void FinishLoadScene(uint token, bool isNewScene, bool isSceneGoto) { } // 0x00000001814E93E0-0x00000001814E9500
                                                                                   // [XID] // 0x0000000189BBC760-0x0000000189BBC780
    private void FinishLoadSceneReal(uint token, bool isNewScene, bool isSceneGoto) { } // 0x00000001814EE3D0-0x00000001814EE5A0
    [DebuggerHidden] // 0x0000000189BC4360-0x0000000189BC43A0
                     // [XID] // 0x0000000189BC4360-0x0000000189BC43A0
    private IEnumerator FinishLoadSceneAynsc(uint token, bool isNewScene, bool isSceneGoto) => default; // 0x00000001814EE0D0-0x00000001814EE1F0
                                                                                                        // [XID] // 0x0000000189BCEE60-0x0000000189BCEE80
    public void PostInitFinish(uint token) { } // 0x00000001814EA270-0x00000001814EA9B0
                                               // [XID] // 0x0000000189BD6240-0x0000000189BD6260
    private void InitWorldShift(bool isNewScene) { } // 0x00000001814EF710-0x00000001814EFA00
                                                     // [XID] // 0x0000000189BDDD60-0x0000000189BDDD80
    private void InitCamera(bool isNewScene) { } // 0x00000001814E8D10-0x00000001814E8E60
                                                 // [XID] // 0x00000001895EAA30-0x00000001895EAA50
    private bool IsLevelReconnect(uint token) => default; // 0x00000001814E7DA0-0x00000001814E7EF0
                                                          // [IDTag] // 0x00000001895F1E30-0x00000001895F1E70
                                                          // [XID] // 0x00000001895F1E30-0x00000001895F1E70
    public void LoadingLevelProgress(LoadState state, float progress = 1f /* Metadata: 0x00AFD05E */) { } // 0x00000001814ED810-0x00000001814EDDE0
                                                                                                          // [XID] // 0x00000001895FC650-0x00000001895FC670
    private void OnLoadAllEffectsProgress(float x) { } // 0x00000001814E87F0-0x00000001814E88B0
                                                       // [XID] // 0x0000000189603FD0-0x0000000189603FF0
    private void OnLoadCommonEffectsProgress(float x) { } // 0x00000001814EBF70-0x00000001814EC040
                                                          // [XID] // 0x000000018960B930-0x000000018960B950
    private void OnLoadIconsProgress(float x) { } // 0x00000001814EB140-0x00000001814EB210
                                                  // [XID] // 0x0000000189612EC0-0x0000000189612EE0
    private void OnLoadUIProgress(float x) { } // 0x00000001814F1230-0x00000001814F1300
                                               // [IDTag] // 0x000000018961A620-0x000000018961A660
                                               // [XID] // 0x000000018961A620-0x000000018961A660
    private void LoadingLevelProgress(SECTR_Manager.ProgressType loadType, float progress) { } // 0x00000001814ED740-0x00000001814ED810
                                                                                               // [XID] // 0x0000000189624AB0-0x0000000189624AD0
    private void DetermineSliceFrameBeforeCreateModuleInLevelManager() { } // 0x00000001814EED10-0x00000001814EEF50
                                                                           // [XID] // 0x000000018962C210-0x000000018962C230
    private void CreateInLevelManagers() { } // 0x00000001814ECC30-0x00000001814ECEE0
                                             // [XID] // 0x0000000189633D90-0x0000000189633DB0
    private void DestroyInLevelManagers() { } // 0x00000001814E88B0-0x00000001814E8B60
                                              // [XID] // 0x000000018963B550-0x000000018963B570
    private void ClearLevelCache() { } // 0x00000001814EB210-0x00000001814EB2D0
                                       // [XID] // 0x0000000189642DE0-0x0000000189642E00
    public void RequestTransmit(ref TransmitRequest request) { } // 0x00000001814EAEC0-0x00000001814EAFF0
                                                                 // [XID] // 0x000000018964A490-0x000000018964A4B0
    private void ClearTransmitRequest() { } // 0x00000001814E9500-0x00000001814E95B0
                                            // [XID] // 0x0000000189AE2AA0-0x0000000189AE2AC0
    public void HandleTransmitRequest() { } // 0x00000001814EFDB0-0x00000001814F0040
                                            // [XID] // 0x0000000189659410-0x0000000189659430
    private void ShowPopPages() { } // 0x00000001814F0DE0-0x00000001814F0FE0
                                    // [XID] // 0x0000000189660A90-0x0000000189660AB0
    public override void BeforeUpdateSchedule() { } // 0x00000001814E8060-0x00000001814E82C0
                                                    // [XID] // 0x00000001896684A0-0x00000001896684C0
    public override void UpdateSchedule() { } // 0x00000001814EC2F0-0x00000001814EC980
                                              // [XID] // 0x000000018966FF50-0x000000018966FF70
    public override void AfterUpdateSchedule() { } // 0x00000001814E8B60-0x00000001814E8D10
                                                   // [XID] // 0x0000000189677860-0x0000000189677880
    public override void EndUpdateSchedule() { } // 0x00000001814EFA00-0x00000001814EFB50
                                                 // [XID] // 0x000000018967ED60-0x000000018967ED80
    public override void BeforeLateUpdatePreSchedule() { } // 0x00000001814ED580-0x00000001814ED740
                                                           // [XID] // 0x0000000189686690-0x00000001896866B0
    public override void LateUpdatePreSchedule() { } // 0x00000001814EE5A0-0x00000001814EE6A0
                                                     // [XID] // 0x000000018968E470-0x000000018968E490
    public override void AfterLateUpdatePreSchedule() { } // 0x00000001814F0FE0-0x00000001814F10E0
                                                          // [XID] // 0x0000000189695D90-0x0000000189695DB0
    public override void BeforeLateUpdatePostSchedule() { } // 0x00000001814E86A0-0x00000001814E87F0
                                                            // [XID] // 0x000000018969D500-0x000000018969D520
    public override void LateUpdatePostSchedule() { } // 0x00000001814EA0C0-0x00000001814EA1C0
                                                      // [XID] // 0x00000001896A4540-0x00000001896A4560
    public override void AfterLateUpdatePostSchedule() { } // 0x00000001814EBC80-0x00000001814EBF70
                                                           // [XID] // 0x00000001896ABD30-0x00000001896ABD50
    public override void EndLateUpdatePostSchedule() { } // 0x00000001814E9C20-0x00000001814E9D90
    private void __iFixBaseProxy_BeforeUpdateSchedule() { } // 0x00000001814EA060-0x00000001814EA0C0
    private void __iFixBaseProxy_UpdateSchedule() { } // 0x00000001814E9E80-0x00000001814E9EE0
    private void __iFixBaseProxy_AfterUpdateSchedule() { } // 0x00000001814F0040-0x00000001814F00A0
    private void __iFixBaseProxy_EndUpdateSchedule() { } // 0x00000001814EFB50-0x00000001814EFBB0
    private void __iFixBaseProxy_BeforeLateUpdatePreSchedule() { } // 0x00000001814ECEE0-0x00000001814ECF40
    private void __iFixBaseProxy_LateUpdatePreSchedule() { } // 0x00000001814F0980-0x00000001814F09E0
    private void __iFixBaseProxy_AfterLateUpdatePreSchedule() { } // 0x00000001814F0D80-0x00000001814F0DE0
    private void __iFixBaseProxy_BeforeLateUpdatePostSchedule() { } // 0x00000001814EFC90-0x00000001814EFCF0
    private void __iFixBaseProxy_LateUpdatePostSchedule() { } // 0x00000001814ED470-0x00000001814ED4D0
    private void __iFixBaseProxy_AfterLateUpdatePostSchedule() { } // 0x00000001814E8370-0x00000001814E83D0
    private void __iFixBaseProxy_EndLateUpdatePostSchedule() { } // 0x00000001814EE070-0x00000001814EE0D0
}
