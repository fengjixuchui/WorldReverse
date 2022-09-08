/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class AvatarMoveToTask // TypeDefIndex: 32040
{
	// Fields
	private Vector3 _targetPos; // 0x10
	private PathQueryTask _pathQuery; // 0x20
	private float _finishDistance; // 0x28
	private float _getCloseDistance; // 0x2C
	private float _stayCloseOverTime; // 0x30
	private float _enterCloseDistanceTime; // 0x34
	private bool _isInCloseDistance; // 0x38
	private float _failTime; // 0x3C
	private float _failOverTime; // 0x40
	private VCMoveData.MotionFlag _motionFlag; // 0x44
	private BaseEntity _entity; // 0x48
	private VCBaseInputController _inputController; // 0x50
	private MoveToTaskState _state; // 0x58

	// Properties
	public bool isMoving { /* [XID] */ /* 0x00000001896C5870-0x00000001896C5890 */ get => default; } // 0x0000000184506A10-0x0000000184506AC0 

	// Nested types
	private enum MoveToTaskState // TypeDefIndex: 32041
	{
		Stop = 0,
		Moving = 1,
		Finish = 2
	}

	// Constructors
	public AvatarMoveToTask() {} // 0x00000001845075C0-0x0000000184507660

	// Methods
	// [XID] // 0x0000000189B3C2B0-0x0000000189B3C2D0
	public void StartMoveToTask(Vector3 startPos, Vector3 targetPos, VCMoveData.MotionFlag motionFlag, uint entityRuntimeId) {} // 0x00000001845073B0-0x00000001845075C0
	// [XID] // 0x000000018967B380-0x000000018967B3A0
	private PathQueryTask CreatePathQueryTask(Vector3 startPos, Vector3 targetPos) => default; // 0x0000000184506B80-0x0000000184506E90
	// [XID] // 0x00000001896CCF00-0x00000001896CCF20
	public void UpdateMoveToTask(float deltaTime) {} // 0x0000000184506F70-0x00000001845073B0
	// [XID] // 0x0000000189B52C90-0x0000000189B52CB0
	private void SetState(MoveToTaskState state) {} // 0x0000000184506AC0-0x0000000184506B80
	// [XID] // 0x0000000189B5A680-0x0000000189B5A6A0
	public void Clear() {} // 0x0000000184506E90-0x0000000184506F70
}

