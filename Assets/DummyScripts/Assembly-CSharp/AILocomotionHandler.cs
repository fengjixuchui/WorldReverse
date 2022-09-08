/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class AILocomotionHandler // TypeDefIndex: 20471
{
	// Fields
	public AIKnowledge aiKnowledge; // 0x10
	public AIPathfinding pathfinder; // 0x18
	public LocoBaseTask currentTask; // 0x20
	public LocoTaskState currentState; // 0x28
	private float? _originalYawSpeed; // 0x2C

	// Nested types
	public struct ParamGoTo // TypeDefIndex: 20472
	{
		// Fields
		public bool scripted; // 0x00
		public Vector3 targetPosition; // 0x04
		public AIMoveSpeedLevel speedLevel; // 0x10
		public PathQueryTask pathQuery; // 0x18
		public LocoBaseTask.ObstacleHandling obstacleHandling; // 0x20
		public float cannedTurnSpeedOverride; // 0x24
		public bool delayStopping; // 0x28
		public bool spacial; // 0x29
		public bool spacialRoll; // 0x2A
		public NavMeshUseType useNavmesh; // 0x2C
		public bool exactlyMove; // 0x30

		// Nested types
		public enum NavMeshUseType // TypeDefIndex: 20473
		{
			Auto = 0,
			ForceUse = 1,
			NotUse = 2
		}
	}

	public struct ParamFacingMove // TypeDefIndex: 20474
	{
		// Fields
		public BaseEntity anchor; // 0x00
		public AIMoveSpeedLevel speedLevel; // 0x08
		public VCMoveData.MotionDirection movingDirection; // 0x0C
		public float duration; // 0x10
	}

	public struct ParamSurroundDash // TypeDefIndex: 20475
	{
		// Fields
		public BaseEntity anchorEntity; // 0x00
		public Vector3? anchorFixedPoint; // 0x08
		public AIMoveSpeedLevel speedLevel; // 0x18
		public float cannedTurnSpeedOverride; // 0x1C
		public bool spacial; // 0x20
		public bool spacialRoll; // 0x21
		public bool clockwise; // 0x22
		public bool reverseMoveDir; // 0x23
		public float radius; // 0x24
		public bool delayStopping; // 0x28
	}

	public struct ParamRotation // TypeDefIndex: 20476
	{
		// Fields
		public Vector3 targetPosition; // 0x00
	}

	public struct ParamFollowMove // TypeDefIndex: 20477
	{
		// Fields
		public BaseEntity anchor; // 0x00
		public bool useMeleeSlot; // 0x08
		public AIMoveSpeedLevel speedLevel; // 0x0C
		public float turnSpeed; // 0x10
		public float targetAngle; // 0x14
		public float stopDistance; // 0x18
	}

	// Constructors
	public AILocomotionHandler() {} // Dummy constructor
	public AILocomotionHandler(AIKnowledge knowledge, AIPathfinding pPathfinding) {} // 0x00000001816A1990-0x00000001816A1A20

	// Methods
	// [XID] // 0x0000000189605370-0x0000000189605390
	public void RefreshTask(Vector3 positoin) {} // 0x00000001816A0A70-0x00000001816A0B90
	// [XID] // 0x000000018960CDC0-0x000000018960CDE0
	public void UpdateTasks(AITransform currentTransform, float deltaTime) {} // 0x00000001816A1490-0x00000001816A1660
	// [XID] // 0x0000000189614350-0x0000000189614370
	private void CreateTask_Internal(LocoBaseTask task, bool delayStopping, float? movingYawSpeedOverride) {} // 0x00000001816A1090-0x00000001816A1270
	// [XID] // 0x000000018961BD90-0x000000018961BDB0
	public void CreateGoToTask(ParamGoTo param) {} // 0x00000001816A1660-0x00000001816A1870
	// [XID] // 0x00000001896232C0-0x00000001896232E0
	public void CreateFacingMoveTask(ParamFacingMove param) {} // 0x00000001816A1360-0x00000001816A1490
	// [XID] // 0x000000018962AB00-0x000000018962AB20
	public void CreateSurroundDashTask(ParamSurroundDash param) {} // 0x00000001816A0670-0x00000001816A07E0
	// [XID] // 0x0000000189632240-0x0000000189632260
	public void CreateRotationTask(ParamRotation param) {} // 0x00000001816A1870-0x00000001816A1990
	// [XID] // 0x0000000189639D30-0x0000000189639D50
	public void CreateSnakelickMove(ParamGoTo param) {} // 0x00000001816A07E0-0x00000001816A0A70
	// [XID] // 0x0000000189641240-0x0000000189641260
	public void CreateFollowMoveTask(ParamFollowMove param) {} // 0x00000001816A0520-0x00000001816A0670
	// [XID] // 0x0000000189648BC0-0x0000000189648BE0
	public bool TaskEnded() => default; // 0x000000018169FF10-0x000000018169FFC0
	// [XID] // 0x000000018994F3C0-0x000000018994F3E0
	public void ClearTask() {} // 0x00000001816A0260-0x00000001816A03D0
	// [XID] // 0x0000000189657B10-0x0000000189657B30
	public void FinishTask() {} // 0x00000001816A0CD0-0x00000001816A0D80
	// [XID] // 0x0000000189983D90-0x0000000189983DB0
	public void UpdateMotionFlag(AIMoveSpeedLevel newSpeed) {} // 0x00000001816A0E40-0x00000001816A0F70
	// [XID] // 0x0000000189666A30-0x0000000189666A50
	public void UpdateTaskSpeed(AIMoveSpeedLevel newSpeed) {} // 0x00000001816A0D80-0x00000001816A0E40
	// [XID] // 0x000000018966E0D0-0x000000018966E0F0
	public void SetGroundFollowAnimationRotation(bool enabled) {} // 0x00000001816A1270-0x00000001816A1360
	// [XID] // 0x0000000189675F60-0x0000000189675F80
	public void Teleport(Vector3 targetPosition) {} // 0x00000001816A0F70-0x00000001816A1090
	// [XID] // 0x000000018967D840-0x000000018967D860
	public void SwitchRotation(bool rotate) {} // 0x00000001816A0130-0x00000001816A0260
	// [XID] // 0x0000000189684DC0-0x0000000189684DE0
	public void SetForwardImmediately(Vector3 dir) {} // 0x000000018169FFC0-0x00000001816A0130
	// [XID] // 0x000000018968C920-0x000000018968C940
	public float GetDistanceToPathEnd(Vector3 currentPos) => default; // 0x00000001816A03D0-0x00000001816A0520
	// [XID] // 0x0000000189694450-0x0000000189694470
	public float GetAlmostReachedDistance() => default; // 0x00000001816A0B90-0x00000001816A0CD0
}

