/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using FullInspector;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class EntityTickBalanceProxy : BalanceTickObjectProxyWithDelayDowngradeTickLOD // TypeDefIndex: 21291
{
	// Fields
	public const int KEEP_FORCETICK_FRAMECOUNT = 15; // Metadata: 0x00AFF416
	public const float NONCACHE_VIEWSIZETAG = -10f; // Metadata: 0x00AFF41A
	public const float NOVALID_VIEWSIZETAG = -1f; // Metadata: 0x00AFF41E
	private bool _bEntityStructureDirty; // 0x48
	private int _atLeastTickLOD; // 0x4C
	public int targetAtLeastTickLOD; // 0x50
	public static bool hasOtherRemotePlayerArround; // 0x00
	private float _entityViewSize; // 0x54
	private float _entityForcePauseTickDistanceSqr; // 0x58
	private float _bestEntityFullTickSqrMag; // 0x5C
	private float _lastConfigedEntityFullTickSqrMag; // 0x60
	public Vector3 _entitySharedPosition; // 0x64
	public bool _entityCachedRendering; // 0x70
	private BaseEntity _owner; // 0x78
	private Action<float, ITokenBudgetComponent> _onCollectTokenBudget; // 0x80
	private bool _ignoreIntervalTick; // 0x88
	private int _tickLodUnityThreadReadOnly; // 0x8C
	private float _balanceTickDeltaTimeUnityThreadReadOnly; // 0x90
	private EntityTickState _entityTickState; // 0x98
	private bool _preferSyncReady; // 0xA8
	public const int entityLowestNonPauseTickLOD = 3; // Metadata: 0x00AFF422
	public const int entityPauseTickLOD = 7; // Metadata: 0x00AFF426
	private BoundsOccluder _boundsOcculuder; // 0xB8
	private Bounds _bounds; // 0xC0
	public ReadyState readyState; // 0xD8
	public int generationUnityThread; // 0xE0
	public int generationJobThread; // 0xE4
	private float _lastNearestAvatarDistanceSqr; // 0xE8
	public int benchmarkOverrideTickLOD; // 0xEC
	public static float halfTickVisibleDistRatioDefault; // 0x04
	public static float halfTickInvisibleDistRatioDefault; // 0x08
	public static float eighthTickInvisibleDistRatioDefault; // 0x0C
	public static float halfTickVisibleDistRatioSquare; // 0x10
	public static float halfTickRatioInvisibleDistRatioSquare; // 0x14
	public static float eighthTickInvisibleDistRatioSquare; // 0x18
	public float _entityComponentBudgetForceFullTick; // 0xFC
	public float _entityComponentBudgetBalanceTick; // 0x100
	private float _entityTypeTokenScore; // 0x104
	public const float TokenPriorityScore_DisablePause = 1000f; // Metadata: 0x00AFF42A
	public const float TokenPriorityScore_ForcedFullTickLOD = 10000f; // Metadata: 0x00AFF42E
	private int _remainingForceCheckVisibleCount; // 0x108
	public const int targetRemainingForceCheckVisibleCount = 6; // Metadata: 0x00AFF432
	private HashSet<Action<BaseEntity, int, int>> _onTickLODChanged; // 0x110
	private const int renderingCacheFrameCountScale = 4; // Metadata: 0x00AFF436
	private const int maxNotCullButPauseStateCacheRenderingStateFrameCount = 8; // Metadata: 0x00AFF43A
	private static System.Random rnd; // 0x20
	private int _accumulatedProxyUpdateCount; // 0x118
	private int _cacheRenderingFrameRemainder; // 0x11C
	private int _cacheRenderingFrameCount; // 0x120

	// Properties
	public bool _entityForceUseTickLOD0 { /* [XID] */ /* 0x0000000189808FD0-0x0000000189808FF0 */ get => default; } // 0x00000001810C00E0-0x00000001810C0190 
	public bool _entityDisablePause { /* [XID] */ /* 0x00000001896BA490-0x00000001896BA4B0 */ get => default; } // 0x00000001810C4340-0x00000001810C43F0 
	private bool _entityActive { /* [XID] */ /* 0x00000001896C16E0-0x00000001896C1700 */ get => default; } // 0x00000001810C4290-0x00000001810C4340 
	public bool entityFullAnimatorTick { /* [XID] */ /* 0x00000001896C8E00-0x00000001896C8E20 */ get => default; } // 0x00000001810C0AE0-0x00000001810C0B90 
	public bool entityShouldForcePauseTickByDistance { /* [XID] */ /* 0x00000001896D07C0-0x00000001896D07E0 */ get => default; } // 0x00000001810C0820-0x00000001810C08D0 
	private float _entityFullTickSqrMag { /* [XID] */ /* 0x00000001896D7CD0-0x00000001896D7CF0 */ get => default; } // 0x00000001810BEF30-0x00000001810BF0D0 
	private bool _entityDisableAnimatorInterleave { /* [XID] */ /* 0x00000001896DF5A0-0x00000001896DF5C0 */ get => default; } // 0x00000001810C0770-0x00000001810C0820 
	private bool _entityReady { /* [XID] */ /* 0x00000001896E68A0-0x00000001896E68C0 */ get => default; } // 0x00000001810BF600-0x00000001810BF6B0 
	public BaseEntity entity { /* [XID] */ /* 0x00000001896F56F0-0x00000001896F5710 */ get => default; /* [XID] */ /* 0x00000001896FCF10-0x00000001896FCF30 */ set {} } // 0x00000001810C4150-0x00000001810C41F0 0x00000001810C1000-0x00000001810C1400
	public int tickLODExecute { /* [XID] */ /* 0x000000018971AD00-0x000000018971AD20 */ get => default; /* [XID] */ /* 0x0000000189722000-0x0000000189722020 */ private set {} } // 0x00000001810C06D0-0x00000001810C0770 0x00000001810C0BF0-0x00000001810C0CA0
	public int tickLODPrepare { /* [XID] */ /* 0x0000000189729730-0x0000000189729750 */ get => default; } // 0x00000001810C2540-0x00000001810C25E0 
	public int tickIntevalExecute { /* [XID] */ /* 0x0000000189730F20-0x0000000189730F40 */ get => default; } // 0x00000001810C3C50-0x00000001810C3D20 
	public int tickIntevalPrepare { /* [XID] */ /* 0x00000001897387D0-0x00000001897387F0 */ get => default; } // 0x00000001810C0190-0x00000001810C0260 
	public float balanceTickDeltaTimeExecute { /* [XID] */ /* 0x00000001898822E0-0x0000000189882300 */ get => default; /* [XID] */ /* 0x00000001897478B0-0x00000001897478D0 */ private set {} } // 0x00000001810C4690-0x00000001810C4740 0x00000001810C4EC0-0x00000001810C4F70
	public float balanceTickDeltaTimePrepare { /* [XID] */ /* 0x0000000189756780-0x00000001897567A0 */ get => default; } // 0x00000001810C1C50-0x00000001810C1D00 
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	public EntityTickState entityTickState { /* [XID] */ /* 0x0000000189690C60-0x0000000189690C80 */ get => default; } // 0x00000001810C43F0-0x00000001810C44C0 
	public bool preferSyncReady { /* [XID] */ /* 0x00000001897651C0-0x00000001897651E0 */ get => default; } // 0x00000001810BEC50-0x00000001810BED00 
	public bool bRequestPauseJobThread { /* [XID] */ /* 0x0000000189601D50-0x0000000189601D70 */ get => default; } // 0x00000001810C2230-0x00000001810C22E0 
	public bool bIsPauseUnityThread { /* [XID] */ /* 0x000000018978A840-0x000000018978A860 */ get => default; } // 0x00000001810C22E0-0x00000001810C2390 
	public TickState animatorTickState { /* [XID] */ /* 0x0000000189791EE0-0x0000000189791F20 */ get; /* [XID] */ /* 0x000000018979D150-0x000000018979D190 */ private set; } // 0x00000001810C0B90-0x00000001810C0BF0 0x00000001810C2780-0x00000001810C27F0
	public int tickCount { /* [XID] */ /* 0x00000001897A7440-0x00000001897A7480 */ get; /* [XID] */ /* 0x00000001897B1D10-0x00000001897B1D50 */ private set; } // 0x00000001810C3EF0-0x00000001810C3F50 0x00000001810BEEC0-0x00000001810BEF30
	public int requestTickInterval { /* [XID] */ /* 0x00000001897BD1D0-0x00000001897BD1F0 */ get => default; } // 0x00000001810C08D0-0x00000001810C09A0 
	public int usingTickLOD { /* [XID] */ /* 0x00000001897F1CD0-0x00000001897F1CF0 */ get => default; } // 0x00000001810C3150-0x00000001810C3200 
	public string gizmoDebugString { /* [XID] */ /* 0x00000001897F9510-0x00000001897F9550 */ get; /* [XID] */ /* 0x0000000189803B50-0x0000000189803B90 */ private set; } // 0x00000001810C0260-0x00000001810C02C0 0x00000001810C4C80-0x00000001810C4CF0
	public float lastNearestAvatarDistance { /* [XID] */ /* 0x000000018980E030-0x000000018980E050 */ get => default; } // 0x00000001810BEDE0-0x00000001810BEEC0 
	public bool culledByFrustum { /* [XID] */ /* 0x00000001898580E0-0x0000000189858120 */ get; /* [XID] */ /* 0x00000001898626D0-0x0000000189862710 */ private set; } // 0x00000001810C16D0-0x00000001810C1730 0x00000001810BF590-0x00000001810BF600
	private bool shouldForceCheckVisible { /* [XID] */ /* 0x0000000189ABCEB0-0x0000000189ABCED0 */ get => default; } // 0x00000001810C3200-0x00000001810C32B0 

	// Nested types
	public struct EntityTickState // TypeDefIndex: 21292
	{
		// Fields
		public bool isValid; // 0x00
		public bool shouldTickBeforeReady; // 0x01
		public bool isLevelReadyToExecuteTickFunctions; // 0x02
		public bool hasComponentsToTick; // 0x03
		public bool hasComponentsToLateTick; // 0x04
		public bool isDisablePause; // 0x05
		public bool hasComponentsToBeAdded; // 0x06
		public EntityTickBalanceProxy ownerTickBalanceProxy; // 0x08

		// Methods
		// [XID] // 0x00000001899637C0-0x00000001899637E0
		public void CacheEntityState(BaseEntity owner, out bool isLoaded, out bool isReady) {
			isLoaded = default;
			isReady = default;
		} // 0x00000001810B8DD0-0x00000001810B8E50
	}

	public struct ReadyState // TypeDefIndex: 21293
	{
		// Fields
		public bool isVisionMiss; // 0x00
		public bool isReadyFrame; // 0x01
		public bool isCulled; // 0x02
		public float toAvatarDistance; // 0x04
	}

	public class Spawner : ISpawner<EntityTickBalanceProxy> // TypeDefIndex: 21294
	{
		// Constructors
		public Spawner() {} // 0x00000001810F18F0-0x00000001810F1950

		// Methods
		// [XID] // 0x000000018996AC00-0x000000018996AC20
		public EntityTickBalanceProxy Spawn() => default; // 0x00000001810F1810-0x00000001810F18F0
	}

	// Constructors
	public EntityTickBalanceProxy() {} // 0x00000001810C5DB0-0x00000001810C5EA0
	static EntityTickBalanceProxy() {} // 0x00000001810C5C50-0x00000001810C5DB0

	// Methods
	// [XID] // 0x000000018966FDF0-0x000000018966FE10
	public override void CheckIntervalSanity() {} // 0x00000001810BFAB0-0x00000001810BFBD0
	// [XID] // 0x0000000189677620-0x0000000189677640
	private static BaseEntity GetEntity(uint inID) => default; // 0x00000001810BE9C0-0x00000001810BEAA0
	// [XID] // 0x000000018967EC00-0x000000018967EC20
	private static EntityManager GetEntityManager() => default; // 0x00000001810BFDC0-0x00000001810BFE80
	// [XID] // 0x00000001896864F0-0x0000000189686510
	public override string ToString() => default; // 0x00000001810C5AA0-0x00000001810C5B90
	// [XID] // 0x000000018968E350-0x000000018968E370
	public override string GetEntityTypeString() => default; // 0x00000001810C1DD0-0x00000001810C1F60
	// [XID] // 0x0000000189695C10-0x0000000189695C30
	public static bool IsParamUnCached(float inParam) => default; // 0x00000001810BFE80-0x00000001810BFF40
	// [XID] // 0x000000018969D380-0x000000018969D3A0
	public static void SetParamHasBeenCached(ref float inParam) {} // 0x00000001810C1730-0x00000001810C17D0
	// [XID] // 0x00000001896A4440-0x00000001896A4460
	public static void SetParamUnCached(ref float inParam) {} // 0x00000001810C1860-0x00000001810C1900
	// [XID] // 0x00000001897DD5A0-0x00000001897DD5C0
	public void SetEntityStructureDirty() {} // 0x00000001810C44C0-0x00000001810C45F0
	// [XID] // 0x00000001896EDEB0-0x00000001896EDED0
	public BaseEntity GetOwnerWithBindingCheck() => default; // 0x00000001810C04D0-0x00000001810C0590
	// [XID] // 0x0000000189704360-0x0000000189704380
	public bool ShouldUseSyncReadyOnCreatedSkillObjectReadyOnlyUnityThread() => default; // 0x00000001810C1400-0x00000001810C1520
	// [XID] // 0x000000018970BBF0-0x000000018970BC10
	public override void SyncTickStateToUnityThread() {} // 0x00000001810C59E0-0x00000001810C5AA0
	// [XID] // 0x0000000189713460-0x0000000189713480
	public override void SetShouldTick(bool bInShouldTick, double inGlobalTime) {} // 0x00000001810C5620-0x00000001810C5770
	// [XID] // 0x000000018974F050-0x000000018974F070
	public void SetForceTick() {} // 0x00000001810C26D0-0x00000001810C2780
	// [XID] // 0x000000018976CC60-0x000000018976CC80
	public void SetForceTickPrerequisite(bool forceSetAsValid) {} // 0x00000001810C1900-0x00000001810C19C0
	// [XID] // 0x0000000189774060-0x0000000189774080
	public void CacheEntityTickState(BaseEntity inOwner, out bool isLoaded, out bool isReady) {
		isLoaded = default;
		isReady = default;
	} // 0x00000001810C0380-0x00000001810C04D0
	// [XID] // 0x000000018977B7E0-0x000000018977B800
	public override void UpdateDeltaTime(float inDeltaTime) {} // 0x00000001810C5B90-0x00000001810C5C50
	// [XID] // 0x00000001897C4580-0x00000001897C45A0
	public void OverrideCullBounds(float inRadius) {} // 0x00000001810C3D20-0x00000001810C3EF0
	// [XID] // 0x00000001897CBD70-0x00000001897CBD90
	public override void OnRegisteredJobThread() {} // 0x00000001810C4A10-0x00000001810C4AC0
	// [XID] // 0x00000001897D37A0-0x00000001897D37C0
	public void ForceSyncCullingAndToLocalAvatarDistance(BaseEntity inEntity) {} // 0x00000001810C3A20-0x00000001810C3C50
	// [XID] // 0x0000000189825560-0x0000000189825580
	public void OnVisionMiss() {} // 0x00000001810C2190-0x00000001810C2230
	// [XID] // 0x00000001897E28C0-0x00000001897E28E0
	public override void OnRegisteredUnityThread() {} // 0x00000001810C4AC0-0x00000001810C4B70
	// [XID] // 0x00000001897E9FE0-0x00000001897EA000
	public override bool ShouldForceTickNextFrame() => default; // 0x00000001810C5770-0x00000001810C5820
	// [XID] // 0x00000001898156D0-0x00000001898156F0
	public void RefreshGizmoDebugString() {} // 0x00000001810C32B0-0x00000001810C3A20
	// [XID] // 0x000000018981D120-0x000000018981D140
	public void ResetTickCount() {} // 0x00000001810C1B70-0x00000001810C1C50
	// [XID] // 0x0000000189B915B0-0x0000000189B915D0
	public void ReInit() {} // 0x00000001810C2030-0x00000001810C20E0
	// [XID] // 0x000000018982C010-0x000000018982C030
	protected override void Init() {} // 0x00000001810C2C00-0x00000001810C2FA0
	// [XID] // 0x0000000189833520-0x0000000189833540
	public static void UpdateTickStrategyDistance(float inHalfTickVisibleDR, float inHalfTickInvisibleDR, float inEighthTickInvisibleDR) {} // 0x00000001810C2390-0x00000001810C2540
	// [XID] // 0x000000018983AA00-0x000000018983AA20
	public static void RequestTickStrategyDistanceChange(EntityTickStrategyDistRatioConfig inConfig) {} // 0x00000001810C48E0-0x00000001810C4A10
	// [XID] // 0x0000000189841FE0-0x0000000189842000
	public static void RestoreDefaultTickStrategyDistance() {} // 0x00000001810BF6B0-0x00000001810BF800
	// [XID] // 0x00000001898494E0-0x0000000189849500
	private int CalcTickLOD(bool bVisible, float inDistanceSqr) => default; // 0x00000001810C4F70-0x00000001810C51C0
	// [XID] // 0x00000001896985D0-0x00000001896985F0
	public static int TickLODToTickInterval(int inLOD) => default; // 0x00000001810BF140-0x00000001810BF270
	// [XID] // 0x000000018986C8B0-0x000000018986C8D0
	private void UpdateTickLODPrerequisite() {} // 0x00000001810C41F0-0x00000001810C4290
	// [XID] // 0x0000000189873D60-0x0000000189873D80
	private int PostDecideRequestTickLOD(int newRequestLOD, float deltaTime) => default; // 0x00000001810C25E0-0x00000001810C26D0
	// [XID] // 0x000000018987B800-0x000000018987B820
	private bool IsVisible() => default; // 0x00000001810BEAA0-0x00000001810BEBA0
	// [XID] // 0x00000001898829B0-0x00000001898829D0
	public override float CollectTokenPriority() => default; // 0x00000001810BFBD0-0x00000001810BFDC0
	// [XID] // 0x000000018988A170-0x000000018988A190
	public static float ScaleRuntimeTokenFromConfigBudget(float inConfigBudget) => default; // 0x00000001810BF360-0x00000001810BF410
	// [XID] // 0x0000000189891620-0x0000000189891640
	public static bool AccumulateRuntimeTokenBudget(ITokenBudgetComponent inComp, float configTokenBudget, float budgetScale, ref float tokenBudgetsFullTick, ref float tokenBudgetsBalanceTick, bool shouldConsiderEnable) => default; // 0x00000001810BFF40-0x00000001810C00E0
	// [XID] // 0x0000000189898E50-0x0000000189898E70
	public static float CalcTokenBudget(ITokenBudgetComponent inComp, float configTokenBudget, float budgetScale, float oneOverInterval, bool shouldConsiderEnable) => default; // 0x00000001810C1520-0x00000001810C16D0
	// [XID] // 0x000000018989FFD0-0x000000018989FFF0
	private float CalcTokenBudgetByTickLOD(int inTickLOD) => default; // 0x00000001810BF410-0x00000001810BF530
	// [XID] // 0x00000001898A7850-0x00000001898A7870
	public override float CalcTokenBudgetByTotalToken(float inTotalToken, float deltaTime) => default; // 0x00000001810BF800-0x00000001810BF9A0
	// [XID] // 0x00000001898AF310-0x00000001898AF330
	public override int GetLastInterval() => default; // 0x00000001810C1F60-0x00000001810C2030
	// [XID] // 0x00000001898B6790-0x00000001898B67B0
	public override int GetCurrentInterval() => default; // 0x00000001810C1D00-0x00000001810C1DD0
	// [XID] // 0x00000001898BDF40-0x00000001898BDF60
	private int CalcRequestTickLODWhenEntityNotReady() => default; // 0x00000001810C20E0-0x00000001810C2190
	// [XID] // 0x00000001898C5810-0x00000001898C5830
	private void UpdateAtLeastTickLOD() {} // 0x00000001810C0CA0-0x00000001810C1000
	// [XID] // 0x00000001898CCEF0-0x00000001898CCF10
	private bool ShouldUseSinglePlayerStrategy() => default; // 0x00000001810C4740-0x00000001810C48E0
	// [XID] // 0x00000001898D4850-0x00000001898D4870
	private int CalcRequestTickLODWhenEntityReady() => default; // 0x00000001810C27F0-0x00000001810C2C00
	// [XID] // 0x00000001898DC250-0x00000001898DC270
	private void CollectTokenBudget(float inBudget, ITokenBudgetComponent inComp) {} // 0x00000001810C3F50-0x00000001810C40D0
	// [XID] // 0x00000001898E3C20-0x00000001898E3C40
	public void OnEntityStructureChange() {} // 0x00000001810C19C0-0x00000001810C1B70
	// [XID] // 0x00000001898EB7D0-0x00000001898EB7F0
	private void UpdateAnimatorTickState() {} // 0x00000001810C2FA0-0x00000001810C3150
	// [XID] // 0x00000001898F3020-0x00000001898F3040
	protected override bool ShouldInstantActivateTickLOD(int newRequestLOD) => default; // 0x00000001810C5820-0x00000001810C5900
	// [XID] // 0x00000001898FA700-0x00000001898FA720
	private int CalcTickLODWithoutTokenLimit(float dt) => default; // 0x00000001810BF270-0x00000001810BF360
	// [XID] // 0x0000000189902070-0x0000000189902090
	public override float CalcTokenBudgetWithOutBudgetLimit(float dt) => default; // 0x00000001810BF9A0-0x00000001810BFAB0
	// [XID] // 0x0000000189910EF0-0x0000000189910F10
	public void ForceCalcCull() {} // 0x00000001810C45F0-0x00000001810C4690
	// [XID] // 0x00000001899189D0-0x00000001899189F0
	private bool ShouldCalcCull() => default; // 0x00000001810C4DB0-0x00000001810C4EC0
	// [XID] // 0x00000001899201D0-0x00000001899201F0
	public bool ShouldCacheRenderingCache() => default; // 0x00000001810C0590-0x00000001810C06D0
	// [XID] // 0x0000000189927A30-0x0000000189927A50
	public virtual void RegisterOnTickLODChanged(Action<BaseEntity, int, int> inOnTickLODChanged) {} // 0x00000001810C51C0-0x00000001810C5300
	// [XID] // 0x000000018992F1E0-0x000000018992F200
	public virtual void UnregisterOnTickLODChanged(Action<BaseEntity, int, int> inOnTickLODChanged) {} // 0x00000001810C09A0-0x00000001810C0AE0
	// [XID] // 0x00000001899365D0-0x00000001899365F0
	public override int SyncTickLODInfo() => default; // 0x00000001810C5900-0x00000001810C59E0
	// [XID] // 0x000000018993E030-0x000000018993E050
	public override void ProcessOnTickLODChange(int fromLOD, int toLOD) {} // 0x00000001810C5300-0x00000001810C5620
	// [XID] // 0x0000000189945720-0x0000000189945740
	public void OnAdded(BoundsOccluder inOcculuder) {} // 0x00000001810BEBA0-0x00000001810BEC50
	// [XID] // 0x000000018994CBD0-0x000000018994CBF0
	public override void OnRemovedFromTickGroup() {} // 0x00000001810C4B70-0x00000001810C4C80
	// [XID] // 0x0000000189954310-0x0000000189954330
	public override void DeallocateToObjectPool() {} // 0x00000001810C02C0-0x00000001810C0380
}

