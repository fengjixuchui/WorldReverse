/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898422C0-0x00000001898422E0
public class AIMoveControlState : IAutoAllocRecycle // TypeDefIndex: 19956
{
	// Fields
	public MoveInfoBase[] moveInfoGroup; // 0x10
	public MoveInfoBase curMoveInfo; // 0x18

	// Properties
	public ReturnToBornInfo returnToBornInfo { /* [XID] */ /* 0x0000000189A56720-0x0000000189A56740 */ get => default; } // 0x0000000182B3E3F0-0x0000000182B3E4D0 
	public WanderInfo wanderInfo { /* [XID] */ /* 0x00000001897C3210-0x00000001897C3230 */ get => default; } // 0x0000000182B3D330-0x0000000182B3D410 
	public FollowScriptedPathInfo followScriptedPathInfo { /* [XID] */ /* 0x00000001897CA9F0-0x00000001897CAA10 */ get => default; } // 0x0000000182B3D410-0x0000000182B3D4F0 
	public PatrolFollowInfo patrolFollowInfo { /* [XID] */ /* 0x00000001897D1FD0-0x00000001897D1FF0 */ get => default; } // 0x0000000182B3D910-0x0000000182B3D9F0 
	public FollowServerRouteInfo followServerRouteInfo { /* [XID] */ /* 0x00000001897D9E50-0x00000001897D9E70 */ get => default; } // 0x0000000182B3DB30-0x0000000182B3DC10 
	public CombatFollowMoveInfo followMoveInfo { /* [XID] */ /* 0x000000018975BB70-0x000000018975BB90 */ get => default; } // 0x0000000182B3D830-0x0000000182B3D910 
	public InvestigateInfo investigateInfo { /* [XID] */ /* 0x00000001897E8950-0x00000001897E8970 */ get => default; } // 0x0000000182B3E150-0x0000000182B3E230 
	public ReactActionPointInfo reactActionPointInfo { /* [XID] */ /* 0x00000001897F0520-0x00000001897F0540 */ get => default; } // 0x0000000182B3DF90-0x0000000182B3E070 
	public SkillPrepareInfo skillPrepareInfo { /* [XID] */ /* 0x00000001897F7C90-0x00000001897F7CB0 */ get => default; } // 0x0000000182B3DDD0-0x0000000182B3DEB0 
	public MeleeChargeInfo meleeChargeInfo { /* [XID] */ /* 0x00000001897FF310-0x00000001897FF330 */ get => default; } // 0x0000000182B3E4D0-0x0000000182B3E5B0 
	public FacingMoveInfo facingMoveInfo { /* [XID] */ /* 0x0000000189806AD0-0x0000000189806AF0 */ get => default; } // 0x0000000182B3D750-0x0000000182B3D830 
	public SurroundInfo surroundInfo { /* [XID] */ /* 0x000000018980E210-0x000000018980E230 */ get => default; } // 0x0000000182B3CFD0-0x0000000182B3D0B0 
	public FindBackInfo findBackInfo { /* [XID] */ /* 0x0000000189815970-0x0000000189815990 */ get => default; } // 0x0000000182B3DEB0-0x0000000182B3DF90 
	public FixedMoveInfo fixedMoveInfo { /* [XID] */ /* 0x0000000189947E10-0x0000000189947E30 */ get => default; } // 0x0000000182B3E070-0x0000000182B3E150 
	public CrabMoveInfo crabMoveInfo { /* [XID] */ /* 0x00000001898247A0-0x00000001898247C0 */ get => default; } // 0x0000000182B3E830-0x0000000182B3E910 
	public SpacialChaseInfo spacialChaseInfo { /* [XID] */ /* 0x000000018982C270-0x000000018982C290 */ get => default; } // 0x0000000182B3E750-0x0000000182B3E830 
	public SpacialProbeInfo spacialProbeInfo { /* [XID] */ /* 0x000000018967B4E0-0x000000018967B500 */ get => default; } // 0x0000000182B3D170-0x0000000182B3D250 
	public SpacialAdjustInfo spacialAdjustInfo { /* [XID] */ /* 0x000000018983AC40-0x000000018983AC60 */ get => default; } // 0x0000000182B3DC10-0x0000000182B3DCF0 
	public ScriptedMoveToInfo scriptedMoveToInfo { /* [XID] */ /* 0x00000001898422A0-0x00000001898422C0 */ get => default; } // 0x0000000182B3D250-0x0000000182B3D330 
	public LandingInfo landingInfo { /* [XID] */ /* 0x00000001898496C0-0x00000001898496E0 */ get => default; } // 0x0000000182B3D670-0x0000000182B3D750 
	public ExtractionInfo extractionInfo { /* [XID] */ /* 0x0000000189850F30-0x0000000189850F50 */ get => default; } // 0x0000000182B3E230-0x0000000182B3E310 
	public FleeInfo fleeInfo { /* [XID] */ /* 0x0000000189858380-0x00000001898583A0 */ get => default; } // 0x0000000182B3E670-0x0000000182B3E750 
	public BirdCirclingInfo birdCirclingInfo { /* [XID] */ /* 0x000000018985F3F0-0x000000018985F410 */ get => default; } // 0x0000000182B3E310-0x0000000182B3E3F0 
	public AutoPlayerSkillPrepareInfo autoPlayerSkillPrepareInfo { /* [XID] */ /* 0x0000000189866C10-0x0000000189866C30 */ get => default; } // 0x0000000182B3F740-0x0000000182B3F820 
	public AutoPlayerFollowTargetInfo autoPlayerFollowTargetInfo { /* [XID] */ /* 0x000000018986E4B0-0x000000018986E4D0 */ get => default; } // 0x0000000182B3CCA0-0x0000000182B3CD80 
	public BrownianMoveInfo brownianMotionInfo { /* [XID] */ /* 0x00000001898758E0-0x0000000189875900 */ get => default; } // 0x0000000182B3DCF0-0x0000000182B3DDD0 

	// Constructors
	public AIMoveControlState() {} // 0x0000000182B3F8C0-0x0000000182B3F920

	// Methods
	[BlackList] // 0x0000000189766D00-0x0000000189766D40
	// [XID] // 0x0000000189766D00-0x0000000189766D40
	public virtual void AutoAllocTypeFields() {} // 0x0000000182B3CE90-0x0000000182B3CF30
	[BlackList] // 0x0000000189771420-0x0000000189771460
	// [XID] // 0x0000000189771420-0x0000000189771460
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182B3CF30-0x0000000182B3CFD0
	[BlackList] // 0x000000018977B960-0x000000018977B9A0
	// [XID] // 0x000000018977B960-0x000000018977B9A0
	public virtual void ReturnToObjectPool() {} // 0x0000000182B3F820-0x0000000182B3F8C0
	// [XID] // 0x0000000189786380-0x00000001897863A0
	public virtual void OnPoolAllocated() {} // 0x0000000182B3EAB0-0x0000000182B3F740
	// [XID] // 0x000000018978D9D0-0x000000018978D9F0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182B3E910-0x0000000182B3EAB0
	// [XID] // 0x0000000189794EE0-0x0000000189794F00
	public void Clear() {} // 0x0000000182B3D9F0-0x0000000182B3DB30
	// [XID] // 0x0000000189965D10-0x0000000189965D30
	public void Goto(MoveDecision newDecision, AILocomotionHandler taskHandler, AIKnowledge aiKnowledge, LCAIManager aiManager) {} // 0x0000000182B3D4F0-0x0000000182B3D670
	// [XID] // 0x00000001897A4630-0x00000001897A4650
	public void UpdateMoveInfo(AILocomotionHandler taskHandler, AIKnowledge aiKnowledge, LCAIBeta lcai, LCAIManager aiManager) {} // 0x0000000182B3CD80-0x0000000182B3CE90
	// [XID] // 0x00000001897ABB40-0x00000001897ABB60
	public void OnPoseChanged() {} // 0x0000000182B3E5B0-0x0000000182B3E670
	// [XID] // 0x00000001897B3B60-0x00000001897B3B80
	public void OnLeaveCombat() {} // 0x0000000182B3D0B0-0x0000000182B3D170
}

