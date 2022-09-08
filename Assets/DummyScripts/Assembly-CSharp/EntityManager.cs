/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using miHoYoThread;
using MoleMole;
using MoleMole.Config;
using UnityEngine;
using UnityEngine.Scripting;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EntityManager : InLevelManager, IWorldShiftCenter // TypeDefIndex: 20770
{
	// Fields
	private EEntityListSyncThreadStage _entityListSyncThreadStage; // 0x10
	private bool useTickFunctionTick; // 0x14
	private EntityTickContext _normalEntityTickContext; // 0x18
	private EntityTickContext _lightInitEntityTickContext; // 0x20
	private EntityTickContext _syncInitEntityTickContext; // 0x28
	private int _unityThreadDoubleBufferIdx; // 0x30
	private const int doubleBufferCount = 2; // Metadata: 0x00AFE2B2
	private const int tripleBufferCount = 3; // Metadata: 0x00AFE2B6
	private Queue<BaseEntity>[] _toDeleteEntitiesQueuesTripleBuffer; // 0x38
	private EntityTickListGroup[] _entityTickGroupDoubleBuffer; // 0x40
	private List<BaseEntity> _entitiesLastFrame; // 0x48
	private Stack<EntityNotReadyReason>[] _entityNotReadyReasonsDoubleBuffer; // 0x50
	public static bool disableForceSyncReady; // 0x00
	private Dictionary<uint, AnimatorParamCache> _entityAnimatorDefaultParamMap; // 0x58
	private Dictionary<uint, Dictionary<int, List<BaseCommand>>> _configID2cmdDic; // 0x60
	private EntityQueryGroup _queryGroup; // 0x68
	private List<BaseEntity> _entities; // 0x70
	private List<BaseEntity> _entitiesToBeAdded; // 0x78
	private List<BaseEntity> _entitiesToBeSafeReady; // 0x80
	private List<BaseEntity> _entitiesToBeRemove; // 0x88
	private List<BaseComponent> _preTickComponents; // 0x90
	private Queue<int> _preTickComponentsEmptySlots; // 0x98
	private Dictionary<uint, Dictionary<uint, int>> _preTickComponentDic; // 0xA0
	private List<int> _toBeRemovePreTickComponents; // 0xA8
	private Dictionary<uint, BaseEntity> _entityMap; // 0xB0
	private ListAmortizedEntityTickHelper _massiveEntities; // 0xB8
	private Dictionary<GameObject, uint> _gameObjectDic; // 0xC0
	private IList<VCAutoPickable> _autoPickableComponents; // 0xC8
	private IList<IAutoAttract> _autoAttractComponents; // 0xD0
	private float _localEntitiesCheckTime; // 0xD8
	private Dictionary<uint, HashList<BaseEntity>> _cachedEntities; // 0xE0
	private HashSet<BaseEntity> _cachedEntityNoLRUSet; // 0xE8
	private MLruList<BaseEntity> _cachedEntityLRU; // 0xF0
	private List<BaseEntity> _oldCachedEntityList; // 0xF8
	private float _cachedEntitiesCheckTime; // 0x100
	private Dictionary<BaseEntity, uint> _cachedEntityConfigID; // 0x108
	private Dictionary<string, IList<BaseEntity>> _tagEntities; // 0x110
	private int _initComponnetCommonFramingTimer; // 0x11C
	private int _initLightComponentCommonFramingTimer; // 0x120
	public bool isEntityReadyOnly; // 0x124
	public Action onPostDestroy; // 0x128
	public bool isDestroying; // 0x130
	private int _preIndex; // 0x134
	private Queue<Dictionary<uint, int>> _preTickDicPool; // 0x138
	private static Action<BaseComponent, TickType> _onTickSinglePreComponent; // 0x08
	private uint _curTeamEntityID; // 0x140
	private uint _globalTeamEntityID; // 0x144
	private uint _curPlayTeamEntityID; // 0x148
	private List<uint> _remoteTeamsEntitiesList; // 0x150
	private Dictionary<uint, BaseEntity> _avatarEntityMap; // 0x158
	private List<BaseEntity> _avatarEntities; // 0x160
	private uint _curAvatarEntityID; // 0x168
	private List<BaseEntity> _noCachedAvatarEntitys; // 0x170
	public ulong heroGuid; // 0x178
	private HeroEntityTeamState heroAvatarState; // 0x180
	private BaseEntity _paimonEntity; // 0x188
	private CameraEntity _mainCamera; // 0x190
	private CameraEntity _subCamera; // 0x1E8
	private LevelEntity _levelEntity; // 0x1F0
	private List<BaseEntity> _entityListTemp; // 0x1F8
	private List<BaseEntity> _combatEntitiesTemp; // 0x200
	public const int ErrorCode_None = 0; // Metadata: 0x00AFE2BA
	public const int ErrorCode_NotInEntityMap = 1; // Metadata: 0x00AFE2BE
	public const int ErrorCode_EntityRecycled = 2; // Metadata: 0x00AFE2C2
	public const int ErrorCode_EntityRuntimeIDDuplidated = 3; // Metadata: 0x00AFE2C6
	public const int ErrorCode_EntitySameInstanceDuplidated = 4; // Metadata: 0x00AFE2CA
	public const int ErrorCode_EntityNullIntance = 5; // Metadata: 0x00AFE2CE
	private Dictionary<uint, bool> _selectPickableShowDic; // 0x208
	private const int RemoveEntityState_None = 0; // Metadata: 0x00AFE2D2
	private const int RemoveEntityState_RemoveEntity = 1; // Metadata: 0x00AFE2D6
	private const int RemoveEntityState_RemoveEntityAlsoInAddableList = 2; // Metadata: 0x00AFE2DA
	private int _SFWatchFlushRemoveEntityHandle; // 0x210
	private bool _nextForceFlushRemoveAllEntity; // 0x214
	public string debugStr; // 0x218
	public int lastPrintFrameCount; // 0x220
	private bool _waitRemoveEntity; // 0x224
	private List<uint> _hideEntityList; // 0x228
	private List<ConfigEntityBlackGrp> _curNpcBanConfigList; // 0x230
	private AbilityProxyMgr _abilityProxyMgr; // 0x238
	private EntityProxyBeforeUpdateTickTask _proxyBeforeTask; // 0x240
	private Dictionary<EntityReuseType, EntityReusedCache> _entityReuseCaches; // 0x248
	private Queue<BaseEntity> _destroyReuseQueue; // 0x250
	private HashSet<uint> _configIDBlackList; // 0x258
	private IGroup[] _taskGroups; // 0x260
	private const int MAX_AVATAR_ENTITY_COUNT = 10; // Metadata: 0x00AFE2DE
	private List<Vector3> _sharedAvatarPositions; // 0x268
	private CycleStat _cycleStat; // 0x270
	private static EntityTickStatLog thisFrameTickStatLog; // 0x10
	private static Dictionary<string, CycleStatTickModuleNode> _nameTickModuleMap; // 0x18
	private static Dictionary<string, StatMMA> _tickModuleMMAMap; // 0x20
	public static List<CycleStatTickModuleNode> cstmnTree; // 0x28
	public static TickModuleStatConcluder _lastFrameTMSC; // 0x30
	public static TickModuleStatConcluder _currentFrameTMSC; // 0x38

	// Properties
	private bool shouldUseTickFunction { /* [XID] */ /* 0x0000000189B9D4E0-0x0000000189B9D500 */ get => default; } // 0x0000000181B81630-0x0000000181B816D0 
	private EntityTickListGroup _entityTickListGroup { /* [XID] */ /* 0x0000000189BB38F0-0x0000000189BB3910 */ get => default; } // 0x0000000181B83780-0x0000000181B83830 
	private Queue<BaseEntity> _toDeleteEntities { /* [XID] */ /* 0x0000000189BCA630-0x0000000189BCA650 */ get => default; } // 0x0000000181B68310-0x0000000181B683F0 
	private Queue<BaseEntity> _toKeepOneFrameDeleteEntitiesJobThread { /* [XID] */ /* 0x0000000189BD1C40-0x0000000189BD1C60 */ get => default; } // 0x0000000181B70EE0-0x0000000181B70FC0 
	private Queue<BaseEntity> _toDeleteEntitiesJobThread { /* [XID] */ /* 0x0000000189BD9270-0x0000000189BD9290 */ get => default; } // 0x0000000181B81EE0-0x0000000181B81FC0 
	private EntityTickListGroup _toExecuteEntityTickListGroup { /* [XID] */ /* 0x00000001895E5E10-0x00000001895E5E30 */ get => default; } // 0x0000000181B82030-0x0000000181B82110 
	private EntityTickListGroup _toPrepareEntityTickListGroup { /* [XID] */ /* 0x00000001895ED7B0-0x00000001895ED7D0 */ get => default; } // 0x0000000181B7C320-0x0000000181B7C400 
	private Stack<EntityNotReadyReason> _entityNotReadyReasonsUnityThread { /* [XID] */ /* 0x0000000189612CE0-0x0000000189612D00 */ get => default; } // 0x0000000181B797F0-0x0000000181B798D0 
	private Stack<EntityNotReadyReason> _entityNotReadyReasonsJobThread { /* [XID] */ /* 0x000000018961A540-0x000000018961A560 */ get => default; } // 0x0000000181B7AFE0-0x0000000181B7B0C0 
	public bool isAllEntityReady { /* [XID] */ /* 0x0000000189621AE0-0x0000000189621B00 */ get => default; } // 0x0000000181B6DCE0-0x0000000181B6DDB0 
	public string entitiesNotReadyReason { /* [XID] */ /* 0x0000000189630D40-0x0000000189630D60 */ get => default; } // 0x0000000181B69010-0x0000000181B69370 
	public List<BaseEntity> DebugEntities { /* [XID] */ /* 0x00000001896F23F0-0x00000001896F2410 */ get => default; } // 0x0000000181B7F390-0x0000000181B7F430 
	public int entityCreationSFTimer { /* [XID] */ /* 0x00000001896F9D30-0x00000001896F9D70 */ get; /* [XID] */ /* 0x0000000189704400-0x0000000189704440 */ private set; } // 0x0000000181B71FB0-0x0000000181B72010 0x0000000181B6BE50-0x0000000181B6BEC0
	public BaseEntity paimonEntity { /* [XID] */ /* 0x00000001898B8220-0x00000001898B8240 */ get => default; /* [XID] */ /* 0x00000001898BF920-0x00000001898BF940 */ set {} } // 0x0000000181B75DC0-0x0000000181B75E70 0x0000000181B82110-0x0000000181B821C0
	public bool bUseOverrideCamera { /* [XID] */ /* 0x00000001898CE730-0x00000001898CE770 */ get; /* [XID] */ /* 0x00000001898D91F0-0x00000001898D9230 */ set; } // 0x0000000181B75940-0x0000000181B759A0 0x0000000181B81FC0-0x0000000181B82030
	public Vector3 overrideCameraPos { /* [XID] */ /* 0x00000001898E3D00-0x00000001898E3D40 */ get; /* [XID] */ /* 0x00000001898EE9C0-0x00000001898EEA00 */ private set; } // 0x0000000181B744F0-0x0000000181B74570 0x0000000181B821C0-0x0000000181B82240
	public Matrix4x4 overrideCameraMVPMatix { /* [XID] */ /* 0x0000000189900AD0-0x0000000189900B10 */ get; /* [XID] */ /* 0x000000018990AFB0-0x000000018990AFF0 */ private set; } // 0x0000000181B7DB90-0x0000000181B7DC20 0x0000000181B82FE0-0x0000000181B83070
	public LevelEntity levelEntity { /* [XID] */ /* 0x0000000189B0CC80-0x0000000189B0CCA0 */ get => default; /* [XID] */ /* 0x0000000189960520-0x0000000189960540 */ set {} } // 0x0000000181B74440-0x0000000181B744F0 0x0000000181B7A180-0x0000000181B7A230
	public List<Vector3> sharedAvatarPositions { /* [XID] */ /* 0x000000018976E180-0x000000018976E1A0 */ get => default; } // 0x0000000181B7F120-0x0000000181B7F1D0 
	public static EntityManager singletonForDebug { /* [XID] */ /* 0x000000018977D240-0x000000018977D260 */ get => default; } // 0x0000000181B6D880-0x0000000181B6D940 
	private static List<CycleStatLogNode> _cycleStatLogs { /* [XID] */ /* 0x0000000189832C60-0x0000000189832C80 */ get => default; } // 0x0000000181B74300-0x0000000181B743E0 
	public static Dictionary<string, CycleStatTickModuleNode> nameTickModuleMap { /* [XID] */ /* 0x00000001897936E0-0x0000000189793700 */ get => default; } // 0x0000000181B7C250-0x0000000181B7C320 
	public static Dictionary<string, StatMMA> tickModuleMMAMap { /* [XID] */ /* 0x000000018979B910-0x000000018979B930 */ get => default; } // 0x0000000181B701D0-0x0000000181B702A0 

	// Nested types
	public enum EEntityListSyncThreadStage // TypeDefIndex: 20771
	{
		ReadOnly = 0,
		MainThread = 1,
		JobThread = 2
	}

	public struct ScopeMainThreadEntityListHardSyncing : IDisposable // TypeDefIndex: 20772
	{
		// Fields
		private EntityManager _mgr; // 0x00
		private EEntityListSyncThreadStage _preRequestUpdateStage; // 0x08
		private string callFunctionName; // 0x10

		// Constructors
		public ScopeMainThreadEntityListHardSyncing(string functionName) {
			_mgr = default;
			_preRequestUpdateStage = default;
			callFunctionName = default;
		} // 0x0000000182CF3A00-0x0000000182CF3C10

		// Methods
		// [XID] // 0x00000001897FF1F0-0x00000001897FF210
		public void Dispose() {} // 0x0000000182CF38F0-0x0000000182CF3A00
	}

	public struct ScopeJobThreadEntityListHardSyncing : IDisposable // TypeDefIndex: 20773
	{
		// Fields
		private EntityManager _mgr; // 0x00
		private EEntityListSyncThreadStage _preRequestUpdateStage; // 0x08
		private string callFunctionName; // 0x10

		// Constructors
		public ScopeJobThreadEntityListHardSyncing(string functionName) {
			_mgr = default;
			_preRequestUpdateStage = default;
			callFunctionName = default;
		} // 0x0000000182CF37D0-0x0000000182CF38F0

		// Methods
		// [XID] // 0x0000000189806950-0x0000000189806970
		public void Dispose() {} // 0x0000000182CF36C0-0x0000000182CF37D0
	}

	private class EntityTickListGroup // TypeDefIndex: 20774
	{
		// Fields
		private TickArray _entityTickList; // 0x10
		private TickArray _entityLatePreTickComponentList; // 0x18
		private TickArray _entityLatePreTickList; // 0x20
		private TickArray _entityLatePostTickList; // 0x28

		// Constructors
		public EntityTickListGroup() {} // 0x0000000182CD3AB0-0x0000000182CD3BB0

		// Methods
		// [XID] // 0x000000018980E130-0x000000018980E150
		private void ExecuteTickFunction(TickArray inTickList) {} // 0x0000000182CD3720-0x0000000182CD3830
		// [XID] // 0x0000000189815810-0x0000000189815830
		private void ClearTickList(TickArray inTickList) {} // 0x0000000182CD3940-0x0000000182CD3A00
		// [XID] // 0x000000018981D200-0x000000018981D220
		public void AddETFTickBeforeReady(BaseEntity entity, EntityTickContext inContext, bool fromJobThread) {} // 0x0000000182CD3600-0x0000000182CD3720
		// [XID] // 0x0000000189824680-0x00000001898246A0
		public void AddETFSyncTickable(BaseEntity entity, EntityTickContext inContext, bool fromJobThread) {} // 0x0000000182CD3830-0x0000000182CD3940
		// [XID] // 0x0000000189B4CBD0-0x0000000189B4CBF0
		public void AddETFTickComponentsAndCacheIsRendering(BaseEntity entity, EntityTickContext inContext, bool fromJobThread) {} // 0x0000000182CD30F0-0x0000000182CD3210
		// [XID] // 0x0000000189615490-0x00000001896154B0
		public void AddETFTickBeforeComponents(BaseEntity entity, EntityTickContext inContext, bool fromJobThread) {} // 0x0000000182CD2C60-0x0000000182CD2D80
		// [XID] // 0x000000018961CC60-0x000000018961CC80
		public void AddETFLateTickComponents(BaseEntity entity, EntityTickContext inContext, bool isLatePreTick, bool fromJobThread) {} // 0x0000000182CD2B30-0x0000000182CD2C60
		// [XID] // 0x0000000189842140-0x0000000189842160
		public void ExecuteTickList() {} // 0x0000000182CD3450-0x0000000182CD3500
		// [XID] // 0x00000001898495A0-0x00000001898495C0
		public void ExecuteLatePreTickComponents() {} // 0x0000000182CD33A0-0x0000000182CD3450
		// [XID] // 0x0000000189850E10-0x0000000189850E30
		public void ExecuteLatePreTickEntities() {} // 0x0000000182CD3A00-0x0000000182CD3AB0
		// [XID] // 0x0000000189858200-0x0000000189858220
		public void ExecuteLatePostTickEntities() {} // 0x0000000182CD2D80-0x0000000182CD2E30
		// [XID] // 0x000000018985F2D0-0x000000018985F2F0
		public void ClearAllTickLists() {} // 0x0000000182CD2E30-0x0000000182CD2F00
		// [XID] // 0x0000000189866AD0-0x0000000189866AF0
		public void FlushAllTickLists() {} // 0x0000000182CD3500-0x0000000182CD3600
		[Preserve] // 0x000000018986E370-0x000000018986E3B0
		// [XID] // 0x000000018986E370-0x000000018986E3B0
		public string Dump() => default; // 0x0000000182CD3210-0x0000000182CD33A0
		// [XID] // 0x0000000189878890-0x00000001898788B0
		private string DumpTickArray(TickArray inTickList, string tag) => default; // 0x0000000182CD2F00-0x0000000182CD30F0
	}

	private struct EntityNotReadyReason // TypeDefIndex: 20775
	{
		// Fields
		private uint configID; // 0x00
		private uint runtimeID; // 0x04
		private bool isLoaded; // 0x08

		// Constructors
		public EntityNotReadyReason(uint inConfigID, uint inRuntimeID, bool inLoaded) {
			configID = default;
			runtimeID = default;
			isLoaded = default;
		} // 0x0000000182CF3CA0-0x0000000182CF3D60

		// Methods
		// [XID] // 0x000000018987FE60-0x000000018987FE80
		public string ToDebugString() => default; // 0x0000000182CF3C10-0x0000000182CF3CA0
	}

	public class AnimatorParamCache // TypeDefIndex: 20776
	{
		// Fields
		private const int MAX_COUNT = 50; // Metadata: 0x00AFE2EE
		private static Queue<AnimatorParamCache> _queue; // 0x00
		public readonly Dictionary<int, bool> boolAnimatorParams; // 0x10
		public readonly Dictionary<int, int> intAnimatorParams; // 0x18
		public readonly Dictionary<int, float> floatAnimatorParams; // 0x20

		// Constructors
		public AnimatorParamCache() {} // 0x0000000182CF4420-0x0000000182CF44F0
		static AnimatorParamCache() {} // 0x0000000182CF4390-0x0000000182CF4420

		// Methods
		// [XID] // 0x0000000189887480-0x00000001898874A0
		public static AnimatorParamCache Get() => default; // 0x0000000182CF40D0-0x0000000182CF4240
		// [XID] // 0x000000018988E600-0x000000018988E620
		public static void Free(AnimatorParamCache cache) {} // 0x0000000182CF4240-0x0000000182CF4390
		// [XID] // 0x0000000189B98890-0x0000000189B988B0
		public void Clear() {} // 0x0000000182CF3FE0-0x0000000182CF40D0
	}

	public enum TickType // TypeDefIndex: 20777
	{
		None = 0,
		FixedTick = 1,
		Tick = 2,
		LateTick = 3,
		LateTickPre = 4,
		LateTickPreEnd = 5,
		LateTickPost = 6,
		LateTickPostEnd = 7,
		STAT_CompCtor = 1001,
		STAT_CompInit = 1002,
		STAT_EntityClear = 1003
	}

	private enum HeroEntityTeamState // TypeDefIndex: 20778
	{
		None = 0,
		MainAvatarInTeam = 1,
		MainAvatarNotInTeam = 2
	}

	public class EntityTickStatLog // TypeDefIndex: 20779
	{
		// Fields
		public List<CycleStatLogNode> _cycleStatLogs; // 0x10

		// Constructors
		public EntityTickStatLog() {} // 0x0000000182CF44F0-0x0000000182CF4580
	}

	// Constructors
	public EntityManager() {} // 0x0000000181B86920-0x0000000181B872B0
	static EntityManager() {} // 0x0000000181B86730-0x0000000181B86920

	// Methods
	// [XID] // 0x0000000189B69DD0-0x0000000189B69DF0
	public static void SetEntityListSyncing(bool isFromeJobThread, string functionName) {} // 0x0000000181B75E70-0x0000000181B76000
	// [XID] // 0x0000000189B71300-0x0000000189B71320
	public static void FinishEntityListSyncing() {} // 0x0000000181B83300-0x0000000181B833E0
	// [XID] // 0x0000000189B78960-0x0000000189B78980
	public static void AssertEntityListSyncingMainThread(string functionName) {} // 0x0000000181B74F00-0x0000000181B75070
	// [XID] // 0x0000000189A3D1F0-0x0000000189A3D210
	public static void AssertEntityListSyncingJobThread(string functionName) {} // 0x0000000181B72B20-0x0000000181B72C90
	// [XID] // 0x0000000189B87960-0x0000000189B87980
	public static void ConditionalCheckEntityListSyncing(string functionName, bool bFromJobThread) {} // 0x0000000181B71860-0x0000000181B71960
	// [XID] // 0x0000000189B8EAA0-0x0000000189B8EAC0
	public void OnPreFrameStart() {} // 0x0000000181B85480-0x0000000181B85520
	// [XID] // 0x0000000189B95F20-0x0000000189B95F40
	public float GetNearestAvatarDistanceSqr(Vector3 pos) => default; // 0x0000000181B7D890-0x0000000181B7DAB0
	// [XID] // 0x0000000189BA4F30-0x0000000189BA4F50
	public void ForceDisableTickFunctionTickFromNextTickStage() {} // 0x0000000181B7BD50-0x0000000181B7BDF0
	// [XID] // 0x0000000189BAC110-0x0000000189BAC130
	public void SetEntityActiveForceLateTickThisFrame(BaseEntity inEntity, bool bActive) {} // 0x0000000181B6D370-0x0000000181B6D4B0
	// [XID] // 0x0000000189BBAEC0-0x0000000189BBAEE0
	private void FlushAllTickLists() {} // 0x0000000181B7D060-0x0000000181B7D140
	// [XID] // 0x0000000189BC2E90-0x0000000189BC2EB0
	private EntityTickContext GetEntityTickContext(BaseEntity inEntity) => default; // 0x0000000181B83B90-0x0000000181B83C80
	// [XID] // 0x00000001895F4E20-0x00000001895F4E40
	private void InternalFlushToToDeleteEntities(Queue<BaseEntity> inToDeleteEntities, bool disableRuntimeIDCacheCehck = false /* Metadata: 0x00AFE29D */) {} // 0x0000000181B6ED60-0x0000000181B6EE80
	// [XID] // 0x00000001895FC530-0x00000001895FC550
	public void FlushToDeleteEntities() {} // 0x0000000181B6C530-0x0000000181B6C620
	// [XID] // 0x0000000189603EF0-0x0000000189603F10
	private void FlushToDeleteEntitiesOnFrameTick() {} // 0x0000000181B6AA40-0x0000000181B6AAF0
	// [XID] // 0x000000018960B810-0x000000018960B830
	public void FlipDoubleBuffer() {} // 0x0000000181B6AAF0-0x0000000181B6AB90
	// [XID] // 0x0000000189629410-0x0000000189629430
	private void PushEntityNotReadyReason(BaseEntity e, bool isLoaded) {} // 0x0000000181B75480-0x0000000181B755D0
	// [XID] // 0x00000001896387A0-0x00000001896387C0
	private void CacheLastFrameEntityStates(bool shouldCheckEntityReady) {} // 0x0000000181B74570-0x0000000181B74970
	// [XID] // 0x000000018963FBF0-0x000000018963FC10
	public void DuplicateLastFrameEntitiesUnityThread() {} // 0x0000000181B79240-0x0000000181B79380
	// [XID] // 0x00000001896473D0-0x00000001896473F0
	private void CacheLastFrameEntitiesInfoJobThread() {} // 0x0000000181B6E5B0-0x0000000181B6E680
	// [XID] // 0x000000018964EB40-0x000000018964EB60
	public void DeleteEntitiesUnityThread() {} // 0x0000000181B77A40-0x0000000181B77B50
	// [XID] // 0x00000001896563F0-0x0000000189656410
	public void BuildTickListFirstPass() {} // 0x0000000181B6A960-0x0000000181B6AA40
	// [XID] // 0x0000000189869330-0x0000000189869350
	private void AddEntityToTickListGroup(BaseEntity entity, EntityTickBalanceProxy tickBalanceProxy, EntityTickListGroup inEntityTickListGroup, bool isAsyncReadyPass, bool bFromJobThread) {} // 0x0000000181B77D60-0x0000000181B78280
	// [XID] // 0x00000001896651A0-0x00000001896651C0
	private void InternalBuildTickListComputeThreadWithCacheState(List<BaseEntity> inEntities, List<BaseComponent> inPreTickComponents, EntityTickListGroup inEntityTickListGroup) {} // 0x0000000181B6BEC0-0x0000000181B6C110
	// [XID] // 0x000000018966C8C0-0x000000018966C8E0
	public void BuildTickListSecondPass() {} // 0x0000000181B78980-0x0000000181B78A70
	// [XID] // 0x00000001896746F0-0x0000000189674710
	public void AppendForceSyncReadyForNextFrameEntities(BaseEntity e, bool bFromJobThread, bool bFromEntityCache = false /* Metadata: 0x00AFE29E */) {} // 0x0000000181B68BE0-0x0000000181B68E70
	// [XID] // 0x000000018967C020-0x000000018967C040
	private void InternalTickArrayTickEntities(int normalEntitySharedInitComponentWatch, int lightEntitySharedInitComponentWatch, bool inIsRoundRobinFrame) {} // 0x0000000181B810E0-0x0000000181B81310
	// [XID] // 0x00000001896835D0-0x00000001896835F0
	private void InternalTickArrayLatePreTickEntities() {} // 0x0000000181B736F0-0x0000000181B737B0
	// [XID] // 0x000000018968B210-0x000000018968B230
	private void InternalTickArrayLatePostTickEntities() {} // 0x0000000181B72470-0x0000000181B72530
	// [XID] // 0x0000000189692F50-0x0000000189692F70
	private void ClearCache() {} // 0x0000000181B791A0-0x0000000181B79240
	// [XID] // 0x000000018969A190-0x000000018969A1B0
	private AnimatorParamCache GetEntityAnimatorDefaultParamCache(uint configId) => default; // 0x0000000181B755D0-0x0000000181B75710
	// [XID] // 0x00000001896A1A00-0x00000001896A1A20
	private AnimatorParamCache TryGetEntityAnimatorDefaultParamCache(uint configId) => default; // 0x0000000181B7B960-0x0000000181B7BA50
	// [XID] // 0x00000001898BD7E0-0x00000001898BD800
	public void SetAnimatorDefaultInt(uint configId, Animator animator, int id) {} // 0x0000000181B68A90-0x0000000181B68BE0
	// [XID] // 0x0000000189A01AC0-0x0000000189A01AE0
	public void SetAnimatorDefaultFloat(uint configId, Animator animator, int id) {} // 0x0000000181B76B40-0x0000000181B76C90
	// [XID] // 0x00000001896B7880-0x00000001896B78A0
	public bool GetAnimatorDefaultFloat(uint configId, int id, out float value) {
		value = default;
		return default;
	} // 0x0000000181B6D940-0x0000000181B6DA60
	// [XID] // 0x0000000189B82820-0x0000000189B82840
	public void SetAnimatorDefaultBool(uint configId, Animator animator, int id) {} // 0x0000000181B7BDF0-0x0000000181B7BF40
	// [XID] // 0x00000001896C62F0-0x00000001896C6310
	public void ResetAnimatorDefaultParam(uint configId, Animator animator) {} // 0x0000000181B6B430-0x0000000181B6B8D0
	// [XID] // 0x00000001896CD8F0-0x00000001896CD910
	private void ClearAnimatorDefaultParam() {} // 0x0000000181B833E0-0x0000000181B835E0
	// [XID] // 0x00000001896D4DC0-0x00000001896D4DE0
	public void AddCacheCmd(uint cfgId, BaseCommand cmd) {} // 0x0000000181B82B80-0x0000000181B82D80
	// [XID] // 0x00000001896DC3C0-0x00000001896DC3E0
	public void HandleCacheCmd(AvatarEntity avatar) {} // 0x0000000181B7A230-0x0000000181B7A370
	// [XID] // 0x00000001896E3C50-0x00000001896E3C70
	private void InitQueryGroup(EntityManager entityMgr) {} // 0x0000000181B717A0-0x0000000181B71860
	// [XID] // 0x00000001896EAFC0-0x00000001896EAFE0
	private void ClearQueryGroup() {} // 0x0000000181B759A0-0x0000000181B75A50
	// [XID] // 0x000000018970EE00-0x000000018970EE20
	public void OnCachedDismiss(BaseEntity entity) {} // 0x0000000181B7C4D0-0x0000000181B7CB20
	// [XID] // 0x0000000189716240-0x0000000189716260
	public override void Init() {} // 0x0000000181B7A5F0-0x0000000181B7AB30
	// [XID] // 0x000000018971DC80-0x000000018971DCA0
	private void DestroyEntityImmediate(BaseEntity entity, bool disableRuntimeIDCacheCheck = false /* Metadata: 0x00AFE29F */) {} // 0x0000000181B6FDF0-0x0000000181B6FF00
	// [XID] // 0x0000000189725160-0x0000000189725180
	public override void Destroy() {} // 0x0000000181B70740-0x0000000181B70CC0
	// [XID] // 0x000000018972C820-0x000000018972C840
	public void FixedTick() {} // 0x0000000181B76140-0x0000000181B76350
	// [XID] // 0x0000000189733F50-0x0000000189733F70
	private void GetSharedInitComponentWatches(out int normalEntitySharedInitComponentWatch, out int lightEntitySharedInitComponentWatch, bool shouldUseSyncReady) {
		normalEntitySharedInitComponentWatch = default;
		lightEntitySharedInitComponentWatch = default;
	} // 0x0000000181B77C70-0x0000000181B77D60
	// [XID] // 0x000000018973B710-0x000000018973B730
	public override void Tick() {} // 0x0000000181B86240-0x0000000181B86730
	// [XID] // 0x00000001897431A0-0x00000001897431C0
	public override void PostTick() {} // 0x0000000181B85DE0-0x0000000181B85F30
	// [XID] // 0x000000018974AD20-0x000000018974AD40
	public override void LateTick() {} // 0x0000000181B80A40-0x0000000181B80CB0
	// [XID] // 0x0000000189751DD0-0x0000000189751DF0
	public override void LatePreTick() {} // 0x0000000181B80830-0x0000000181B80A40
	// [XID] // 0x0000000189759480-0x00000001897594A0
	public override void LatePreTickEnd() {} // 0x0000000181B80740-0x0000000181B80830
	// [XID] // 0x0000000189761070-0x0000000189761090
	public override void LatePostTick() {} // 0x0000000181B80560-0x0000000181B80740
	// [XID] // 0x00000001897683C0-0x00000001897683E0
	public override void LatePostTickEnd() {} // 0x0000000181B802E0-0x0000000181B80560
	// [XID] // 0x000000018960F4B0-0x000000018960F4D0
	public void AddEntity(BaseEntity e) {} // 0x0000000181B72010-0x0000000181B72180
	// [XID] // 0x00000001897772D0-0x00000001897772F0
	private int GetLargestEntityOrder() => default; // 0x0000000181B7D790-0x0000000181B7D890
	// [XID] // 0x000000018977EA40-0x000000018977EA60
	private void InternalAddAllAddableEntities() {} // 0x0000000181B73A30-0x0000000181B74200
	// [XID] // 0x00000001897861C0-0x00000001897861E0
	private void AddAllAddableEntities() {} // 0x0000000181B79440-0x0000000181B79560
	// [XID] // 0x0000000189B64D40-0x0000000189B64D60
	public void SwitchEntityRuntimeID(BaseEntity e, Action postSwitchEntityRuntimeID) {} // 0x0000000181B7FB70-0x0000000181B7FDF0
	// [XID] // 0x0000000189794D20-0x0000000189794D40
	public void AddEntityLightweight(BaseEntity e) {} // 0x0000000181B7F1D0-0x0000000181B7F390
	// [XID] // 0x000000018979D250-0x000000018979D270
	public void RemoveEntityLightweight(BaseEntity e) {} // 0x0000000181B7B530-0x0000000181B7B700
	// [XID] // 0x00000001897A4530-0x00000001897A4550
	public int CheckDuplicatedEntityInEntityMap(BaseEntity newlyAddedEntity, bool duplicatedAdd) => default; // 0x0000000181B6B0E0-0x0000000181B6B380
	// [XID] // 0x000000018990D980-0x000000018990D9A0
	private void AddEntityInternal(BaseEntity e, bool checkOrder) {} // 0x0000000181B6E680-0x0000000181B6ED60
	// [XID] // 0x00000001897B3A00-0x00000001897B3A20
	private Dictionary<uint, int> GetPreTickDic() => default; // 0x0000000181B84B50-0x0000000181B84C60
	// [XID] // 0x000000018995FD30-0x000000018995FD50
	private void ReleasePreTickDic(Dictionary<uint, int> dic) {} // 0x0000000181B71960-0x0000000181B71A30
	// [XID] // 0x000000018972BF90-0x000000018972BFB0
	public void RemoveEntityTickComponents(uint entityId) {} // 0x0000000181B7CBE0-0x0000000181B7D060
	// [XID] // 0x00000001897CA910-0x00000001897CA930
	public void AddPreTickComponent(BaseComponent component) {} // 0x0000000181B7E290-0x0000000181B7EA40
	// [XID] // 0x00000001897D1F10-0x00000001897D1F30
	private void RemovePreTickComponent(int index) {} // 0x0000000181B73040-0x0000000181B73240
	// [XID] // 0x00000001897D9D30-0x00000001897D9D50
	private void SwitchPreTickComponent(uint preRuntimeId, uint runtimeId) {} // 0x0000000181B72530-0x0000000181B72730
	// [XID] // 0x00000001897E1080-0x00000001897E10A0
	private static bool ShouldTickPreComponent(BaseComponent component, int indexInComponentList, List<int> inToBeRemovePreTickComponents) => default; // 0x0000000181B852C0-0x0000000181B853D0
	// [XID] // 0x00000001897E87D0-0x00000001897E87F0
	private static void InternalTickSinglePreComponent(BaseComponent component, TickType tickType) {} // 0x0000000181B72180-0x0000000181B72370
	// [XID] // 0x00000001897F0420-0x00000001897F0440
	private void InternalTickPreComponents(TickType tickType, Action<BaseComponent, TickType> onTickComponent, List<BaseComponent> inPreTickComponents, List<int> inToBeRemovePreTickComponents, bool bFromJobThread) {} // 0x0000000181B6C1E0-0x0000000181B6C530
	// [XID] // 0x00000001897F7B70-0x00000001897F7B90
	public void TickPreComponent(TickType tickType) {} // 0x0000000181B813C0-0x0000000181B81560
	// [XID] // 0x00000001897FF210-0x00000001897FF230
	public void SetLocalTeamEntityID(uint curTeamEntityID) {} // 0x0000000181B78A70-0x0000000181B78B20
	// [XID] // 0x0000000189806970-0x0000000189806990
	public uint GetLocalTeamEntityId() => default; // 0x0000000181B68E70-0x0000000181B68F10
	// [XID] // 0x0000000189706A80-0x0000000189706AA0
	public BaseEntity GetLocalTeamEntity() => default; // 0x0000000181B6CF80-0x0000000181B6D030
	// [XID] // 0x0000000189815830-0x0000000189815850
	public void SetGlobalTeamEntityID(uint teamEntityID) {} // 0x0000000181B6B8D0-0x0000000181B6B980
	// [XID] // 0x00000001897395E0-0x0000000189739600
	public uint GetGlobalTeamEntityId() => default; // 0x0000000181B6FBE0-0x0000000181B6FC80
	// [XID] // 0x00000001898246A0-0x00000001898246C0
	public void SetLocalPlayTeamEntityID(uint curPlayTeamEntityID) {} // 0x0000000181B6C8B0-0x0000000181B6C960
	// [XID] // 0x000000018982C130-0x000000018982C150
	public uint GetLocalPlayTeamEntityId() => default; // 0x0000000181B778C0-0x0000000181B77960
	// [XID] // 0x0000000189833600-0x0000000189833620
	public BaseEntity GetLocalPlayTeamEntity() => default; // 0x0000000181B683F0-0x0000000181B684A0
	// [XID] // 0x000000018983AAE0-0x000000018983AB00
	public void AddRemoteTeamEntityId(uint teamEntityId) {} // 0x0000000181B74D10-0x0000000181B74E00
	// [XID] // 0x0000000189842160-0x0000000189842180
	public void RemoveRemoteTeamEntityId(uint teamEntityId) {} // 0x0000000181B6F040-0x0000000181B6F110
	// [XID] // 0x000000018970E410-0x000000018970E430
	public List<uint> GetRemoteTeamEntitiesList() => default; // 0x0000000181B7EA40-0x0000000181B7EAF0
	// [XID] // 0x000000018974A230-0x000000018974A250
	public AvatarEntity GetActiveAvatarInSameTeam(AvatarEntity avatar) => default; // 0x0000000181B73460-0x0000000181B736F0
	// [XID] // 0x0000000189858220-0x0000000189858240
	public void SetLocalAvatarEntityID(uint curAvatarEntityID) {} // 0x0000000181B73240-0x0000000181B73340
	// [XID] // 0x000000018985F2F0-0x000000018985F310
	public uint GetLocalAvatarEntityID() => default; // 0x0000000181B74200-0x0000000181B742A0
	// [XID] // 0x000000018993F060-0x000000018993F080
	public AvatarEntity GetLocalAvatarEntity() => default; // 0x0000000181B716F0-0x0000000181B717A0
	// [XID] // 0x000000018986E3B0-0x000000018986E3D0
	public AvatarEntity GetAvatarByPeerID(uint peerID) => default; // 0x0000000181B6C620-0x0000000181B6C8B0
	// [XID] // 0x0000000189875820-0x0000000189875840
	public uint GetLocalAvatarConfigID() => default; // 0x0000000181B7CB20-0x0000000181B7CBE0
	// [XID] // 0x000000018987D3B0-0x000000018987D3D0
	public AvatarEntity GetAvatarEntity(uint runtimeID) => default; // 0x0000000181B74E00-0x0000000181B74F00
	// [XID] // 0x0000000189A62860-0x0000000189A62880
	public bool IsLocalAvatar(uint runtimeID) => default; // 0x0000000181B67930-0x0000000181B67A30
	// [XID] // 0x0000000189ABE720-0x0000000189ABE740
	public List<BaseEntity> GetAllAvatars(bool includeCachedEntities = true /* Metadata: 0x00AFE2A0 */) => default; // 0x0000000181B69370-0x0000000181B695C0
	// [XID] // 0x0000000189747190-0x00000001897471B0
	public bool IsAvatarAllReady() => default; // 0x0000000181B76000-0x0000000181B76140
	// [XID] // 0x000000018989A790-0x000000018989A7B0
	public void CreateHeroEntity(bool isSameWithAvatar) {} // 0x0000000181B71A30-0x0000000181B71FB0
	// [XID] // 0x00000001898A1A20-0x00000001898A1A40
	public void ClearHeroEntity() {} // 0x0000000181B7DDC0-0x0000000181B7DF50
	// [XID] // 0x00000001898A92D0-0x00000001898A92F0
	public AvatarEntity GetHeroEntity() => default; // 0x0000000181B83C80-0x0000000181B83EB0
	// [XID] // 0x00000001898B0B40-0x00000001898B0B60
	public AvatarEntity GetRealHeroEntity() => default; // 0x0000000181B79660-0x0000000181B79790
	// [XID] // 0x00000001898C71C0-0x00000001898C71E0
	public CameraEntity GetMainCameraEntity() => default; // 0x0000000181B6B380-0x0000000181B6B430
	// [XID] // 0x00000001898F9170-0x00000001898F9190
	public Vector3 GetSharedCameraPos() => default; // 0x0000000181B6F570-0x0000000181B6F740
	// [XID] // 0x0000000189915A00-0x0000000189915A20
	public void CacheOverrideCameraSharedInfo(Camera inCamera, Vector3 posOffset) {} // 0x0000000181B82240-0x0000000181B82600
	// [XID] // 0x000000018991D390-0x000000018991D3B0
	public CameraEntity GetSubCameraEntity() => default; // 0x0000000181B687D0-0x0000000181B68880
	// [XID] // 0x0000000189924D20-0x0000000189924D40
	public List<BaseEntity> GetEntities() => default; // 0x0000000181B706A0-0x0000000181B70740
	// [XID] // 0x000000018992C220-0x000000018992C240
	private BaseEntity InternalGetEntity(uint runtimeID, bool withEntityToBeAdded) => default; // 0x0000000181B79FE0-0x0000000181B7A180
	// [XID] // 0x0000000189A35B60-0x0000000189A35B80
	public BaseEntity GetEntityFromJobThread(uint runtimeID) => default; // 0x0000000181B76800-0x0000000181B768F0
	// [XID] // 0x00000001896A9CD0-0x00000001896A9CF0
	public BaseEntity GetValidEntity(uint runtimeID) => default; // 0x0000000181B843A0-0x0000000181B844A0
	// [XID] // 0x0000000189942440-0x0000000189942460
	public BaseEntity GetEntity(uint runtimeID) => default; // 0x0000000181B67EE0-0x0000000181B68140
	// [XID] // 0x0000000189949D60-0x0000000189949D80
	public BaseEntity GetEntityByGroup(GroupEntityType groupEntityType, uint groupId, uint mapInstId) => default; // 0x0000000181B83830-0x0000000181B83980
	// [XID] // 0x0000000189951940-0x0000000189951960
	public List<BaseEntity> GetEnitiesByGroup(GroupEntityType groupEntityType, uint groupId) => default; // 0x0000000181B75130-0x0000000181B753C0
	// [XID] // 0x0000000189854610-0x0000000189854630
	public MonsterEntity GetMonsterEntity(uint runtimeID) => default; // 0x0000000181B7DF50-0x0000000181B7E030
	// [XID] // 0x000000018996F180-0x000000018996F1A0
	public IndexHandleObjectList<BaseEntity> GetAllMonsters() => default; // 0x0000000181B77800-0x0000000181B778C0
	// [XID] // 0x0000000189976CD0-0x0000000189976CF0
	public MonsterEntity GetGadgetEntity(uint runtimeID) => default; // 0x0000000181B77960-0x0000000181B77A40
	// [XID] // 0x000000018997E0E0-0x000000018997E100
	public IndexHandleObjectList<BaseEntity> GetAllGadgets() => default; // 0x0000000181B78280-0x0000000181B78340
	// [IDTag] // 0x0000000189985BF0-0x0000000189985C30
	// [XID] // 0x0000000189985BF0-0x0000000189985C30
	public List<BaseEntity> GetEntitiesByIDs(List<uint> entityIdList) => default; // 0x0000000181B74A10-0x0000000181B74BB0
	// [IDTag] // 0x0000000189990890-0x00000001899908D0
	// [XID] // 0x0000000189990890-0x00000001899908D0
	public void GetEntitiesByIDs(List<uint> entityIdList, ref List<BaseEntity> entityList) {} // 0x0000000181B74BB0-0x0000000181B74D10
	// [XID] // 0x00000001897FD240-0x00000001897FD260
	public IList<BaseEntity> GetAllCombatEntitiesByCampExcludeGWs(uint campID) => default; // 0x0000000181B7C400-0x0000000181B7C4D0
	// [XID] // 0x00000001897E68C0-0x00000001897E68E0
	public List<BaseEntity> GetAllCombatEntitiesByCamps(SimpleSafeUInt32[] campIDs, uint excludeRuntimeId = 0 /* Metadata: 0x00AFE2A1 */) => default; // 0x0000000181B702A0-0x0000000181B705D0
	// [XID] // 0x00000001899AA6E0-0x00000001899AA700
	public List<BaseEntity> GetAllCombatEntitiesByTargetCamps(uint selfCamp, TargetType targetType, uint selfRuntimeID) => default; // 0x0000000181B7EEC0-0x0000000181B7F120
	// [XID] // 0x000000018961FC50-0x000000018961FC70
	public void AddCombatEntity(BaseEntity entity) {} // 0x0000000181B70030-0x0000000181B701D0
	// [XID] // 0x0000000189A8FF70-0x0000000189A8FF90
	public int RemoveCombatEntity(uint entityRuntimeID) => default; // 0x0000000181B7B3B0-0x0000000181B7B4D0
	// [XID] // 0x00000001899C0E90-0x00000001899C0EB0
	private void RemoveCombatEntityInternal(BaseEntity entity) {} // 0x0000000181B7DC20-0x0000000181B7DDC0
	// [XID] // 0x00000001899EB4F0-0x00000001899EB510
	public IndexHandleObjectList<BaseEntity> GetAllCombatEntitiesExcludeGWGOs() => default; // 0x0000000181B753C0-0x0000000181B75480
	// [XID] // 0x00000001899CFED0-0x00000001899CFEF0
	public IList<BaseEntity> GetAllEntitiesExcludeGWGOs() => default; // 0x0000000181B83070-0x0000000181B83130
	// [XID] // 0x00000001899D73F0-0x00000001899D7410
	public void AddPickableEntity(BaseEntity entity) {} // 0x0000000181B82F10-0x0000000181B82FE0
	// [XID] // 0x00000001899DE790-0x00000001899DE7B0
	public void RemovePickableEntity(BaseEntity entity) {} // 0x0000000181B83130-0x0000000181B83200
	// [XID] // 0x00000001899E6490-0x00000001899E64B0
	public IList<BaseEntity> GetAllPickableEntities() => default; // 0x0000000181B729E0-0x0000000181B72AA0
	// [XID] // 0x00000001899ED9E0-0x00000001899EDA00
	public void AddSelectPickableEntity(BaseEntity entity) {} // 0x0000000181B851F0-0x0000000181B852C0
	// [XID] // 0x00000001899F53D0-0x00000001899F53F0
	public void RemoveSelectPickableEntity(BaseEntity entity) {} // 0x0000000181B7EC60-0x0000000181B7ED30
	// [XID] // 0x0000000189624080-0x00000001896240A0
	public IList<BaseEntity> GetAllSelectPickableEntities() => default; // 0x0000000181B7EE00-0x0000000181B7EEC0
	// [XID] // 0x0000000189A03F20-0x0000000189A03F40
	public void HideAllSelectPickableEntities() {} // 0x0000000181B7A370-0x0000000181B7A520
	// [XID] // 0x0000000189814C10-0x0000000189814C30
	public void ResumeShowAllSelectPickableEntities() {} // 0x0000000181B83980-0x0000000181B83B90
	// [XID] // 0x0000000189A12D50-0x0000000189A12D70
	public void AddAutoPickableEntity(VCAutoPickable component) {} // 0x0000000181B816D0-0x0000000181B817D0
	// [XID] // 0x0000000189A1A110-0x0000000189A1A130
	public void RemoveAutoPickableEntity(VCAutoPickable component) {} // 0x0000000181B6FF00-0x0000000181B6FFD0
	// [XID] // 0x00000001896002F0-0x0000000189600310
	public IList<VCAutoPickable> GetAllAutoPickableComponents() => default; // 0x0000000181B6E390-0x0000000181B6E440
	// [XID] // 0x0000000189A28C50-0x0000000189A28C70
	public void AddWindSeed(BaseEntity entity) {} // 0x0000000181B705D0-0x0000000181B706A0
	// [XID] // 0x0000000189A302F0-0x0000000189A30310
	public void RemoveWindSeed(BaseEntity entity) {} // 0x0000000181B6C110-0x0000000181B6C1E0
	// [XID] // 0x0000000189A37D50-0x0000000189A37D70
	public IList<BaseEntity> GetAllWindSeedEntities() => default; // 0x0000000181B75070-0x0000000181B75130
	// [XID] // 0x0000000189670E30-0x0000000189670E50
	public void AddAutoAttractEntity(IAutoAttract component) {} // 0x0000000181B68F10-0x0000000181B69010
	// [XID] // 0x0000000189616A10-0x0000000189616A30
	public bool HasAutoAttractEntity(IAutoAttract component) => default; // 0x0000000181B6FB10-0x0000000181B6FBE0
	// [XID] // 0x0000000189A26C40-0x0000000189A26C60
	public void RemoveAutoAttractEntity(IAutoAttract component) {} // 0x0000000181B790D0-0x0000000181B791A0
	// [XID] // 0x000000018967FDF0-0x000000018967FE10
	public IList<IAutoAttract> GetAllAutoAttractComponents() => default; // 0x0000000181B85140-0x0000000181B851F0
	// [XID] // 0x0000000189A5D300-0x0000000189A5D320
	public void AddPropAccurateMoveEntity(uint entityRuntimeID) {} // 0x0000000181B6EE80-0x0000000181B6EF80
	// [XID] // 0x0000000189A64C60-0x0000000189A64C80
	public void RemovePropAccurateMoveEntity(uint entityRuntimeID) {} // 0x0000000181B6D270-0x0000000181B6D370
	// [XID] // 0x0000000189A6C480-0x0000000189A6C4A0
	public IList<BaseEntity> GetAllPropAccurateMoveEntities() => default; // 0x0000000181B844A0-0x0000000181B84560
	// [XID] // 0x0000000189A73BF0-0x0000000189A73C10
	public VCWeather CurWeatherComponent() => default; // 0x0000000181B686F0-0x0000000181B687D0
	// [XID] // 0x0000000189A0C3F0-0x0000000189A0C410
	public void AddLocalEntity(uint entityRuntimeID) {} // 0x0000000181B84C60-0x0000000181B84D60
	// [XID] // 0x0000000189A82D80-0x0000000189A82DA0
	public void RemoveLocalEntity(uint entityRuntimeID) {} // 0x0000000181B79560-0x0000000181B79660
	// [XID] // 0x0000000189A8A760-0x0000000189A8A780
	public bool IsLocalEntity(BaseEntity entity) => default; // 0x0000000181B6CB20-0x0000000181B6CBF0
	// [XID] // 0x0000000189A91FA0-0x0000000189A91FC0
	public IList<BaseEntity> GetAllLocalEntities() => default; // 0x0000000181B79380-0x0000000181B79440
	// [XID] // 0x0000000189A99A20-0x0000000189A99A40
	public void CheckLocalEntity(bool force = false /* Metadata: 0x00AFE2A5 */) {} // 0x0000000181B799C0-0x0000000181B79C10
	// [XID] // 0x0000000189AA0A80-0x0000000189AA0AA0
	public void ForceUpdateAllLocalEntity(Vector3 checkPos) {} // 0x0000000181B78B20-0x0000000181B78D20
	// [XID] // 0x0000000189AA8100-0x0000000189AA8120
	public void ReplaceRuntimeID(BaseEntity entity, uint runtimeID) {} // 0x0000000181B71610-0x0000000181B716F0
	// [XID] // 0x0000000189AAFCF0-0x0000000189AAFD10
	public void SetCachedEntity(BaseEntity entity, BaseEntity.ClearReason clearReason = BaseEntity.ClearReason.Miss /* Metadata: 0x00AFE2A6 */, bool checkRemoveifCached = true /* Metadata: 0x00AFE2AA */) {} // 0x0000000181B82600-0x0000000181B82B80
	// [XID] // 0x0000000189AB7450-0x0000000189AB7470
	public void ForceClearCache() {} // 0x0000000181B7FF60-0x0000000181B802E0
	// [XID] // 0x0000000189ABEEB0-0x0000000189ABEED0
	public void ReuseCachedEntity(BaseEntity entity, bool withObj = true /* Metadata: 0x00AFE2AB */, bool runtimeIDChange = false /* Metadata: 0x00AFE2AC */) {} // 0x0000000181B83EB0-0x0000000181B843A0
	// [XID] // 0x0000000189A2E350-0x0000000189A2E370
	private void RemoveCachedEntity(BaseEntity entity) {} // 0x0000000181B72C90-0x0000000181B73040
	// [XID] // 0x0000000189ACE150-0x0000000189ACE170
	public BaseEntity GetCacheEntity(uint configID, uint runtimeID) => default; // 0x0000000181B6B980-0x0000000181B6BCE0
	// [XID] // 0x0000000189AD5F20-0x0000000189AD5F40
	public bool IsCachedEntity(BaseEntity entity) => default; // 0x0000000181B6A600-0x0000000181B6A770
	// [XID] // 0x0000000189ADD870-0x0000000189ADD890
	private void CheckCachedEntity() {} // 0x0000000181B79C10-0x0000000181B79FE0
	// [XID] // 0x0000000189AE5020-0x0000000189AE5040
	public override void InitOnConnect() {} // 0x0000000181B7A520-0x0000000181B7A5F0
	// [XID] // 0x0000000189AEC6A0-0x0000000189AEC6C0
	public override void ClearOnDisconnect() {} // 0x0000000181B6F110-0x0000000181B6F570
	// [XID] // 0x0000000189AF4130-0x0000000189AF4150
	public void AddAbilityEntity(uint entityRuntimeID) {} // 0x0000000181B76E60-0x0000000181B76F60
	// [XID] // 0x0000000189AFB8E0-0x0000000189AFB900
	public void RemoveAbilityEntity(uint entityRuntimeID) {} // 0x0000000181B835E0-0x0000000181B83780
	// [XID] // 0x0000000189B02F70-0x0000000189B02F90
	public IndexHandleObjectList<BaseEntity> GetAllAbilitiesEntities() => default; // 0x0000000181B6C960-0x0000000181B6CA20
	// [XID] // 0x0000000189B0A720-0x0000000189B0A740
	public IList<BaseEntity> GetAllFoundations() => default; // 0x0000000181B70E20-0x0000000181B70EE0
	// [XID] // 0x0000000189B11E00-0x0000000189B11E20
	private void AddFilterEntity(BaseEntity e) {} // 0x0000000181B67B10-0x0000000181B67EE0
	// [XID] // 0x0000000189B19050-0x0000000189B19070
	private void RemoveFilterEntity(BaseEntity entity) {} // 0x0000000181B7B700-0x0000000181B7B960
	// [XID] // 0x0000000189B20790-0x0000000189B207B0
	private void AddProxy(BaseEntity e) {} // 0x0000000181B80D90-0x0000000181B80E70
	// [XID] // 0x0000000189B27E50-0x0000000189B27E70
	public static BaseEntity ContainsSameRuntimeIDOrInstanceEntity(BaseEntity toCheckEntity, IEnumerable<BaseEntity> entityList) => default; // 0x0000000181B7D140-0x0000000181B7D330
	// [XID] // 0x0000000189B2F190-0x0000000189B2F1B0
	public static void DebugLogSameRuntimeIDOrInstanceEntity(BaseEntity toCheckEntity, IEnumerable<BaseEntity> entityList, string containerName) {} // 0x0000000181B76350-0x0000000181B76580
	// [XID] // 0x0000000189B36AF0-0x0000000189B36B10
	public void PreRemoveEntity(BaseEntity entity) {} // 0x0000000181B7E030-0x0000000181B7E290
	// [IDTag] // 0x0000000189B3E290-0x0000000189B3E2D0
	// [XID] // 0x0000000189B3E290-0x0000000189B3E2D0
	public int RemoveEntityInToBeRemoveList(BaseEntity entityToBeRemove) => default; // 0x0000000181B78E00-0x0000000181B790D0
	// [IDTag] // 0x0000000189B48E00-0x0000000189B48E40
	// [XID] // 0x0000000189B48E00-0x0000000189B48E40
	public void RemoveEntityInToBeRemoveList(uint entityRuntimeID) {} // 0x0000000181B78D20-0x0000000181B78E00
	// [XID] // 0x0000000189B53400-0x0000000189B53420
	public void SetNextForceFlushRemoveAllEntity() {} // 0x0000000181B74970-0x0000000181B74A10
	// [XID] // 0x0000000189B5AD10-0x0000000189B5AD30
	public void FlushRemoveEntity(bool useSliceFrame = true /* Metadata: 0x00AFE2AD */) {} // 0x0000000181B7F430-0x0000000181B7FB70
	// [XID] // 0x0000000189B62150-0x0000000189B62170
	public List<BaseEntity> GetEntitiesToBeRemove() => default; // 0x0000000181B853D0-0x0000000181B85480
	// [XID] // 0x0000000189B69DB0-0x0000000189B69DD0
	private bool RemoveEntity(BaseEntity entity, uint specifiedRuntimeID = 0 /* Metadata: 0x00AFE2AE */) => default; // 0x0000000181B6DDB0-0x0000000181B6E390
	// [XID] // 0x0000000189B712E0-0x0000000189B71300
	private void RemoveAllKindsOfCache(BaseEntity entity) {} // 0x0000000181B695C0-0x0000000181B69730
	// [XID] // 0x0000000189B78940-0x0000000189B78960
	public void SetEntitySleep(BaseEntity entity, bool sleep) {} // 0x0000000181B7D330-0x0000000181B7D790
	// [XID] // 0x0000000189AA19F0-0x0000000189AA1A10
	public bool IsEntitySleep(BaseEntity entity) => default; // 0x0000000181B7ED30-0x0000000181B7EE00
	// [XID] // 0x0000000189B87940-0x0000000189B87960
	private void InternalRemoveAllRemoveableEntites() {} // 0x0000000181B6EF80-0x0000000181B6F040
	// [XID] // 0x0000000189B8EA80-0x0000000189B8EAA0
	private void RemoveAllRemoveableEntites() {} // 0x0000000181B77B50-0x0000000181B77C70
	// [XID] // 0x00000001899C1EF0-0x00000001899C1F10
	private void SetEntityNull(BaseEntity entity) {} // 0x0000000181B6A770-0x0000000181B6A960
	// [XID] // 0x000000018989F6B0-0x000000018989F6D0
	private void RemoveSleepEntity(BaseEntity entity) {} // 0x0000000181B81560-0x0000000181B81630
	// [XID] // 0x0000000189BA4F10-0x0000000189BA4F30
	public BaseEntity GetEntityFromGameObejct(GameObject gameObject) => default; // 0x0000000181B6A420-0x0000000181B6A600
	// [XID] // 0x0000000189B55B60-0x0000000189B55B80
	public GameObject GetIdentiferGameObject(GameObject gameObject) => default; // 0x0000000181B75710-0x0000000181B75890
	// [XID] // 0x0000000189BB38D0-0x0000000189BB38F0
	private GameObject GetIdentiferGameObjectInChild(GameObject gameObject) => default; // 0x0000000181B68140-0x0000000181B68310
	// [XID] // 0x0000000189BBAEA0-0x0000000189BBAEC0
	private BaseEntity GetEntityFromGameObejctInChild(GameObject gameObject) => default; // 0x0000000181B72730-0x0000000181B72910
	// [XID] // 0x0000000189999410-0x0000000189999430
	public void AddGameObjectEntityIdentifer(uint handle, GameObject prefab) {} // 0x0000000181B80CB0-0x0000000181B80D90
	// [XID] // 0x0000000189BCA610-0x0000000189BCA630
	public void ResetGameObjectEntityIdentifer(uint handle, GameObject prefab) {} // 0x0000000181B68970-0x0000000181B68A90
	// [XID] // 0x0000000189BD1C20-0x0000000189BD1C40
	public void RemoveGameObjectEntityIdentifer(GameObject prefab) {} // 0x0000000181B7B0C0-0x0000000181B7B190
	// [XID] // 0x0000000189BD9250-0x0000000189BD9270
	public List<uint> SetEntitiesActive(List<uint> configIDs, bool active) => default; // 0x0000000181B73340-0x0000000181B73460
	// [IDTag] // 0x00000001895E5DD0-0x00000001895E5E10
	// [XID] // 0x00000001895E5DD0-0x00000001895E5E10
	private void SetEntitiesActiveInternal(SimpleSafeUInt32[] configIDs, bool active, bool isBlack) {} // 0x0000000181B70FC0-0x0000000181B71330
	// [IDTag] // 0x00000001895F05C0-0x00000001895F0600
	// [XID] // 0x00000001895F05C0-0x00000001895F0600
	private void SetEntitiesActiveInternal(List<uint> configIDs, bool active, bool isBlack) {} // 0x0000000181B71330-0x0000000181B71610
	// [XID] // 0x00000001895FAD50-0x00000001895FAD70
	public void BanEntityByConfig(string entityBan) {} // 0x0000000181B7EAF0-0x0000000181B7EC60
	// [XID] // 0x0000000189925AC0-0x0000000189925AE0
	private void BanOtherEntity(SimpleSafeUInt32[] entityList, bool isBlack) {} // 0x0000000181B7DAB0-0x0000000181B7DB90
	// [XID] // 0x0000000189893DC0-0x0000000189893DE0
	public void FreeEntityByConfig(string entityBan) {} // 0x0000000181B817D0-0x0000000181B81940
	// [XID] // 0x00000001898CF7D0-0x00000001898CF7F0
	private void FreeOtherEntity(SimpleSafeUInt32[] entityList, bool isBlack) {} // 0x0000000181B67A30-0x0000000181B67B10
	// [XID] // 0x0000000189619040-0x0000000189619060
	public bool IsNpcBaned(uint configId) => default; // 0x0000000181B6F910-0x0000000181B6FB10
	// [XID] // 0x0000000189620520-0x0000000189620540
	private void BanNpcEntity(ConfigEntityBlackGrp grp) {} // 0x0000000181B6DA60-0x0000000181B6DCE0
	// [XID] // 0x00000001896279B0-0x00000001896279D0
	private void FreeNpcEntity(ConfigEntityBlackGrp grp) {} // 0x0000000181B737B0-0x0000000181B73A30
	// [IDTag] // 0x000000018962F3D0-0x000000018962F410
	// [XID] // 0x000000018962F3D0-0x000000018962F410
	private void AddTagEntity(BaseEntity e) {} // 0x0000000181B84D60-0x0000000181B84E70
	// [IDTag] // 0x0000000189639CB0-0x0000000189639CF0
	// [XID] // 0x0000000189639CB0-0x0000000189639CF0
	public void AddTagEntity(string tag, BaseEntity e) {} // 0x0000000181B84E70-0x0000000181B85060
	// [IDTag] // 0x00000001896444D0-0x0000000189644510
	// [XID] // 0x00000001896444D0-0x0000000189644510
	public void RemoveTagEntity(BaseEntity e) {} // 0x0000000181B6CBF0-0x0000000181B6CE20
	// [IDTag] // 0x000000018964EB00-0x000000018964EB40
	// [XID] // 0x000000018964EB00-0x000000018964EB40
	public void RemoveTagEntity(string tag, BaseEntity e) {} // 0x0000000181B6CE20-0x0000000181B6CF80
	// [XID] // 0x00000001898A5BC0-0x00000001898A5BE0
	public IList<BaseEntity> GetTagEntities(string tag) => default; // 0x0000000181B6CA20-0x0000000181B6CB20
	// [XID] // 0x00000001896609B0-0x00000001896609D0
	public void SetEntityTags(BaseEntity e, IEnumerable<string> tags) {} // 0x0000000181B6D6D0-0x0000000181B6D880
	[Preserve] // 0x0000000189668400-0x0000000189668440
	// [XID] // 0x0000000189668400-0x0000000189668440
	public override string Dump(string tag) => default; // 0x0000000181B70CC0-0x0000000181B70E20
	// [XID] // 0x0000000189672FC0-0x0000000189672FE0
	private string GetEntityMapDumpInfo() => default; // 0x0000000181B75AB0-0x0000000181B75DC0
	// [XID] // 0x000000018967A5B0-0x000000018967A5D0
	private string GetEntityCacheDumpInfo() => default; // 0x0000000181B6A0B0-0x0000000181B6A420
	// [XID] // 0x0000000189681EB0-0x0000000189681ED0
	private string GetEntityTicklistDumpInfo() => default; // 0x0000000181B7B190-0x0000000181B7B3B0
	// [XID] // 0x0000000189689900-0x0000000189689920
	private void InitProxy() {} // 0x0000000181B85CA0-0x0000000181B85DE0
	// [XID] // 0x0000000189691660-0x0000000189691680
	public void PreTickProxy() {} // 0x0000000181B83260-0x0000000181B83300
	// [XID] // 0x0000000189698C90-0x0000000189698CB0
	public void TickProxy() {} // 0x0000000181B81310-0x0000000181B813C0
	// [XID] // 0x00000001896A0170-0x00000001896A0190
	private void DestroyProxy() {} // 0x0000000181B72370-0x0000000181B72470
	// [IDTag] // 0x00000001896A74C0-0x00000001896A7500
	// [XID] // 0x00000001896A74C0-0x00000001896A7500
	public bool IsInToBeRemoveList(BaseEntity e) => default; // 0x0000000181B81B20-0x0000000181B81C00
	// [IDTag] // 0x00000001896B13D0-0x00000001896B1410
	// [XID] // 0x00000001896B13D0-0x00000001896B1410
	public BaseEntity IsInToBeRemoveList(uint runtimeID) => default; // 0x0000000181B81940-0x0000000181B81B20
	// [XID] // 0x00000001896BBCA0-0x00000001896BBCC0
	public bool IsInEntityMap(BaseEntity e) => default; // 0x0000000181B85060-0x0000000181B85140
	// [XID] // 0x00000001896C3160-0x00000001896C3180
	public void addToDestroyReuseQueue(BaseEntity e) {} // 0x0000000181B72910-0x0000000181B729E0
	// [XID] // 0x00000001896CA670-0x00000001896CA690
	private void InitBlackList() {} // 0x0000000181B78340-0x0000000181B78400
	// [XID] // 0x00000001896D1D00-0x00000001896D1D20
	public void ClearDestroyReuseQueue() {} // 0x0000000181B68880-0x0000000181B68970
	// [XID] // 0x00000001896D9590-0x00000001896D95B0
	private void InitReuseCache() {} // 0x0000000181B849A0-0x0000000181B84B50
	// [XID] // 0x00000001896E0D50-0x00000001896E0D70
	public EntityReusedCache GetReusedCache(EntityReuseType entityReuseType) => default; // 0x0000000181B798D0-0x0000000181B799C0
	// [XID] // 0x00000001896E8000-0x00000001896E8020
	public void TickReUseCache(SliceFrameWatch watch) {} // 0x0000000181B7AD60-0x0000000181B7AFE0
	// [XID] // 0x00000001896EF6A0-0x00000001896EF6C0
	public string DumpReUseCache() => default; // 0x0000000181B6D4B0-0x0000000181B6D6D0
	// [XID] // 0x00000001896BCBC0-0x00000001896BCBE0
	public bool isEntityCanbeReusedByConfigID(BaseEntity entity) => default; // 0x0000000181B7BF40-0x0000000181B7C1A0
	// [XID] // 0x00000001896FE920-0x00000001896FE940
	public bool TrySetReusedEntityToCache(BaseEntity entity) => default; // 0x0000000181B78400-0x0000000181B78980
	// [XID] // 0x0000000189705B80-0x0000000189705BA0
	public BaseEntity TryGetReusedEntity(uint configId, EntityReuseType reuseType) => default; // 0x0000000181B82D80-0x0000000181B82F10
	// [XID] // 0x000000018970D5D0-0x000000018970D5F0
	private void HandlePostReInit(BaseEntity entity, AbilitySyncStateInfo abilitySyncInfo) {} // 0x0000000181B6BCE0-0x0000000181B6BE50
	// [XID] // 0x00000001897149D0-0x00000001897149F0
	public void ReuseEntity(BaseEntity entity, Vector3 initPos, Quaternion initRotation, float initScale, AbilitySyncStateInfo abilitySyncInfo, DataItem dataItem) {} // 0x0000000181B84560-0x0000000181B84940
	// [XID] // 0x000000018971C460-0x000000018971C480
	public void ReUseGadget(GadgetEntity gadget, Vector3 initPos, Quaternion initRotation, float initScale, ConfigGadget jsonConfig, GadgetDataItem dataItem, uint targetRuntimeID, uint targetLockPointIndex, AbilitySyncStateInfo abilitySyncInfo) {} // 0x0000000181B85520-0x0000000181B85CA0
	// [XID] // 0x0000000189723850-0x0000000189723870
	public void ReUseMonster(MonsterEntity monster, Vector3 initPos, Quaternion initRotation, float initScale, ConfigMonster jsonConfig, MonsterDataItem dataItem, bool isElite, List<uint> affixList, LCAIBetaData aiData, int currentPoseID, AbilitySyncStateInfo abilitySyncInfo) {} // 0x0000000181B69730-0x0000000181B69DA0
	// [XID] // 0x00000001897B12F0-0x00000001897B1310
	private void RenameEntityName(GameObject go, uint runtimeID) {} // 0x0000000181B6FC80-0x0000000181B6FDF0
	// [XID] // 0x0000000189732760-0x0000000189732780
	public void ClearResuedEntities() {} // 0x0000000181B76C90-0x0000000181B76E60
	// [XID] // 0x0000000189739EA0-0x0000000189739EC0
	private void DestroyResuedEntities() {} // 0x0000000181B68500-0x0000000181B686F0
	// [XID] // 0x0000000189741A00-0x0000000189741A20
	public bool IsCenterValid() => default; // 0x0000000181B7AB30-0x0000000181B7AD60
	// [XID] // 0x0000000189749340-0x0000000189749360
	public Vector3 GetCenterAgentPosition() => default; // 0x0000000181B76580-0x0000000181B76700
	// [XID] // 0x00000001897507C0-0x00000001897507E0
	public bool ShiftWorld(Vector3 newShift, Vector3 oldShift) => default; // 0x0000000181B85F30-0x0000000181B86240
	// [XID] // 0x0000000189757CB0-0x0000000189757CD0
	private void ShiftOneEntity(BaseEntity entity, Vector3 newShift, Vector3 oldShift) {} // 0x0000000181B81C00-0x0000000181B81EE0
	// [XID] // 0x000000018975F730-0x000000018975F750
	private void InitTaskGroups() {} // 0x0000000181B6E440-0x0000000181B6E5B0
	private IGroup AddGroup<GroupNodeType>(EntityTaskType taskType)
		where GroupNodeType : IGroupNode, new() => default;
	private TaskGroup<GroupNodeType> GetGroup<GroupNodeType>(EntityTaskType taskType)
		where GroupNodeType : IGroupNode, new() => default;
	// [XID] // 0x0000000189766BE0-0x0000000189766C00
	private void DestroyTaskGroups() {} // 0x0000000181B76700-0x0000000181B76800
	// [XID] // 0x0000000189775A00-0x0000000189775A20
	public void CacheAvatarPositionUnityThread() {} // 0x0000000181B768F0-0x0000000181B76B40
	// [XID] // 0x0000000189784CC0-0x0000000189784CE0
	public void StatIterEntity(Action<BaseEntity> inFun) {} // 0x0000000181B6F740-0x0000000181B6F910
	// [XID] // 0x00000001897A2D40-0x00000001897A2D60
	public static CycleStatTickModuleNode CollectTickModule(CycleStat inStat, TickType inType) => default; // 0x0000000181B6D030-0x0000000181B6D270
	// [XID] // 0x00000001897AA340-0x00000001897AA360
	public static string GetCSTMNTreeJson() => default; // 0x0000000181B80E70-0x0000000181B810E0
	// [XID] // 0x00000001897B1DD0-0x00000001897B1DF0
	public static string GetTMMMAJson() => default; // 0x0000000181B7BA50-0x0000000181B7BD50
	// [XID] // 0x00000001897B97F0-0x00000001897B9810
	public static List<string> GetTMMACSV() => default; // 0x0000000181B69DA0-0x0000000181B6A0B0
	// [XID] // 0x00000001897C1850-0x00000001897C1870
	private static void CollectTickModuleCurrentFrameStats(ref StatFrameData inFrameData) {} // 0x0000000181B7FDF0-0x0000000181B7FF60
	// [XID] // 0x00000001897C9260-0x00000001897C9280
	public static void FlushLog(bool bRequestClear, long inStatProfilerFinishTime) {} // 0x0000000181B6AB90-0x0000000181B6B0E0
	// [XID] // 0x00000001897D0890-0x00000001897D08B0
	public List<CycleStatLogNode> GenerateThisFrameTickStatLog(ref StatFrameData inFrameData) => default; // 0x0000000181B77440-0x0000000181B77800
	// [XID] // 0x00000001897D85A0-0x00000001897D85C0
	public string GenerateEntityTickStatLog() => default; // 0x0000000181B76F60-0x0000000181B773C0
}

