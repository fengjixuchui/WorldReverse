/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using UnityEngine;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class AIKnowledge : IAutoAllocRecycle // TypeDefIndex: 19954
{
	// Fields
	public float time; // 0x10
	public float aiBeginTime; // 0x14
	public BaseEntity aiOwnerEntity; // 0x18
	public uint runtimeID; // 0x20
	public uint campID; // 0x24
	public MonsterConfigIdentifier monsterConfigId; // 0x28
	public Vector3 bornPos; // 0x34
	public Vector3 currentPos; // 0x40
	public Vector3 currentForward; // 0x4C
	public Transform currentTransform; // 0x58
	public Vector3 eyePos; // 0x60
	public Transform eyeTransform; // 0x70
	public AIFriendlinessLevel friendliness; // 0x78
	public uint aiGroupID; // 0x7C
	public float temperature; // 0x80
	public ThreatLevel threatLevel; // 0x84
	public ThreatLevel threatLevelOld; // 0x88
	public Vector3? enterCombatPostion; // 0x8C
	public Vector3? enterCombatForward; // 0x9C
	public DecisionArchetype decisionArchetype; // 0xAC
	public AITactic currentTactic; // 0xB0
	public float currentTacticBeginTick; // 0xB4
	public bool tacticChanged; // 0xB8
	public bool moveDecisionChanged; // 0xB9
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	public AIMoveControlState moveControlState; // 0xC0
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	public AIActionControlState actionControlState; // 0xC8
	public int poseID; // 0xD0
	public bool stealthy; // 0xD4
	public float nearestAvatarDistance; // 0xD8
	public bool lodEnabled; // 0xDC
	public AILODLevel lodLevel; // 0xE0
	public LCAIManager aiManager; // 0xE8
	public VCBaseInputController aiInputController; // 0xF0
	public VCCharacterAudio audioComponent; // 0xF8
	public VCBaseMove moveComponent; // 0x100
	public VCGrassDisplacment grassDisplacement; // 0x108
	public LCBaseEquipController equipController; // 0x110
	public LCBaseCombat combatComponent; // 0x118
	public LCPose pose; // 0x120
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	public List<BrainModuleBase> modules; // 0x128
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	public AIMoveKnowledge moveKnowledge; // 0x130
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	public AIAvoidanceKnowledge avoidanceKnowledge; // 0x138
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	public AINerveKnowledge nerveKnowledge; // 0x140
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	public AIPrecombatKnowledge precombatKnowledge; // 0x148
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	public AICombatKnowledge combatKnowledge; // 0x150
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	public AIBuddyKnowledge buddyKnowledge; // 0x158
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	public AISensingKnowledge sensingKnowledge; // 0x160
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	public AITargetKnowledge targetKnowledge; // 0x168
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	public AIThreatKnowledge threatKnowledge; // 0x170
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	public AIOrderKnowledge orderKnowledge; // 0x178
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	public AIFlyKnowledge flyKnowledge; // 0x180
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	public AIDefendAreaKnowledge defendAreaKnowledge; // 0x188
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	public AIEquipmentKnowledge equipKnowledge; // 0x190
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	public AISkillKnowledge skillKnowledge; // 0x198
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	public AIUIKnowledge uiKnowledge; // 0x1A0
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	public AIProfilingKnowledge profilingKnowledge; // 0x1A8
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	public AISnapshotKnowledge snapshotKnowledge; // 0x1B0
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	public AINetworkKnowledge networkKnowledge; // 0x1B8
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	public AIPoseControlKnowledge poseControlKnowledge; // 0x1C0
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	public AIWaypointRoute route; // 0x1C8
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	public AIAutoPlayerKnowledge autoPlayerKnowledge; // 0x1D0
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	public AIMixinKnowledge mixinKnowledge; // 0x1D8
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	public AIDebugKnowledge debug; // 0x1E0
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	public AITacticKnowledge_ReturnToBorn returnToBornTactic; // 0x1E8
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	public AITacticKnowledge_Wander wanderTactic; // 0x1F0
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	public AITacticKnowledge_PatrolFollowPath patrolFollowTactic; // 0x1F8
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	public AITacticKnowledge_FollowScriptedPath followScriptedPathTactic; // 0x200
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	public AITacticKnowledge_FollowServerRoute followServerRouteTactic; // 0x208
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	public AITacticKnowledge_CombatFollowMove combatFollowMoveTactic; // 0x210
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	public AITacticKnowledge_Investigate investigateTactic; // 0x218
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	public AITacticKnowledge_ReactActionPoint reactActionPointTactic; // 0x220
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	public AITacticKnowledge_MeleeCharge meleeChargeTactic; // 0x228
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	public AITacticKnowledge_FacingMove facingMoveTactic; // 0x230
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	public AITacticKnowledge_Surround surroundTactic; // 0x238
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	public AITacticKnowledge_FindBack findBackTactic; // 0x240
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	public AITacticKnowledge_CombatFixedMove combatFixedMoveTactic; // 0x248
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	public AITacticKnowledge_CrabMove crabMoveTactic; // 0x250
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	public AITacticKnowledge_Flee fleeTactic; // 0x258
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	public AITacticKnowledge_SpacialChase spacialChaseTactic; // 0x260
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	public AITacticKnowledge_SpacialProbe spacialProbeTactic; // 0x268
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	public AITacticKnowledge_SpacialAdjust spacialAdjustTactic; // 0x270
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	public AITacticKnowledge_ScriptedMoveTo scriptedMoveToTactic; // 0x278
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	public AITacticKnowledge_Landing landingTactic; // 0x280
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	public AITacticKnowledge_Extraction extractionTactic; // 0x288
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	public AITacticKnowledge_BirdCircling birdCirclingTactic; // 0x290
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	public AITacticKnowledge_BrownianMotion brownianMotionTactic; // 0x298

	// Properties
	public uint sceneID { /* [XID] */ /* 0x00000001896F7070-0x00000001896F7090 */ get => default; } // 0x000000018425DC80-0x000000018425DD30 

	// Constructors
	public AIKnowledge() {} // 0x000000018425F870-0x000000018425F940

	// Methods
	[BlackList] // 0x00000001896C3280-0x00000001896C32C0
	// [XID] // 0x00000001896C3280-0x00000001896C32C0
	public virtual void AutoAllocTypeFields() {} // 0x000000018425D1D0-0x000000018425D690
	[BlackList] // 0x00000001896CD990-0x00000001896CD9D0
	// [XID] // 0x00000001896CD990-0x00000001896CD9D0
	public virtual void AutoRecycleTypeFields() {} // 0x000000018425D690-0x000000018425DC80
	[BlackList] // 0x00000001896D7DB0-0x00000001896D7DF0
	// [XID] // 0x00000001896D7DB0-0x00000001896D7DF0
	public virtual void ReturnToObjectPool() {} // 0x000000018425F7D0-0x000000018425F870
	[BlackList] // 0x00000001896E26A0-0x00000001896E26E0
	// [XID] // 0x00000001896E26A0-0x00000001896E26E0
	public virtual void OnPoolAllocated() {} // 0x000000018425F730-0x000000018425F7D0
	[BlackList] // 0x00000001896EC840-0x00000001896EC880
	// [XID] // 0x00000001896EC840-0x00000001896EC880
	public virtual void OnBeforePoolRecycled() {} // 0x000000018425F690-0x000000018425F730
	// [XID] // 0x00000001896FEA20-0x00000001896FEA40
	public void InitKnowledge(BaseEntity aiEntity, LCAIBetaData aiCreationData) {} // 0x000000018425DF60-0x000000018425E950
	// [XID] // 0x0000000189890E80-0x0000000189890EA0
	internal void RecoverFromServer(LCAIBetaData data) {} // 0x000000018425DE30-0x000000018425DF60
	// [XID] // 0x000000018970D690-0x000000018970D6B0
	internal void Clear(BaseEntity.ClearReason reason) {} // 0x000000018425DD30-0x000000018425DE30
	// [XID] // 0x00000001896AB200-0x00000001896AB220
	internal void ReInitByConfigID(BaseEntity.ReInitReason reason, ConfigAIBeta config, LCAIBetaData aiCreationData) {} // 0x000000018425E950-0x000000018425F690
}

