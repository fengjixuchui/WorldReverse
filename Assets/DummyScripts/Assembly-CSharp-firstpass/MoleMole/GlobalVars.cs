/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;
using UnityEngine.Scripting;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
	public static class GlobalVars // TypeDefIndex: 10548
	{
		// Fields
		public static bool checkEntityPreloadOverTime; // 0x00
		public static bool onEntityReadyDelay; // 0x01
		public static bool lockScene; // 0x02
		public static bool entityReadyAnimatorPause; // 0x03
		public static bool entityReadyRenderEnable; // 0x04
		public static bool reUseEntityUseLightDeActive; // 0x05
		public static bool forceSkipCutscene; // 0x06
		public static bool netpacketUsejobThread; // 0x07
		public static bool protoUseThreadSerialized; // 0x08
		public static bool useUnionPacket; // 0x09
		public static bool multithreadUseObjectPool; // 0x0A
		public static bool configUseObjectPool; // 0x0B
		public static bool useLightDeactiveMonoBehaviour; // 0x0C
		public static bool useEntityGameObjectPool; // 0x0D
		public static bool useActionToken; // 0x0E
		public static bool useAbilitySystem; // 0x0F
		public static bool useAbilitySystemAsync; // 0x10
		public static bool useAbilitySystemNetworkSimulation; // 0x11
		public static bool useLightweightGrassWater; // 0x12
		public static bool useDestroyEntityFraming; // 0x13
		public static int useMessageObjectPoolType; // 0x14
		public static bool checkMessageToGC; // 0x18
		public static bool useMessageReference; // 0x19
		public static bool reportProtoDeserializeError; // 0x1A
		public static bool resetMessageInDeallocate; // 0x1B
		public static bool useClearInLevelJob; // 0x1C
		public static bool useRemoteLiteHumanoidMove; // 0x1D
		public static bool fanCylinderAttackUseSphereCast; // 0x1E
		public static bool loadingUseSyncLoad; // 0x1F
		public const int DEFAULT_FRAME_RATE = 30; // Metadata: 0x00AE784C
		public const float IN_LEVEL_TIME_PER_FRAME = 0.033333335f; // Metadata: 0x00AE7850
		public const float RATIO2FLOAT = 0.01f; // Metadata: 0x00AE7854
		public const uint PROTO_NUM_SCALE = 100; // Metadata: 0x00AE7858
		public const string BUNDLE_IDENTIFIER = "com.miHoYo.hk4e"; // Metadata: 0x00AE785C
		public const string CURVERSION_FOLDER = "Dev"; // Metadata: 0x00AE786F
		public const string FPS_INDICATOR_PREFAB_PATH = "ART/UI/UIToolkits/FPSIndicator"; // Metadata: 0x00AE7876
		public const string MEMORY_INDICATOR_PREFAB_PATH = "ART/UI/UIToolkits/MemoryIndicator"; // Metadata: 0x00AE7898
		public const string GMTALK_PREFAB_PATH = "ART/UI/UIToolkits/GMTalk"; // Metadata: 0x00AE78BD
		public const string CONTAINER_PREFAB_PATH = "ART/UI/UIScene/SceneUISetup"; // Metadata: 0x00AE78D9
		public static bool loadingUseEntityASyncLoad; // 0x20
		public const string BORN_VIDEO_NAME = "MDAQ001_OPNew_Part1.usm"; // Metadata: 0x00AE78F8
		public const uint BORN_VIDEO_TEXT = 300009; // Metadata: 0x00AE7913
		public const string BORN_BOY_VIDEO_NAME = "MDAQ001_OPNew_Part2_PlayerBoy.usm"; // Metadata: 0x00AE7917
		public const uint BORN_BOY_VIDEO_TEXT = 300010; // Metadata: 0x00AE793C
		public const string BORN_Girl_VIDEO_NAME = "MDAQ001_OPNew_Part2_PlayerGirl.usm"; // Metadata: 0x00AE7940
		public const uint BORN_Girl_VIDEO_TEXT = 300011; // Metadata: 0x00AE7966
		public const string DEFAULT_RESOURCE_URL = "https://hk4estorage.mihoyo.com/bh4/GenshinDownloads/game_res/"; // Metadata: 0x00AE796A
		public const string DEFAULT_DATA_URL = "https://hk4estorage.mihoyo.com/bh4/GenshinDownloads/design_data/"; // Metadata: 0x00AE79AB
		public const string DEFAULT_SILENCE_DATA_URL = "https://hk4estorage.mihoyo.com/bh4/GenshinDownloads/design_data/"; // Metadata: 0x00AE79EF
		public const string OFFICIAL_WEBSITE_OVERSEA = "https://genshin.mihoyo.com"; // Metadata: 0x00AE7A33
		public static string DATA_URL; // 0x28
		public static string SILENCE_DATA_URL; // 0x30
		public static string BACKUP_DATA_URL; // 0x38
		public static string BACKUP_RESOURCE_URL; // 0x40
		public static string BACKUP_SILENCE_DATA_URL; // 0x48
		public static string FEEDBACK_URL; // 0x50
		public static string BULLETIN_URL; // 0x58
		public static string HANDBOOK_URL; // 0x60
		public static string COMMUNITY_URL; // 0x68
		public static string BIND_ACCOUNT_URL; // 0x70
		public static string PRIVACY_URL; // 0x78
		public static string DERIVATIVE_MALL_URL; // 0x80
		public static string EXCHANGE_CODE_URL; // 0x88
		public static string PERF_REPORT_CONFIG_URL; // 0x90
		public static string PERF_REPORT_RECORD_URL; // 0x98
		public static uint DATA_VERSION; // 0xA0
		public static uint SILENCE_DATA_VERSION; // 0xA4
		public static uint RESOURCE_VERSION_EX; // 0xA8
		public static string RESOURCE_VERSION_SIZE; // 0xB0
		public static string RESOURCE_URL; // 0xB8
		public static uint RESOURCE_VERSION; // 0xC0
		public static string RES_VERSION_SUFFIX; // 0xC8
		public static string RESOURCE_MD5; // 0xD0
		public static string NEXT_RESOURCE_URL; // 0xD8
		public static uint NEXT_RESOURCE_VERSION; // 0xE0
		public static string NEXT_RES_VERSION_SUFFIX; // 0xE8
		public static string NEXT_RESOURCE_MD5; // 0xF0
		public static string NEXT_SCRIPT_VERSION; // 0xF8
		public static string DATA_MD5; // 0x100
		public static string SILENCE_DATA_MD5; // 0x108
		public static string AREA_TYPE; // 0x110
		public static string DATA_VERSION_SUFFIX; // 0x118
		public static string SILENCE_DATA_VERSION_SUFFIX; // 0x120
		public static string BASE_SUFFIX; // 0x128
		public static bool IS_IOS_AUDIT; // 0x130
		public const string CSV_LINE_TOKEN = "\n"; // Metadata: 0x00AE7A51
		public const string CSV_MAC_LINE_TOKEN = "\r"; // Metadata: 0x00AE7A56
		public const string CSV_WORD_TOKEN = ";"; // Metadata: 0x00AE7A5B
		public const string CSV_WORD_TAB_TOKEN = "\t"; // Metadata: 0x00AE7A60
		public static List<int> coverSwitches; // 0x138
		public static List<int> codeSwitches; // 0x140
		public static bool moveInWater; // 0x148
		public static bool asyncLoadJsonConfig; // 0x149
		public static int asyncLoadExceptionalLongWaitTime; // 0x14C
		public static bool debugMenu; // 0x150
		public static bool debugLogEnabled; // 0x151
		public static List<int> debugLogSwitches; // 0x158
		public static int debugLogMask; // 0x160
		public static bool isAutoLogout; // 0x164
		public static bool DebugOpenLCAI; // 0x165
		public static bool DebugCloseStateId; // 0x166
		public static bool DebugAIProfilingEnable; // 0x167
		public static bool DebugAISkillDisabled; // 0x168
		public static bool DebugPlayerInvisible_On; // 0x169
		public static bool EditorControl; // 0x16A
		public static bool DebugAISkillLocked; // 0x16B
		public static bool DebugCutsceneInEditor; // 0x16C
		public static float DebugEnvironSkyTimeScale; // 0x170
		public static float DebugCloudHorizontalTimeScale; // 0x174
		public static float DebugCloudVerticalTimeScale; // 0x178
		public static uint DebugAISkillLockedId; // 0x17C
		public static bool DebugAIDiagnosisMode; // 0x180
		public static float time; // 0x184
		public static bool AvatarDebugInv; // 0x188
		public static bool MonsterDebugInv; // 0x189
		public static bool UsingEffectCache; // 0x18A
		public static bool SkillNoCD; // 0x18B
		public static bool InfiniteStamina; // 0x18C
		public static bool showMassiveEntity; // 0x18D
		public static bool showPathfDebug; // 0x18E
		public static bool dumpSyncLoad; // 0x18F
		public static bool dumpLoadingSyncLoad; // 0x190
		public static bool openAntiLuaObf; // 0x191
		public static bool skipLuaEnvReload; // 0x192
		public static bool CheckResChildName; // 0x193
		public static bool UseGameObjectPool; // 0x194
		public static bool UseLegacyGenericObjectPool; // 0x195
		public static int ObjectPoolSize; // 0x198
		public static bool UseObjectPool; // 0x19C
		public static bool UseConfigIDCacheEntity; // 0x19D
		public static int GameObjectPoolSize; // 0x1A0
		public static bool cacheEntityLightDeActive; // 0x1A4
		public static bool StreamingUseGameObjectPool; // 0x1A5
		public static bool BillBoardUseGameObjectPool; // 0x1A6
		public static bool UIUseCache; // 0x1A7
		public static float WorldShiftDistance; // 0x1A8
		public static bool DebugJoypadUIModulePrint; // 0x1AC
		public static bool enableMobileJoystickSwitch; // 0x1AD
		public static bool enableTokenForceEnqueue; // 0x1AE
		public static int scenePropCacheCount; // 0x1B0
		public static bool muteDamageText; // 0x1B4
		public static bool forcePhysicsSimulateBetweenUpdate; // 0x1B5
		public static bool checkAvatarSpecialBoneNames; // 0x1B6
		public static StoragePool globalStoragePool; // 0x1B8
		public static string p4Version; // 0x1C0
		public static string p4DataVersion; // 0x1C8
		public static string p4SilenceDataVersion; // 0x1D0
		public static string engineP4VersionTxt; // 0x1D8
		public static string channelConfigFileName; // 0x1E0
		public static string channelConfigBlkName; // 0x1E8
		public static bool DebugEnableEventLog; // 0x1F0
		public static bool DebugAvatarNoHitLog; // 0x1F1
		public static bool DebugShowAttackShape; // 0x1F2
		public static bool DebugAttackPatternList; // 0x1F3
		public static bool DebugNoAttackEffect; // 0x1F4
		public static bool DebugShowColiderBox; // 0x1F5
		public static bool enableSubThread; // 0x1F6
		public static bool enableForceStreaming; // 0x1F7
		public static bool enableMall; // 0x1F8
		public static bool enableMallPay; // 0x1F9
		public static int getProductListRetryTimes; // 0x1FC
		public static bool disableIOSDownload; // 0x200
		public static bool enableIOSBGM; // 0x201
		public static bool disableQRCode; // 0x202
		public static bool StatFlagGlobal; // 0x203
		public static bool StatFlagUser; // 0x204
		public static bool StatFlagAI; // 0x205
		public static int netClientType; // 0x208
		public static float loginQueuingTime; // 0x20C
		public static bool loadInjectfixOnServerStop; // 0x210
		public static bool downloadPackageOnServerStop; // 0x211
		public static bool mtpEnable; // 0x212
		public static bool debugAlwaysSpawnMonoPatternChair; // 0x213
		public static bool debugChecksumPass; // 0x214
		public static string debugChecksumValSuccess; // 0x218
		public static string debugChecksumValFail; // 0x220
		public static bool defaultDeactiveAfterInstantiate; // 0x228
		public static ulong lastLoadingFinishTimeStamp; // 0x230
		public static bool DebugAttackResultLog; // 0x238
		public static bool showAvatarListInCharacterPage; // 0x239
		public static string debugRemoteUid; // 0x240
		public static uint debugSquadLeaderUid; // 0x248
		public static string debugUserId; // 0x250
		public static string debugDeviceId; // 0x258
		public static int debugEntityPauseLevel; // 0x260
		public static bool useEntityTickFunctionArray; // 0x264
		public static int totalEntityTickTokenDefault; // 0x268
		public static int totalEntityTickToken; // 0x26C
		public static int significanceTaskThreadLOD; // 0x270
		public static bool shouldAmortizedTickMassiveEntity; // 0x274
		public static float amortizedTickMassiveEntityBudget; // 0x278
		public static bool enableOverrideEntityTickStrategy; // 0x27C
		public static float nearVisibleEntityHighPriorityDistSqr; // 0x280
		public static bool disableAvatarSyncBalanceTickAnimatorTickState; // 0x284
		public static bool useLegacyHasOtherPlayerArround; // 0x285
		public static bool showElementReactionText; // 0x286
		public static int disableNPC; // 0x288
		public static bool fastLoadingMode; // 0x28C
		public static bool preinstantiateEffects; // 0x28D
		public static bool removeEntityLightDeActive; // 0x28E
		public static bool forcePreloadAllEffects; // 0x28F
		public const EffectPoolRemoveStrategy CommonEffectPoolRemoveStrategy = EffectPoolRemoveStrategy.NeverRemove; // Metadata: 0x00AE7A65
		public const EffectPoolRemoveStrategy EntityEffectPoolRemoveStrategy = EffectPoolRemoveStrategy.DelayRemove; // Metadata: 0x00AE7A69
		public static bool forcePreloadAllIcons; // 0x290
		public static bool forcePreloadEssentialIcons; // 0x291
		public static bool forcePreloadUIContexts; // 0x292
		public const float platformWatchScale = 0.5f; // Metadata: 0x00AE7A6D
		public static bool dumpSliceFrameManager; // 0x293
		public static float dumpSliceFrameManagerInterval; // 0x294
		public static bool objectPoolCheckRepeat; // 0x298
		public static bool npcFaceUseLOD2; // 0x299
		public static float sharedSliceFrameGameSystemTime; // 0x29C
		public static float resourcesManagerAssetJobMaxTime; // 0x2A0
		public static float resourcesManagerInstantiateMaxTime; // 0x2A4
		public static float resourcesManagerUnloadMinTime; // 0x2A8
		public static float resourcesManagerUnloadMaxTime; // 0x2AC
		public static float resourcesManagerInstantiateJobTime; // 0x2B0
		public static float levelAppearDisappearTimeMSDefault; // 0x2B4
		public static float levelAppearDisappearTimeMS; // 0x2B8
		public static int levelAppearDisappearWRRWeight; // 0x2BC
		public static float InitComponentCommonSlicingTimeDefault; // 0x2C0
		public static float InitComponentCommonSlicingTime; // 0x2C4
		public static float removeEntityTimeMSDefault; // 0x2C8
		public static float removeEntityTimeMS; // 0x2CC
		public static int removeEnityWRRWeight; // 0x2D0
		public static int sectrWRRWeightDefault; // 0x2D4
		public static int sectrWRRWeight; // 0x2D8
		public static float timerManagerTimeMS; // 0x2DC
		public static float networkManagerTimeMS; // 0x2E0
		public static float entityCreationTimeMSDefault; // 0x2E4
		public static float entityCreationTimeMS; // 0x2E8
		public static bool useCoalescedTimer; // 0x2EC
		public static bool onlyManuallyCallAnimatorUpdateInLateUpdateStage; // 0x2ED
		public static bool shouldPauseAnimatorWhenPauseEntity; // 0x2EE
		public static bool shouldConsiderVisibleWhenRemotePlayerAround; // 0x2EF
		public const uint DEFAULT_SCENE_ID = 3; // Metadata: 0x00AE7A71
		public const float SERVER_ROI = 150f; // Metadata: 0x00AE7A75
		public static float enemyRange; // 0x2F0
		public static bool EnableGoogleEsc; // 0x2F4
		public static string buildBranch; // 0x2F8
		public static string ScriptVersion; // 0x300
		public static int VersionCode; // 0x308
		public static string EngineBranch; // 0x310
		public static string SDKEnv; // 0x318
		public static int regionDispatchBeginType; // 0x320
		public static bool AfterAgreement; // 0x324
		public static string DEBUG_SDKEnv; // 0x328
		public static bool PCLoginEnable; // 0x330
		public static bool ShowException; // 0x331
		public static bool enableEffect; // 0x332
		public static bool enableBillboard; // 0x333
		public static int DownloadMode; // 0x334
		public static int DownloadThreadNum; // 0x338
		public static bool IsTrackingIODev; // 0x33C
		public static bool IsAdjustSDKDev; // 0x33D
		public static bool IsOperationSDKClose; // 0x33E
		public static bool autoSceneQuery; // 0x33F
		public static bool useRagdoll; // 0x340
		public static bool usingRagdoll; // 0x341
		public static bool settingUseRagdoll; // 0x342
		public static bool useAvatarGrassDisplacement; // 0x343
		public static bool useOtherEnttiyGrassDisplacement; // 0x344
		public static bool useWindZoneGrassDisplacement; // 0x345
		public static bool useMihoyoVegetation; // 0x346
		public static bool useFBIK; // 0x347
		public static bool reuseGadget; // 0x348
		public static bool reuseMonster; // 0x349
		public static bool removeToBeRemoveListByRuntimeID; // 0x34A
		public static bool useTextureStreamingPriority; // 0x34B
		public static int preloadJobCountBeforeTextureStreamingNeedToWait; // 0x34C
		public static bool useDynamicBone; // 0x350
		public static int ps4EffectToken; // 0x354
		public static bool useLimitOptimization; // 0x358
		public static bool useFinalIK; // 0x359
		public static bool useHeadControl; // 0x35A
		public const float transpointMissTime = 3f; // Metadata: 0x00AE7A79
		public const float localEntityTime = 5f; // Metadata: 0x00AE7A7D
		public static float cachedEntityTime; // 0x35C
		public static float reusedEntityTime; // 0x360
		public static int windFlagMaxQualityLevel; // 0x364
		public static bool iOSTiShen; // 0x368
		private static bool _useEffectLOD; // 0x369
		private static bool _enableMainCameraEffectLOD; // 0x36A
		public static bool useMoveIK; // 0x36B
		public static bool useClimbIK; // 0x36C
		public static bool checkAbilityHash; // 0x36D
		public static int climbIKQualityLevel; // 0x370
		private static float[][] _climbIKHalfCycleRaycastDegrees; // 0x378
		public static bool enableAudioSurfaceMultiprobing; // 0x380
		public static bool enableAudioFocusAttenuation; // 0x381
		public static bool enableAudioOcclusionRacasts; // 0x382
		public static bool enableAudioListenerOutreachDetetion; // 0x383
		public static bool runAudioWorkerInJobThread; // 0x384
		public static bool loadBankDataFromConfig; // 0x385
		public static readonly MusicSystem musicSystem; // 0x388
		public static bool muteMonoAudioEvents; // 0x38C
		public static LangType LANG_TYPE; // 0x390
		public static float talkAngle; // 0x394
		public static bool enableAutoTalk; // 0x398
		public static PackageType packageType; // 0x39C
		public const int applicationId = 100001; // Metadata: 0x00AE7A81
		public const string reportApplicationName = "hk4e"; // Metadata: 0x00AE7A85
		public const string authKey = "mihoyo2020hk4e"; // Metadata: 0x00AE7A8D
		public const string reportUrl = "https://devlog-upload.mihoyo.com/client/event/dataUpload"; // Metadata: 0x00AE7A9F
		public static ulong serialNumber; // 0x3A0
		public static string registerCPS; // 0x3A8
		private static Dictionary<int, bool> _boolDict; // 0x3B0
		private static Dictionary<int, int> _intDict; // 0x3B8
		private static Dictionary<int, uint> _uintDict; // 0x3C0
		private static Dictionary<int, float> _floatDict; // 0x3C8
		private static Dictionary<int, double> _doubleDict; // 0x3D0
		private static Dictionary<int, Vector3> _vector3Dict; // 0x3D8
		private static Dictionary<int, object> _objectDict; // 0x3E0
		public static bool clientCreateNPC; // 0x3E8
		public static bool NPCDynamicAvoidanceAvatar; // 0x3E9
		public static bool psTrcEnableNetWork; // 0x3EA
		public static int psTrcChatRestriction; // 0x3EC
		public static int psTrcUgcRestriction; // 0x3F0
		public static bool isNpcActorUseLOD; // 0x3F4
		public static bool isEnablePerfReport; // 0x3F5
		public static bool isPerfReportValid; // 0x3F6
		public static float perfReportPercent; // 0x3F8
		public static HashSet<string> perfReportAccountWhitelist; // 0x400
		public static HashSet<string> perfReportAccountBlacklist; // 0x408
		public static HashSet<int> perfReportPlatformWhitelist; // 0x410
		public static HashSet<int> perfReportPlatformBlacklist; // 0x418
		public static bool HasGameLevelLoadFinished; // 0x420
		public static bool DisableAsyncLoad; // 0x421
		public static float debugSpeechBubbleInterval; // 0x424
		public static readonly bool exploreIndependentWithTeamSystem; // 0x428
		public static bool forceLuaPreloadEternal; // 0x429
		public static bool logEntityPreloadAssetName; // 0x42A
		public static bool reportLoadingTime; // 0x42B
		public static bool isFirstLoading; // 0x42C
		public static uint debugCareRewindMainQuestId; // 0x430
		public static bool dataHotfixCheckVersion; // 0x434
		public static bool lightningBoltUseMultiThread; // 0x435
		public static bool entityVisualReInitDefault; // 0x436
		public static bool useRagdollPool; // 0x437
		public static int ragdollCountLimit; // 0x438
		public static int ragdollPoolSize; // 0x43C
		public static int ragdollPoolSameIdSize; // 0x440
	
		// Properties
		public static string BASE_RES_VERSION_SUFFIX { /* [XID] */ /* 0x0000000189A7AEF0-0x0000000189A7AF10 */ get; } // 0x0000000189BEA960-0x0000000189BEAAD0 
		public static bool StatEnabled { /* [XID] */ /* 0x0000000189A82540-0x0000000189A82560 */ get; } // 0x0000000189BEABD0-0x0000000189BEACD0 
		public static bool StatEnabledAI { /* [XID] */ /* 0x0000000189A89DE0-0x0000000189A89E00 */ get; } // 0x0000000189BEAAD0-0x0000000189BEABD0 
		public static bool useEntityToken { /* [XID] */ /* 0x0000000189701580-0x00000001897015A0 */ get; } // 0x0000000189BEB1B0-0x0000000189BEB280 
		public static bool useEffectLOD { /* [XID] */ /* 0x00000001896686C0-0x00000001896686E0 */ get; /* [XID] */ /* 0x00000001896AB000-0x00000001896AB020 */ set; } // 0x0000000189BEB0E0-0x0000000189BEB1B0 0x0000000189BEB360-0x0000000189BEB440
		public static bool enableMainCameraEffectLOD { /* [XID] */ /* 0x0000000189AAF290-0x0000000189AAF2B0 */ get; /* [XID] */ /* 0x00000001896B2130-0x00000001896B2150 */ set; } // 0x0000000189BEAE30-0x0000000189BEAF00 0x0000000189BEB280-0x0000000189BEB360
		public static float[] climbIKHalfCycleRaycastDegrees { /* [XID] */ /* 0x00000001896C0F40-0x00000001896C0F60 */ get; } // 0x0000000189BEACD0-0x0000000189BEAE30 
		public static bool isEnableNetwork { /* [XID] */ /* 0x0000000189693AB0-0x0000000189693AD0 */ get; } // 0x0000000189BEAFA0-0x0000000189BEB040 
		public static bool isEnableChat { /* [XID] */ /* 0x000000018969AED0-0x000000018969AEF0 */ get; } // 0x0000000189BEAF00-0x0000000189BEAFA0 
		public static bool isEnableUgc { /* [XID] */ /* 0x00000001897AADE0-0x00000001897AAE00 */ get; } // 0x0000000189BEB040-0x0000000189BEB0E0 
	
		// Nested types
		public enum WorldType // TypeDefIndex: 10549
		{
			Invalid = -1,
			Login = 0,
			Home = 1,
			Level = 2,
			DevLevel = 3,
			BundleDownload = 4,
			LevelTestScene = 5,
			TestCutscene = 6,
			ScenicScanLevel = 7,
			TalkPreview = 8,
			ProfileEffects = 9,
			RagdollScene = 10,
			MoveTestScene = 11,
			PSPrepare = 12
		}
	
		public enum LevelSubType // TypeDefIndex: 10550
		{
			NormalLevel = 0,
			StreamingLevel = 1
		}
	
		public enum EffectPoolRemoveStrategy // TypeDefIndex: 10551
		{
			DelayRemove = 0,
			BudgetRemove = 1,
			NeverRemove = 2
		}
	
		public enum MusicSystem // TypeDefIndex: 10552
		{
			None = 0,
			Legacy = 1,
			Experimental = 2
		}
	
		public enum LangType // TypeDefIndex: 10553
		{
			NotInit = -1,
			Chinese = 0,
			English = 1,
			Vietnamese = 2,
			Thai = 3,
			French = 4,
			German = 5
		}
	
		public enum PackageType // TypeDefIndex: 10554
		{
			None = 0,
			Less = 1,
			Medium = 2,
			Full = 3
		}
	
		// Constructors
		static GlobalVars() {} // 0x0000000189BE8E80-0x0000000189BEA960
	
		// Methods
		// [XID] // 0x0000000189AB6BB0-0x0000000189AB6BD0
		private static void RefreshEffectLOD() {} // 0x0000000189BE7CF0-0x0000000189BE7DF0
		// [XID] // 0x0000000189AC6150-0x0000000189AC6170
		public static List<LangType> GetLangProvidedList() => default; // 0x0000000189BE78A0-0x0000000189BE7970
		// [XID] // 0x00000001896CFEB0-0x00000001896CFED0
		public static LangType SystemLanguageToLangType() => default; // 0x0000000189BE8C40-0x0000000189BE8E80
		// [XID] // 0x00000001896F06C0-0x00000001896F06E0
		public static string GetLangSuffix(LangType langType = LangType.NotInit /* Metadata: 0x00AE7848 */) => default; // 0x0000000189BE7970-0x0000000189BE7AA0
		// [XID] // 0x0000000189ADCE30-0x0000000189ADCE50
		public static string GetLangTag() => default; // 0x0000000189BE7AA0-0x0000000189BE7C60
		// [XID] // 0x0000000189AE46C0-0x0000000189AE46E0
		public static CultureInfo GetCultureInfo() => default; // 0x0000000189BE6850-0x0000000189BE6B60
		// [XID] // 0x0000000189AEBDD0-0x0000000189AEBDF0
		public static string GetAIHelpLang() => default; // 0x0000000189BE67B0-0x0000000189BE6850
		// [XID] // 0x0000000189AF3820-0x0000000189AF3840
		public static void InitMultiLang() {} // 0x0000000189BE7C60-0x0000000189BE7CF0
		[Preserve] // 0x0000000189AFB0A0-0x0000000189AFB0E0
		// [XID] // 0x0000000189AFB0A0-0x0000000189AFB0E0
		public static void SetGlobalBoolValue(string varFullName, bool value) {} // 0x0000000189BE7DF0-0x0000000189BE7EF0
		[Preserve] // 0x0000000189B053D0-0x0000000189B05410
		// [XID] // 0x0000000189B053D0-0x0000000189B05410
		public static bool GetGlobalBoolValue(string varFullName) => default; // 0x0000000189BE6B60-0x0000000189BE6C50
		[Preserve] // 0x0000000189B0FBB0-0x0000000189B0FBF0
		// [XID] // 0x0000000189B0FBB0-0x0000000189B0FBF0
		public static void SetGlobalIntValue(string varFullName, int value) {} // 0x0000000189BE80F0-0x0000000189BE81F0
		[Preserve] // 0x0000000189B19F60-0x0000000189B19FA0
		// [XID] // 0x0000000189B19F60-0x0000000189B19FA0
		public static int GetGlobalIntValue(string varFullName) => default; // 0x0000000189BE6E30-0x0000000189BE6F10
		[Preserve] // 0x0000000189B24680-0x0000000189B246C0
		// [XID] // 0x0000000189B24680-0x0000000189B246C0
		public static void SetGlobalUintValue(string varFullName, uint value) {} // 0x0000000189BE82F0-0x0000000189BE83F0
		[Preserve] // 0x0000000189B2E9A0-0x0000000189B2E9E0
		// [XID] // 0x0000000189B2E9A0-0x0000000189B2E9E0
		public static uint GetGlobalUIntValue(string varFullName) => default; // 0x0000000189BE7000-0x0000000189BE70E0
		[Preserve] // 0x0000000189B38F30-0x0000000189B38F70
		// [XID] // 0x0000000189B38F30-0x0000000189B38F70
		public static void SetGlobalFloatValue(string varFullName, float value) {} // 0x0000000189BE7FF0-0x0000000189BE80F0
		[Preserve] // 0x0000000189B43BD0-0x0000000189B43C10
		// [XID] // 0x0000000189B43BD0-0x0000000189B43C10
		public static float GetGlobalFloatValue(string varFullName) => default; // 0x0000000189BE6D40-0x0000000189BE6E30
		[Preserve] // 0x0000000189B4E430-0x0000000189B4E470
		// [XID] // 0x0000000189B4E430-0x0000000189B4E470
		public static void SetGlobalDoubleValue(string varFullName, double value) {} // 0x0000000189BE7EF0-0x0000000189BE7FF0
		[Preserve] // 0x0000000189B58E20-0x0000000189B58E60
		// [XID] // 0x0000000189B58E20-0x0000000189B58E60
		public static double GetGlobalDoubleValue(string varFullName) => default; // 0x0000000189BE6C50-0x0000000189BE6D40
		[Preserve] // 0x0000000189B63220-0x0000000189B63260
		// [XID] // 0x0000000189B63220-0x0000000189B63260
		public static void SetGlobalVector3Value(string varFullName, Vector3 value) {} // 0x0000000189BE83F0-0x0000000189BE8510
		[Preserve] // 0x0000000189B6D8D0-0x0000000189B6D910
		// [XID] // 0x0000000189B6D8D0-0x0000000189B6D910
		public static Vector3 GetGlobalVector3Value(string varFullName) => default; // 0x0000000189BE70E0-0x0000000189BE7210
		[Preserve] // 0x0000000189B77E20-0x0000000189B77E60
		// [XID] // 0x0000000189B77E20-0x0000000189B77E60
		public static void SetGlobalObjectValue(string varFullName, object value) {} // 0x0000000189BE81F0-0x0000000189BE82F0
		[Preserve] // 0x0000000189B82630-0x0000000189B82670
		// [XID] // 0x0000000189B82630-0x0000000189B82670
		public static object GetGlobalObjectValue(string varFullName) => default; // 0x0000000189BE6F10-0x0000000189BE7000
		[Preserve] // 0x0000000189B94090-0x0000000189B940A0
		private static void SetGlobalValue<T>(ref Dictionary<int, T> valueDict, string varFullName, T value) {}
		[Preserve] // 0x0000000189B94090-0x0000000189B940A0
		private static T GetGlobalValue<T>(Dictionary<int, T> valueDict, string varFullName) => default;
		[Preserve] // 0x0000000189B9B6B0-0x0000000189B9B6F0
		// [XID] // 0x0000000189B9B6B0-0x0000000189B9B6F0
		public static void SetInstanceBoolValue(string varFullName, object instance, bool value) {} // 0x0000000189BE8510-0x0000000189BE8610
		[Preserve] // 0x0000000189BA5C10-0x0000000189BA5C50
		// [XID] // 0x0000000189BA5C10-0x0000000189BA5C50
		public static bool GetInstanceBoolValue(string varFullName, object instance) => default; // 0x0000000189BE7210-0x0000000189BE72F0
		[Preserve] // 0x0000000189BAFC80-0x0000000189BAFCC0
		// [XID] // 0x0000000189BAFC80-0x0000000189BAFCC0
		public static void ClearInstanceBoolValue(string varFullName, object instance) {} // 0x0000000189BE6190-0x0000000189BE6270
		[Preserve] // 0x0000000189BBA340-0x0000000189BBA380
		// [XID] // 0x0000000189BBA340-0x0000000189BBA380
		public static void SetInstanceIntValue(string varFullName, object instance, int value) {} // 0x0000000189BE8810-0x0000000189BE8910
		[Preserve] // 0x0000000189BC5000-0x0000000189BC5040
		// [XID] // 0x0000000189BC5000-0x0000000189BC5040
		public static int GetInstanceIntValue(string varFullName, object instance) => default; // 0x0000000189BE74D0-0x0000000189BE75B0
		[Preserve] // 0x0000000189BCF9D0-0x0000000189BCFA10
		// [XID] // 0x0000000189BCF9D0-0x0000000189BCFA10
		public static void ClearInstanceIntValue(string varFullName, object instance) {} // 0x0000000189BE6430-0x0000000189BE6510
		[Preserve] // 0x0000000189BD9F50-0x0000000189BD9F90
		// [XID] // 0x0000000189BD9F50-0x0000000189BD9F90
		public static void SetInstanceUintValue(string varFullName, object instance, uint value) {} // 0x0000000189BE8A10-0x0000000189BE8B10
		[Preserve] // 0x00000001895E9C60-0x00000001895E9CA0
		// [XID] // 0x00000001895E9C60-0x00000001895E9CA0
		public static uint GetInstanceUintValue(string varFullName, object instance) => default; // 0x0000000189BE7690-0x0000000189BE7770
		[Preserve] // 0x00000001895F4410-0x00000001895F4450
		// [XID] // 0x00000001895F4410-0x00000001895F4450
		public static void ClearInstanceUintValue(string varFullName, object instance) {} // 0x0000000189BE65F0-0x0000000189BE66D0
		[Preserve] // 0x00000001895FE9B0-0x00000001895FE9F0
		// [XID] // 0x00000001895FE9B0-0x00000001895FE9F0
		public static void SetInstanceFloatValue(string varFullName, object instance, float value) {} // 0x0000000189BE8710-0x0000000189BE8810
		[Preserve] // 0x00000001896094E0-0x0000000189609520
		// [XID] // 0x00000001896094E0-0x0000000189609520
		public static float GetInstanceFloatValue(string varFullName, object instance) => default; // 0x0000000189BE73E0-0x0000000189BE74D0
		[Preserve] // 0x0000000189613A80-0x0000000189613AC0
		// [XID] // 0x0000000189613A80-0x0000000189613AC0
		public static void ClearInstanceFloatValue(string varFullName, object instance) {} // 0x0000000189BE6350-0x0000000189BE6430
		[Preserve] // 0x000000018961E2A0-0x000000018961E2E0
		// [XID] // 0x000000018961E2A0-0x000000018961E2E0
		public static void SetInstanceDoubleValue(string varFullName, object instance, double value) {} // 0x0000000189BE8610-0x0000000189BE8710
		[Preserve] // 0x0000000189628820-0x0000000189628860
		// [XID] // 0x0000000189628820-0x0000000189628860
		public static double GetInstanceDoubleValue(string varFullName, object instance) => default; // 0x0000000189BE72F0-0x0000000189BE73E0
		[Preserve] // 0x00000001896330D0-0x0000000189633110
		// [XID] // 0x00000001896330D0-0x0000000189633110
		public static void ClearInstanceDoubleValue(string varFullName, object instance) {} // 0x0000000189BE6270-0x0000000189BE6350
		[Preserve] // 0x000000018963DB30-0x000000018963DB70
		// [XID] // 0x000000018963DB30-0x000000018963DB70
		public static void SetInstanceVector3Value(string varFullName, object instance, Vector3 value) {} // 0x0000000189BE8B10-0x0000000189BE8C40
		[Preserve] // 0x0000000189648140-0x0000000189648180
		// [XID] // 0x0000000189648140-0x0000000189648180
		public static Vector3 GetInstanceVector3Value(string varFullName, object instance) => default; // 0x0000000189BE7770-0x0000000189BE78A0
		[Preserve] // 0x00000001896527A0-0x00000001896527E0
		// [XID] // 0x00000001896527A0-0x00000001896527E0
		public static void ClearInstanceVector3Value(string varFullName, object instance) {} // 0x0000000189BE66D0-0x0000000189BE67B0
		[Preserve] // 0x000000018965D1C0-0x000000018965D200
		// [XID] // 0x000000018965D1C0-0x000000018965D200
		public static void SetInstanceObjectValue(string varFullName, object instance, object value) {} // 0x0000000189BE8910-0x0000000189BE8A10
		[Preserve] // 0x00000001896679A0-0x00000001896679E0
		// [XID] // 0x00000001896679A0-0x00000001896679E0
		public static object GetInstanceObjectValue(string varFullName, object instance) => default; // 0x0000000189BE75B0-0x0000000189BE7690
		[Preserve] // 0x00000001896725B0-0x00000001896725F0
		// [XID] // 0x00000001896725B0-0x00000001896725F0
		public static void ClearInstanceObjectValue(string varFullName, object instance) {} // 0x0000000189BE6510-0x0000000189BE65F0
		[Preserve] // 0x0000000189B94090-0x0000000189B940A0
		private static void SetInstanceValue<T>(string varFullName, object instance, T value) {}
		[Preserve] // 0x0000000189B94090-0x0000000189B940A0
		private static T GetInstanceValue<T>(string varFullName, object instance) => default;
		[Preserve] // 0x0000000189B94090-0x0000000189B940A0
		private static void ClearInstanceValue<T>(string varFullName, object instance) {}
	}
}
