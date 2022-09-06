/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using FullInspector;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using UniRx;
using UnityEngine;
using UnityEngine.Scripting;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x0000000189670B20-0x0000000189670B60
[TickWithFrameDeltaTime] // 0x0000000189670B20-0x0000000189670B60
public abstract class BaseEntity : IAmortizedTickEntity, IAutoAllocRecycle, IEventDispatcher<BaseEvent>, IPausableEntity, IActionTokenTarget, ITickBalanceObject // TypeDefIndex: 11645
{
    // Fields
    [InspectorCollapsedFoldout] // 0x000000018981F560-0x000000018981F570
    public ConfigEntity jsonConfig; // 0x10
    [InspectorCollapsedFoldout] // 0x000000018981F560-0x000000018981F570
    public EntityExcelConfig excelConfig; // 0x18
    public SimpleSafeUInt32 campID; // 0x34
    [ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
    protected bool _isDestroied; // 0x38
    [ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
    protected bool _isToBeRemoved; // 0x39
    [ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
    protected bool _isInCutscene; // 0x3A
    protected bool _isDontDestroyGameObject; // 0x3B
    protected string _alias; // 0x40
    public int order; // 0x48
    public bool isForceClientSynced; // 0x4C
    [ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
    protected ComponentManager _logicComponentManager; // 0x50
    [ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
    protected ComponentManager _visualComponentManager; // 0x58
    [ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
    protected bool _isInited; // 0x60
                              // [PooledField] // 0x0000000189757FB0-0x0000000189757FD0
    private Action<EvtEntityTimeScaleChange> _onLevelTimeScaleChange; // 0x68
                                                                      // [PooledField] // 0x0000000189757FB0-0x0000000189757FD0
    private Action _syncAnimatorSpeed; // 0x70
                                       // [PooledField] // 0x0000000189757FB0-0x0000000189757FD0
    private Action _onTimeScaleChangedByAbility; // 0x78
    protected EntityQueryIndex _queryIndex; // 0x80
    protected AbilityComponentProxy _abilityProxy; // 0x88
    protected TokenManager _tokenMgr; // 0x90
    [ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
    protected bool _isCleared; // 0x99
    private bool _hasAddedInitialComponents; // 0x9B
    private int _entityInitFrame; // 0x9C
    [ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
    protected bool _isEntityReady; // 0xA0
    public Action<BaseEntity> onComponentInitPostCallback; // 0xA8
    public Action<BaseEntity> onEntityReadyPreCallback; // 0xB0
    public Action<BaseEntity> onEntityReadyBeforePostCallback; // 0xB8
    private bool _IsTickable; // 0xC0
    public bool isLightInitializationEntity; // 0xC6
    [ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
    protected bool _isDestroying; // 0xC8
    public Action<BaseEntity> onDestroyCallback; // 0xD0
    [ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
    protected bool _isAlive; // 0xD8
    public Action<BaseEntity> onSetAliveFalseCallback; // 0xE0
    [ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
    protected bool _isActive; // 0xE8
    public Action<BaseEntity> preAnimatorInitUpdateCallback; // 0xF0
    private bool _needSetActiveOnEntityReady; // 0xF8
    private bool _setActiveOnEntityReady; // 0xF9
    public Action<BaseEntity, bool> onSetActiveCallback; // 0x100
    [ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
    private bool _withGameObjWhenSetActive; // 0x108
    [ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
    private bool _isLightActive; // 0x109
    [ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
    private bool _playDefault; // 0x10A
    [ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
    private bool _deepIfInactive; // 0x10B
    [ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
    private bool _forceSkipAnimatorUpdate; // 0x10C
    private bool _hasActiveInited; // 0x10D
    protected float _lastTimeScale; // 0x110
    [ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
    protected float _timeScale; // 0x114
    public bool ignoreLevelTimeScale; // 0x118
    protected FixedStack<float> _timeScaleStack; // 0x120
    private LCAbilityState _lcAblityState; // 0x128
    private uint _nextComponentID; // 0x130
    protected bool _isAuthority; // 0x138
    public uint authorityPeerId; // 0x13C
    public bool isAuthorityUseHost; // 0x140
    private Dictionary<int, int> _componentTags; // 0x148
    private List<ComponentTag> _componentTagsCache; // 0x150
    private HashList<BaseComponent> _componentsForEntityTickManager; // 0x158
    private float budgetValue; // 0x160
    private bool isAnimalBudget; // 0x164
    protected List<ComponentInitNotifyData> _notifyListOnComponentInit; // 0x170
    private bool _needSafeEntityInit; // 0x178
    private List<EntitySafeCmd> _entitySafeCmds; // 0x180
    private Vector3 _sharedPosition; // 0x188
    private Vector3 _sharedForward; // 0x194
    private MEventDispatcher _eventDispatcher; // 0x1A0
    public Func<bool> onShouldNoPause; // 0x1A8
    public Action<TickState, bool, bool> onAnimatorTickStateChange; // 0x1B0
    private HashList<IRenderable> _extraRenderers; // 0x1B8
    private HashSet<IRequestOwnerEntityNoPauseTask> _noPauseTaskRequests; // 0x1C0
    private bool _bDisableAnimatorInterleave; // 0x1C8
    private TickState _currentAnimatorTickState; // 0x1CC
    protected EntityTickBalanceProxy _tickBalanceProxy; // 0x1D0
    private bool isKinematicRigidbody; // 0x1D8
    public static bool alsoDisableRootMotionTickWhenPause; // 0x00
    public static bool alsoPropagateAnimatorTickState; // 0x01
    public static bool enablePauseRelatedAnimators; // 0x02
    public bool isInConfigIDReuseCache; // 0x1D9
    public const float MAX_DISABLE_TICK_DISTANCE = 10000000f; // Metadata: 0x00AEA41C
    private static bool _bAllowStat; // 0x03
    private static StatFrameData _frameData; // 0x08
    private static IEnumerator _currentStatFrameIter; // 0x100
    public ECPDebugInfo _edi; // 0x1E8
    public static ECPDebugInfo.EFilterEntityType lastFilterType; // 0x108
    public static TotalECPDebugInfo totalEdi; // 0x110
    public MMAField _frameTotalWithoutStatTickMS; // 0x298
    public MMAField _frameLogicTickMS; // 0x2C0
    private FrameTickTimeAccumulator _thisframeTickMS; // 0x2E8
    private static Stopwatch _gStopWatch; // 0x1E0
    public static double millisecondsOverTick; // 0x1E8
    private CycleStat _cycleStat; // 0x2F8
    private static Action<List<CycleStatLogNode>> _onGenerateEntityTickStatLog; // 0x1F0
    private static bool _bRequestClearHistroy; // 0x1F8
    public static CycleStat _gameTime; // 0x200
    public static CycleStat _cameraRender; // 0x208
    public static CycleStat _physicsTime; // 0x210
    public static CycleStat _animationTime; // 0x218
    public static CycleStat _coroutineFixedUpdate; // 0x220
    public static CycleStat _coroutineUpdate; // 0x228
    public static CycleStat _coroutineLateUpdate; // 0x230
    public static CycleStat _particleTime; // 0x238
    public static CycleStat _playerUpdateCanvasTime; // 0x240
    public static CycleStat _canvasManagerEmitOffScreenGeometryTime; // 0x248
    public static CycleStat _updateAllUpdateAllRenderersTime; // 0x250
    public static CycleStat _updateAllSkinnedMeshesTime; // 0x258
    public static CycleStat _aiUpdateTime; // 0x260
    public static CycleStat _tickModuleTotalTime; // 0x268
    public static CycleStat _overheadTime; // 0x270
    public static CycleStat _profilerTime; // 0x278
    public static double thisFrameECPStatingMillisecond; // 0x280
    public static double singleThreadEntitySingleTickStageAccumulatedTickTime; // 0x288
    public static CycleStatData _ecpProfilerDetailTime; // 0x290
    public static CycleStatData ECPInternalTick; // 0x308
    public static bool bInTickStage; // 0x380
    public static Queue<object> lastStatECPQueue; // 0x388
    private static List<CycleStat> _staticStatPool; // 0x390
    public const string GameplayTickModuleName = "EM_Gameplay"; // Metadata: 0x00AEA420
    private static bool _bPauseAnalyzeFrame; // 0x3A0
    private const string ANIMATOR_INSTANCE_SUFFIX = "(Instanced)"; // Metadata: 0x00AEA42F
    private const float ANIME_RESET_DELAY = 5f; // Metadata: 0x00AEA43E
    private const float FLUSH_ANIME_RESET_INTERVAL = 2f; // Metadata: 0x00AEA442
    public ConfigAnimator animatorConfig; // 0x300
    private AnimatorOverrideController _animatorOverrideController; // 0x308
    private int _lastSetOverrideAnimeFrame; // 0x310
    private AnimatorOverrideController _originAnimatorController; // 0x318
                                                                  // [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
    private Dictionary<string, AnimeLoadInfo> _curLoadedAnime; // 0x320
    private RecycledLinkedList<AnimeLoadInfo> _needFlushResetAnimes; // 0x328
    private int _curForceCacheFreeStyleId; // 0x330
    protected EntityTimerReceiver _animeRecycleTimer; // 0x338
    private Coroutine _checkAnimeLoadFinishCoroutine; // 0x340
    protected EntityPreloader _onCreatePreloader; // 0x348
    protected EntityPreloader _onCombatPreloader; // 0x350
    private uint _gameObjectResourceHandle; // 0x358
    private int _preloadIndex; // 0x35C
    protected GameObject _preLoadObject; // 0x360
    protected Action<BaseEntity> _jsonConfigLoadedCallback; // 0x368
    protected GameObject _offsetDummyObject; // 0x380
    protected GameObject _animatorObject; // 0x388
    protected bool _isForceDisableGameObjectPool; // 0x390
    protected MaterialGroup _defaultGroup; // 0x398
    protected MaterialGroup _instancedMaterialGroup; // 0x3A0
    private bool _forceUpdateRigidbodyRotationCurFrame; // 0x3C8
    private Rigidbody _mRigidbody; // 0x3D0
    private CollisionDetectionMode _defaultCollisionDetectionMode; // 0x3D8
    private CollisionDetectionMode _curCollisionDetectionMode; // 0x3DC
    protected Animator _animator; // 0x3E0
    protected bool _animatorCullModeExternal; // 0x3E8
    public Action<BaseEntity> finishLoadCallback; // 0x3F0
    [NonSerialized]
    [NotSerialized] // 0x0000000189845E90-0x0000000189845EA0
    public float cachedEntityDist; // 0x3F8
    [NonSerialized]
    [NotSerialized] // 0x0000000189845E90-0x0000000189845EA0
    public float localEntityDist; // 0x3FC
    [NonSerialized]
    [NotSerialized] // 0x0000000189845E90-0x0000000189845EA0
    public bool localEntityWithGO; // 0x400
    private bool _forceDontUseUpdateRigidbody; // 0x430
    private bool _useDummyPrefab; // 0x431
    private bool _createDummyGameObject; // 0x432
    private AsyncJob _loadJob; // 0x438
    protected WorldTimer _infoTimer; // 0x448
    protected EntityGameObjectNode _gameObjectNode; // 0x450
    protected bool _isGameObjectFromPool; // 0x458
    protected bool _isEntityAsyncLoad; // 0x459
    private float _curMass; // 0x45C
    private FixedFloatStack _massRatio; // 0x460
    private bool _enableSetPostiion; // 0x468
    private Vector3 _lastPosInParent; // 0x46C
    private int _isKinematicTrue; // 0x478
    protected bool _isActorHided; // 0x47C
    protected bool _isRoomHided; // 0x47D
    protected RuntimeAnimatorController _authorityRuntimeAnimatorController; // 0x480
    protected RuntimeAnimatorController _remoteRuntimeAnimatorController; // 0x488
    protected uint _authorityRuntimeAnimatorHandler; // 0x490
    protected uint _remoteRuntimeAnimatorHandler; // 0x494
                                                  // [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
    private Dictionary<int, bool> _boolPersistentParams; // 0x498
                                                         // [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
    private Dictionary<int, int> _intPersistentParams; // 0x4A0
                                                       // [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
    private Dictionary<int, float> _floatPersistentParams; // 0x4A8
    private List<Tuple<int, float, float, float, float>> _linearSmoothAnimatorFloats; // 0x4B0

    // Properties
    protected VCSyncAnimator _vcSyncAnimator { /* [XID] */ /* 0x00000001898A84A0-0x00000001898A84C0 */ get; } // 0x0000000182696BB0-0x0000000182696C60 
    public uint runtimeID { /* [XID] */ /* 0x000000018990A510-0x000000018990A550 */ get; /* [XID] */ /* 0x0000000189914E70-0x0000000189914EB0 */ set; } // 0x0000000182675E10-0x0000000182675E70 0x000000018267CA80-0x000000018267CAE0
    public uint preRuntimeID { /* [XID] */ /* 0x000000018991F5F0-0x000000018991F630 */ get; /* [XID] */ /* 0x0000000189929F40-0x0000000189929F80 */ protected set; } // 0x0000000182686BF0-0x0000000182686C50 0x000000018268CC50-0x000000018268CCB0
    public uint entityRefCountKey { /* [XID] */ /* 0x0000000189934340-0x0000000189934380 */ get; /* [XID] */ /* 0x000000018993ED80-0x000000018993EDC0 */ set; } // 0x0000000182693FE0-0x0000000182694040 0x00000001826A74B0-0x00000001826A7510
    [NotSerialized] // 0x0000000189845E90-0x0000000189845EA0
    public uint configID { /* [XID] */ /* 0x0000000189949450-0x0000000189949490 */ get; /* [XID] */ /* 0x00000001899538F0-0x0000000189953930 */ protected set; } // 0x0000000182682AD0-0x0000000182682B30 0x00000001826787C0-0x0000000182678820
    public uint questID { /* [XID] */ /* 0x000000018995E2B0-0x000000018995E2F0 */ get; /* [XID] */ /* 0x00000001899689D0-0x0000000189968A10 */ set; } // 0x00000001826A20B0-0x00000001826A2110 0x00000001826A1AC0-0x00000001826A1B20
    public bool IsInCutscene { /* [XID] */ /* 0x00000001897D1520-0x00000001897D1540 */ get; } // 0x0000000182681DB0-0x0000000182681E50 
    public string alias { /* [XID] */ /* 0x00000001899A0AD0-0x00000001899A0AF0 */ get; /* [XID] */ /* 0x0000000189999200-0x0000000189999220 */ set; } // 0x000000018268E9D0-0x000000018268EA70 0x0000000182697870-0x0000000182697920
    public EntityQueryIndex queryIndex { /* [XID] */ /* 0x00000001899BEBC0-0x00000001899BEBE0 */ get; } // 0x00000001826A24B0-0x00000001826A2560 
    public AbilityComponentProxy abilityProxy { /* [XID] */ /* 0x00000001899C6680-0x00000001899C66A0 */ get; } // 0x0000000182676140-0x00000001826761F0 
    public TokenManager tokenMgr { /* [XID] */ /* 0x00000001899CDB40-0x00000001899CDB60 */ get; } // 0x0000000182682B30-0x0000000182682BE0 
    public bool createDuringReconnectingSceneInitFinish { /* [XID] */ /* 0x00000001899F3160-0x00000001899F31A0 */ get; /* [XID] */ /* 0x00000001899FD530-0x00000001899FD570 */ set; } // 0x000000018268F420-0x000000018268F480 0x000000018267F2E0-0x000000018267F350
    public virtual EntityReuseType entityReuseType { /* [XID] */ /* 0x0000000189A718B0-0x0000000189A718D0 */ get; } // 0x00000001826A90D0-0x00000001826A9170 
    public bool checkRemoveifCached { /* [XID] */ /* 0x0000000189AB5080-0x0000000189AB50C0 */ get; /* [XID] */ /* 0x0000000189ABFAE0-0x0000000189ABFB20 */ set; } // 0x00000001826A4D10-0x00000001826A4D70 0x0000000182693880-0x00000001826938F0
    public bool isTickable { /* [XID] */ /* 0x0000000189B2BA60-0x0000000189B2BA80 */ get; /* [XID] */ /* 0x0000000189A7DD00-0x0000000189A7DD20 */ set; } // 0x00000001826AAC20-0x00000001826AACD0 0x0000000182678EA0-0x0000000182679220
    public bool forceTickVisualComMgrIfDisable { /* [XID] */ /* 0x0000000189B3AA20-0x0000000189B3AA60 */ get; /* [XID] */ /* 0x0000000189B45540-0x0000000189B45580 */ set; } // 0x00000001826986B0-0x0000000182698710 0x0000000182682BE0-0x0000000182682C50
    public bool logicHasAnyTickComponent { /* [XID] */ /* 0x0000000189B8AF00-0x0000000189B8AF40 */ get; /* [XID] */ /* 0x0000000189B95540-0x0000000189B95580 */ set; } // 0x00000001826870B0-0x0000000182687110 0x00000001826A2FE0-0x00000001826A3050
    public bool visualHasAnyTickComponent { /* [XID] */ /* 0x0000000189B9FAC0-0x0000000189B9FB00 */ get; /* [XID] */ /* 0x0000000189BAA1C0-0x0000000189BAA200 */ set; } // 0x000000018267C980-0x000000018267C9E0 0x000000018269EF70-0x000000018269EFE0
    public bool logicHasAnyLateTickComponent { /* [XID] */ /* 0x0000000189BB46F0-0x0000000189BB4730 */ get; /* [XID] */ /* 0x0000000189BBE950-0x0000000189BBE990 */ set; } // 0x0000000182696C60-0x0000000182696CC0 0x0000000182681F00-0x0000000182681F70
    public bool visualHasAnyLateTickComponent { /* [XID] */ /* 0x0000000189BC98F0-0x0000000189BC9930 */ get; /* [XID] */ /* 0x0000000189BD4190-0x0000000189BD41D0 */ set; } // 0x000000018269F0F0-0x000000018269F150 0x00000001826A6850-0x00000001826A68C0
    [NotSerialized] // 0x0000000189845E90-0x0000000189845EA0
    public bool canBeDestroied { /* [XID] */ /* 0x0000000189653FB0-0x0000000189653FF0 */ get; /* [XID] */ /* 0x000000018965E810-0x000000018965E850 */ protected set; } // 0x00000001826A46F0-0x00000001826A4750 0x00000001826A5150-0x00000001826A51C0
    public virtual bool LifeByOwnerLife { /* [XID] */ /* 0x00000001896C9B70-0x00000001896C9B90 */ get; /* [XID] */ /* 0x00000001896D1360-0x00000001896D1380 */ set; } // 0x0000000182694EF0-0x0000000182694F90 0x000000018268AB60-0x000000018268AC10
    public bool isAlive { /* [XID] */ /* 0x000000018975EC90-0x000000018975ECB0 */ get; /* [XID] */ /* 0x00000001897660D0-0x00000001897660F0 */ set; } // 0x0000000182683F50-0x0000000182684000 0x00000001826A8550-0x00000001826A86D0
    public bool duringSetComponentsEnabledOnSetActive { /* [XID] */ /* 0x00000001897B8DC0-0x00000001897B8E00 */ get; /* [XID] */ /* 0x00000001897C3C30-0x00000001897C3C70 */ private set; } // 0x0000000182699570-0x00000001826995D0 0x000000018267B120-0x000000018267B190
    public float TimeScale { /* [XID] */ /* 0x00000001897FE580-0x00000001897FE5A0 */ get; } // 0x000000018268B600-0x000000018268B6B0 
    public FixedStack<float> timeScaleStack { /* [XID] */ /* 0x00000001896F1910-0x00000001896F1930 */ get; } // 0x00000001826A67A0-0x00000001826A6850 
    public EntityType entityType { /* [XID] */ /* 0x0000000189844810-0x0000000189844850 */ get; /* [XID] */ /* 0x000000018984EC00-0x000000018984EC40 */ set; } // 0x0000000182687650-0x00000001826876B0 0x000000018267C5A0-0x000000018267C610
    public bool isMassivelyEntityType { /* [XID] */ /* 0x00000001898590B0-0x00000001898590D0 */ get; } // 0x00000001826A70C0-0x00000001826A7220 
    public virtual bool isAuthority { /* [XID] */ /* 0x0000000189860290-0x00000001898602B0 */ get; /* [XID] */ /* 0x00000001897C26E0-0x00000001897C2700 */ set; } // 0x0000000182677780-0x0000000182677830 0x0000000182691B70-0x0000000182691C20
    public float lastTickTime { get; /* [XID] */ /* 0x0000000189962E50-0x0000000189962E90 */ set; } // 0x00000001826936B0-0x0000000182693720 0x000000018269A9A0-0x000000018269AA10
    public virtual MassiveEntityProxy massiveEntityProxy { /* [XID] */ /* 0x0000000189A419A0-0x0000000189A419C0 */ get; } // 0x00000001826A09E0-0x00000001826A0A80 
    public MEventDispatcher EventDispatcher { /* [XID] */ /* 0x0000000189A48FD0-0x0000000189A48FF0 */ get; } // 0x000000018268F680-0x000000018268F730 
    public bool IsRecycled { /* [XID] */ /* 0x0000000189A508E0-0x0000000189A50900 */ get; } // 0x00000001826905F0-0x00000001826906A0 
    private int _noPauseTaskRequestCount { /* [XID] */ /* 0x0000000189A6E980-0x0000000189A6E9A0 */ get; } // 0x000000018268F850-0x000000018268F910 
    public int tickLOD { /* [XID] */ /* 0x0000000189AB9840-0x0000000189AB9860 */ get; } // 0x00000001826A7220-0x00000001826A72D0 
    public bool bCachedRendering { /* [XID] */ /* 0x000000018980D6C0-0x000000018980D6E0 */ get; } // 0x000000018269A640-0x000000018269A6F0 
    public bool bDisableAnimatorInterleave { /* [XID] */ /* 0x0000000189B4E4F0-0x0000000189B4E510 */ get; /* [XID] */ /* 0x0000000189ADFE20-0x0000000189ADFE40 */ set; } // 0x000000018269AE80-0x000000018269AF30 0x0000000182693950-0x0000000182693A10
    public TickState requestAnimatorTickStateComputeThread { /* [XID] */ /* 0x0000000189AE7480-0x0000000189AE74A0 */ get; } // 0x00000001826937C0-0x0000000182693880 
    public TickState currentAnimatorTickState { /* [XID] */ /* 0x0000000189AEF210-0x0000000189AEF230 */ get; } // 0x00000001826A55F0-0x00000001826A5690 
    [ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
    public EntityTickBalanceProxy tickBalanceProxy { /* [XID] */ /* 0x0000000189AF65C0-0x0000000189AF65E0 */ get; } // 0x00000001826862A0-0x0000000182686350 
    public bool bRequestPause { /* [XID] */ /* 0x0000000189B38E10-0x0000000189B38E30 */ get; } // 0x000000018267CCB0-0x000000018267CD60 
    public bool isInRuntimeIDReuseCache { /* [XID] */ /* 0x0000000189BDD170-0x0000000189BDD190 */ get; } // 0x0000000182690020-0x0000000182690100 
    private bool isInToBeRemoveList { /* [XID] */ /* 0x000000018986D960-0x000000018986D980 */ get; } // 0x0000000182699240-0x0000000182699320 
    private bool isInEntityMap { /* [XID] */ /* 0x000000018960F370-0x000000018960F390 */ get; } // 0x000000018268FE40-0x000000018268FF20 
    public int tickBalanceRemainder { /* [XID] */ /* 0x000000018962CF50-0x000000018962CF70 */ get; } // 0x00000001826AAD90-0x00000001826AAE50 
    public int tickInterval { /* [XID] */ /* 0x0000000189634B40-0x0000000189634B60 */ get; } // 0x00000001826AAE50-0x00000001826AAF10 
    public int requestTickInterval { /* [XID] */ /* 0x000000018963C240-0x000000018963C260 */ get; } // 0x00000001826AACD0-0x00000001826AAD90 
    public bool bIgnoreIntervalTick { /* [XID] */ /* 0x0000000189643920-0x0000000189643960 */ get; /* [XID] */ /* 0x000000018964E060-0x000000018964E0A0 */ set; } // 0x00000001826AA9D0-0x00000001826AAA30 0x00000001826AAF10-0x00000001826AAF80
    public int targetAtLeastTickLOD { get; /* [XID] */ /* 0x00000001896F18F0-0x00000001896F1910 */ set; } // 0x0000000182687430-0x0000000182687500
    public float _fullTickSqrMag { /* [XID] */ /* 0x0000000189B46C80-0x0000000189B46CC0 */ get; /* [XID] */ /* 0x000000018966A8B0-0x000000018966A8F0 */ private set; } // 0x0000000182684530-0x00000001826845A0 0x00000001826855C0-0x0000000182685630
    public float disableTickDistance { get; /* [XID] */ /* 0x00000001896755D0-0x00000001896755F0 */ set; } // 0x0000000182678C30-0x0000000182678D20
    public bool canBeTickBalanced { /* [XID] */ /* 0x0000000189985310-0x0000000189985330 */ get; } // 0x00000001826AAB00-0x00000001826AABC0 
    public int greaterToDisableInterval { get; /* [XID] */ /* 0x000000018968BEF0-0x000000018968BF30 */ set; } // 0x00000001826AABC0-0x00000001826AAC20 0x00000001826AAF80-0x00000001826AB0B0
    public virtual float balanceTickDeltaTime { /* [XID] */ /* 0x0000000189696B70-0x0000000189696B90 */ get; } // 0x00000001826AAA30-0x00000001826AAB00 
    public static bool bAllowStat { /* [XID] */ /* 0x00000001896B3D70-0x00000001896B3D90 */ get; } // 0x0000000182689240-0x0000000182689310 
    public static StatFrameData frameData { /* [XID] */ /* 0x000000018973CA50-0x000000018973CA70 */ get; } // 0x000000018269F980-0x000000018269FC20 
    public static long CycleTicks { /* [XID] */ /* 0x0000000189725F40-0x0000000189725F60 */ get; } // 0x00000001826A7AB0-0x00000001826A7B90 
    public CycleStat cycleStat { /* [XID] */ /* 0x000000018972D4D0-0x000000018972D4F0 */ get; } // 0x000000018267B9E0-0x000000018267BA90 
    public static bool bNeedDumpTickStatLog { /* [XID] */ /* 0x0000000189734BF0-0x0000000189734C10 */ get; } // 0x00000001826929D0-0x0000000182692AD0 
    public static bool bRequestClearHistory { /* [XID] */ /* 0x0000000189752C70-0x0000000189752C90 */ get; } // 0x0000000182683B00-0x0000000182683C00 
    public static bool bPauseAnalyzeFrame { /* [XID] */ /* 0x0000000189795CC0-0x0000000189795CE0 */ get; /* [XID] */ /* 0x000000018998A030-0x000000018998A050 */ set; } // 0x000000018269E940-0x000000018269EA10 0x00000001826A73E0-0x00000001826A74B0
    internal uint gameObjectResourceHandle { /* [XID] */ /* 0x0000000189929F20-0x0000000189929F40 */ get; } // 0x0000000182697F90-0x0000000182698030 
    public MonoVisualEntityTool visualEntityTool { /* [XID] */ /* 0x0000000189931670-0x00000001899316B0 */ get; /* [XID] */ /* 0x000000018993C090-0x000000018993C0D0 */ private set; } // 0x0000000182691C20-0x0000000182691C80 0x000000018269E6A0-0x000000018269E710
    public GameObject rootGameObject { /* [XID] */ /* 0x0000000189946450-0x0000000189946490 */ get; /* [XID] */ /* 0x0000000189950CF0-0x0000000189950D30 */ protected set; } // 0x00000001826938F0-0x0000000182693950 0x00000001826948B0-0x0000000182694920
    public bool isForceDisableGameObjectPool { /* [XID] */ /* 0x000000018995B170-0x000000018995B190 */ get; } // 0x000000018268FD80-0x000000018268FE40 
    public MaterialGroup defaultGroup { /* [XID] */ /* 0x0000000189962E30-0x0000000189962E50 */ get; } // 0x0000000182685F10-0x0000000182685FC0 
    public MaterialGroup instancedMaterialGroup { /* [XID] */ /* 0x00000001899CDCF0-0x00000001899CDD10 */ get; } // 0x0000000182686350-0x0000000182686400 
    public GameObject gameObject { /* [XID] */ /* 0x00000001899808A0-0x00000001899808E0 */ get; /* [XID] */ /* 0x000000018998B580-0x000000018998B5C0 */ protected set; } // 0x00000001826A8780-0x00000001826A87E0 0x00000001826A7950-0x00000001826A79C0
    public bool enableSyncFromTransform { /* [XID] */ /* 0x0000000189996020-0x0000000189996060 */ get; /* [XID] */ /* 0x00000001899A0A90-0x00000001899A0AD0 */ private set; } // 0x0000000182685310-0x0000000182685370 0x0000000182677710-0x0000000182677780
    public virtual Transform transform { /* [XID] */ /* 0x00000001899AB530-0x00000001899AB570 */ get; /* [XID] */ /* 0x00000001899B5A20-0x00000001899B5A60 */ protected set; } // 0x0000000182677A40-0x0000000182677AA0 0x000000018268CB20-0x000000018268CB90
    public Transform gameObjectParent { /* [XID] */ /* 0x00000001899C0330-0x00000001899C0370 */ get; /* [XID] */ /* 0x00000001899CAB80-0x00000001899CABC0 */ protected set; } // 0x0000000182693F80-0x0000000182693FE0 0x0000000182698900-0x0000000182698970
    internal Rigidbody rigidbody { /* [XID] */ /* 0x00000001899D5160-0x00000001899D5180 */ get; } // 0x0000000182681C50-0x0000000182681D00 
    private Rigidbody _rigidbody { /* [XID] */ /* 0x00000001899DC6C0-0x00000001899DC6E0 */ get; /* [XID] */ /* 0x00000001899E3FE0-0x00000001899E4000 */ set; } // 0x000000018267C060-0x000000018267C110 0x00000001826A8450-0x00000001826A8550
    internal Animator animator { /* [XID] */ /* 0x00000001899EB470-0x00000001899EB490 */ get; } // 0x000000018268E6D0-0x000000018268E780 
    public bool IsAnimatorCullModeExternal { /* [XID] */ /* 0x00000001899F3140-0x00000001899F3160 */ get; } // 0x00000001826A4850-0x00000001826A4900 
    [ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
    public bool isLoaded { /* [XID] */ /* 0x0000000189A019C0-0x0000000189A01A00 */ get; /* [XID] */ /* 0x0000000189A0C290-0x0000000189A0C2D0 */ protected set; } // 0x0000000182691230-0x0000000182691290 0x00000001826A68C0-0x00000001826A6930
    [NotSerialized] // 0x000000018999AFD0-0x000000018999B000
    [ShowInInspector] // 0x000000018999AFD0-0x000000018999B000
    public Vector3 initPos { /* [XID] */ /* 0x0000000189A167A0-0x0000000189A167E0 */ get; /* [XID] */ /* 0x0000000189A20DF0-0x0000000189A20E30 */ private set; } // 0x000000018268EA70-0x000000018268EAF0 0x0000000182691290-0x0000000182691310
    [NotSerialized] // 0x0000000189845E90-0x0000000189845EA0
    public Quaternion initRotation { /* [XID] */ /* 0x0000000189A2B100-0x0000000189A2B140 */ get; /* [XID] */ /* 0x0000000189A35A20-0x0000000189A35A60 */ private set; } // 0x000000018269CEE0-0x000000018269CF50 0x00000001826A5270-0x00000001826A52E0
    [NotSerialized] // 0x0000000189845E90-0x0000000189845EA0
    public float initUniformScale { /* [XID] */ /* 0x0000000189A40140-0x0000000189A40180 */ get; /* [XID] */ /* 0x0000000189A4A730-0x0000000189A4A770 */ private set; } // 0x00000001826A1560-0x00000001826A15D0 0x0000000182692810-0x0000000182692880
    public ulong prefabPathHash { /* [XID] */ /* 0x0000000189A55010-0x0000000189A55050 */ get; /* [XID] */ /* 0x0000000189A5FA30-0x0000000189A5FA70 */ private set; } // 0x0000000182690A90-0x0000000182690AF0 0x00000001826A4900-0x00000001826A4970
    public bool hasGameObject { /* [XID] */ /* 0x0000000189A97490-0x0000000189A974D0 */ get; /* [XID] */ /* 0x0000000189AA1740-0x0000000189AA1780 */ protected set; } // 0x00000001826761F0-0x0000000182676250 0x00000001826A0A80-0x00000001826A0AF0
    public bool isActorHided { /* [XID] */ /* 0x000000018965B970-0x000000018965B990 */ get; } // 0x0000000182691770-0x0000000182691820 
    public bool isRoomHided { /* [XID] */ /* 0x000000018966A890-0x000000018966A8B0 */ get; } // 0x0000000182690490-0x0000000182690540 

    // Events
    private static event DelegateOnAnalyzeFrame _onAnalyzeFrame;

    // Nested types
    public enum ReInitReason // TypeDefIndex: 11646
    {
        Default = 0,
        Appear = 1,
        Revive = 2,
        Reuse = 3
    }

    public enum ClearReason // TypeDefIndex: 11647
    {
        Invalid = 0,
        Miss = 1,
        Die = 2,
        Revive = 3,
        TalentRefresh = 4,
        OnDisable = 5,
        ReUse = 6
    }

    public struct ComponentInitNotifyData // TypeDefIndex: 11648
    {
        // Fields
        public System.Type compType; // 0x00
        public object compData; // 0x08

        // Constructors
        public ComponentInitNotifyData(System.Type compType, object compData)
        {
            this.compType = default;
            this.compData = default;
        } // 0x0000000183837F60-0x0000000183838000
    }

    public struct ECPDebugInfo // TypeDefIndex: 11649
    {
        // Fields
        public float lastToLocalDistanceXYZ; // 0x00
        public float lastToLocalDistanceXZ; // 0x04
        public bool bPause; // 0x08
        public int _count; // 0x0C
        public float _totalTime; // 0x10
        public float _tickTime; // 0x14
        public float tokenPriorityScore; // 0x18
        public int idealTickLOD; // 0x1C
        public float idealTokenBudget; // 0x20
        public int currentTickLOD; // 0x24
        public float currentTokenBudget; // 0x28
        public string debugName; // 0x30
        public BaseEntity owner; // 0x38
        public string categoryName; // 0x40
        public EFilterEntityType entityType; // 0x48
        public uint configID; // 0x4C
        public bool rtServerEntity; // 0x50
        public string rtEntityType; // 0x58
        public string rtCategory; // 0x60
        public float staticBudget; // 0x68
        public int componentCount; // 0x6C
        public int tickableComponentCount; // 0x70
        public int lateTickableComponentCount; // 0x74
        public int fixTickableComponentCount; // 0x78
        public int pluginCount; // 0x7C
        public int tickablePluginCount; // 0x80
        public int lateTickablePluginCount; // 0x84
        public int fixTickablePluginCount; // 0x88
        public int _gameObjectCount; // 0x8C
        public int _animatorCount; // 0x90
        public int _particleCount; // 0x94
        public int _renderCount; // 0x98
        public int _colliderCount; // 0x9C
        public int _rigidbodyCount; // 0xA0
        public string debugInfo; // 0xA8
        public static bool disableRightAlignment; // 0x00
        public const int STATMODE_Detail = 0; // Metadata: 0x00AEA483
        public const int STATMODE_Mean = 1; // Metadata: 0x00AEA487

        // Properties
        public bool hasCachedEntityComponentStat { /* [XID] */ /* 0x00000001898BD640-0x00000001898BD660 */ get => default; } // 0x0000000183830120-0x0000000183830220 
        public bool hasCachedEntityGOStat { /* [XID] */ /* 0x00000001898C4EE0-0x00000001898C4F00 */ get => default; } // 0x00000001838352A0-0x0000000183835390 
        public float instanceCount { /* [XID] */ /* 0x00000001898FB2D0-0x00000001898FB2F0 */ get => default; } // 0x0000000183835390-0x00000001838353A0 

        // Nested types
        public enum EFilterEntityType // TypeDefIndex: 11650
        {
            EFET_None = 0,
            EFET_Avatar = 1,
            EFET_Monster = 2,
            EFET_Animal = 3,
            EFET_NPC = 4,
            EFET_Other = 5
        }

        // Constructors
        public ECPDebugInfo(BaseEntity e) : this()
        {
            lastToLocalDistanceXYZ = default;
            lastToLocalDistanceXZ = default;
            bPause = default;
            _count = default;
            _totalTime = default;
            _tickTime = default;
            tokenPriorityScore = default;
            idealTickLOD = default;
            idealTokenBudget = default;
            currentTickLOD = default;
            currentTokenBudget = default;
            debugName = default;
            owner = default;
            categoryName = default;
            entityType = default;
            configID = default;
            rtServerEntity = default;
            rtEntityType = default;
            rtCategory = default;
            staticBudget = default;
            componentCount = default;
            tickableComponentCount = default;
            lateTickableComponentCount = default;
            fixTickableComponentCount = default;
            pluginCount = default;
            tickablePluginCount = default;
            lateTickablePluginCount = default;
            fixTickablePluginCount = default;
            _gameObjectCount = default;
            _animatorCount = default;
            _particleCount = default;
            _renderCount = default;
            _colliderCount = default;
            _rigidbodyCount = default;
            debugInfo = default;
        } // 0x0000000183836720-0x0000000183836750
        static ECPDebugInfo()
        {
            disableRightAlignment = default;
        } // 0x00000001838365B0-0x0000000183836720

        // Methods
        // [XID] // 0x00000001898CC3E0-0x00000001898CC400
        public static EFilterEntityType GetEntityType(BaseEntity inEntity) => default; // 0x00000001838302D0-0x0000000183830400
                                                                                       // [XID] // 0x00000001898D3D30-0x00000001898D3D50
        public void Init(BaseEntity e) { } // 0x0000000183830FC0-0x0000000183830FD0
                                           // [IDTag] // 0x00000001898DB4A0-0x00000001898DB4E0
                                           // [XID] // 0x00000001898DB4A0-0x00000001898DB4E0
        public static string RightAlignmentString(string inStr, int targetLength = 16 /* Metadata: 0x00AEA472 */, bool bAppendComma = true /* Metadata: 0x00AEA476 */) => default; // 0x0000000183830BE0-0x0000000183830D80
                                                                                                                                                                                   // [IDTag] // 0x00000001898E6390-0x00000001898E63D0
                                                                                                                                                                                   // [XID] // 0x00000001898E6390-0x00000001898E63D0
        public static string RightAlignmentString(float value, int targetLength = 16 /* Metadata: 0x00AEA477 */, bool bAppendComma = true /* Metadata: 0x00AEA47B */) => default; // 0x0000000183830D80-0x0000000183830FC0
                                                                                                                                                                                  // [IDTag] // 0x00000001898F0DC0-0x00000001898F0E00
                                                                                                                                                                                  // [XID] // 0x00000001898F0DC0-0x00000001898F0E00
        public static string RightAlignmentString(int value, int targetLength = 8 /* Metadata: 0x00AEA47C */, bool bAppendComma = true /* Metadata: 0x00AEA480 */) => default; // 0x0000000183830AD0-0x0000000183830BE0
                                                                                                                                                                               // [XID] // 0x0000000189902E80-0x0000000189902EA0
        public static string GenOneDecimalFloatStr(float inValue) => default; // 0x0000000183831BE0-0x0000000183831CD0
                                                                              // [XID] // 0x000000018990A4F0-0x000000018990A510
        public static string GenOneDecimalFloatCSVStr(float inValue, bool needAppendCommaPrefix = false /* Metadata: 0x00AEA481 */, bool needAppendCommaSuffix = false /* Metadata: 0x00AEA482 */) => default; // 0x00000001838316A0-0x0000000183831900
                                                                                                                                                                                                               // [XID] // 0x0000000189612420-0x0000000189612440
        public static float GenToLocalAvatarDistanceStr(BaseEntity e) => default; // 0x000000018382FD00-0x0000000183830040
                                                                                  // [XID] // 0x0000000189A310E0-0x0000000189A31100
        public static string ToCSVTitleStatID(int mode) => default; // 0x00000001838320A0-0x0000000183832910
                                                                    // [XID] // 0x0000000189920EF0-0x0000000189920F10
        public string ToCSVStringStatID(int mode) => default; // 0x0000000183834A00-0x0000000183834B70
                                                              // [XID] // 0x0000000189928910-0x0000000189928930
        public static string ToCSVTitleTickTime() => default; // 0x00000001838350A0-0x00000001838352A0
                                                              // [XID] // 0x0000000189A675E0-0x0000000189A67600
        public string ToCSVStringTickTime() => default; // 0x000000018382FCF0-0x000000018382FD00
                                                        // [XID] // 0x0000000189BDA010-0x0000000189BDA030
        public static string ToCSVTitleTokenBudget(int mode) => default; // 0x0000000183830740-0x0000000183830AD0
                                                                         // [XID] // 0x0000000189A56800-0x0000000189A56820
        public string ToCSVStringTokenBudget(int mode) => default; // 0x0000000183832D40-0x00000001838338E0
                                                                   // [XID] // 0x0000000189A402E0-0x0000000189A40300
        public static string ToCSVTitleEntityToken(int mode) => default; // 0x0000000183831E00-0x0000000183831FD0
                                                                         // [XID] // 0x000000018994DB80-0x000000018994DBA0
        public Vector3 GetPosition() => default; // 0x0000000183830710-0x0000000183830740
                                                 // [XID] // 0x0000000189A4F1F0-0x0000000189A4F210
        private static string ToGotoString(Vector3 vector) => default; // 0x0000000183831CD0-0x0000000183831E00
                                                                       // [XID] // 0x0000000189AB0BE0-0x0000000189AB0C00
        public string ToCSVStringEntityToken(int mode) => default; // 0x0000000183834210-0x0000000183834220
                                                                   // [XID] // 0x0000000189964270-0x0000000189964290
        public ECPDebugInfo RefreshMeanECPDebugInfo(bool needUnityObjectStatInfo) => default; // 0x00000001838338E0-0x0000000183833AF0
                                                                                              // [XID] // 0x00000001898BC3B0-0x00000001898BC3D0
        public static string GetCSVTitle() => default; // 0x0000000183830230-0x00000001838302D0
                                                       // [XID] // 0x00000001899733D0-0x00000001899733F0
        public string ToCSVString() => default; // 0x00000001838365A0-0x00000001838365B0
                                                // [XID] // 0x000000018997ACA0-0x000000018997ACC0
        public static string GetCSVTitleDetailMode() => default; // 0x0000000183834220-0x0000000183834A00
                                                                 // [XID] // 0x0000000189982630-0x0000000189982650
        public string ToCSVStringDetailMode() => default; // 0x0000000183832910-0x0000000183832D40
                                                          // [XID] // 0x0000000189989DD0-0x0000000189989DF0
        public static void DumpCSV(List<ECPDebugInfo> inList) { } // 0x0000000183831900-0x0000000183831BE0
                                                                  // [XID] // 0x00000001899916F0-0x0000000189991710
        public void ClearRuntimeInfo() { } // 0x0000000183831FD0-0x0000000183832090
                                           // [XID] // 0x00000001899991E0-0x0000000189999200
        private void MergeWithRuntimeInfo(ref ECPDebugInfo other) { } // 0x0000000183833AF0-0x0000000183834210
                                                                      // [XID] // 0x00000001899A0A70-0x00000001899A0A90
        public void ClearEntityComponentInfo() { } // 0x00000001838312C0-0x00000001838313E0
                                                   // [XID] // 0x00000001899A84E0-0x00000001899A8500
        private void MergeWithEntityComponentInfo(ref ECPDebugInfo other) { } // 0x0000000183835090-0x00000001838350A0
                                                                              // [XID] // 0x00000001899AFCB0-0x00000001899AFCD0
        public void ClearEntityGOInfo() { } // 0x0000000183832090-0x00000001838320A0
                                            // [XID] // 0x0000000189B605E0-0x0000000189B60600
        private void MergeWithEntityGOInfo(ref ECPDebugInfo other) { } // 0x0000000183830220-0x0000000183830230
                                                                       // [XID] // 0x00000001899BEBA0-0x00000001899BEBC0
        public void Clear() { } // 0x00000001838314B0-0x00000001838314C0
                                // [XID] // 0x00000001899C6660-0x00000001899C6680
        public void CollectInfoByComponentList(IEnumerable<BaseComponent> inCompList, EFilterEntityType inEntityType) { } // 0x000000018382FB70-0x000000018382FCF0
                                                                                                                          // [XID] // 0x0000000189866090-0x00000001898660B0
        public int CompareWithTickTime(ref ECPDebugInfo other) => default; // 0x00000001838313E0-0x00000001838314B0
                                                                           // [XID] // 0x00000001898416C0-0x00000001898416E0
        public static int EcpDebugInfoTickTimeComparer(ECPDebugInfo x, ECPDebugInfo y) => default; // 0x0000000183834B80-0x0000000183834D30
                                                                                                   // [XID] // 0x00000001899DC6A0-0x00000001899DC6C0
        public static int EcpDebugInfoTokenBudgetComparer(ECPDebugInfo x, ECPDebugInfo y) => default; // 0x00000001838353A0-0x00000001838365A0
                                                                                                      // [XID] // 0x00000001899E3FC0-0x00000001899E3FE0
        public static int EcpDebugInfoCountComparer(ECPDebugInfo x, ECPDebugInfo y) => default; // 0x0000000183830400-0x0000000183830710
                                                                                                // [XID] // 0x00000001899EB450-0x00000001899EB470
        public static int EcpDebugInfoComparerByCategoryNameOnly(ECPDebugInfo x, ECPDebugInfo y) => default; // 0x00000001838314C0-0x00000001838316A0
                                                                                                             // [XID] // 0x00000001899F3120-0x00000001899F3140
        public static void DumpLog(List<string> inList) { } // 0x0000000183831170-0x00000001838312C0
                                                            // [XID] // 0x00000001899FA7B0-0x00000001899FA7D0
        public void MergeWith(ref ECPDebugInfo other) { } // 0x0000000183834B70-0x0000000183834B80
                                                          // [XID] // 0x0000000189A019A0-0x0000000189A019C0
        public static string ParseByClone(string debugName) => default; // 0x0000000183834D30-0x0000000183834E00
                                                                        // [XID] // 0x0000000189A094B0-0x0000000189A094D0
        public static string ParseByUnderscore(string debugName) => default; // 0x0000000183834E00-0x0000000183835090
                                                                             // [XID] // 0x0000000189A109A0-0x0000000189A109C0
        public static string ParseBySpace(string debugName) => default; // 0x0000000183830FD0-0x0000000183831170
                                                                        // [XID] // 0x00000001898A1160-0x00000001898A1180
        public void FillCategoryName() { } // 0x0000000183830040-0x0000000183830120
    }

    public struct TotalECPDebugInfo // TypeDefIndex: 11651
    {
        // Fields
        public ECPDebugInfo _edi; // 0x00
        public int totalEntityCount; // 0xB0
        public int totalMassiveEntityCount; // 0xB4
        public float totalEntityBudget; // 0xB8
        public int EntityCount_Monster; // 0xBC
        public int EntityCount_Animal; // 0xC0
        public int EntityCount_NPC; // 0xC4
        public int totalAppliedModifiersCount; // 0xC8
        public int timerCount; // 0xCC
    }

    public struct ScopeStateEntityTickStage : IDisposable // TypeDefIndex: 11652
    {
        // Constructors
        public ScopeStateEntityTickStage(bool setInTickStage = true /* Metadata: 0x00AEA4A3 */) { } // 0x0000000183837EE0-0x0000000183837F60

        // Methods
        // [XID] // 0x0000000189A1F5D0-0x0000000189A1F5F0
        public void Dispose() { } // 0x0000000183837E40-0x0000000183837EE0
    }

    public struct ScopeStatEntityTickTime : IDisposable // TypeDefIndex: 11653
    {
        // Fields
        private long st; // 0x00
        private EntityManager.TickType tickType; // 0x08
        private BaseEntity entity; // 0x10

        // Constructors
        public ScopeStatEntityTickTime(BaseEntity inEntity, EntityManager.TickType inType)
        {
            st = default;
            tickType = default;
            entity = default;
        } // 0x000000018382F510-0x000000018382F670

        // Methods
        // [XID] // 0x0000000189829DD0-0x0000000189829DF0
        public void Dispose() { } // 0x000000018382F440-0x000000018382F510
    }

    public delegate void DelegateOnAnalyzeFrame(ref StatFrameData inFrameData); // TypeDefIndex: 11654; 0x0000000183837530-0x00000001838376C0

    public class AnimeLoadCallBackWrapper : AsyncJobProxy // TypeDefIndex: 11655
    {
        // Fields
        private Action<bool> _callBack; // 0x10

        // Constructors
        public AnimeLoadCallBackWrapper() { } // 0x00000001838384D0-0x0000000183838530

        // Methods
        // [XID] // 0x0000000189A2E0C0-0x0000000189A2E0E0
        public void Do(bool success) { } // 0x0000000183838000-0x00000001838380D0
                                         // [XID] // 0x0000000189657300-0x0000000189657320
        public void Add(Action<bool> callBack) { } // 0x00000001838383E0-0x00000001838384D0
                                                   // [XID] // 0x000000018964F970-0x000000018964F990
        public static AnimeLoadCallBackWrapper Get() => default; // 0x0000000183838290-0x0000000183838330
                                                                 // [XID] // 0x0000000189ABFDD0-0x0000000189ABFDF0
        public void Release() { } // 0x0000000183838330-0x00000001838383E0
                                  // [XID] // 0x0000000189A4BF90-0x0000000189A4BFB0
        public void Dismiss(object voucher) { } // 0x0000000183838190-0x0000000183838290
                                                // [XID] // 0x0000000189A65C60-0x0000000189A65C80
        public bool CheckVoucher(object voucher) => default; // 0x00000001838380D0-0x0000000183838190
    }

    public enum AnimeLoadState // TypeDefIndex: 11656
    {
        None = 0,
        Loading = 1,
        Loaded = 2
    }

    public class AnimeLoadInfo // TypeDefIndex: 11657
    {
        // Fields
        public string stateId; // 0x10
        public AsyncJob loadJob; // 0x18
        public AnimeLoadState loadState; // 0x28
        public uint handle; // 0x2C
        public AnimationClip clip; // 0x30
        public float recycleTime; // 0x38
        public RecycledLinkedList<AnimeLoadInfo> recycleListNode; // 0x40
        public Dictionary<IAnimeOverrideReason, AnimeLoadCallBackWrapper> loadReasonCallBackDic; // 0x48

        // Properties
        public bool isNoLoadReason { /* [XID] */ /* 0x0000000189A5AE00-0x0000000189A5AE20 */ get => default; } // 0x00000001838371E0-0x00000001838372A0 

        // Constructors
        public AnimeLoadInfo() { } // 0x0000000183837350-0x00000001838373F0

        // Methods
        // [XID] // 0x0000000189A62660-0x0000000189A62680
        public static AnimeLoadInfo Get(string stateId) => default; // 0x0000000183836A20-0x0000000183836AF0
                                                                    // [XID] // 0x0000000189AFDD50-0x0000000189AFDD70
        public void ResetRecyleInfo() { } // 0x00000001838372A0-0x0000000183837350
                                          // [XID] // 0x0000000189A71870-0x0000000189A71890
        public void Release() { } // 0x0000000183836DF0-0x00000001838370D0
                                  // [XID] // 0x0000000189A79330-0x0000000189A79350
        public void AddLoadReasonCallBack(IAnimeOverrideReason reason, Action<bool> callBack) { } // 0x00000001838368E0-0x0000000183836A20
                                                                                                  // [XID] // 0x0000000189A809A0-0x0000000189A809C0
        public AsyncJob AddLoadReasonCallBackWithJob(IAnimeOverrideReason reason, Action<bool> callBack) => default; // 0x0000000183836750-0x00000001838368E0
                                                                                                                     // [XID] // 0x0000000189A88460-0x0000000189A88480
        public void RemoveLoadReason(IAnimeOverrideReason reason) { } // 0x0000000183836CC0-0x0000000183836DF0
                                                                      // [XID] // 0x0000000189A8FE30-0x0000000189A8FE50
        public void OnLoadFinish(AnimationClip _clip, uint _handle) { } // 0x00000001838370D0-0x00000001838371E0
                                                                        // [XID] // 0x0000000189A97470-0x0000000189A97490
        public void DoLoadCallBack(bool success) { } // 0x0000000183836AF0-0x0000000183836CC0
    }

    private class MultiCallBackWrapper // TypeDefIndex: 11658
    {
        // Fields
        private int _leftCount; // 0x10
        private Action<bool> _realCallBack; // 0x18
        private bool _curRet; // 0x20
        private bool _isInited; // 0x21
        private uint _configId; // 0x24

        // Constructors
        public MultiCallBackWrapper() { } // 0x000000018382F320-0x000000018382F440

        // Methods
        // [XID] // 0x00000001896C72D0-0x00000001896C72F0
        public static MultiCallBackWrapper Get(int count, Action<bool> callBack, uint configId) => default; // 0x000000018382F0C0-0x000000018382F1C0
                                                                                                            // [XID] // 0x0000000189AA6220-0x0000000189AA6240
        public void AddCount(int count) { } // 0x000000018382F270-0x000000018382F320
                                            // [XID] // 0x00000001896CE8A0-0x00000001896CE8C0
        public void OnCallBack(bool success) { } // 0x000000018382EF50-0x000000018382F0C0
                                                 // [XID] // 0x0000000189A6D270-0x0000000189A6D290
        public void AbortOnce() { } // 0x000000018382EEB0-0x000000018382EF50
                                    // [XID] // 0x00000001896D5CA0-0x00000001896D5CC0
        public void Release() { } // 0x000000018382F1C0-0x000000018382F270
    }

    public struct AnimeOverrideForceCacheFreeStyleReason : IAnimeOverrideReason // TypeDefIndex: 11659
    {
        // Fields
        private int _freeStyleId; // 0x00

        // Constructors
        public AnimeOverrideForceCacheFreeStyleReason(int freeStyleId)
        {
            _freeStyleId = default;
        } // 0x000000018382EE50-0x000000018382EEB0

        // Methods
        // [XID] // 0x0000000189AC4670-0x0000000189AC4690
        public override bool Equals(object obj) => default; // 0x000000018382EC80-0x000000018382ED30
                                                            // [XID] // 0x0000000189AA19D0-0x0000000189AA19F0
        public override int GetHashCode() => default; // 0x000000018382ED30-0x000000018382EDE0
        private bool __iFixBaseProxy_Equals(object P0) => default; // 0x000000018382EDE0-0x000000018382EE50
        private int __iFixBaseProxy_GetHashCode() => default; // 0x000000018382EB80-0x000000018382EC80
    }

    public enum SetKinematicPriority // TypeDefIndex: 11660
    {
        Tick = 1,
        Init = 2,
        Loading = 4
    }

    // Constructors
    protected BaseEntity() { } // 0x00000001826AA6F0-0x00000001826AA9D0
    static BaseEntity() { } // 0x00000001826AA340-0x00000001826AA6F0

    // Methods
    private T InternalGetLogicComponent<T>(int metaTypeID)
        where T : LCBase => default;
    public T GetLogicComponentFromJobThread<T>(int metaTypeID)
        where T : LCBase => default;
    public T GetLogicComponent<T>(int metaTypeID)
        where T : LCBase => default;
    private T InternalGetVisualComponent<T>(int metaTypeID)
        where T : VCBase => default;
    public T GetVisualComponentFromJobThread<T>(int metaTypeID)
        where T : VCBase => default;
    public T GetVisualComponent<T>(int metaTypeID)
        where T : VCBase => default;
    // [XID] // 0x00000001898A0F10-0x00000001898A0F30
    public void RemoveComponentCache(BaseComponent component) { } // 0x0000000182691D70-0x0000000182691F80
    public T GetLogicCombatComponent<T>()
        where T : LCBaseCombat => default;
    public T GetVisualCombatComponent<T>()
        where T : VCBaseCombat => default;
    // [XID] // 0x00000001898B0070-0x00000001898B0090
    public LCAIBeta GetAIBetaComponent() => default; // 0x000000018268EAF0-0x000000018268EBA0
                                                     // [XID] // 0x00000001897F71E0-0x00000001897F7200
    public LCAbilityElement GetLogicAbilityElementComponent() => default; // 0x000000018269DB80-0x000000018269DC30
                                                                          // [XID] // 0x00000001898BED00-0x00000001898BED20
    public LCAbility GetAbilityComponent() => default; // 0x0000000182692CD0-0x0000000182692D80
    public T GetMoveComponent<T>()
        where T : VCBaseMove => default;
    // [XID] // 0x00000001898C6540-0x00000001898C6560
    public VCAnimatorEvent GetAnimEventComCache() => default; // 0x0000000182683400-0x00000001826834B0
                                                              // [XID] // 0x00000001898CDC10-0x00000001898CDC30
    public VCBaseModel GetModelComCache() => default; // 0x0000000182685830-0x00000001826858E0
                                                      // [XID] // 0x00000001898D5630-0x00000001898D5650
    public VCSyncAnimator GetSyncAnimatorComponent() => default; // 0x0000000182698E60-0x0000000182698F10
                                                                 // [XID] // 0x0000000189B423B0-0x0000000189B423D0
    public LCActor GetActorComCache() => default; // 0x0000000182695490-0x0000000182695540
                                                  // [XID] // 0x00000001899EB6F0-0x00000001899EB710
    public VCBaseAudio GetAudioCache() => default; // 0x00000001826A66F0-0x00000001826A67A0
                                                   // [XID] // 0x0000000189B3AC90-0x0000000189B3ACB0
    public LCBaseIntee GetInteeComCache() => default; // 0x000000018268C820-0x000000018268C8D0
                                                      // [XID] // 0x00000001898F3DC0-0x00000001898F3DE0
    public LCBaseInter GetInterComCache() => default; // 0x0000000182690540-0x00000001826905F0
                                                      // [XID] // 0x0000000189B516A0-0x0000000189B516C0
    public LCLevel GetLCLevelComponent() => default; // 0x00000001826839B0-0x0000000182683A60
                                                     // [XID] // 0x0000000189902EA0-0x0000000189902EC0
    public VCLevel GetVCLevelComponent() => default; // 0x000000018269A590-0x000000018269A640
                                                     // [XID] // 0x00000001899733F0-0x0000000189973410
    public virtual long GetScenePropID() => default; // 0x0000000182697C00-0x0000000182697CA0
                                                     // [XID] // 0x0000000189982650-0x0000000189982670
    public virtual void SetIsInCutscene(bool value) { } // 0x00000001826967C0-0x0000000182696870
                                                        // [XID] // 0x0000000189989DF0-0x0000000189989E10
    public virtual void SetIsInTalk(bool enable) { } // 0x00000001826A0B90-0x00000001826A0C40
                                                     // [XID] // 0x0000000189991710-0x0000000189991730
    public virtual bool IsInTalk() => default; // 0x0000000182683C00-0x0000000182683CA0
                                               // [XID] // 0x00000001899A8500-0x00000001899A8520
    public ComponentManager GetLogicComponentManager() => default; // 0x0000000182684FD0-0x0000000182685070
                                                                   // [XID] // 0x0000000189B798E0-0x0000000189B79900
    public ComponentManager GetVisualComponentManager() => default; // 0x0000000182687F80-0x0000000182688020
                                                                    // [XID] // 0x00000001899B7120-0x00000001899B7140
    public virtual EntityMultiPlayerExcelConfig GetMultiPlayerExcelConfig() => default; // 0x000000018268CCB0-0x000000018268CD50
                                                                                        // [XID] // 0x00000001899D5180-0x00000001899D51A0
    public virtual void OnPoolAllocated() { } // 0x00000001826A6D40-0x00000001826A6FD0
                                              // [XID] // 0x00000001899DC6E0-0x00000001899DC700
    protected virtual void AllocatedAbilityProxy() { } // 0x00000001826A3270-0x00000001826A3320
                                                       // [XID] // 0x00000001899E4000-0x00000001899E4020
    public virtual void OnBeforePoolRecycled() { } // 0x00000001826A6B50-0x00000001826A6D40
                                                   // [XID] // 0x00000001899EB490-0x00000001899EB4B0
    protected virtual void DeallocatedAbilityProxy() { } // 0x00000001826A15D0-0x00000001826A1680
                                                         // [IDTag] // 0x0000000189A07AA0-0x0000000189A07AE0
                                                         // [XID] // 0x0000000189A07AA0-0x0000000189A07AE0
    public virtual void Init(uint runtimeID, uint configID, string scriptDataPath = "" /* Metadata: 0x00AEA3A2 */) { } // 0x000000018268A4B0-0x000000018268A5A0
                                                                                                                       // [IDTag] // 0x0000000189A12320-0x0000000189A12360
                                                                                                                       // [XID] // 0x0000000189A12320-0x0000000189A12360
    public virtual void Init(uint runtimeID, uint configID, ulong scriptDataPathHash) { } // 0x000000018268A5A0-0x000000018268A690
                                                                                          // [IDTag] // 0x0000000189A1C470-0x0000000189A1C4B0
                                                                                          // [XID] // 0x0000000189A1C470-0x0000000189A1C4B0
    public virtual void Init(uint runtimeID, uint configID = 0 /* Metadata: 0x00AEA3A6 */) { } // 0x0000000182689E40-0x000000018268A4B0
                                                                                               // [XID] // 0x0000000189A26B10-0x0000000189A26B30
    public virtual void OnEntityCreated() { } // 0x0000000182692080-0x0000000182692120
                                              // [XID] // 0x0000000189A2E0E0-0x0000000189A2E100
    public virtual void OnEntityRemoved() { } // 0x00000001826964E0-0x0000000182696660
                                              // [XID] // 0x0000000189A35A60-0x0000000189A35A80
    protected virtual void InitAuthority() { } // 0x000000018268D1A0-0x000000018268D3B0
                                               // [XID] // 0x0000000189A3CFD0-0x0000000189A3CFF0
    private bool CheckOnlyClientForAuthority() => default; // 0x000000018269AA10-0x000000018269ABA0
                                                           // [XID] // 0x00000001899702C0-0x00000001899702E0
    public void ChangeAuthorityPeer(uint authorityPeerId) { } // 0x00000001826A3320-0x00000001826A3440
                                                              // [XID] // 0x00000001899A86A0-0x00000001899A86C0
    private void ChangeAuthorityEntityReadyPost(EvtEntityReadyPost e) { } // 0x00000001826998C0-0x0000000182699BD0
                                                                          // [XID] // 0x0000000189A536B0-0x0000000189A536D0
    protected virtual bool ChangeAuthority() => default; // 0x0000000182695A20-0x0000000182695B10
                                                         // [XID] // 0x0000000189943650-0x0000000189943670
    public bool IsRuntimeIDChanged() => default; // 0x0000000182679740-0x0000000182679860
                                                 // [XID] // 0x0000000189A62680-0x0000000189A626A0
    public void Retarget(uint newRuntimeID) { } // 0x000000018268F180-0x000000018268F420
                                                // [XID] // 0x0000000189AED630-0x0000000189AED650
    private void OnPostRetarget() { } // 0x00000001826858E0-0x0000000182685B60
                                      // [XID] // 0x0000000189A79350-0x0000000189A79370
    public virtual bool CanReuseEntity() => default; // 0x0000000182684BF0-0x0000000182684C90
                                                     // [XID] // 0x0000000189A809E0-0x0000000189A80A00
    private void ReinitTickProxy(ReInitReason reason) { } // 0x0000000182684DB0-0x0000000182684EA0
                                                          // [XID] // 0x0000000189A884A0-0x0000000189A884C0
    public virtual void ReInit(ReInitReason reason = ReInitReason.Default /* Metadata: 0x00AEA3AA */, bool runtimeIDChange = false /* Metadata: 0x00AEA3AE */) { } // 0x0000000182690100-0x0000000182690490
                                                                                                                                                                   // [XID] // 0x000000018961E4A0-0x000000018961E4C0
    public virtual void PostReInit() { } // 0x0000000182694AF0-0x0000000182694BD0
                                         // [XID] // 0x00000001898660F0-0x0000000189866110
    public bool IsCleared() => default; // 0x00000001826A3AD0-0x00000001826A3B80
                                        // [XID] // 0x0000000189A9E870-0x0000000189A9E890
    public virtual void Clear(ClearReason clearReason = ClearReason.Invalid /* Metadata: 0x00AEA3AF */) { } // 0x000000018268D770-0x000000018268D8E0
                                                                                                            // [XID] // 0x0000000189756050-0x0000000189756070
    public void RefreshComponentsEntityRuntimeId(uint entityId) { } // 0x0000000182689590-0x0000000182689660
                                                                    // [XID] // 0x0000000189B0FDA0-0x0000000189B0FDC0
    public bool IsNeedClearEntityReleation(ClearReason clearReason) => default; // 0x0000000182693520-0x00000001826935E0
                                                                                // [XID] // 0x0000000189ACA480-0x0000000189ACA4A0
    public virtual void OnClientConnect() { } // 0x0000000182693720-0x00000001826937C0
                                              // [XID] // 0x0000000189AD1F40-0x0000000189AD1F60
    public virtual void OnClientDisconnect() { } // 0x000000018268AAC0-0x000000018268AB60
                                                 // [XID] // 0x0000000189AD99D0-0x0000000189AD99F0
    public bool IsEntityReady() => default; // 0x00000001826A88F0-0x00000001826A89A0
                                            // [XID] // 0x00000001896259E0-0x0000000189625A00
    private void OnLevelTimeScaleChange(EvtEntityTimeScaleChange evt) { } // 0x00000001826A4C40-0x00000001826A4D10
                                                                          // [XID] // 0x0000000189AE8A70-0x0000000189AE8A90
    public void OnRegisteredToEntityManager() { } // 0x000000018267ADE0-0x000000018267AE90
                                                  // [XID] // 0x0000000189AF08E0-0x0000000189AF0900
    public void OnUnregisteredToEntityManagaer() { } // 0x000000018269A2E0-0x000000018269A390
                                                     // [XID] // 0x0000000189AF7E50-0x0000000189AF7E70
    public virtual bool ShouldCollectEntityToken() => default; // 0x00000001826765E0-0x0000000182676680
                                                               // [XID] // 0x0000000189AFF450-0x0000000189AFF470
    protected virtual void BindWithTickBalanceProxy(bool isStructureDirty, bool fromReady) { } // 0x00000001826958A0-0x0000000182695A20
                                                                                               // [XID] // 0x0000000189B06C10-0x0000000189B06C30
    public void OnVisionMiss() { } // 0x0000000182691600-0x00000001826916C0
                                   // [XID] // 0x0000000189B0E410-0x0000000189B0E430
    public bool GetBalanceTickReadyState(out bool isCulled, out float toAvatarDistance)
    {
        isCulled = default;
        toAvatarDistance = default;
        return default;
    } // 0x00000001826A2D40-0x00000001826A2E90
      // [XID] // 0x0000000189B155B0-0x0000000189B155D0
    public virtual bool ShouldSetTickableWhenEventsResolved() => default; // 0x0000000182689310-0x00000001826893B0
                                                                          // [XID] // 0x0000000189B1D030-0x0000000189B1D050
    public virtual void OnEntityReady() { } // 0x0000000182698280-0x00000001826986B0
                                            // [XID] // 0x0000000189B24600-0x0000000189B24620
    public void RegisterAbilityStateProperty() { } // 0x000000018269FF80-0x00000001826A0090
                                                   // [XID] // 0x0000000189B55B80-0x0000000189B55BA0
    private bool IsLevelReady() => default; // 0x000000018269AF30-0x000000018269B030
                                            // [XID] // 0x0000000189B57200-0x0000000189B57220
    public virtual bool ShouldTickComponents() => default; // 0x000000018269E5E0-0x000000018269E6A0
                                                           // [XID] // 0x0000000189B5D600-0x0000000189B5D620
    public bool HasComponentsToTick() => default; // 0x0000000182685E00-0x0000000182685F10
                                                  // [XID] // 0x0000000189B662A0-0x0000000189B662C0
    public virtual bool IsLevelReadyToExecuteTickFunctions() => default; // 0x0000000182696380-0x0000000182696430
                                                                         // [XID] // 0x0000000189B6D850-0x0000000189B6D870
    public bool BaseShouldTickComponents() => default; // 0x000000018269FC20-0x000000018269FCE0
                                                       // [XID] // 0x0000000189B74E30-0x0000000189B74E50
    public virtual bool ShouldLateTickComponents() => default; // 0x000000018268FA10-0x000000018268FAD0
                                                               // [XID] // 0x0000000189B7C370-0x0000000189B7C390
    public bool HasComponentsToLateTick() => default; // 0x0000000182698030-0x0000000182698140
                                                      // [XID] // 0x000000018987F630-0x000000018987F650
    protected bool BaseShouldLateTickComponents() => default; // 0x000000018268D5E0-0x000000018268D6A0
                                                              // [XID] // 0x0000000189BDEB00-0x0000000189BDEB20
    public void RefreshLogicHasAnyTickComponent() { } // 0x00000001826A5A30-0x00000001826A5B30
                                                      // [XID] // 0x0000000189BAFE80-0x0000000189BAFEA0
    public void RefreshVisualHasAnyTickComponent() { } // 0x0000000182691F80-0x0000000182692080
                                                       // [XID] // 0x00000001895F2960-0x00000001895F2980
    public void RefreshLogicHasAnyLateTickComponent() { } // 0x000000018268FF20-0x0000000182690020
                                                          // [XID] // 0x0000000189BA13A0-0x0000000189BA13C0
    public void RefreshVisualHasAnyLateTickComponent() { } // 0x00000001826A7F30-0x00000001826A8030
                                                           // [XID] // 0x000000018989CB60-0x000000018989CB80
    public void TickComponents(float inGameDeltaTime) { } // 0x00000001826A3B80-0x00000001826A3DD0
                                                          // [XID] // 0x0000000189609480-0x00000001896094A0
    public void LateTickComponents(float inGameDeltaTime) { } // 0x0000000182689A10-0x0000000182689C60
                                                              // [XID] // 0x0000000189852DF0-0x0000000189852E10
    public bool ShouldTickBeforeReady() => default; // 0x000000018268F5D0-0x000000018268F680
                                                    // [XID] // 0x000000018985AA50-0x000000018985AA70
    public void TickBeforeReady(int watch) { } // 0x000000018267FA50-0x00000001826801B0
                                               // [XID] // 0x000000018961FB90-0x000000018961FBB0
    public bool HasComponentsToBeAdded() => default; // 0x0000000182685070-0x00000001826851B0
                                                     // [XID] // 0x0000000189626ED0-0x0000000189626EF0
    public bool ShouldTickBeforeComponents() => default; // 0x000000018269C850-0x000000018269C910
                                                         // [XID] // 0x000000018962E840-0x000000018962E860
    public void TickBeforeComponents() { } // 0x00000001826A7510-0x00000001826A7800
                                           // [XID] // 0x00000001896364C0-0x00000001896364E0
    public void LateTickAfterComponents() { } // 0x0000000182697B30-0x0000000182697C00
                                              // [XID] // 0x000000018963DB10-0x000000018963DB30
    public void SetDontDestroyGameObject() { } // 0x000000018268A950-0x000000018268A9F0
                                               // [XID] // 0x00000001896952F0-0x0000000189695310
    public bool IsToBeRemove() => default; // 0x0000000182698DC0-0x0000000182698E60
                                           // [XID] // 0x000000018964CB80-0x000000018964CBA0
    public bool CheckIsRecycledEntity() => default; // 0x000000018268C8D0-0x000000018268C9E0
    public virtual bool SetToBeRemoved<T>(ref T entityFieldToClear, bool checkSyncFromAuthority = true /* Metadata: 0x00AEA3B3 */, bool isRecoverFromServer = false /* Metadata: 0x00AEA3B4 */)
        where T : BaseEntity => default;
    // [XID] // 0x0000000189669150-0x0000000189669170
    public bool IsDestroying() => default; // 0x00000001826A4300-0x00000001826A43B0
                                           // [XID] // 0x0000000189670B00-0x0000000189670B20
    public virtual bool CheckDestroy() => default; // 0x0000000182679680-0x0000000182679740
                                                   // [XID] // 0x00000001896783D0-0x00000001896783F0
    public virtual bool Destroy(SliceFrameWatch watch = null) => default; // 0x0000000182681340-0x0000000182681C50
                                                                          // [XID] // 0x000000018967FCB0-0x000000018967FCD0
    public void PostDestroy(bool fromConfgIDCache = false /* Metadata: 0x00AEA3B5 */, bool disableRuntimeIDCacheCehck = false /* Metadata: 0x00AEA3B6 */) { } // 0x00000001826A2110-0x00000001826A2250
                                                                                                                                                              // [XID] // 0x0000000189687300-0x0000000189687320
    private void ClearActor() { } // 0x00000001826A9170-0x00000001826A92F0
                                  // [XID] // 0x00000001898FE940-0x00000001898FE960
    public bool IsDestroied() => default; // 0x00000001826A7800-0x00000001826A78B0
                                          // [XID] // 0x0000000189AF4FA0-0x0000000189AF4FC0
    public virtual bool OnEvent(BaseEvent e) => default; // 0x000000018269C480-0x000000018269C670
                                                         // [XID] // 0x000000018969E100-0x000000018969E120
    private void OnPreEvent(BaseEvent e) { } // 0x0000000182691180-0x0000000182691230
                                             // [XID] // 0x0000000189A125B0-0x0000000189A125D0
    private void OnPostEvent(BaseEvent e) { } // 0x000000018268AE60-0x000000018268AFE0
                                              // [XID] // 0x0000000189BA5E20-0x0000000189BA5E40
    public bool ListenEvent(BaseEvent e) => default; // 0x000000018268F480-0x000000018268F5D0
                                                     // [XID] // 0x0000000189B215C0-0x0000000189B215E0
    public virtual bool CanHandleEvent(BaseEvent e) => default; // 0x00000001826837D0-0x00000001826838C0
                                                                // [XID] // 0x00000001896BB400-0x00000001896BB420
    public virtual bool CanHandleWhateverDieEvent() => default; // 0x0000000182683340-0x0000000182683400
                                                                // [XID] // 0x0000000189AC7880-0x0000000189AC78A0
    public void FireEvent(BaseEvent e, bool immediately = false /* Metadata: 0x00AEA3B7 */) { } // 0x000000018269DA80-0x000000018269DB80
                                                                                                // [XID] // 0x00000001896D8AA0-0x00000001896D8AC0
    protected void RegistLifeToOwner(bool isTo) { } // 0x000000018269A6F0-0x000000018269A9A0
                                                    // [XID] // 0x00000001896E02D0-0x00000001896E02F0
    protected virtual void OnOwnerDie(BaseEntity ownerEntity) { } // 0x0000000182681D00-0x0000000182681DB0
                                                                  // [XID] // 0x00000001896BE080-0x00000001896BE0A0
    public virtual void SetOwnerRuntimeId(uint runtimeId) { } // 0x000000018268A8A0-0x000000018268A950
                                                              // [XID] // 0x00000001896EEC00-0x00000001896EEC20
    public virtual BaseEntity GetOwnerEntity() => default; // 0x000000018267BA90-0x000000018267BB30
                                                           // [XID] // 0x00000001896C5970-0x00000001896C5990
    public virtual void SetOriginOwnerRuntimeId(uint runtimeId) { } // 0x0000000182686990-0x0000000182686A40
                                                                    // [XID] // 0x00000001896CCFC0-0x00000001896CCFE0
    public virtual uint GetOwnerRuntimeID() => default; // 0x0000000182676470-0x0000000182676510
                                                        // [XID] // 0x0000000189705150-0x0000000189705170
    public virtual BaseEntity GetOriginOwnerEntity() => default; // 0x000000018268A690-0x000000018268A730
                                                                 // [XID] // 0x000000018970C820-0x000000018970C840
    public virtual uint GetOriginOwnerRuntimeID() => default; // 0x000000018267AC10-0x000000018267ACB0
                                                              // [XID] // 0x0000000189B084A0-0x0000000189B084C0
    public virtual void ClearOwners() { } // 0x00000001826A3A30-0x00000001826A3AD0
                                          // [XID] // 0x000000018971BAB0-0x000000018971BAD0
    public virtual void ClearOriginOwners() { } // 0x000000018267F4E0-0x000000018267F580
                                                // [XID] // 0x00000001896E33A0-0x00000001896E33C0
    public virtual List<uint> GetChildrenRuntimeIds() => default; // 0x00000001826A5550-0x00000001826A55F0
                                                                  // [XID] // 0x000000018972A4A0-0x000000018972A4C0
    public virtual void AddChild(uint runtimeId) { } // 0x00000001826A3520-0x00000001826A35D0
                                                     // [XID] // 0x00000001896EA8A0-0x00000001896EA8C0
    public virtual void RemoveChild(uint runtimeId) { } // 0x0000000182676680-0x0000000182676730
                                                        // [XID] // 0x0000000189739240-0x0000000189739260
    public virtual void ClearChildren() { } // 0x00000001826A8030-0x00000001826A80D0
                                            // [XID] // 0x0000000189741020-0x0000000189741040
    public virtual void AddDescendants(uint runtimeId) { } // 0x00000001826A51C0-0x00000001826A5270
                                                           // [XID] // 0x0000000189728E20-0x0000000189728E40
    public virtual void RemoveDescendants(uint runtimeId) { } // 0x00000001826918F0-0x00000001826919A0
                                                              // [XID] // 0x0000000189B4E510-0x0000000189B4E530
    public virtual void ClearDescendants(bool destroyDescendants = false /* Metadata: 0x00AEA3B8 */) { } // 0x0000000182681E50-0x0000000182681F00
                                                                                                         // [XID] // 0x00000001897574A0-0x00000001897574C0
    public virtual void DestroyLocalDescendants() { } // 0x00000001826842F0-0x0000000182684390
                                                      // [XID] // 0x000000018976D9A0-0x000000018976D9C0
    public bool IsLightActive() => default; // 0x0000000182687380-0x0000000182687430
                                            // [XID] // 0x0000000189774D60-0x0000000189774D80
    public bool IsActive() => default; // 0x0000000182675E70-0x0000000182675F30
                                       // [XID] // 0x000000018977C640-0x000000018977C660
    public bool IsSelfActive() => default; // 0x0000000182693CF0-0x0000000182693DA0
                                           // [XID] // 0x0000000189784100-0x0000000189784120
    public bool IsValid(bool checkCleared = true /* Metadata: 0x00AEA3B9 */) => default; // 0x00000001826784B0-0x0000000182678580
                                                                                         // [XID] // 0x000000018978B8D0-0x000000018978B8F0
    public bool IsValidLegacy(bool checkCleared = true /* Metadata: 0x00AEA3BA */) => default; // 0x0000000182692880-0x00000001826929D0
                                                                                               // [XID] // 0x0000000189712BF0-0x0000000189712C10
    public void SetForceSkipAnimatorUpdate(bool value) { } // 0x0000000182692760-0x0000000182692810
                                                           // [XID] // 0x000000018979A370-0x000000018979A390
    public virtual void SetActive(bool active, bool deepIfInactive = false /* Metadata: 0x00AEA3BB */, bool withGameObj = true /* Metadata: 0x00AEA3BC */, bool isLightActive = false /* Metadata: 0x00AEA3BD */, bool playDefault = true /* Metadata: 0x00AEA3BE */) { } // 0x00000001826A2560-0x00000001826A2D40
                                                                                                                                                                                                                                                                          // [XID] // 0x00000001897A22E0-0x00000001897A2300
    private void SetGameObjectActiveImp(bool active, bool withGameObj, bool isLightActive) { } // 0x0000000182677AA0-0x0000000182677D20
                                                                                               // [XID] // 0x00000001897A99A0-0x00000001897A99C0
    public bool IsVolatileGameObject() => default; // 0x000000018267B3E0-0x000000018267B550
                                                   // [XID] // 0x00000001897B1200-0x00000001897B1220
    public virtual void SetLightDeactive() { } // 0x00000001826A89A0-0x00000001826A8AD0
                                               // [XID] // 0x00000001897CE640-0x00000001897CE660
    private void SetActiveImp(bool active, bool withGameObj, bool isLightActive) { } // 0x000000018268D8E0-0x000000018268DB70
                                                                                     // [XID] // 0x00000001897D5D10-0x00000001897D5D30
    public void SetLightActive(bool active, bool deepIfInactive = false /* Metadata: 0x00AEA3BF */) { } // 0x00000001826A5C70-0x00000001826A5D60
                                                                                                        // [XID] // 0x0000000189A9A980-0x0000000189A9A9A0
    protected virtual void OnSetLightActive(bool active) { } // 0x0000000182679950-0x0000000182679AD0
                                                             // [XID] // 0x00000001897E4DD0-0x00000001897E4DF0
    public virtual void DoRevive() { } // 0x00000001826997E0-0x00000001826998C0
                                       // [XID] // 0x00000001897EC9F0-0x00000001897ECA10
    protected virtual void InitTimeScale() { } // 0x0000000182685370-0x00000001826855C0
                                               // [IDTag] // 0x00000001897F4220-0x00000001897F4260
                                               // [XID] // 0x00000001897F4220-0x00000001897F4260
    protected void OnTimeScaleChanged(float newTimeScale) { } // 0x000000018269BC80-0x000000018269BFB0
                                                              // [XID] // 0x000000018980D520-0x000000018980D540
    public void PushTimeScale(float timescale, int stackIx) { } // 0x00000001826A72D0-0x00000001826A73E0
                                                                // [XID] // 0x0000000189798DB0-0x0000000189798DD0
    public void PopTimeScale(int stackIx) { } // 0x000000018269C1C0-0x000000018269C2A0
                                              // [IDTag] // 0x000000018981C660-0x000000018981C6A0
                                              // [XID] // 0x000000018981C660-0x000000018981C6A0
    public virtual void OnTimeScaleChanged(bool force = false /* Metadata: 0x00AEA3C0 */) { } // 0x000000018269BA00-0x000000018269BC80
                                                                                              // [XID] // 0x0000000189826C90-0x0000000189826CB0
    protected void OnTimeScaleChangedByAbility() { } // 0x0000000182684C90-0x0000000182684DB0
                                                     // [XID] // 0x000000018982E320-0x000000018982E340
    private void RegisterTimeScaleByAbility() { } // 0x000000018269E880-0x000000018269E940
                                                  // [XID] // 0x0000000189A0AD30-0x0000000189A0AD50
    private void UnRegisterTimeScaleByAbility() { } // 0x0000000182687B00-0x0000000182687BC0
                                                    // [XID] // 0x000000018983D120-0x000000018983D140
    public uint GetNextComponentID() => default; // 0x00000001826A64D0-0x00000001826A65C0
                                                 // [XID] // 0x0000000189700D70-0x0000000189700D90
    public virtual void AddComponent(BaseComponent component) { } // 0x0000000182685FC0-0x00000001826861B0
                                                                  // [XID] // 0x0000000189876550-0x0000000189876570
    public void OnAddComponent(BaseComponent component) { } // 0x000000018268B3A0-0x000000018268B450
                                                            // [IDTag] // 0x000000018987E110-0x000000018987E150
                                                            // [XID] // 0x000000018987E110-0x000000018987E150
    public LCBase GetLogicComponent(uint componentRuntimeID) => default; // 0x00000001826A1190-0x00000001826A1260
                                                                         // [IDTag] // 0x0000000189888060-0x00000001898880A0
                                                                         // [XID] // 0x0000000189888060-0x00000001898880A0
    public LCBase GetLogicComponent(System.Type type) => default; // 0x00000001826A10B0-0x00000001826A1190
    public List<T> GetLogicComponents<T>()
        where T : LCBase => default;
    // [IDTag] // 0x00000001898922A0-0x00000001898922E0
    // [XID] // 0x00000001898922A0-0x00000001898922E0
    public VCBase GetVisualComponent(uint componentRuntimeID) => default; // 0x000000018269AC80-0x000000018269AD50
                                                                          // [IDTag] // 0x000000018989C990-0x000000018989C9D0
                                                                          // [XID] // 0x000000018989C990-0x000000018989C9D0
    public VCBase GetVisualComponent(System.Type type) => default; // 0x000000018269ABA0-0x000000018269AC80
    public List<T> GetVisualComponents<T>()
        where T : LCBase => default;
    // [XID] // 0x00000001898A7080-0x00000001898A70A0
    public List<BaseComponent> GetAllLogicComponents() => default; // 0x000000018267F160-0x000000018267F220
                                                                   // [XID] // 0x00000001898AE960-0x00000001898AE980
    public List<BaseComponent> GetAllVisualComponents() => default; // 0x00000001826A6930-0x00000001826A69F0
    public void RemoveLogicComponent<T>()
        where T : LCBase
    { }
    public void RemoveVisualComponent<T>()
        where T : VCBase
    { }
    // [XID] // 0x00000001898B5CD0-0x00000001898B5CF0
    public void RemoveLogicComponent(uint componentRuntimeID) { } // 0x0000000182698F10-0x0000000182698FD0
                                                                  // [XID] // 0x00000001896D43E0-0x00000001896D4400
    public void RemoveVisualComponent(uint componentRuntimeID) { } // 0x000000018268CB90-0x000000018268CC50
                                                                   // [XID] // 0x0000000189924680-0x00000001899246A0
    public void OnRemoveComponent(BaseComponent component) { } // 0x0000000182686D50-0x0000000182686E10
    public void RemoveLogicComponents<T>()
        where T : LCBase
    { }
    public void RemoveVisualComponents<T>()
        where T : VCBase
    { }
    public void EnableLogicComponent<T>(bool enabled)
        where T : LCBase
    { }
    public void EnableVisualComponent<T>(bool enabled)
        where T : VCBase
    { }
    // [XID] // 0x0000000189B30270-0x0000000189B30290
    public void EnableLogicComponent(uint componentRuntimeID, bool enabled) { } // 0x0000000182677D20-0x0000000182677E00
                                                                                // [XID] // 0x00000001898D3D50-0x00000001898D3D70
    public void EnableVisualComponent(uint componentRuntimeID, bool enabled) { } // 0x00000001826A5D60-0x00000001826A5E40
    public void EnableLogicComponents<T>(bool enabled)
        where T : LCBase
    { }
    public void EnableVisualComponents<T>(bool enabled)
        where T : VCBase
    { }
    // [XID] // 0x00000001898DB4E0-0x00000001898DB500
    public bool HasComponentTag(ComponentTag tag) => default; // 0x000000018268F910-0x000000018268FA10
                                                              // [XID] // 0x00000001898E3120-0x00000001898E3140
    private void AddComponentTag(BaseComponent component) { } // 0x00000001826A5E40-0x00000001826A60A0
                                                              // [XID] // 0x00000001899C3860-0x00000001899C3880
    private void RemoveComponentTag(BaseComponent component) { } // 0x00000001826A43B0-0x00000001826A45D0
                                                                 // [XID] // 0x00000001898F2620-0x00000001898F2640
    private List<ComponentTag> GetComponentTag(BaseComponent component) => default; // 0x0000000182676930-0x00000001826774B0
                                                                                    // [XID] // 0x0000000189649BE0-0x0000000189649C00
    public void RegisterComponentForEntityTickManager(BaseComponent component) { } // 0x000000018269C2A0-0x000000018269C3C0
                                                                                   // [XID] // 0x00000001899017A0-0x00000001899017C0
    public void UnregisterComponentForEntityTickManager(BaseComponent component) { } // 0x00000001826838C0-0x00000001826839B0
                                                                                     // [XID] // 0x0000000189908EB0-0x0000000189908ED0
    public void CheckTickableForEntityTickManager() { } // 0x0000000182698140-0x0000000182698280
                                                        // [XID] // 0x0000000189910450-0x0000000189910470
    public HashList<BaseComponent> GetComponentsForEntityTickManager() => default; // 0x0000000182684390-0x0000000182684440
                                                                                   // [XID] // 0x0000000189917FA0-0x0000000189917FC0
    public override string ToString() => default; // 0x00000001826A94C0-0x00000001826AA340
                                                  // [XID] // 0x000000018991F5D0-0x000000018991F5F0
    public string ToStringWithConfigID(bool withFrameIndex) => default; // 0x000000018268E780-0x000000018268E9D0
                                                                        // [XID] // 0x0000000189927140-0x0000000189927160
    public string ToStringRelease() => default; // 0x00000001826906A0-0x00000001826909E0
                                                // [XID] // 0x000000018992E8F0-0x000000018992E910
    protected string GetName() => default; // 0x000000018269F150-0x000000018269F210
                                           // [XID] // 0x00000001896035E0-0x0000000189603600
    public static void CollectTokenBudgetByComponents(List<BaseComponent> components, Action<float, ITokenBudgetComponent> onCollectTokenBudget) { } // 0x00000001826A7B90-0x00000001826A7F30
                                                                                                                                                     // [XID] // 0x000000018993D820-0x000000018993D840
    private void OnCollectStaticBudget(float inBudget, ITokenBudgetComponent inComp) { } // 0x0000000182691820-0x00000001826918F0
                                                                                         // [XID] // 0x0000000189999430-0x0000000189999450
    public virtual float GetStaticBudget() => default; // 0x0000000182697100-0x0000000182697480
                                                       // [XID] // 0x000000018994C2A0-0x000000018994C2C0
    public void AccumulateToEntityTickBudget() { } // 0x0000000182695610-0x00000001826958A0
                                                   // [XID] // 0x00000001899538D0-0x00000001899538F0
    public void ExecuteTickComponents(float inDeltaTime, List<BaseEntity> onSafeReadyEntitiesList, int sharedInitComponentWatch, bool isRoundRobinFrame) { } // 0x000000018267BB30-0x000000018267BFA0
                                                                                                                                                             // [XID] // 0x0000000189ADE6E0-0x0000000189ADE700
    public void AmortizedTick(float inDeltaTime, List<BaseEntity> onSafeReadyEntitiesList, int sharedInitComponentWatch) { } // 0x0000000182678D20-0x0000000182678EA0
                                                                                                                             // [XID] // 0x000000018965D380-0x000000018965D3A0
    public void ExecuteLateTickComponents(float inDeltaTime) { } // 0x0000000182677E00-0x0000000182678060
                                                                 // [XID] // 0x0000000189630350-0x0000000189630370
    public void ExecuteUpdateRigidBody() { } // 0x0000000182685B60-0x0000000182685D10
                                             // [XID] // 0x00000001898F7180-0x00000001898F71A0
    protected virtual bool ShouldFireEntityCreated() => default; // 0x0000000182683730-0x00000001826837D0
                                                                 // [XID] // 0x000000018971BCE0-0x000000018971BD00
    protected virtual bool ShouldFireEntityReady() => default; // 0x000000018268C9E0-0x000000018268CB20
                                                               // [XID] // 0x00000001897515C0-0x00000001897515E0
    protected virtual bool ShouldFireEntityActive() => default; // 0x0000000182692BA0-0x0000000182692CD0
                                                                // [XID] // 0x000000018963F1D0-0x000000018963F1F0
    protected virtual bool ShouldFireEntityRemoved() => default; // 0x00000001826996B0-0x00000001826997E0
                                                                 // [XID] // 0x0000000189655C20-0x0000000189655C40
    protected virtual bool ShouldFireEntityReconnectEvent() => default; // 0x000000018269AD50-0x000000018269AE80
                                                                        // [XID] // 0x00000001897141D0-0x00000001897141F0
    public void FireEntityReadyEvent() { } // 0x0000000182684AB0-0x0000000182684BF0
                                           // [XID] // 0x0000000189646A60-0x0000000189646A80
    public void FireEntityReconnectEvent() { } // 0x0000000182692120-0x0000000182692260
                                               // [XID] // 0x00000001899B8AA0-0x00000001899B8AC0
    public bool IsInCamera() => default; // 0x000000018268A9F0-0x000000018268AAC0
                                         // [XID] // 0x000000018989F690-0x000000018989F6B0
    public void RegisterComponentInitNoitfy(System.Type compType, object compData) { } // 0x000000018269DC30-0x000000018269DD60
                                                                                       // [XID] // 0x00000001899C7BF0-0x00000001899C7C10
    protected void HandleComponentInitNotify() { } // 0x000000018269A390-0x000000018269A590
                                                   // [XID] // 0x00000001899CF390-0x00000001899CF3B0
    protected void ClearComponentInitNotify() { } // 0x0000000182696430-0x00000001826964E0
    [Preserve] // 0x00000001899D6870-0x00000001899D68B0
               // [XID] // 0x00000001899D6870-0x00000001899D68B0
    public virtual string Dump() => default; // 0x0000000182693A10-0x0000000182693BA0
    [Preserve] // 0x0000000189B94090-0x0000000189B940A0
    public virtual string DumpLogicComponent<T>(int metaTypeID, string tag = "" /* Metadata: 0x00AEA3C1 */)
        where T : LCBase => default;
    [Preserve] // 0x0000000189B94090-0x0000000189B940A0
    public virtual string DumpVisualComponent<T>(int metaTypeID, string tag = "" /* Metadata: 0x00AEA3C5 */)
        where T : VCBase => default;
    [Preserve] // 0x00000001899F01C0-0x00000001899F0200
               // [XID] // 0x00000001899F01C0-0x00000001899F0200
    public string DumpSimpleInfo() => default; // 0x000000018268AFE0-0x000000018268B3A0
    [Preserve] // 0x00000001899FA7F0-0x00000001899FA830
               // [XID] // 0x00000001899FA7F0-0x00000001899FA830
    public string DumpBaseInfo() => default; // 0x00000001826801B0-0x00000001826809D0
                                             // [XID] // 0x0000000189873710-0x0000000189873730
    public bool ShouldEntitySafeReady() => default; // 0x000000018267ACB0-0x000000018267AD70
                                                    // [XID] // 0x00000001898A71A0-0x00000001898A71C0
    public virtual void OnSafeEntityReady() { } // 0x00000001826A86D0-0x00000001826A8780
                                                // [XID] // 0x00000001899586A0-0x00000001899586C0
    public void FireSafeCmd(EntitySafeCmd cmd) { } // 0x0000000182692AD0-0x0000000182692BA0
                                                   // [XID] // 0x00000001898AEBF0-0x00000001898AEC10
    private void DispatchSafeCmd() { } // 0x00000001826952E0-0x0000000182695490
    [BlackList] // 0x0000000189A22770-0x0000000189A227B0
                // [XID] // 0x0000000189A22770-0x0000000189A227B0
    public virtual void AutoAllocTypeFields() { } // 0x0000000182679AD0-0x0000000182679BE0
    [BlackList] // 0x0000000189A2C900-0x0000000189A2C940
                // [XID] // 0x0000000189A2C900-0x0000000189A2C940
    public virtual void AutoRecycleTypeFields() { } // 0x0000000182679BE0-0x000000018267A8A0
    [BlackList] // 0x0000000189A372C0-0x0000000189A37300
                // [XID] // 0x0000000189A372C0-0x0000000189A37300
    public virtual void ReturnToObjectPool() { } // 0x00000001826A9420-0x00000001826A94C0
                                                 // [XID] // 0x0000000189A57DC0-0x0000000189A57DE0
    public void RegisterExtraRenderer(IRenderable inRenderer) { } // 0x000000018269CB80-0x000000018269CCB0
                                                                  // [XID] // 0x0000000189A5FA70-0x0000000189A5FA90
    public void UnRegisterExtraRenderer(IRenderable inRenderer) { } // 0x00000001826851B0-0x0000000182685310
                                                                    // [XID] // 0x0000000189BC5240-0x0000000189BC5260
    public bool IsExtraRenderersVisible() => default; // 0x00000001826A5B30-0x00000001826A5C70
                                                      // [XID] // 0x0000000189A76210-0x0000000189A76230
    public void OnAddNoPauseTask(IRequestOwnerEntityNoPauseTask inTask) { } // 0x00000001826A69F0-0x00000001826A6B50
                                                                            // [XID] // 0x0000000189A7DC00-0x0000000189A7DC20
    public void OnRemoveNoPauseTask(IRequestOwnerEntityNoPauseTask inTask) { } // 0x00000001826A6FD0-0x00000001826A70C0
                                                                               // [XID] // 0x0000000189A854B0-0x0000000189A854D0
    private void CacheSharedPosition() { } // 0x00000001826774B0-0x00000001826775B0
                                           // [XID] // 0x0000000189B28D70-0x0000000189B28D90
    protected virtual void OnSharedPositionDirty() { } // 0x000000018269EFE0-0x000000018269F0F0
                                                       // [XID] // 0x0000000189A941B0-0x0000000189A941D0
    public void SetSharedPosition(Vector3 inPos) { } // 0x000000018268E050-0x000000018268E130
                                                     // [XID] // 0x0000000189A9BB80-0x0000000189A9BBA0
    public Vector3 GetSharedPosition() => default; // 0x0000000182686E10-0x0000000182686EF0
                                                   // [XID] // 0x0000000189AA3060-0x0000000189AA3080
    public Vector3 GetSharedForward() => default; // 0x000000018269B030-0x000000018269B110
                                                  // [XID] // 0x0000000189AAA530-0x0000000189AAA550
    public Vector3 GetNearestPositionByTarget(Vector3 target) => default; // 0x000000018267A8A0-0x000000018267AC10
                                                                          // [XID] // 0x0000000189AB23D0-0x0000000189AB23F0
    public void SetTickLODHelper(SignificanceManager.ISignificanceManagedObject inTickLODHelper) { } // 0x0000000182696DE0-0x0000000182696E90
                                                                                                     // [XID] // 0x0000000189AC13F0-0x0000000189AC1410
    public void RegisterOnTickLODChanged(Action<BaseEntity, int, int> inOnTickLODChanged) { } // 0x00000001826A9000-0x00000001826A90D0
                                                                                              // [XID] // 0x0000000189AC8CC0-0x0000000189AC8CE0
    public void UnregisterOnTickLODChanged(Action<BaseEntity, int, int> inOnTickLODChanged) { } // 0x0000000182686FE0-0x00000001826870B0
                                                                                                // [XID] // 0x000000018966F2E0-0x000000018966F300
    public virtual void OnSetComponentEnableDirty() { } // 0x00000001826A78B0-0x00000001826A7950
                                                        // [XID] // 0x0000000189B05330-0x0000000189B05350
    public virtual bool ShouldConsiderComponentEnableWhenAccumulateBudget() => default; // 0x0000000182682FC0-0x0000000182683060
                                                                                        // [XID] // 0x0000000189B0CA60-0x0000000189B0CA80
    protected virtual void AllocateTickBalanceProxy() { } // 0x0000000182678920-0x0000000182678C30
                                                          // [XID] // 0x0000000189B13FE0-0x0000000189B14000
    protected virtual void RegisterTickBalanceProxy(bool considerAsReady) { } // 0x00000001826A2E90-0x00000001826A2FE0
                                                                              // [XID] // 0x0000000189B1B870-0x0000000189B1B890
    public virtual void UnregisterTickBalanceProxy() { } // 0x00000001826893B0-0x0000000182689590
                                                         // [XID] // 0x0000000189B22E10-0x0000000189B22E30
    protected void OnActiveChange(bool isActive) { } // 0x000000018267CBA0-0x000000018267CCB0
                                                     // [XID] // 0x0000000189AC7900-0x0000000189AC7920
    public void OnRelatedGameObjectVisibleChange(bool isVisible) { } // 0x0000000182694DE0-0x0000000182694EF0
                                                                     // [XID] // 0x0000000189B319C0-0x0000000189B319E0
    protected virtual void DeallocTickBalanceProxy() { } // 0x00000001826A36B0-0x00000001826A3860
                                                         // [XID] // 0x0000000189B409F0-0x0000000189B40A10
    internal bool GetIsKinematicRigidbody() => default; // 0x0000000182694040-0x00000001826940F0
                                                        // [XID] // 0x0000000189B482B0-0x0000000189B482D0
    private void OnNeedNoPauseNoIntervalTickInInitializationStage() { } // 0x0000000182679860-0x0000000182679950
                                                                        // [XID] // 0x0000000189B4FB90-0x0000000189B4FBB0
    public virtual bool ShouldUseSyncReadyOnCreatedSkillObject() => default; // 0x00000001826A5690-0x00000001826A5730
                                                                             // [XID] // 0x0000000189628AA0-0x0000000189628AC0
    protected bool IsSelfShouldDisablePause() => default; // 0x0000000182695540-0x0000000182695610
                                                          // [XID] // 0x00000001898576B0-0x00000001898576D0
    public bool HasNonSelfOwner() => default; // 0x0000000182696FF0-0x0000000182697100
                                              // [XID] // 0x0000000189B66280-0x0000000189B662A0
    public BaseEntity GetNonSelfOwner() => default; // 0x000000018267B290-0x000000018267B3E0
                                                    // [XID] // 0x0000000189B6D830-0x0000000189B6D850
    public float GetEntityTokenBudgetScale() => default; // 0x000000018268D6A0-0x000000018268D770
                                                         // [XID] // 0x00000001896211F0-0x0000000189621210
    public virtual bool IsDisablePause() => default; // 0x0000000182687ED0-0x0000000182687F80
                                                     // [XID] // 0x0000000189B6C0D0-0x0000000189B6C0F0
    public void SyncBalanceTickEntityIsTickable() { } // 0x000000018269C670-0x000000018269C850
                                                      // [XID] // 0x0000000189B83F00-0x0000000189B83F20
    protected virtual void SyncBalanceTickAnimatorTickState(bool isTickableDirty) { } // 0x00000001826995D0-0x00000001826996B0
                                                                                      // [XID] // 0x0000000189B8AEE0-0x0000000189B8AF00
    private void SyncBalanceTickSharedPosition() { } // 0x0000000182684EA0-0x0000000182684FD0
                                                     // [XID] // 0x0000000189B92680-0x0000000189B926A0
    public bool ShouldSyncBalanceTickAnimatorTickState() => default; // 0x0000000182678820-0x0000000182678920
                                                                     // [XID] // 0x0000000189B99BA0-0x0000000189B99BC0
    public bool ShouldSyncSyncBalanceTickIsRenderingInUnityThread() => default; // 0x000000018267F350-0x000000018267F4E0
                                                                                // [XID] // 0x0000000189BA1280-0x0000000189BA12A0
    public void SyncBalanceTickIsRenderingUnityThread() { } // 0x0000000182697CA0-0x0000000182697F90
                                                            // [XID] // 0x0000000189BB5F30-0x0000000189BB5F50
    protected virtual void InternalUpdateTickable() { } // 0x000000018268A7E0-0x000000018268A8A0
                                                        // [XID] // 0x00000001899FAA70-0x00000001899FAA90
    public static bool ShouldDisableRootMotionTickWhenPause() => default; // 0x0000000182676510-0x00000001826765E0
                                                                          // [XID] // 0x0000000189BB7380-0x0000000189BB73A0
    public static bool ShouldPropagateAnimatorTickState() => default; // 0x00000001826A3050-0x00000001826A3120
                                                                      // [XID] // 0x0000000189BBE930-0x0000000189BBE950
    private void ForcePauseAnimators(bool bPause) { } // 0x0000000182686C50-0x0000000182686D50
                                                      // [XID] // 0x0000000189BC6630-0x0000000189BC6650
    private void SyncEntityAnimatorState(TickState inAnimatorTickState, bool isPause) { } // 0x0000000182687500-0x0000000182687650
                                                                                          // [XID] // 0x0000000189B5D580-0x0000000189B5D5A0
    private void UpdateAnimatorTickState(TickState inAnimatorTickState, bool isTickableDirty) { } // 0x00000001826941A0-0x0000000182694360
    public void AddEventListener<T>(Action<T> eventHandler)
        where T : class, IDispatchableEvent
    { }
    public void RemoveEventListener<T>(Action<T> eventHandler)
        where T : class, IDispatchableEvent
    { }
    // [XID] // 0x0000000189BD55B0-0x0000000189BD55D0
    public void FireEventToDispatch(BaseEvent args) { } // 0x000000018268CE00-0x000000018268CF80
                                                        // [XID] // 0x00000001895E9B80-0x00000001895E9BA0
    public bool CheckBoolStateMatch(bool currentState, bool targetState, string stateDesc, string errorMsg) => default; // 0x000000018269E3D0-0x000000018269E5E0
                                                                                                                        // [XID] // 0x00000001895F1280-0x00000001895F12A0
    public bool CheckInConfigIDReuseCache(bool shouldInCache, string errorMsg) => default; // 0x0000000182678580-0x0000000182678670
                                                                                           // [XID] // 0x00000001895F8DC0-0x00000001895F8DE0
    public bool CheckInRuntimeIDReuseCache(bool shouldInCache, string errorMsg) => default; // 0x0000000182685D10-0x0000000182685E00
                                                                                            // [XID] // 0x0000000189B88720-0x0000000189B88740
    public bool CheckInToBeRemoveList(bool shouldInList, string errorMsg) => default; // 0x0000000182691C80-0x0000000182691D70
                                                                                      // [XID] // 0x0000000189616910-0x0000000189616930
    public bool CheckInEntityMap(bool shouldInList, string errorMsg) => default; // 0x00000001826A4D70-0x00000001826A4E60
                                                                                 // [XID] // 0x00000001896E3380-0x00000001896E33A0
    public int GetTickLod() => default; // 0x00000001826A14B0-0x00000001826A1560
                                        // [XID] // 0x00000001896256F0-0x0000000189625710
    public virtual EntityType GetTokenEntityType() => default; // 0x00000001826A63F0-0x00000001826A64D0
                                                               // [XID] // 0x0000000189770A40-0x0000000189770A60
    public float GetBalanceTickDeltaTime() => default; // 0x00000001826A1FF0-0x00000001826A20B0
                                                       // [XID] // 0x00000001897782F0-0x0000000189778310
    public bool GetRequestPause() => default; // 0x00000001826940F0-0x00000001826941A0
                                              // [XID] // 0x0000000189874D50-0x0000000189874D70
    public void UpdateComponentsBalancedTickInfoComputeThread() { } // 0x000000018269C3C0-0x000000018269C480
    [DebuggerHidden] // 0x00000001896C2600-0x00000001896C2640
                     // [XID] // 0x00000001896C2600-0x00000001896C2640
    private static IEnumerator CoroutineStatFrame() => default; // 0x00000001826909E0-0x0000000182690A90
                                                                // [XID] // 0x00000001896CCE00-0x00000001896CCE20
    public static void EnableStatModule(bool bEnable) { } // 0x0000000182698970-0x0000000182698D10
                                                          // [XID] // 0x00000001898A8600-0x00000001898A8620
    private void ConditionalCacheEntityComponentInfo() { } // 0x00000001826A5730-0x00000001826A5A30
                                                           // [XID] // 0x00000001896DB960-0x00000001896DB980
    private void ConditionalCacheEntityGameObjectInfo() { } // 0x000000018269E140-0x000000018269E3D0
                                                            // [XID] // 0x00000001896E3160-0x00000001896E3180
    public void RefreshECPDebugInfo(bool needUnityObjectStatInfo) { } // 0x000000018269C9E0-0x000000018269CB80
                                                                      // [XID] // 0x00000001896EA700-0x00000001896EA720
    public static bool IsEntityTypeValid(ECPDebugInfo.EFilterEntityType inEntityType) => default; // 0x0000000182691500-0x0000000182691600
                                                                                                  // [XID] // 0x00000001898BEE80-0x00000001898BEEA0
    public static bool IsEntityValid(ref ECPDebugInfo e) => default; // 0x00000001826A8F30-0x00000001826A9000
                                                                     // [XID] // 0x00000001896F90C0-0x00000001896F90E0
    public static void ClearStats()
    {
        totalEdi._edi.lastToLocalDistanceXYZ = default;
        totalEdi._edi.lastToLocalDistanceXZ = default;
        totalEdi._edi.bPause = default;
        totalEdi._edi._count = default;
        totalEdi._edi._totalTime = default;
        totalEdi._edi._tickTime = default;
        totalEdi._edi.tokenPriorityScore = default;
        totalEdi._edi.idealTickLOD = default;
        totalEdi._edi.idealTokenBudget = default;
        totalEdi._edi.currentTickLOD = default;
        totalEdi._edi.currentTokenBudget = default;
        totalEdi._edi.debugName = default;
        totalEdi._edi.owner = default;
        totalEdi._edi.categoryName = default;
        totalEdi._edi.entityType = default;
        totalEdi._edi.configID = default;
        totalEdi._edi.rtServerEntity = default;
        totalEdi._edi.rtEntityType = default;
        totalEdi._edi.rtCategory = default;
        totalEdi._edi.staticBudget = default;
        totalEdi._edi.componentCount = default;
        totalEdi._edi.tickableComponentCount = default;
        totalEdi._edi.lateTickableComponentCount = default;
        totalEdi._edi.fixTickableComponentCount = default;
        totalEdi._edi.pluginCount = default;
        totalEdi._edi.tickablePluginCount = default;
        totalEdi._edi.lateTickablePluginCount = default;
        totalEdi._edi.fixTickablePluginCount = default;
        totalEdi._edi._gameObjectCount = default;
        totalEdi._edi._animatorCount = default;
        totalEdi._edi._particleCount = default;
        totalEdi._edi._renderCount = default;
        totalEdi._edi._colliderCount = default;
        totalEdi._edi._rigidbodyCount = default;
        totalEdi._edi.debugInfo = default;
        totalEdi.totalEntityCount = default;
        totalEdi.totalMassiveEntityCount = default;
        totalEdi.totalEntityBudget = default;
        totalEdi.EntityCount_Monster = default;
        totalEdi.EntityCount_Animal = default;
        totalEdi.EntityCount_NPC = default;
        totalEdi.totalAppliedModifiersCount = default;
        totalEdi.timerCount = default;
    } // 0x000000018268B6B0-0x000000018268B820
      // [XID] // 0x0000000189700AD0-0x0000000189700AF0
    public virtual uint GetGroupIDForStat() => default; // 0x0000000182683A60-0x0000000182683B00
                                                        // [XID] // 0x0000000189708120-0x0000000189708140
    public void AccumulateThisFrameTickMS(long startTick, EntityManager.TickType tickType) { } // 0x0000000182695070-0x00000001826951F0
                                                                                               // [XID] // 0x0000000189982840-0x0000000189982860
    public static Stopwatch StartStatWatch() => default; // 0x000000018269CCB0-0x000000018269CEE0
                                                         // [XID] // 0x000000018980BDF0-0x000000018980BE10
    public static long DeltaTick(long inStartTick) => default; // 0x0000000182677960-0x0000000182677A40
                                                               // [XID] // 0x000000018984EF50-0x000000018984EF70
    public static double DeltaTickToMilliseconds(long inDeltaTick) => default; // 0x000000018267F580-0x000000018267F670
                                                                               // [XID] // 0x000000018973C7A0-0x000000018973C7C0
    public static bool RequestDumpProfileFrame(Action<List<CycleStatLogNode>> inOnGenerateEntityTickStatLog) => default; // 0x0000000182676730-0x0000000182676930
                                                                                                                         // [XID] // 0x0000000189B2A6A0-0x0000000189B2A6C0
    public static void CancelDumpProfileFrame(Action<List<CycleStatLogNode>> inOnGenerateEntityTickStatLog) { } // 0x0000000182693BA0-0x0000000182693CF0
                                                                                                                // [XID] // 0x0000000189959C30-0x0000000189959C50
    public static void RequestClearHistory() { } // 0x00000001826935E0-0x00000001826936B0
                                                 // [XID] // 0x00000001898B77E0-0x00000001898B7800
    private static CycleStat NewPooledCycleStat(string id, int inStatOwnerid) => default; // 0x00000001826A87E0-0x00000001826A88F0
                                                                                          // [XID] // 0x0000000189761D00-0x0000000189761D20
    private static void CreateStaticStats() { } // 0x000000018269D180-0x000000018269D4D0
                                                // [XID] // 0x00000001897690F0-0x0000000189769110
    private static void FlushStaticStats() { } // 0x000000018267F840-0x000000018267FA50
                                               // [XID] // 0x00000001897707D0-0x00000001897707F0
    public static void OnFinishProfileFrame() { } // 0x00000001826A52E0-0x00000001826A5550
                                                  // [XID] // 0x0000000189778010-0x0000000189778030
    public CycleStatLogNode GenerateThisFrameTickStatLog() => default; // 0x0000000182690F80-0x00000001826910C0
                                                                       // [XID] // 0x000000018977F520-0x000000018977F540
    public string GenerateTickStatLog(ref double totalTickMilliseconds) => default; // 0x000000018267BFA0-0x000000018267C060
                                                                                    // [XID] // 0x00000001897D9400-0x00000001897D9420
    public static bool RequestAnalyzeFrame(DelegateOnAnalyzeFrame inOnAnalyzeFrame) => default; // 0x0000000182696E90-0x0000000182696FF0
                                                                                                // [XID] // 0x0000000189B1BA20-0x0000000189B1BA40
    public static void CancelAnalyzeFrame(DelegateOnAnalyzeFrame inOnAnalyzeFrame) { } // 0x0000000182686EF0-0x0000000182686FE0
                                                                                       // [IDTag] // 0x00000001897B4880-0x00000001897B48C0
                                                                                       // [XID] // 0x00000001897B4880-0x00000001897B48C0
    public bool IsLoadingAnime() => default; // 0x000000018269B3A0-0x000000018269B450
                                             // [IDTag] // 0x00000001897BF900-0x00000001897BF940
                                             // [XID] // 0x00000001897BF900-0x00000001897BF940
    private bool IsLoadingAnime(out bool isLastFrame)
    {
        isLastFrame = default;
        return default;
    } // 0x000000018269B110-0x000000018269B3A0
      // [XID] // 0x00000001897C9C60-0x00000001897C9C80
    private void InitAnimatorOverrideController() { } // 0x0000000182698FD0-0x0000000182699240
                                                      // [XID] // 0x00000001897D12B0-0x00000001897D12D0
    private void ClearAnimatorOverrideController() { } // 0x00000001826919A0-0x0000000182691B70
                                                       // [XID] // 0x0000000189BDEC20-0x0000000189BDEC40
    private ulong GetOverrideAnimeByState(string stateId) => default; // 0x00000001826A1ED0-0x00000001826A1FF0
                                                                      // [XID] // 0x00000001895EB770-0x00000001895EB790
    private string[] GetStateIdListByFreeStyle(int freeStyleId) => default; // 0x000000018268F730-0x000000018268F850
                                                                            // [XID] // 0x0000000189B31B90-0x0000000189B31BB0
    private void AddAnimeToNeedResetList(AnimeLoadInfo tarInfo) { } // 0x0000000182687BC0-0x0000000182687CF0
                                                                    // [XID] // 0x00000001897EF880-0x00000001897EF8A0
    private void TryRemoveAnimeFromNeedResetList(AnimeLoadInfo tarInfo) { } // 0x0000000182694F90-0x0000000182695070
                                                                            // [IDTag] // 0x00000001897F6F60-0x00000001897F6FA0
                                                                            // [XID] // 0x00000001897F6F60-0x00000001897F6FA0
    public bool LoadOverrideAnimeSync(string stateId, IAnimeOverrideReason reason) => default; // 0x000000018267C610-0x000000018267C850
                                                                                               // [IDTag] // 0x0000000189801970-0x00000001898019B0
                                                                                               // [XID] // 0x0000000189801970-0x00000001898019B0
    public bool LoadOverrideAnimeSync(string[] stateIdList, IAnimeOverrideReason reason) => default; // 0x000000018267C850-0x000000018267C980
                                                                                                     // [XID] // 0x000000018980BBD0-0x000000018980BBF0
    public bool LoadOverrideAnimeByFreeStyleSync(int freeStyleId, IAnimeOverrideReason reason) => default; // 0x00000001826840E0-0x00000001826841C0
                                                                                                           // [XID] // 0x000000018968C080-0x000000018968C0A0
    public bool LoadOverrideAnimeByFreeStyleListSync(int[] freeStyleList, IAnimeOverrideReason reason) => default; // 0x0000000182694920-0x0000000182694A40
                                                                                                                   // [IDTag] // 0x000000018981AED0-0x000000018981AF10
                                                                                                                   // [XID] // 0x000000018981AED0-0x000000018981AF10
    public void LoadOverrideAnimeAsync(string stateId, IAnimeOverrideReason reason, Action<bool> loadCallBack) { } // 0x000000018268E360-0x000000018268E620
                                                                                                                   // [IDTag] // 0x00000001898252C0-0x0000000189825300
                                                                                                                   // [XID] // 0x00000001898252C0-0x0000000189825300
    public void LoadOverrideAnimeAsyncWithJob(string stateId, IAnimeOverrideReason reason, Action<bool> loadCallBack, List<AsyncJob> jobs) { } // 0x00000001826A3FE0-0x00000001826A4300
                                                                                                                                               // [IDTag] // 0x000000018982F990-0x000000018982F9D0
                                                                                                                                               // [XID] // 0x000000018982F990-0x000000018982F9D0
    public void LoadOverrideAnimeAsync(string[] stateIdList, IAnimeOverrideReason reason, Action<bool> loadCallBack) { } // 0x000000018268E130-0x000000018268E360
                                                                                                                         // [IDTag] // 0x0000000189839F70-0x0000000189839FB0
                                                                                                                         // [XID] // 0x0000000189839F70-0x0000000189839FB0
    public void LoadOverrideAnimeAsyncWithJob(string[] stateIdList, IAnimeOverrideReason reason, Action<bool> loadCallBack, List<AsyncJob> jobs, ref int count) { } // 0x00000001826A3DD0-0x00000001826A3FE0
                                                                                                                                                                    // [XID] // 0x00000001896E4A70-0x00000001896E4A90
    private void LoadOverrideAnimeAsyncWithCallBackWrapper(string[] stateIdList, IAnimeOverrideReason reason, MultiCallBackWrapper callBackWrapper) { } // 0x00000001826A1680-0x00000001826A1840
                                                                                                                                                        // [XID] // 0x000000018984BD70-0x000000018984BD90
    public void LoadOverrideAnimeByFreeStyleAsync(int freeStyleId, IAnimeOverrideReason reason, Action<bool> loadCallBack) { } // 0x00000001826861B0-0x00000001826862A0
                                                                                                                               // [XID] // 0x00000001897024B0-0x00000001897024D0
    public void LoadOverrideAnimeByFreeStyleAsyncWithJob(int freeStyleId, IAnimeOverrideReason reason, Action<bool> loadCallBack, List<AsyncJob> jobs, ref int count) { } // 0x0000000182693E50-0x0000000182693F80
                                                                                                                                                                          // [XID] // 0x000000018985A880-0x000000018985A8A0
    public void LoadOverrideAnimeByFreeStyleListAsync(int[] freeStyleList, IAnimeOverrideReason reason, Action<bool> loadCallBack) { } // 0x0000000182690CB0-0x0000000182690E80
                                                                                                                                       // [XID] // 0x0000000189666040-0x0000000189666060
    private void OnOverrideAnimeLoadFinish(string stateId, uint handle, ulong animePathHash, AnimationClip clip) { } // 0x000000018269F430-0x000000018269F980
                                                                                                                     // [XID] // 0x00000001898E9B10-0x00000001898E9B30
    private void ChangeOverrideAnimeImpl(string stateId, AnimationClip tarClip) { } // 0x00000001826A3120-0x00000001826A3270
                                                                                    // [XID] // 0x00000001898704F0-0x0000000189870510
    public void ResetOverrideAnime(string stateId, IAnimeOverrideReason reason, bool immediately = false /* Metadata: 0x00AEA3C9 */) { } // 0x000000018268FAD0-0x000000018268FBD0
                                                                                                                                         // [IDTag] // 0x0000000189877BE0-0x0000000189877C20
                                                                                                                                         // [XID] // 0x0000000189877BE0-0x0000000189877C20
    private bool ResetOverrideAnimeInternal(string stateId, IAnimeOverrideReason reason, bool immediately) => default; // 0x00000001826A1840-0x00000001826A1980
                                                                                                                       // [XID] // 0x0000000189882080-0x00000001898820A0
    private bool CheckAnimeNeedReset(AnimeLoadInfo info, bool immediately) => default; // 0x000000018268AC10-0x000000018268AE60
                                                                                       // [XID] // 0x0000000189AF67D0-0x0000000189AF67F0
    private bool TickRecycleOverrideAnimes() => default; // 0x0000000182688020-0x00000001826882B0
                                                         // [IDTag] // 0x0000000189890BC0-0x0000000189890C00
                                                         // [XID] // 0x0000000189890BC0-0x0000000189890C00
    private bool ResetOverrideAnimeInternal(string[] stateIdList, IAnimeOverrideReason reason, bool immediately) => default; // 0x00000001826A1980-0x00000001826A1AC0
                                                                                                                             // [XID] // 0x000000018989B390-0x000000018989B3B0
    public void ResetOverrideAnimeByFreeStyle(int freeStyle, IAnimeOverrideReason reason, bool immediately = false /* Metadata: 0x00AEA3CA */) { } // 0x0000000182690E80-0x0000000182690F80
                                                                                                                                                   // [XID] // 0x00000001897366F0-0x0000000189736710
    private bool ResetOverrideAnimeByFreeStyleInternal(int freeStyle, IAnimeOverrideReason reason, bool immediately) => default; // 0x000000018267B190-0x000000018267B290
                                                                                                                                 // [XID] // 0x000000018973E4C0-0x000000018973E4E0
    public void ResetOverrideAnimeByFreeStyleList(int[] freeStyleList, IAnimeOverrideReason reason, bool immediately = false /* Metadata: 0x00AEA3CB */) { } // 0x0000000182678670-0x00000001826787C0
                                                                                                                                                             // [XID] // 0x00000001898B17F0-0x00000001898B1810
    private void ClearOverrideAnimesImpl() { } // 0x0000000182676250-0x0000000182676470
                                               // [XID] // 0x00000001898B9140-0x00000001898B9160
    private void CreateAnimeRecycleTimer() { } // 0x00000001826A80D0-0x00000001826A8260
                                               // [XID] // 0x00000001898C0700-0x00000001898C0720
    private void ReleaseAnimeRecycleTimer() { } // 0x0000000182682340-0x00000001826823F0
                                                // [XID] // 0x00000001898C7EE0-0x00000001898C7F00
    private void InitOverrideAnimeImpl() { } // 0x0000000182698710-0x0000000182698900
                                             // [XID] // 0x00000001898A4380-0x00000001898A43A0
    private void OnAnimeLoadFinish() { } // 0x00000001826A1260-0x00000001826A14B0
                                         // [XID] // 0x00000001898D6F70-0x00000001898D6F90
    private void DelayCheckAnimeLoadFinish() { } // 0x0000000182698D10-0x0000000182698DC0
                                                 // [XID] // 0x0000000189745850-0x0000000189745870
    public void ForceCacheFreeStyle(int freeStyle) { } // 0x00000001826A60A0-0x00000001826A62F0
                                                       // [XID] // 0x00000001898E63D0-0x00000001898E63F0
    public string AllPreloadersToDebugString() => default; // 0x00000001826A8260-0x00000001826A8450
                                                           // [XID] // 0x000000018976AD50-0x000000018976AD70
    protected virtual EntityPreloader GetPreloder(ConfigPreloadType preloadType, bool withCreate = false /* Metadata: 0x00AEA3CC */) => default; // 0x0000000182696660-0x00000001826967C0
                                                                                                                                                 // [XID] // 0x00000001898F5670-0x00000001898F5690
    public void Preload(ConfigPreloadType preloadType) { } // 0x0000000182684440-0x0000000182684530
                                                           // [XID] // 0x00000001898FCD80-0x00000001898FCDA0
    public void PreloadAsync(ConfigPreloadType preloadType, Action preloadedCallback = null) { } // 0x0000000182696CC0-0x0000000182696DE0
                                                                                                 // [XID] // 0x0000000189904720-0x0000000189904740
    public void ReleasePreloaded(ConfigPreloadType preloadType) { } // 0x00000001826951F0-0x00000001826952E0
                                                                    // [XID] // 0x000000018990BEE0-0x000000018990BF00
    public void ReleaseAllPreloaded() { } // 0x000000018268F0B0-0x000000018268F180
                                          // [XID] // 0x00000001899A8680-0x00000001899A86A0
    public bool IsPreloaded(ConfigPreloadType preloadType) => default; // 0x00000001826A3440-0x00000001826A3520
                                                                       // [XID] // 0x000000018991B220-0x000000018991B240
    private bool EnablePreload() => default; // 0x000000018267C9E0-0x000000018267CA80
                                             // [XID] // 0x00000001899227F0-0x0000000189922810
    private EPreloadEntityType GetPreloadEntityType() => default; // 0x000000018268CF80-0x000000018268D1A0
                                                                  // [XID] // 0x000000018996A130-0x000000018996A150
    public void RegisterDefaultMaterialGroup(MaterialGroup group) { } // 0x0000000182694A40-0x0000000182694AF0
                                                                      // [XID] // 0x0000000189979800-0x0000000189979820
    public void RegisterInstanceMaterialGroup(MaterialGroup group) { } // 0x00000001826916C0-0x0000000182691770
                                                                       // [XID] // 0x00000001899FA7D0-0x00000001899FA7F0
    public void SetAniamtorCullModeExternal(bool value) { } // 0x0000000182692260-0x0000000182692310
                                                            // [XID] // 0x0000000189A6A460-0x0000000189A6A480
    public void SetForceDontUseUpdateRigidbody(bool forceDontUse) { } // 0x0000000182693DA0-0x0000000182693E50
                                                                      // [XID] // 0x0000000189A71890-0x0000000189A718B0
    public void SetPreloadObjectScale(float scale) { } // 0x000000018268EBA0-0x000000018268ED50
                                                       // [XID] // 0x0000000189A01C00-0x0000000189A01C20
    public void CreateTimer() { } // 0x000000018268B450-0x000000018268B600
                                  // [XID] // 0x0000000189A809C0-0x0000000189A809E0
    public void ReleaseTimer() { } // 0x0000000182686400-0x00000001826864F0
                                   // [XID] // 0x0000000189A88480-0x0000000189A884A0
    public bool IsTimerActive() => default; // 0x000000018267F220-0x000000018267F2E0
                                            // [XID] // 0x0000000189B28D50-0x0000000189B28D70
    protected void ReleaseRealEntity() { } // 0x000000018268B820-0x000000018268B9F0
                                           // [XID] // 0x00000001895E85F0-0x00000001895E8610
    public virtual void InitVisual(ulong prefabPathHash, Vector3 initPos, Quaternion initRotation, float initUniformScale, bool anyncLoad, bool createDummyGameObject = false /* Metadata: 0x00AEA3CD */, bool forceDontUseUpdateRigidbody = false /* Metadata: 0x00AEA3CE */, GameObject givenGameObject = null, Action<BaseEntity> jsonConfigLoadedCallback = null)
    {
        this.initPos = initPos;
        this.initRotation = initRotation;
        this.initUniformScale = initUniformScale;
        _preloadIndex = 0;
        _forceDontUseUpdateRigidbody = forceDontUseUpdateRigidbody;
        _jsonConfigLoadedCallback = jsonConfigLoadedCallback;
        if (ExternalResourceProvider.instance.IsBatchCollect || entityType != EntityType.Camera || entityType != EntityType.Level || entityType != EntityType.MPLevel || entityType != EntityType.Team)
        {
            anyncLoad = true;
        }
        if (givenGameObject)
        {
            gameObject = givenGameObject;
            gameObject.transform.position = WorldShiftManager.GetRelativePosition(initPos);
            gameObject.transform.rotation = initRotation;
            gameObject.transform.localScale = new Vector3(initUniformScale, initUniformScale, initUniformScale);
            if (anyncLoad)
            {
                PreloadAsync(ConfigPreloadType.onCreate, PreloadAsyncCallback);
            }
            else
            {
                Preload(ConfigPreloadType.onCreate);
                PreloadAsyncCallback();
            }
            _isEntityAsyncLoad = anyncLoad;
            _tokenMgr.HandleEntityCreateToken(_isEntityAsyncLoad, this);
        }
        else
        {
            this.prefabPathHash = prefabPathHash;
            if (Miscs.IsEmptyPath(prefabPathHash))
            {
                _useDummyPrefab = true;
                if (!ExternalResourceProvider.instance.IsBatchCollect)
                    anyncLoad = false;
            }
            _createDummyGameObject = createDummyGameObject;
            _isEntityAsyncLoad = anyncLoad;
            _tokenMgr.HandleEntityCreateToken(_isEntityAsyncLoad, this);
            if (anyncLoad)
            {
                if (_useDummyPrefab)
                {
                    if (_createDummyGameObject)
                    {
                        gameObject = new GameObject();
                        gameObject.name = entityType.ToString();
                        gameObject.transform.position = WorldShiftManager.GetRelativePosition(initPos);
                        gameObject.transform.rotation = initRotation;
                    }
                    PreloadAsync(ConfigPreloadType.onCreate, PreloadAsyncCallback);
                }
                else
                {
                    AsyncLoadResource();
                }
            }
            else
            {
                if (_useDummyPrefab)
                {
                    if (_createDummyGameObject)
                    {
                        gameObject = new GameObject();
                        gameObject.name = entityType.ToString();
                        gameObject.transform.position = WorldShiftManager.GetRelativePosition(initPos);
                        gameObject.transform.rotation = initRotation;
                    }
                }
                else
                {
                    _isGameObjectFromPool = true;
                    _gameObjectNode = EntityFactory.GetGameObjectNode(configID);
                    if (_gameObjectNode != null)
                    {
                        gameObject = _gameObjectNode.gameObject;
                        _gameObjectResourceHandle = _gameObjectNode.gameObjectResourceHandle;
                    }
                    else
                    {
                        gameObject = CommonMiscs.LoadPrefab(prefabPathHash, ref _gameObjectResourceHandle);
                        _isGameObjectFromPool = false;
                    }
                    if (gameObject)
                    {
                        BaseEntity entity = this;
                        SetToBeRemoved<BaseEntity>(ref entity);
                        DestroyGameObject();
                        return;
                    }
                    else
                    {
                        SuperDebug.Assert(false, "gamePrefab should not be null, PathHash is" + prefabPathHash);
                    }

                    gameObject.transform.position = WorldShiftManager.GetRelativePosition(initPos);
                    gameObject.transform.rotation = initRotation;
                    if (!_isGameObjectFromPool)
                    {
                        gameObject.SetActive(true);
                    }
                }
                if (gameObject) gameObject.transform.localScale = new Vector3(initUniformScale, initUniformScale, initUniformScale);
                Preload(ConfigPreloadType.onCreate);
                if (_jsonConfigLoadedCallback != null) _jsonConfigLoadedCallback(this);
                OnLoadFinished();
            }
        }
    } // 0x00000001826882B0-0x00000001826890E0
      // [XID] // 0x0000000189B89F00-0x0000000189B89F20
    protected void PreloadAsyncCallback()
    {
        if (_jsonConfigLoadedCallback != null)
        {
            _jsonConfigLoadedCallback(this);
        }
        OnLoadFinished();
    } // 0x00000001826910C0-0x0000000182691180
      // [XID] // 0x0000000189ABB730-0x0000000189ABB750
    public void ReInitTransform(Vector3 initPos, Quaternion initRotation, float uniformScale) { } // 0x0000000182687CF0-0x0000000182687ED0
                                                                                                  // [XID] // 0x0000000189733560-0x0000000189733580
    public void ResetTransform(Vector3 position, Quaternion rotation, float uniformScale) { } // 0x000000018268D4A0-0x000000018268D5E0
                                                                                              // [XID] // 0x0000000189ACA460-0x0000000189ACA480
    public Rigidbody GetRigidbody() => default; // 0x000000018268E620-0x000000018268E6D0
                                                // [XID] // 0x0000000189AD1F20-0x0000000189AD1F40
    public virtual Vector3 GetAbsolutePosition() => default; // 0x0000000182685630-0x0000000182685830
                                                             // [XID] // 0x0000000189AD99B0-0x0000000189AD99D0
    public virtual Vector3 GetRelativePosition() => default; // 0x00000001826845A0-0x0000000182684790
                                                             // [XID] // 0x000000018973AE30-0x000000018973AE50
    public virtual Vector3 GetRigidbodyAbsolutePosition() => default; // 0x0000000182690AF0-0x0000000182690CB0
                                                                      // [XID] // 0x0000000189AE8A50-0x0000000189AE8A70
    public Vector3 GetAbsolutePositionFast() => default; // 0x000000018268EED0-0x000000018268EFC0
                                                         // [IDTag] // 0x0000000189AF08A0-0x0000000189AF08E0
                                                         // [XID] // 0x0000000189AF08A0-0x0000000189AF08E0
    public Vector3 GetAbsolutePositionForPredicate() => default; // 0x000000018268C2D0-0x000000018268C410
                                                                 // [IDTag] // 0x0000000189AFAFC0-0x0000000189AFB000
                                                                 // [XID] // 0x0000000189AFAFC0-0x0000000189AFB000
    public Vector3 GetAbsolutePositionForPredicate(Vector3 selfPos) => default; // 0x000000018268C6E0-0x000000018268C820
                                                                                // [IDTag] // 0x0000000189B052F0-0x0000000189B05330
                                                                                // [XID] // 0x0000000189B052F0-0x0000000189B05330
    private Vector3 GetAbsolutePositionForPredicate(bool useSelfPos, Vector3 selfPos) => default; // 0x000000018268C410-0x000000018268C6E0
                                                                                                  // [XID] // 0x00000001898B2D40-0x00000001898B2D60
    public Vector3 GetRelativePositionForPredicate() => default; // 0x000000018267F670-0x000000018267F840
                                                                 // [XID] // 0x0000000189B16CC0-0x0000000189B16CE0
    public void PushMassRatio(int value, float ratio) { } // 0x000000018269CF50-0x000000018269D180
                                                          // [XID] // 0x00000001899DB0C0-0x00000001899DB0E0
    public void SetParent(Transform trans, bool worldPositionStays = true /* Metadata: 0x00AEA3CF */) { } // 0x000000018269B450-0x000000018269B6F0
                                                                                                          // [XID] // 0x0000000189B25E60-0x0000000189B25E80
    public void SetRelativePosition(Vector3 position, bool forceSyncToRigidbody = false /* Metadata: 0x00AEA3D0 */) { } // 0x000000018267D390-0x000000018267D500
                                                                                                                        // [XID] // 0x0000000189676DB0-0x0000000189676DD0
    public void SetAbsolutePosition(Vector3 abpos, bool forceSyncToRigidbody = false /* Metadata: 0x00AEA3D1 */) { } // 0x000000018268ED50-0x000000018268EED0
                                                                                                                     // [XID] // 0x0000000189B346B0-0x0000000189B346D0
    public void EnableSetPosition(bool enable) { } // 0x00000001826A50A0-0x00000001826A5150
                                                   // [XID] // 0x00000001899A8660-0x00000001899A8680
    private void SetBothPosition(Vector3 offsetPos, Vector3 absPos, bool forceSyncToRigidbody) { } // 0x000000018269D690-0x000000018269DA80
                                                                                                   // [IDTag] // 0x0000000189B43A90-0x0000000189B43AD0
                                                                                                   // [XID] // 0x0000000189B43A90-0x0000000189B43AD0
    public void ResetParentTrans() { } // 0x0000000182695CF0-0x0000000182695ED0
                                       // [IDTag] // 0x0000000189B4E2D0-0x0000000189B4E310
                                       // [XID] // 0x0000000189B4E2D0-0x0000000189B4E310
    public void ResetParentTrans(Transform trans) { } // 0x0000000182695B10-0x0000000182695CF0
                                                      // [XID] // 0x0000000189B58D40-0x0000000189B58D60
    public Vector3 GetForward() => default; // 0x0000000182697920-0x0000000182697B30
                                            // [XID] // 0x0000000189B60410-0x0000000189B60430
    public Vector3 GetForwardFast() => default; // 0x000000018268D3B0-0x000000018268D4A0
                                                // [XID] // 0x0000000189B67BD0-0x0000000189B67BF0
    public Vector3 GetRight() => default; // 0x0000000182694BD0-0x0000000182694DE0
                                          // [XID] // 0x00000001898A42A0-0x00000001898A42C0
    public Vector3 GetUp() => default; // 0x00000001826864F0-0x0000000182686700
                                       // [XID] // 0x0000000189B765F0-0x0000000189B76610
    public void SetTransformYaw(float yaw, bool immediately = true /* Metadata: 0x00AEA3D2 */) { } // 0x00000001826876B0-0x0000000182687920
                                                                                                   // [XID] // 0x00000001899B5B40-0x00000001899B5B60
    public void SetTransformForward(Vector3 forward, bool keepHorizontal = true /* Metadata: 0x00AEA3D3 */, bool immediately = true /* Metadata: 0x00AEA3D4 */) { } // 0x000000018269B6F0-0x000000018269BA00
                                                                                                                                                                    // [XID] // 0x0000000189B85880-0x0000000189B858A0
    public void SetTransformForwardKeepUpAxis(Vector3 forward, bool immediately = true /* Metadata: 0x00AEA3D5 */) { } // 0x0000000182695ED0-0x0000000182696380
                                                                                                                       // [XID] // 0x0000000189B8C690-0x0000000189B8C6B0
    public virtual Quaternion GetRotation() => default; // 0x00000001826821A0-0x0000000182682340
                                                        // [XID] // 0x0000000189B94070-0x0000000189B94090
    public virtual Vector3 GetEulerAngles() => default; // 0x00000001826A3860-0x00000001826A3A30
                                                        // [XID] // 0x0000000189B9B610-0x0000000189B9B630
    public virtual void SetEulerAngles(Vector3 euler, bool immediately = true /* Metadata: 0x00AEA3D6 */) { } // 0x000000018269BFB0-0x000000018269C1C0
                                                                                                              // [XID] // 0x0000000189BA2D70-0x0000000189BA2D90
    public void SetRotation(Quaternion rotation, bool immediately = true /* Metadata: 0x00AEA3D7 */) { } // 0x00000001826A1B20-0x00000001826A1ED0
                                                                                                         // [XID] // 0x0000000189BAA1A0-0x0000000189BAA1C0
    private void OnTransformPosRotateChanged() { } // 0x00000001826A35D0-0x00000001826A36B0
                                                   // [XID] // 0x0000000189BB19A0-0x0000000189BB19C0
    public void SetUniformScale(float uniformScale) { } // 0x00000001826A2250-0x00000001826A24B0
                                                        // [XID] // 0x0000000189BB8980-0x0000000189BB89A0
    public virtual Transform GetAttachPoint(string name) => default; // 0x0000000182686700-0x0000000182686990
                                                                     // [XID] // 0x0000000189BC0340-0x0000000189BC0360
    public void SetDynamicPointPos(string name, Vector3 pos) { } // 0x000000018269D4D0-0x000000018269D690
                                                                 // [XID] // 0x0000000189895340-0x0000000189895360
    public void SetWorldDynamicPointPos(string name, Vector3 pos, bool disableWhenEntityDisable = false /* Metadata: 0x00AEA3D8 */) { } // 0x0000000182689C60-0x0000000182689E40
                                                                                                                                        // [XID] // 0x00000001899FEEE0-0x00000001899FEF00
    public bool HideLocalEntity(Vector3 checkPos) => default; // 0x0000000182687920-0x0000000182687B00
                                                              // [XID] // 0x0000000189BD6D40-0x0000000189BD6D60
    protected void AsyncLoadResource() { } // 0x00000001826A0D40-0x00000001826A10B0
                                           // [XID] // 0x0000000189BDEAE0-0x0000000189BDEB00
    private void ConfigFinish() { } // 0x000000018267CAE0-0x000000018267CBA0
                                    // [XID] // 0x00000001895EB530-0x00000001895EB550
    private void PreloadFinish() { } // 0x0000000182686A40-0x0000000182686BF0
                                     // [XID] // 0x00000001895F2940-0x00000001895F2960
    private void AsyncLoadGameObject() { } // 0x000000018267CD60-0x000000018267D390
                                           // [XID] // 0x0000000189715870-0x0000000189715890
    private void AsyncLoadGameObjectCallback(ulong hash, bool loadSucceeded, uint handle, GameObject prefab) { } // 0x0000000182689660-0x0000000182689A10
                                                                                                                 // [XID] // 0x00000001898B5E50-0x00000001898B5E70
    private void CheckJsonConfig() { } // 0x000000018268A730-0x000000018268A7E0
                                       // [XID] // 0x0000000189609460-0x0000000189609480
    public void ResetParent() { } // 0x00000001826823F0-0x0000000182682AD0
                                  // [XID] // 0x0000000189B91570-0x0000000189B91590
    private void OnLoadFinished(bool checkValid = true /* Metadata: 0x00AEA3D9 */) { } // 0x000000018267D500-0x000000018267F160
                                                                                       // [XID] // 0x0000000189617F10-0x0000000189617F30
    private void DestroyGameObject() { } // 0x0000000182679220-0x0000000182679680
                                         // [XID] // 0x00000001899526E0-0x0000000189952700
    private void ClearGameObject() { } // 0x000000018268DB70-0x000000018268DCF0
                                       // [XID] // 0x0000000189626EB0-0x0000000189626ED0
    private void CheckRigidbodyKinematic() { } // 0x00000001826A79C0-0x00000001826A7AB0
                                               // [XID] // 0x000000018962E820-0x000000018962E840
    public void EnableRigidbodyKinematic(bool enable, SetKinematicPriority priority) { } // 0x000000018269F210-0x000000018269F430
                                                                                         // [XID] // 0x0000000189822760-0x0000000189822780
    private void ClearRigidbodyKinematic() { } // 0x000000018268FBD0-0x000000018268FD80
                                               // [XID] // 0x000000018963DAF0-0x000000018963DB10
    public Animator GetAnimator() => default; // 0x000000018268CD50-0x000000018268CE00
                                              // [XID] // 0x00000001896450A0-0x00000001896450C0
    public void ForceUpdateRigidbodyRotationCurFrame() { } // 0x00000001826A0AF0-0x00000001826A0B90
                                                           // [XID] // 0x0000000189638020-0x0000000189638040
    public virtual void UpdateRigidbody() { } // 0x0000000182694360-0x00000001826948B0
                                              // [XID] // 0x0000000189653F90-0x0000000189653FB0
    public bool IsVisible() => default; // 0x0000000182675F30-0x0000000182676140
                                        // [XID] // 0x0000000189A490B0-0x0000000189A490D0
    public void ActorHide(bool enable) { } // 0x000000018269C910-0x000000018269C9E0
                                           // [XID] // 0x0000000189672530-0x0000000189672550
    public void RoomHide(bool hide) { } // 0x00000001826A4750-0x00000001826A4850
                                        // [XID] // 0x0000000189679DA0-0x0000000189679DC0
    private void RecoverAnimatorSpeed() { } // 0x00000001826A62F0-0x00000001826A63F0
                                            // [XID] // 0x00000001896814C0-0x00000001896814E0
    public void SetRigidbodyCollisionDetectionMode(CollisionDetectionMode collisionDetectionMode) { } // 0x0000000182677830-0x0000000182677960
                                                                                                      // [XID] // 0x0000000189688FC0-0x0000000189688FE0
    public void ResetRigidbodyCollisionDetectionMode() { } // 0x00000001826A65C0-0x00000001826A66F0
                                                           // [XID] // 0x0000000189B886A0-0x0000000189B886C0
    public virtual bool ShiftWorld(Vector3 newShift, Vector3 oldShift) => default; // 0x000000018269FCE0-0x000000018269FF80
                                                                                   // [XID] // 0x0000000189698380-0x00000001896983A0
    protected bool CanUseRemotePrefab() => default; // 0x00000001826775B0-0x0000000182677710
                                                    // [XID] // 0x000000018969F640-0x000000018969F660
    protected void CheckRuntimeAnimatorController() { } // 0x0000000182699BD0-0x000000018269A0C0
                                                        // [XID] // 0x00000001899E4020-0x00000001899E4040
    protected void ChangeMPRuntimeAnimatorController() { } // 0x0000000182692D80-0x0000000182693520
                                                           // [IDTag] // 0x00000001896AE0B0-0x00000001896AE0F0
                                                           // [XID] // 0x00000001896AE0B0-0x00000001896AE0F0
    public MonoEffectProxy FireEffectWithToken(EntityInternalAction actionLevel, string effectName, bool isHitEffect = false /* Metadata: 0x00AEA3DA */, float scale = 1f /* Metadata: 0x00AEA3DB */, Transform followTransform = null) => default; // 0x00000001826809D0-0x0000000182680EA0
                                                                                                                                                                                                                                                    // [IDTag] // 0x0000000189A0DE60-0x0000000189A0DEA0
                                                                                                                                                                                                                                                    // [XID] // 0x0000000189A0DE60-0x0000000189A0DEA0
    public MonoEffectProxy FireEffect(string effectName, bool isHitEffect = false /* Metadata: 0x00AEA3DF */, float scale = 1f /* Metadata: 0x00AEA3E0 */, Transform followTransform = null, bool ignoreToken = false /* Metadata: 0x00AEA3E4 */, bool asyncCreate = false /* Metadata: 0x00AEA3E5 */) => default; // 0x00000001826A0090-0x00000001826A0570
                                                                                                                                                                                                                                                                                                                   // [IDTag] // 0x00000001896C25C0-0x00000001896C2600
                                                                                                                                                                                                                                                                                                                   // [XID] // 0x00000001896C25C0-0x00000001896C2600
    public MonoEffectProxy FireEffectWithToken(EntityInternalAction actionLevel, string effectName, Vector3 initPos, Quaternion initRot, bool isHitEffect = false /* Metadata: 0x00AEA3E6 */, float scale = 1f /* Metadata: 0x00AEA3E7 */, Vector3? targetDir = default) => default; // 0x0000000182680EA0-0x0000000182681340
                                                                                                                                                                                                                                                                                     // [IDTag] // 0x00000001896CCDC0-0x00000001896CCE00
                                                                                                                                                                                                                                                                                     // [XID] // 0x00000001896CCDC0-0x00000001896CCE00
    public MonoEffectProxy FireEffect(string effectName, Vector3 initPos, Quaternion initRot, bool isHitEffect = false /* Metadata: 0x00AEA3EB */, float scale = 1f /* Metadata: 0x00AEA3EC */, bool ignoreToken = false /* Metadata: 0x00AEA3F0 */) => default; // 0x00000001826A0570-0x00000001826A09E0
                                                                                                                                                                                                                                                                 // [XID] // 0x00000001896D72E0-0x00000001896D7300
    public void FireEffectTo(string effectName, Vector3 initPos, Vector3 targetPos, bool isHitEffect = false /* Metadata: 0x00AEA3F1 */) { } // 0x000000018267C110-0x000000018267C5A0
                                                                                                                                             // [XID] // 0x00000001896DEB70-0x00000001896DEB90
    public int AttachEffect(string effectName, Vector3? pos = default, Quaternion? rot = default, float scale = 1f /* Metadata: 0x00AEA3F2 */, bool ignoreToken = false /* Metadata: 0x00AEA3F6 */) => default; // 0x0000000182683CA0-0x0000000182683F50
                                                                                                                                                                                                                // [XID] // 0x000000018982E4B0-0x000000018982E4D0
    public int AttachEffectAllowDelay(EntityInternalAction actionLevel, string effectName, Vector3? pos = default, Quaternion? rot = default, float scale = 1f /* Metadata: 0x00AEA3F7 */, bool isHitEffect = false /* Metadata: 0x00AEA3FB */) => default; // 0x000000018269DD60-0x000000018269E140
                                                                                                                                                                                                                                                            // [XID] // 0x00000001896ED410-0x00000001896ED430
    public void DetachEffect(int index) { } // 0x00000001826A8E40-0x00000001826A8F30
                                            // [XID] // 0x0000000189699910-0x0000000189699930
    public void DetachEffectAllowDelay(EntityInternalAction actionLevel, int index) { } // 0x00000001826841C0-0x00000001826842F0
                                                                                        // [XID] // 0x00000001896E7790-0x00000001896E77B0
    public void StopAllEffects() { } // 0x00000001826A45D0-0x00000001826A46F0
                                     // [XID] // 0x00000001899FD7D0-0x00000001899FD7F0
    private void ApplyAnimatorProperties() { } // 0x00000001826A4A80-0x00000001826A4C40
                                               // [XID] // 0x0000000189A9A940-0x0000000189A9A960
    public void RecoverAnimator() { } // 0x0000000182684000-0x00000001826840E0
                                      // [XID] // 0x0000000189A628E0-0x0000000189A62900
    public bool HasAnimator() => default; // 0x00000001826A4970-0x00000001826A4A80
                                          // [XID] // 0x000000018971A370-0x000000018971A390
    private void ClearPersistentParams() { } // 0x000000018268EFC0-0x000000018268F0B0
                                             // [IDTag] // 0x0000000189721600-0x0000000189721640
                                             // [XID] // 0x0000000189721600-0x0000000189721640
    public void SetAnimatorTrigger(string name) { } // 0x000000018267B6B0-0x000000018267B850
                                                    // [IDTag] // 0x000000018972BC00-0x000000018972BC40
                                                    // [XID] // 0x000000018972BC00-0x000000018972BC40
    public virtual void SetAnimatorTrigger(int id) { } // 0x000000018267B850-0x000000018267B9E0
                                                       // [IDTag] // 0x00000001897364F0-0x0000000189736530
                                                       // [XID] // 0x00000001897364F0-0x0000000189736530
    public void ResetAnimatorTrigger(string name) { } // 0x0000000182681F70-0x0000000182682090
                                                      // [IDTag] // 0x0000000189740FE0-0x0000000189741020
                                                      // [XID] // 0x0000000189740FE0-0x0000000189741020
    public void ResetAnimatorTrigger(int id) { } // 0x0000000182682090-0x00000001826821A0
                                                 // [XID] // 0x000000018974B830-0x000000018974B850
    protected void OnAnimatorParameterSetTrigger(int id, bool triggerValue) { } // 0x0000000182691310-0x0000000182691500
                                                                                // [IDTag] // 0x0000000189752C30-0x0000000189752C70
                                                                                // [XID] // 0x0000000189752C30-0x0000000189752C70
    public void SetAnimatorBool(string name, bool value, bool persistent = false /* Metadata: 0x00AEA3FC */) { } // 0x00000001826A8AD0-0x00000001826A8C90
                                                                                                                 // [IDTag] // 0x000000018975D0E0-0x000000018975D120
                                                                                                                 // [XID] // 0x000000018975D0E0-0x000000018975D120
    public void SetAnimatorBool(int id, bool value, bool persistent = false /* Metadata: 0x00AEA3FD */) { } // 0x00000001826A8C90-0x00000001826A8E40
                                                                                                            // [XID] // 0x0000000189767780-0x00000001897677A0
    private void OnAnimatorParameterSetBool(int id, bool boolValue, bool persistent) { } // 0x0000000182687110-0x0000000182687380
                                                                                         // [IDTag] // 0x000000018976EE90-0x000000018976EED0
                                                                                         // [XID] // 0x000000018976EE90-0x000000018976EED0
    public void SetAnimatorInt(string name, int value, bool persistent = false /* Metadata: 0x00AEA3FE */) { } // 0x0000000182682C50-0x0000000182682E10
                                                                                                               // [IDTag] // 0x0000000189779900-0x0000000189779940
                                                                                                               // [XID] // 0x0000000189779900-0x0000000189779940
    public void SetAnimatorInt(int id, int value, bool persistent = false /* Metadata: 0x00AEA3FF */) { } // 0x0000000182682E10-0x0000000182682FC0
                                                                                                          // [XID] // 0x00000001897840E0-0x0000000189784100
    private void OnAnimatorParameterSetInt(int id, int intValue, bool persistent) { } // 0x0000000182699320-0x0000000182699570
                                                                                      // [IDTag] // 0x000000018978B890-0x000000018978B8D0
                                                                                      // [XID] // 0x000000018978B890-0x000000018978B8D0
    public void SetAnimatorFloat(string name, float value, float dampTime = 0f /* Metadata: 0x00AEA400 */, float deltaTime = 0f /* Metadata: 0x00AEA404 */, bool persistent = false /* Metadata: 0x00AEA408 */) { } // 0x000000018268C0C0-0x000000018268C2D0
                                                                                                                                                                                                                    // [IDTag] // 0x0000000189795C80-0x0000000189795CC0
                                                                                                                                                                                                                    // [XID] // 0x0000000189795C80-0x0000000189795CC0
    public void SetAnimatorFloat(string name, float value, float linearSmoothTime, bool persistent = false /* Metadata: 0x00AEA409 */) { } // 0x000000018268BE50-0x000000018268C0C0
                                                                                                                                           // [IDTag] // 0x00000001897A0AB0-0x00000001897A0AF0
                                                                                                                                           // [XID] // 0x00000001897A0AB0-0x00000001897A0AF0
    public void SetAnimatorFloat(int id, float value, float dampTime = 0f /* Metadata: 0x00AEA40A */, float deltaTime = 0f /* Metadata: 0x00AEA40E */, bool persistent = false /* Metadata: 0x00AEA412 */) { } // 0x000000018268B9F0-0x000000018268BBF0
                                                                                                                                                                                                               // [IDTag] // 0x00000001897AAEA0-0x00000001897AAEE0
                                                                                                                                                                                                               // [XID] // 0x00000001897AAEA0-0x00000001897AAEE0
    public void SetAnimatorFloat(int id, float value, float linearSmoothTime, bool persistent = false /* Metadata: 0x00AEA413 */) { } // 0x000000018268BBF0-0x000000018268BE50
                                                                                                                                      // [XID] // 0x00000001897B6370-0x00000001897B6390
    private void TryRemoveFromLinerSmoothAnimatorFloats(int id) { } // 0x000000018269E710-0x000000018269E880
                                                                    // [XID] // 0x00000001897BE0E0-0x00000001897BE100
    private void TryRefreshLinerSmoothAnimatorFloats(int nameId, float originValue, float targetValue, float smoothTime) { } // 0x000000018267AE90-0x000000018267B120
                                                                                                                             // [XID] // 0x0000000189900210-0x0000000189900230
    private void OnAnimatorParameterSetFloat(int id, float floatValue, bool persistent) { } // 0x00000001826A4E60-0x00000001826A50A0
                                                                                            // [IDTag] // 0x00000001897CCDC0-0x00000001897CCE00
                                                                                            // [XID] // 0x00000001897CCDC0-0x00000001897CCE00
    public bool HasAnimatorParameter(string name) => default; // 0x000000018269A1D0-0x000000018269A2E0
                                                              // [IDTag] // 0x00000001897D7650-0x00000001897D7690
                                                              // [XID] // 0x00000001897D7650-0x00000001897D7690
    public bool HasAnimatorParameter(int id) => default; // 0x000000018269A0C0-0x000000018269A1D0
                                                         // [IDTag] // 0x00000001897E1DC0-0x00000001897E1E00
                                                         // [XID] // 0x00000001897E1DC0-0x00000001897E1E00
    public bool GetAnimatorTrigger(string name) => default; // 0x0000000182696A10-0x0000000182696BB0
                                                            // [IDTag] // 0x00000001897EC9B0-0x00000001897EC9F0
                                                            // [XID] // 0x00000001897EC9B0-0x00000001897EC9F0
    public bool GetAnimatorTrigger(int id) => default; // 0x0000000182696870-0x0000000182696A10
                                                       // [IDTag] // 0x00000001897F6F20-0x00000001897F6F60
                                                       // [XID] // 0x00000001897F6F20-0x00000001897F6F60
    public bool GetAnimatorBool(string name) => default; // 0x000000018269EC30-0x000000018269EDD0
                                                         // [IDTag] // 0x0000000189801930-0x0000000189801970
                                                         // [XID] // 0x0000000189801930-0x0000000189801970
    public bool GetAnimatorBool(int id) => default; // 0x000000018269EDD0-0x000000018269EF70
                                                    // [IDTag] // 0x000000018980BB90-0x000000018980BBD0
                                                    // [XID] // 0x000000018980BB90-0x000000018980BBD0
    public int GetAnimatorInt(string name) => default; // 0x0000000182684920-0x0000000182684AB0
                                                       // [IDTag] // 0x00000001898164F0-0x0000000189816530
                                                       // [XID] // 0x00000001898164F0-0x0000000189816530
    public int GetAnimatorInt(int id) => default; // 0x0000000182684790-0x0000000182684920
                                                  // [IDTag] // 0x0000000189821150-0x0000000189821190
                                                  // [XID] // 0x0000000189821150-0x0000000189821190
    public float GetAnimatorFloat(string name) => default; // 0x000000018268DCF0-0x000000018268DEA0
                                                           // [IDTag] // 0x000000018982B530-0x000000018982B570
                                                           // [XID] // 0x000000018982B530-0x000000018982B570
    public float GetAnimatorFloat(int id) => default; // 0x000000018268DEA0-0x000000018268E050
                                                      // [XID] // 0x00000001899AFEB0-0x00000001899AFED0
    public void ResetAnimatorParameters() { } // 0x00000001826834B0-0x0000000182683630
                                              // [XID] // 0x0000000189A38DB0-0x0000000189A38DD0
    private void SyncAnimatorParameters() { } // 0x0000000182692310-0x0000000182692760
                                              // [XID] // 0x0000000189B03DB0-0x0000000189B03DD0
    private void TickAnimatorParameters() { } // 0x0000000182678130-0x00000001826784B0
                                              // [XID] // 0x000000018984BD50-0x000000018984BD70
    private void OnMassChangedByAbility() { } // 0x00000001826A92F0-0x00000001826A9420
                                              // [XID] // 0x00000001897BFAF0-0x00000001897BFB10
    private void RegisterMassAddByAbility() { } // 0x0000000182683630-0x0000000182683730
                                                // [XID] // 0x00000001897BE320-0x00000001897BE340
    private void UnRegisterMassAddByAbility() { } // 0x00000001826A0C40-0x00000001826A0D40
                                                  // [XID] // 0x00000001897B2E80-0x00000001897B2EA0
    private void SyncAnimatorSpeed() { } // 0x000000018269EA10-0x000000018269EC30
                                         // [XID] // 0x0000000189869210-0x0000000189869230
    public Vector3 GetFaceToTargetDirection(float inDeltaTime, Vector3 targetDir, float maxAngle = 36000f /* Metadata: 0x00AEA414 */) => default; // 0x0000000182697480-0x0000000182697870
                                                                                                                                                  // [XID] // 0x0000000189A1B080-0x0000000189A1B0A0
    public void ClearOnTimelineFinish() { } // 0x0000000182678060-0x0000000182678130
                                            // [XID] // 0x0000000189A38D30-0x0000000189A38D50
    public bool GetEntityHeight(out float entityHeight, float defaultHeight = 0f /* Metadata: 0x00AEA418 */)
    {
        entityHeight = default;
        return default;
    } // 0x0000000182683060-0x0000000182683340
    private string __iFixBaseProxy_ToString() => default; // 0x000000018267AD70-0x000000018267ADE0
}

