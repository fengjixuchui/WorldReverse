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

public abstract class LocoBaseTask // TypeDefIndex: 20478
{
	// Fields
	public bool delayStopping; // 0x10
	protected Vector3 _destination; // 0x14
	protected AIMoveSpeedLevel _speedLevel; // 0x20
	protected float _startTick; // 0x24
	protected ObstacleHandling _obstacleHandling; // 0x28
	protected AIKnowledge _aiKnowledge; // 0x30
	protected const float CHECKFAIL_PRE_TIME = 1.5f; // Metadata: 0x00AFDB22
	protected static readonly FailDetectionSystem[] CHECKFAIL; // 0x00
	protected Vector3? _prevPos; // 0x38
	protected AITimer _moveFailTimer; // 0x48
	protected float _distanceMoved; // 0x50
	protected Vector3? _moveFailStartPos; // 0x54
	protected bool _stopped; // 0x64
	protected DirectionLock _directionLock; // 0x65

	// Properties
	public bool stopped { /* [XID] */ /* 0x00000001896C79D0-0x00000001896C79F0 */ get; } // 0x00000001811F4660-0x00000001811F4720 

	// Nested types
	public enum ObstacleHandling // TypeDefIndex: 20479
	{
		KeepMoving = 0,
		Stop = 1,
		StopOnlyByPathEnd = 2,
		Teleport = 3
	}

	protected struct FailDetectionSystem // TypeDefIndex: 20480
	{
		// Fields
		public float CHECKFAIL_SPEED_RUNSTOP; // 0x00
		public float CHECKFAIL_SPEED_WALKSTOP; // 0x04
		public float CHECKFAIL_TIME; // 0x08

		// Constructors
		public FailDetectionSystem(float time, float walk, float run) {
			CHECKFAIL_SPEED_RUNSTOP = default;
			CHECKFAIL_SPEED_WALKSTOP = default;
			CHECKFAIL_TIME = default;
		} // 0x00000001811DDF30-0x00000001811DDF40
	}

	public struct DirectionLock // TypeDefIndex: 20481
	{
		// Fields
		public bool lockX; // 0x00
		public bool lockY; // 0x01
		public bool lockZ; // 0x02

		// Methods
		// [XID] // 0x00000001896EC7C0-0x00000001896EC7E0
		public Vector3 Apply(Vector3 origin) => default; // 0x0000000181203A70-0x0000000181203B00
	}

	// Constructors
	public LocoBaseTask() {} // 0x00000001811F55E0-0x00000001811F56A0
	static LocoBaseTask() {} // 0x00000001811F5420-0x00000001811F55E0

	// Methods
	public abstract void UpdateLoco(AILocomotionHandler handler, AITransform currentTransform, ref LocoTaskState state, float deltaTime);
	// [XID] // 0x000000018969BA10-0x000000018969BA30
	public virtual void UpdateLocoSpeed(AIMoveSpeedLevel speed) {} // 0x00000001811F5370-0x00000001811F5420
	// [XID] // 0x00000001895EFD40-0x00000001895EFD60
	public virtual Vector3 GetDestination() => default; // 0x00000001811F49D0-0x00000001811F4AB0
	// [XID] // 0x00000001896AA530-0x00000001896AA550
	public virtual bool NeedPathfinder() => default; // 0x00000001811F4B80-0x00000001811F4C20
	// [XID] // 0x00000001896B1430-0x00000001896B1450
	public virtual void OnCloseTask(AILocomotionHandler handler) {} // 0x00000001811F4920-0x00000001811F49D0
	public abstract void Deallocate();
	// [XID] // 0x00000001896B8ED0-0x00000001896B8EF0
	public virtual void ShowPath() {} // 0x00000001811F4720-0x00000001811F4800
	// [XID] // 0x00000001896C0210-0x00000001896C0230
	protected bool AllowCheckFail() => default; // 0x00000001811F45A0-0x00000001811F4660
	// [XID] // 0x00000001896CF2C0-0x00000001896CF2E0
	protected void Init(AIKnowledge knowledge) {} // 0x00000001811F4800-0x00000001811F4920
	// [XID] // 0x00000001896D6540-0x00000001896D6560
	protected bool UpdateStopping(Vector3 currentPos, AIMoveSpeedLevel speedLevel, int checkModelIndex) => default; // 0x00000001811F4CF0-0x00000001811F5370
	// [XID] // 0x00000001896DDC40-0x00000001896DDC60
	public virtual void SetDirectionLock(DirectionLock dl) {} // 0x00000001811F4C20-0x00000001811F4CF0
	// [XID] // 0x00000001896E5290-0x00000001896E52B0
	public virtual void RefreshTask(AILocomotionHandler handler, Vector3 positoin) {} // 0x00000001811F4AB0-0x00000001811F4B80
}

