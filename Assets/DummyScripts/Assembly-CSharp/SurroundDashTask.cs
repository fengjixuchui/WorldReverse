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

public sealed class SurroundDashTask : LocoBaseTask // TypeDefIndex: 20487
{
	// Fields
	private BaseEntity _anchorEntity; // 0x68
	private Vector3? _anchorFixedPoint; // 0x70
	private bool _clockwise; // 0x80
	private bool _reverseMoveDir; // 0x81
	private float _surroundRadius; // 0x84
	private bool _spacial; // 0x88
	private bool _spacialRoll; // 0x89

	// Constructors
	public SurroundDashTask() {} // 0x000000018275B150-0x000000018275B1E0

	// Methods
	// [XID] // 0x000000018974DB10-0x000000018974DB30
	public override void Deallocate() {} // 0x000000018275A5E0-0x000000018275A680
	// [XID] // 0x0000000189755140-0x0000000189755160
	public void Init(AIKnowledge knowledge, AILocomotionHandler.ParamSurroundDash param) {} // 0x000000018275B010-0x000000018275B150
	// [XID] // 0x000000018975C310-0x000000018975C330
	public override void UpdateLoco(AILocomotionHandler handler, AITransform currentTransform, ref LocoTaskState state, float deltaTime) {} // 0x000000018275A680-0x000000018275B010
}

