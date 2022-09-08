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

public sealed class RotationTask : LocoBaseTask // TypeDefIndex: 20488
{
	// Fields
	private static readonly float TIMEOUT; // 0x00
	private float _timeoutTick; // 0x68
	private Vector3 _targetPosition; // 0x6C

	// Constructors
	public RotationTask() {} // 0x0000000183E13970-0x0000000183E13A00
	static RotationTask() {} // 0x0000000183E13910-0x0000000183E13970

	// Methods
	// [XID] // 0x0000000189763D00-0x0000000189763D20
	public override void Deallocate() {} // 0x0000000183E13320-0x0000000183E133C0
	// [XID] // 0x000000018976B4A0-0x000000018976B4C0
	public void Init(AIKnowledge knowledge, AILocomotionHandler.ParamRotation param) {} // 0x0000000183E13690-0x0000000183E137D0
	// [XID] // 0x0000000189772AA0-0x0000000189772AC0
	public override void UpdateLoco(AILocomotionHandler handler, AITransform currentTransform, ref LocoTaskState state, float deltaTime) {} // 0x0000000183E133C0-0x0000000183E13690
	// [XID] // 0x000000018977A260-0x000000018977A280
	public override void OnCloseTask(AILocomotionHandler handler) {} // 0x0000000183E137D0-0x0000000183E13890
}

