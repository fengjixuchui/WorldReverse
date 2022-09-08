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
public class AITargetKnowledge : IAutoAllocRecycle // TypeDefIndex: 20003
{
	// Fields
	public AITargetType targetType; // 0x10
	public uint targetID; // 0x14
	public BaseEntity targetEntity; // 0x18
	public LCAvatarCombat targetAvatarCombat; // 0x20
	public ActorAbilityPlugin targetAbilityPlugin; // 0x28
	public Vector3 targetPosition; // 0x30
	public Vector3 targetForward; // 0x3C
	public Vector3 targetDirection; // 0x48
	public Vector3? targetLKP; // 0x54
	public float targetDistance; // 0x64
	public float targetDistanceXZ; // 0x68
	public float targetDistanceY; // 0x6C
	public float targetRelativeAngleYaw; // 0x70
	public float targetRelativeAnglePitch; // 0x74
	public bool targetInAir; // 0x78
	public bool targetKilled; // 0x79
	public bool isSelfAtTargetBack; // 0x7A
	public bool targetInDefendArea; // 0x7B
	public AITargetHasPathType hasPath; // 0x7C
	public float hasPathTick; // 0x80
	public bool hasLineOfSight; // 0x84
	public bool buddyOverride; // 0x85
	public float skillAnchorDistance; // 0x88
	public Vector3 skillAnchorPosition; // 0x8C
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	public List<AIPathfindDebugInfo> debugPathfindInfo; // 0x98

	// Constructors
	public AITargetKnowledge() {} // 0x0000000181A5C640-0x0000000181A5C7A0

	// Methods
	[BlackList] // 0x0000000189827AB0-0x0000000189827AF0
	// [XID] // 0x0000000189827AB0-0x0000000189827AF0
	public virtual void AutoAllocTypeFields() {} // 0x0000000181A5B820-0x0000000181A5B8F0
	[BlackList] // 0x0000000189831D80-0x0000000189831DC0
	// [XID] // 0x0000000189831D80-0x0000000189831DC0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181A5B8F0-0x0000000181A5BA50
	[BlackList] // 0x000000018983C510-0x000000018983C550
	// [XID] // 0x000000018983C510-0x000000018983C550
	public virtual void ReturnToObjectPool() {} // 0x0000000181A5C5A0-0x0000000181A5C640
	[BlackList] // 0x0000000189846A70-0x0000000189846AB0
	// [XID] // 0x0000000189846A70-0x0000000189846AB0
	public virtual void OnPoolAllocated() {} // 0x0000000181A5C430-0x0000000181A5C4D0
	[BlackList] // 0x0000000189850EF0-0x0000000189850F30
	// [XID] // 0x0000000189850EF0-0x0000000189850F30
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181A5C390-0x0000000181A5C430
	// [XID] // 0x000000018985B350-0x000000018985B370
	public void ReInitByConfigID(AITargetType clearType, AIKnowledge knowledge) {} // 0x0000000181A5C2A0-0x0000000181A5C390
	// [XID] // 0x00000001898628D0-0x00000001898628F0
	public void ClearTarget(AITargetType clearType) {} // 0x0000000181A5C120-0x0000000181A5C2A0
	// [XID] // 0x00000001896AE1B0-0x00000001896AE1D0
	private void SetEntityTargetInternal(uint newTargetID, LCAIBeta lcai, bool jobThread = false /* Metadata: 0x00AFD16E */) {} // 0x0000000181A5BB30-0x0000000181A5BEC0
	// [XID] // 0x0000000189A77BA0-0x0000000189A77BC0
	public void SetEntityTarget(AITargetSource targetSource, uint newTargetID, LCAIBeta lcai, bool jobThread = false /* Metadata: 0x00AFD16F */) {} // 0x0000000181A5C000-0x0000000181A5C120
	// [XID] // 0x00000001898789D0-0x00000001898789F0
	public void ReleaseTarget(AITargetSource targetSource, AIThreatKnowledge threatKnowledge, LCAIBeta lcai, bool jobThread = false /* Metadata: 0x00AFD170 */) {} // 0x0000000181A5BEC0-0x0000000181A5C000
	// [XID] // 0x000000018987FF80-0x000000018987FFA0
	public void SetPointTarget(Vector3 pos) {} // 0x0000000181A5C4D0-0x0000000181A5C5A0
	// [XID] // 0x0000000189A09580-0x0000000189A095A0
	public void SetHasPathToTarget(bool hasPathToTarget, float curretnTime) {} // 0x0000000181A5BA50-0x0000000181A5BB30
}

