/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security;
using System.Threading;
using IFix.Core;
using MiHoYo.SDK;
using miHoYoThread;
using miHoYoTools;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
    public class GameManager : MonoBehaviour // TypeDefIndex: 20729
    {
        // Fields
        public bool isDevLevel; // 0x18
        public bool workOffline; // 0x19
        [NonSerialized]
        public bool isOnlineMode; // 0x1A
        private bool isUnloadResource; // 0x1B
        public static GameManager Instance; // 0x00
        protected GameWorld _curGameWorld; // 0x20
        private bool _shouldForceFinishObjectPoolWarmUp; // 0x28
        private int _lastFixedUpdateFrameCount; // 0x2C
        private bool _isToGoBackHome; // 0x30
        private bool _isToGoBundleDownload; // 0x31
        private GameObject _memoryIndicator; // 0x38
        private uint _memoryHandler; // 0x40
        public const string MEMORY_INDICATOR_PREFAB_PATH = "ART/UI/UIToolkits/MemoryIndicator"; // Metadata: 0x00AFE1EA
        private ulong pauseApplicationTime; // 0x48
        private Coroutine _setAndroidResolution; // 0x50
        private SchedulerMgr _schedulerMgr; // 0x58
        private SchedulerGlobalMgr _schedulerGlobalMgr; // 0x60

        // Properties
        public bool isToGoBackHome { /* [XID] */ /* 0x000000018962DC50-0x000000018962DC70 */ get => default; } // 0x0000000181F86B50-0x0000000181F86BF0 
        public bool isToGoBundleDownload { /* [XID] */ /* 0x0000000189635850-0x0000000189635870 */ get => default; } // 0x0000000181F86BF0-0x0000000181F86C90 
        public SchedulerMgr schedulerMgr { /* [XID] */ /* 0x0000000189735650-0x0000000189735670 */ get => default; } // 0x0000000181F86D30-0x0000000181F86DD0 
        public SchedulerGlobalMgr schedulerGlobalMgr { /* [XID] */ /* 0x000000018973D230-0x000000018973D250 */ get => default; } // 0x0000000181F86C90-0x0000000181F86D30 

        // Constructors
        public GameManager() { } // 0x0000000181F86AC0-0x0000000181F86B50
        static GameManager() { } // 0x0000000181F86A60-0x0000000181F86AC0

        // Methods
        // [XID] // 0x00000001895EA8C0-0x00000001895EA8E0
        public GameWorld GetCurGameWorld() => default; // 0x0000000181F83C30-0x0000000181F83CD0
                                                       // [XID] // 0x00000001895F1DD0-0x00000001895F1DF0
        private void Awake()
        {
            ObjectPoolUtility.isMainThread = true;
            CultureInfo cultureInfo = new CultureInfo("zh-CN");
            string currentCulture = Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator;
            string defaultCulture = cultureInfo.NumberFormat.CurrencyDecimalSeparator;
            if (currentCulture.CompareTo(defaultCulture) == 0)
            {
                SuperDebug.VeryImportantError("CurrentCulture is Invalid:" + cultureInfo.Name + " " + cultureInfo.NumberFormat.ToString(), ErrorLevel.Medium, ErrorCategory.Level, " ");
                Thread.CurrentThread.CurrentCulture = cultureInfo;
            }
            WatchDog.Start();
            Miscs.SetUnloadCPUVertexDataForSkinnedMesh(false);
            if (Miscs.IsCloudGame())
            {
                MiHoYoBaseSDK.SetCloudPlat(true);
            }
        } // 0x0000000181F81210-0x0000000181F81570
          // [XID] // 0x00000001895F9710-0x00000001895F9730
        private void Start()
        {
            InitObjectPool();
            Screen.sleepTimeout = -1;
            InitGame();

            // 控制台相关 先忽视
            InitObfuscatorTranslation();
            BaseEntity.StartStatWatch();
            StatCommandBootstrap.RegisterCommands();
        } // 0x0000000181F864A0-0x0000000181F86590
          // [XID] // 0x0000000189600E40-0x0000000189600E60
        private void InitObjectPool()
        {
            ObjectPoolUtility.Init();
            SECTR_Utils.InitObjectPool();
            ObjectPoolWarmupNoGen.WarmupObjectPool();

            // 大得就尼玛离离离离离离离离离离离离离离离离离离离离离离谱 删了也能空池触发所以先忽略
            IEnumerator warmupCallback = default;
            if (GlobalVars.UseLegacyGenericObjectPool)
            {
                warmupCallback = ObjectPoolWarmup.WarmupObjectPoolLegacy(new Func<bool>(() => _shouldForceFinishObjectPoolWarmUp));
            }
            else
            {
                warmupCallback = ObjectPoolWarmup.WarmupObjectPool(new Func<bool>(() => _shouldForceFinishObjectPoolWarmUp));
            }
            StartCoroutine(warmupCallback);
        } // 0x0000000181F85E80-0x0000000181F86030
          // [XID] // 0x00000001896087B0-0x00000001896087D0
        private void FixedUpdate() { } // 0x0000000181F83750-0x0000000181F83810
                                       // [XID] // 0x000000018960FF90-0x000000018960FFB0
        private void Update()
        {
            if (Time.frameCount > _lastFixedUpdateFrameCount) Physics.SyncTransforms();
            BeforeUpdateSchedule();
            UpdateSchedule();
            if (_curGameWorld != null) _curGameWorld.Tick();
            AfterUpdateSchedule();
            HandleStatDebugCommand();
        } // 0x0000000181F86950-0x0000000181F86A60
          // [XID] // 0x00000001896172F0-0x0000000189617310
        private void HandleStatDebugCommand() { } // 0x0000000181F82FB0-0x0000000181F83390
                                                  // [XID] // 0x000000018961EEE0-0x000000018961EF00
        private void LateUpdate() { } // 0x0000000181F849F0-0x0000000181F84B40
                                      // [XID] // 0x00000001896262A0-0x00000001896262C0
        private void OnApplicationQuit() { } // 0x0000000181F85B90-0x0000000181F85D90
                                             // [XID] // 0x00000001897E37F0-0x00000001897E3810
        public void TryGoBackHome() { } // 0x0000000181F866D0-0x0000000181F86810
                                        // [XID] // 0x0000000189644510-0x0000000189644530
        public void TryGoToBundleDownload() { } // 0x0000000181F86810-0x0000000181F86950
                                                // [XID] // 0x0000000189A0AD50-0x0000000189A0AD70
        private void GoToBundleDownload() { } // 0x0000000181F84640-0x0000000181F846E0
                                              // [XID] // 0x00000001897EB030-0x00000001897EB050
        private void GoBackHome() { } // 0x0000000181F83960-0x0000000181F83A00
                                      // [XID] // 0x000000018965ABF0-0x000000018965AC10
        public void GoBackHomeInternal() { } // 0x0000000181F83CD0-0x0000000181F84090
                                             // [XID] // 0x0000000189662080-0x00000001896620A0
        private void ClearOtherOnBackHome() { } // 0x0000000181F85D90-0x0000000181F85E80
                                                // [XID] // 0x0000000189669C80-0x0000000189669CA0
        public void ChangeGameWorld(GlobalVars.WorldType worldType, uint token = 0, string levelInfo = null, Action createNewWorldCallback = null, string overrideDefalutWeatherProfile = null)
        {
            ResourcesManager.QuietDownCallback action = () =>
            {
                ResourcesManager resourcesManager = Singleton<ResourcesManager>.Instance;
                if (resourcesManager.assetUpdated)
                {
                    CoroutineManager coroutineManager = Singleton<CoroutineManager>.Instance;
                    coroutineManager.StartCoroutine(resourcesManager.PreToLoadSceneIter(() =>
                    {
                        CreateNewGameWorld(worldType, token, levelInfo, overrideDefalutWeatherProfile);
                        if (createNewWorldCallback != null) createNewWorldCallback();
                        isUnloadResource = false;
                    }));
                }
                else
                {
                    CreateNewGameWorld(worldType, token, levelInfo, overrideDefalutWeatherProfile);
                    if (createNewWorldCallback != null) createNewWorldCallback();
                    isUnloadResource = false;
                }
                if (worldType == GlobalVars.WorldType.Home)
                {
                    ObjectPoolManager.ClearAllPool();
                }
            };
            if (!isUnloadResource)
            {
                UniqueString.Clear();
                SliceFrameManager.ClearAllWRRHandles();
                BaseEntity.ClearStats();
                _shouldForceFinishObjectPoolWarmUp = true;
                SchedulerConfigUtils.ClearOnLevelDestroy();
                ResourcesManager resourcesManager = Singleton<ResourcesManager>.Instance;
                resourcesManager.DropUnstartedLoads();
                resourcesManager.RegisterQuietDownCallback(action);
                DestroyCurLevel();
            }
        } // 0x0000000181F82360-0x0000000181F82830
          // [XID] // 0x0000000189671880-0x00000001896718A0
        public void DestroyCurLevel() { } // 0x0000000181F82C50-0x0000000181F82D90
                                          // [XID] // 0x0000000189679090-0x00000001896790B0
        private void ClearOtherOnLevelDestroy() { } // 0x0000000181F82D90-0x0000000181F82E80
                                                    // [XID] // 0x00000001896807B0-0x00000001896807D0
        public void HandleWrongDataVersion() { } // 0x0000000181F84210-0x0000000181F842F0
                                                 // [XID] // 0x0000000189688380-0x00000001896883A0
        public void ForceQuitApplication() { } // 0x0000000181F83810-0x0000000181F83960
                                               // [XID] // 0x000000018968FBC0-0x000000018968FBE0
        private void InitGame()
        {
            WebRequest.Create("http://localhost:19999").Abort();
            DontDestroyOnLoad(gameObject);
            LocalDataVersion.LoadFromFile();
            Singleton<MiHoYoGameData>.Create();
            Instance = this;
            /* 因为是单机版可以跳过
            FileIOUtil.CheckPackageType();
            PersistDirUtil.CheckClearResInPersistDir_BeforeCreateGlobalManager();
            FileIOUtil.CheckUnsavedNewRes();
            DownloadAliveKeeper.OnInit();
            */
            CreateGlobalManagers();
            //PersistDirUtil.CheckClearResInPersistDir_AfterCreateGlobalManager();
            InitEmbeddedData();
            Singleton<LocalizationManager>.Instance.ResetWindowTitle();
            ShowLogo();
            UnityEngine.Debug.LogFormat("InitGame end at {0}" + Time.realtimeSinceStartup);
        } // 0x0000000181F84FD0-0x0000000181F853B0
          // [XID] // 0x00000001896975C0-0x00000001896975E0
        public void BindPSNPStateChange() { } // 0x0000000181F81F00-0x0000000181F81FA0
                                              // [XID] // 0x000000018969EAF0-0x000000018969EB10
        private void OnPSNPStateChange(int userID, int state) { } // 0x0000000181F82830-0x0000000181F828F0
                                                                  // [XID] // 0x00000001896A5C60-0x00000001896A5C80
        public void StartHome() { } // 0x0000000181F86180-0x0000000181F863E0
                                    // [XID] // 0x00000001896AD350-0x00000001896AD370
        private void FirstChangeToHomeCallback() { } // 0x0000000181F828F0-0x0000000181F82AD0
                                                     // [XID] // 0x00000001896B4AB0-0x00000001896B4AD0
        private void InitEmbeddedData()
        {
            GlobalDataManager.InitEmbeddedData();
        } // 0x0000000181F84090-0x0000000181F84150
          // [XID] // 0x00000001896BBCC0-0x00000001896BBCE0
        public void ShowLogo() { } // 0x0000000181F86030-0x0000000181F86180
                                   // [XID] // 0x00000001896C3180-0x00000001896C31A0
        private void CreateNewGameWorld(GlobalVars.WorldType worldType, uint token, string levelInfo = null, string overloadDefaultWeatherProfile = null)
        {
            switch (worldType)
            {
                case GlobalVars.WorldType.BundleDownload:
                    _curGameWorld = new BundleDownload();
                    break;
                case GlobalVars.WorldType.Home:
                    _curGameWorld = new Home();
                    break;
                case GlobalVars.WorldType.Level:
                    _curGameWorld = new MPLevel();
                    break;
                case GlobalVars.WorldType.DevLevel:
                    _curGameWorld = new DevLevel();
                    break;
                case GlobalVars.WorldType.TestCutscene:
                    _curGameWorld = new TestCutscene();
                    (_curGameWorld as TestCutscene).InitScenePath("EmotionPreview");
                    break;
                case GlobalVars.WorldType.ProfileEffects:
                    _curGameWorld = new ProfileEffects();
                    break;
                case GlobalVars.WorldType.PSPrepare:
                    _curGameWorld = new PSPrepare();
                    break;
                case GlobalVars.WorldType.Login:
                    _curGameWorld = new Login();
                    break;
            }
            _curGameWorld.Init(token);
            _curGameWorld.worldType = worldType;
        } // 0x0000000181F84B40-0x0000000181F84FD0
          // [XID] // 0x00000001896CA690-0x00000001896CA6B0
        private void CreateGlobalManagers()
        {
            ManagerController.CreateGlobalManager<WorldShiftManager>();
            ManagerController.CreateGlobalManager<IFixManager>();
            ManagerController.CreateGlobalManager<TimerManager>();
            ManagerController.CreateGlobalManager<MEventMgr>();
            ManagerController.CreateGlobalManager<CoroutineManager>();
            ManagerController.CreateGlobalManager<ResourcesManager>();
            SchedulerConfigUtils.LoadScheduleConfig();
            SchedulerGlobalMgr.Create();
            SchedulerGlobalMgr.SwitchThread(GlobalVars.lockScene);
            SchedulerConfigUtils.StartConfigThreadTasks();
            ManagerController.CreateGlobalManager<NetworkManager>();
            ManagerController.CreateGlobalManager<LuaManager>();
            ManagerController.CreateGlobalManager<LuaShellManager>();
            ManagerController.CreateGlobalManager<ActorManager>();
            ManagerController.CreateGlobalManager<UIManager>();
            ManagerController.CreateGlobalManager<AudioManager>();
            ManagerController.CreateGlobalManager<NotifyManager>();
            ManagerController.CreateGlobalManager<CutsceneManager>();
            ManagerController.CreateGlobalManager<BagManager>();
            ManagerController.CreateGlobalManager<WidgetSystemManager>();
            ManagerController.CreateGlobalManager<StoreManager>();
            ManagerController.CreateGlobalManager<TipsManager>();
            ManagerController.CreateGlobalManager<DataItemManager>();
            ManagerController.CreateGlobalManager<SocketManager>();
            ManagerController.CreateGlobalManager<TeamManager>();
            ManagerController.CreateGlobalManager<WorldInfoManager>();
            ManagerController.CreateGlobalManager<QAManager>();
            ManagerController.CreateGlobalManager<InputManager>();
            ManagerController.CreateGlobalManager<LocalizationManager>();
            ManagerController.CreateGlobalManager<VideoManager>();
            ManagerController.CreateGlobalManager<BanManager>();
            ManagerController.CreateGlobalManager<GalleryManager>();
            ManagerController.CreateGlobalManager<ChatDataManager>();
            ManagerController.CreateGlobalManager<ChatResManager>();
            ManagerController.CreateGlobalManager<TextMapManager>();
            ManagerController.CreateGlobalManager<MiHoYoSDKManager>();
            ManagerController.CreateGlobalManager<BuriedPointReportManager>();
            ManagerController.CreateGlobalManager<OperationSDKManager>();
            ManagerController.CreateGlobalManager<SilenceDataManager>();
            ManagerController.CreateGlobalManager<BlackScreenManager>();
            ManagerController.CreateGlobalManager<NpcManager>();
            ManagerController.CreateGlobalManager<SocialManager>();
            ManagerController.CreateGlobalManager<DownloadSizeManager>();
            ManagerController.CreateGlobalManager<LoadingManager>();
            ManagerController.CreateGlobalManager<CoopManager>();
            ManagerController.CreateGlobalManager<CameraManager>();
            ManagerController.CreateGlobalManager<TheWorldLockManager>();
            ManagerController.CreateGlobalManager<MTRManager>();
            ManagerController.CreateGlobalManager<CustomEventManager>();
            ManagerController.CreateGlobalManager<SECTR_Manager>();
            /* 自定义引擎代码
            if (DeformationManager.IsDeformationEnabled())
            {
                ManagerController.CreateGlobalManager<DeformationProfileManager>();
            }
            */
            var Inst = SchedulerGlobalMgr.Inst;
            Inst.Start();
            Inst.CheckStarted();
        } // 0x0000000181F81620-0x0000000181F81A50
          // [XID] // 0x00000001896D1D20-0x00000001896D1D40
        private void DestroyGlobalManagers() { } // 0x0000000181F81FA0-0x0000000181F82360
                                                 // [XID] // 0x00000001896D95B0-0x00000001896D95D0
        public void SwitchMemInfo() { } // 0x0000000181F86590-0x0000000181F866D0
                                        // [XID] // 0x00000001896E0D70-0x00000001896E0D90
        public void InstantiateMemoryIndicatorIfNecessary() { } // 0x0000000181F844D0-0x0000000181F84640
                                                                // [XID] // 0x00000001896E8020-0x00000001896E8040
        private void OnLoadedMemoryIndicator(ulong requestedPath, bool loadSucceeded, uint handle, GameObject prefab) { } // 0x0000000181F83390-0x0000000181F83570
                                                                                                                          // [XID] // 0x00000001896EF6C0-0x00000001896EF6E0
        private void InitObfuscatorTranslation() { } // 0x0000000181F84150-0x0000000181F84210
                                                     // [XID] // 0x00000001896F6FD0-0x00000001896F6FF0
        private void OnApplicationPause(bool isPause) { } // 0x0000000181F857C0-0x0000000181F85B90
                                                          // [XID] // 0x00000001896FE940-0x00000001896FE960
        private void ResolveAndroidResolution(bool isPause) { } // 0x0000000181F84890-0x0000000181F849F0
        [DebuggerHidden] // 0x0000000189705BE0-0x0000000189705C20
                         // [XID] // 0x0000000189705BE0-0x0000000189705C20
        private IEnumerator SetAndroidResolution(int attemptTimes, float interval = 0.5f /* Metadata: 0x00AFE1E6 */) => default; // 0x0000000181F82E80-0x0000000181F82FB0
                                                                                                                                 // [XID] // 0x00000001897105A0-0x00000001897105C0
        private void OnApplicationFocus(bool isFocus) { } // 0x0000000181F85480-0x0000000181F85700
                                                          // [XID] // 0x00000001897179C0-0x00000001897179E0
        private void OnApplicationPauseInBackground(bool isPause) { } // 0x0000000181F81DF0-0x0000000181F81F00
                                                                      // [XID] // 0x000000018971F450-0x000000018971F470
        public void OnApplicationPauseInBackgroundExternal(bool isPause) { } // 0x0000000181F85700-0x0000000181F857C0
                                                                             // [XID] // 0x0000000189726A80-0x0000000189726AA0
        private bool CheckPSTRC() => default; // 0x0000000181F80BF0-0x0000000181F80D00
                                              // [XID] // 0x000000018972DFB0-0x000000018972DFD0
        public void StartPSPrepare() { } // 0x0000000181F863E0-0x0000000181F864A0
                                         // [XID] // 0x0000000189744710-0x0000000189744730
        private void BeforeUpdateSchedule()
        {
            ResStat.Refresh();
            ObjectPoolNonGenericCluster.instance.Tick();
            Singleton<WorldShiftManager>.Instance.Tick();
            TimerManager.RefreshTime();
            BalanceTickUtility.OnFrameTick();
            _schedulerMgr = SchedulerMgr.Inst;
            _schedulerGlobalMgr = SchedulerGlobalMgr.Inst;
            SchedulerUtils.SchedulerWaitFlush(_schedulerMgr, SchedulerType.RENDER_TO_NEXT_BEFORE_NETWORK, false);
            SchedulerUtils.ScheduleGlobalBackground(_schedulerGlobalMgr);
            FlexibleSlice.RefreshDeltaTime();
            DelayRemoveManager.Tick();
            //Singleton<UnityEngine.Networking.NetworkManager>.Instance.StartHost();
            SchedulerUtils.ScheduleEntry(_schedulerMgr, SchedulerType.AFTER_NETWORK_TO_RENDER, false);
            Singleton<InputManager>.Instance.Tick();
            //Singleton<QAManager>.Instance.Tick();
            SchedulerUtils.SchedulerWaitFlush(_schedulerMgr, SchedulerType.RENDER_TO_NEXT_BEFORE_RES, false);
            Singleton<ResourcesManager>.Instance.Tick();
            SchedulerUtils.SchedulerWaitFlush(_schedulerMgr, SchedulerType.AFTER_RES_TO_UPDATE_END, false);
            //Singleton<SocketManager>.Instance.Tick();
            Singleton<LuaManager>.Instance.Tick();
            if (_curGameWorld != null) _curGameWorld.BeforeUpdateSchedule();
            Singleton<TimerManager>.Instance.Tick();
        } // 0x0000000181F80D60-0x0000000181F81210
          // [XID] // 0x000000018974C3D0-0x000000018974C3F0
        private void UpdateSchedule() { } // 0x0000000181F83A00-0x0000000181F83C30
                                          // [XID] // 0x0000000189753680-0x00000001897536A0
        private void AfterUpdateSchedule() { } // 0x0000000181F81AB0-0x0000000181F81DF0
                                               // [XID] // 0x000000018975AB80-0x000000018975ABA0
        private void BeforeLateUpdatePreSchedule() { } // 0x0000000181F842F0-0x0000000181F844D0
                                                       // [XID] // 0x00000001897626B0-0x00000001897626D0
        private void LateUpdatePreSchedule() { } // 0x0000000181F846E0-0x0000000181F84890
                                                 // [XID] // 0x0000000189769D30-0x0000000189769D50
        private void AfterLateUpdatePreSchedule() { } // 0x0000000181F853B0-0x0000000181F85480
                                                      // [XID] // 0x0000000189771320-0x0000000189771340
        private void BeforeLateUpdatePostSchedule() { } // 0x0000000181F81570-0x0000000181F81620
                                                        // [XID] // 0x0000000189778B80-0x0000000189778BA0
        private void LateUpdatePostSchedule() { } // 0x0000000181F82AD0-0x0000000181F82C50
                                                  // [XID] // 0x0000000189780120-0x0000000189780140
        private void AfterLateUpdatePostSchedule() { } // 0x0000000181F83570-0x0000000181F83750
    }
}
