/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoEffect : MonoBehaviour, IEventDispatcher<BaseEvent>, ITickWithGlobalAndDeltaTime, ILateTickable, IWorldShiftAgent // TypeDefIndex: 19680
	{
		// Fields
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public float duration; // 0x18
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public Vector3 offsetVec3; // 0x1C
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public Bounds bounds; // 0x28
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public StopEmitAction stopEmitAction; // 0x40
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public float remainingLifetimeAfterStopEmit; // 0x44
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public bool onlyValidForSpecifiedParticleSystems; // 0x48
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public ParticleSystem[] specifiedParticleSystems; // 0x50
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public DisableAction disableAction; // 0x58
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public bool ignoreTimeScale; // 0x5C
		private ulong _prefabPathHash; // 0x70
		private bool _isToBeDeallocated; // 0x7A
		private MEventDispatcher _dispatcher; // 0x80
		public DateTime lastUsedTime; // 0x88
		private float _timeSinceInit; // 0x98
		private Action<EvtEntityDestroy> _onOwnerDestroy; // 0xA0
		private Action<EvtEntityActiveChange> _onOwnerActiveChange; // 0xA8
		private Action<EvtEntityTimeScaleChange> _onLevelTimeScaleChange; // 0xB0
		private Action<EvtEntityDestroy> _onLevelDestroy; // 0xB8
		private Action<EvtEntityTimeScaleChange> _onOwnerTimeScaleChange; // 0xC0
		private Action<float> _onSystemTimeScaleChange; // 0xC8
		private const float _balanceTickDeltaTimeScale = 4f; // Metadata: 0x00AFCC67
		private const float _maximumNoTickInterval = 1f; // Metadata: 0x00AFCC6B
		private float _lastTickPaticleStatusTime; // 0xD0
		private static int _timeScaleID; // 0x00
		private float _lastTimeScale; // 0xEC
		private TimerReceiver _timer; // 0xF0
		private const int MAX_PARTICLE_COUNT = 1000; // Metadata: 0x00AFCC6F
		private static ParticleSystem.Particle[] _particles; // 0x08
		private ParticleSystem[] _allParticleSystems; // 0xF8
		private const int DEFAULT_FALLOFF_END_DIST = 150; // Metadata: 0x00AFCC73
		private const int DEFAULT_FALLOFF_START_DIST = 50; // Metadata: 0x00AFCC77
		private const int MIN_DIS_BETWEEN_START_AND_END = 10; // Metadata: 0x00AFCC7B
		private Animation[] _allAnimations; // 0x110
		private Animator[] _allAnimators; // 0x118
		private AnimatorControllerParameter[][] _allAnimatorParams; // 0x120
		private List<MonoBehaviour> _allMonos; // 0x128
		private ParticleSystemRenderer[] _allParticleSystemRenderers; // 0x130
		private MeshRenderer[] _allMeshRenderers; // 0x138
		private SkinnedMeshRenderer[] _allSkinnedMeshRenderers; // 0x140
		private TrailRenderer[] _allTrailRenderers; // 0x148
		private bool[] _allParticleSystemRendererInitEnables; // 0x150
		private bool[] _allMeshRendererInitEnables; // 0x158
		private bool[] _allSkinnedMeshRendererInitEnables; // 0x160
		private static int _zTestPropertyID; // 0x10
		private static HashSet<string> _particleSystemRendererShadersWithZTest; // 0x18
		private static List<ParticleSystemRenderer> _particleSystemRendererWithZTestPropertyList; // 0x20
		private ParticleSystemRenderer[] _particleSystemRendererWithZTestProperty; // 0x168
		private BaseMonoEffectPlugin[] _effectPlugins; // 0x170
		private List<BaseMonoEffectPlugin> _initEffectPlugins; // 0x178
		private List<BaseMonoEffectPlugin> _clearEffectPlugins; // 0x180
		private List<BaseMonoEffectPlugin> _enabledEffectPlugins; // 0x188
		private List<BaseMonoEffectPlugin> _disabledEffectPlugins; // 0x190
		private List<BaseMonoEffectPlugin> _tickEffectPlugins; // 0x198
		private List<BaseMonoEffectPlugin> _lateTickEffectPlugins; // 0x1A0
		private List<BaseMonoEffectPlugin> _checkDeallocateEffectPlugins; // 0x1A8
		private List<BaseMonoEffectPlugin> _destroiedEffectPlugins; // 0x1B0
		private List<BaseMonoEffectPlugin> _deallocatedEffectPlugins; // 0x1B8
		private List<BaseMonoEffectPlugin> _setStoppedEffectPlugins; // 0x1C0
		private List<BaseMonoEffectPlugin> _emittingStoppedEffectPlugins; // 0x1C8
		private List<MonoEffectPluginAnimatorPose> _cachedAnimatorPosePlugin; // 0x1D0
		private bool _needTick; // 0x1D8
		private bool _needLateTick; // 0x1D9
		private int _defaultLayer; // 0x1DC
		private int _hiddenLayer; // 0x1E0
		private MonoEffectProxy _proxyAttachedTo; // 0x1E8
		private List<Vector3> _subEmitterEmitBuffer; // 0x1F0
		private bool _containsSubEmitter; // 0x1F8
		private static HashSet<ulong> _towerFireOnlineLog; // 0x28
		private static List<string> _towerFireNameOnlineLog; // 0x30
		private static HashSet<ulong> _burnEffectOnlineLog; // 0x38
		private static List<string> _burnEffectNameOnlineLog; // 0x40
		private bool _checkTowerFireHasLogged; // 0x1F9
		private bool _checkBurnEffectHasLogged; // 0x1FA
		private float BURN_EFFECT_INVALID_LIFE_TIME; // 0x1FC
	
		// Properties
		public string effectName { /* [XID] */ /* 0x00000001898684E0-0x0000000189868520 */ get; /* [XID] */ /* 0x00000001898728D0-0x0000000189872910 */ set; } // 0x00000001846B03A0-0x00000001846B0400 0x00000001846B0F30-0x00000001846B0F90
		public bool indexed { /* [XID] */ /* 0x000000018987D500-0x000000018987D540 */ get; /* [XID] */ /* 0x0000000189887520-0x0000000189887560 */ private set; } // 0x00000001846B0460-0x00000001846B04C0 0x00000001846A63E0-0x00000001846A6440
		public virtual bool isPlaceHolder { /* [XID] */ /* 0x0000000189891740-0x0000000189891760 */ get => default; } // 0x00000001846B0750-0x00000001846B07F0 
		public ulong prefabPathHash { /* [XID] */ /* 0x00000001898990B0-0x00000001898990D0 */ get => default; } // 0x00000001846B0D30-0x00000001846B0DD0 
		public bool isAlive { /* [XID] */ /* 0x00000001898A0270-0x00000001898A02B0 */ get; /* [XID] */ /* 0x00000001898AA800-0x00000001898AA840 */ private set; } // 0x00000001846B04C0-0x00000001846B0520 0x00000001846AE410-0x00000001846AE470
		public bool isEmitting { /* [XID] */ /* 0x00000001898B5130-0x00000001898B5170 */ get; /* [XID] */ /* 0x00000001898BFAA0-0x00000001898BFAE0 */ private set; } // 0x00000001846B0520-0x00000001846B0580 0x00000001846AC6F0-0x00000001846AC750
		public bool isToBeDeallocated { /* [XID] */ /* 0x00000001898CA320-0x00000001898CA340 */ get => default; /* [XID] */ /* 0x00000001898D1AD0-0x00000001898D1AF0 */ private set {} } // 0x00000001846B07F0-0x00000001846B0890 0x00000001846A36F0-0x00000001846A39B0
		public bool isMonoEnabled { /* [XID] */ /* 0x00000001898D9310-0x00000001898D9350 */ get; /* [XID] */ /* 0x00000001898E3E60-0x00000001898E3EA0 */ private set; } // 0x00000001846B06F0-0x00000001846B0750 0x00000001846AD5E0-0x00000001846AD640
		public float timeSinceInit { /* [XID] */ /* 0x00000001898EEAC0-0x00000001898EEAE0 */ get => default; } // 0x00000001846B0E80-0x00000001846B0F30 
		public bool isLastUsedTimeOverThreshold { /* [XID] */ /* 0x0000000189A50B00-0x0000000189A50B20 */ get => default; } // 0x00000001846B0580-0x00000001846B06F0 
		public BaseEntity level { /* [XID] */ /* 0x0000000189993DF0-0x0000000189993E30 */ get; /* [XID] */ /* 0x000000018999E7D0-0x000000018999E810 */ private set; } // 0x00000001846B0890-0x00000001846B08F0 0x00000001846A9760-0x00000001846A97D0
		public BaseEntity owner { /* [XID] */ /* 0x00000001899BF930-0x00000001899BF970 */ get; /* [XID] */ /* 0x00000001899C9EA0-0x00000001899C9EE0 */ private set; } // 0x00000001846B0C70-0x00000001846B0CD0 0x00000001846A8AD0-0x00000001846A8B40
		public bool ownerIsNullOrRecycled { /* [XID] */ /* 0x00000001899D4440-0x00000001899D4460 */ get => default; } // 0x00000001846B0B20-0x00000001846B0C70 
		public uint ownerID { get; /* [XID] */ /* 0x00000001899E34D0-0x00000001899E3510 */ private set; } // 0x00000001846B0AC0-0x00000001846B0B20 0x00000001846A6570-0x00000001846A65E0
		public float LevelTimeScale { /* [XID] */ /* 0x00000001899F3300-0x00000001899F3320 */ get => default; } // 0x00000001846B00D0-0x00000001846B0220 
		public float TimeScale { /* [XID] */ /* 0x0000000189A12EF0-0x0000000189A12F10 */ get => default; } // 0x00000001846B0220-0x00000001846B03A0 
		public int particleSystemCount { /* [XID] */ /* 0x0000000189A64DC0-0x0000000189A64E00 */ get; /* [XID] */ /* 0x0000000189A6F540-0x0000000189A6F580 */ private set; } // 0x00000001846B0CD0-0x00000001846B0D30 0x00000001846A2680-0x00000001846A26F0
		public float longestDurationOfParticleSystems { /* [XID] */ /* 0x0000000189A7A330-0x0000000189A7A370 */ get; /* [XID] */ /* 0x0000000189A848C0-0x0000000189A84900 */ private set; } // 0x00000001846B08F0-0x00000001846B0960 0x00000001846AD570-0x00000001846AD5E0
		public bool hasLoopParticle { /* [XID] */ /* 0x0000000189A8F1B0-0x0000000189A8F1F0 */ get; /* [XID] */ /* 0x0000000189A99B60-0x0000000189A99BA0 */ private set; } // 0x00000001846B0400-0x00000001846B0460 0x00000001846A59E0-0x00000001846A5A50
		public MonoEffectProxy proxyAttachedTo { /* [XID] */ /* 0x0000000189635950-0x0000000189635970 */ get => default; } // 0x00000001846B0DD0-0x00000001846B0E80 
		private static HashSet<ulong> towerFireOnlineLog { /* [XID] */ /* 0x0000000189680900-0x0000000189680920 */ get => default; } // 0x00000001846AB650-0x00000001846AB8F0 
		private static HashSet<ulong> burnEffectOnlineLog { /* [XID] */ /* 0x00000001896884A0-0x00000001896884C0 */ get => default; } // 0x00000001846A3C00-0x00000001846A3EA0 
		public bool needOnlineLog { /* [XID] */ /* 0x000000018968FD00-0x000000018968FD20 */ get => default; } // 0x00000001846B0960-0x00000001846B0AC0 
	
		// Nested types
		public enum StopEmitAction // TypeDefIndex: 19681
		{
			Ignore = 0,
			StopEmit = 1,
			StopEmitAndClearParticles = 2,
			StopEmitAndSetParticlesRemainingLifeTime = 3
		}
	
		public enum DisableAction // TypeDefIndex: 19682
		{
			Ignore = 0,
			Disable = 1,
			Deallocate = 2
		}
	
		// Constructors
		public MonoEffect() {} // 0x00000001846AFF00-0x00000001846B00D0
		static MonoEffect() {} // 0x00000001846AFC90-0x00000001846AFF00
	
		// Methods
		// [XID] // 0x00000001898FDAC0-0x00000001898FDAE0
		private void Awake() {} // 0x00000001846A35F0-0x00000001846A36F0
		// [XID] // 0x000000018992FFB0-0x000000018992FFD0
		public void InitEffect(bool indexed, BaseEntity owner, ulong prefabPathHash) {} // 0x00000001846A8F80-0x00000001846A91A0
		// [XID] // 0x000000018990CBD0-0x000000018990CBF0
		public void InitTransform(Vector3 initPos, Quaternion initRot, Vector3 initScale) {} // 0x00000001846A91A0-0x00000001846A95F0
		// [XID] // 0x00000001899142E0-0x0000000189914300
		private void InternalTick(float inGlobalTime, float inDeltaTime) {} // 0x00000001846AC300-0x00000001846AC610
		// [XID] // 0x000000018991BDE0-0x000000018991BE00
		public void Tick(float inGlobalTime, float inDeltaTime) {} // 0x00000001846AF9E0-0x00000001846AFC90
		// [XID] // 0x00000001899234A0-0x00000001899234C0
		private void InternalLateTick(float inDeltaTime) {} // 0x00000001846A3FF0-0x00000001846A40C0
		// [XID] // 0x000000018992ABE0-0x000000018992AC00
		public void LateTick(float inDeltaTime) {} // 0x00000001846AB080-0x00000001846AB310
		// [XID] // 0x00000001899736B0-0x00000001899736D0
		private void ClearEffect() {} // 0x00000001846A6100-0x00000001846A6260
		// [XID] // 0x0000000189939BD0-0x0000000189939BF0
		public void OnDealloc() {} // 0x00000001846AD6E0-0x00000001846AD7A0
		// [XID] // 0x0000000189940E00-0x0000000189940E20
		private void OnDestroy() {} // 0x00000001846AD7A0-0x00000001846AD890
		// [XID] // 0x0000000189948800-0x0000000189948820
		private void OnEnable() {} // 0x00000001846ADC70-0x00000001846AE050
		// [XID] // 0x000000018994FF90-0x000000018994FFB0
		private void OnDisable() {} // 0x00000001846AD890-0x00000001846ADC70
		// [XID] // 0x0000000189957580-0x00000001899575A0
		public virtual void SetEffectActive(bool active, bool checkOwner) {} // 0x00000001846AE650-0x00000001846AE7F0
		// [XID] // 0x000000018995EF90-0x000000018995EFB0
		public void SetEffectStop() {} // 0x00000001846AEC70-0x00000001846AED80
		// [XID] // 0x000000018994DD00-0x000000018994DD20
		public void SetEffectDeallocate() {} // 0x00000001846AE7F0-0x00000001846AE8A0
		// [XID] // 0x000000018996DC20-0x000000018996DC40
		public void SetGameObjectActive(bool active, bool changeRoot = false /* Metadata: 0x00AFCC66 */) {} // 0x00000001846AED80-0x00000001846AEF80
		// [XID] // 0x00000001899757F0-0x0000000189975810
		public string Dump() => default; // 0x00000001846A5A50-0x00000001846A6100
		// [XID] // 0x0000000189912090-0x00000001899120B0
		private void RefreshTickParticleStatusTime(float time) {} // 0x00000001846A5520-0x00000001846A55D0
		// [XID] // 0x0000000189984670-0x0000000189984690
		private bool CheckTickParticleStatus(float inGlobalTime, float inDeltaTime) => default; // 0x00000001846A84A0-0x00000001846A8590
		// [XID] // 0x000000018998C0D0-0x000000018998C0F0
		private float GetBalanceTickDeltaTime(float inDeltaTime) => default; // 0x00000001846AC750-0x00000001846AC8B0
		// [XID] // 0x000000018996BB80-0x000000018996BBA0
		private void InitLevel() {} // 0x00000001846AAC70-0x00000001846AAE10
		// [XID] // 0x00000001899B0AF0-0x00000001899B0B10
		private void ClearLevel() {} // 0x00000001846AC8B0-0x00000001846ACA40
		// [XID] // 0x00000001899B7DD0-0x00000001899B7DF0
		private void OnLevelDestroy(EvtEntityDestroy entity) {} // 0x00000001846A97D0-0x00000001846A99D0
		// [XID] // 0x0000000189955420-0x0000000189955440
		private void InitOwner(BaseEntity owner) {} // 0x00000001846A99D0-0x00000001846A9B70
		// [XID] // 0x00000001899F54D0-0x00000001899F54F0
		private void ClearOwner() {} // 0x00000001846A73C0-0x00000001846A75E0
		// [XID] // 0x00000001899FCB70-0x00000001899FCB90
		private void OnOwnerDestroy(EvtEntityDestroy evt) {} // 0x00000001846AA8A0-0x00000001846AA970
		// [XID] // 0x0000000189A04020-0x0000000189A04040
		private void OnOwnerActiveChange(EvtEntityActiveChange evt) {} // 0x00000001846AB8F0-0x00000001846AB9D0
		// [XID] // 0x0000000189A1A270-0x0000000189A1A290
		private void InitTimeScale() {} // 0x00000001846A57A0-0x00000001846A59E0
		// [XID] // 0x0000000189A21830-0x0000000189A21850
		private void ClearTimeScale() {} // 0x00000001846AAE10-0x00000001846AB080
		// [XID] // 0x0000000189A28DC0-0x0000000189A28DE0
		private void OnSystemTimeScaleChange(float timeScale) {} // 0x00000001846AC610-0x00000001846AC6F0
		// [XID] // 0x0000000189A30470-0x0000000189A30490
		private void OnLevelTimeScaleChange(EvtEntityTimeScaleChange evt) {} // 0x00000001846AD230-0x00000001846AD3A0
		// [XID] // 0x0000000189A37E90-0x0000000189A37EB0
		private void OnOwnerTimeScaleChange(EvtEntityTimeScaleChange evt) {} // 0x00000001846A6260-0x00000001846A63E0
		// [XID] // 0x0000000189A3F5E0-0x0000000189A3F600
		public void OnTimeScaleChange(float timeScale, float playSpeed) {} // 0x00000001846AE050-0x00000001846AE1A0
		// [XID] // 0x0000000189A46C10-0x0000000189A46C30
		private void InitDurationTimer() {} // 0x00000001846A8B40-0x00000001846A8CA0
		// [XID] // 0x0000000189A4E430-0x0000000189A4E450
		private void ClearDurationTimer() {} // 0x00000001846A31F0-0x00000001846A32A0
		// [XID] // 0x0000000189A55C60-0x0000000189A55C80
		private void OnDurationTimeScaleChange(float timeScale) {} // 0x00000001846ACF90-0x00000001846AD050
		// [XID] // 0x0000000189A18150-0x0000000189A18170
		private bool OnDurationTimeOut() => default; // 0x00000001846A96B0-0x00000001846A9760
		// [XID] // 0x0000000189AA3EA0-0x0000000189AA3EC0
		private void BuildParticles() {} // 0x00000001846A2F60-0x00000001846A3010
		// [XID] // 0x0000000189AAB370-0x0000000189AAB390
		private void BuildParticleSystemInfo() {} // 0x00000001846A26F0-0x00000001846A2B90
		// [XID] // 0x0000000189A1F7D0-0x0000000189A1F7F0
		private void InitParticles() {} // 0x00000001846AA360-0x00000001846AA8A0
		// [XID] // 0x0000000189ABCE90-0x0000000189ABCEB0
		public void ClearParticles() {} // 0x00000001846A49A0-0x00000001846A4F20
		// [XID] // 0x000000018985E870-0x000000018985E890
		private void EnableParticles() {} // 0x00000001846A32A0-0x00000001846A33C0
		// [XID] // 0x0000000189AC98E0-0x0000000189AC9900
		private void DisableParticles() {} // 0x00000001846A80F0-0x00000001846A8210
		// [XID] // 0x0000000189AD11B0-0x0000000189AD11D0
		private void UpdateParticleStatus() {} // 0x00000001846A8CA0-0x00000001846A8F80
		// [XID] // 0x00000001899FAA50-0x00000001899FAA70
		private void SetParticlePlaySpeed(float speed) {} // 0x00000001846ACE60-0x00000001846ACF90
		// [XID] // 0x0000000189AE0A80-0x0000000189AE0AA0
		public ParticleSystem[] GetAllParticleSystems() => default; // 0x00000001846A7E30-0x00000001846A7EE0
		// [XID] // 0x0000000189AE7F30-0x0000000189AE7F50
		private void BuildAnims() {} // 0x00000001846A2D80-0x00000001846A2F60
		// [XID] // 0x00000001899D0E10-0x00000001899D0E30
		private void InitAnims() {} // 0x00000001846AE1A0-0x00000001846AE410
		// [XID] // 0x0000000189AA64C0-0x0000000189AA64E0
		private void ClearAnims() {} // 0x00000001846A6AD0-0x00000001846A6CE0
		// [XID] // 0x0000000189AFE890-0x0000000189AFE8B0
		private void EnableAnims() {} // 0x00000001846A40C0-0x00000001846A4660
		// [XID] // 0x0000000189B06140-0x0000000189B06160
		private void DisableAnims() {} // 0x00000001846ABCF0-0x00000001846ABEC0
		// [XID] // 0x0000000189B0D8D0-0x0000000189B0D8F0
		private void SetAnimPlaySpeed(float speed) {} // 0x00000001846A65E0-0x00000001846A6900
		// [XID] // 0x0000000189B14D10-0x0000000189B14D30
		public Animation[] GetAllAnimations() => default; // 0x00000001846A7C20-0x00000001846A7CD0
		// [XID] // 0x0000000189B1C690-0x0000000189B1C6B0
		public Animator[] GetAllAnimators() => default; // 0x00000001846A7CD0-0x00000001846A7D80
		// [XID] // 0x0000000189B23BA0-0x0000000189B23BC0
		private void BuildMonos() {} // 0x00000001846AB9D0-0x00000001846ABBB0
		// [XID] // 0x000000018986D880-0x000000018986D8A0
		private void EnableMonos() {} // 0x00000001846A2B90-0x00000001846A2D80
		// [XID] // 0x0000000189B324A0-0x0000000189B324C0
		private void DisableMonos() {} // 0x00000001846A5330-0x00000001846A5520
		// [XID] // 0x0000000189B39D50-0x0000000189B39D70
		private void BuildRenders() {} // 0x00000001846A8590-0x00000001846A8AD0
		// [XID] // 0x00000001895ECE60-0x00000001895ECE80
		private void InitRenders() {} // 0x00000001846AD640-0x00000001846AD6E0
		// [XID] // 0x0000000189ACBF00-0x0000000189ACBF20
		private void ClearRenders() {} // 0x00000001846A8360-0x00000001846A8400
		// [XID] // 0x0000000189874CD0-0x0000000189874CF0
		private void EnableRenders() {} // 0x00000001846A3EA0-0x00000001846A3FF0
		// [XID] // 0x0000000189B57F80-0x0000000189B57FA0
		private void DisableRenders() {} // 0x00000001846A8210-0x00000001846A8360
		// [XID] // 0x0000000189B5F900-0x0000000189B5F920
		private void ShowRenders(bool active) {} // 0x00000001846A6F90-0x00000001846A73C0
		// [XID] // 0x0000000189B67030-0x0000000189B67050
		private bool UseZTest() => default; // 0x00000001846AA970-0x00000001846AAAA0
		// [XID] // 0x0000000189B6E260-0x0000000189B6E280
		public void SetMaterialFloat(int propID, float value) {} // 0x00000001846AEF80-0x00000001846AF100
		// [XID] // 0x0000000189B75AF0-0x0000000189B75B10
		private void InitAllMeshRendererInitEnables() {} // 0x00000001846A50C0-0x00000001846A5330
		// [XID] // 0x0000000189B7CEE0-0x0000000189B7CF00
		private void BuildEffectPlugin() {} // 0x00000001846A75E0-0x00000001846A7C20
		// [XID] // 0x00000001899D8250-0x00000001899D8270
		private void InitEffectPlugin() {} // 0x00000001846ACA40-0x00000001846ACC90
		// [XID] // 0x0000000189B8BBE0-0x0000000189B8BC00
		private void ClearEffectPlugin() {} // 0x00000001846A39B0-0x00000001846A3C00
		// [XID] // 0x0000000189B933D0-0x0000000189B933F0
		private void EnableEffectPlugin() {} // 0x00000001846AD3A0-0x00000001846AD570
		// [XID] // 0x00000001898EC660-0x00000001898EC680
		private void DisableEffectPlugin() {} // 0x00000001846A6900-0x00000001846A6AD0
		// [XID] // 0x0000000189BA2050-0x0000000189BA2070
		private void TickEffectPlugin(float inDeltaTime) {} // 0x00000001846AD050-0x00000001846AD230
		// [XID] // 0x0000000189BA94A0-0x0000000189BA94C0
		private void LateTickEffectPlugin(float inDeltaTime) {} // 0x00000001846A6CE0-0x00000001846A6EC0
		// [XID] // 0x0000000189BB0C70-0x0000000189BB0C90
		private void CheckEffectPluginDeallocate() {} // 0x00000001846A3010-0x00000001846A31F0
		// [XID] // 0x0000000189BB7E60-0x0000000189BB7E80
		private void DestroyEffectPlugin() {} // 0x00000001846A55D0-0x00000001846A57A0
		// [XID] // 0x0000000189BBF5D0-0x0000000189BBF5F0
		private void DeallocEffectPlugin() {} // 0x00000001846AAAA0-0x00000001846AAC70
		// [XID] // 0x0000000189BC7220-0x0000000189BC7240
		private void StopEffectPlugin() {} // 0x00000001846ACC90-0x00000001846ACE60
		// [XID] // 0x0000000189BCEEA0-0x0000000189BCEEC0
		private void SetEffectPluginEmittingStopped() {} // 0x00000001846A24B0-0x00000001846A2680
		// [XID] // 0x0000000189BD62A0-0x0000000189BD62C0
		public void SetEffectPluginTarget(Vector3 targetPos, BaseEntity targetEntity, Transform targetTransform, Vector3 targetDir) {} // 0x00000001846AE8A0-0x00000001846AEC70
		// [XID] // 0x0000000189BDDD80-0x0000000189BDDDA0
		public BaseMonoEffectPlugin[] GetAllEffectPlugins() => default; // 0x00000001846A7D80-0x00000001846A7E30
		// [XID] // 0x00000001895EAA50-0x00000001895EAA70
		public List<BaseMonoEffectPlugin> GetTickEffectPlugins() => default; // 0x00000001846A8040-0x00000001846A80F0
		// [XID] // 0x00000001895F1E70-0x00000001895F1E90
		public List<BaseMonoEffectPlugin> GetLateTickEffectPlugins() => default; // 0x00000001846A7F90-0x00000001846A8040
		// [XID] // 0x00000001895F97E0-0x00000001895F9800
		public List<MonoEffectPluginAnimatorPose> GetAnimatorPosePlugins() => default; // 0x00000001846A7EE0-0x00000001846A7F90
		// [XID] // 0x0000000189600F60-0x0000000189600F80
		private void BuildTickable() {} // 0x00000001846A95F0-0x00000001846A96B0
		// [XID] // 0x00000001898D57B0-0x00000001898D57D0
		private void EnableTickable() {} // 0x00000001846AE470-0x00000001846AE5B0
		// [XID] // 0x0000000189610050-0x0000000189610070
		private void DisableTickable() {} // 0x00000001846ABBB0-0x00000001846ABCF0
		// [XID] // 0x0000000189617310-0x0000000189617330
		private void InitVisible() {} // 0x00000001846A4FE0-0x00000001846A50C0
		// [XID] // 0x00000001899465E0-0x0000000189946600
		public void SetVisible(bool enable) {} // 0x00000001846AF670-0x00000001846AF790
		public void AddEventListener<T>(Action<T> action)
			where T : class, IDispatchableEvent {}
		public void RemoveEventListener<T>(Action<T> action)
			where T : class, IDispatchableEvent {}
		// [XID] // 0x0000000189626310-0x0000000189626330
		public void FireEventToDispatch(BaseEvent args) {} // 0x00000001846A6EC0-0x00000001846A6F90
		// [XID] // 0x000000018980D6A0-0x000000018980D6C0
		public void AttacheToProxy(MonoEffectProxy proxyAttachedTo) {} // 0x00000001846A3540-0x00000001846A35F0
		// [XID] // 0x000000018963D010-0x000000018963D030
		private void InitProxy() {} // 0x00000001846AE5B0-0x00000001846AE650
		// [XID] // 0x00000001896445D0-0x00000001896445F0
		public void SetMonoEffectPluginAnimatorPose(bool effectNameEmpty, string effectName, string parameter, AnimatorParamType type, int value) {} // 0x00000001846AF2B0-0x00000001846AF670
		// [XID] // 0x000000018964BE10-0x000000018964BE30
		public void SetMonoEffectAnimatorParamFloat(string effectName, int id, float value) {} // 0x00000001846AF100-0x00000001846AF2B0
		// [XID] // 0x0000000189653480-0x00000001896534A0
		public void ApplyEffectArgsTemplate(int templateID) {} // 0x00000001846A33C0-0x00000001846A3540
		// [XID] // 0x000000018965AC90-0x000000018965ACB0
		public void ChangeFollowDampTime(bool effectNameEmpty, string effectName, float positionDampTime, float rotationDampTime) {} // 0x00000001846A4660-0x00000001846A49A0
		// [XID] // 0x00000001896621A0-0x00000001896621C0
		public void EmitSubEmitterParticlesWithSpcifyPosition(Vector3 position) {} // 0x00000001846A6440-0x00000001846A6570
		// [XID] // 0x0000000189669D60-0x0000000189669D80
		public void ClearSubEmitter() {} // 0x00000001846A4F20-0x00000001846A4FE0
		// [XID] // 0x0000000189671A00-0x0000000189671A20
		private void LateTickSubEmitter() {} // 0x00000001846AB310-0x00000001846AB650
		// [XID] // 0x00000001896791D0-0x00000001896791F0
		public bool ShiftWorld(Vector3 newShift, Vector3 oldShift) => default; // 0x00000001846AF790-0x00000001846AF9E0
		// [XID] // 0x00000001896976C0-0x00000001896976E0
		private void InitOnlineLog() {} // 0x00000001846A8400-0x00000001846A84A0
		// [XID] // 0x000000018969EBB0-0x000000018969EBD0
		private void CheckTowerFireOnlineLog() {} // 0x00000001846ABEC0-0x00000001846AC300
		// [XID] // 0x00000001896A5E00-0x00000001896A5E20
		private void CheckBurnEffectOnlineLog() {} // 0x00000001846A9B70-0x00000001846AA360
	}
}
