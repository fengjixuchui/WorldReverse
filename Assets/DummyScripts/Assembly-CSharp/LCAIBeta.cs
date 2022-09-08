/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using IFix.Core;
using MoleMole;
using UnityEngine;
using UnityEngine.Scripting;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class LCAIBeta : LCBase // TypeDefIndex: 11686
{
	// Fields
	protected float _nextFrameTime; // 0x130
	protected LCAIBetaData _data; // 0x138
	protected ConfigAIBeta _config; // 0x140
	protected AIKnowledge _knowledge; // 0x148
	protected AIDecision _decision; // 0x150
	protected AIDecision _decisionOld; // 0x158
	protected AINerve _nerve; // 0x160
	protected AISensingUpdater _sensing; // 0x168
	protected AIAvoidanceUpdater _avoidanceUpdater; // 0x170
	protected AIPrecombatUpdater _precombatUpdater; // 0x178
	protected AIBuddyUpdater _buddyUpdater; // 0x180
	protected AIAreaUpdater _areaUpdater; // 0x188
	protected AIOrderUpdater _orderUpdater; // 0x190
	protected AIEquipUpdater _equipUpdater; // 0x198
	protected AIPathfinding _pathfinder; // 0x1A0
	protected AIThreatUpdater _threatUpdater; // 0x1A8
	protected AITargetUpdater _targetUpdater; // 0x1B0
	protected AIFlyUpdater _flyUpdater; // 0x1B8
	protected AITacticInfoUpdater _tacticInfoUpdater; // 0x1C0
	protected AISkillUpdater _skillUpdater; // 0x1C8
	protected AIMixinUpdater _mixinUpdater; // 0x1D0
	protected AIPoseControlUpdater _poseControlUpdater; // 0x1D8
	protected AIActionControl _actionController; // 0x1E0
	protected AIMoveControl _moveController; // 0x1E8
	protected AIParamControl _paramController; // 0x1F0
	private StringBuilder _reporterText; // 0x1F8
	private bool _ignoreCheckAIStuck; // 0x200
	public CallbackManager callbacks; // 0x208
	public Action<uint, uint> OnThreatTargetChanged; // 0x210
	public Action<ThreatLevel, ThreatLevel> OnThreatLevelChanged; // 0x218
	public Action<uint, bool> OnAvatarBecomeThreat; // 0x220
	public Action OnEnterCombat; // 0x228
	public Action<List<ThreatDebugLogInfo>> OnLeaveCombat; // 0x230
	public Action<uint> OnEntityAddThreatByTaunt; // 0x238
	public Action<uint, ConfigAICombatPhase> OnAICombatPhaseChanged; // 0x240
	public Action<uint> OnSetCombatAttackTarget; // 0x248
	public Action<AISoundInfo> OnHearingSound; // 0x250
	public Action<ScriptedMoveToInfo.ReachPointState, int> OnScriptedMoveEnded; // 0x258
	private EntityAiData _computeThreadData; // 0x260

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x00000001898F0DA0-0x00000001898F0DC0 */ get => default; } // 0x000000018200DE20-0x000000018200DEC0 

	// Nested types
	public class CallbackManager // TypeDefIndex: 11687
	{
		// Fields
		public List<CallbackInterface> awaitingCallbacks; // 0x10

		// Nested types
		public interface CallbackInterface // TypeDefIndex: 11688
		{
			// Methods
			void Execute();
		}

		public struct CallbackItem : CallbackInterface // TypeDefIndex: 11689
		{
			// Fields
			public Action action; // 0x00

			// Methods
			// [XID] // 0x00000001896814A0-0x00000001896814C0
			public void Execute() {} // 0x00000001820175E0-0x0000000182017660
		}

		public struct CallbackItem<T1> : CallbackInterface // TypeDefIndex: 11690
		{
			// Fields
			public Action<T1> action;
			public T1 param1;

			// Methods
			public void Execute() {}
		}

		public struct CallbackItem<T1, T2> : CallbackInterface // TypeDefIndex: 11691
		{
			// Fields
			public Action<T1, T2> action;
			public T1 param1;
			public T2 param2;

			// Methods
			public void Execute() {}
		}

		// Constructors
		public CallbackManager() {} // 0x00000001820174A0-0x00000001820175E0

		// Methods
		// [XID] // 0x000000018989F650-0x000000018989F670
		public void Register(CallbackInterface item, bool immediate = false /* Metadata: 0x00AEA6E2 */) {} // 0x00000001820173A0-0x00000001820174A0
		// [XID] // 0x00000001899E10A0-0x00000001899E10C0
		public void ExecuteAll() {} // 0x0000000182017230-0x00000001820173A0
	}

	// Constructors
	public LCAIBeta() {} // 0x000000018200DD40-0x000000018200DE20
	public LCAIBeta(LCAIBetaData data) {} // 0x000000018200DC90-0x000000018200DD40

	// Methods
	// [XID] // 0x00000001898F8760-0x00000001898F8780
	public override void Init() {} // 0x0000000182005370-0x0000000182005F10
	// [XID] // 0x00000001898FFFC0-0x00000001898FFFE0
	public override void ReInitByConfigID(BaseEntity.ReInitReason reason) {} // 0x000000018200C260-0x000000018200CB70
	// [XID] // 0x000000018993EF80-0x000000018993EFA0
	public void resetAIData(LCAIBetaData data) {} // 0x00000001820007E0-0x0000000182001100
	// [XID] // 0x000000018990F030-0x000000018990F050
	public override void ReInit(BaseEntity.ReInitReason reason) {} // 0x000000018200CB70-0x000000018200CFF0
	// [XID] // 0x00000001899168C0-0x00000001899168E0
	public override void PostReInit() {} // 0x000000018200C190-0x000000018200C260
	// [XID] // 0x0000000189742500-0x0000000189742520
	protected virtual void InitLevelDesign() {} // 0x000000018200BBE0-0x000000018200C190
	// [XID] // 0x00000001899259A0-0x00000001899259C0
	protected virtual void InitConfig() {} // 0x0000000182008800-0x000000018200A0E0
	// [XID] // 0x0000000189A88620-0x0000000189A88640
	protected virtual void InitPoseFSM() {} // 0x0000000182003DA0-0x0000000182003F10
	// [XID] // 0x0000000189934320-0x0000000189934340
	protected virtual void InitGizmos() {} // 0x0000000182001780-0x0000000182001820
	// [XID] // 0x000000018993C070-0x000000018993C090
	protected virtual void InitFinish() {} // 0x0000000182003FC0-0x00000001820041C0
	// [XID] // 0x0000000189943430-0x0000000189943450
	protected override void Tick(float inDeltaTime) {} // 0x000000018200CFF0-0x000000018200DC90
	// [XID] // 0x000000018994AB40-0x000000018994AB60
	private void UpdateAIStateSync() {} // 0x000000018200B1F0-0x000000018200B470
	// [XID] // 0x0000000189A70350-0x0000000189A70370
	protected virtual void UpdateMove(float deltaTime) {} // 0x0000000181FFE6A0-0x0000000181FFE7C0
	// [XID] // 0x00000001899599D0-0x00000001899599F0
	protected virtual void UpdateAction(float deltaTime) {} // 0x0000000182001440-0x0000000182001510
	// [XID] // 0x0000000189961310-0x0000000189961330
	protected virtual void UpdateAudio() {} // 0x0000000182007C90-0x0000000182007D80
	// [XID] // 0x0000000189A479B0-0x0000000189A479D0
	protected virtual void UpdateParamPose() {} // 0x0000000182007BE0-0x0000000182007C90
	// [XID] // 0x0000000189B9CD00-0x0000000189B9CD20
	protected virtual void UpdateParamAnimator() {} // 0x0000000182001310-0x00000001820013C0
	// [XID] // 0x00000001895F4520-0x00000001895F4540
	public override void OnEnable() {} // 0x000000018200B6A0-0x000000018200B760
	// [XID] // 0x0000000189698570-0x0000000189698590
	internal void ChangeAuthority() {} // 0x0000000182007A30-0x0000000182007BE0
	// [XID] // 0x00000001899868F0-0x0000000189986910
	private void ResumeTactic() {} // 0x00000001820081F0-0x0000000182008360
	// [XID] // 0x00000001899001D0-0x00000001899001F0
	public override void OnDisable() {} // 0x000000018200B5E0-0x000000018200B6A0
	// [XID] // 0x0000000189907880-0x00000001899078A0
	public void OnClientDisconnect() {} // 0x0000000182003360-0x0000000182003450
	// [XID] // 0x000000018999DA20-0x000000018999DA40
	public override void Clear(BaseEntity.ClearReason clearReason) {} // 0x0000000181FFD8B0-0x0000000181FFDDE0
	// [XID] // 0x00000001899A5360-0x00000001899A5380
	public override void Destroy() {} // 0x0000000181FFE820-0x0000000181FFEEC0
	// [XID] // 0x00000001895E85B0-0x00000001895E85D0
	protected virtual void UpdateCustomizedBeforeDecision() {} // 0x0000000182003580-0x0000000182003620
	// [XID] // 0x00000001899B4610-0x00000001899B4630
	protected static new EventID[] GetSelfListenEventIDsExcludingBase() => default; // 0x00000001820041C0-0x0000000182004290
	// [XID] // 0x00000001899BBAB0-0x00000001899BBAD0
	protected override bool ListenEvent(BaseEvent evt) => default; // 0x000000018200A0E0-0x000000018200A1D0
	// [XID] // 0x00000001896C5910-0x00000001896C5930
	protected static new EventID[] GetSelfOnEventIDsExcludingBase() => default; // 0x0000000182004290-0x0000000182004360
	// [XID] // 0x00000001899CAB60-0x00000001899CAB80
	protected override bool OnEvent(BaseEvent evt) => default; // 0x000000018200B870-0x000000018200B960
	// [XID] // 0x00000001896DBC40-0x00000001896DBC60
	public void HandleRemoteEvtBeingHit(BaseEvent evt) {} // 0x0000000181FFCB30-0x0000000181FFCC00
	// [XID] // 0x0000000189A71A30-0x0000000189A71A50
	protected void StateIDChanged(EvtStateIDChanged evt) {} // 0x00000001820039D0-0x0000000182003B30
	// [XID] // 0x00000001899E0E90-0x00000001899E0EB0
	protected void PoseIDChanged(int fromPose, int toPose) {} // 0x0000000181FFC3B0-0x0000000181FFCA60
	// [XID] // 0x00000001896F1850-0x00000001896F1870
	public static void ValidateConfig(BaseEntity entity, uint ownerID, ConfigAIBeta config) {} // 0x0000000182005190-0x0000000182005370
	// [XID] // 0x00000001899F01A0-0x00000001899F01C0
	private static int GetConfigHash(object obj) => default; // 0x000000018200A2F0-0x000000018200A410
	// [XID] // 0x0000000189B05530-0x0000000189B05550
	private static void OnConfigHashCalculated(uint ownerID, int hashValue, object data, uint uniqId) {} // 0x00000001820049B0-0x0000000182004B20
	// [XID] // 0x0000000189B52B00-0x0000000189B52B20
	protected virtual void UpdateAiStuckCheck(float deltaTime) {} // 0x0000000182001950-0x0000000182003360
	// [XID] // 0x0000000189A06700-0x0000000189A06720
	private void ParseSkillCastConditionInfo(AISkillInfo skillInfo, StringBuilder reporterText) {} // 0x0000000182005FC0-0x0000000182007870
	[Preserve] // 0x0000000189A0DC00-0x0000000189A0DC40
	// [XID] // 0x0000000189A0DC00-0x0000000189A0DC40
	public override string Dump() => default; // 0x0000000181FFEEC0-0x0000000182000420
	// [XID] // 0x0000000189A17FB0-0x0000000189A17FD0
	private void DumpThreatUnit(StringBuilder sb, ThreatInfo threadInfo, int index) {} // 0x0000000182004C30-0x0000000182004E30
	// [XID] // 0x0000000189A1F5B0-0x0000000189A1F5D0
	public void AcquireAuthority(Vector3? enterCombatPosition) {} // 0x0000000182001880-0x0000000182001950
	// [XID] // 0x00000001896816A0-0x00000001896816C0
	public bool NeedSyncAiInfo() => default; // 0x0000000181FFDDE0-0x0000000181FFDED0
	// [XID] // 0x0000000189A2E0A0-0x0000000189A2E0C0
	public void FillAiSyncInfo(AiSyncInfo info) {} // 0x0000000182007870-0x0000000182007980
	// [XID] // 0x0000000189A35A00-0x0000000189A35A20
	public void OnSyncAiInfo(AiSyncInfo info, float nowTime) {} // 0x000000018200BA00-0x000000018200BB20
	// [XID] // 0x0000000189A3CFB0-0x0000000189A3CFD0
	public AIKnowledge GetKnowledge() => default; // 0x0000000182004530-0x00000001820045E0
	// [XID] // 0x0000000189A44870-0x0000000189A44890
	public LCAIBetaData GetLevelCreationData() => default; // 0x000000018200A410-0x000000018200A4C0
	// [XID] // 0x0000000189A4BF70-0x0000000189A4BF90
	public AISensingKnowledge GetSensingKnowledge() => default; // 0x0000000182003B30-0x0000000182003BF0
	// [XID] // 0x0000000189A53690-0x0000000189A536B0
	public AISkillKnowledge GetSkillKnowledge() => default; // 0x0000000181FFE5E0-0x0000000181FFE6A0
	// [XID] // 0x0000000189A5ADE0-0x0000000189A5AE00
	public AINetworkKnowledge GetNetworkKnowledge() => default; // 0x0000000182000720-0x00000001820007E0
	// [XID] // 0x0000000189A62640-0x0000000189A62660
	public AIOrderKnowledge GetOrderKnowledge() => default; // 0x0000000182004650-0x0000000182004710
	// [XID] // 0x0000000189A6A440-0x0000000189A6A460
	public AIDecision GetDecison() => default; // 0x0000000182008460-0x0000000182008510
	// [XID] // 0x0000000189A71850-0x0000000189A71870
	public AIDecision GetDecisonOld() => default; // 0x0000000182004480-0x0000000182004530
	// [XID] // 0x0000000189A79310-0x0000000189A79330
	public Vector3 GetPos() => default; // 0x000000018200A9F0-0x000000018200AB10
	// [XID] // 0x0000000189A80980-0x0000000189A809A0
	public Vector3 GetBornPos() => default; // 0x0000000182004360-0x0000000182004480
	// [XID] // 0x0000000189618230-0x0000000189618250
	public AITactic GetCurrentTactic() => default; // 0x000000018200AFA0-0x000000018200B050
	// [XID] // 0x000000018961FCF0-0x000000018961FD10
	public uint GetAIGroupID() => default; // 0x0000000182004B80-0x0000000182004C30
	// [XID] // 0x0000000189A97450-0x0000000189A97470
	public uint GetSceneID() => default; // 0x0000000182003450-0x0000000182003500
	// [XID] // 0x0000000189A9E850-0x0000000189A9E870
	public float GetTime() => default; // 0x0000000181FFD2C0-0x0000000181FFD380
	// [XID] // 0x0000000189AA6200-0x0000000189AA6220
	public AILocomotionHandler GetLocomotion() => default; // 0x000000018200B470-0x000000018200B530
	// [XID] // 0x0000000189A38C90-0x0000000189A38CB0
	public LCBaseCombat GetCombatComponent() => default; // 0x000000018200BB20-0x000000018200BBE0
	// [XID] // 0x0000000189AB5060-0x0000000189AB5080
	public AIActionControlState GetActionState() => default; // 0x000000018200A4C0-0x000000018200A580
	// [XID] // 0x00000001897AE490-0x00000001897AE4B0
	public AIPathfinding GetPathfinding() => default; // 0x000000018200B530-0x000000018200B5E0
	// [XID] // 0x0000000189AC4650-0x0000000189AC4670
	public AIFriendlinessLevel GetFriendliness() => default; // 0x0000000182007980-0x0000000182007A30
	// [XID] // 0x0000000189ACBCB0-0x0000000189ACBCD0
	public int GetCombatBGMLevel() => default; // 0x0000000182001200-0x0000000182001310
	// [XID] // 0x0000000189AD36B0-0x0000000189AD36D0
	public AIDebugKnowledge GetDebug() => default; // 0x000000018200B050-0x000000018200B110
	// [XID] // 0x0000000189ADB190-0x0000000189ADB1B0
	public void NeuronMute(NeuronName neuronName, bool enable) {} // 0x0000000181FFE3C0-0x0000000181FFE4F0
	// [XID] // 0x0000000189AE2860-0x0000000189AE2880
	public void NeuronStimulate(NeuronName neuronName, bool stimulate) {} // 0x0000000182005060-0x0000000182005190
	// [XID] // 0x0000000189AEA370-0x0000000189AEA390
	public void SetStealthy(bool enable) {} // 0x0000000182008130-0x00000001820081F0
	// [XID] // 0x0000000189AF1E90-0x0000000189AF1EB0
	public bool GetStealthy() => default; // 0x0000000181FFD200-0x0000000181FFD2C0
	// [XID] // 0x0000000189AF9880-0x0000000189AF98A0
	public bool ShowCombatIndicator() => default; // 0x0000000181FFE4F0-0x0000000181FFE5E0
	// [XID] // 0x0000000189B00C30-0x0000000189B00C50
	public bool HasAvoidance() => default; // 0x0000000182004F90-0x0000000182005060
	// [XID] // 0x0000000189B08290-0x0000000189B082B0
	public void SetOrderMaster(uint masterID) {} // 0x0000000182008360-0x0000000182008460
	// [XID] // 0x0000000189718B70-0x0000000189718B90
	public bool IsAlerted() => default; // 0x0000000181FFD7F0-0x0000000181FFD8B0
	// [XID] // 0x000000018979C7C0-0x000000018979C7E0
	public ThreatLevel GetThreatLevel() => default; // 0x0000000181FFE230-0x0000000181FFE2E0
	// [XID] // 0x0000000189B1E500-0x0000000189B1E520
	public TauntLevel GetResistTauntLevel() => default; // 0x0000000182007DF0-0x0000000182007EB0
	// [XID] // 0x00000001897BA950-0x00000001897BA970
	public Dictionary<uint, ThreatInfo> GetThreatAlertedList() => default; // 0x00000001820048D0-0x00000001820049B0
	// [XID] // 0x0000000189B2D130-0x0000000189B2D150
	public Dictionary<uint, ThreatInfo> GetThreatCandidateList() => default; // 0x0000000181FFE2E0-0x0000000181FFE3C0
	// [XID] // 0x0000000189A28320-0x0000000189A28340
	public BaseEntity GetCurrentTarget() => default; // 0x0000000182003840-0x0000000182003900
	// [XID] // 0x0000000189B3BEB0-0x0000000189B3BED0
	public uint GetCurrentTargetID() => default; // 0x0000000182004710-0x00000001820047D0
	// [XID] // 0x00000001897A2540-0x00000001897A2560
	public ThreatLevel GetThreatStatus(uint targetID, ref float temperature) => default; // 0x0000000182008510-0x0000000182008730
	// [XID] // 0x0000000189B4B0E0-0x0000000189B4B100
	public void AddThreat(uint runtimeID, Vector3 pos, ThreatAddReason reason, float threatValue) {} // 0x000000018200A7A0-0x000000018200A8E0
	// [XID] // 0x0000000189B52920-0x0000000189B52940
	public void ForceEnterCombat() {} // 0x0000000182003F10-0x0000000182003FC0
	// [XID] // 0x0000000189B5A340-0x0000000189B5A360
	public void SetResistTauntLevel(TauntLevel newResistLevel) {} // 0x000000018200AC50-0x000000018200AD20
	// [XID] // 0x00000001897F8B60-0x00000001897F8B80
	public void SetBroadcastRange(float range) {} // 0x000000018200A6D0-0x000000018200A7A0
	// [XID] // 0x0000000189B693D0-0x0000000189B693F0
	public void SetAIHitFeeling(bool value) {} // 0x0000000182003900-0x00000001820039D0
	// [XID] // 0x00000001899993F0-0x0000000189999410
	public void ForceLeaveCombat() {} // 0x0000000182005F10-0x0000000182005FC0
	// [XID] // 0x00000001899A0D10-0x00000001899A0D30
	public ConfigAICombatPhase GetCombatPhase() => default; // 0x0000000182003620-0x0000000182003700
	// [XID] // 0x00000001899A8640-0x00000001899A8660
	public ConfigAICombatRole GetCombatRole() => default; // 0x0000000181FFD5E0-0x0000000181FFD6D0
	// [XID] // 0x0000000189B86F30-0x0000000189B86F50
	public void SetCombatAttackTarget(uint targetRuntimeID) {} // 0x0000000182001660-0x0000000182001780
	// [XID] // 0x0000000189B8E0C0-0x0000000189B8E0E0
	public uint GetCombatAttackTargetID() => default; // 0x0000000182000420-0x0000000182000500
	// [XID] // 0x0000000189B95520-0x0000000189B95540
	public SimplePolygon? GetDefendArea() => default; // 0x0000000182004E30-0x0000000182004F90
	// [XID] // 0x0000000189B9CBB0-0x0000000189B9CBD0
	public void SetSkillCDAvailableNow(uint skillID) {} // 0x000000018200B110-0x000000018200B1F0
	// [XID] // 0x0000000189A10B90-0x0000000189A10BB0
	public void SetSkillGCD(float gcdVal) {} // 0x0000000181FFCA60-0x0000000181FFCB30
	// [XID] // 0x0000000189BAB870-0x0000000189BAB890
	public void ReTriggerSkillInitialCD(uint skillID) {} // 0x0000000181FFCDD0-0x0000000181FFCEB0
	// [XID] // 0x0000000189AC16A0-0x0000000189AC16C0
	public void SetSkillCDGlobalMultiplier(float multiplier) {} // 0x000000018200AD20-0x000000018200ADF0
	// [XID] // 0x0000000189BBA1C0-0x0000000189BBA1E0
	public void SetSkillAnchorPosition(Vector3 anchorPos) {} // 0x0000000182001510-0x0000000182001600
	// [XID] // 0x000000018963DCB0-0x000000018963DCD0
	public VCGrassDisplacment GetGrassDispacement() => default; // 0x0000000181FFDED0-0x0000000181FFDF90
	// [XID] // 0x00000001899F6070-0x00000001899F6090
	public bool CheckActivateNoCollisionLOD(float avatarDistance) => default; // 0x0000000182008020-0x0000000182008130
	// [XID] // 0x0000000189AFDD30-0x0000000189AFDD50
	public void SetSurroundAnchor(Vector3? anchor) {} // 0x000000018200AB10-0x000000018200AC50
	// [XID] // 0x0000000189B31B50-0x0000000189B31B70
	public void SetTargetAbilityPoint(Vector3? point) {} // 0x0000000182003700-0x0000000182003840
	// [XID] // 0x0000000189B40C30-0x0000000189B40C50
	public void OnActionPointRemoved(LevelActionPoint point) {} // 0x0000000182003BF0-0x0000000182003DA0
	// [XID] // 0x00000001895ECC80-0x00000001895ECCA0
	public void SetPatrolLeader(LCAIBeta leader) {} // 0x0000000181FFD4C0-0x0000000181FFD5E0
	// [XID] // 0x00000001895F42D0-0x00000001895F42F0
	public bool ReceiveCommand(int commandID, float commandDuration) => default; // 0x0000000182007EB0-0x0000000182007FC0
	// [XID] // 0x0000000189864C10-0x0000000189864C30
	public void SetScriptedMoveTo(List<Vector3> scriptedRoute, ScriptedMoveToInfo.ActionType actionType, bool needDynamicAvoidance = true /* Metadata: 0x00AEA6E0 */, bool exactlyMove = false /* Metadata: 0x00AEA6E1 */) {} // 0x0000000181FFDF90-0x0000000181FFE230
	// [XID] // 0x0000000189603240-0x0000000189603260
	public void SetScriptedMoveSpeed(AIMoveSpeedLevel speedLevel) {} // 0x000000018200AE60-0x000000018200AFA0
	// [XID] // 0x00000001899CF620-0x00000001899CF640
	public bool Is3D() => default; // 0x000000018200A8E0-0x000000018200A9F0
	// [XID] // 0x00000001899ECF20-0x00000001899ECF40
	public void SetScripted3D(bool value) {} // 0x0000000181FFD380-0x0000000181FFD4C0
	// [XID] // 0x0000000189898400-0x0000000189898420
	public void SetScriptedMoveEnded(ScriptedMoveToInfo.ReachPointState state, int middlePointIndex) {} // 0x0000000181FFD6D0-0x0000000181FFD7F0
	// [XID] // 0x0000000189620FD0-0x0000000189620FF0
	public void SetServerRoute(MonsterRoute route) {} // 0x000000018200A1D0-0x000000018200A2F0
	// [XID] // 0x0000000189628780-0x00000001896287A0
	public bool ProfilingShouldNoPause() => default; // 0x00000001820047D0-0x00000001820048D0
	// [IDTag] // 0x0000000189630090-0x00000001896300D0
	// [XID] // 0x0000000189630090-0x00000001896300D0
	public void CollectSnapshot(AISnapshotInfo snapshotCollection, float currentTime) {} // 0x0000000182000500-0x0000000182000610
	// [IDTag] // 0x000000018963AAB0-0x000000018963AAF0
	// [XID] // 0x000000018963AAB0-0x000000018963AAF0
	public void CollectSnapshot(AISnapshotInfoJson snapshotCollection, float currentTime) {} // 0x0000000182000610-0x0000000182000720
	// [XID] // 0x0000000189645080-0x00000001896450A0
	public void RecordHitAvatar(uint victimID) {} // 0x0000000182008730-0x0000000182008800
	// [XID] // 0x000000018964CB60-0x000000018964CB80
	private void PrepareData() {} // 0x0000000181FFCC00-0x0000000181FFCD60
	// [XID] // 0x0000000189741140-0x0000000189741160
	public override void OnEntityReady() {} // 0x000000018200B760-0x000000018200B870
	// [XID] // 0x000000018965B950-0x000000018965B970
	public override void OnSafeDispatch() {} // 0x000000018200B960-0x000000018200BA00
	// [XID] // 0x0000000189B05550-0x0000000189B05570
	protected void DestroyComputeThreadData() {} // 0x0000000182001100-0x0000000182001200
	// [XID] // 0x000000018966A870-0x000000018966A890
	public virtual void UpdateComputeThread(float deltaTime) {} // 0x0000000181FFCEB0-0x0000000181FFD200
}

